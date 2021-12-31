using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Data;
using PMS.Models.Lookup;
using PMS.Utilities;
using System;
using System.Linq;

namespace PMS.Controllers.LookupControllers
{
    public class AssetTypeController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public AssetTypeController(IToastNotification toastNotification,
            ApplicationDbContext dbContext,
            PMSHelper pmsHelper)
        {
            this.toastNotification = toastNotification;
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
        }

        // GET: AssetTypeController
        public ActionResult Index()
        {
            return View(dbContext.AssetsCategories.ToList());
        }

        //GET : Asset Category Success Massage
        [HttpGet]
        public ActionResult Success()
        {
            toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
            return RedirectToAction(nameof(Index));
        }

        // GET: AssetTypeController/Create
        [HttpGet]
        public ActionResult Create()
        {
            AssetsCategory category = new AssetsCategory();
            return PartialView("_CreatePartialView", category);
        }

        // POST: AssetTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssetsCategory category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.CreatedAt = DateTime.Now;
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.AssetsCategories.Add(category) != null)
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

        // GET: AssetTypeController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = dbContext.AssetsCategories.FirstOrDefault(x => x.Id == id);
            return PartialView("_EditPartialView", category);
        }

        // POST: AssetTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AssetsCategory category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.AssetsCategories.Update(category) != null)
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
