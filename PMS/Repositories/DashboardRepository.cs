﻿using PMS.Data;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.PurchaseViewModels;
using PMS.ViewModels.SaleViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    [System.Runtime.InteropServices.Guid("25B42203-39AE-45CD-8B9A-260FC7007718")]
    public class DashboardRepository : IDashboardRepository
    {
        private readonly ApplicationDbContext dbContext;

        public DashboardRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<SaleDetailsViewModel> GetAllSaleDetails()
        {
            if (dbContext != null)
            {
                List<SaleDetailsViewModel> list = new List<SaleDetailsViewModel>();
                var details = dbContext.SaleDetails.Where(x => x.DeletedAt == null).ToList();
                var sno = 1;

                foreach (var d in details)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == d.UnitId).KgAmount;
                    float QtyUnits = (float)d.Qty * kgunits;

                    SaleDetailsViewModel model = new SaleDetailsViewModel
                    {
                        ProductId = d.ProductId,
                        Product = dbContext.Products.FirstOrDefault(x => x.Id == d.ProductId),
                        UnitId = d.UnitId,
                        Unit = dbContext.Units.FirstOrDefault(x => x.Id == d.UnitId),
                        Qty = (decimal)QtyUnits,
                        UnitPrice = d.UnitPrice,
                        Discount = d.Discount,
                        TotalSalePrice = d.TotalSalePrice,
                        CreatedAt = d.CreatedAt,
                        Sno = sno
                    };

                    sno++;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public IEnumerable<PurchaseDetailsViewModel> GetAllPurchaseDetails()
        {
            if (dbContext != null)
            {
                List<PurchaseDetailsViewModel> list = new List<PurchaseDetailsViewModel>();
                var details = dbContext.PurchaseDetails.ToList();
                var sno = 1;

                foreach (var d in details)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == d.UnitId).KgAmount;
                    float QtyUnits = (float)d.Qty * kgunits;

                    PurchaseDetailsViewModel model = new PurchaseDetailsViewModel
                    {
                        ProductId = d.ProductId,
                        Product = dbContext.Products.FirstOrDefault(x => x.Id == d.ProductId),
                        UnitId = d.UnitId,
                        Unit = dbContext.Units.FirstOrDefault(x => x.Id == d.UnitId),
                        Qty = (decimal)QtyUnits,
                        PurchasePrice = d.PurchasePrice,
                        TotalPurchasePrice = d.TotalPurchasePrice,
                        CreatedAt = d.CreatedAt,
                        Sno = sno
                    };

                    sno++;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public long GetAllProducts()
        {
            if (dbContext != null)
            {
                var Products = dbContext.Products.Where(x => x.DeletedAt == null).Count();
                if (Products > 0)
                {
                    return Products;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public long GetAllProductseMonth()
        {
            if (dbContext != null)
            {
                var Products = dbContext.Products.Where(x => x.DeletedAt == null && x.CreatedAt.Value.Month == DateTime.Now.Month).Count();
                if (Products > 0)
                {
                    return Products;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public decimal GetAllExpenses()
        {
            if (dbContext != null)
            {
                var totalExpense = dbContext.Expenses.Where(x => x.DeletedAt == null).Sum(x => x.Amount);
                if (totalExpense > 0)
                {
                    return totalExpense;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public decimal GetAllExpensesMonth()
        {
            if (dbContext != null)
            {
                var totalExpense = dbContext.Expenses.Where(x => x.DeletedAt == null && x.ExpenseDate.Value.Month == DateTime.Now.Month).Sum(x => x.Amount);
                if (totalExpense > 0)
                {
                    return totalExpense;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public long GetAllCustomers()
        {
            if (dbContext != null)
            {
                var Customers = dbContext.Customers.Where(x => x.DeletedAt == null).Count();
                if (Customers > 0)
                {
                    return Customers;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public long GetAllCustomersMonth()
        {
            if (dbContext != null)
            {
                var Customers = dbContext.Customers.Where(x => x.DeletedAt == null && x.CreatedAt.Value.Month == DateTime.Now.Month).Count();
                if (Customers > 0)
                {
                    return Customers;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public long GetAllSuppliers()
        {
            if (dbContext != null)
            {
                var Suppliers = dbContext.Suppliers.Where(x => x.DeletedAt == null).Count();
                if (Suppliers > 0)
                {
                    return Suppliers;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public long GetAllSuppliersMonth()
        {
            if (dbContext != null)
            {
                var Suppliers = dbContext.Suppliers.Where(x => x.DeletedAt == null && x.CreatedAt.Value.Month == DateTime.Now.Month).Count();

                if (Suppliers > 0)
                {
                    return Suppliers;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public IEnumerable<SalesPerMonthViewModel> GetAllSalesPerMonth()
        {
            if (dbContext != null)
            {
                List<SalesPerMonthViewModel> list = new List<SalesPerMonthViewModel>();
                var details = dbContext.Sales.Where(x => x.DeletedAt == null).ToList();
                foreach (var d in details)
                {
                    SalesPerMonthViewModel model = new SalesPerMonthViewModel
                    {
                        Amount = d.TotalAmount,
                        Month = d.SaleDate.Month,
                        Year = d.SaleDate.Year

                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        //i leaved the salepermonthviewmodel same VM for purchase
        public IEnumerable<SalesPerMonthViewModel> GetAllPurchasePerMonth()
        {
            if (dbContext != null)
            {
                List<SalesPerMonthViewModel> list = new List<SalesPerMonthViewModel>();
                var details = dbContext.Purchases.Where(x => x.DeletedAt == null).ToList();
                foreach (var d in details)
                {
                    SalesPerMonthViewModel model = new SalesPerMonthViewModel
                    {
                        Amount = d.TotalAmount,
                        Month = d.PurchaseDate.Month,
                        Year = d.PurchaseDate.Year

                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public IEnumerable<Expense> GetAllExpense()
        {
            if (dbContext != null)
            {
                var totalExpense = dbContext.Expenses.ToList();

                if (totalExpense != null)
                {
                    return totalExpense;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
