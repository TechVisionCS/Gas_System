using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models.OfficeLoan;
using PMS.Repositories.IRepositories;
using System;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class OfficeLoanController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly IOfficeLoanRepository officeLoanRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IShopRepository shopRepository;

        public OfficeLoanController(IToastNotification toastNotification,
            IOfficeLoanRepository officeLoanRepository,
            IHelperRepository helperRepository, IWebHostEnvironment webHostEnvironment, IShopRepository shopRepository)
        {
            this.toastNotification = toastNotification;
            this.officeLoanRepository = officeLoanRepository;
            this.helperRepository = helperRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.shopRepository = shopRepository;
        }


        public IActionResult Index()
        {
            return View(officeLoanRepository.GetAllOfficePerson());
        }

        public ActionResult Details(long id)
        {
            return View(officeLoanRepository.GetOfficePersonDetails(id));
        }

        public ActionResult GetAllLedgers()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            var PersonLedger = officeLoanRepository.GetOfficePersonLedgers(0, null, null);
            return View(PersonLedger);
        }

        public ActionResult GetLedgerById(long personId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            var personLedger = officeLoanRepository.GetOfficePersonLedgers(0, null, null);

            if (personId != 0 && startDate != null && endDate != null)
            {
                personLedger = officeLoanRepository.GetOfficePersonLedgers(personId, startDate, endDate);
                var spp = officeLoanRepository.GetByIdOfficePerson(personId);
                ViewBag.PersonName = spp.Name;
                ViewBag.PersonPhone = spp.Phone;
                ViewBag.PersonFatherName = spp.FatherName;
                ViewBag.PersonAddress = spp.Address;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;
                return View(personLedger);
            }

            else if (personId == 0 && startDate != null && endDate != null)
            {
                personLedger = officeLoanRepository.GetOfficePersonLedgers(0, startDate, endDate);
                ViewBag.PersonName = null;
                ViewBag.PersonPhone = null;
                ViewBag.PersonFatherName = null;
                ViewBag.PersonAddress = null;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;
                return View(personLedger);
            }

            else if (personId != 0 && startDate == null && endDate == null)
            {
                personLedger = officeLoanRepository.GetOfficePersonLedgers(personId, null, null);
                var spp = officeLoanRepository.GetByIdOfficePerson(personId);
                ViewBag.PersonName = spp.Name;
                ViewBag.PersonFatherName = spp.FatherName;
                ViewBag.PersonPhone = spp.Phone;
                ViewBag.PersonAddress = spp.Address;
                ViewBag.StartDate = null;
                ViewBag.EndDate = null;
                return View(personLedger);
            }
            else
            {
                helperRepository.AlertMessage("Please enter correct filter details!");
                return View("GetAllLedgers", personLedger);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new OfficePerson());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OfficePerson person)
        {
            try
            {
                bool flag = false;
                var res = officeLoanRepository.AddOfficePerson(person);
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
                    return View(person);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(person);
            }
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var person = officeLoanRepository.GetOfficePersonByIdForUpdate(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, OfficePerson person, int sbm_flg)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res = officeLoanRepository.UpdateOfficePerson(person);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(person);
                    }

                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(person);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(person);
            }
        }

        [HttpPost]
        public ActionResult Delete(long id)
        {
            bool isDeleted = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var res = officeLoanRepository.DeleteOfficePerson(id);
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

        //Office Loan Payments

        public ActionResult OfficeLoanPayments()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            var models = officeLoanRepository.GetOfficePersonPayments();
            return View(models);
        }

        public ActionResult Payments_to_officeLoan(long personId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            var models = officeLoanRepository.GetOfficePersonPayments(personId, startDate, endDate);
            return View("OfficeLoanPayments", models);
        }

        [HttpGet]
        public ActionResult CreatePayment()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePayment(OfficeLoanPayment officeLoanPayments)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            try
            {
                if (ModelState.IsValid)
                {
                    var res = officeLoanRepository.AddOfficePersonPayment(officeLoanPayments);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(OfficeLoanPayments));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(officeLoanPayments);
                    }

                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(officeLoanPayments);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(officeLoanPayments);
            }
        }

        [HttpGet]
        public ActionResult EditPayment(long id)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            var personModel = officeLoanRepository.GetOfficePersonPaymentbyId(id);
            if (personModel == null)
            {
                return NotFound();
            }
            return View(personModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPayment(OfficeLoanPayment officeLoanEdit)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            try
            {
                if (ModelState.IsValid)
                {
                    var res = officeLoanRepository.EditOfficePersonPayment(officeLoanEdit);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(OfficeLoanPayments));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(officeLoanEdit);
                    }

                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(officeLoanEdit);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(officeLoanEdit);
            }
        }


        // Loan Receives from Person Back

        public ActionResult LoanReceives()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            var models = officeLoanRepository.GetOfficePersonLoanReceives();
            return View(models);
        }

        public ActionResult Receives_Loan_from_Person(long personId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            var models = officeLoanRepository.GetOfficePersonLoanReceives(personId, startDate, endDate);
            return View("LoanReceives", models);
        }

        public ActionResult CreateReceive()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateReceive(OfficeLoanReceive LoanRecevie)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            try
            {
                if (ModelState.IsValid)
                {
                    var res = officeLoanRepository.AddOfficePersonLoanReceive(LoanRecevie);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(LoanReceives));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(LoanRecevie);
                    }

                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(LoanRecevie);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(LoanRecevie);
            }
        }

        [HttpGet]
        public ActionResult EditReceive(long id)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            var personReceiveModel = officeLoanRepository.GetOfficePersonLoanReceivesById(id);
            if (personReceiveModel == null)
            {
                return NotFound();
            }
            return View(personReceiveModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditReceive(OfficeLoanReceive LoanReceivesEdit)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetOfficeLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            try
            {
                if (ModelState.IsValid)
                {
                    var res = officeLoanRepository.EditOfficePersonLoanReceives(LoanReceivesEdit);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(LoanReceives));

                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(LoanReceivesEdit);
                    }
                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(LoanReceivesEdit);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(LoanReceivesEdit);
            }
        }

        public ActionResult PrintPersonalLoanLedger(long personId, DateTime? startDate, DateTime? endDate)
        {
            string mimeType = "";
            int extension = 1;
            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\OfficePersonLoanLedger.rdlc";
            var shop = shopRepository.GetShop();
            var OfficePersonLedger = officeLoanRepository.GetOfficePersonLedgers(personId, startDate, endDate);
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("startDate", startDate.ToString());
            parameters.Add("endDate", endDate.ToString());
            parameters.Add("personId", personId.ToString());

            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("OfficePersonLedger", OfficePersonLedger);
            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);
            return File(res.MainStream, "application/pdf");
        }
    }
}
