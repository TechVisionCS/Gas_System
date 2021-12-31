using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using NToastNotify;
using PMS.Models;
using PMS.Models.Sale;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.SaleViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class SaleController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ISaleRepository saleRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IProductRepository productRepository;
        private readonly IShopRepository shopRepository;
        private readonly ILogger<SaleController> logger;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ICustomerRepository customerRepository;
        private readonly IBankRepository bankRepository;

        public SaleController(IToastNotification toastNotification,
                              ISaleRepository saleRepository,
                              IHelperRepository helperRepository,
                              IProductRepository productRepository,
                              IShopRepository shopRepository,
                              ILogger<SaleController> logger,
                              IWebHostEnvironment webHostEnvironment,
                              ICustomerRepository customerRepository, IBankRepository bankRepository)
        {
            this.toastNotification = toastNotification;
            this.saleRepository = saleRepository;
            this.helperRepository = helperRepository;
            this.productRepository = productRepository;
            this.shopRepository = shopRepository;
            this.logger = logger;
            this.webHostEnvironment = webHostEnvironment;
            this.customerRepository = customerRepository;
            this.bankRepository = bankRepository;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        // GET: SaleController 
        public ActionResult Index()
        {
            var sales = saleRepository.GetAllSales();
            return View(sales);
        }

        // GET: SaleController/Details/5
        public ActionResult Details(long id)
        {
            var sale = saleRepository.GetSale(id);
            return View(sale);
        }

        public ActionResult ViewSaleDetails(long id)
        {
            var details = saleRepository.GetAllSaleDetails(id);
            return PartialView("_ViewSaleDetailsPartials", details);
        }

        // GET: SaleController/Create
        public ActionResult Create()
        {
            ViewBag.SaleDetailsFlg = 0;
            ViewBag.InvoiceNo = saleRepository.GetInvoiceNo();

            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");

            //List<SelectListItem> viewList = new List<SelectListItem>();
            //viewList.AddRange(new SelectList(helperRepository.GetCustomer(), "Id", "Name"));
            //ViewBag.DatumRID = viewList;

            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            return View(new CreateSaleViewModel());
        }

        public ActionResult LoadDetails()
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");
            return PartialView("_SaleDetailsPartial");
        }

        // POST: SaleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateSaleViewModel saleViewModel, long[] ProductId, long[] UnitId, decimal[] Qty, decimal[] UnitPrice, decimal[] Discount, decimal[] TotalSalePrice, int sbm_flg)
        {
            ViewBag.SaleDetailsFlg = 1;
            ViewBag.InvoiceNo = saleRepository.GetInvoiceNo();
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");
            //ViewBag.ProductBatches = new SelectList(productRepository.GetAllProductBatches(), "Id", "Name");

            bool validationFlg = true;
            var errorMsg = "";
            decimal totalSalePrice = 0;
            List<SaleDetails> list = new List<SaleDetails>();

            //if (ModelState.IsValid)
            //{
            if (ProductId.Length > 0)
            {
                //check validations ...
                for (int i = 0; i < ProductId.Length; i++)
                {
                    var productAvailQty = productRepository.GetProductAvailQty(ProductId[i], UnitId[i]);
                    var productName = productRepository.GetByIdForUpdate(ProductId[i]).Name;
                    if (productAvailQty == 0)
                    {
                        errorMsg = productName + " is not available in stock.";
                        validationFlg = false;
                    }

                    if (productAvailQty < Qty[i])
                    {
                        errorMsg = productName + " stock qty is less then current requested Qty.";
                        validationFlg = false;
                    }
                }

                //create Sales Object ... 
                for (int i = 0; i < ProductId.Length; i++)
                {
                    SaleDetails model = new SaleDetails
                    {
                        SaleId = 0,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = Discount[i],
                        TotalSalePrice = (UnitPrice[i] * Qty[i]) - Discount[i],
                    };
                    list.Add(model);
                    totalSalePrice += model.TotalSalePrice;
                }

                saleViewModel.Sale.SubTotal = totalSalePrice;
                saleViewModel.SaleDetails = list;

                if (validationFlg == false)
                {
                    toastNotification.AddErrorToastMessage(errorMsg);
                    return View(saleViewModel);
                }

                //try
                //{

                var res = saleRepository.AddSale(saleViewModel);

                if (res != 0)
                {
                    helperRepository.SuccessMessage();

                    if (sbm_flg == 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return RedirectToAction("PrintDiv", "Sale", new { Id = res });
                    }
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(saleViewModel);
                }

                //if (sbm_flg == 0 && res != 0)
                //{
                //    return RedirectToAction(nameof(Index));
                //}
                //else
                //{
                //    // return RedirectToAction(nameof(PrintSaveSlip),);
                //    return RedirectToAction("PrintSaveSlip", "Sale", new { Id = res });
                //}
                //}
                //catch
                //{
                //    return View();
                //}
            }
            else
            {
                //if Products not added to sale ... 
                toastNotification.AddErrorToastMessage("No item available in this sale!");
                return View(saleViewModel);
            }
            //}
            //else
            //{
            //    toastNotification.AddErrorToastMessage("Please enter the correct data!");
            //    return View(saleViewModel);
            //}
        }




        // GET: SaleController/Edit/5
        public ActionResult Edit(long id)
        {
            var sale = saleRepository.GetSaleForEdit(id);

            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            return View(sale);
        }

        // POST: SaleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateSaleViewModel saleViewModel, long[] ProductId, long[] UnitId, decimal[] Qty, decimal[] UnitPrice, decimal[] Discount, decimal[] TotalSalePrice)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");

            bool validationFlg = true;
            var errorMsg = "";
            decimal totalSalePrice = 0;
            List<SaleDetails> list = new List<SaleDetails>();

            //if (ModelState.IsValid)
            //{
            if (ProductId.Length > 0)
            {
                //check validations ...
                for (int i = 0; i < ProductId.Length; i++)
                {
                    var productAvailQty = productRepository.GetProductAvailQty(ProductId[i], UnitId[i]);
                    var productName = productRepository.GetByIdForUpdate(ProductId[i]).Name;
                    if (productAvailQty == 0)
                    {
                        errorMsg = productName + " is not available in stock.";
                        validationFlg = false;
                    }

                    if (productAvailQty < Qty[i])
                    {
                        errorMsg = productName + " stock qty is less then current requested Qty.";
                        validationFlg = false;
                    }
                }

                //create Sales Object ... 
                for (int i = 0; i < ProductId.Length; i++)
                {
                    SaleDetails model = new SaleDetails
                    {
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = Discount[i],
                        TotalSalePrice = (UnitPrice[i] * Qty[i]) - Discount[i],
                    };
                    list.Add(model);
                    totalSalePrice += model.TotalSalePrice;
                }

                saleViewModel.Sale.SubTotal = totalSalePrice;
                saleViewModel.SaleDetails = list;

                if (validationFlg == false)
                {
                    toastNotification.AddErrorToastMessage(errorMsg);
                    return View(saleViewModel);
                }

                //try
                //{

                var res = saleRepository.UpdateSale(saleViewModel);

                if (res != null)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(saleViewModel);
                }
                //}
                //catch
                //{
                //    return View();
                //}
            }
            else
            {
                //if Products not added to sale ... 
                toastNotification.AddErrorToastMessage("No item available in this sale!");
                return View(saleViewModel);
            }
            //}
            //else
            //{
            //    toastNotification.AddErrorToastMessage("Please enter the correct data!");
            //    return View(saleViewModel);
            //}
        }

        // GET: SaleController/Delete/5
        public ActionResult Delete(long id)
        {
            var sale = saleRepository.GetSale(id);
            return View(sale);
        }

        // POST: SaleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long saleId, DateTime? saleDate)
        {
            var sale = saleRepository.GetSale(saleId);
            try
            {
                var res = saleRepository.DeleteSale(saleId);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(sale);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(sale);
            }
        }


        [HttpGet]
        public JsonResult GetProductBatches(long id) //product Id ...
        {

            var batches = saleRepository.GetProductBatchesWithExpireDate(id);
            return Json(batches);
        }

        [HttpGet]
        public decimal GetProductsAvailQtyByUnit(long unitId, long productId)
        {
            var qty = saleRepository.GetProductUnitQty(productId, unitId);
            return qty;
        }

        [HttpGet]
        public decimal GetBatchUnitPrice(long unitId, long productId)
        {
            var price = saleRepository.GetUnitPrice(productId, unitId);
            return price;
        }

        public ActionResult GetSaleDetailsPartial(SaleDetails saleDetails) ////////////////////////////// we should review this ... Not used till now ...
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.ProductBatches = new SelectList(productRepository.GetAllProductBatches(1), "BatchId", "BatchIdName");
            return PartialView("_SaleDetailsPartial", saleDetails);
        }


        //Bill Print ...

        public ActionResult PrintDiv(long Id)
        {
            return View(saleRepository.GetSale(Id));
        }

        public ActionResult PrintInvoice(long id)
        {
            string mimeType = "";
            int extension = 1;
            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\InvoiceReport.rdlc";

            var shop = shopRepository.GetShop();
            var sale = saleRepository.GetSale(id).Sale;
            var saleDetails = saleRepository.GetSale(id).SaleDetails;

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("invoiceNo", sale.Id.ToString());
            parameters.Add("invoiceDate", sale.SaleDate);
            parameters.Add("customerId", sale.CustomerId.ToString());
            parameters.Add("customerName", sale.CustomerName);

            parameters.Add("subTotal", sale.SubTotal.ToString());
            parameters.Add("rent", sale.RentAmount.ToString());
            parameters.Add("tax", sale.TaxAmount.ToString());
            parameters.Add("discount", sale.DiscountAmount.ToString());
            parameters.Add("netTotal", sale.TotalAmount.ToString());
            parameters.Add("paid", sale.PaidAmount.ToString());
            parameters.Add("due", sale.DueAmount.ToString());



            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("SaleDetails", saleDetails);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);



            return File(res.MainStream, "application/pdf");
        }

        [HttpPost]
        public JsonResult GetCustomer()
        {
            var customerList = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            return Json(customerList);
        }

        [HttpPost]
        public JsonResult GetBank()
        {
            var banklist = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return Json(banklist);
        }

        // GET: AssetTypeController/Create
        [HttpGet]
        public ActionResult CreateCustomerModel()
        {

            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");

            Customer customer = new Customer();
            return PartialView("_CreateCustomerPartialView", customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomerModel(Customer customer, int sbm_flg)
        {
            // ViewBag.CustomerAdded = 1;
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");

            if (ModelState.IsValid)
            {
                try
                {
                    var res = customerRepository.AddCustomer(customer);
                    var id = customer.Id;
                    ViewBag.LastId = id;
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        if (sbm_flg == 0)
                        {
                            return RedirectToAction(nameof(GetCustomer));
                        }
                        else
                        {
                            return RedirectToAction(nameof(Create));
                        }
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(customer);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(customer);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(customer);
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
