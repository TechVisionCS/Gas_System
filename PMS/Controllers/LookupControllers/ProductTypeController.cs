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
    public class ProductTypeController : Controller
    {

        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public ProductTypeController(IToastNotification _toastNotification,
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
            var categories = dbContext.ProductTypes.ToList();
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
            ProductType category = new ProductType();
            ViewBag.Categories = new SelectList(dbContext.Categories.Where(x => x.Status == 1).ToList(), "Name", "Name");
            return PartialView("_CreatePartialView", category);
        }

        public ActionResult Edit(long id)
        {
            var category = dbContext.ProductTypes.FirstOrDefault(x => x.Id == id);
            ViewBag.Categories = new SelectList(dbContext.Categories.Where(x => x.Status == 1).ToList(), "Name", "Name");
            return PartialView("_EditPartialView", category);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductType category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.CreatedAt = DateTime.Now;
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.ProductTypes.Add(category) != null)
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
        public ActionResult Edit(ProductType category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    category.UserId = pmsHelper.GetCurrentUserId();
                    category.UserName = pmsHelper.GetUserName(category.UserId);
                    category.UpdatedAt = DateTime.Now;

                    if (dbContext.ProductTypes.Update(category) != null)
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