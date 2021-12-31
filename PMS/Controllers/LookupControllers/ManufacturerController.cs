using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class ManufacturerController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public ManufacturerController(IToastNotification _toastNotification,
                                ApplicationDbContext _dbContext,
                                PMSHelper _pmsHelper)
        {
            toastNotification = _toastNotification;
            dbContext = _dbContext;
            pmsHelper = _pmsHelper;
        }

        // GET: ManufacturerController
        public ActionResult Index()
        {
            var manufaturers = dbContext.Manufacturers.Where(x => x.DeletedAt == null).ToList();
            return View(manufaturers);
        }

        public ActionResult Success()
        {
            toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
            return RedirectToAction(nameof(Index));
        }

        // GET: ManufacturerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManufacturerController/Create
        public ActionResult Create()
        {
            Manufacturer manufacturer = new Manufacturer();
            ViewBag.Countries = new SelectList(dbContext.Countries.Where(x => x.DeletedAt == null).ToList(), "Name", "Name");
            return PartialView("_CreatePartialView", manufacturer);
        }

        // POST: ManufacturerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    manufacturer.UserId = pmsHelper.GetCurrentUserId();
                    manufacturer.UserName = pmsHelper.GetUserName(manufacturer.UserId);
                    manufacturer.CreatedAt = DateTime.Now;
                    manufacturer.UpdatedAt = DateTime.Now;

                    if (dbContext.Manufacturers.Add(manufacturer) != null)
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

        // GET: ManufacturerController/Edit/5
        public ActionResult Edit(long id)
        {
            var manufaturer = dbContext.Manufacturers.FirstOrDefault(x => x.Id == id);
            ViewBag.Countries = new SelectList(dbContext.Countries.Where(x => x.DeletedAt == null).ToList(), "Name", "Name");
            return PartialView("_EditPartialView", manufaturer);
        }

        // POST: ManufacturerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    manufacturer.UserId = pmsHelper.GetCurrentUserId();
                    manufacturer.UserName = pmsHelper.GetUserName(manufacturer.UserId);
                    manufacturer.UpdatedAt = DateTime.Now;

                    if (dbContext.Manufacturers.Update(manufacturer) != null)
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

        // GET: ManufacturerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManufacturerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
