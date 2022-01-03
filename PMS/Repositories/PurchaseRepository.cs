using PMS.Data;
using PMS.Data.Enums;
using PMS.Models;
using PMS.Models.Finance;
using PMS.Models.Purchase;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels.PurchaseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly PMSHelper pmsHelper;
        private readonly ITransactionRepository transactionRepository;
        private readonly IStockRepository stockRepository;
        private readonly ISupplierRepository supplierRepository;
        private readonly IBankRepository bankRepository;
        private readonly IShopRepository shopRepository;


        public PurchaseRepository(ApplicationDbContext dbContext,
                                  IHelperRepository helperRepository,
                                  PMSHelper pmsHelper,
                                  ITransactionRepository transactionRepository,
                                  IStockRepository stockRepository,
                                  ISupplierRepository supplierRepository,
                                  IBankRepository bankRepository,
                                IShopRepository shopRepository)
        {
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
            this.pmsHelper = pmsHelper;
            this.transactionRepository = transactionRepository;
            this.stockRepository = stockRepository;
            this.supplierRepository = supplierRepository;
            this.bankRepository = bankRepository;
            this.shopRepository = shopRepository;
        }
        public IEnumerable<PurchaseViewModel> GetAllPurchases()
        {
            if (dbContext != null)
            {
                List<PurchaseViewModel> list = new List<PurchaseViewModel>();
                var models = dbContext.Purchases.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;

                foreach (var m in models)
                {
                    var ptname = "";
                    var bId = (long)0;
                    var bName = "";
                    var sName = "";
                    if (m.PurchaseType == Data.Enums.PurchaseType.General)
                    {
                        ptname = "General";
                    }
                    else
                    {
                        ptname = "Shared";
                    }

                    if (m.PaymentType != 1)
                    {
                        bId = m.BankId;
                        bName = dbContext.Banks.FirstOrDefault(x => x.Id == m.BankId).BankName;
                    }
                    Supplier supplier = new Supplier();

                    if (m.SupplierId != 0)
                    {
                        sName = dbContext.Suppliers.FirstOrDefault(x => x.Id == m.SupplierId).Name;
                        supplier = dbContext.Suppliers.FirstOrDefault(x => x.Id == m.SupplierId);
                    }
                    PurchaseViewModel model = new PurchaseViewModel
                    {
                        Id = m.Id,
                        SNo = sno,
                        PurchaseDate = m.PurchaseDate.Date.ToString(),
                        InvoiceNo = m.InvoiceNo,
                        SupplierId = m.SupplierId,
                        SupplierName = sName,
                        Supplier = supplier,
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
                        PurchaseTypeId = m.PurchaseType,
                        PurchaseType = ptname,
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

        public IEnumerable<PurchaseDetailsViewModel> GetAllPurchaseDetails(long id)
        {
            if (dbContext != null)
            {
                List<PurchaseDetailsViewModel> list = new List<PurchaseDetailsViewModel>();
                var details = dbContext.PurchaseDetails.Where(x => x.PurchaseId == id).ToList();
                var sno = 1;

                foreach (var d in details)
                {
                    PurchaseDetailsViewModel model = new PurchaseDetailsViewModel
                    {
                        ProductId = d.ProductId,
                        Product = dbContext.Products.FirstOrDefault(x => x.Id == d.ProductId),
                        UnitId = d.UnitId,
                        Unit = dbContext.Units.FirstOrDefault(x => x.Id == d.UnitId),
                        Qty = d.Qty,
                        PurchasePrice = d.PurchasePrice,
                        TotalPurchasePrice = d.TotalPurchasePrice,
                        Sno = sno
                    };

                    sno++;

                    list.Add(model);
                }

                return list;
            }
            return null;
        }

        public ViewPurchaseDetailsViewModel GetPurchase(long id)
        {
            if (dbContext != null)
            {
                var puchase = GetAllPurchases().FirstOrDefault(x => x.Id == id);
                var details = GetAllPurchaseDetails(id);
                var ShopDetails = shopRepository.GetShop();

                ViewPurchaseDetailsViewModel model = new ViewPurchaseDetailsViewModel
                {
                    purchase = puchase,
                    purchaseDetails = details,
                    ShopModelDetails = ShopDetails
                };

                return model;
            }

            return null;
        }

        public CreatePurchaseViewModel GetPurchaseForEdit(long id)
        {
            if (dbContext != null)
            {
                var purchase = dbContext.Purchases.FirstOrDefault(x => x.Id == id);
                if (purchase == null)
                {
                    return null;
                }

                var details = dbContext.PurchaseDetails.Where(x => x.PurchaseId == id).ToList();

                CreatePurchaseViewModel model = new CreatePurchaseViewModel
                {
                    Purchase = purchase,
                    PurchaseDetails = details
                };

                return model;
            }
            return null;
        }

        public long AddPurchase(CreatePurchaseViewModel purchaseViewModel)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                //Save Purchase Details 
                var transCode = helperRepository.GetTransactionCode();
                purchaseViewModel.Purchase.TransCode = transCode;

                var purchaseId = AddPurchase(purchaseViewModel.Purchase);

                if (purchaseId != 0)
                {
                    //Save Purchase Details 
                    var purchaseDetails = AddPurchaseDetails(purchaseId, purchaseViewModel.PurchaseDetails);

                    if (purchaseDetails != 0)
                    {
                        //Add to Stock
                        var stockDetails = AddStockDetails(purchaseViewModel.Purchase.SupplierId, purchaseViewModel.PurchaseDetails, transCode, purchaseViewModel.Purchase.InvoiceNo);

                        if (stockDetails)
                        {
                            // Add Supplier Ledger
                            // Add Cash or Bank Ledger
                            var sl = AddSupplierLedgerDetails(transCode, purchaseViewModel.Purchase);
                            if (sl == 0)
                            {
                                return 0;
                            }

                            var cl = AddSupplierCashLedgerDetails(transCode, purchaseViewModel.Purchase);
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

                return purchaseId;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }
            return 0;
        }

        private long AddPurchase(Purchase purchase)
        {
            if (dbContext != null)
            {
                purchase.CreatedAt = DateTime.Now;
                purchase.UpdatedAt = DateTime.Now;
                purchase.UserId = helperRepository.GetCurrentUserId();
                purchase.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Purchases.Add(purchase);
                dbContext.SaveChanges();

                var maxId = dbContext.Purchases.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        private long AddPurchaseDetails(long purchaseId, IEnumerable<PurchaseDetails> purchaseDetails)
        {
            if (dbContext != null)
            {
                foreach (var d in purchaseDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.PurchaseId = purchaseId;
                }

                dbContext.PurchaseDetails.AddRange(purchaseDetails);
                dbContext.SaveChanges();

                return 1;
            }
            return 0;
        }
        private bool AddStockDetails(long supplierId, IEnumerable<PurchaseDetails> purchaseDetails, string transCode, string invoiceNo)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in purchaseDetails)
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

                    //Add Stock Details
                    if (!StockDetails(supplierId, p, transCode, invoiceNo))
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

        private bool StockDetails(long supplierId, PurchaseDetails p, string tcode, string invoiceNo)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    CustomerId = -1,
                    SupplierId = supplierId,
                    InQty = QtyUnits,
                    OutQty = 0,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg(p.ProductId, supplierId, invoiceNo),

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

        private int AddSupplierLedgerDetails(string trc, Purchase purchase)
        {
            if (dbContext != null)
            {
                SupplierLedger supplierLedger_total = new SupplierLedger
                {
                    EntityId = purchase.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierPurchaseMsg(purchase.InvoiceNo, purchase.TotalAmount),
                    Debit = 0,
                    Credit = purchase.TotalAmount,
                    Balance = 0 - purchase.TotalAmount,
                    TransCode = trc,
                };

                SupplierLedger supplierLedger_paid = new SupplierLedger
                {
                    EntityId = purchase.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                    Debit = purchase.PaidAmount,
                    Credit = 0,
                    Balance = purchase.PaidAmount - 0,
                    TransCode = trc,
                };


                Transaction transaction1 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierPurchaseMsg(purchase.InvoiceNo, purchase.TotalAmount),
                    Amount = purchase.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                    Amount = purchase.PaidAmount,
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

        private int AddSupplierCashLedgerDetails(string transCode, Purchase purchase)
        {
            if (dbContext != null)
            {

                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                    Amount = purchase.PaidAmount,
                    Operation = Operation.Create
                };

                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr2 == true)
                {

                    //Cash Ledger
                    if (purchase.BankId != 0)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = purchase.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                            Debit = 0,
                            Credit = purchase.PaidAmount,
                            Balance = 0 - purchase.PaidAmount,
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
                            EntityId = purchase.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                            VoucherNo = purchase.InvoiceNo,
                            Debit = 0,
                            Credit = purchase.PaidAmount,
                            Balance = 0 - purchase.PaidAmount,
                            TransCode = transCode,
                            TransType = CashType.Purchase,
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


        public PurchaseDetails GetPurchaseDetailsById(long id)
        {
            if (dbContext != null)
            {
                var details = dbContext.PurchaseDetails.FirstOrDefault(x => x.Id == id);
                if (details != null)
                {
                    return details;
                }
                return null;
            }

            return null;
        }

        public string GetProductBatchByPurchaseId_ProductId(long purchaseId, long productId)
        {
            if (dbContext != null)
            {
                var batchId = dbContext.ProductBatches.FirstOrDefault(x => x.DeletedAt == null && x.ProductId == productId && x.PurchaseId == purchaseId).BatchId;
                return batchId;
            }
            return null;
        }

        public decimal GetUnitPrice(long unitId, long productId)
        {
            if (dbContext != null)
            {
                var prc = dbContext.ProductUnits.FirstOrDefault(x => x.UnitId == unitId && x.ProductId == productId).UnitSellPrice;
                return prc;
            }

            return 0;
        }

        public decimal GetLastPurchasedUnitPrice(long unitId, long productId)
        {
            if (dbContext != null)
            {
                var lastPurchase = dbContext.PurchaseDetails.Where(x => x.ProductId == productId).OrderByDescending(x => x.UpdatedAt).FirstOrDefault();

                var unitprice = lastPurchase.PurchasePrice;

                var unit = lastPurchase.UnitId;

                var res = (decimal)(dbContext.Units.FirstOrDefault(x => x.Id == unitId).KgAmount) * unitprice / (decimal)(dbContext.Units.FirstOrDefault(x => x.Id == lastPurchase.UnitId).KgAmount);
                return res;
            }

            return 0;
        }


        public bool DeletePurchase(long purchaseId)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();

                var transCode = helperRepository.GetTransactionCode();

                //Delete Purchase
                var deletedPurchase = dbContext.Purchases.FirstOrDefault(x => x.Id == purchaseId && x.DeletedAt == null);
                if (deletedPurchase != null)
                {
                    deletedPurchase.DeletedAt = DateTime.Now;
                    dbContext.Purchases.Update(deletedPurchase);
                    dbContext.SaveChanges();

                    //Delete Purchase Details
                    var deletedPurchaseDetails = dbContext.PurchaseDetails.Where(x => x.PurchaseId == purchaseId && x.DeletedAt == null).ToList();
                    if (deletedPurchaseDetails.Any())
                    {
                        foreach (var d in deletedPurchaseDetails)
                        {
                            d.DeletedAt = DateTime.Now;
                        }
                        dbContext.UpdateRange(deletedPurchaseDetails);
                        dbContext.SaveChanges();

                        //Update Stock and Stock Details
                        var deletedStockDetails = DeletePurchase_Stock(deletedPurchase.SupplierId, deletedPurchaseDetails, transCode, purchaseId);
                        if (deletedStockDetails)
                        {
                            //Update Supplier and Cash/Bank Ledgers
                            var sl = DeletePurchase_SupplierLedgerDetails(transCode, deletedPurchase, purchaseId);
                            if (sl == 0)
                            {
                                return false;
                            }

                            var cl = DeletePurchase_SupplierCashLedgerDetails(transCode, deletedPurchase, purchaseId);
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

        private bool DeletePurchase_Stock(long supplierId, IEnumerable<PurchaseDetails> purchaseDetails, string transCode, long purchaseId)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in purchaseDetails)
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

                    if (!DeletePurchase_StockDetails(supplierId, p, transCode, purchaseId))
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

        private bool DeletePurchase_StockDetails(long supplierId, PurchaseDetails p, string tcode, long purchaseId)
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
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_Purchase_Delete(p.ProductId, supplierId, purchaseId),

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

        private int DeletePurchase_SupplierLedgerDetails(string trc, Purchase purchase, long purchaseId)
        {
            if (dbContext != null)
            {
                SupplierLedger supplierLedger_total = new SupplierLedger
                {
                    EntityId = purchase.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierPurchaseTotalMsg_Delete(purchaseId, purchase.TotalAmount),
                    Debit = purchase.TotalAmount,
                    Credit = 0,
                    Balance = purchase.TotalAmount - 0,
                    TransCode = trc,
                };

                SupplierLedger supplierLedger_paid = new SupplierLedger
                {
                    EntityId = purchase.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierPurchasePaidMsg_Delete(purchaseId, purchase.PaidAmount),
                    Debit = 0,
                    Credit = purchase.PaidAmount,
                    Balance = 0 - purchase.PaidAmount,
                    TransCode = trc,
                };


                Transaction transaction1 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.SupplierPurchaseTotalMsg_Delete(purchaseId, purchase.TotalAmount),
                    Amount = purchase.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierPurchasePaidMsg_Delete(purchaseId, purchase.PaidAmount),
                    Amount = purchase.PaidAmount,
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

        private int DeletePurchase_SupplierCashLedgerDetails(string transCode, Purchase purchase, long purchaseId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CashBankPurchasePaidMsg_Delete(purchaseId, purchase.PaidAmount),
                    Amount = purchase.PaidAmount,
                    Operation = Operation.Create
                };

                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr2 == true)
                {
                    //Cash Ledger
                    if (purchase.BankId != 0)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = purchase.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.CashBankPurchasePaidMsg_Delete(purchaseId, purchase.PaidAmount),
                            Debit = purchase.PaidAmount,
                            Credit = 0,
                            Balance = purchase.PaidAmount - 0,
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
                            EntityId = purchase.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            VoucherNo = purchaseId.ToString(),
                            Description = helperRepository.CashBankPurchasePaidMsg_Delete(purchaseId, purchase.PaidAmount),
                            Debit = purchase.PaidAmount,
                            Credit = 0,
                            Balance = purchase.PaidAmount - 0,
                            TransCode = transCode,
                            TransType = CashType.Purchase,
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

        public CreatePurchaseViewModel UpdatePurchase(CreatePurchaseViewModel purchaseViewModel)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                //Upate Purchase 
                var transCode = purchaseViewModel.Purchase.TransCode;

                purchaseViewModel.Purchase.UpdatedAt = DateTime.Now;
                purchaseViewModel.Purchase.UserId = helperRepository.GetCurrentUserId();
                purchaseViewModel.Purchase.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                var updatedPurchase = dbContext.Purchases.FirstOrDefault(x => x.Id == purchaseViewModel.Purchase.Id);
                updatedPurchase.InvoiceNo = purchaseViewModel.Purchase.InvoiceNo;
                updatedPurchase.PaidAmount = purchaseViewModel.Purchase.PaidAmount;
                updatedPurchase.PaymentType = purchaseViewModel.Purchase.PaymentType;
                updatedPurchase.PurchaseDate = purchaseViewModel.Purchase.PurchaseDate;
                updatedPurchase.PurchaseType = purchaseViewModel.Purchase.PurchaseType;
                updatedPurchase.RentAmount = purchaseViewModel.Purchase.RentAmount;
                updatedPurchase.SubTotal = purchaseViewModel.Purchase.SubTotal;
                updatedPurchase.SupplierId = purchaseViewModel.Purchase.SupplierId;
                updatedPurchase.TaxAmount = purchaseViewModel.Purchase.TaxAmount;
                updatedPurchase.TotalAmount = purchaseViewModel.Purchase.TotalAmount;
                updatedPurchase.TransCode = purchaseViewModel.Purchase.TransCode;
                updatedPurchase.UpdatedAt = purchaseViewModel.Purchase.UpdatedAt;
                updatedPurchase.UserId = purchaseViewModel.Purchase.UserId;
                updatedPurchase.UserName = purchaseViewModel.Purchase.UserName;
                updatedPurchase.BankId = purchaseViewModel.Purchase.BankId;
                updatedPurchase.CreatedAt = purchaseViewModel.Purchase.CreatedAt;
                updatedPurchase.DeletedAt = purchaseViewModel.Purchase.DeletedAt;
                updatedPurchase.Description = purchaseViewModel.Purchase.Description;
                updatedPurchase.DiscountAmount = purchaseViewModel.Purchase.DiscountAmount;
                updatedPurchase.DueAmount = purchaseViewModel.Purchase.DueAmount;

                dbContext.Purchases.Update(updatedPurchase);
                dbContext.SaveChanges();

                //delete old purchase details 
                var oldPurchaseDetails = dbContext.PurchaseDetails.Where(x => x.PurchaseId == purchaseViewModel.Purchase.Id).ToList();
                dbContext.PurchaseDetails.RemoveRange(oldPurchaseDetails);
                dbContext.SaveChanges();

                //add new purchase details
                foreach (var d in purchaseViewModel.PurchaseDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.PurchaseId = purchaseViewModel.Purchase.Id;
                }
                dbContext.PurchaseDetails.AddRange(purchaseViewModel.PurchaseDetails);
                dbContext.SaveChanges();

                //Update Stock
                var updatedStockDetails = UpdatePurchase_Stock(purchaseViewModel.Purchase, purchaseViewModel.PurchaseDetails, oldPurchaseDetails);
                if (updatedStockDetails)
                {
                    //Update Supplier and Cash/Bank Ledgers
                    var sl = UpdatePurchase_SupplierLedgerDetails(transCode, purchaseViewModel.Purchase, purchaseViewModel.Purchase.Id);
                    if (sl == 0)
                    {
                        return null;
                    }

                    var cl = UpdatePurchase_SupplierCashLedgerDetails(transCode, purchaseViewModel.Purchase, purchaseViewModel.Purchase.Id);
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

                return purchaseViewModel;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }

            return null;
        }

        private bool UpdatePurchase_Stock(Purchase purchase, IEnumerable<PurchaseDetails> purchaseDetails, IEnumerable<PurchaseDetails> oldPurchaseDetails)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in oldPurchaseDetails)
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

                    if (!UpdatePurchase_StockDetailsDelete(purchase.SupplierId, p, purchase.TransCode, purchase.Id))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();

                List<Stock> list2 = new List<Stock>();
                foreach (var p in purchaseDetails)
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

                    //Add Stock Details
                    if (!UpdatePurchase_StockDetailsAdd(purchase.SupplierId, p, purchase.TransCode, purchase.Id))
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

        private bool UpdatePurchase_StockDetailsDelete(long supplierId, PurchaseDetails p, string tcode, long purchaseId)
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
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_PurchaseUpdate_Delete(p.ProductId, supplierId, purchaseId),

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

        private bool UpdatePurchase_StockDetailsAdd(long supplierId, PurchaseDetails p, string tcode, long purchaseId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    CustomerId = -1,
                    SupplierId = supplierId,
                    InQty = QtyUnits,
                    OutQty = 0,
                    TransCode = tcode,
                    Description = helperRepository.StockDetailsMsg_PurchaseUpdate_Add(p.ProductId, supplierId, purchaseId),

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

        private int UpdatePurchase_SupplierLedgerDetails(string trc, Purchase purchase, long purchaseId)
        {
            if (dbContext != null)
            {

                //if transaction code is null ... find solution for it.
                var old_supplierLedger_total = dbContext.SupplierLedgers.FirstOrDefault(x => x.TransCode == trc);
                transactionRepository.DeleteSupplierLedger(old_supplierLedger_total); //Delete add records, total and paid ...

                SupplierLedger supplierLedger_total = new SupplierLedger
                {
                    EntityId = purchase.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierPurchaseMsg(purchase.InvoiceNo, purchase.TotalAmount),
                    Debit = 0,
                    Credit = purchase.TotalAmount,
                    Balance = 0 - purchase.TotalAmount,
                    TransCode = trc,
                };

                SupplierLedger supplierLedger_paid = new SupplierLedger
                {
                    EntityId = purchase.SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                    Debit = purchase.PaidAmount,
                    Credit = 0,
                    Balance = purchase.PaidAmount - 0,
                    TransCode = trc,
                };


                Transaction transaction1 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierPurchaseMsg(purchase.InvoiceNo, purchase.TotalAmount),
                    Amount = purchase.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                    Amount = purchase.PaidAmount,
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

        private int UpdatePurchase_SupplierCashLedgerDetails(string transCode, Purchase purchase, long purchaseId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                    Amount = purchase.PaidAmount,
                    Operation = Operation.Create
                };

                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr2 == true)
                {
                    //Cash Ledger
                    if (purchase.BankId != 0)
                    {
                        var old_bankledger = dbContext.BankLedgers.FirstOrDefault(x => x.TransCode == transCode);
                        transactionRepository.DeleteBankLedger(old_bankledger);

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = purchase.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                            Debit = 0,
                            Credit = purchase.PaidAmount,
                            Balance = 0 - purchase.PaidAmount,
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
                            EntityId = purchase.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            VoucherNo = purchaseId.ToString(),
                            Description = helperRepository.SupplierPaidMsg(purchase.InvoiceNo, purchase.PaidAmount),
                            Debit = 0,
                            Credit = purchase.PaidAmount,
                            Balance = 0 - purchase.PaidAmount,
                            TransCode = transCode,
                            TransType = CashType.Purchase,
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
