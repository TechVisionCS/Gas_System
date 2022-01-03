using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using System;

namespace PMS.Controllers
{
    public class SarafController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ISarafRepository sarafRepository;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;

        public SarafController(IToastNotification toastNotification,
            ISarafRepository sarafRepository,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository)
        {
            this.toastNotification = toastNotification;
            this.sarafRepository = sarafRepository;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
        }

        // GET: SarafController
        public ActionResult Index()
        {
            var sarafs = sarafRepository.GetAll();
            return View(sarafs);
        }

        public ActionResult Details(long id)
        {
            var sarafDetails = sarafRepository.GetSarafDetails(id);
            return View(sarafDetails);
        }

        // GET: TaxController/Create
        public ActionResult CreateOrEdit(long id = 0)
        {
            ViewBag.flag = id;
            Saraf saraf = new Saraf();
            if (id != 0)
            {
                saraf = sarafRepository.GetByIdSaraf(id);
            }
            return View(saraf);
        }

        // POST: TaxController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrEdit(Saraf saraf, long flag)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bool res = false;
                    saraf.UserId = pmsHelper.GetCurrentUserId();
                    saraf.UserName = pmsHelper.GetUserName(saraf.UserId);

                    if (flag == 0)
                    {
                        if (sarafRepository.AddSaraf(saraf) != null)
                        {
                            saraf.CreatedAt = DateTime.Now;
                            saraf.UpdatedAt = DateTime.Now;
                            res = true;
                        }
                    }
                    else
                    {
                        if (sarafRepository.UpdateSaraf(saraf) != null)
                        {
                            saraf.UpdatedAt = DateTime.Now;
                            res = true;
                        }
                    }

                    if (res)
                    {
                        toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        toastNotification.AddSuccessToastMessage("Operation faild, please try again later!");
                        return View(saraf);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(saraf);
                }
            }
            toastNotification.AddWarningToastMessage("Please enter correct data and try again!");
            return View(saraf);
        }


        //Ledger Action Methods
        public ActionResult GetAllLedgers()
        {
            ViewBag.Sarafs = new SelectList(helperRepository.GetSarafs(), "Id", "SarafName");
            var sarafsLedgers = sarafRepository.GetSarafLedgers(0, null, null);

            return View(sarafsLedgers);
        }

        public ActionResult GetLedgerById(long sarafId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Sarafs = new SelectList(helperRepository.GetSarafs(), "Id", "SarafName");
            var sarafLedgers = sarafRepository.GetSarafLedgers(0, null, null);

            if (sarafId != 0 && startDate != null && endDate != null)
            {
                sarafLedgers = sarafRepository.GetSarafLedgers(sarafId, startDate, endDate);
                var spp = sarafRepository.GetByIdSaraf(sarafId);
                ViewBag.SarafName = spp.SarafName;
                ViewBag.AccountName = spp.AccountName;
                ViewBag.AccountNo = spp.AccountNo;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;

                return View(sarafLedgers);
            }
            else if (sarafId == 0 && startDate != null && endDate != null)
            {
                sarafLedgers = sarafRepository.GetSarafLedgers(0, startDate, endDate);
                ViewBag.SarafName = null;
                ViewBag.AccountName = null;
                ViewBag.AccountNo = null;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;
                return View(sarafLedgers);
            }
            else if (sarafId != 0 && startDate == null && endDate == null)
            {
                sarafLedgers = sarafRepository.GetSarafLedgers(sarafId, null, null);
                var spp = sarafRepository.GetByIdSaraf(sarafId);
                ViewBag.SarafName = spp.SarafName;
                ViewBag.AccountName = spp.AccountName;
                ViewBag.AccountNo = spp.AccountNo;
                ViewBag.StartDate = null;
                ViewBag.EndDate = null;
                return View(sarafLedgers);
            }
            else
            {
                helperRepository.AlertMessage("Please enter correct filter details!");
                return View("GetAllLedgers", sarafLedgers);
            }
        }

        public ActionResult Transaction()
        {
            ViewBag.Sarafs = new SelectList(helperRepository.GetSarafs(), "Id", "SarafName");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transaction(SarafTransaction sarafTransaction)
        {
            ViewBag.Sarafs = new SelectList(helperRepository.GetSarafs(), "Id", "SarafName");

            if (ModelState.IsValid)
            {
                try
                {
                    sarafTransaction.UserId = pmsHelper.GetCurrentUserId();
                    sarafTransaction.UserName = pmsHelper.GetUserName(sarafTransaction.UserId);
                    sarafTransaction.CreatedAt = DateTime.Now;
                    sarafTransaction.UpdatedAt = DateTime.Now;

                    var res = sarafRepository.AddSarafTransaction(sarafTransaction);
                    if (res != null)
                    {
                        toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        toastNotification.AddErrorToastMessage("Operation faild, please try again later!");
                        return View(sarafTransaction);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(sarafTransaction);
                }

            }
            toastNotification.AddWarningToastMessage("Please enter correct data and try again!");
            return View(sarafTransaction);

        }

        //Update Transaction Details ...


    }
}
