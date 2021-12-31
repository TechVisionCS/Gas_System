using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Data;
using PMS.Models.Lookup;
using PMS.Utilities;

namespace PMS.Controllers.LookupControllers
{
    public class ProvinceController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public ProvinceController(IToastNotification _toastNotification,
                                ApplicationDbContext _dbContext,
                                PMSHelper _pmsHelper)
        {
            toastNotification = _toastNotification;
            dbContext = _dbContext;
            pmsHelper = _pmsHelper;
        }
        // GET: Province
        public ActionResult Index()
        {
            var categories = dbContext.Provinces.ToList();
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
            Province country = new Province();
            ViewBag.Countries = new SelectList(dbContext.Countries.ToList(), "Id", "Name");
            return PartialView("_CreatePartialView", country);
        }

        public ActionResult Edit(long id)
        {
            var country = dbContext.Provinces.FirstOrDefault(x => x.Id == id);
            ViewBag.Countries = new SelectList(dbContext.Countries.ToList(), "Id", "Name");
            return PartialView("_EditPartialView", country);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Province category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.CreatedAt = DateTime.Now;
                    category.UpdatedAt = DateTime.Now;

                    category.CountryCode = dbContext.Countries.FirstOrDefault(x => x.Id == category.CountryId).Code;
                    category.CountryName = dbContext.Countries.FirstOrDefault(x => x.Id == category.CountryId).Name;

                    if (dbContext.Provinces.Add(category) != null)
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
        public ActionResult Edit(Province category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.UpdatedAt = DateTime.Now;

                    category.CountryCode = dbContext.Countries.FirstOrDefault(x => x.Id == category.CountryId).Code;
                    category.CountryName = dbContext.Countries.FirstOrDefault(x => x.Id == category.CountryId).Name;

                    if (dbContext.Provinces.Update(category) != null)
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