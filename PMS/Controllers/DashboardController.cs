using Microsoft.AspNetCore.Mvc;
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
            //Sales in bar chart
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

            //purchase in bar chart
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

            //Expense Moduel
            var TotalExpenses = dashboardRepository.GetAllExpense();

            ViewBag.TotalExpenses = TotalExpenses.Where(x => x.DeletedAt == null).Sum(x => x.Amount);
            ViewBag.TotalExpensesMonth = TotalExpenses.Where(xd => xd.ExpenseDate.Value.Month == DateTime.Now.Month).Select(x => x.Amount).Sum();
            ViewBag.TodayExpense = TotalExpenses.Where(xd => xd.ExpenseDate.Value.Day == DateTime.Now.Day).Select(x => x.Amount).Sum();

            decimal TotalExpensesMonth = TotalExpenses.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Amount).Sum();
            decimal expense = TotalExpenses.Where(x => x.DeletedAt == null).Sum(x => x.Amount);

            //Sale Modul
            var SaleDetails = dashboardRepository.GetAllSaleDetails();

            ViewBag.SaleQty = SaleDetails.Select(x => x.Qty).Sum();

            ViewBag.TotalSale = SaleDetails.Select(x => x.TotalSalePrice).Sum();
            ViewBag.TotalSalePerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.TotalSalePrice).Sum();
            ViewBag.TodaySale = SaleDetails.Where(xd => xd.CreatedAt.Value.Day == DateTime.Now.Day).Select(x => x.TotalSalePrice).Sum();

            ViewBag.SaleRevenueQty = SaleDetails.Select(x => x.Qty).Sum();
            ViewBag.SaleRevenue = (SaleDetails.Select(x => x.Qty).Sum()) * (SaleDetails.Select(x => x.UnitPrice).DefaultIfEmpty().Average());
            ViewBag.SaleRevenuePerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Qty).Sum() * (SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.UnitPrice).DefaultIfEmpty().Average());
            ViewBag.TodaySaleRevenue = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Qty).Sum() * (SaleDetails.Where(xd => xd.CreatedAt.Value.Day == DateTime.Now.Day).Select(x => x.UnitPrice).DefaultIfEmpty().Average());

            ViewBag.TotalProfit = SaleDetails.Select(x => x.Qty).Sum() * SaleDetails.Select(x => x.UnitPrice).DefaultIfEmpty().Average() - expense;
            ViewBag.TotalProfitPerMonth = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Qty).Sum() * (SaleDetails.Where(x => x.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.UnitPrice).DefaultIfEmpty().Average()) - (TotalExpensesMonth);
            ViewBag.TodayProfit = SaleDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.Qty).Sum() * (SaleDetails.Where(x => x.CreatedAt.Value.Day == DateTime.Now.Day).Select(x => x.UnitPrice).DefaultIfEmpty().Average()) - (TotalExpensesMonth);

            var PurchaseDetails = dashboardRepository.GetAllPurchaseDetails();

            ViewBag.PurchaseQty = PurchaseDetails.Select(x => x.Qty).Sum();
            ViewBag.TotalPurchase = PurchaseDetails.Select(x => x.TotalPurchasePrice).Sum();
            ViewBag.TotalPurchasePerMonth = PurchaseDetails.Where(xd => xd.CreatedAt.Value.Month == DateTime.Now.Month).Select(x => x.TotalPurchasePrice).Sum();
            ViewBag.TotalPurchaseToday = PurchaseDetails.Where(xd => xd.CreatedAt.Value.Day == DateTime.Now.Day).Select(x => x.TotalPurchasePrice).Sum();

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

    }
}