using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Data;
using PMS.Models.Lookup;
using PMS.Repositories.IRepositories;
using System;
using System.Linq;

namespace PMS.Controllers.LookupControllers
{
    public class CurrencyController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;

        public CurrencyController(IToastNotification toastNotification,
            ApplicationDbContext dbContext,
            IHelperRepository helperRepository)
        {
            this.toastNotification = toastNotification;
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(dbContext.currencies.Where(x => x.DeletedAt == null).ToList());
        }

        [HttpGet]
        public ActionResult Success()
        {
            helperRepository.SuccessMessage();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create()
        {
            Currency currency = new Currency();
            return PartialView("_CreatePartialView", currency);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Currency currency)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    currency.UserId = helperRepository.GetCurrentUserId();
                    currency.UserName = helperRepository.GetUserName(currency.UserId);
                    currency.CreatedAt = DateTime.Now;
                    currency.UpdatedAt = DateTime.Now;

                    if (dbContext.currencies.Add(currency) != null)
                    {
                        dbContext.SaveChanges();
                    }
                    helperRepository.SuccessMessage();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                helperRepository.WarningMessage("Please enter correct data and try again!");
                return RedirectToAction(nameof(Index));
            }
        }

        public ActionResult Edit(long id)
        {
            var currency = dbContext.currencies.FirstOrDefault(x => x.Id == id);
            return PartialView("_EditPartialView", currency);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Currency currency)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    currency.UserId = helperRepository.GetCurrentUserId();
                    currency.UserName = helperRepository.GetUserName(currency.UserId);
                    currency.UpdatedAt = DateTime.Now;

                    if (dbContext.currencies.Update(currency) != null)
                    {
                        dbContext.SaveChanges();
                    }
                    helperRepository.SuccessMessage();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    helperRepository.ErrorMessage();

                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                helperRepository.WarningMessage("Please enter correct data and try again!");
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (dbContext != null)
                    {
                        var DeleteQuery = dbContext.currencies.FirstOrDefault(x => x.Id == id);

                        if (DeleteQuery != null)
                        {
                            DeleteQuery.UserId = helperRepository.GetCurrentUserId();
                            DeleteQuery.UserName = helperRepository.GetUserName(DeleteQuery.UserId);
                            DeleteQuery.DeletedAt = DateTime.Now;

                            dbContext.currencies.Update(DeleteQuery);
                            dbContext.SaveChanges();
                        }
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    helperRepository.ErrorMessage();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    helperRepository.WarningMessage("Something went wrong, please try again later!_" + ex);
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                helperRepository.WarningMessage("Please Try Again_");

                return RedirectToAction(nameof(Index));
            }
        }
    }
}
