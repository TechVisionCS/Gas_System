using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PMS.Models;
using PMS.Models.Purchase;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.PurchaseViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IPurchaseRepository purchaseRepository;
        private readonly IHelperRepository helperRepository;

        private readonly IProductRepository productRepository;
        private readonly IShopRepository shopRepository;
        private readonly ILogger<SaleController> logger;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ISupplierRepository supplierRepository;
        private readonly IBankRepository bankRepository;


        public PurchaseController(IPurchaseRepository purchaseRepository,
                                   IHelperRepository helperRepository,
                                   IProductRepository productRepository,
            IShopRepository shopRepository,
            ILogger<SaleController> logger,
            IWebHostEnvironment webHostEnvironment,
            ISupplierRepository supplierRepository, IBankRepository bankRepository)
        {
            this.productRepository = productRepository;
            this.shopRepository = shopRepository;
            this.logger = logger;
            this.webHostEnvironment = webHostEnvironment;
            this.supplierRepository = supplierRepository;
            this.purchaseRepository = purchaseRepository;
            this.helperRepository = helperRepository;
            this.bankRepository = bankRepository;
        }

        // GET: PurchaseController
        public ActionResult Index()
        {
            var purchases = purchaseRepository.GetAllPurchases();
            return View(purchases);
        }

        // GET: PurchaseController/Details/5
        public ActionResult Details(long id)
        {
            var purchase = purchaseRepository.GetPurchase(id);
            return View(purchase);
        }

        //For DropDown To Fill on Load Trigger 
        [HttpPost]
        public JsonResult GetSupplier()
        {
            var SupplierList = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            return Json(SupplierList);
        }

        //For DropDown To Fill on Load Trigger 
        [HttpPost]
        public JsonResult GetBank()
        {
            var BankList = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return Json(BankList);
        }

        public ActionResult ViewPurchaseDetails(long id)
        {
            var details = purchaseRepository.GetAllPurchaseDetails(id);
            return PartialView("_ViewPurchaseDetailsPartials", details);
        }

        // GET: PurchaseController/Create
        public ActionResult Create()
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            return View(new CreatePurchaseViewModel());
        }

        public ActionResult LoadDetails()
        {
            ViewBag.Products = new SelectList(helperRepository.GetProducts(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            return PartialView("_PurchaseDetailsPartial");
        }

        // POST: PurchaseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreatePurchaseViewModel purchaseViewModel, long[] ProductId, long[] UnitId, decimal[] Qty, decimal[] PurchasePrice, int sbm_flg)
        {
            if (purchaseViewModel.Purchase.SupplierId == 0)
            {
                helperRepository.InfoMessage("Please Resubmit Form Select Supplier");
                RedirectToAction("Create", "Purchase");
            }


            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(helperRepository.GetProducts(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            if (ProductId.Length > 0)
            {

                List<PurchaseDetails> list = new List<PurchaseDetails>();

                decimal subTotal = 0;
                for (int i = 0; i < ProductId.Length; i++)
                {
                    PurchaseDetails model = new PurchaseDetails
                    {
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        PurchasePrice = PurchasePrice[i],
                        TotalPurchasePrice = PurchasePrice[i] * Qty[i]
                    };
                    list.Add(model);
                    subTotal += model.TotalPurchasePrice;
                }

                purchaseViewModel.Purchase.SubTotal = subTotal;
                purchaseViewModel.PurchaseDetails = list;
            }


            if (ModelState.IsValid)
            {
                //try
                //{


                var res = purchaseRepository.AddPurchase(purchaseViewModel);

                if (res != 0)
                {
                    helperRepository.SuccessMessage();

                    if (sbm_flg == 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return RedirectToAction("PrintDivSaveClicked", "Purchase", new { Id = res });
                    }
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(purchaseViewModel);
                }

                //}
                //catch
                //{
                //    helperRepository.ErrorMessage();
                //    return View(purchaseViewModel);
                //}
            }
            else
            {
                helperRepository.ErrorMessage();
                return View(purchaseViewModel);
            }
        }

        // GET: PurchaseController/Edit/5
        public ActionResult Edit(long id)
        {
            var purchase = purchaseRepository.GetPurchaseForEdit(id);

            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(helperRepository.GetProducts(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            return View(purchase);
        }

        // POST: PurchaseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreatePurchaseViewModel purchaseViewModel, long[] ProductId, long[] UnitId, decimal[] Qty, decimal[] PurchasePrice)
        {
            var purchase = purchaseRepository.GetPurchaseForEdit(purchaseViewModel.Purchase.Id);

            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(helperRepository.GetProducts(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            if (ProductId.Length > 0)
            {
                List<PurchaseDetails> list = new List<PurchaseDetails>();

                decimal subTotal = 0;
                for (int i = 0; i < ProductId.Length; i++)
                {
                    PurchaseDetails model = new PurchaseDetails
                    {
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        PurchasePrice = PurchasePrice[i],
                        TotalPurchasePrice = PurchasePrice[i] * Qty[i]
                    };
                    list.Add(model);
                    subTotal += model.TotalPurchasePrice;
                }

                purchaseViewModel.Purchase.SubTotal = subTotal;
                purchaseViewModel.PurchaseDetails = list;
            }

            if (ModelState.IsValid)
            {
                //try
                //{
                var res = purchaseRepository.UpdatePurchase(purchaseViewModel);

                if (res != null)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(purchaseViewModel);
                }

                //}
                //catch
                //{
                //    helperRepository.ErrorMessage();
                //    return View(purchaseViewModel);
                //}
            }
            else
            {
                helperRepository.ErrorMessage();
                return View(purchaseViewModel);
            }
        }

        // GET: PurchaseController/Delete/5
        public ActionResult Delete(long id)
        {
            var purchase = purchaseRepository.GetPurchase(id);
            return View(purchase);
        }

        // POST: PurchaseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long purchaseId, DateTime? purchaseDate)
        {
            var purchase = purchaseRepository.GetPurchase(purchaseId);

            try
            {
                var res = purchaseRepository.DeletePurchase(purchaseId);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(purchase);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(purchase);
            }
        }

        //Print Invoices Bills,
        public ActionResult PrintDiv(long Id)
        {
            return View(purchaseRepository.GetPurchase(Id));
        }

        public ActionResult PrintDivSaveClicked(long Id)
        {
            return View(purchaseRepository.GetPurchase(Id));
        }

        //Bill Print ...
        public ActionResult PrintInvoice(long id)
        {
            string mimeType = "";
            int extension = 1;
            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\PurchaseInvoice.rdlc";

            var shop = shopRepository.GetShop();
            var purchase = purchaseRepository.GetPurchase(id).purchase;
            var purchaseDetails = purchaseRepository.GetPurchase(id).purchaseDetails;

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("invoiceNo", purchase.InvoiceNo);
            parameters.Add("purchaseDate", purchase.PurchaseDate);
            parameters.Add("supplierId", purchase.SupplierId.ToString());
            parameters.Add("supplierName", purchase.SupplierName);

            parameters.Add("subTotal", purchase.SubTotal.ToString());
            parameters.Add("rent", purchase.RentAmount.ToString());
            parameters.Add("tax", purchase.TaxAmount.ToString());
            parameters.Add("discount", purchase.DiscountAmount.ToString());
            parameters.Add("netTotal", purchase.TotalAmount.ToString());
            parameters.Add("paid", purchase.PaidAmount.ToString());
            parameters.Add("due", purchase.DueAmount.ToString());

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("PurchaseDetails", purchaseDetails);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);
            return File(res.MainStream, "application/pdf");
        }


        [HttpGet]
        public ActionResult CreateSupplierModel()
        {
            Supplier supplier = new Supplier();
            return PartialView("_CreateSupplierPartialView", supplier);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSupplierModel(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = supplierRepository.AddSupplier(supplier);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Create));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(supplier);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(supplier);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(supplier);
            }
        }

        [HttpGet]
        public ActionResult CreateBankModel()
        {
            Bank banks = new Bank();
            return PartialView("_CreateBankPartialView", banks);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBankModel(Bank bank)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = bankRepository.AddBank(bank);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();

                        return RedirectToAction(nameof(Create));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(bank);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(bank);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(bank);
            }
        }
    }
}
