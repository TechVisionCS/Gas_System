using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PMS.Repositories.IRepositories;
using System;
using System.Collections.Generic;
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
            var TotalExpenses = dashboardRepository.GetAllExpenses();
            ViewBag.TotalExpenses = TotalExpenses;

            var TotalExpensesMonth = dashboardRepository.GetAllExpensesMonth();
            ViewBag.TotalExpensesMonth = TotalExpensesMonth;

            //Sale Report
            var SaleDetails = dashboardRepository.GetAllSaleDetails();
            ViewBag.SaleQty = SaleDetails.Select(x => x.Qty).Sum();
            ViewBag.TotalSale = SaleDetails.Select(x => x.TotalSalePrice).Sum();
            ViewBag.TotalSalePerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.TotalSalePrice).Sum();
            var check = SaleDetails;
            if (check == null)
            {
                ViewBag.SaleRevenue = 0;
                ViewBag.SaleRevenuePerMonth = 0;
                ViewBag.SaleRevenueQty = 0;
                ViewBag.TotalProfit = 0;
                ViewBag.TotalProfitPerMonth = 0;
            }
            else
            {
                try
                { //Revenue
                    ViewBag.SaleRevenue = SaleDetails.Select(x => x.Qty).Sum() * SaleDetails.Select(x => x.UnitPrice).Average();
                    ViewBag.SaleRevenuePerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Qty).Sum() * SaleDetails.Select(x => x.UnitPrice).Average();
                    ViewBag.SaleRevenueQty = SaleDetails.Select(x => x.Qty).Sum();
                    ViewBag.TotalProfit = SaleDetails.Select(x => x.Qty).Sum() * SaleDetails.Select(x => x.UnitPrice).Average() - TotalExpenses;
                    ViewBag.TotalProfitPerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Qty).Sum() * SaleDetails.Select(x => x.UnitPrice).Average() - TotalExpenses;
                }
                catch
                {
                }
            }

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

        public ActionResult TotalSalesPerMonth()
        {
            //PassMonth List Static for now
            var monthlists = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ViewBag.MonthName = Newtonsoft.Json.JsonConvert.SerializeObject(monthlists);
            var salesperMonths = dashboardRepository.GetAllSalesPerMonth();

            // Method One 

            //ViewBag.other = salesperMonths
            //   .GroupBy(x => new { group = x.Month }).Select(group => new
            //   {
            //       sum = salesperMonths.Select(x => x.Amount).Sum()
            //   }).ToArray();

            //Method Tow
            ViewBag.another = (from t in salesperMonths
                               group t by new
                               {
                                   t.Month
                               }
                       into g
                               select g.Sum(a => a.Amount)).ToArray();

            // This was also 
            //List<decimal> lst = new List<decimal>();
            //ViewBag.Data = salesperMonths.Select(k => new { k.Month, k.Amount }).GroupBy(x => new { x.Month }, (key, group) => new
            //{
            //    Month = key.Month,
            //    Amount = group.Sum(k => k.Amount)
            //}).ToArray();

            //Also this 

            //ViewBag.Data = salesperMonths.GroupBy(x => new { x.Month }, (key, group) => new
            //{
            //    Amount = group.Sum(k => k.Amount)
            //}).ToList();


            //Changed to ENumerble 

            //var other= salesperMonths.GroupBy(a => new {
            //      Month = a.Month
            //  })
            //.AsEnumerable()
            //.Select(q => salesperMonths
            //{
            //    Month = q.Key.Month,
            //    Year = q.Key.Year,
            //    Total = q.SelectMany(a => a.DetalleVenta).Sum(a => a.Total)
            //}).OrderByDescending(a => a.Month)
            //.ToList();

            return PartialView("_TotalSalesPerMonth");
        }
    }
}