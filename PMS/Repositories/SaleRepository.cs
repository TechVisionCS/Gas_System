using PMS.Data;
using PMS.Data.Enums;
using PMS.Models;
using PMS.Models.Finance;
using PMS.Models.Sale;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels.SaleViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly PMSHelper pmsHelper;
        private readonly ITransactionRepository transactionRepository;
        private readonly IStockRepository stockRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IBankRepository bankRepository;
        private readonly IShopRepository shopRepository;



        public SaleRepository(ApplicationDbContext dbContext,
                                  IHelperRepository helperRepository,
                                  PMSHelper pmsHelper,
                                  ITransactionRepository transactionRepository,
                                  IStockRepository stockRepository,
                                  ICustomerRepository customerRepository,
                                  IBankRepository bankRepository, IShopRepository shopRepository)
        {
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
            this.pmsHelper = pmsHelper;
            this.transactionRepository = transactionRepository;
            this.stockRepository = stockRepository;
            this.customerRepository = customerRepository;
            this.bankRepository = bankRepository;
            this.shopRepository = shopRepository;
        }

        public IEnumerable<SaleViewModel> GetAllSales()
        {
            if (dbContext != null)
            {
                List<SaleViewModel> list = new List<SaleViewModel>();
                var models = dbContext.Sales.Where(x => x.DeletedAt == null).OrderByDescending(x => x.Id).ToList();
                long sno = 1;

                foreach (var m in models)
                {
                    var bId = (long)0;
                    var bName = "";


                    if (m.PaymentType != 1)
                    {
                        bId = m.BankId;
                        bName = dbContext.Banks.FirstOrDefault(x => x.Id == m.BankId).BankName;
                    }


                    var cName = "WALKING CUSTOMER";
                    Customer customer = new Customer();

                    if (m.CustomerId != 0)
                    {
                        cName = dbContext.Customers.FirstOrDefault(x => x.Id == m.CustomerId).Name;
                        customer = dbContext.Customers.FirstOrDefault(x => x.Id == m.CustomerId);
                    }


                    SaleViewModel model = new SaleViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        SaleDate = m.SaleDate.Date.ToString(),
                        CustomerId = m.CustomerId,
                        CustomerName = cName,
                        Customer = customer,
                        PaymentType = m.PaymentType,
                        BankId = bId,
                        BankName = bName,
                        SubTotal = m.SubTotal,
                        RentAmount = m.RentAmount,
                        TaxAmount = m.TaxAmount,
                        DiscountAmount = m.DiscountAmount,
                        TotalAmount = m.TotalAmount,
                        PaidAmount = m.PaidAmount,
                        DueAmount = m.DueAmount,
                        Description = m.Description,
                        TransCode = m.TransCode,
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt,
                        UserId = m.UserId,
                        UserName = pmsHelper.GetUserName(m.UserId)

                    };

                    sno++;

                    list.Add(model);
                }

                return list;
            }
            return null;
        }

        public IEnumerable<SaleDetailsViewModel> GetAllSaleDetails(long id)
        {
            if (dbContext != null)
            {
                List<SaleDetailsViewModel> list = new List<SaleDetailsViewModel>();
                var details = dbContext.SaleDetails.Where(x => x.SaleId == id).ToList();
                var sno = 1;

                foreach (var d in details)
                {
                    SaleDetailsViewModel model = new SaleDetailsViewModel
                    {
                        ProductId = d.ProductId,
                        Product = dbContext.Products.FirstOrDefault(x => x.Id == d.ProductId),
                        UnitId = d.UnitId,
                        Unit = dbContext.Units.FirstOrDefault(x => x.Id == d.UnitId),
                        Qty = d.Qty,
                        UnitPrice = d.UnitPrice,
                        Discount = d.Discount,
                        TotalSalePrice = d.TotalSalePrice,
                        Sno = sno
                    };

                    sno++;

                    list.Add(model);
                }

                return list;
            }
            return null;
        }

        public ViewSaleDetailsViewModel GetSale(long id)
        {
            if (dbContext != null)
            {
                var sale = GetAllSales().FirstOrDefault(x => x.Id == id);
                var details = GetAllSaleDetails(id);
                var ShopDetails = shopRepository.GetShop();

                ViewSaleDetailsViewModel model = new ViewSaleDetailsViewModel
                {
                    Sale = sale,
                    SaleDetails = details,
                    ShopModelDetails = ShopDetails
                };

                return model;
            }

            return null;
        }

        public CreateSaleViewModel GetSaleForEdit(long id)
        {
            if (dbContext != null)
            {
                var sale = dbContext.Sales.FirstOrDefault(x => x.Id == id);
                if (sale == null)
                {
                    return null;
                }

                var details = dbContext.SaleDetails.Where(x => x.SaleId == id).ToList();
                CreateSaleViewModel model = new CreateSaleViewModel
                {
                    Sale = sale,
                    SaleDetails = details
                };

                return model;
            }
            return null;
        }

        public long AddSale(CreateSaleViewModel saleViewModel)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                //Save Sale 
                var transCode = helperRepository.GetTransactionCode();
                saleViewModel.Sale.TransCode = transCode;

                var saleId = AddNewSale(saleViewModel.Sale);

                if (saleId != 0)
                {
                    //Save Sale Details 
                    var saleDetails = AddSaleDetails(saleId, saleViewModel.SaleDetails);

                    if (saleDetails != 0)
                    {
                        //Add to Stock
                        var stockDetails = AddStockDetails(saleViewModel.Sale.CustomerId, saleViewModel.SaleDetails, transCode, saleId);

                        if (stockDetails)
                        {
                            // Add Customer Ledger
                            // Add Cash or Bank Ledger
                            var sl = AddCustomerLedgerDetails(transCode, saleViewModel.Sale, saleId);
                            if (sl == 0)
                            {
                                return 0;
                            }

                            var cl = AddCustomerCashLedgerDetails(transCode, saleViewModel.Sale, saleId);
                            if (cl == 0)
                            {
                                return 0;
                            }

                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }

                transaction.Commit();

                return saleId;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }

            return 0;
        }

        private long AddNewSale(Sale sale)
        {
            if (dbContext != null)
            {
                sale.CreatedAt = DateTime.Now;
                sale.UpdatedAt = DateTime.Now;
                sale.UserId = helperRepository.GetCurrentUserId();
                sale.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Sales.Add(sale);
                dbContext.SaveChanges();

                var maxId = dbContext.Sales.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        private long AddSaleDetails(long saleId, IEnumerable<SaleDetails> saleDetails)
        {
            if (dbContext != null)
            {
                foreach (var d in saleDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.SaleId = saleId;
                }

                dbContext.AddRange(saleDetails);
                dbContext.SaveChanges();

                return 1;
            }

            return 0;
        }

        private bool AddStockDetails(long customerId, IEnumerable<SaleDetails> saleDetails, string transCode, long saleId)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in saleDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = 0,
                        OutQty = QtyUnits,
                        StockQty = 0 - QtyUnits,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list.Add(model);

                    //Add Stock Details
                    if (!StockDetails(customerId, p, transCode, saleId))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool StockDetails(long customerId, SaleDetails p, string tcode, long saleId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    CustomerId = customerId,
                    SupplierId = 0,
                    InQty = 0,
                    OutQty = QtyUnits,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Sale(p.ProductId, customerId, saleId),

                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = helperRepository.GetCurrentUserId(),
                    UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                };

                dbContext.StockDetails.Add(model);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private int AddCustomerLedgerDetails(string trc, Sale sale, long saleId)
        {
            if (dbContext != null)
            {
                CustomerLedger customerLedger_total = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerSaleMsg(saleId, sale.TotalAmount),
                    Debit = sale.TotalAmount,
                    Credit = 0,
                    Balance = sale.TotalAmount - 0,
                    TransCode = trc,
                };

                CustomerLedger customerLedger_paid = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                    Debit = 0,
                    Credit = sale.PaidAmount,
                    Balance = 0 - sale.PaidAmount,
                    TransCode = trc,
                };


                Transaction transaction1 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerSaleMsg(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr1 = transactionRepository.AddTransactionLog(transaction1);
                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr1 == true && tr2 == true)
                {
                    var res1 = transactionRepository.AddCustomerLedger(customerLedger_total);
                    var res2 = transactionRepository.AddCustomerLedger(customerLedger_paid);
                    if (res1 != null && res2 != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private int AddCustomerCashLedgerDetails(string transCode, Sale sale, long saleId)
        {
            if (dbContext != null)
            {

                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr2 == true)
                {

                    //Cash Ledger
                    if (sale.BankId != 0)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = sale.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                            Debit = sale.PaidAmount,
                            Credit = 0,
                            Balance = sale.PaidAmount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };


                        var res = transactionRepository.AddBankLedger(bankLedger);
                        if (res != null)
                        {
                            return 1;
                        }


                    }
                    else
                    {
                        CashLedger cashLedger_paid = new CashLedger
                        {
                            EntityId = sale.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                            VoucherNo = saleId.ToString(),
                            Debit = sale.PaidAmount,
                            Credit = 0,
                            Balance = sale.PaidAmount - 0,
                            TransCode = transCode,
                            TransType = CashType.Sale,
                        };

                        var res2 = transactionRepository.AddCashLedger(cashLedger_paid);

                        if (res2 != null)
                        {
                            return 1;
                        }
                    }

                }

            }
            return 0;
        }


        public string GetInvoiceNo()
        {
            if (dbContext != null)
            {
                var sales = dbContext.Sales.ToList();
                long maxId = 1;
                if (sales.Any())
                {
                    maxId = dbContext.Sales.Max(x => x.Id) + 1;
                }

                return maxId.ToString();

            }
            return null;
        }

        public IEnumerable<ProductBatch> GetProductBatches(long productId)
        {
            if (dbContext != null)
            {
                var batches = dbContext.ProductBatches.Where(x => x.ProductId == productId && x.StockQty != 0 && x.DeletedAt == null).ToList();
                return batches;
            }
            return null;
        }

        public IEnumerable<ProductBatch> GetProductBatchesWithExpireDate(long productId)
        {
            if (dbContext != null)
            {
                var batches = dbContext.ProductBatches.Where(x => x.ProductId == productId && x.StockQty != 0 && x.DeletedAt == null).ToList();
                List<ProductBatch> list = new List<ProductBatch>();

                foreach (var model in batches)
                {
                    ProductBatch m = new ProductBatch
                    {
                        Id = model.Id,
                        BatchId = model.BatchId,
                        BatchIdName = model.BatchId, // + " | " + model.ExpireDate?.ToString("dd/MM/yyyy"),
                        ProductId = model.ProductId,
                        //ExpireDate = model.ExpireDate
                    };

                    list.Add(m);
                }
                return list;
            }
            return null;
        }

        public decimal GetProductUnitQty(long productId, long unitId)
        {
            if (dbContext != null)
            {
                var qty = dbContext.Stocks.Where(x => x.ProductId == productId).Sum(x => x.StockQty);
                var unitAmount = dbContext.Units.FirstOrDefault(x => x.Id == unitId).KgAmount;
                var currentQty = qty / unitAmount;

                return (decimal)currentQty;
            }

            return 0;
        }

        public decimal GetUnitPrice(long productId, long unitId)
        {
            if (dbContext != null)
            {
                var prc = dbContext.ProductUnits.FirstOrDefault(x => x.ProductId == productId && x.UnitId == unitId).UnitSellPrice;
                if (prc > 0)
                {
                    return prc;
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        public ProductBatch GetSaleDetailsByBatchId(string batchId)
        {
            if (dbContext != null)
            {
                var batch = dbContext.ProductBatches.FirstOrDefault(x => x.BatchId == batchId && x.StockQty > 0 && x.DeletedAt == null);
                if (batch != null)
                {
                    return batch;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public SaleDetails GetSaleDetailsById(long id)
        {
            if (dbContext != null)
            {
                var details = dbContext.SaleDetails.FirstOrDefault(x => x.Id == id);
                if (details != null)
                {
                    return details;
                }
                return null;
            }

            return null;
        }

        public bool DeleteSale(long saleId)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();

                var transCode = helperRepository.GetTransactionCode();

                //Delete Sale
                var deletedSale = dbContext.Sales.FirstOrDefault(x => x.Id == saleId && x.DeletedAt == null);
                if (deletedSale != null)
                {
                    deletedSale.DeletedAt = DateTime.Now;
                    dbContext.Sales.Update(deletedSale);
                    dbContext.SaveChanges();

                    //Delete Sale Details
                    var deletedSaleDetails = dbContext.SaleDetails.Where(x => x.SaleId == saleId && x.DeletedAt == null).ToList();
                    if (deletedSaleDetails.Any())
                    {
                        foreach (var d in deletedSaleDetails)
                        {
                            d.DeletedAt = DateTime.Now;
                        }
                        dbContext.UpdateRange(deletedSaleDetails);
                        dbContext.SaveChanges();

                        //Update Stock and Stock Details
                        var deletedStockDetails = DeleteSale_Stock(deletedSale.CustomerId, deletedSaleDetails, transCode, saleId);
                        if (deletedStockDetails)
                        {
                            //Update Customer and Cash/Bank Ledgers
                            var sl = DeleteSale_CustomerLedgerDetails(transCode, deletedSale, saleId);
                            if (sl == 0)
                            {
                                return false;
                            }

                            var cl = DeleteSale_CustomerCashLedgerDetails(transCode, deletedSale, saleId);
                            if (cl == 0)
                            {
                                return false;
                            }


                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

                transaction.Commit();
                return true;
            }
            return false;
        }


        private bool DeleteSale_Stock(long customerId, IEnumerable<SaleDetails> saleDetails, string transCode, long saleId)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in saleDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = QtyUnits,
                        OutQty = 0,
                        StockQty = QtyUnits - 0,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list.Add(model);

                    if (!DeleteSale_StockDetails(customerId, p, transCode, saleId))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool DeleteSale_StockDetails(long customerId, SaleDetails p, string tcode, long saleId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = -1,
                    CustomerId = customerId,
                    InQty = QtyUnits,
                    OutQty = 0,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Sale_Delete(p.ProductId, customerId, saleId),

                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = helperRepository.GetCurrentUserId(),
                    UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                };

                dbContext.StockDetails.Add(model);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private int DeleteSale_CustomerLedgerDetails(string trc, Sale sale, long saleId)
        {
            if (dbContext != null)
            {
                CustomerLedger customerLedger_total = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerSaleTotalMsg_Delete(saleId, sale.TotalAmount),
                    Debit = 0,
                    Credit = sale.TotalAmount,
                    Balance = 0 - sale.TotalAmount,
                    TransCode = trc,
                };

                CustomerLedger customerLedger_paid = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerSalePaidMsg_Delete(saleId, sale.PaidAmount),
                    Debit = sale.PaidAmount,
                    Credit = 0,
                    Balance = sale.PaidAmount - 0,
                    TransCode = trc,
                };


                Transaction transaction1 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CustomerSaleTotalMsg_Delete(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerSalePaidMsg_Delete(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr1 = transactionRepository.AddTransactionLog(transaction1);
                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr1 == true && tr2 == true)
                {
                    var res1 = transactionRepository.AddCustomerLedger(customerLedger_total);
                    var res2 = transactionRepository.AddCustomerLedger(customerLedger_paid);
                    if (res1 != null && res2 != null)
                    {
                        return 1;
                    }
                }

            }
            return 0;
        }

        private int DeleteSale_CustomerCashLedgerDetails(string transCode, Sale sale, long saleId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CashBankSalePaidMsg_Delete(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr2 == true)
                {
                    //Cash Ledger
                    if (sale.BankId != 0)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = sale.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.CashBankSalePaidMsg_Delete(saleId, sale.PaidAmount),
                            Debit = 0,
                            Credit = sale.PaidAmount,
                            Balance = 0 - sale.PaidAmount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };


                        var res = transactionRepository.AddBankLedger(bankLedger);
                        if (res != null)
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        CashLedger cashLedger_paid = new CashLedger
                        {
                            EntityId = sale.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = DateTime.Now,
                            VoucherNo = saleId.ToString(),
                            Description = helperRepository.CashBankSalePaidMsg_Delete(saleId, sale.PaidAmount),
                            Debit = 0,
                            Credit = sale.PaidAmount,
                            Balance = 0 - sale.PaidAmount,
                            TransCode = transCode,
                            TransType = CashType.Sale,
                        };

                        var res2 = transactionRepository.AddCashLedger(cashLedger_paid);

                        if (res2 != null)
                        {
                            return 1;
                        }
                    }

                }

            }
            return 0;
        }

        public CreateSaleViewModel UpdateSale(CreateSaleViewModel saleViewModel)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                //Upate Sale 
                var transCode = saleViewModel.Sale.TransCode;

                saleViewModel.Sale.UpdatedAt = DateTime.Now;
                saleViewModel.Sale.UserId = helperRepository.GetCurrentUserId();
                saleViewModel.Sale.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Sales.Update(saleViewModel.Sale);
                dbContext.SaveChanges();

                //delete old sale details 
                var oldSaleDetails = dbContext.SaleDetails.Where(x => x.SaleId == saleViewModel.Sale.Id).ToList();
                dbContext.SaleDetails.RemoveRange(oldSaleDetails);
                dbContext.SaveChanges();

                //add new sale details
                foreach (var d in saleViewModel.SaleDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.SaleId = saleViewModel.Sale.Id;
                }
                dbContext.SaleDetails.AddRange(saleViewModel.SaleDetails);
                dbContext.SaveChanges();

                //Update Stock
                var updatedStockDetails = UpdateSale_Stock(saleViewModel.Sale, saleViewModel.SaleDetails, oldSaleDetails);
                if (updatedStockDetails)
                {
                    //Update Customer and Cash/Bank Ledgers
                    var sl = UpdateSale_CustomerLedgerDetails(transCode, saleViewModel.Sale, saleViewModel.Sale.Id);
                    if (sl == 0)
                    {
                        return null;
                    }

                    var cl = UpdateSale_CustomerCashLedgerDetails(transCode, saleViewModel.Sale, saleViewModel.Sale.Id);
                    if (cl == 0)
                    {
                        return null;
                    }


                }
                else
                {
                    return null;
                }

                transaction.Commit();

                return saleViewModel;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }

            return null;
        }

        private bool UpdateSale_Stock(Sale sale, IEnumerable<SaleDetails> saleDetails, IEnumerable<SaleDetails> oldSaleDetails)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in oldSaleDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = QtyUnits,
                        OutQty = 0,
                        StockQty = QtyUnits - 0,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list.Add(model);

                    if (!UpdateSale_StockDetailsDelete(sale.CustomerId, p, sale.TransCode, sale.Id))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();

                List<Stock> list2 = new List<Stock>();
                foreach (var p in saleDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = 0,
                        OutQty = QtyUnits,
                        StockQty = 0 - QtyUnits,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list2.Add(model);

                    //Add Stock Details
                    if (!UpdateSale_StockDetailsAdd(sale.CustomerId, p, sale.TransCode, sale.Id))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list2);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool UpdateSale_StockDetailsDelete(long customerId, SaleDetails p, string tcode, long saleId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = -1,
                    CustomerId = customerId,
                    InQty = QtyUnits,
                    OutQty = 0,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Sale_Delete(p.ProductId, customerId, saleId),

                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = helperRepository.GetCurrentUserId(),
                    UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                };

                dbContext.StockDetails.Add(model);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool UpdateSale_StockDetailsAdd(long customerId, SaleDetails p, string tcode, long saleId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    CustomerId = customerId,
                    SupplierId = 0,
                    InQty = 0,
                    OutQty = QtyUnits,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Sale_Update(p.ProductId, customerId, saleId),

                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = helperRepository.GetCurrentUserId(),
                    UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                };

                dbContext.StockDetails.Add(model);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private int UpdateSale_CustomerLedgerDetails(string trc, Sale sale, long saleId)
        {
            if (dbContext != null)
            {
                //if transaction code is null ... find solution for it.
                var old_customerLedger_total = dbContext.CustomerLedgers.FirstOrDefault(x => x.TransCode == trc);
                transactionRepository.DeleteCustomerLedger(old_customerLedger_total); //Delete add records, total and paid ...

                CustomerLedger customerLedger_total = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerSaleMsg(saleId, sale.TotalAmount),
                    Debit = sale.TotalAmount,
                    Credit = 0,
                    Balance = sale.TotalAmount - 0,
                    TransCode = trc,
                };

                CustomerLedger customerLedger_paid = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                    Debit = 0,
                    Credit = sale.PaidAmount,
                    Balance = 0 - sale.PaidAmount,
                    TransCode = trc,
                };


                Transaction transaction1 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerSaleMsg(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr1 = transactionRepository.AddTransactionLog(transaction1);
                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr1 == true && tr2 == true)
                {
                    var res1 = transactionRepository.AddCustomerLedger(customerLedger_total);
                    var res2 = transactionRepository.AddCustomerLedger(customerLedger_paid);
                    if (res1 != null && res2 != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private int UpdateSale_CustomerCashLedgerDetails(string transCode, Sale sale, long saleId)
        {
            if (dbContext != null)
            {
                //if transaction code is null ... find solution for it.

                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr2 == true)
                {

                    //Cash Ledger
                    if (sale.BankId != 0)
                    {
                        var old_bankledger = dbContext.BankLedgers.FirstOrDefault(x => x.TransCode == transCode);
                        transactionRepository.DeleteBankLedger(old_bankledger);

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = sale.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                            Debit = sale.PaidAmount,
                            Credit = 0,
                            Balance = sale.PaidAmount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };


                        var res = transactionRepository.AddBankLedger(bankLedger);
                        if (res != null)
                        {
                            return 1;
                        }


                    }
                    else
                    {
                        var old_cashledger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);
                        transactionRepository.DeleteCashLedger(old_cashledger);

                        CashLedger cashLedger_paid = new CashLedger
                        {
                            EntityId = sale.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerPaidMsg(saleId, sale.PaidAmount),
                            VoucherNo = saleId.ToString(),
                            Debit = sale.PaidAmount,
                            Credit = 0,
                            Balance = sale.PaidAmount - 0,
                            TransCode = transCode,
                            TransType = CashType.Sale,
                        };

                        var res2 = transactionRepository.AddCashLedger(cashLedger_paid);

                        if (res2 != null)
                        {
                            return 1;
                        }
                    }

                }

            }
            return 0;
        }


    }
}
