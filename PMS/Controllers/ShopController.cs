using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Models;
using PMS.Repositories.IRepositories;
using System;
using System.IO;

namespace PMS.Controllers
{
    public class ShopController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly IHelperRepository helperRepository;
        private readonly IShopRepository shopRepository;
        private readonly IWebHostEnvironment hostEnvironment;

        public ShopController(IToastNotification toastNotification,
                                   IHelperRepository helperRepository,
                                   IShopRepository shopRepository,
                                   IWebHostEnvironment hostEnvironment)
        {
            this.toastNotification = toastNotification;
            this.helperRepository = helperRepository;
            this.shopRepository = shopRepository;
            this.hostEnvironment = hostEnvironment;
        }
        // GET: ShopController
        public ActionResult Index()
        {
            var shop = shopRepository.GetShop();
            return View(shop);
        }


        // GET: ShopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Shop shop)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFileName = ProcessUploadedFile(shop);

                    shop.LogoUrl = uniqueFileName;

                    var res = shopRepository.AddShop(shop);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View();
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View();
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(shop);
            }
        }

        // GET: ShopController/Edit/5
        public ActionResult Edit()
        {
            var shop = shopRepository.GetShop();
            return View(shop);
        }

        // POST: ShopController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Shop shop)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (shop.ImageFile != null)
                    {
                        if (shop.LogoUrl != null)
                        {
                            string filePath = Path.Combine(hostEnvironment.WebRootPath, "Uploads", shop.LogoUrl);
                            System.IO.File.Delete(filePath);
                        }

                        shop.LogoUrl = ProcessUploadedFile(shop);
                    }

                    var res = shopRepository.UpdateShop(shop);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View();
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View();
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(shop);
            }
        }


        private string ProcessUploadedFile(Shop model)
        {
            string uniqueFileName = null;

            if (model.ImageFile != null)
            {
                string uploadsFolder = Path.Combine(hostEnvironment.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
