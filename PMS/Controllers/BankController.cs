using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using System;

namespace PMS.Controllers
{
    public class BankController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly IBankRepository bankRepository;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;

        public BankController(IToastNotification toastNotification,
            IBankRepository bankRepository,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository)
        {
            this.toastNotification = toastNotification;
            this.bankRepository = bankRepository;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
        }

        // GET: BankController
        public ActionResult Index()
        {
            var banks = bankRepository.GetAll();
            return View(banks);
        }

        public ActionResult Details(long id)
        {
            var bankDetails = bankRepository.GetBankDetails(id);
            return View(bankDetails);
        }

        // GET: TaxController/Create
        public ActionResult CreateOrEdit(long id = 0)
        {
            ViewBag.flag = id;
            Bank bank = new Bank();
            if (id != 0)
            {
                bank = bankRepository.GetByIdBank(id);
            }
            return View(bank);
        }

        // POST: TaxController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrEdit(Bank bank, long flag)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bool res = false;
                    bank.UserId = pmsHelper.GetCurrentUserId();
                    bank.UserName = pmsHelper.GetUserName(bank.UserId);

                    if (flag == 0)
                    {
                        if (bankRepository.AddBank(bank) != null)
                        {
                            bank.CreatedAt = DateTime.Now;
                            bank.UpdatedAt = DateTime.Now;
                            res = true;
                        }
                    }
                    else
                    {
                        if (bankRepository.UpdateBank(bank) != null)
                        {
                            bank.UpdatedAt = DateTime.Now;
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
                        return View(bank);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(bank);
                }
            }
            toastNotification.AddWarningToastMessage("Please enter correct data and try again!");
            return View(bank);
        }


        //Ledger Action Methods
        public ActionResult GetAllLedgers()
        {
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            var banksLedgers = bankRepository.GetBankLedgers(0, null, null);

            return View(banksLedgers);
        }

        public ActionResult GetLedgerById(long bankId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            var bankLedgers = bankRepository.GetBankLedgers(0, null, null);

            if (bankId != 0 && startDate != null && endDate != null)
            {
                bankLedgers = bankRepository.GetBankLedgers(bankId, startDate, endDate);
                var spp = bankRepository.GetByIdBank(bankId);
                ViewBag.BankName = spp.BankName;
                ViewBag.AccountName = spp.AccountName;
                ViewBag.AccountNo = spp.AccountNo;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;

                return View(bankLedgers);
            }
            else if (bankId == 0 && startDate != null && endDate != null)
            {
                bankLedgers = bankRepository.GetBankLedgers(0, startDate, endDate);
                ViewBag.BankName = null;
                ViewBag.AccountName = null;
                ViewBag.AccountNo = null;
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;
                return View(bankLedgers);
            }
            else if (bankId != 0 && startDate == null && endDate == null)
            {
                bankLedgers = bankRepository.GetBankLedgers(bankId, null, null);
                var spp = bankRepository.GetByIdBank(bankId);
                ViewBag.BankName = spp.BankName;
                ViewBag.AccountName = spp.AccountName;
                ViewBag.AccountNo = spp.AccountNo;
                ViewBag.StartDate = null;
                ViewBag.EndDate = null;
                return View(bankLedgers);
            }
            else
            {
                helperRepository.AlertMessage("Please enter correct filter details!");
                return View("GetAllLedgers", bankLedgers);
            }
        }

        public ActionResult Transaction()
        {
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transaction(BankTransaction bankTransaction)
        {
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            if (ModelState.IsValid)
            {
                try
                {
                    bankTransaction.UserId = pmsHelper.GetCurrentUserId();
                    bankTransaction.UserName = pmsHelper.GetUserName(bankTransaction.UserId);
                    bankTransaction.CreatedAt = DateTime.Now;
                    bankTransaction.UpdatedAt = DateTime.Now;

                    var res = bankRepository.AddBankTransaction(bankTransaction);
                    if (res != null)
                    {
                        toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        toastNotification.AddErrorToastMessage("Operation faild, please try again later!");
                        return View(bankTransaction);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(bankTransaction);
                }

            }
            toastNotification.AddWarningToastMessage("Please enter correct data and try again!");
            return View(bankTransaction);

        }

        //Update Transaction Details ...


    }
}
