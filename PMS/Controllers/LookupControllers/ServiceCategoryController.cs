using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Data;
using PMS.Models.Lookup;
using PMS.Repositories.IRepositories;
using System;
using System.Linq;

namespace PMS.Controllers.LookupControllers
{
    public class ServiceCategoryController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;

        public ServiceCategoryController(IToastNotification toastNotification,
            ApplicationDbContext dbContext, IHelperRepository helperRepository)
        {
            this.toastNotification = toastNotification;
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
        }

        // GET: AssetTypeController
        public ActionResult Index()
        {
            return View(dbContext.ServiceCategories.ToList());
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
            ServiceCategory serviceCategory = new ServiceCategory();
            return PartialView("_CreatePartialView", serviceCategory);
        }

        // POST: AssetTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceCategory serviceCategory)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    serviceCategory.UserId = helperRepository.GetCurrentUserId();
                    serviceCategory.UserName = helperRepository.GetUserName(serviceCategory.UserId);
                    serviceCategory.CreatedAt = DateTime.Now;
                    serviceCategory.UpdatedAt = DateTime.Now;

                    if (dbContext.ServiceCategories.Add(serviceCategory) != null)
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

        // GET: AssetTypeController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var serviceCategory = dbContext.ServiceCategories.FirstOrDefault(x => x.Id == id);
            return PartialView("_EditPartialView", serviceCategory);
        }

        // POST: AssetTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServiceCategory serviceCategory)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    serviceCategory.UserId = helperRepository.GetCurrentUserId();
                    serviceCategory.UserName = helperRepository.GetUserName(serviceCategory.UserId);
                    serviceCategory.UpdatedAt = DateTime.Now;

                    if (dbContext.ServiceCategories.Update(serviceCategory) != null)
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
    }
}
