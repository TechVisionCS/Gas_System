using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Data;
using PMS.Models.Lookup;
using PMS.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Controllers.LookupControllers
{
    public class CategoryController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public CategoryController(IToastNotification _toastNotification,
                                ApplicationDbContext _dbContext,
                                PMSHelper _pmsHelper)
        {
            toastNotification = _toastNotification;
            dbContext = _dbContext;
            pmsHelper = _pmsHelper;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            var categories = dbContext.Categories.ToList();
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
            Category category = new Category();
            return PartialView("_CreatePartialView", category);
        }

        public ActionResult Edit(long id)
        {
            var category = dbContext.Categories.FirstOrDefault(x => x.Id == id);
            return PartialView("_EditPartialView", category);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.CreatedAt = DateTime.Now;
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.Categories.Add(category) != null)
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
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.Categories.Update(category) != null)
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
