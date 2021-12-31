using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models;
using PMS.Repositories.IRepositories;
using System;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class SupplierController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ISupplierRepository supplierRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IShopRepository shopRepository;
        public SupplierController(IHelperRepository helperRepository,
                                IToastNotification toastNotification,
                                ISupplierRepository supplierRepository, IWebHostEnvironment webHostEnvironment, IShopRepository shopRepository)
        {
            this.toastNotification = toastNotification;
            this.supplierRepository = supplierRepository;
            this.helperRepository = helperRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.shopRepository = shopRepository;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        // GET: SupplierController
        public ActionResult Index()
        {
            var SupplierList = supplierRepository.GetAllSupplier();
            return View(SupplierList);
        }

        // GET: SupplierController/Details/5
        public ActionResult Details(long id)
        {
            var supplierDetails = supplierRepository.GetSupplierDetails(id);
            return View(supplierDetails);
        }

        [HttpGet]
        public decimal GetSupplierLedgerBelance(long SupplierId)
        {
            var qty = supplierRepository.GetSBelance(SupplierId);
            return qty;
        }


        // GET: SupplierController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            return View(new Supplier());
        }


        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Supplier supplier)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");

            try
            {
                bool flag = false;
                var res = supplierRepository.AddSupplier(supplier);
                if (res != null)
                {
                    flag = true;
                }

                if (flag)
                {
                    toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(supplier);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(supplier);
            }
        }


        // GET: SupplierController/Edit
        [HttpGet]
        public ActionResult Edit(long id)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");

            var supplier = supplierRepository.GetByIdForUpdate(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }


        // POST: SupplierController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Supplier supplier)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");
            try
            {
                bool flag = false;
                var res = supplierRepository.UpdateSupplier(supplier);
                if (res != null)
                {
                    flag = true;
                }
                if (flag)
                {
                    toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(supplier);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(supplier);
            }
        }


        // POST: SupplierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long Id)
        {
            try
            {
                bool flag = false;
                var res = supplierRepository.DeleteSupplier(Id);
                if (res)
                {
                    flag = true;
                }
                if (flag)
                {
                    toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return RedirectToAction("Index");
            }
        }


        //Ledger Action Methods

        public ActionResult GetAllLedgers()
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            var supplierLedgers = supplierRepository.GetSupplierLedgers(0, null, null);

            return View(supplierLedgers);
        }

        public ActionResult GetLedgerById(long supplierId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            var supplierLedgers = supplierRepository.GetSupplierLedgers(0, null, null);

            if (supplierId != 0 && startDate != null && endDate != null)
            {
                supplierLedgers = supplierRepository.GetSupplierLedgers(supplierId, startDate, endDate);
                var spp = supplierRepository.GetByIdSupplier(supplierId);
                ViewBag.SupplierName = spp.Name;
                ViewBag.SupplierPhone = spp.Phone;
                ViewBag.SupplierAddress = spp.Address;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;

                return View(supplierLedgers);
            }
            else if (supplierId == 0 && startDate != null && endDate != null)
            {
                supplierLedgers = supplierRepository.GetSupplierLedgers(0, startDate, endDate);
                ViewBag.SupplierName = null;
                ViewBag.SupplierPhone = null;
                ViewBag.SupplierAddress = null;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;
                return View(supplierLedgers);
            }
            else if (supplierId != 0 && startDate == null && endDate == null)
            {
                supplierLedgers = supplierRepository.GetSupplierLedgers(supplierId, null, null);
                var spp = supplierRepository.GetByIdSupplier(supplierId);
                ViewBag.SupplierName = spp.Name;
                ViewBag.SupplierPhone = spp.Phone;
                ViewBag.SupplierAddress = spp.Address;
                ViewBag.StartDate = null;
                ViewBag.EndDate = null;
                return View(supplierLedgers);
            }
            else
            {
                helperRepository.AlertMessage("Please enter correct filter details!");
                return View("GetAllLedgers", supplierLedgers);
            }
        }

        public ActionResult Payments()
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            var models = supplierRepository.GetSupplierPayments();
            return View(models);
        }

        public ActionResult Payments_by_Supplier(long supplierId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            var models = supplierRepository.GetSupplierPayments(supplierId, startDate, endDate);
            return View("Payments", models);
        }

        public ActionResult CreatePayment()
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePayment(SupplierPayment supplier)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    bool flag = false;
                    var res = supplierRepository.AddSupplierPayment(supplier);
                    if (res != null)
                    {
                        flag = true;
                    }

                    if (flag)
                    {
                        toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                        return View(supplier);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                    return View(supplier);
                }
            }

            toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
            return View(supplier);
        }

        public ActionResult EditPayment(long id)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            var model = supplierRepository.GetSupplierPayment(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPayment(SupplierPayment supplier)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    bool flag = false;
                    var res = supplierRepository.EditSupplierPayment(supplier);
                    if (res != null)
                    {
                        flag = true;
                    }

                    if (flag)
                    {
                        toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                        return View(supplier);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                    return View(supplier);
                }
            }

            toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
            return View(supplier);
        }


        public ActionResult Advances()
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            var models = supplierRepository.GetSupplierAdvanceds();
            return View(models);
        }

        public ActionResult Advances_by_Supplier(long supplierId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            var models = supplierRepository.GetSupplierAdvanceds(supplierId, startDate, endDate);
            return View("Advances", models);
        }

        public ActionResult CreateAdvance()
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAdvance(SupplierAdvanced supplier)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    bool flag = false;
                    var res = supplierRepository.AddSupplierAdvanced(supplier);
                    if (res != null)
                    {
                        flag = true;
                    }

                    if (flag)
                    {
                        toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                        return View(supplier);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                    return View(supplier);
                }
            }

            toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
            return View(supplier);
        }

        public ActionResult EditAdvance(long id)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            var model = supplierRepository.GetSupplierAdvanced(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAdvance(SupplierAdvanced supplier)
        {
            ViewBag.Suppliers = new SelectList(helperRepository.GetSupplier(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    bool flag = false;
                    var res = supplierRepository.EditSupplierAdvanced(supplier);
                    if (res != null)
                    {
                        flag = true;
                    }

                    if (flag)
                    {
                        toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                        return View(supplier);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                    return View(supplier);
                }
            }

            toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
            return View(supplier);
        }


        public ActionResult PrintDiv(long supplierid, DateTime? startDate, DateTime? endDate)
        {
            var shop = shopRepository.GetShop();
            ViewBag.ShopName = shop.Name_en;
            ViewBag.Email = shop.Email1;
            ViewBag.Phone = shop.Phone1;
            ViewBag.Address = shop.Address_en;
            return View(supplierRepository.GetSupplierLedgers(supplierid, startDate, endDate));
        }

        public ActionResult PrintSupplierLedger(long supplierId, DateTime? startDate, DateTime? endDate)
        {
            string mimeType = "";

            int extension = 1;

            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\SupplierLedger.rdlc";

            var shop = shopRepository.GetShop();

            var supplierLedger = supplierRepository.GetSupplierLedgers(supplierId, startDate, endDate);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("startDate", startDate.ToString());
            parameters.Add("endDate", endDate.ToString());
            parameters.Add("supplierId", supplierId.ToString());

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("supplierLedger", supplierLedger);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);

            return File(res.MainStream, "application/pdf");
        }
    }
}