using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Data;
using PMS.Models.Lookup;
using PMS.Utilities;
using System;
using System.Linq;

namespace PMS.Controllers.LookupControllers
{
    public class DesignationController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public DesignationController(IToastNotification toastNotification,
            ApplicationDbContext dbContext,
            PMSHelper pmsHelper)
        {
            this.toastNotification = toastNotification;
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
        }

        [HttpGet]
        // GET: DesignationController
        public ActionResult Index()
        {
            return View(dbContext.Designations.Where(x => x.DeletedAt == null).ToList());
        }

        [HttpGet]
        public ActionResult Success()
        {
            toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
            return RedirectToAction(nameof(Index));
        }

        // GET: DesignationController/Create
        public ActionResult Create()
        {
            Designation designation = new Designation();
            return PartialView("_CreatePartialView", designation);
        }

        // POST: DesignationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Designation designation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    designation.UserId = pmsHelper.GetCurrentUserId();
                    designation.UserName = pmsHelper.GetUserName(designation.UserId);
                    designation.CreatedAt = DateTime.Now;
                    designation.UpdatedAt = DateTime.Now;

                    if (dbContext.Designations.Add(designation) != null)
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

        // GET: DesignationController/Edit/5
        public ActionResult Edit(long id)
        {
            var designation = dbContext.Designations.FirstOrDefault(x => x.Id == id);
            return PartialView("_EditPartialView", designation);
        }

        // POST: DesignationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Designation designation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    designation.UserId = pmsHelper.GetCurrentUserId();
                    designation.UserName = pmsHelper.GetUserName(designation.UserId);
                    designation.UpdatedAt = DateTime.Now;

                    if (dbContext.Designations.Update(designation) != null)
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
                        var DeleteQuery = dbContext.Designations.FirstOrDefault(x => x.Id == id);

                        if (DeleteQuery != null)
                        {
                            DeleteQuery.UserId = pmsHelper.GetCurrentUserId();
                            DeleteQuery.UserName = pmsHelper.GetUserName(DeleteQuery.UserId);
                            DeleteQuery.DeletedAt = DateTime.Now;

                            dbContext.Designations.Update(DeleteQuery);
                            dbContext.SaveChanges();
                        }
                        return RedirectToAction(nameof(Index));
                    }
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
                toastNotification.AddWarningToastMessage("Please try again!");
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
