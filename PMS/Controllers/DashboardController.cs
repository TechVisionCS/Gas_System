﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PMS.Repositories.IRepositories;
using System;
using System.Linq;

namespace PMS.Controllers
{
    //[AllowAnonymous]
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository dashboardRepository;
        private readonly ISaleRepository saleRepository;
        private readonly IPurchaseRepository purchaseRepository;
        private readonly IExpenseRepository expenseRepository;
        private readonly IStockRepository stockRepository;
        private readonly IHelperRepository helperRepository;

        public DashboardController(IDashboardRepository dashboardRepository,
            ISaleRepository saleRepository,
            IPurchaseRepository purchaseRepository,
            IExpenseRepository expenseRepository,
            IStockRepository stockRepository,
            IHelperRepository helperRepository)
        {
            this.dashboardRepository = dashboardRepository;
            this.saleRepository = saleRepository;
            this.purchaseRepository = purchaseRepository;
            this.expenseRepository = expenseRepository;
            this.stockRepository = stockRepository;
            this.helperRepository = helperRepository;
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            var salesperMonths = dashboardRepository.GetAllSalesPerMonth();

            ViewBag.JanuarySale = salesperMonths.Where(x => x.Month == 1 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.FaberuarySale = salesperMonths.Where(x => x.Month == 2 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.March = salesperMonths.Where(x => x.Month == 3 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.AprilSale = salesperMonths.Where(x => x.Month == 4 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.MaySale = salesperMonths.Where(x => x.Month == 5 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.JuneSale = salesperMonths.Where(x => x.Month == 6 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.JulySale = salesperMonths.Where(x => x.Month == 7 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.AugustSale = salesperMonths.Where(x => x.Month == 8 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.SeptemberSale = salesperMonths.Where(x => x.Month == 9 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.OctoberSale = salesperMonths.Where(x => x.Month == 10 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.NovermberSale = salesperMonths.Where(x => x.Month == 11 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.DecemberSale = salesperMonths.Where(x => x.Month == 12 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();


            var salesperMPurchaseonths = dashboardRepository.GetAllPurchasePerMonth();

            ViewBag.JanuarySalep = salesperMPurchaseonths.Where(x => x.Month == 1 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.FaberuarySalep = salesperMPurchaseonths.Where(x => x.Month == 2 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.Marchp = salesperMPurchaseonths.Where(x => x.Month == 3 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.AprilSalep = salesperMPurchaseonths.Where(x => x.Month == 4 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.MaySalep = salesperMPurchaseonths.Where(x => x.Month == 5 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.JuneSalep = salesperMPurchaseonths.Where(x => x.Month == 6 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.JulySalep = salesperMPurchaseonths.Where(x => x.Month == 7 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.AugustSalep = salesperMPurchaseonths.Where(x => x.Month == 8 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.SeptemberSalep = salesperMPurchaseonths.Where(x => x.Month == 9 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.OctoberSalep = salesperMPurchaseonths.Where(x => x.Month == 10 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.NovermberSalep = salesperMPurchaseonths.Where(x => x.Month == 11 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();
            ViewBag.DecemberSalep = salesperMPurchaseonths.Where(x => x.Month == 12 && x.Year == DateTime.Now.Year).Select(x => x.Amount).Sum();

            var TotalExpenses = dashboardRepository.GetAllExpenses();

            ViewBag.TotalExpenses = TotalExpenses;

            var TotalExpensesMonth = dashboardRepository.GetAllExpensesMonth();

            ViewBag.TotalExpensesMonth = TotalExpensesMonth;


            var SaleDetails = dashboardRepository.GetAllSaleDetails();

            ViewBag.SaleQty = SaleDetails.Select(x => x.Qty).Sum();

            ViewBag.TotalSale = SaleDetails.Select(x => x.TotalSalePrice).Sum();

            ViewBag.TotalSalePerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.TotalSalePrice).Sum();

            if (SaleDetails == null)
            {
                ViewBag.SaleRevenue = (SaleDetails.Select(x => x.Qty).Sum()) * (SaleDetails.Select(x => x.UnitPrice).Average());
                ViewBag.SaleRevenuePerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Qty).Sum() * SaleDetails.Select(x => x.UnitPrice).Average();
                ViewBag.SaleRevenueQty = SaleDetails.Select(x => x.Qty).Sum();
                ViewBag.TotalProfit = SaleDetails.Select(x => x.Qty).Sum() * SaleDetails.Select(x => x.UnitPrice).Average() - TotalExpenses;
                ViewBag.TotalProfitPerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Qty).Sum() * SaleDetails.Select(x => x.UnitPrice).Average() - TotalExpenses;
            }

            else
            {
                ViewBag.SaleRevenue = 0;
                ViewBag.SaleRevenuePerMonth = 0;
                ViewBag.SaleRevenueQty = 0;
                ViewBag.TotalProfit = 0;
                ViewBag.TotalProfitPerMonth = 0;
            }

            //doughnet

            var stockItems = stockRepository.GetCurrentStockDetails();



            ViewBag.stockPro = stockItems.Select(k => new { k.ProductName, k.CurrentStockQty }).GroupBy(a => new
            {
                ProductName = a.ProductName
            }).ToArray();

            //ViewBag.ProductName = stockItems.Select(k => new { k.ProductName }).ToArray();

            ////ViewBag.ProductName = JsonConvert.SerializeObject(list);

            ////  ViewBag.ProductName = stockItems.Select(k => new { k.ProductName }).ToArray();
            //ViewBag.CurrentQty = stockItems.Select(k => new { k.CurrentStockQty }).ToArray();

            //// var CurrentQty = @Html.Raw(Json.Serialize(@ViewBag.CurrentQty));
            //ViewBag.ProductName = Newtonsoft.Json.JsonConvert.SerializeObject(ProductName);
            //ViewBag.CurrentStock = Newtonsoft.Json.JsonConvert.SerializeObject(CurrentStock);
            //List<DatapointLine> dataPoints = new List<DatapointLine>{
            //    new DatapointLine(10, 22),
            //    new DatapointLine(20, 36),
            //    new DatapointLine(30, 42),
            //    new DatapointLine(40, 51),
            //    new DatapointLine(50, 46),
            //};

            //ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            //return Json(dataPoints, JsonRequestBehavior.AllowGet);

            //Profit

            //Purchase 
            var PurchaseDetails = dashboardRepository.GetAllPurchaseDetails();
            ViewBag.PurchaseQty = PurchaseDetails.Select(x => x.Qty).Sum();
            ViewBag.TotalPurchase = PurchaseDetails.Select(x => x.TotalPurchasePrice).Sum();
            ViewBag.TotalPurchasePerMonth = PurchaseDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.TotalPurchasePrice).Sum();

            var TotalProducts = dashboardRepository.GetAllProducts();
            ViewBag.TotalProducts = TotalProducts;

            var TotalProductMonth = dashboardRepository.GetAllProductseMonth();
            ViewBag.TotalProductMonth = TotalProductMonth;

            var TotalCustomers = dashboardRepository.GetAllCustomers();
            ViewBag.TotalCustomers = TotalCustomers;

            var TotalCustomersPerMonth = dashboardRepository.GetAllCustomersMonth();
            ViewBag.TotalProductMonth = TotalCustomersPerMonth;

            var TotalSuppliers = dashboardRepository.GetAllSuppliers();
            ViewBag.TotalSuppliers = TotalSuppliers;

            var TotalSuppliersPerMonth = dashboardRepository.GetAllSuppliersMonth();
            ViewBag.TotalSuppliersPerMonth = TotalSuppliersPerMonth;

            return View();
        }

        [HttpGet]
        public ActionResult Sale()
        {
            var sales = saleRepository.GetAllSales();
            return PartialView("_LatestSales", sales);
        }

        [HttpGet]
        public ActionResult Purchase()
        {
            var purchase = purchaseRepository.GetAllPurchases();
            return PartialView("_LatestPurchases", purchase);
        }


        [HttpGet]
        public ActionResult Expenses()
        {
            var Expenses = expenseRepository.GetAllExpense();
            return PartialView("_LatestExpenses", Expenses);
        }

        [HttpGet]
        public ActionResult Stock(long unitId = 0)
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
            return PartialView("_LatestCurrentStock", stockItems);
        }

        //public ActionResult TotalSalesPerMonth()
        //{
        //    //PassMonth List Static for now
        //    var monthlists = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        //    ViewBag.MonthName = Newtonsoft.Json.JsonConvert.SerializeObject(monthlists);



        //    // This was also 
        //    //List<decimal> lst = new List<decimal>();
        //    //ViewBag.Data = salesperMonths.Select(k => new { k.Month, k.Amount }).GroupBy(x => new { x.Month }, (key, group) => new
        //    //{
        //    //    Month = key.Month,
        //    //    Amount = group.Sum(k => k.Amount)
        //    //}).ToArray();

        //    //Also this 

        //    //ViewBag.Data = salesperMonths.GroupBy(x => new { x.Month }, (key, group) => new
        //    //{
        //    //    Amount = group.Sum(k => k.Amount)
        //    //}).ToList();


        //    //Changed to ENumerble 

        //    //var other= salesperMonths.GroupBy(a => new {
        //    //      Month = a.Month
        //    //  })
        //    //.AsEnumerable()
        //    //.Select(q => salesperMonths
        //    //{
        //    //    Month = q.Key.Month,
        //    //    Year = q.Key.Year,
        //    //    Total = q.SelectMany(a => a.DetalleVenta).Sum(a => a.Total)
        //    //}).OrderByDescending(a => a.Month)
        //    //.ToList();

        //    return PartialView("_TotalSalesPerMonth");
        //}
    }
}