using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models;
using PMS.Models.Service;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.Service;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly IServiceRepository serviceRepository;
        private readonly IHelperRepository helperRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IShopRepository shopRepository;
        public ServiceController(IToastNotification toastNotification,
            IServiceRepository serviceRepository,
            IHelperRepository helperRepository,
        ICustomerRepository customerRepository, IWebHostEnvironment webHostEnvironment, IShopRepository shopRepository)
        {
            this.toastNotification = toastNotification;
            this.serviceRepository = serviceRepository;
            this.helperRepository = helperRepository;
            this.customerRepository = customerRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.shopRepository = shopRepository;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        // GET: ServiceController
        public ActionResult Index()
        {
            return View(serviceRepository.GetAllServices());
        }
        public ActionResult ViewServiceDetails(long id)
        {
            var details = serviceRepository.GetAllServiceDetails(id);
            return PartialView("_ViewServiceDetailsPartials", details);
        }

        // GET: ServiceController/Details/5
        public ActionResult Details(int id)
        {
            return View(serviceRepository.GetService(id));
        }

        public ActionResult LoadDetails()
        {
            ViewBag.Category = new SelectList(helperRepository.GetServiceCategories(), "Id", "Name");
            return PartialView("_ServiceDetailsPartial");
        }

        // GET: ServiceController/Create
        public ActionResult Create()
        {
            ViewBag.ServiceDetailsFlg = 0;

            ViewBag.InvoiceNo = serviceRepository.GetInvoiceNo();
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            return View(new CreateServiceViewModel());
        }

        // POST: ServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateServiceViewModel serviceViewModel, long[] ServiceCatergoryId, decimal[] Qty, decimal[] Fee_Charges, decimal[] Discount, decimal[] TotalServicePrice, string[] Descriptions, int sbm_flg)
        {
            ViewBag.ServiceDetailsFlg = 1;

            ViewBag.InvoiceNo = serviceRepository.GetInvoiceNo();
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            decimal totalServicePrice = 0;

            List<ServiceDetails> list = new List<ServiceDetails>();

            if (ServiceCatergoryId.Length > 0)
            {
                for (int i = 0; i < ServiceCatergoryId.Length; i++)
                {
                    ServiceDetails model = new ServiceDetails
                    {
                        ServiceId = 0,
                        ServiceCatergoryId = ServiceCatergoryId[i],
                        Qty = Qty[i],
                        Fee_Charges = Fee_Charges[i],
                        Discount = Discount[i],
                        TotalServicePrice = TotalServicePrice[i],
                        Descriptions = Descriptions[i]
                    };

                    list.Add(model);

                    totalServicePrice += model.TotalServicePrice;
                }

                serviceViewModel.Services.SubTotal = totalServicePrice;

                serviceViewModel.ServiceDetails = list;
                try
                {
                    var res = serviceRepository.AddService(serviceViewModel);

                    if (res != 0)
                    {
                        helperRepository.SuccessMessage();

                        if (sbm_flg == 0)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            return RedirectToAction("PrintDiv", "Service", new { Id = res });
                        }
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(serviceViewModel);
                    }

                }
                catch
                {
                    return View();
                }
            }
            else
            {
                toastNotification.AddErrorToastMessage("No Services available !");
                return View(serviceViewModel);
            }
        }

        // Edit Sections 
        public ActionResult LoadDetailsForEdit()
        {
            ViewBag.Category = new SelectList(helperRepository.GetServiceCategories(), "Id", "Name");
            return PartialView("_ServiceDetailsPartialEdit");
        }

        // GET: ServiceController/Edit/5
        public ActionResult Edit(long id)
        {
            var service = serviceRepository.GetServiceForEdit(id);

            ViewBag.Category = new SelectList(helperRepository.GetServiceCategories(), "Id", "Name");
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            return View(service);
        }

        // POST: ServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateServiceViewModel serviceViewModel, long[] ServiceCatergoryId, decimal[] Qty, decimal[] Fee_Charges, decimal[] Discount, decimal[] TotalServicePrice, string[] Descriptions)
        {
            ViewBag.Category = new SelectList(helperRepository.GetServiceCategories(), "Id", "Name");
            ViewBag.Customers = new SelectList(helperRepository.GetCustomer(), "Id", "Name");
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            decimal totalServicePrice = 0;

            List<ServiceDetails> list = new List<ServiceDetails>();

            if (ServiceCatergoryId.Length > 0)
            {
                for (int i = 0; i < ServiceCatergoryId.Length; i++)
                {
                    ServiceDetails model = new ServiceDetails
                    {
                        ServiceCatergoryId = ServiceCatergoryId[i],
                        Qty = Qty[i],
                        Fee_Charges = Fee_Charges[i],
                        Discount = Discount[i],
                        TotalServicePrice = TotalServicePrice[i],
                        Descriptions = Descriptions[i]
                    };

                    list.Add(model);
                    totalServicePrice += model.TotalServicePrice;
                }

                serviceViewModel.Services.SubTotal = totalServicePrice;
                serviceViewModel.ServiceDetails = list;

                try
                {
                    var res = serviceRepository.EditService(serviceViewModel);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(serviceViewModel);
                    }
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                toastNotification.AddErrorToastMessage("No Services available !");
                return View(serviceViewModel);
            }
        }

        // GET: ServiceController/Delete /
        public ActionResult Delete(long id)
        {
            bool isDeleted = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var res = serviceRepository.DeleteService(id);
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
        // local methods

        [HttpGet]
        public decimal GetCategoryFeePrice(long CategoryId)
        {
            var price = serviceRepository.GetFeePrice(CategoryId);
            return price;
        }

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
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(GetCustomer));
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



        //Bill Print ...

        public ActionResult PrintDiv(long Id)
        {
            return View(serviceRepository.GetService(Id));
        }

        public ActionResult PrintInvoice(long id)
        {
            string mimeType = "";
            int extension = 1;
            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\ServiceInvoice.rdlc";

            var shop = shopRepository.GetShop();
            var service = serviceRepository.GetService(id).ServiceViewModel;
            var serviceDetails = serviceRepository.GetService(id).ServiceDetailViewModels;

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("invoiceNo", service.InvoiceNo);
            parameters.Add("invoiceDate", service.ServiceDate.ToString());
            parameters.Add("description", service.Description);
            parameters.Add("customerId", service.CustomerId.ToString());
            parameters.Add("customerName", service.CustomerName);
            parameters.Add("CustomeraAddress", service.CustomeraAddress);
            parameters.Add("CustomerPhone", service.CustomerPhone);
            parameters.Add("CustomerEmail", service.CustomerEmail);

            parameters.Add("subTotal", service.SubTotal.ToString());
            parameters.Add("tax", service.TaxAmount.ToString());
            parameters.Add("discount", service.DiscountAmount.ToString());
            parameters.Add("netTotal", service.TotalAmount.ToString());
            parameters.Add("paid", service.PaidAmount.ToString());
            parameters.Add("due", service.DueAmount.ToString());

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("serviceDetails", serviceDetails);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);

            return File(res.MainStream, "application/pdf");
        }


    }
}
