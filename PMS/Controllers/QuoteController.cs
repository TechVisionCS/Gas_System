using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using NToastNotify;
using PMS.Models;
using PMS.Models.Quote;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.QuoteViewModels;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class QuoteController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly IQuoteReposoitory quoteRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IProductRepository productRepository;
        private readonly IShopRepository shopRepository;
        private readonly ILogger<QuoteController> logger;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ICustomerRepository customerRepository;

        public QuoteController(IToastNotification toastNotification,
            IQuoteReposoitory quoteRepository,
            IHelperRepository helperRepository,
            IProductRepository productRepository,
            IShopRepository shopRepository,
            ILogger<QuoteController> logger,
            IWebHostEnvironment webHostEnvironment,
            ICustomerRepository customerRepository)
        {
            this.toastNotification = toastNotification;
            this.quoteRepository = quoteRepository;
            this.helperRepository = helperRepository;
            this.productRepository = productRepository;
            this.shopRepository = shopRepository;
            this.logger = logger;
            this.webHostEnvironment = webHostEnvironment;
            this.customerRepository = customerRepository;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        // GET: QuoteController
        public ActionResult Index()
        {
            return View(quoteRepository.GetAllQuotes());
        }

        public ActionResult ViewQuoteDetails(long id)
        {
            var details = quoteRepository.GetAllQuoteDetails(id);
            return PartialView("_ViewQuoteDetailsPartials", details);
        }

        [HttpGet]
        public ActionResult QuotationToSale()
        {
            return View(quoteRepository.GetAllQuotesWithStatus());
        }

        [HttpGet]
        public ActionResult QuoteMapToSale(long PassByInput)
        {
            if (ModelState.IsValid)
            {

                var model = quoteRepository.MapQuoteToSale(PassByInput);

                return RedirectToAction("Create", "Sale", model);
            }
            return null;

        }

        // GET: QuoteController/Details/5
        public ActionResult Details(long id)
        {
            return View(quoteRepository.GetQuote(id));
        }
        public ActionResult LoadDetails()
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.ProductBatches = null; // new SelectList(productRepository.GetAllProductBatches(1), "Id", "Name");
            return PartialView("_QuoteDetailsPartial");
        }
        public ActionResult LoadDetailsEdit()
        {
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            //ViewBag.ProductBatches = null; // new SelectList(productRepository.GetAllProductBatches(1), "Id", "Name");
            return PartialView("_QuoteDetailsPartialEdit");
        }
        public ActionResult LoadDetails2(string batchId)
        {
            var model = quoteRepository.GetQuoteDetailsByBatchId(batchId);
            QuoteDetails quoteDetails = new QuoteDetails();
            if (model != null)
            {
                ViewBag.Flg = true;
                var product = productRepository.GetByIdForUpdate(model.ProductId);
                //ViewBag.ProductName = product.Name + "-" + product.Model; ----
                ViewBag.AvailQty = model.StockQty;

                quoteDetails.BatchId = model.BatchId;
                quoteDetails.ProductId = model.ProductId;
                quoteDetails.Qty = 1;
                quoteDetails.Discount = 0;
            }
            else
            {
                ViewBag.Flg = false;
            }

            return PartialView("_QuoteDetailsPartial2", quoteDetails);
        }

        // GET: QuoteController/Create
        public ActionResult Create()
        {
            ViewBag.QuoteDetailsFlg = 0;
            ViewBag.InvoiceNo = quoteRepository.GetQuoteInvoiceNo();
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");

            return View(new CreateQuoteViewModel());
        }

        // POST: QuoteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateQuoteViewModel quoteViewModel, long[] ProductId, string[] BatchId, decimal[] Qty, decimal[] UnitPrice, decimal[] Discount, decimal[] TotalQuotePrice, int sbm_flg)
        {
            ViewBag.QuoteDetailsFlg = 1;
            ViewBag.InvoiceNo = quoteRepository.GetQuoteInvoiceNo();
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            // ViewBag.ProductBatches = new SelectList(productRepository.GetAllProductBatches(), "Id", "Name");

            bool validationFlg = true;
            var errorMsg = "";
            decimal totalSalePrice = 0;
            List<QuoteDetails> list = new List<QuoteDetails>();

            if (ModelState.IsValid)
            {
                if (ProductId.Length > 0)
                {
                    //check validations ...
                    for (int i = 0; i < ProductId.Length; i++)
                    {
                        //var productAvailQty = productRepository.GetProductAvailQty(ProductId[i], BatchId[i]);
                        var productAvailQty = productRepository.GetProductAvailQty(ProductId[i], 0);

                        var productName = productRepository.GetByIdForUpdate(ProductId[i]).Name;
                        if (productAvailQty == 0)
                        {
                            errorMsg = productName + " - " + BatchId[i] + " is not available in stock.";
                            validationFlg = false;
                        }

                        if (productAvailQty < Qty[i])
                        {
                            errorMsg = productName + " - " + BatchId[i] + " stock qty is less then current requested Qty.";
                            validationFlg = false;
                        }
                    }
                    //create Sales Object ... 
                    for (int i = 0; i < ProductId.Length; i++)
                    {
                        QuoteDetails model = new QuoteDetails
                        {
                            QuoteId = 0,
                            ProductId = ProductId[i],
                            BatchId = BatchId[i],
                            Qty = Qty[i],
                            UnitPrice = UnitPrice[i],
                            Discount = Discount[i],
                            TotalQuotePrice = (UnitPrice[i] * Qty[i]) - Discount[i],
                        };
                        list.Add(model);
                        totalSalePrice += model.TotalQuotePrice;
                    }

                    quoteViewModel.Quote.SubTotal = totalSalePrice;
                    quoteViewModel.QuoteDetails = list;

                    if (validationFlg == false)
                    {
                        toastNotification.AddErrorToastMessage(errorMsg);
                        return View(quoteViewModel);
                    }

                    try
                    {

                        var res = quoteRepository.AddQuote(quoteViewModel);

                        if (res != 0)
                        {
                            helperRepository.SuccessMessage();

                            if (sbm_flg == 0)
                            {
                                return RedirectToAction(nameof(Index));
                            }
                            else
                            {
                                return RedirectToAction("PrintDiv", "Quote", new { Id = res });
                            }
                        }
                        else
                        {
                            helperRepository.ErrorMessage();
                            return View(quoteViewModel);
                        }
                    }
                    catch
                    {
                        return View();
                    }
                }
                else
                {
                    //if Products not added to sale ... 
                    toastNotification.AddErrorToastMessage("No item available in this sale!");
                    return View(quoteViewModel);
                }
            }
            else
            {
                toastNotification.AddErrorToastMessage("Please enter the correct data!");
                return View(quoteViewModel);
            }
        }
        public ActionResult Create2()
        {
            ViewBag.InvoiceNo = quoteRepository.GetQuoteInvoiceNo();
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            return View(new CreateQuoteViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create2(CreateQuoteViewModel quoteViewModel, long[] ProductId, string[] BatchId, decimal[] Qty, decimal[] UnitPrice, decimal[] Discount, decimal[] TotalQuotePrice, int sbm_flg)
        {
            ViewBag.InvoiceNo = quoteRepository.GetQuoteInvoiceNo();
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            //ViewBag.ProductBatches = new SelectList(productRepository.GetAllProductBatches(), "Id", "Name");

            bool validationFlg = true;
            var errorMsg = "";
            decimal totalSalePrice = 0;
            List<QuoteDetails> list = new List<QuoteDetails>();

            if (ModelState.IsValid)
            {
                if (ProductId.Length > 0)
                {
                    //check validations ...
                    for (int i = 0; i < ProductId.Length; i++)
                    {
                        //var productAvailQty = productRepository.GetProductAvailQty(ProductId[i], BatchId[i]);
                        var productAvailQty = productRepository.GetProductAvailQty(ProductId[i], 0);
                        var productName = productRepository.GetByIdForUpdate(ProductId[i]).Name;
                        if (productAvailQty == 0)
                        {
                            errorMsg = productName + " - " + BatchId[i] + " is not available in stock.";
                            validationFlg = false;
                        }

                        if (productAvailQty < Qty[i])
                        {
                            errorMsg = productName + " - " + BatchId[i] + " stock qty is less then current requested Qty.";
                            validationFlg = false;
                        }
                    }

                    //create Sales Object ... 
                    for (int i = 0; i < ProductId.Length; i++)
                    {
                        QuoteDetails model = new QuoteDetails
                        {
                            QuoteId = 0,
                            ProductId = ProductId[i],
                            BatchId = BatchId[i],
                            Qty = Qty[i],
                            UnitPrice = UnitPrice[i],
                            Discount = Discount[i],
                            TotalQuotePrice = (UnitPrice[i] * Qty[i]) - Discount[i],
                        };
                        list.Add(model);
                        totalSalePrice += model.TotalQuotePrice;
                    }

                    quoteViewModel.Quote.SubTotal = totalSalePrice;
                    quoteViewModel.QuoteDetails = list;

                    if (validationFlg == false)
                    {
                        toastNotification.AddErrorToastMessage(errorMsg);
                        return View(quoteViewModel);
                    }

                    try
                    {
                        var res = quoteRepository.AddQuote(quoteViewModel);

                        if (res != 0)
                        {
                            helperRepository.SuccessMessage();

                            if (sbm_flg == 0)
                            {
                                return RedirectToAction(nameof(Index));
                            }
                            else
                            {
                                return RedirectToAction("PrintDiv", "Quote", new { Id = res });
                            }
                        }
                        else
                        {
                            helperRepository.ErrorMessage();
                            return View(quoteViewModel);
                        }
                    }
                    catch
                    {
                        return View();
                    }
                }
                else
                {
                    //if Products not added to sale ... 
                    toastNotification.AddErrorToastMessage("No item available in this sale!");
                    return View(quoteViewModel);
                }
            }
            else
            {
                toastNotification.AddErrorToastMessage("Please enter the correct data!");
                return View(quoteViewModel);
            }
        }

        [HttpGet]
        public JsonResult GetProductBatches(long id) //product Id ...
        {
            var batches = quoteRepository.GetProductBatchesWithExpireDate(id);
            return Json(batches);
        }

        [HttpGet]
        public decimal GetProductsAvailQtyByBatchId(string batchId, long productId)
        {
            var qty = quoteRepository.GetProductBatchQty(batchId, productId);
            return qty;
        }

        [HttpGet]
        public decimal GetBatchUnitPrice(string batchId, long productId)
        {
            var price = quoteRepository.GetUnitPrice(batchId, productId);
            return price;
        }

        // GET: QuoteController/Edit/5
        public ActionResult Edit(long id)
        {
            var quote = quoteRepository.GetQuoteForEdit(id);

            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.ProductBatches = new SelectList(helperRepository.GetProductBatchesForEdit(), "Id", "BatchId");

            return View(quote);
        }

        // POST: QuoteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateQuoteViewModel quoteViewModel, long[] QuoteId, long[] ProductId, string[] BatchId, decimal[] Qty, decimal[] UnitPrice, decimal[] Discount, decimal[] TotalQuotePrice)
        {
            ViewBag.InvoiceNo = quoteRepository.GetQuoteInvoiceNo();
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.ProductBatches = new SelectList(helperRepository.GetProductBatchesForEdit(), "Id", "BatchId"); // No Product Id - - show all batches coz i returned all batches in list 

            bool validationFlg = true;
            var errorMsg = "";
            decimal totalSalePrice = 0;
            List<QuoteDetails> list = new List<QuoteDetails>();

            if (ModelState.IsValid)
            {
                if (ProductId.Length > 0)
                {
                    //check validations ...
                    for (int i = 0; i < ProductId.Length; i++)
                    {
                        //var productAvailQty = productRepository.GetProductAvailQty(ProductId[i], BatchId[i]);
                        var productAvailQty = productRepository.GetProductAvailQty(ProductId[i], 0);

                        var productName = productRepository.GetByIdForUpdate(ProductId[i]).Name;

                        if (productAvailQty == 0)
                        {
                            errorMsg = productName + " - " + BatchId[i] + " is not available in stock.";

                            validationFlg = false;
                        }

                        if (productAvailQty < Qty[i])
                        {
                            errorMsg = productName + " - " + BatchId[i] + " stock qty is less then current requested Qty.";

                            validationFlg = false;
                        }
                    }

                    //create Qoute  Object ...

                    for (int i = 0; i < ProductId.Length; i++)
                    {
                        QuoteDetails model = new QuoteDetails
                        {
                            QuoteId = QuoteId[i],
                            ProductId = ProductId[i],
                            BatchId = BatchId[i],
                            Qty = Qty[i],
                            UnitPrice = UnitPrice[i],
                            Discount = Discount[i],
                            TotalQuotePrice = (UnitPrice[i] * Qty[i]) - Discount[i],
                        };
                        list.Add(model);
                        totalSalePrice += model.TotalQuotePrice;
                    }

                    quoteViewModel.Quote.SubTotal = totalSalePrice;
                    quoteViewModel.QuoteDetails = list;

                    if (validationFlg == false)
                    {
                        toastNotification.AddErrorToastMessage(errorMsg);
                        return View(quoteViewModel);
                    }

                    //try
                    //{

                    var res = quoteRepository.EditQuote(quoteViewModel);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(quoteViewModel);
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
                    return View(quoteViewModel);
                }
            }
            else
            {
                toastNotification.AddErrorToastMessage("Please enter the correct data!");
                return View(quoteViewModel);
            }
        }

        // POST: QuoteController/Delete/5
        [HttpDelete]
        [HttpPost]
        public ActionResult Delete(long id)
        {
            bool isDeleted = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var quote = quoteRepository.GetQuoteForEdit(id);

                    if (quote == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        var res = quoteRepository.DeleteQuote(id);
                        if (res)
                        {
                            isDeleted = true;
                        }
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

        //Customer add section

        [HttpGet]
        public ActionResult Success()
        {
            toastNotification.AddSuccessToastMessage("operation completed successfully!");
            return RedirectToAction(nameof(GetCustomer));
        }

        [HttpGet]
        public JsonResult GetCustomer()
        {
            var customer = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            return Json(customer);
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


        public ActionResult PrintDiv(long Id)
        {
            return View(quoteRepository.GetQuote(Id));
        }


        public ActionResult PrintInvoice(long id)
        {
            string mimeType = "";
            int extension = 1;
            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\QuoteInvoice.rdlc";

            var shop = shopRepository.GetShop();
            var quote = quoteRepository.GetQuote(id).Quote;
            var quoteDetails = quoteRepository.GetQuote(id).QuoteDetails;

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("invoiceNo", quote.InvoiceNo);
            parameters.Add("invoiceDate", quote.QuoteDate.ToString());
            parameters.Add("description", quote.Description);
            parameters.Add("customerId", quote.CustomerId.ToString());
            parameters.Add("customerName", quote.CustomerName);
            parameters.Add("CustomeraAddress", quote.CustomeraAddress);
            parameters.Add("CustomerPhone", quote.CustomerPhone);
            parameters.Add("CustomerEmail", quote.CustomerEmail);

            parameters.Add("subTotal", quote.SubTotal.ToString());
            parameters.Add("rent", quote.RentAmount.ToString());
            parameters.Add("tax", quote.TaxAmount.ToString());
            parameters.Add("discount", quote.DiscountAmount.ToString());
            parameters.Add("netTotal", quote.TotalAmount.ToString());
            parameters.Add("paid", quote.PaidAmount.ToString());
            parameters.Add("due", quote.DueAmount.ToString());

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("quoteDetails", quoteDetails);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);

            return File(res.MainStream, "application/pdf");
        }

    }
}
