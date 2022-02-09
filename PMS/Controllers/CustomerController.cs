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
    public class CustomerController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ICustomerRepository customerRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IShopRepository shopRepository;
        public CustomerController(IToastNotification toastNotification,
            ICustomerRepository customerRepository,
            IHelperRepository helperRepository, IWebHostEnvironment webHostEnvironment, IShopRepository shopRepository)
        {
            this.toastNotification = toastNotification;
            this.customerRepository = customerRepository;
            this.helperRepository = helperRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.shopRepository = shopRepository;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            var customerList = customerRepository.GetAllCustomer();
            return View(customerList);
        }

        [HttpGet]
        public decimal GetCustomerLedgerBelance(long CustomerId)
        {
            var Belance = customerRepository.GetCLedgerBelance(CustomerId);
            return Belance;
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(long id)
        {
            if (id == 0)
            {
                helperRepository.InfoMessage("Walking cusotmer recorde is not avalible");
                return RedirectToAction("Index", "Sale", new { CustomerIdNotFound = id });
            }

            var customerDetails = customerRepository.GetCustomerDetails(id);
            return View(customerDetails);
        }

        // GET: CustomerController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");

            return View(new Customer());
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");

            try
            {
                bool flag = false;
                var res = customerRepository.AddCustomer(customer);
                if (res != null)
                {
                    flag = true;
                }

                if (flag)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(customer);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(customer);
            }
        }

        // GET: CustomerController/Edit
        [HttpGet]
        public ActionResult Edit(long id)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");

            var customer = customerRepository.GetByIdForUpdate(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: CustomerController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Customer customer)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");
            try
            {
                bool flag = false;
                var res = customerRepository.UpdateCustomer(customer);
                if (res != null)
                {
                    flag = true;
                }
                if (flag)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction("Create", "Sale", new { });
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(customer);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(customer);
            }
        }


        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            bool isDeleted = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var res = customerRepository.DeleteCustomer(id);
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


        //Ledger Action Methods

        // Method: CustomerController/GetAllLedgers/
        public ActionResult GetAllLedgers()
        {
            ViewBag.Customer = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            var customerLedgers = customerRepository.GetCustomerLedgers(0, null, null);

            return View(customerLedgers);
        }

        // Method: CustomerController/GetLedgerById/
        public ActionResult GetLedgerById(long customerId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Customer = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            var customerLedgers = customerRepository.GetCustomerLedgers(0, null, null);

            if (customerId != 0 && startDate != null && endDate != null)
            {
                customerLedgers = customerRepository.GetCustomerLedgers(customerId, startDate, endDate);
                var cpp = customerRepository.GetByIdCustomer(customerId);
                ViewBag.CustomerName = cpp.Name;
                ViewBag.CustomerPhone = cpp.Phone;
                ViewBag.CustomerAddress = cpp.Address;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;

                return View(customerLedgers);
            }
            else if (customerId == 0 && startDate != null && endDate != null)
            {
                customerLedgers = customerRepository.GetCustomerLedgers(0, startDate, endDate);
                ViewBag.CustomerName = null;
                ViewBag.CustomerPhone = null;
                ViewBag.CustomerAddress = null;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;
                return View(customerLedgers);
            }
            else if (customerId != 0 && startDate == null && endDate == null)
            {
                customerLedgers = customerRepository.GetCustomerLedgers(customerId, null, null);
                var cpp = customerRepository.GetByIdCustomer(customerId);
                ViewBag.CustomerName = cpp.Name;
                ViewBag.CustomerPhone = cpp.Phone;
                ViewBag.CustomerAddress = cpp.Address;
                ViewBag.StartDate = null;
                ViewBag.EndDate = null;
                return View(customerLedgers);
            }
            else
            {
                helperRepository.AlertMessage("Please enter correct filter details!");
                return View("GetAllLedgers", customerLedgers);
            }
        }


        public ActionResult Receives()
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            var models = customerRepository.GetCustomerReceives();
            return View(models);
        }

        public ActionResult Receives_by_Customer(long customerId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            var models = customerRepository.GetCustomerReceives(customerId, startDate, endDate);
            return View("Receives", models);
        }

        public ActionResult CreateReceive()
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateReceive(CustomerReceive customer)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    bool flag = false;
                    var res = customerRepository.AddCustomerReceive(customer);
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
                        return View(customer);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                    return View(customer);
                }
            }

            toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
            return View(customer);
        }

        public ActionResult EditReceive(long id)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            var model = customerRepository.GetCustomerReceive(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditReceive(CustomerReceive customer)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    bool flag = false;
                    var res = customerRepository.EditCustomerReceive(customer);
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
                        return View(customer);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                    return View(customer);
                }
            }

            toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
            return View(customer);
        }

        public ActionResult Advances()
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            var models = customerRepository.GetCustomerAdvances();
            return View(models);
        }

        public ActionResult Advances_by_Customer(long customerId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            var models = customerRepository.GetCustomerAdvances(customerId, startDate, endDate);
            return View("Advances", models);
        }

        public ActionResult CreateAdvance()
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAdvance(CustomerAdvanced customer)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    bool flag = false;
                    var res = customerRepository.AddCustomerAdvance(customer);
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
                        return View(customer);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                    return View(customer);
                }
            }

            toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
            return View(customer);
        }

        public ActionResult EditAdvance(long id)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            var model = customerRepository.GetCustomerAdvance(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAdvance(CustomerAdvanced customer)
        {
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    bool flag = false;
                    var res = customerRepository.EditCustomerAdvance(customer);
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
                        return View(customer);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                    return View(customer);
                }
            }

            toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
            return View(customer);
        }


        public ActionResult PrintDiv(long customerid, DateTime? startDate, DateTime? endDate)
        {
            var shop = shopRepository.GetShop();
            ViewBag.ShopName = shop.Name_en;
            ViewBag.Email = shop.Email1;
            ViewBag.Phone = shop.Phone1;
            ViewBag.Address = shop.Address_en;
            return View(customerRepository.GetCustomerLedgers(customerid, startDate, endDate));
        }


        public ActionResult PrintCustomerLedger(long customerid, DateTime? startDate, DateTime? endDate)
        {
            string mimeType = "";

            int extension = 1;

            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\CustomerLedger.rdlc";

            var shop = shopRepository.GetShop();

            var customerLedger = customerRepository.GetCustomerLedgers(customerid, startDate, endDate);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);
            parameters.Add("startDate", startDate.ToString());
            parameters.Add("endDate", endDate.ToString());
            parameters.Add("customerid", customerid.ToString());
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("customerLedger", customerLedger);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);
            return File(res.MainStream, "application/pdf");
        }


        // GET: SupplierController/Create
        [HttpGet]
        public ActionResult CreatePartial()
        {
            Customer customerModel = new Customer();

            return PartialView("_CreatePartialView", customerModel);
        }


        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePartial(Customer customer)
        {
            try
            {

                var res = customerRepository.AddCustomer(customer);
                if (res != null)
                {
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    helperRepository.ErrorMessage();
                    return View(customer);
                }
            }
            catch
            {
                helperRepository.WarningMessage("Please Check your data");
                return View(customer);
            }
        }

    }
}