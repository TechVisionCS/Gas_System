using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.Wastages;
using System;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class WastageController : Controller
    {
        private readonly IWastageRepository wastageRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IProductRepository productRepository;
        private readonly IStockRepository stockRepository;
        private readonly ISaleRepository saleRepository;
        private readonly IPurchaseRepository purchaseRepository;
        private readonly IReturnRepository returnRepository;

        public WastageController(IWastageRepository wastageRepository,
                                IHelperRepository helperRepository,
                                IProductRepository productRepository,
                                IStockRepository stockRepository,
                                ISaleRepository saleRepository,
                                IPurchaseRepository purchaseRepository,
                                IReturnRepository returnRepository
                                )
        {
            this.wastageRepository = wastageRepository;
            this.helperRepository = helperRepository;
            this.productRepository = productRepository;
            this.stockRepository = stockRepository;
            this.saleRepository = saleRepository;
            this.purchaseRepository = purchaseRepository;
            this.returnRepository = returnRepository;
        }
        // GET: WastageController
        public ActionResult Index()
        {
            var wastages = wastageRepository.GetAllWastages();
            return View(wastages);
        }

        public ActionResult WastagesByDate(DateTime? startDate = null, DateTime? endDate = null)
        {
            var wastages = wastageRepository.GetAllWastagesByDate(startDate, endDate);
            return View("Index", wastages);
        }

        // GET: WastageController/Details/5
        public ActionResult Details(long id)
        {
            var wastage = wastageRepository.GetWastage(id);
            return View(wastage);
        }

        // GET: WastageController/Create
        public ActionResult Create()
        {
            return View(new WastageViewModel());
        }

        public ActionResult LoadDetails()
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");
            ViewBag.ProductBatches = null; // new SelectList(productRepository.GetAllProductBatches(1), "Id", "Name");
            return PartialView("_WastageDetailsPartial");
        }

        public ActionResult Create2()
        {
            return View(new WastageViewModel());
        }

        public ActionResult LoadDetails2(string batchId)
        {

            var model = returnRepository.GetProductBatchDetails(batchId);
            WastageDetailsViewModel wastageDetails = new WastageDetailsViewModel();

            if (model != null)
            {
                var product = productRepository.GetByIdForUpdate(model.ProductId);
                ViewBag.ProductName = product.Name;// + "-" + product.Model;
                ViewBag.AvailQty = model.StockQty;

                //wastageDetails.BatchId = model.BatchId;
                wastageDetails.ProductId = model.ProductId;
                wastageDetails.Qty = 1;
                wastageDetails.UnitPrice = model.PurchasePrice;
                wastageDetails.TotalPrice = 1 * model.PurchasePrice;

            }

            return PartialView("_WastageDetailsPartial2", wastageDetails);
        }

        [HttpGet]
        public JsonResult GetProductBatches(long id) //product Id ...
        {

            var batches = saleRepository.GetProductBatchesWithExpireDate(id);
            return Json(batches);
        }

        [HttpGet]
        public decimal GetProductsAvailQty(long unitId, long productId)
        {
            var qty = saleRepository.GetProductUnitQty(productId, unitId);
            return qty;
        }

        [HttpGet]
        public decimal GetBatchUnitPrice(long unitId, long productId)
        {
            var price = purchaseRepository.GetUnitPrice(unitId, productId);
            return price;
        }

        // POST: WastageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WastageViewModel model, long[] ProductId, long[] UnitId, decimal[] UnitPrice, decimal[] Qty, decimal[] TotalPrice)
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");
            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (ProductId.Length > 0)
            {
                Wastage wastage = new Wastage
                {
                    Id = 0,
                    WastageDate = model.Wastage.WastageDate,
                    Description = model.Wastage.Description,
                    SubTotal = model.Wastage.SubTotal,
                    ExCharges = model.Wastage.ExCharges,
                    IncomeFromWastage = model.Wastage.IncomeFromWastage,
                    TotalAmount = model.Wastage.TotalAmount,
                    Flg = 0
                };

                List<WastageDetails> list = new List<WastageDetails>();
                List<WastageDetailsViewModel> detailsList = new List<WastageDetailsViewModel>();

                for (int i = 0; i < ProductId.Length; i++)
                {
                    WastageDetails detail = new WastageDetails
                    {
                        WastageId = 0,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        UnitPrice = UnitPrice[i],
                        Qty = Qty[i],
                        TotalPrice = TotalPrice[i]
                    };
                    list.Add(detail);

                    WastageDetailsViewModel detailsModel = new WastageDetailsViewModel
                    {
                        ProductId = ProductId[i],
                        Product = productRepository.GetByIdForUpdate(ProductId[i]),
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        TotalPrice = TotalPrice[i]
                    };
                    detailsList.Add(detailsModel);
                }

                model.WastageDetails = detailsList; //in case of fail, page rendering ...

                var res = wastageRepository.AddWastage(wastage, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
            //}
            //catch
            //{
            //    return View(model);
            //}
            //}
            //else
            //{
            //    return View(model);
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create2(WastageViewModel model, long[] ProductId, long[] UnitId, decimal[] UnitPrice, decimal[] Qty, decimal[] TotalPrice)
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (ProductId.Length > 0)
            {
                Wastage wastage = new Wastage
                {
                    Id = 0,
                    WastageDate = model.Wastage.WastageDate,
                    Description = model.Wastage.Description,
                    SubTotal = model.Wastage.SubTotal,
                    ExCharges = model.Wastage.ExCharges,
                    IncomeFromWastage = model.Wastage.IncomeFromWastage,
                    TotalAmount = model.Wastage.TotalAmount,
                    Flg = 1
                };

                List<WastageDetails> list = new List<WastageDetails>();
                List<WastageDetailsViewModel> detailsList = new List<WastageDetailsViewModel>();

                for (int i = 0; i < ProductId.Length; i++)
                {
                    WastageDetails detail = new WastageDetails
                    {
                        WastageId = 0,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        UnitPrice = UnitPrice[i],
                        Qty = Qty[i],
                        TotalPrice = TotalPrice[i]
                    };
                    list.Add(detail);

                    WastageDetailsViewModel detailsModel = new WastageDetailsViewModel
                    {
                        ProductId = ProductId[i],
                        Product = productRepository.GetByIdForUpdate(ProductId[i]),
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        TotalPrice = TotalPrice[i]
                    };
                    detailsList.Add(detailsModel);
                }

                model.WastageDetails = detailsList; //in case of fail, page rendering ...

                var res = wastageRepository.AddWastage(wastage, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
            //}
            //catch
            //{
            //    return View(model);
            //}
            //}
            //else
            //{
            //    return View(model);
            //}
        }

        // GET: WastageController/Edit/5
        public ActionResult Edit(long id)
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            var wastage = wastageRepository.GetWastage(id);
            return View(wastage);
        }

        public ActionResult Edit2(long id)
        {
            var wastage = wastageRepository.GetWastage(id);
            return View(wastage);
        }

        // POST: WastageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WastageViewModel model, long[] ProductId, long[] UnitId, decimal[] UnitPrice, decimal[] Qty, decimal[] TotalPrice)
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (ProductId.Length > 0)
            {

                List<WastageDetails> list = new List<WastageDetails>();
                List<WastageDetailsViewModel> detailsList = new List<WastageDetailsViewModel>();

                for (int i = 0; i < ProductId.Length; i++)
                {
                    WastageDetails detail = new WastageDetails
                    {
                        WastageId = model.Wastage.Id,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        UnitPrice = UnitPrice[i],
                        Qty = Qty[i],
                        TotalPrice = TotalPrice[i]
                    };
                    list.Add(detail);

                    WastageDetailsViewModel detailsModel = new WastageDetailsViewModel
                    {
                        ProductId = ProductId[i],
                        Product = productRepository.GetByIdForUpdate(ProductId[i]),
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        TotalPrice = TotalPrice[i]
                    };
                    detailsList.Add(detailsModel);
                }

                model.WastageDetails = detailsList; //in case of fail, page rendering ...

                var res = wastageRepository.UpdateWastage(model.Wastage, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
            //}
            //catch
            //{
            //    return View(model);
            //}
            //}
            //else
            //{
            //    return View(model);
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit2(WastageViewModel model, long[] ProductId, long[] UnitId, decimal[] UnitPrice, decimal[] Qty, decimal[] TotalPrice)
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (ProductId.Length > 0)
            {

                List<WastageDetails> list = new List<WastageDetails>();
                List<WastageDetailsViewModel> detailsList = new List<WastageDetailsViewModel>();

                for (int i = 0; i < ProductId.Length; i++)
                {
                    WastageDetails detail = new WastageDetails
                    {
                        WastageId = model.Wastage.Id,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        UnitPrice = UnitPrice[i],
                        Qty = Qty[i],
                        TotalPrice = TotalPrice[i]
                    };
                    list.Add(detail);

                    WastageDetailsViewModel detailsModel = new WastageDetailsViewModel
                    {
                        ProductId = ProductId[i],
                        Product = productRepository.GetByIdForUpdate(ProductId[i]),
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        TotalPrice = TotalPrice[i]
                    };
                    detailsList.Add(detailsModel);
                }

                model.WastageDetails = detailsList; //in case of fail, page rendering ...

                var res = wastageRepository.UpdateWastage(model.Wastage, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
            //}
            //catch
            //{
            //    return View(model);
            //}
            //}
            //else
            //{
            //    return View(model);
            //}
        }

        // GET: WastageController/Delete/5
        public ActionResult Delete(long id)
        {
            var wastage = wastageRepository.GetWastage(id);
            return View(wastage);
        }

        // POST: WastageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long wastageId, DateTime? wastageDate)
        {
            var wastage = wastageRepository.GetWastage(wastageId);
            try
            {
                var res = wastageRepository.DeleteWastage(wastageId);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(wastage);
                }
            }
            catch
            {
                return View(wastage);
            }
        }
    }
}
