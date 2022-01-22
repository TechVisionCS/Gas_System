using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PMS.Repositories.IRepositories;
using System.Linq;

namespace PMS.Controllers
{
    public class StockController : Controller
    {
        private readonly IHelperRepository helperRepository;
        private readonly IStockRepository stockRepository;

        public StockController(IHelperRepository _helperRepository,
            IStockRepository _stockRepository)
        {
            helperRepository = _helperRepository;
            stockRepository = _stockRepository;
        }
        // GET: Stock
        public ActionResult Index(long unitId = 0)
        {
            var stockItems = stockRepository.GetCurrentStockDetails();
            if (unitId > 0)
            {
                ViewBag.UnitName = helperRepository.GetUnit().FirstOrDefault(x => x.Id == unitId).Name;
                stockItems = stockRepository.GetCurrentStockDetails(unitId);
            }
            else
            {
                ViewBag.UnitName = "kg - کیلو ګرام";
            }

            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            return View(stockItems);
        }

        public ActionResult GetByManufacturerId(long id)
        {
            var stockItems = stockRepository.GetCurrentStockDetails().Where(x => x.ManufacturerId == id).ToList();
            return View("Index", stockItems);
        }
        public ActionResult GetByCategoryId(long id)
        {
            var stockItems = stockRepository.GetCurrentStockDetails().Where(x => x.CategoryId == id).ToList();
            return View("Index", stockItems);
        }

        // GET: Stock/Details/5
        public ActionResult Details(long id)
        {
            return View();
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stock/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Stock/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult StockDetails(long id = 0, long unitId = 0)
        {
            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");

            if (id == 0)
            {
                var stockItems = stockRepository.GetCurrentStockDetails();
                if (unitId > 0)
                {
                    ViewBag.UnitName = helperRepository.GetUnit().FirstOrDefault(x => x.Id == unitId).Name;
                    
                    stockItems = stockRepository.GetCurrentStockDetails(unitId);
                }
                else
                {
                    ViewBag.UnitName = "kg - کیلو ګرام";
                }
                return View(stockItems);
            }
            else
            {
                var stockItems = stockRepository.GetProductStockDetailsById(id);
                if (unitId > 0)
                {
                    ViewBag.UnitName = helperRepository.GetUnit().FirstOrDefault(x => x.Id == unitId).Name;
                    stockItems = stockRepository.GetProductStockDetailsById(id, unitId);
                }
                else
                {
                    ViewBag.UnitName = "kg - کیلو ګرام";
                }
                return View(stockItems);
            }



        }

        public ActionResult StockDetailsList(long unitId = 0)
        {
            var details = stockRepository.GetStockDetailsList();
            if (unitId > 0)
            {
                ViewBag.UnitName = helperRepository.GetUnit().FirstOrDefault(x => x.Id == unitId).Name;
                details = stockRepository.GetStockDetailsList(unitId);
            }
            else
            {
                ViewBag.UnitName = "kg - کیلو ګرام";
            }

            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");


            return View(details);
        }

        public ActionResult EachStockDetails(long id, long unitId = 0)
        {
            var DetilesList = stockRepository.GetEachStockDetails(id);
            if (unitId > 0)
            {
                ViewBag.UnitName = helperRepository.GetUnit().FirstOrDefault(x => x.Id == unitId).Name;
                DetilesList = stockRepository.GetEachStockDetails(id, unitId);
            }
            else
            {
                ViewBag.UnitName = "kg - کیلو ګرام";
            }

            ViewBag.Units = new SelectList(helperRepository.GetUnit(), "Id", "Name");


            return View(DetilesList);
        }
    }
}