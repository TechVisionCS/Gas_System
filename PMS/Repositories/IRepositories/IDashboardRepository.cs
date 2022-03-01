using PMS.Models;
using PMS.ViewModels.PurchaseViewModels;
using PMS.ViewModels.SaleViewModels;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IDashboardRepository
    {
        IEnumerable<SaleDetailsViewModel> GetAllSaleDetails();
        IEnumerable<PurchaseDetailsViewModel> GetAllPurchaseDetails();
        IEnumerable<SalesPerMonthViewModel> GetAllSalesPerMonth();
        IEnumerable<SalesPerMonthViewModel> GetAllPurchasePerMonth();

        IEnumerable<Expense> GetAllExpense();

        // void MonthSales(out string Months, out string Amount);
        long GetAllProducts();
        long GetAllProductseMonth();

        long GetAllCustomers();
        long GetAllCustomersMonth();

        long GetAllSuppliers();
        long GetAllSuppliersMonth();
        decimal GetAllExpenses();
        decimal GetAllExpensesMonth();

    }
}
