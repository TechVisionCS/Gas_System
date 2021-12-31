using PMS.Data;
using PMS.Data.Enums;
using PMS.Models;
using PMS.Models.Finance;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels.ReturnViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class ReturnRepository : IReturnRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly PMSHelper pmsHelper;
        private readonly ITransactionRepository transactionRepository;
        private readonly IStockRepository stockRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly ISupplierRepository supplierRepository;
        private readonly IBankRepository bankRepository;

        public ReturnRepository(ApplicationDbContext dbContext,
                                  IHelperRepository helperRepository,
                                  PMSHelper pmsHelper,
                                  ITransactionRepository transactionRepository,
                                  IStockRepository stockRepository,
                                  ICustomerRepository customerRepository,
                                  ISupplierRepository supplierRepository,
                                  IBankRepository bankRepository)
        {
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
            this.pmsHelper = pmsHelper;
            this.transactionRepository = transactionRepository;
            this.stockRepository = stockRepository;
            this.customerRepository = customerRepository;
            this.supplierRepository = supplierRepository;
            this.bankRepository = bankRepository;
        }

        ///returns type
        /// 0.Sale Returns
        /// 1.Purchase Returns
        /// 2.Wastages

        public IEnumerable<ReturnModelViewModel> GetAllSaleReturns()
        {
            if (dbContext != null)
            {
                List<ReturnModelViewModel> list = new List<ReturnModelViewModel>();
                var models = dbContext.Returns.Where(x => x.ReturnType == 0 && x.DeletedAt == null).ToList();
                if (models.Any())
                {
                    foreach (var m in models)
                    {
                        list.Add(MapReturnViewModel(m));
                    }
                }
                return list;
            }
            return null;
        }

        public IEnumerable<ReturnModelViewModel> GetAllSaleReturnsByDate(DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                List<ReturnModelViewModel> list = new List<ReturnModelViewModel>();
                var models = dbContext.Returns.Where(x => x.ReturnType == 0 && x.DeletedAt == null).ToList();

                if (startDate != null)
                {
                    models = models.Where(x => x.ReturnDate >= startDate).ToList();
                }

                if (endDate != null)
                {
                    models = models.Where(x => x.ReturnDate <= endDate).ToList();
                }

                if (models.Any())
                {
                    foreach (var m in models)
                    {
                        list.Add(MapReturnViewModel(m));
                    }
                }
                return list;
            }
            return null;
        }

        public IEnumerable<ReturnModelViewModel> GetAllPurchaseReturns()
        {
            if (dbContext != null)
            {
                List<ReturnModelViewModel> list = new List<ReturnModelViewModel>();
                var models = dbContext.Returns.Where(x => x.ReturnType == 1 && x.DeletedAt == null).ToList();
                if (models.Any())
                {
                    foreach (var m in models)
                    {
                        list.Add(MapReturnViewModel(m));
                    }
                }
                return list;
            }
            return null;
        }

        public IEnumerable<ReturnModelViewModel> GetAllPurchaseReturnsByDate(DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                List<ReturnModelViewModel> list = new List<ReturnModelViewModel>();
                var models = dbContext.Returns.Where(x => x.ReturnType == 1 && x.DeletedAt == null).ToList();

                if (startDate != null)
                {
                    models = models.Where(x => x.ReturnDate >= startDate).ToList();
                }

                if (endDate != null)
                {
                    models = models.Where(x => x.ReturnDate <= endDate).ToList();
                }

                if (models.Any())
                {
                    foreach (var m in models)
                    {
                        list.Add(MapReturnViewModel(m));
                    }
                }
                return list;
            }
            return null;
        }

        public ReturnViewModel GetPurchaseReturn(long returnId)
        {
            if (dbContext != null)
            {
                var rtn = dbContext.Returns.FirstOrDefault(x => x.Id == returnId && x.DeletedAt == null);
                var rtnDetails = dbContext.ReturnDetails.Where(x => x.ReturnId == returnId && x.DeletedAt == null).ToList();

                var SupplierName = supplierRepository.GetByIdForUpdate(rtn.SupplierId).Name;
                var BankName = "";
                if (rtn.BankId > 0)
                {
                    BankName = bankRepository.GetByIdBank(rtn.BankId).BankName;
                }

                ReturnModelViewModel model = new ReturnModelViewModel
                {
                    Id = rtn.Id,
                    PurchaseId = rtn.PurchaseId,
                    InvoiceNo = rtn.InvoiceNo,
                    ReturnType = rtn.ReturnType,
                    ReturnDate = rtn.ReturnDate,
                    CustomerId = -1,
                    CustomerName = "",
                    SupplierId = rtn.SupplierId,
                    SupplierName = SupplierName,
                    PaymentType = rtn.PaymentType,
                    BankId = rtn.BankId,
                    BankName = BankName,
                    SubTotal = rtn.SubTotal,
                    RentAmount = rtn.RentAmount,
                    TaxAmount = rtn.TaxAmount,
                    DiscountAmount = rtn.DiscountAmount,
                    TotalAmount = rtn.TotalAmount,
                    PaidAmount = rtn.PaidAmount,
                    DueAmount = rtn.DueAmount,
                    Description = rtn.Description,
                    CreatedAt = rtn.CreatedAt,
                    UpdatedAt = rtn.UpdatedAt,
                    DeletedAt = rtn.DeletedAt,
                    UserId = rtn.UserId,
                    UserName = pmsHelper.GetUserName(rtn.UserId)
                };

                List<ReturnDetailsViewModel> models = new List<ReturnDetailsViewModel>();
                foreach (var d in rtnDetails)
                {
                    ReturnDetailsViewModel m = new ReturnDetailsViewModel
                    {
                        ReturnId = returnId,
                        ProductId = d.ProductId,
                        Product = dbContext.Products.FirstOrDefault(x => x.Id == d.ProductId),
                        UnitId = d.UnitId,
                        Unit = dbContext.Units.FirstOrDefault(x => x.Id == d.UnitId),
                        Qty = d.Qty,
                        UnitPrice = d.UnitPrice,
                        Discount = d.Discount,
                        TotalPrice = d.TotalReturnPrice,
                        DetailsId = d.DetailsId
                    };
                    models.Add(m);
                }

                ReturnViewModel returnModel = new ReturnViewModel
                {
                    Return = model,
                    ReturnDetails = models
                };

                return returnModel;
            }

            return null;
        }

        public ReturnViewModel GetSaleReturn(long returnId)
        {
            if (dbContext != null)
            {
                var rtn = dbContext.Returns.FirstOrDefault(x => x.Id == returnId && x.DeletedAt == null);
                var rtnDetails = dbContext.ReturnDetails.Where(x => x.ReturnId == returnId && x.DeletedAt == null).ToList();

                var CustomerName = "WALKING CUSTOMER";
                if (rtn.CustomerId > 0)
                {
                    CustomerName = customerRepository.GetByIdForUpdate(rtn.CustomerId).Name;
                }

                var BankName = "";
                if (rtn.BankId > 0)
                {
                    BankName = bankRepository.GetByIdBank(rtn.BankId).BankName;
                }

                ReturnModelViewModel model = new ReturnModelViewModel
                {
                    Id = rtn.Id,
                    PurchaseId = 0,
                    SaleId = rtn.SaleId,
                    InvoiceNo = rtn.InvoiceNo,
                    ReturnType = rtn.ReturnType,
                    ReturnDate = rtn.ReturnDate,
                    CustomerId = rtn.CustomerId,
                    CustomerName = CustomerName,
                    SupplierId = 0,
                    SupplierName = "",
                    PaymentType = rtn.PaymentType,
                    BankId = rtn.BankId,
                    BankName = BankName,
                    SubTotal = rtn.SubTotal,
                    RentAmount = rtn.RentAmount,
                    TaxAmount = rtn.TaxAmount,
                    DiscountAmount = rtn.DiscountAmount,
                    TotalAmount = rtn.TotalAmount,
                    PaidAmount = rtn.PaidAmount,
                    DueAmount = rtn.DueAmount,
                    Description = rtn.Description,
                    CreatedAt = rtn.CreatedAt,
                    UpdatedAt = rtn.UpdatedAt,
                    DeletedAt = rtn.DeletedAt,
                    UserId = rtn.UserId,
                    UserName = pmsHelper.GetUserName(rtn.UserId)
                };

                List<ReturnDetailsViewModel> models = new List<ReturnDetailsViewModel>();
                foreach (var d in rtnDetails)
                {
                    ReturnDetailsViewModel m = new ReturnDetailsViewModel
                    {
                        ReturnId = returnId,
                        ProductId = d.ProductId,
                        Product = dbContext.Products.FirstOrDefault(x => x.Id == d.ProductId),
                        UnitId = d.UnitId,
                        Unit = dbContext.Units.FirstOrDefault(x => x.Id == d.UnitId),
                        Qty = d.Qty,
                        UnitPrice = d.UnitPrice,
                        Discount = d.Discount,
                        TotalPrice = d.TotalReturnPrice,
                        DetailsId = d.DetailsId
                    };
                    models.Add(m);
                }

                ReturnViewModel returnModel = new ReturnViewModel
                {
                    Return = model,
                    ReturnDetails = models
                };

                return returnModel;
            }

            return null;
        }

        public IEnumerable<Return> GetAllWastages()
        {
            if (dbContext != null)
            {
                var wastages = dbContext.Returns.Where(x => x.ReturnType == 2 && x.DeletedAt == null).ToList();
                return wastages;
            }
            return null;
        }

        private ReturnModelViewModel MapReturnViewModel(Return rtn)
        {
            var cName = "";
            var sName = "";
            var bName = "";
            if (rtn.CustomerId != -1 && rtn.CustomerId != 0)
            {
                cName = dbContext.Customers.FirstOrDefault(x => x.Id == rtn.CustomerId).Name;
            }
            else if (rtn.CustomerId == 0)
            {
                cName = "WALKING CUSTOMER";
            }

            if (rtn.SupplierId != 0)
            {
                sName = dbContext.Suppliers.FirstOrDefault(x => x.Id == rtn.SupplierId).Name;
            }

            //if (rtn.BankId != 0)
            //{
            //    bName = dbContext.Banks.FirstOrDefault(x => x.Id == rtn.BankId).BankName;
            //}

            ReturnModelViewModel model = new ReturnModelViewModel
            {
                Id = rtn.Id,
                PurchaseId = rtn.PurchaseId,
                SaleId = rtn.SaleId,
                InvoiceNo = rtn.InvoiceNo,
                ReturnType = rtn.ReturnType,
                ReturnDate = rtn.ReturnDate,
                CustomerId = rtn.CustomerId,
                CustomerName = cName,
                SupplierId = rtn.SupplierId,
                SupplierName = sName,
                //PaymentType = rtn.PaymentType,
                //BankId = rtn.BankId,
                BankName = bName,
                TotalAmount = rtn.TotalAmount,
                PaidAmount = rtn.PaidAmount,
                DueAmount = rtn.DueAmount,
                Description = rtn.Description,
                UserId = rtn.UserId,
                UserName = pmsHelper.GetUserName(rtn.UserId),
                CreatedAt = rtn.CreatedAt,
                UpdatedAt = rtn.UpdatedAt,
                DeletedAt = rtn.DeletedAt
            };

            return model;
        }

        public bool AddPurchaseReturn(Return rtn, IEnumerable<ReturnDetails> returnDetails)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var transCode = helperRepository.GetTransactionCode();
                var returnId = AddReturn(rtn, transCode);

                if (returnId != 0)
                {
                    var purchaseReturnDetails = AddReturnDetails(returnId, returnDetails);
                    if (purchaseReturnDetails)
                    {
                        //Add to Stock
                        var stockDetails = AddStockDetails(rtn.SupplierId, returnDetails, transCode, returnId, rtn.PurchaseId);
                        if (stockDetails)
                        {
                            // Add supplier Ledger
                            // Add Cash or Bank Ledger
                            var sl = AddSupplierLedgerDetails(transCode, rtn, returnId);
                            if (sl == 0)
                            {
                                return false;
                            }

                            var cl = AddSupplierCashLedgerDetails(transCode, rtn, returnId);
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
                //}
                //catch (Exception)
                //{
                //    return false;
                //}
            }
            return false;
        }

        private long AddReturn(Return rtn, string transCode)
        {
            if (dbContext != null)
            {
                rtn.TransCode = transCode;

                rtn.CreatedAt = DateTime.Now;
                rtn.UpdatedAt = DateTime.Now;
                rtn.UserId = helperRepository.GetCurrentUserId();
                rtn.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Returns.Add(rtn);
                dbContext.SaveChanges();

                var maxId = dbContext.Returns.Max(x => x.Id);
                return maxId;
            }

            return 0;
        }

        private bool AddReturnDetails(long returnId, IEnumerable<ReturnDetails> details)
        {
            if (dbContext != null)
            {
                foreach (var d in details)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.ReturnId = returnId;
                }
                dbContext.ReturnDetails.AddRange(details);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        private bool AddStockDetails(long supplierId, IEnumerable<ReturnDetails> returnDetails, string transCode, long returnId, long purchaseId)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in returnDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = 0,
                        OutQty = QtyUnits,
                        StockQty = 0 - QtyUnits,
                        //TotalStockPurchasePrice
                        //TotalSalePrice
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list.Add(model);

                    //Add Stock Details
                    if (!StockDetails(supplierId, p, transCode, returnId, purchaseId))
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

        private bool StockDetails(long supplierId, ReturnDetails p, string tcode, long returnId, long purchaseId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = supplierId,
                    CustomerId = -1,
                    InQty = 0,
                    OutQty = QtyUnits,
                    PurchasePrice = p.UnitPrice,
                    SalePrice = 0,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Purchase_Return(p.ProductId, supplierId, purchaseId),

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


        private int AddSupplierLedgerDetails(string trc, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                SupplierLedger supplierLedger_total = new SupplierLedger
                {
                    EntityId = sale.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierReturnMsg(saleId, sale.TotalAmount),
                    Debit = sale.TotalAmount,
                    Credit = 0,
                    Balance = sale.TotalAmount - 0,
                    TransCode = trc,
                };

                SupplierLedger supplierLedger_paid = new SupplierLedger
                {
                    EntityId = sale.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
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
                    Description = helperRepository.SupplierReturnMsg(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr1 = transactionRepository.AddTransactionLog(transaction1);
                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr1 == true && tr2 == true)
                {
                    var res1 = transactionRepository.AddSupplierLedger(supplierLedger_total);
                    var res2 = transactionRepository.AddSupplierLedger(supplierLedger_paid);
                    if (res1 != null && res2 != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private int AddSupplierCashLedgerDetails(string transCode, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
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
                            Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
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
                            EntityId = sale.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
                            VoucherNo = saleId.ToString(),
                            Debit = sale.PaidAmount,
                            Credit = 0,
                            Balance = sale.PaidAmount - 0,
                            TransCode = transCode,
                            TransType = CashType.Return,
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


        //Delete Purchase Return
        public bool DeletePurchaseReturn(long returnId, long purchaseId)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();

                var transCode = helperRepository.GetTransactionCode();

                //Delete Return
                var deletedReturn = dbContext.Returns.FirstOrDefault(x => x.Id == returnId && x.DeletedAt == null);
                if (deletedReturn != null)
                {
                    deletedReturn.DeletedAt = DateTime.Now;
                    dbContext.Returns.Update(deletedReturn);
                    dbContext.SaveChanges();

                    //Delete Return Details
                    var deletedReturnDetails = dbContext.ReturnDetails.Where(x => x.ReturnId == returnId && x.DeletedAt == null).ToList();
                    if (deletedReturnDetails.Any())
                    {
                        foreach (var d in deletedReturnDetails)
                        {
                            d.DeletedAt = DateTime.Now;
                        }
                        dbContext.UpdateRange(deletedReturnDetails);
                        dbContext.SaveChanges();

                        var deletedStockDetails = DeletePurchaseReturn_StockDetails(deletedReturn.SupplierId, deletedReturnDetails, transCode, returnId, purchaseId);
                        if (deletedStockDetails)
                        {
                            // Delete supplier Ledger
                            // Delete Cash or Bank Ledger
                            var sl = DeletePurchaseReturn_SupplierLedgerDetails(transCode, deletedReturn, returnId);
                            if (sl == 0)
                            {
                                return false;
                            }

                            var cl = DeletePurchaseReturn_SupplierCashLedgerDetails(transCode, deletedReturn, returnId);
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
        private bool DeletePurchaseReturn_StockDetails(long supplierId, IEnumerable<ReturnDetails> returnDetails, string transCode, long returnId, long purchaseId)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in returnDetails)
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

                    if (!DeletePurchaseReturn_StockDetails(supplierId, p, transCode, returnId, purchaseId))
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

        private bool DeletePurchaseReturn_StockDetails(long supplierId, ReturnDetails p, string tcode, long returnId, long purchaseId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = supplierId,
                    InQty = QtyUnits,
                    OutQty = 0,
                    PurchasePrice = p.UnitPrice,
                    SalePrice = 0,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Purchase_Return_Delete(p.ProductId, supplierId, purchaseId),
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

        private int DeletePurchaseReturn_SupplierLedgerDetails(string trc, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                SupplierLedger supplierLedger_total = new SupplierLedger
                {
                    EntityId = sale.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierReturnMsg_Delete(saleId, sale.TotalAmount),
                    Debit = 0,
                    Credit = sale.TotalAmount,
                    Balance = 0 - sale.TotalAmount,
                    TransCode = trc,
                };

                SupplierLedger supplierLedger_paid = new SupplierLedger
                {
                    EntityId = sale.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierReturnPaidMsg_Delete(saleId, sale.PaidAmount),
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
                    Description = helperRepository.SupplierReturnMsg_Delete(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.SupplierReturnPaidMsg_Delete(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr1 = transactionRepository.AddTransactionLog(transaction1);
                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr1 == true && tr2 == true)
                {
                    var res1 = transactionRepository.AddSupplierLedger(supplierLedger_total);
                    var res2 = transactionRepository.AddSupplierLedger(supplierLedger_paid);
                    if (res1 != null && res2 != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private int DeletePurchaseReturn_SupplierCashLedgerDetails(string transCode, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierReturnPaidMsg_Delete(saleId, sale.PaidAmount),
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
                            Description = helperRepository.SupplierReturnPaidMsg_Delete(saleId, sale.PaidAmount),
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
                            EntityId = sale.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierReturnPaidMsg_Delete(saleId, sale.PaidAmount),
                            VoucherNo = saleId.ToString(),
                            Debit = 0,
                            Credit = sale.PaidAmount,
                            Balance = 0 - sale.PaidAmount,
                            TransCode = transCode,
                            TransType = CashType.Return,
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


        public Return GetReturnById(long returnId)
        {
            if (dbContext != null)
            {
                var rtn = dbContext.Returns.FirstOrDefault(x => x.Id == returnId && x.DeletedAt == null);
                return rtn;
            }
            return null;
        }
        public IEnumerable<ReturnDetails> GetReturnDetailsByReturnId(long returnId)
        {
            if (dbContext != null)
            {
                var rtn = dbContext.Returns.FirstOrDefault(x => x.Id == returnId && x.DeletedAt == null);
                var purchaseDetails = dbContext.PurchaseDetails.Where(x => x.PurchaseId == rtn.PurchaseId && x.DeletedAt == null).ToList();
                //var returnDetails = dbContext.ReturnDetails.Where(x => x.ReturnId == returnId && x.DeletedAt == null).ToList();
                List<ReturnDetails> list = new List<ReturnDetails>();
                foreach (var d in purchaseDetails)
                {
                    var rd = dbContext.ReturnDetails.FirstOrDefault(x => x.ReturnId == returnId && x.DetailsId == d.Id && x.DeletedAt == null);
                    if (rd != null)
                    {
                        ReturnDetails model = new ReturnDetails
                        {
                            Id = rd.Id,
                            ReturnId = rd.ReturnId,
                            ProductId = rd.ProductId,
                            Product = dbContext.Products.FirstOrDefault(x => x.Id == rd.ProductId),
                            UnitId = rd.UnitId,
                            Unit = dbContext.Units.FirstOrDefault(x => x.Id == rd.UnitId),
                            UnitPrice = rd.UnitPrice,
                            Qty = rd.Qty,
                            Discount = rd.Discount,
                            TotalReturnPrice = rd.TotalReturnPrice,
                            DetailsId = rd.DetailsId
                        };
                        list.Add(model);
                    }
                    else
                    {
                        ReturnDetails model = new ReturnDetails
                        {
                            Id = rd.Id,
                            ReturnId = rd.ReturnId,
                            ProductId = rd.ProductId,
                            Product = dbContext.Products.FirstOrDefault(x => x.Id == rd.ProductId),
                            UnitId = rd.UnitId,
                            Unit = dbContext.Units.FirstOrDefault(x => x.Id == rd.UnitId),
                            UnitPrice = rd.UnitPrice,
                            Qty = 0,
                            Discount = 0,
                            TotalReturnPrice = 0
                        };
                        list.Add(model);
                    }
                }
                return list;
            }
            return null;
        }

        public IEnumerable<ReturnDetails> GetSaleReturnDetailsByReturnId(long returnId)
        {
            if (dbContext != null)
            {
                var rtn = dbContext.Returns.FirstOrDefault(x => x.Id == returnId && x.DeletedAt == null);
                //var purchaseDetails = dbContext.PurchaseDetails.Where(x => x.PurchaseId == rtn.PurchaseId && x.DeletedAt == null).ToList();
                var returnDetails = dbContext.ReturnDetails.Where(x => x.ReturnId == returnId && x.DeletedAt == null).ToList();
                List<ReturnDetails> list = new List<ReturnDetails>();
                foreach (var d in returnDetails)
                {
                    var rd = dbContext.ReturnDetails.FirstOrDefault(x => x.ReturnId == returnId && x.DetailsId == d.DetailsId && x.DeletedAt == null);
                    if (rd != null)
                    {
                        ReturnDetails model = new ReturnDetails
                        {
                            Id = rd.Id,
                            ReturnId = rd.ReturnId,
                            ProductId = rd.ProductId,
                            Product = dbContext.Products.FirstOrDefault(x => x.Id == rd.ProductId),
                            UnitId = rd.UnitId,
                            Unit = dbContext.Units.FirstOrDefault(x => x.Id == rd.UnitId),
                            UnitPrice = rd.UnitPrice,
                            Qty = rd.Qty,
                            Discount = rd.Discount,
                            TotalReturnPrice = rd.TotalReturnPrice,
                            DetailsId = rd.DetailsId
                        };
                        list.Add(model);
                    }
                    else
                    {
                        ReturnDetails model = new ReturnDetails
                        {
                            Id = rd.Id,
                            ReturnId = rd.ReturnId,
                            ProductId = rd.ProductId,
                            Product = dbContext.Products.FirstOrDefault(x => x.Id == rd.ProductId),
                            UnitId = rd.UnitId,
                            Unit = dbContext.Units.FirstOrDefault(x => x.Id == rd.UnitId),
                            UnitPrice = rd.UnitPrice,
                            Qty = 0,
                            Discount = 0,
                            TotalReturnPrice = 0
                        };
                        list.Add(model);
                    }
                }
                return list;
            }
            return null;
        }

        public bool UpdatePurchaseReturn(Return rtn, IEnumerable<ReturnDetails> returnDetails)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var transCode = rtn.TransCode;

                rtn.UpdatedAt = DateTime.Now;
                rtn.UserId = helperRepository.GetCurrentUserId();
                rtn.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Returns.Update(rtn);
                dbContext.SaveChanges();

                //Delete Return Details 
                var oldReturnDetails = dbContext.ReturnDetails.Where(x => x.ReturnId == rtn.Id).ToList();
                dbContext.ReturnDetails.RemoveRange(oldReturnDetails);
                dbContext.SaveChanges();

                //add new Return Details 
                foreach (var d in returnDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.ReturnId = rtn.Id;
                }
                dbContext.ReturnDetails.AddRange(returnDetails);
                dbContext.SaveChanges();

                //Update Total Stock
                var updateTotalStock = UpdatePurchaseReturn_TotalStock(returnDetails, oldReturnDetails);

                if (updateTotalStock > 0)
                {
                    //Update Stock Details 
                    var udpatedStockDetails = UpdatePurchaseReturn_StockDetails(rtn, returnDetails, oldReturnDetails);
                    if (udpatedStockDetails == 0)
                    {
                        return false;
                    }

                    //Update Ledgers 
                    var sl = UpdateSupplierLedgerDetails(transCode, rtn, rtn.Id);
                    if (sl == 0)
                    {
                        return false;
                    }

                    var cl = UpdateSupplierCashLedgerDetails(transCode, rtn, rtn.Id);
                    if (cl == 0)
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
                //}
                //catch (Exception)
                //{
                //    return false;
                //}
            }
            return false;
        }

        private long UpdatePurchaseReturn_TotalStock(IEnumerable<ReturnDetails> returnDetails, IEnumerable<ReturnDetails> oldReturnDetails)
        {
            if (dbContext != null)
            {

                List<Stock> list2 = new List<Stock>();
                foreach (var p in oldReturnDetails)
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

                    list2.Add(model);
                }

                dbContext.Stocks.AddRange(list2);
                dbContext.SaveChanges();


                List<Stock> list = new List<Stock>();
                foreach (var p in returnDetails)
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
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();

                return 1;

            }
            return 0;
        }

        private long UpdatePurchaseReturn_StockDetails(Return rtn, IEnumerable<ReturnDetails> returnDetails, IEnumerable<ReturnDetails> oldReturnDetails)
        {
            if (dbContext != null)
            {
                List<StockDetails> list = new List<StockDetails>();
                foreach (var p in oldReturnDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    StockDetails model = new StockDetails
                    {
                        ProductId = p.ProductId,
                        SupplierId = rtn.SupplierId,
                        CustomerId = -1,
                        InQty = QtyUnits,
                        OutQty = 0,
                        PurchasePrice = p.UnitPrice,
                        SalePrice = 0,
                        TransCode = rtn.TransCode,
                        Description = helperRepository.StockDetailsMsg_Purchase_Return(p.ProductId, rtn.SupplierId, rtn.PurchaseId),

                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };
                    list.Add(model);
                }

                dbContext.StockDetails.AddRange(list);
                dbContext.SaveChanges();

                List<StockDetails> list2 = new List<StockDetails>();
                foreach (var p in returnDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    StockDetails model = new StockDetails
                    {
                        ProductId = p.ProductId,
                        SupplierId = rtn.SupplierId,
                        CustomerId = -1,
                        InQty = 0,
                        OutQty = QtyUnits,
                        PurchasePrice = p.UnitPrice,
                        SalePrice = 0,
                        TransCode = rtn.TransCode,
                        Description = helperRepository.StockDetailsMsg_Purchase_Return_Delete(p.ProductId, rtn.SupplierId, rtn.PurchaseId),

                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };
                    list2.Add(model);
                }

                dbContext.StockDetails.AddRange(list2);
                dbContext.SaveChanges();

                return 1;

            }
            return 0;
        }

        private int UpdateSupplierLedgerDetails(string trc, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                var old_supplierLedger_total = dbContext.SupplierLedgers.FirstOrDefault(x => x.TransCode == trc);
                transactionRepository.DeleteSupplierLedger(old_supplierLedger_total); //Delete add records, total and paid ...



                SupplierLedger supplierLedger_total = new SupplierLedger
                {
                    EntityId = sale.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierReturnMsg(saleId, sale.TotalAmount),
                    Debit = sale.TotalAmount,
                    Credit = 0,
                    Balance = sale.TotalAmount - 0,
                    TransCode = trc,
                };

                SupplierLedger supplierLedger_paid = new SupplierLedger
                {
                    EntityId = sale.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
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
                    Description = helperRepository.SupplierReturnMsg(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
                    Amount = sale.PaidAmount,
                    Operation = Operation.Create
                };

                var tr1 = transactionRepository.AddTransactionLog(transaction1);
                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr1 == true && tr2 == true)
                {
                    var res1 = transactionRepository.AddSupplierLedger(supplierLedger_total);
                    var res2 = transactionRepository.AddSupplierLedger(supplierLedger_paid);
                    if (res1 != null && res2 != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private int UpdateSupplierCashLedgerDetails(string transCode, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
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
                            Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
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
                            EntityId = sale.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierReturnPaidMsg(saleId, sale.PaidAmount),
                            VoucherNo = saleId.ToString(),
                            Debit = sale.PaidAmount,
                            Credit = 0,
                            Balance = sale.PaidAmount - 0,
                            TransCode = transCode,
                            TransType = CashType.Return,
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


        public bool AddSaleReturn(Return rtn, IEnumerable<ReturnDetails> returnDetails)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var transCode = helperRepository.GetTransactionCode();
                var returnId = AddReturn(rtn, transCode);

                if (returnId != 0)
                {
                    var saleReturnDetails = AddReturnDetails(returnId, returnDetails);
                    if (saleReturnDetails)
                    {
                        //Add to Stock
                        var stockDetails = AddSaleReturnStockDetails(rtn.CustomerId, returnDetails, transCode, returnId, rtn.SaleId);
                        if (stockDetails)
                        {
                            // Add supplier Ledger
                            // Add Cash or Bank Ledger
                            var sl = AddReturnSaleCustomerLedgerDetails(transCode, rtn, returnId);
                            if (sl == 0)
                            {
                                return false;
                            }

                            var cl = AddReturnSaleCustomerCashLedgerDetails(transCode, rtn, returnId);
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
                //}
                //catch (Exception)
                //{
                //    return false;
                //}
            }
            return false;
        }

        private bool AddSaleReturnStockDetails(long customerId, IEnumerable<ReturnDetails> returnDetails, string transCode, long returnId, long saleId)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in returnDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = QtyUnits,
                        OutQty = 0,
                        StockQty = QtyUnits - 0,
                        //TotalStockPurchasePrice
                        //TotalSalePrice
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list.Add(model);

                    //Add Stock Details
                    if (!SaleReturnStockDetails(customerId, p, transCode, returnId, saleId))
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

        private bool SaleReturnStockDetails(long customerId, ReturnDetails p, string tcode, long returnId, long saleId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = 0,
                    CustomerId = customerId,
                    InQty = QtyUnits,
                    OutQty = 0,
                    PurchasePrice = 0,
                    SalePrice = p.UnitPrice,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Sale_Return(p.ProductId, customerId, saleId),

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

        private int AddReturnSaleCustomerLedgerDetails(string trc, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                CustomerLedger customerLedger_total = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerReturnMsg(saleId, sale.TotalAmount),
                    Debit = 0,
                    Credit = sale.TotalAmount,
                    Balance = 0 - sale.TotalAmount,
                    TransCode = trc,
                };

                CustomerLedger customerLedger_paid = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
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
                    Description = helperRepository.CustomerReturnMsg(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
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

        private int AddReturnSaleCustomerCashLedgerDetails(string transCode, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
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
                            Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
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
                            Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
                            VoucherNo = saleId.ToString(),
                            Debit = 0,
                            Credit = sale.PaidAmount,
                            Balance = 0 - sale.PaidAmount,
                            TransCode = transCode,
                            TransType = CashType.Return,
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

        public bool UpdateSaleReturn(Return rtn, IEnumerable<ReturnDetails> returnDetails)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var transCode = rtn.TransCode;

                rtn.UpdatedAt = DateTime.Now;
                rtn.UserId = helperRepository.GetCurrentUserId();
                rtn.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Returns.Update(rtn);
                dbContext.SaveChanges();

                //Delete Return Details 
                var oldReturnDetails = dbContext.ReturnDetails.Where(x => x.ReturnId == rtn.Id).ToList();
                dbContext.ReturnDetails.RemoveRange(oldReturnDetails);
                dbContext.SaveChanges();

                //add new Return Details 
                foreach (var d in returnDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.ReturnId = rtn.Id;
                }
                dbContext.ReturnDetails.AddRange(returnDetails);
                dbContext.SaveChanges();

                //Update Total Stock
                var updateTotalStock = UpdateSaleReturn_TotalStock(returnDetails, oldReturnDetails);

                if (updateTotalStock > 0)
                {
                    //Update Stock Details 
                    var udpatedStockDetails = UpdateSaleReturn_StockDetails(rtn, returnDetails, oldReturnDetails);
                    if (udpatedStockDetails == 0)
                    {
                        return false;
                    }

                    //Update Ledgers 
                    var sl = UpdateCustomerLedgerDetails(transCode, rtn, rtn.Id);
                    if (sl == 0)
                    {
                        return false;
                    }

                    var cl = UpdateCustomerCashLedgerDetails(transCode, rtn, rtn.Id);
                    if (cl == 0)
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
                //}
                //catch (Exception)
                //{
                //    return false;
                //}
            }
            return false;
        }

        private long UpdateSaleReturn_TotalStock(IEnumerable<ReturnDetails> returnDetails, IEnumerable<ReturnDetails> oldReturnDetails)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in oldReturnDetails)
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
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();

                List<Stock> list2 = new List<Stock>();
                foreach (var p in returnDetails)
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

                    list2.Add(model);
                }

                dbContext.Stocks.AddRange(list2);
                dbContext.SaveChanges();

                return 1;
            }
            return 0;
        }

        private long UpdateSaleReturn_StockDetails(Return rtn, IEnumerable<ReturnDetails> returnDetails, IEnumerable<ReturnDetails> oldReturnDetails)
        {
            if (dbContext != null)
            {
                List<StockDetails> list = new List<StockDetails>();
                foreach (var p in oldReturnDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    StockDetails model = new StockDetails
                    {
                        ProductId = p.ProductId,
                        SupplierId = 0,
                        CustomerId = rtn.CustomerId,
                        InQty = 0,
                        OutQty = QtyUnits,
                        PurchasePrice = 0,
                        SalePrice = p.UnitPrice,
                        TransCode = rtn.TransCode,
                        Description = helperRepository.StockDetailsMsg_Sale_Return_Delete(p.ProductId, rtn.CustomerId, rtn.SaleId),

                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };
                    list.Add(model);
                }

                dbContext.StockDetails.AddRange(list);
                dbContext.SaveChanges();

                List<StockDetails> list2 = new List<StockDetails>();
                foreach (var p in returnDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    StockDetails model = new StockDetails
                    {
                        ProductId = p.ProductId,
                        SupplierId = 0,
                        CustomerId = rtn.CustomerId,
                        InQty = QtyUnits,
                        OutQty = 0,
                        PurchasePrice = 0,
                        SalePrice = p.UnitPrice,
                        TransCode = rtn.TransCode,
                        Description = helperRepository.StockDetailsMsg_Sale_Return(p.ProductId, rtn.CustomerId, rtn.SaleId),

                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };
                    list2.Add(model);
                }

                dbContext.StockDetails.AddRange(list2);
                dbContext.SaveChanges();

                return 1;
            }
            return 0;
        }

        private int UpdateCustomerLedgerDetails(string trc, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                var old_customerLedger_total = dbContext.CustomerLedgers.FirstOrDefault(x => x.TransCode == trc);
                transactionRepository.DeleteCustomerLedger(old_customerLedger_total); //Delete add records, total and paid ...



                CustomerLedger customerLedger_total = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerReturnMsg(saleId, sale.TotalAmount),
                    Debit = 0,
                    Credit = sale.TotalAmount,
                    Balance = 0 - sale.TotalAmount,
                    TransCode = trc,
                };

                CustomerLedger customerLedger_paid = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
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
                    Description = helperRepository.CustomerReturnMsg(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
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

        private int UpdateCustomerCashLedgerDetails(string transCode, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
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
                            Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
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
                        var old_cashledger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);
                        transactionRepository.DeleteCashLedger(old_cashledger);

                        CashLedger cashLedger_paid = new CashLedger
                        {
                            EntityId = sale.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerReturnPaidMsg(saleId, sale.PaidAmount),
                            VoucherNo = saleId.ToString(),
                            Debit = 0,
                            Credit = sale.PaidAmount,
                            Balance = 0 - sale.PaidAmount,
                            TransCode = transCode,
                            TransType = CashType.Return,
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


        public bool DeleteSaleReturn(long returnId, long saleId)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();

                var transCode = helperRepository.GetTransactionCode();

                //Delete Return
                var deletedReturn = dbContext.Returns.FirstOrDefault(x => x.Id == returnId && x.DeletedAt == null);
                if (deletedReturn != null)
                {
                    deletedReturn.DeletedAt = DateTime.Now;
                    dbContext.Returns.Update(deletedReturn);
                    dbContext.SaveChanges();

                    //Delete Return Details
                    var deletedReturnDetails = dbContext.ReturnDetails.Where(x => x.ReturnId == returnId && x.DeletedAt == null).ToList();
                    if (deletedReturnDetails.Any())
                    {
                        foreach (var d in deletedReturnDetails)
                        {
                            d.DeletedAt = DateTime.Now;
                        }
                        dbContext.UpdateRange(deletedReturnDetails);
                        dbContext.SaveChanges();

                        var deletedStockDetails = DeleteSaleReturn_StockDetails(deletedReturn.SupplierId, deletedReturnDetails, transCode, returnId, saleId);
                        if (deletedStockDetails)
                        {
                            // Delete Customer Ledger
                            // Delete Cash or Bank Ledger
                            var sl = DeleteSaleReturn_CustomerLedgerDetails(transCode, deletedReturn, returnId);
                            if (sl == 0)
                            {
                                return false;
                            }

                            var cl = DeleteSaleReturn_CustomerCashLedgerDetails(transCode, deletedReturn, returnId);
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

        private bool DeleteSaleReturn_StockDetails(long customerId, IEnumerable<ReturnDetails> returnDetails, string transCode, long returnId, long saleId)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in returnDetails)
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

                    if (!DeleteSaleReturn_StockDetails(customerId, p, transCode, returnId, saleId))
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

        private bool DeleteSaleReturn_StockDetails(long customerId, ReturnDetails p, string tcode, long returnId, long saleId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = 0,
                    CustomerId = customerId,
                    InQty = 0,
                    OutQty = QtyUnits,
                    PurchasePrice = 0,
                    SalePrice = p.UnitPrice,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Sale_Return_Delete(p.ProductId, customerId, saleId),

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

        private int DeleteSaleReturn_CustomerLedgerDetails(string trc, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                CustomerLedger customerLedger_total = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerReturnMsg_Delete(saleId, sale.TotalAmount),
                    Debit = sale.TotalAmount,
                    Credit = 0,
                    Balance = sale.TotalAmount - 0,
                    TransCode = trc,
                };

                CustomerLedger customerLedger_paid = new CustomerLedger
                {
                    EntityId = sale.CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerReturnPaidMsg_Delete(saleId, sale.PaidAmount),
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
                    Description = helperRepository.CustomerReturnMsg_Delete(saleId, sale.TotalAmount),
                    Amount = sale.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CustomerReturnPaidMsg_Delete(saleId, sale.PaidAmount),
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

        private int DeleteSaleReturn_CustomerCashLedgerDetails(string transCode, Return sale, long saleId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerReturnPaidMsg_Delete(saleId, sale.PaidAmount),
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
                            Description = helperRepository.CustomerReturnPaidMsg_Delete(saleId, sale.PaidAmount),
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
                            EntityId = sale.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            VoucherNo = saleId.ToString(),
                            Description = helperRepository.CustomerReturnPaidMsg_Delete(saleId, sale.PaidAmount),
                            Debit = sale.PaidAmount,
                            Credit = 0,
                            Balance = sale.PaidAmount - 0,
                            TransCode = transCode,
                            TransType = CashType.Return,
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

        public ProductBatch GetProductBatchDetails(string batchId)
        {
            if (dbContext != null)
            {
                var batch = dbContext.ProductBatches.FirstOrDefault(x => x.BatchId == batchId);
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
    }
}
