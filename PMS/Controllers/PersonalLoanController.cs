using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models.PersonalLoan;
using PMS.Repositories.IRepositories;
using System;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class PersonalLoanController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly IPersonalLoanRepository personalLoanRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IShopRepository shopRepository;

        public PersonalLoanController(IToastNotification toastNotification,
            IPersonalLoanRepository personalLoanRepository,
            IHelperRepository helperRepository, IWebHostEnvironment webHostEnvironment, IShopRepository shopRepository)
        {
            this.toastNotification = toastNotification;
            this.personalLoanRepository = personalLoanRepository;
            this.helperRepository = helperRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.shopRepository = shopRepository;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }


        public IActionResult Index()
        {
            return View(personalLoanRepository.GetAllPerson());
        }

        public ActionResult Details(long id)
        {
            return View(personalLoanRepository.GetPersonDetails(id));
        }

        public ActionResult GetAllLedgers()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            var PersonLedger = personalLoanRepository.GetPersonLedgers(0, null, null);
            return View(PersonLedger);
        }

        public ActionResult GetLedgerById(long personId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            var personLedger = personalLoanRepository.GetPersonLedgers(0, null, null);

            if (personId != 0 && startDate != null && endDate != null)
            {
                personLedger = personalLoanRepository.GetPersonLedgers(personId, startDate, endDate);
                var spp = personalLoanRepository.GetByIdPerson(personId);
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
                personLedger = personalLoanRepository.GetPersonLedgers(0, startDate, endDate);
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
                personLedger = personalLoanRepository.GetPersonLedgers(personId, null, null);
                var spp = personalLoanRepository.GetByIdPerson(personId);
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
            return View(new Person());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res = personalLoanRepository.AddPerson(person);

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

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var person = personalLoanRepository.GetByIdForUpdate(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res = personalLoanRepository.UpdatePerson(person);

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
                    var res = personalLoanRepository.DeletePerson(id);
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

        //Personal Loan Payments
        public ActionResult LoanPayments()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            var models = personalLoanRepository.GetPersonPayments();
            return View(models);
        }

        public ActionResult Payments_To_PeronalLoan(long personId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            var models = personalLoanRepository.GetPersonPayments(personId, startDate, endDate);
            return View("LoanPayments", models);
        }

        [HttpGet]
        public ActionResult CreatePayment()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePayment(PersonalLoanPayment personalLoan, int sbm_flg)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            try
            {
                if (ModelState.IsValid)
                {
                    var res = personalLoanRepository.AddPersonPayment(personalLoan);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(LoanPayments));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(personalLoan);
                    }

                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(personalLoan);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(personalLoan);
            }
        }

        [HttpGet]
        public ActionResult EditPayment(long id)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            var personModel = personalLoanRepository.GetPersonPaymentbyId(id);
            if (personModel == null)
            {
                return NotFound();
            }
            return View(personModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPayment(PersonalLoanPayment personalLoan)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            try
            {
                if (ModelState.IsValid)
                {
                    var res = personalLoanRepository.EditPersonPayment(personalLoan);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(LoanPayments));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(personalLoan);
                    }

                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(personalLoan);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(personalLoan);
            }
        }

        // Loan Receives from Person Back

        public ActionResult LoanReceives()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            var models = personalLoanRepository.GetPersonLoanReceives();
            return View(models);
        }

        public ActionResult Receives_Loan_from_Person(long personId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            var models = personalLoanRepository.GetPersonLoanReceives(personId, startDate, endDate);
            return View("LoanReceives", models);
        }

        public ActionResult CreateReceive()
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateReceive(PersonalLoanReceive personalLoan)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            try
            {
                if (ModelState.IsValid)
                {
                    var res = personalLoanRepository.AddPersonLoanReceive(personalLoan);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(LoanReceives));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(personalLoan);
                    }

                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(personalLoan);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(personalLoan);
            }
        }

        [HttpGet]
        public ActionResult EditReceive(long id)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            var personReceiveModel = personalLoanRepository.GetPersonLoanReceivesById(id);
            if (personReceiveModel == null)
            {
                return NotFound();
            }
            return View(personReceiveModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditReceive(PersonalLoanReceive personalLoan)
        {
            ViewBag.Persons = new SelectList(helperRepository.GetLoanPersons(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            try
            {
                if (ModelState.IsValid)
                {
                    var res = personalLoanRepository.EditPersonLoanReceives(personalLoan);

                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(LoanReceives));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(personalLoan);
                    }

                }
                else
                {
                    helperRepository.WarningMessage("Please check your form and then submit it!");
                    return View(personalLoan);
                }
            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(personalLoan);
            }
        }


        public ActionResult PrintPersonalLoanLedger(long personId, DateTime? startDate, DateTime? endDate)
        {
            string mimeType = "";
            int extension = 1;
            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\PersonalLoanLedger.rdlc";
            var shop = shopRepository.GetShop();
            var personloanLedger = personalLoanRepository.GetPersonLedgers(personId, startDate, endDate);
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("startDate", startDate.ToString());
            parameters.Add("endDate", endDate.ToString());
            parameters.Add("personId", personId.ToString());

            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("personloanLedger", personloanLedger);
            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);
            return File(res.MainStream, "application/pdf");
        }

    }
}
