using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Models.Settings;
using PMS.Repositories.IRepositories.Settings;
using PMS.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Controllers.Settings
{
    public class TaxController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ITaxRepository taxRepository;
        private readonly PMSHelper pmsHelper;

        public TaxController(IToastNotification _toastNotification, ITaxRepository _taxRepository, PMSHelper pmsHelper)
        {
            toastNotification = _toastNotification;
            taxRepository = _taxRepository;
            this.pmsHelper = pmsHelper;
        }
        // GET: TaxController
        public ActionResult Index()
        {
            var taxes = taxRepository.GetAll();
            return View(taxes);
        }

        // GET: TaxController/Create
        public ActionResult CreateOrEdit(long id = 0)
        {
            ViewBag.flag = id;
            Tax tax = new Tax();
            if (id != 0)
            {
                tax = taxRepository.GetById(id);
            }
            return View(tax);
        }

        // POST: TaxController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrEdit(Tax tax, long flag)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bool res = false;
                    tax.UserId = pmsHelper.GetCurrentUserId();
                    tax.UserName = pmsHelper.GetUserName(tax.UserId);
                    
                    if (flag == 0)
                    {
                        tax.CreatedAt = DateTime.Now;
                        tax.UpdatedAt = DateTime.Now;
                        if (taxRepository.Add(tax) != null)
                        {
                            res = true;
                        }
                    }
                    else
                    {
                        tax.UpdatedAt = DateTime.Now;
                        if (taxRepository.Update(tax) != null)
                        {
                            res = true;
                        }
                    }

                    if (res)
                    {
                        toastNotification.AddSuccessToastMessage("Operation Completed Successfully!");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        toastNotification.AddSuccessToastMessage("Operation faild, please try again later!");
                        return View(tax);
                    }
                }
                catch
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View(tax);
                }
            }
            toastNotification.AddWarningToastMessage("Please enter correct data and try again!");
            return View(tax);
        }

        
    }
}
