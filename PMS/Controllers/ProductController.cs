using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PMS.Models;
using PMS.Repositories.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHelperRepository helperRepository;
        private readonly IProductRepository productRepository;

        public ProductController(IHelperRepository _helperRepository,
                                IProductRepository _productRepository)
        {
            helperRepository = _helperRepository;
            productRepository = _productRepository;
        }


        // GET: ProductController
        public ActionResult Index()
        {
            var products = productRepository.GetAllProducts();
            return View(products);
        }

        public ActionResult ProductsByCategory(long category)
        {
            var products = productRepository.GetAllProducts().Where(x => x.CategoryId == category).ToList();
            return View("Index", products);
        }

        public ActionResult ProductsByManufacturer(long manu)
        {
            var products = productRepository.GetAllProducts().Where(x => x.ManufacturerId == manu).ToList();
            return View("Index", products);
        }

        //For DropDown To Fill on Load Trigger 
        [HttpPost]
        public JsonResult GetManufacturer()
        {
            var ManufacturerList = new SelectList(helperRepository.GetManufacturers(), "Id", "Name");
            return Json(ManufacturerList);
        }

        //For DropDown To Fill on Load Trigger 
        [HttpPost]
        public JsonResult GetCategory()
        {
            var Category = new SelectList(helperRepository.GetCategory(), "Id", "Name");
            return Json(Category);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(long id, long unitId = 0)
        {
            var productDetails = productRepository.GetProductDetails(id);

            if (unitId > 0)
            {
                ViewBag.UnitName = helperRepository.GetUnit().FirstOrDefault(x => x.Id == unitId).Name;
                productDetails = productRepository.GetProductDetails(id, unitId);
            }
            else
            {
                ViewBag.UnitName = "kg - کیلو ګرام";
            }

            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");


            return View(productDetails);
        }


        public ActionResult BatchDetails(long id)
        {
            var batches = productRepository.GetAllProductBatches(id);
            return PartialView("_BatchDetailsPartials", batches);
        }

        public ActionResult UnitDetails(long id)
        {
            var units = productRepository.GetAllProductUnits(id);
            return PartialView("_UnitDetailsPartials", units);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.Category = new SelectList(helperRepository.GetCategory(), "Id", "Name");
            ViewBag.Unit = helperRepository.GetUnit();
            ViewBag.Manufacturers = new SelectList(helperRepository.GetManufacturers(), "Id", "Name");

            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product, long[] UnitId, decimal[] UnitSellPrice)
        {
            ViewBag.Category = new SelectList(helperRepository.GetCategory(), "Id", "Name");
            ViewBag.Unit = helperRepository.GetUnit();
            ViewBag.Manufacturers = new SelectList(helperRepository.GetManufacturers(), "Id", "Name");

            if (ModelState.IsValid)
            {
                //try
                //{
                if (UnitId.Length > 0)
                {
                    List<ProductUnit> list = new List<ProductUnit>();

                    for (int i = 0; i < UnitId.Length; i++)
                    {
                        ProductUnit unit = new ProductUnit
                        {
                            UnitId = UnitId[i],
                            UnitSellPrice = UnitSellPrice[i]
                        };
                        list.Add(unit);
                    }

                    var res = productRepository.AddProduct(product, list);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(product);
                    }
                }
                else
                {
                    helperRepository.InfoMessage("Please specify unit details!");
                    return View(product);
                }
                //}
                //catch
                //{
                //    helperRepository.ErrorMessage();
                //    return View(product);
                //}
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(product);
            }

        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(long id)
        {
            ViewBag.Category = new SelectList(helperRepository.GetCategory(), "Id", "Name");
            ViewBag.Unit = helperRepository.GetUnit();
            ViewBag.Manufacturers = new SelectList(helperRepository.GetManufacturers(), "Id", "Name");

            var units = productRepository.GetAllProductUnits(id);
            ViewBag.OldUnits = units;

            var product = productRepository.GetByIdForUpdate(id);
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product, long[] UnitId, decimal[] UnitSellPrice)
        {
            ViewBag.Category = new SelectList(helperRepository.GetCategory(), "Id", "Name");
            ViewBag.Unit = helperRepository.GetUnit();
            ViewBag.Manufacturers = new SelectList(helperRepository.GetManufacturers(), "Id", "Name");

            if (ModelState.IsValid)
            {
                try
                {
                    if (UnitId.Length > 0)
                    {
                        List<ProductUnit> list = new List<ProductUnit>();

                        for (int i = 0; i < UnitId.Length; i++)
                        {
                            ProductUnit unit = new ProductUnit
                            {
                                UnitId = UnitId[i],
                                UnitSellPrice = UnitSellPrice[i]
                            };
                            list.Add(unit);
                        }

                        var res = productRepository.UpdateProduct(product, list);
                        if (res != null)
                        {
                            helperRepository.SuccessMessage();
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            helperRepository.ErrorMessage();
                            return View(product);
                        }
                    }
                    else
                    {
                        helperRepository.InfoMessage("Please specify unit details!");
                        return View(product);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(product);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(product);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            bool isDeleted = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var res = productRepository.DeleteProduct(id);
                    if (res)
                    {
                        isDeleted = true;
                    }
                }
                catch
                {
                    isDeleted = false;
                }
            }

            if (isDeleted)
            {
                helperRepository.SuccessMessage();
            }
            else
            {
                helperRepository.ErrorMessage();
            }

            return RedirectToAction(nameof(Index));

        }

        public ActionResult EditSellPrice(long pid, long uid)
        {
            var sellPrice = productRepository.GetAllProductUnits(pid).FirstOrDefault(x => x.UnitId == uid).UnitSellPrice;
            ViewBag.CurrentSalePrint = sellPrice;
            ViewBag.UnitId = uid;
            ViewBag.ProductId = pid;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSellPrice(decimal SalePrice, long UnitId, long ProductId)
        {
            ViewBag.CurrentSalePrint = SalePrice;
            ViewBag.UnitId = UnitId;
            ViewBag.ProductId = ProductId;

            if (ModelState.IsValid)
            {
                try
                {
                    var res = productRepository.UpdateSalePrice(SalePrice, UnitId, ProductId);
                    if (res != 0)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View();
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult CreatePartial()
        {
            Product Productmodel = new Product();

            ViewBag.Category = new SelectList(helperRepository.GetCategory(), "Id", "Name");
            ViewBag.Unit = helperRepository.GetUnit();
            ViewBag.Manufacturers = new SelectList(helperRepository.GetManufacturers(), "Id", "Name");
            return PartialView("_CreatePartialView", Productmodel);

        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePartial(Product product, long[] UnitId, decimal[] UnitSellPrice)
        {
            ViewBag.Category = new SelectList(helperRepository.GetCategory(), "Id", "Name");
            ViewBag.Unit = helperRepository.GetUnit();
            ViewBag.Manufacturers = new SelectList(helperRepository.GetManufacturers(), "Id", "Name");

            if (ModelState.IsValid)
            {
                //try
                //{
                if (UnitId.Length > 0)
                {
                    List<ProductUnit> list = new List<ProductUnit>();

                    for (int i = 0; i < UnitId.Length; i++)
                    {
                        ProductUnit unit = new ProductUnit
                        {
                            UnitId = UnitId[i],
                            UnitSellPrice = UnitSellPrice[i]
                        };
                        list.Add(unit);
                    }

                    var res = productRepository.AddProduct(product, list);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(product);
                    }
                }
                else
                {
                    helperRepository.InfoMessage("Please specify unit details!");
                    return View(product);
                }
                //}
                //catch
                //{
                //    helperRepository.ErrorMessage();
                //    return View(product);
                //}
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(product);
            }

        }

    }
}
