using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models.FixedAsset;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.Asset;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class FixedAssetController : Controller
    {
        private readonly IFixedAssetRepository fixedAssetRepository;
        private readonly IToastNotification toastNotification;
        private readonly IHelperRepository helperRepository;

        public FixedAssetController(IFixedAssetRepository fixedAssetRepository,
            IToastNotification toastNotification,
            IHelperRepository helperRepository)
        {
            this.fixedAssetRepository = fixedAssetRepository;
            this.toastNotification = toastNotification;
            this.helperRepository = helperRepository;
        }

        // GET: FixedAssetController
        public ActionResult Index()
        {
            return View(fixedAssetRepository.GetAllFixedAssets());
        }

        // GET: FixedAssetController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.AssetTypes = new SelectList(helperRepository.GetAssetCategories(), "Id", "Name");
            return View(new Asset());
        }

        // POST: FixedAssetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Asset fixedAsset)
        {
            ViewBag.AssetTypes = new SelectList(helperRepository.GetAssetCategories(), "Id", "Name");

            if (ModelState.IsValid)
            {
                try
                {
                    var res = fixedAssetRepository.AddFixedAsset(fixedAsset);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));

                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(fixedAsset);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(fixedAsset);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(fixedAsset);
            }
        }

        // GET: FixedAssetController/Edit/5
        [HttpGet]
        public ActionResult Edit(long id)
        {
            ViewBag.AssetTypes = new SelectList(helperRepository.GetAssetCategories(), "Id", "Name");
            var Asset = fixedAssetRepository.GetByIdForUpdate(id);
            return View(Asset);
        }

        // POST: FixedAssetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Asset fixedAsset)
        {
            ViewBag.AssetTypes = new SelectList(helperRepository.GetAssetCategories(), "Id", "Name");
            if (ModelState.IsValid)
            {
                try
                {
                    var res = fixedAssetRepository.UpdateFixedAsset(fixedAsset);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(fixedAsset);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(fixedAsset);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(fixedAsset);
            }
        }

        // GET: FixedAssetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            bool isDeleted = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var res = fixedAssetRepository.DeleteFixedAsset(id);
                    if (res)
                    {
                        isDeleted = true;
                    }
                }
                catch
                {
                    isDeleted = false;
                }
            }

            if (isDeleted)
            {
                helperRepository.SuccessMessage();
            }
            else
            {
                helperRepository.ErrorMessage();
            }

            return RedirectToAction(nameof(Index));
        }

        //Stock Index Page
        [HttpGet]
        public ActionResult AssetStock()
        {
            var stockItems = fixedAssetRepository.GetAssetStockDetails();
            return View(stockItems);
        }

        //Asset Stock Implemenation 
        [HttpGet]
        public ActionResult AssetStockAdd()
        {
            ViewBag.AssetName = new SelectList(helperRepository.GetAssets(), "Id", "Name");
            return View(new AssetStock());
        }

        // POST: FixedAssetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssetStockAdd(AssetStock assetStock)
        {
            ViewBag.AssetName = new SelectList(helperRepository.GetAssets(), "Id", "Name");
            if (ModelState.IsValid)
            {
                try
                {
                    var res = fixedAssetRepository.AddAssetStock(assetStock);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(AssetStock));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(assetStock);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(assetStock);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(assetStock);
            }
        }

        //Asset Stock Implemenation 
        [HttpGet]
        public ActionResult AssetStockEdit(long id)
        {
            ViewBag.AssetName = new SelectList(helperRepository.GetAssets(), "Id", "Name");
            var product = fixedAssetRepository.GetByIdForUpdateStock(id);
            return View(product);
        }

        // POST: FixedAssetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssetStockEdit(AssetStock assetStock)
        {
            ViewBag.AssetName = new SelectList(helperRepository.GetAssets(), "Id", "Name");
            if (ModelState.IsValid)
            {
                try
                {
                    var res = fixedAssetRepository.UpdateAssetStock(assetStock);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(assetStock));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(assetStock);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(assetStock);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(assetStock);
            }
        }

        // Asset Stock HandOver To Employee
        public ActionResult LoadDetails(long AssetHandoverId, int i)
        {
            ViewBag.Asset = new SelectList(helperRepository.GetAssets(), "Id", "Name");

            return PartialView("_AssetHandoverDetailsPartial");
        }
        [HttpGet]
        public ActionResult AssetHandover()
        {
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.Asset = new SelectList(helperRepository.GetAssets(), "Id", "Name");
            return View(new CreateAssetHandoverViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssetHandover(CreateAssetHandoverViewModel AssetHandoverViewModel, long[] AssetId, decimal[] Qty, int[] Status, string[] Details)
        {
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.Asset = new SelectList(helperRepository.GetAssets(), "Id", "Name");
            if (AssetId.Length > 0)
            {
                List<AssetHandoverDetails> list = new List<AssetHandoverDetails>();
                for (int i = 0; i < AssetId.Length; i++)
                {
                    AssetHandoverDetails model = new AssetHandoverDetails
                    {
                        AssetId = AssetId[i],
                        Status = (Data.Enums.AssetStatus)Status[i],
                        Details = Details[i],
                        Qty = (int)Qty[i]
                    };
                    list.Add(model);
                }
                AssetHandoverViewModel.AssetHandoverDetailss = list;
            }

            var res = fixedAssetRepository.AddStockHandover(AssetHandoverViewModel);

            if (res != null)
            {
                helperRepository.SuccessMessage();
                return RedirectToAction(nameof(AssetHandoverView));
            }
            else
            {
                helperRepository.ErrorMessage();
                return View(AssetHandoverViewModel);
            }
        }

        [HttpGet]
        public ActionResult AssetHandoverEdit(long id)
        {
            var AssetHandovers = fixedAssetRepository.GetStockHandoverForEdit(id);
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.Asset = new SelectList(helperRepository.GetAssets(), "Id", "Name");
            return View(AssetHandovers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssetHandoverEdit(CreateAssetHandoverViewModel EditAssetHandoverViewModel, long[] AssetId, decimal[] Qty, int[] Status, string[] Details, long[] AssetHandoverId, long[] DetailsId)
        {

            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.Asset = new SelectList(helperRepository.GetAssets(), "Id", "Name");
            if (AssetId.Length > 0)
            {
                List<AssetHandoverDetails> list = new List<AssetHandoverDetails>();

                for (int i = 0; i < AssetId.Length; i++)
                {
                    AssetHandoverDetails model = new AssetHandoverDetails
                    {
                        AssetId = AssetId[i],
                        AssetHandoverId = AssetHandoverId[i],
                        Id = DetailsId[i],
                        Status = (Data.Enums.AssetStatus)Status[i],
                        Details = Details[i],
                        Qty = (int)Qty[i]
                    };
                    list.Add(model);
                }

                EditAssetHandoverViewModel.AssetHandoverDetailss = list;
            }

            try
            {
                var res = fixedAssetRepository.EditStockHandover(EditAssetHandoverViewModel);

                if (res != null)
                {
                    helperRepository.SuccessMessage();

                    return RedirectToAction(nameof(AssetHandoverView));
                }
                else
                {
                    helperRepository.ErrorMessage();

                    return View(EditAssetHandoverViewModel);
                }

            }
            catch
            {
                helperRepository.ErrorMessage();
                return View(EditAssetHandoverViewModel);
            }

        }
        public ActionResult AssetHandoverView()
        {
            var purchases = fixedAssetRepository.GetAllAssetHandover();
            return View(purchases);
        }
        public ActionResult ViewAssetHandoverDetails(long id)
        {
            var details = fixedAssetRepository.GetAllAssetHandoverDetails(id);
            return PartialView("_ViewAssetHandoverDetailsPartials", details);
        }
        public ActionResult AssetHandoverDetails(long id)
        {
            var assetdetials = fixedAssetRepository.GetAssetGeneralDetails(id);
            return View(assetdetials);
        }
        public ActionResult AssetHandoverDelete(long id)
        {
            bool isDeleted = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var res = fixedAssetRepository.DeleteStockHandover(id);
                    if (res)
                    {
                        isDeleted = true;
                    }
                }
                catch
                {
                    isDeleted = false;
                }
            }

            if (isDeleted)
            {
                helperRepository.SuccessMessage();
            }
            else
            {
                helperRepository.ErrorMessage();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
