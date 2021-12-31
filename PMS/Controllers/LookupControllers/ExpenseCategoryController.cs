using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Data;
using PMS.Models.Lookup;
using PMS.Utilities;
using System;
using System.Linq;

namespace PMS.Controllers.LookupControllers
{
    public class ExpenseCategoryController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public ExpenseCategoryController(IToastNotification toastNotification,
            ApplicationDbContext dbContext,
            PMSHelper pmsHelper)
        {
            this.toastNotification = toastNotification;
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
        }

        // GET: ExpenseCategoryController
        public ActionResult Index()
        {
            return View(dbContext.ExpensesCategories.ToList());
        }

        //GET : Expense Category Success Massage
        [HttpGet]
        public ActionResult Success()
        {
            toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
            return RedirectToAction(nameof(Index));
        }

        // GET: ExpenseCategoryController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ExpensesCategory category = new ExpensesCategory();
            return PartialView("_CreatePartialView", category);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ExpensesCategory category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.CreatedAt = DateTime.Now;
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.ExpensesCategories.Add(category) != null)
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

        // GET: ExpenseCategoryController/Edit/5
        [HttpGet]
        public ActionResult Edit(long id)
        {
            var category = dbContext.ExpensesCategories.FirstOrDefault(x => x.Id == id);
            return PartialView("_EditPartialView", category);
        }

        // POST: ExpenseCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ExpensesCategory category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.ExpensesCategories.Update(category) != null)
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
