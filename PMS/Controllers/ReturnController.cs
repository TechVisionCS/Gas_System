using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.ReturnViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class ReturnController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly IReturnRepository returnRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IProductRepository productRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly ISupplierRepository supplierRepository;
        private readonly IStockRepository stockRepository;
        private readonly IPurchaseRepository purchaseRepository;
        private readonly ISaleRepository saleRepository;

        public ReturnController(IToastNotification toastNotification,
                                IReturnRepository returnRepository,
                                IHelperRepository helperRepository,
                                IProductRepository productRepository,
                                ICustomerRepository customerRepository,
                                ISupplierRepository supplierRepository,
                                IStockRepository stockRepository,
                                IPurchaseRepository purchaseRepository,
                                ISaleRepository saleRepository)
        {
            this.toastNotification = toastNotification;
            this.returnRepository = returnRepository;
            this.helperRepository = helperRepository;
            this.productRepository = productRepository;
            this.customerRepository = customerRepository;
            this.supplierRepository = supplierRepository;
            this.stockRepository = stockRepository;
            this.purchaseRepository = purchaseRepository;
            this.saleRepository = saleRepository;
        }

        // GET: ReturnController
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult SaleReturn()
        {
            var saleReturns = returnRepository.GetAllSaleReturns();
            return View(saleReturns);
        }

        public ActionResult SaleReturnByDate(DateTime? startDate = null, DateTime? endDate = null)
        {
            var saleReturns = returnRepository.GetAllSaleReturnsByDate(startDate, endDate);
            return View("SaleReturn", saleReturns);
        }

        public ActionResult PurchaseReturn()
        {
            var purchaseReturns = returnRepository.GetAllPurchaseReturns();
            return View(purchaseReturns);
        }

        public ActionResult PurchaseReturnByDate(DateTime? startDate = null, DateTime? endDate = null)
        {
            var purchaseReturns = returnRepository.GetAllPurchaseReturnsByDate(startDate, endDate);
            return View("PurchaseReturn", purchaseReturns);
        }

        public ActionResult Wastages()
        {
            var wastages = returnRepository.GetAllWastages();
            return View(wastages);
        }


        // GET: ReturnController/Details/5
        public ActionResult DetailsSaleReturn(long id)
        {
            var saleReturn = returnRepository.GetSaleReturn(id);
            return View(saleReturn);
        }

        public ActionResult DetailsPurchaseReturn(long id)
        {
            var purchaseReturn = returnRepository.GetPurchaseReturn(id);
            return View(purchaseReturn);
        }

        public ActionResult DetailsWastage(long id)
        {

            return View();
        }


        // GET: ReturnController/Create
        public ActionResult CreateSaleReturn(long saleId)
        {
            ViewBag.SaleId = saleId;
            var sale = saleRepository.GetSaleForEdit(saleId);

            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            return View(sale);
        }

        public ActionResult LoadDetails(string batchId)
        {
            var model = returnRepository.GetProductBatchDetails(batchId);
            ReturnDetailsViewModel returnDetail = new ReturnDetailsViewModel();

            if (model != null)
            {
                var product = productRepository.GetByIdForUpdate(model.ProductId);
                //ViewBag.ProductName = product.Name + "-" + product.Model; ---

                //returnDetail.UnitId = model.BatchId;
                returnDetail.ProductId = model.ProductId;
                returnDetail.Qty = 1;
                //returnDetail.UnitPrice = model.SellPrice;
                returnDetail.Discount = 0;
                //returnDetail.TotalPrice = 1 * model.SellPrice;

            }

            return PartialView("_SaleDetailsPartial2", returnDetail);
        }

        public ActionResult LoadDetails2(string batchId)
        {
            var model = returnRepository.GetProductBatchDetails(batchId);
            ReturnDetailsViewModel returnDetail = new ReturnDetailsViewModel();

            if (model != null)
            {
                var product = productRepository.GetByIdForUpdate(model.ProductId);
                //ViewBag.ProductName = product.Name + "-" + product.Model; ---

                //returnDetail.BatchId = model.BatchId;
                returnDetail.ProductId = model.ProductId;
                returnDetail.Qty = 1;
                returnDetail.UnitPrice = model.PurchasePrice;
                returnDetail.Discount = 0;
                returnDetail.TotalPrice = 1 * model.PurchasePrice;

            }

            return PartialView("_PurchaseDetailsPartial2", returnDetail);
        }

        public ActionResult CreatePurchaseReturn(long purchaseId)
        {
            ViewBag.PurchaseId = purchaseId;
            var purchase = purchaseRepository.GetPurchaseForEdit(purchaseId);

            ViewBag.Suppliers = new SelectList(helperRepository.GetAllSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(helperRepository.GetProducts(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            return View(purchase);
        }

        public ActionResult CreateWastage()
        {

            return View();
        }


        // POST: ReturnController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSaleReturn(long saleId, DateTime returnDate, string returnNote, decimal subTotal, decimal rent, decimal tax, decimal totalDiscount,
            decimal totalAmount, decimal paidAmount, decimal balancedAmount, decimal[] returnedQty, decimal[] discount, decimal[] totalReturnPrice, long[] chkSaleDetailsId)
        {
            ViewBag.SaleId = saleId;
            var sale = saleRepository.GetSaleForEdit(saleId);
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (chkSaleDetailsId.Length > 0)
            {
                Return rtn = new Return
                {
                    SaleId = saleId,
                    InvoiceNo = saleId.ToString(),
                    Description = returnNote,
                    ReturnDate = returnDate,
                    SubTotal = subTotal,
                    RentAmount = rent,
                    TaxAmount = tax,
                    DiscountAmount = totalDiscount,
                    TotalAmount = totalAmount,
                    PaidAmount = paidAmount,
                    DueAmount = balancedAmount,
                    PaymentType = sale.Sale.PaymentType,
                    BankId = sale.Sale.BankId,
                    ReturnType = 0, //Return Type = Sale...
                    CustomerId = sale.Sale.CustomerId
                };


                List<ReturnDetails> list = new List<ReturnDetails>();
                for (int i = 0; i < chkSaleDetailsId.Length; i++)
                {
                    var itemdiscount = (decimal)0;
                    if (discount.Length != 0)
                    {
                        itemdiscount = discount[i];
                    }
                    var saleDetails = saleRepository.GetSaleDetailsById(chkSaleDetailsId[i]);
                    ReturnDetails details = new ReturnDetails
                    {
                        ReturnId = 0,
                        ProductId = saleDetails.ProductId,
                        UnitId = saleDetails.UnitId,
                        Qty = returnedQty[i],
                        UnitPrice = saleDetails.UnitPrice,
                        Discount = itemdiscount,
                        TotalReturnPrice = totalReturnPrice[i],
                        DetailsId = chkSaleDetailsId[i]
                    };
                    list.Add(details);
                }

                var res = returnRepository.AddSaleReturn(rtn, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(SaleReturn));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(sale);
                }
            }
            else
            {
                return View(sale);
            }
            //}
            //catch
            //{
            //    return View(purchase);
            //}
            //}
            //else
            //{
            //    return View(purchase);
            //}
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePurchaseReturn(long purchaseId, DateTime returnDate, string returnNote, decimal subTotal, decimal rent, decimal tax, decimal totalDiscount,
            decimal totalAmount, decimal paidAmount, decimal balancedAmount, decimal[] returnedQty, decimal[] discount, decimal[] totalReturnPrice, long[] chkPurchaseDetailsId)
        {
            ViewBag.PurchaseId = purchaseId;
            var purchase = purchaseRepository.GetPurchaseForEdit(purchaseId);
            ViewBag.Suppliers = new SelectList(helperRepository.GetAllSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(helperRepository.GetProducts(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (chkPurchaseDetailsId.Length > 0)
            {
                Return rtn = new Return
                {
                    PurchaseId = purchaseId,
                    Description = returnNote,
                    ReturnDate = returnDate,
                    SubTotal = subTotal,
                    RentAmount = rent,
                    TaxAmount = tax,
                    DiscountAmount = totalDiscount,
                    TotalAmount = totalAmount,
                    PaidAmount = paidAmount,
                    DueAmount = balancedAmount,
                    PaymentType = purchase.Purchase.PaymentType,
                    BankId = purchase.Purchase.BankId,
                    ReturnType = 1, //Return Type = Purchase...
                    SupplierId = purchase.Purchase.SupplierId
                };


                List<ReturnDetails> list = new List<ReturnDetails>();
                for (int i = 0; i < chkPurchaseDetailsId.Length; i++)
                {
                    var itemdiscount = (decimal)0;
                    if (discount.Length != 0)
                    {
                        itemdiscount = discount[i];
                    }
                    var purchaseDetails = purchaseRepository.GetPurchaseDetailsById(chkPurchaseDetailsId[i]);
                    ReturnDetails details = new ReturnDetails
                    {
                        ReturnId = 0,
                        ProductId = purchaseDetails.ProductId,
                        UnitId = purchaseDetails.UnitId,
                        Qty = returnedQty[i],
                        UnitPrice = purchaseDetails.PurchasePrice,
                        Discount = itemdiscount,
                        TotalReturnPrice = totalReturnPrice[i],
                        DetailsId = chkPurchaseDetailsId[i]
                    };
                    list.Add(details);
                }

                var res = returnRepository.AddPurchaseReturn(rtn, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(PurchaseReturn));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(purchase);
                }
            }
            else
            {
                return View(purchase);
            }
            //}
            //catch
            //{
            //    return View(purchase);
            //}
            //}
            //else
            //{
            //    return View(purchase);
            //}
        }


        // GET: ReturnController/Edit/5
        public ActionResult EditSaleReturn(long returnId, long saleId)
        {
            ViewBag.SaleId = saleId;
            var sale = saleRepository.GetSaleForEdit(saleId);

            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");


            ViewBag.EditReturn = returnRepository.GetReturnById(returnId);
            ViewBag.EditReturnDetails = returnRepository.GetSaleReturnDetailsByReturnId(returnId);

            return View(sale);
        }

        public ActionResult EditPurchaseReturn(long returnId, long purchaseId)
        {
            ViewBag.PurchaseId = purchaseId;
            var purchase = purchaseRepository.GetPurchaseForEdit(purchaseId);

            ViewBag.Suppliers = new SelectList(helperRepository.GetAllSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(helperRepository.GetProducts(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");


            ViewBag.EditReturn = returnRepository.GetReturnById(returnId);
            ViewBag.EditReturnDetails = returnRepository.GetReturnDetailsByReturnId(returnId);

            return View(purchase);

        }

        public ActionResult EditWastages(long id) //return id
        {
            return View();
        }

        // POST: ReturnController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPurchaseReturn(long returnId, long purchaseId, DateTime returnDate, string returnNote, decimal subTotal, decimal rent, decimal tax, decimal totalDiscount,
            decimal totalAmount, decimal paidAmount, decimal balancedAmount, decimal[] returnedQty, decimal[] discount, decimal[] totalReturnPrice, long[] chkPurchaseDetailsId)
        {
            ViewBag.PurchaseId = purchaseId;
            var purchase = purchaseRepository.GetPurchaseForEdit(purchaseId);

            ViewBag.Suppliers = new SelectList(helperRepository.GetAllSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(helperRepository.GetProducts(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");


            ViewBag.EditReturn = returnRepository.GetReturnById(returnId);
            ViewBag.EditReturnDetails = returnRepository.GetReturnDetailsByReturnId(returnId);

            //try
            //{
            if (chkPurchaseDetailsId.Length > 0)
            {
                var updatedRtn = returnRepository.GetReturnById(returnId);
                updatedRtn.ReturnDate = returnDate;
                updatedRtn.Description = returnNote;
                updatedRtn.SubTotal = subTotal;
                updatedRtn.RentAmount = rent;
                updatedRtn.TaxAmount = tax;
                updatedRtn.DiscountAmount = totalDiscount;
                updatedRtn.TotalAmount = totalAmount;
                updatedRtn.PaidAmount = paidAmount;
                updatedRtn.DueAmount = balancedAmount;

                List<ReturnDetails> list = new List<ReturnDetails>();
                for (int i = 0; i < chkPurchaseDetailsId.Length; i++)
                {
                    var purchaseDetails = purchaseRepository.GetPurchaseDetailsById(chkPurchaseDetailsId[i]);
                    ReturnDetails details = new ReturnDetails
                    {
                        ReturnId = 0,
                        ProductId = purchaseDetails.ProductId,
                        UnitId = purchaseDetails.UnitId,
                        Qty = returnedQty[i],
                        UnitPrice = purchaseDetails.PurchasePrice,
                        Discount = discount[i],
                        TotalReturnPrice = totalReturnPrice[i],
                        DetailsId = chkPurchaseDetailsId[i]
                    };
                    list.Add(details);
                }

                var res = returnRepository.UpdatePurchaseReturn(updatedRtn, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(PurchaseReturn));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(purchase);
                }
            }
            else
            {
                helperRepository.ErrorMessage();
                return View(purchase);
            }
            //}
            //catch
            //{
            //    helperRepository.ErrorMessage();
            //    return View(purchase);
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSaleReturn(long returnId, long saleId, DateTime returnDate, string returnNote, decimal subTotal, decimal rent, decimal tax, decimal totalDiscount,
            decimal totalAmount, decimal paidAmount, decimal balancedAmount, decimal[] returnedQty, decimal[] discount, decimal[] totalReturnPrice, long[] chkSaleDetailsId)
        {
            ViewBag.SaleId = saleId;
            var sale = saleRepository.GetSaleForEdit(saleId);

            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");


            ViewBag.EditReturn = returnRepository.GetReturnById(returnId);
            ViewBag.EditReturnDetails = returnRepository.GetSaleReturnDetailsByReturnId(returnId);

            //try
            //{
            if (chkSaleDetailsId.Length > 0)
            {
                var updatedRtn = returnRepository.GetReturnById(returnId);
                updatedRtn.ReturnDate = returnDate;
                updatedRtn.Description = returnNote;
                updatedRtn.SubTotal = subTotal;
                updatedRtn.RentAmount = rent;
                updatedRtn.TaxAmount = tax;
                updatedRtn.DiscountAmount = totalDiscount;
                updatedRtn.TotalAmount = totalAmount;
                updatedRtn.PaidAmount = paidAmount;
                updatedRtn.DueAmount = balancedAmount;

                List<ReturnDetails> list = new List<ReturnDetails>();
                for (int i = 0; i < chkSaleDetailsId.Length; i++)
                {
                    var saleDetails = saleRepository.GetSaleDetailsById(chkSaleDetailsId[i]);
                    ReturnDetails details = new ReturnDetails
                    {
                        ReturnId = returnId,
                        ProductId = saleDetails.ProductId,
                        UnitId = saleDetails.UnitId,
                        Qty = returnedQty[i],
                        UnitPrice = saleDetails.UnitPrice,
                        Discount = discount[i],
                        TotalReturnPrice = totalReturnPrice[i],
                        DetailsId = chkSaleDetailsId[i]
                    };
                    list.Add(details);
                }

                var res = returnRepository.UpdateSaleReturn(updatedRtn, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(SaleReturn));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(sale);
                }
            }
            else
            {
                helperRepository.ErrorMessage();
                return View(sale);
            }
            //}
            //catch
            //{
            //    helperRepository.ErrorMessage();
            //    return View(purchase);
            //}
        }

        // GET: ReturnController/Delete/5
        public ActionResult DeleteSaleReturn(long id)
        {
            var saleReturn = returnRepository.GetSaleReturn(id);
            return View(saleReturn);
        }

        public ActionResult DeletePurchaseReturn(long id)
        {
            var purchaseReturn = returnRepository.GetPurchaseReturn(id);
            return View(purchaseReturn);
        }

        public ActionResult DeleteWastage(long id)
        {
            return View();
        }

        // POST: ReturnController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePurchaseReturn(long returnId, long purchaseId)
        {
            var purchaseReturn = returnRepository.GetPurchaseReturn(returnId);

            try
            {
                var res = returnRepository.DeletePurchaseReturn(returnId, purchaseId);
                if (res)
                {
                    toastNotification.AddSuccessToastMessage();
                    return RedirectToAction(nameof(PurchaseReturn));
                }
                else
                {
                    toastNotification.AddErrorToastMessage();
                    return View(purchaseReturn);
                }
            }
            catch
            {
                return View(purchaseReturn);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSaleReturn(long returnId, long saleId)
        {
            var saleReturn = returnRepository.GetSaleReturn(returnId);

            try
            {
                var res = returnRepository.DeleteSaleReturn(returnId, saleId);
                if (res)
                {
                    toastNotification.AddSuccessToastMessage();
                    return RedirectToAction(nameof(SaleReturn));
                }
                else
                {
                    toastNotification.AddErrorToastMessage();
                    return View(saleReturn);
                }
            }
            catch
            {
                return View(saleReturn);
            }
        }

        [HttpGet]
        public ActionResult SaleReturnWithBarCodeReader()
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            ReturnViewModel model = new ReturnViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaleReturnWithBarCodeReader(ReturnViewModel returnModel, long[] ProductId, long[] UnitId, decimal[] UnitPrice, decimal[] Qty, decimal[] Discount, decimal[] TotalPrice)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");


            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (ProductId.Length > 0)
            {
                Return rtn = new Return
                {
                    SaleId = 0,
                    InvoiceNo = "",
                    Description = returnModel.Return.Description,
                    ReturnDate = returnModel.Return.ReturnDate,
                    SubTotal = returnModel.Return.SubTotal,
                    RentAmount = returnModel.Return.RentAmount,
                    TaxAmount = returnModel.Return.TaxAmount,
                    DiscountAmount = returnModel.Return.DiscountAmount,
                    TotalAmount = returnModel.Return.TotalAmount,
                    PaidAmount = returnModel.Return.PaidAmount,
                    DueAmount = returnModel.Return.DueAmount,
                    PaymentType = returnModel.Return.PaymentType,
                    BankId = returnModel.Return.BankId,
                    ReturnType = 0,
                    CustomerId = returnModel.Return.CustomerId
                };

                List<ReturnDetails> list = new List<ReturnDetails>();
                List<ReturnDetailsViewModel> returnDetailsList = new List<ReturnDetailsViewModel>();

                for (int i = 0; i < ProductId.Length; i++)
                {
                    var itemdiscount = (decimal)0;
                    if (Discount.Length != 0)
                    {
                        itemdiscount = Discount[i];
                    }

                    ReturnDetails details = new ReturnDetails
                    {
                        ReturnId = 0,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = itemdiscount,
                        TotalReturnPrice = TotalPrice[i],
                        DetailsId = 0
                    };
                    list.Add(details);

                    ReturnDetailsViewModel detailsModel = new ReturnDetailsViewModel
                    {
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = itemdiscount,
                        TotalPrice = TotalPrice[i]
                    };
                    returnDetailsList.Add(detailsModel);
                }

                returnModel.ReturnDetails = returnDetailsList; //in case of fail, page rendering ...

                var res = returnRepository.AddSaleReturn(rtn, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(SaleReturn));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(returnModel);
                }
            }
            else
            {
                return View(returnModel);
            }
            //}
            //catch
            //{
            //    return View(purchase);
            //}
            //}
            //else
            //{
            //    return View(purchase);
            //}
        }

        [HttpGet]
        public ActionResult EditSaleReturn2(long returnId)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            ReturnViewModel model = new ReturnViewModel();

            var rtn = returnRepository.GetReturnById(returnId);
            var rtnDetails = returnRepository.GetSaleReturnDetailsByReturnId(returnId);

            ReturnModelViewModel rtnModel = new ReturnModelViewModel
            {
                Id = rtn.Id,
                BankId = rtn.BankId,
                CreatedAt = rtn.CreatedAt,
                CustomerId = rtn.CustomerId,
                DeletedAt = rtn.DeletedAt,
                Description = rtn.Description,
                DiscountAmount = rtn.DiscountAmount,
                DueAmount = rtn.DueAmount,
                InvoiceNo = rtn.InvoiceNo,
                PaidAmount = rtn.PaidAmount,
                PaymentType = rtn.PaymentType,
                PurchaseId = rtn.PurchaseId,
                RentAmount = rtn.RentAmount,
                ReturnDate = rtn.ReturnDate,
                ReturnType = rtn.ReturnType,
                SaleId = rtn.SaleId,
                SubTotal = rtn.SubTotal,
                SupplierId = rtn.SupplierId,
                TaxAmount = rtn.TaxAmount,
                TotalAmount = rtn.TotalAmount,
                UpdatedAt = rtn.UpdatedAt,
                TransCode = rtn.TransCode
            };

            List<ReturnDetailsViewModel> returnDetailsList = new List<ReturnDetailsViewModel>();
            foreach (var d in rtnDetails)
            {
                var product = productRepository.GetByIdForUpdate(d.ProductId);
                var pName = product.Name; // + "-" + product.Model;

                ReturnDetailsViewModel detailsModel = new ReturnDetailsViewModel
                {
                    ReturnId = d.ReturnId,
                    ProductId = d.ProductId,
                    Product = d.Product,
                    UnitId = d.UnitId,
                    Unit = d.Unit,
                    Qty = d.Qty,
                    UnitPrice = d.UnitPrice,
                    Discount = d.Discount,
                    TotalPrice = d.TotalReturnPrice,
                    DetailsId = d.DetailsId
                };

                returnDetailsList.Add(detailsModel);
            }

            model.Return = rtnModel;
            model.ReturnDetails = returnDetailsList;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSaleReturn2(ReturnViewModel returnModel, long[] ProductId, long[] UnitId, decimal[] UnitPrice, decimal[] Qty, decimal[] Discount, decimal[] TotalPrice)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (ProductId.Length > 0)
            {
                Return rtn = new Return
                {
                    SaleId = 0,
                    InvoiceNo = "",
                    Description = returnModel.Return.Description,
                    ReturnDate = returnModel.Return.ReturnDate,
                    SubTotal = returnModel.Return.SubTotal,
                    RentAmount = returnModel.Return.RentAmount,
                    TaxAmount = returnModel.Return.TaxAmount,
                    DiscountAmount = returnModel.Return.DiscountAmount,
                    TotalAmount = returnModel.Return.TotalAmount,
                    PaidAmount = returnModel.Return.PaidAmount,
                    DueAmount = returnModel.Return.DueAmount,
                    PaymentType = returnModel.Return.PaymentType,
                    BankId = returnModel.Return.BankId,
                    ReturnType = 0,
                    CustomerId = returnModel.Return.CustomerId,
                    CreatedAt = returnModel.Return.CreatedAt,
                    Id = returnModel.Return.Id,
                    TransCode = returnModel.Return.TransCode
                };

                List<ReturnDetails> list = new List<ReturnDetails>();
                List<ReturnDetailsViewModel> returnDetailsList = new List<ReturnDetailsViewModel>();

                for (int i = 0; i < ProductId.Length; i++)
                {
                    var itemdiscount = (decimal)0;
                    if (Discount.Length != 0)
                    {
                        itemdiscount = Discount[i];
                    }

                    ReturnDetails details = new ReturnDetails
                    {
                        ReturnId = returnModel.Return.Id,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = itemdiscount,
                        TotalReturnPrice = TotalPrice[i],
                        DetailsId = 0
                    };
                    list.Add(details);

                    ReturnDetailsViewModel detailsModel = new ReturnDetailsViewModel
                    {
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = itemdiscount,
                        TotalPrice = TotalPrice[i]
                    };
                    returnDetailsList.Add(detailsModel);
                }

                returnModel.ReturnDetails = returnDetailsList; //in case of fail, page rendering ...

                var res = returnRepository.UpdateSaleReturn(rtn, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(SaleReturn));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(returnModel);
                }
            }
            else
            {
                return View(returnModel);
            }
            //}
            //catch
            //{
            //    return View(purchase);
            //}
            //}
            //else
            //{
            //    return View(purchase);
            //}
        }

        [HttpGet]
        public ActionResult PurchaseReturnWithBarCodeReader()
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetAllSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            ReturnViewModel model = new ReturnViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PurchaseReturnWithBarCodeReader(ReturnViewModel returnModel, long[] ProductId, long[] UnitId, decimal[] UnitPrice, decimal[] Qty, decimal[] Discount, decimal[] TotalPrice)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetAllSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (ProductId.Length > 0)
            {
                Return rtn = new Return
                {
                    SaleId = 0,
                    InvoiceNo = "",
                    PurchaseId = 0,
                    Description = returnModel.Return.Description,
                    ReturnDate = returnModel.Return.ReturnDate,
                    SubTotal = returnModel.Return.SubTotal,
                    RentAmount = returnModel.Return.RentAmount,
                    TaxAmount = returnModel.Return.TaxAmount,
                    DiscountAmount = returnModel.Return.DiscountAmount,
                    TotalAmount = returnModel.Return.TotalAmount,
                    PaidAmount = returnModel.Return.PaidAmount,
                    DueAmount = returnModel.Return.DueAmount,
                    PaymentType = returnModel.Return.PaymentType,
                    BankId = returnModel.Return.BankId,
                    ReturnType = 1,
                    SupplierId = returnModel.Return.SupplierId
                };

                List<ReturnDetails> list = new List<ReturnDetails>();
                List<ReturnDetailsViewModel> returnDetailsList = new List<ReturnDetailsViewModel>();

                for (int i = 0; i < ProductId.Length; i++)
                {
                    var itemdiscount = (decimal)0;
                    if (Discount.Length != 0)
                    {
                        itemdiscount = Discount[i];
                    }

                    ReturnDetails details = new ReturnDetails
                    {
                        ReturnId = 0,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = itemdiscount,
                        TotalReturnPrice = TotalPrice[i],
                        DetailsId = 0
                    };
                    list.Add(details);

                    ReturnDetailsViewModel detailsModel = new ReturnDetailsViewModel
                    {
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = itemdiscount,
                        TotalPrice = TotalPrice[i]
                    };
                    returnDetailsList.Add(detailsModel);
                }

                returnModel.ReturnDetails = returnDetailsList; //in case of fail, page rendering ...

                var res = returnRepository.AddPurchaseReturn(rtn, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(PurchaseReturn));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(returnModel);
                }
            }
            else
            {
                return View(returnModel);
            }
            //}
            //catch
            //{
            //    return View(purchase);
            //}
            //}
            //else
            //{
            //    return View(purchase);
            //}
        }

        [HttpGet]
        public ActionResult EditPurchaseReturn2(long returnId)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetAllSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            ReturnViewModel model = new ReturnViewModel();

            var rtn = returnRepository.GetReturnById(returnId);
            var rtnDetails = returnRepository.GetSaleReturnDetailsByReturnId(returnId);

            ReturnModelViewModel rtnModel = new ReturnModelViewModel
            {
                Id = rtn.Id,
                BankId = rtn.BankId,
                CreatedAt = rtn.CreatedAt,
                CustomerId = rtn.CustomerId,
                DeletedAt = rtn.DeletedAt,
                Description = rtn.Description,
                DiscountAmount = rtn.DiscountAmount,
                DueAmount = rtn.DueAmount,
                InvoiceNo = rtn.InvoiceNo,
                PaidAmount = rtn.PaidAmount,
                PaymentType = rtn.PaymentType,
                PurchaseId = rtn.PurchaseId,
                RentAmount = rtn.RentAmount,
                ReturnDate = rtn.ReturnDate,
                ReturnType = rtn.ReturnType,
                SaleId = rtn.SaleId,
                SubTotal = rtn.SubTotal,
                SupplierId = rtn.SupplierId,
                TaxAmount = rtn.TaxAmount,
                TotalAmount = rtn.TotalAmount,
                UpdatedAt = rtn.UpdatedAt,
                TransCode = rtn.TransCode
            };

            List<ReturnDetailsViewModel> returnDetailsList = new List<ReturnDetailsViewModel>();
            foreach (var d in rtnDetails)
            {
                var product = productRepository.GetByIdForUpdate(d.ProductId);
                var pName = product.Name;// + "-" + product.Model;

                ReturnDetailsViewModel detailsModel = new ReturnDetailsViewModel
                {
                    ReturnId = d.ReturnId,
                    ProductId = d.ProductId,
                    Product = d.Product,
                    UnitId = d.UnitId,
                    Unit = d.Unit,
                    Qty = d.Qty,
                    UnitPrice = d.UnitPrice,
                    Discount = d.Discount,
                    TotalPrice = d.TotalReturnPrice,
                    DetailsId = d.DetailsId
                };

                returnDetailsList.Add(detailsModel);
            }

            model.Return = rtnModel;
            model.ReturnDetails = returnDetailsList;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPurchaseReturn2(ReturnViewModel returnModel, long[] ProductId, long[] UnitId, decimal[] UnitPrice, decimal[] Qty, decimal[] Discount, decimal[] TotalPrice)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetAllSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            ViewBag.Products = new SelectList(productRepository.ProductsList(), "Id", "Name");
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            //if (ModelState.IsValid)
            //{

            //try
            //{

            if (ProductId.Length > 0)
            {
                Return rtn = new Return
                {
                    SaleId = 0,
                    InvoiceNo = "",
                    PurchaseId = 0,
                    Description = returnModel.Return.Description,
                    ReturnDate = returnModel.Return.ReturnDate,
                    SubTotal = returnModel.Return.SubTotal,
                    RentAmount = returnModel.Return.RentAmount,
                    TaxAmount = returnModel.Return.TaxAmount,
                    DiscountAmount = returnModel.Return.DiscountAmount,
                    TotalAmount = returnModel.Return.TotalAmount,
                    PaidAmount = returnModel.Return.PaidAmount,
                    DueAmount = returnModel.Return.DueAmount,
                    PaymentType = returnModel.Return.PaymentType,
                    BankId = returnModel.Return.BankId,
                    ReturnType = 1,
                    SupplierId = returnModel.Return.SupplierId,
                    CreatedAt = returnModel.Return.CreatedAt,
                    Id = returnModel.Return.Id,
                    TransCode = returnModel.Return.TransCode
                };

                List<ReturnDetails> list = new List<ReturnDetails>();
                List<ReturnDetailsViewModel> returnDetailsList = new List<ReturnDetailsViewModel>();

                for (int i = 0; i < ProductId.Length; i++)
                {
                    var itemdiscount = (decimal)0;
                    if (Discount.Length != 0)
                    {
                        itemdiscount = Discount[i];
                    }

                    ReturnDetails details = new ReturnDetails
                    {
                        ReturnId = returnModel.Return.Id,
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = itemdiscount,
                        TotalReturnPrice = TotalPrice[i],
                        DetailsId = 0
                    };
                    list.Add(details);

                    ReturnDetailsViewModel detailsModel = new ReturnDetailsViewModel
                    {
                        ProductId = ProductId[i],
                        UnitId = UnitId[i],
                        Qty = Qty[i],
                        UnitPrice = UnitPrice[i],
                        Discount = itemdiscount,
                        TotalPrice = TotalPrice[i]
                    };
                    returnDetailsList.Add(detailsModel);
                }

                returnModel.ReturnDetails = returnDetailsList; //in case of fail, page rendering ...

                var res = returnRepository.UpdatePurchaseReturn(rtn, list);
                if (res)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(PurchaseReturn));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(returnModel);
                }
            }
            else
            {
                return View(returnModel);
            }
            //}
            //catch
            //{
            //    return View(purchase);
            //}
            //}
            //else
            //{
            //    return View(purchase);
            //}
        }



    }
}
