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
    public class UnitController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;


        public UnitController(IToastNotification _toastNotification,
                                ApplicationDbContext _dbContext,
                                PMSHelper _pmsHelper)
        {
            toastNotification = _toastNotification;
            dbContext = _dbContext;
            pmsHelper = _pmsHelper;
        }
        // GET: UnitController
        public ActionResult Index()
        {
            var units = dbContext.Units.ToList();
            return View(units);
        }

        public ActionResult Success()
        {
            toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
            return RedirectToAction(nameof(Index));
        }

        // GET: UnitController/Create/5
        public ActionResult Create()
        {
            Unit unit = new Unit();
            return PartialView("_CreatePartialView", unit);
        }

        public ActionResult Edit(long id)
        {
            var unit = dbContext.Units.FirstOrDefault(x => x.Id == id);
            return PartialView("_EditPartialView", unit);
        }

        // POST: UnitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Unit u)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    u.UserId = pmsHelper.GetCurrentUserId();
                    u.UserName = pmsHelper.GetUserName(u.UserId);
                    u.CreatedAt = DateTime.Now;
                    u.UpdatedAt = DateTime.Now;


                    if (dbContext.Units.Add(u) != null)
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

        // GET: UnitController/Edit/5


        // POST: UnitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Unit u)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    u.UserId = pmsHelper.GetCurrentUserId();
                    u.UserName = pmsHelper.GetUserName(u.UserId);
                    u.UpdatedAt = DateTime.Now;

                    if (dbContext.Units.Update(u) != null)
                    {
                        dbContext.SaveChanges();
                    }
                        toastNotification.AddSuccessToastMessage("Operation Performed Successfully!");
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
