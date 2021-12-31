using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models;
using PMS.Repositories.IRepositories;
using System;

namespace PMS.Controllers
{
    public class PartnerController : Controller
    {
        private readonly IPartnerRepository partnerRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IToastNotification toastNotification;

        public PartnerController(IPartnerRepository partnerRepository,
                                IHelperRepository helperRepository,
                                IToastNotification toastNotification)
        {
            this.partnerRepository = partnerRepository;
            this.helperRepository = helperRepository;
            this.toastNotification = toastNotification;
        }

        // GET: PartnerController
        public ActionResult Index()
        {
            var partnerList = partnerRepository.GetAllPartner();
            return View(partnerList);
        }

        // GET: PartnerController/Details/5
        public ActionResult Details(long id)
        {
            var partnerDetails = partnerRepository.GetPartnerDetails(id);
            return View(partnerDetails);
        }

        // GET: PartnerController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            return View(new Partner());
        }

        // POST: PartnerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Partner partner)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");

            partner.PreviousBalance = 0;

            try
            {
                bool flag = false;
                var res = partnerRepository.AddPartner(partner);
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
                    return View(partner);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(partner);
            }
        }


        // GET: partnerController/Edit
        [HttpGet]
        public ActionResult Edit(long id)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");

            var partner = partnerRepository.GetByIdForUpdate(id);
            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        // POST: partnerController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Partner partner)
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");
            try
            {
                bool flag = false;
                var res = partnerRepository.UpdatePartner(partner);
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
                    return View(partner);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(partner);
            }
        }


        // POST: PartnerController/Delete/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long Id)
        {
            try
            {
                bool flag = false;
                var res = partnerRepository.DeletePartner(Id);
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


        //Local  Action Methods Defined 

        // Method: PartnerController/GetAllLedgers/
        public ActionResult GetAllLedgers()
        {
            ViewBag.Partner = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            var partnerLedgers = partnerRepository.GetPartnerLedgers(0, null, null);

            return View(partnerLedgers);
        }


        // Method: PartnerController/GetLedgerById/
        public ActionResult GetLedgerById(long partnerId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Partner = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            var partnerLedgers = partnerRepository.GetPartnerLedgers(0, null, null);

            if (partnerId != 0 && startDate != null && endDate != null)
            {
                partnerLedgers = partnerRepository.GetPartnerLedgers(partnerId, startDate, endDate);
                var cpp = partnerRepository.GetByIdPartner(partnerId);
                ViewBag.PartnerName = cpp.Name;
                ViewBag.PartnerPhone = cpp.Phone;
                ViewBag.PartnerAddress = cpp.Address;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;

                return View(partnerLedgers);
            }
            else if (partnerId == 0 && startDate != null && endDate != null)
            {
                partnerLedgers = partnerRepository.GetPartnerLedgers(0, startDate, endDate);
                ViewBag.PartnerName = null;
                ViewBag.PartnerPhone = null;
                ViewBag.PartnerAddress = null;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;
                return View(partnerLedgers);
            }
            else if (partnerId != 0 && startDate == null && endDate == null)
            {
                partnerLedgers = partnerRepository.GetPartnerLedgers(partnerId, null, null);
                var cpp = partnerRepository.GetByIdPartner(partnerId);
                ViewBag.PartnerName = cpp.Name;
                ViewBag.PartnerPhone = cpp.Phone;
                ViewBag.PartnerAddress = cpp.Address;
                ViewBag.StartDate = null;
                ViewBag.EndDate = null;
                return View(partnerLedgers);
            }
            else
            {
                helperRepository.AlertMessage("Please enter correct filter details!");
                return View("GetAllLedgers", partnerLedgers);
            }
        }

        public ActionResult Investments()
        {
            var models = partnerRepository.GetAllPartnersInvestments();
            return View(models);
        }


        [HttpGet]
        public ActionResult Investment()
        {
            ViewBag.Partners = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Investment(PartnerInvestment partnerInvestment)
        {
            ViewBag.Partners = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");


            try
            {
                bool flag = false;
                var res = partnerRepository.AddPartnerInvestment(partnerInvestment);
                if (res != null)
                {
                    flag = true;
                }

                if (flag)
                {
                    toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                    return RedirectToAction(nameof(Investments));
                }
                else
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(partnerInvestment);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(partnerInvestment);
            }
        }

        public ActionResult EditInvestmentDetails(long id)
        {
            ViewBag.Partners = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            var model = partnerRepository.GetPartnerInvestment(id);
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditInvestmentDetails(PartnerInvestment partnerInvestment)
        {
            ViewBag.Partners = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");


            try
            {
                bool flag = false;
                var res = partnerRepository.EditPartnerInvestment(partnerInvestment);
                if (res != null)
                {
                    flag = true;
                }

                if (flag)
                {
                    toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                    return RedirectToAction(nameof(Investments));
                }
                else
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(partnerInvestment);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(partnerInvestment);
            }
        }

        public ActionResult PartnerPayments()
        {
            var models = partnerRepository.GetAllPartnersPayments();
            return View(models);
        }

        public ActionResult PartnerPayment()
        {
            ViewBag.Partners = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            return View();
        }

        public ActionResult EditPartnerPayment(long id)
        {
            ViewBag.Partners = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            var model = partnerRepository.GetPartnerPayment(id);
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PartnerPayment(PartnerPayment partnerPayment)
        {
            ViewBag.Partners = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");


            try
            {
                bool flag = false;
                var res = partnerRepository.AddPartnerPayment(partnerPayment);
                if (res != null)
                {
                    flag = true;
                }

                if (flag)
                {
                    toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                    return RedirectToAction(nameof(PartnerPayments));
                }
                else
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(partnerPayment);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(partnerPayment);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPartnerPayment(PartnerPayment partnerPayment)
        {
            ViewBag.Partners = new SelectList(helperRepository.GetPartner(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");


            try
            {
                bool flag = false;
                var res = partnerRepository.EditPartnerPayment(partnerPayment);
                if (res != null)
                {
                    flag = true;
                }

                if (flag)
                {
                    toastNotification.AddSuccessToastMessage("The operation was performed successfully");
                    return RedirectToAction(nameof(PartnerPayments));
                }
                else
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(partnerPayment);
                }
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return View(partnerPayment);
            }
        }




    }
}
