using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Data;
using PMS.Models.Lookup;
using PMS.Utilities;
using System;
using System.Linq;

namespace PMS.Controllers.LookupControllers
{
    public class CountryController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public CountryController(IToastNotification _toastNotification,
                                ApplicationDbContext _dbContext,
                                PMSHelper _pmsHelper)
        {
            toastNotification = _toastNotification;
            dbContext = _dbContext;
            pmsHelper = _pmsHelper;
        }
        // GET: Country
        public ActionResult Index()
        {
            var categories = dbContext.Countries.ToList();
            return View(categories);
        }

        public ActionResult Success()
        {
            toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            Country country = new Country();
            return PartialView("_CreatePartialView", country);
        }

        public ActionResult Edit(long id)
        {
            var country = dbContext.Countries.FirstOrDefault(x => x.Id == id);
            return PartialView("_EditPartialView", country);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Country category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.CreatedAt = DateTime.Now;
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.Countries.Add(category) != null)
                    {
                        dbContext.SaveChanges();
                    }
                    toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                toastNotification.AddWarningToastMessage("Please enter correct data and try again!");
                return RedirectToAction(nameof(Index));
            }
        }


        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Country category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.Countries.Update(category) != null)
                    {
                        dbContext.SaveChanges();
                    }
                    toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                toastNotification.AddWarningToastMessage("Please enter correct data and try again!");
                return RedirectToAction(nameof(Index));
            }
        }
    }
}