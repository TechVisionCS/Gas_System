using PMS.Data;
using PMS.Data.Enums;
using PMS.Models;
using PMS.Models.Finance;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PMS.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;
        private readonly IProductRepository productRepository;

        public SupplierRepository(ApplicationDbContext dbContext,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository,
            ITransactionRepository transactionRepository,
            IProductRepository productRepository)
        {
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
            this.transactionRepository = transactionRepository;
            this.productRepository = productRepository;
        }

        public SupplierDetailsViewModel GetSupplierDetails(long id)
        {
            if (dbContext != null)
            {
                var supplier = dbContext.Suppliers.FirstOrDefault(x => x.Id == id);
                if (supplier != null)
                {
                    var supplierViewModel = GetByIdSupplier(id);
                    var supplierLedger = GetSupplierLedgers(id, null, null);
                    var products = productRepository.GetAllProducts().ToList();

                    SupplierDetailsViewModel model = new SupplierDetailsViewModel()
                    {
                        SupplierDetails = supplierViewModel,
                        SupplierLedgerDetails = supplierLedger,
                        ProductDetails = products
                    };

                    return model;

                }
                return null;
            }
            return null;
        }

        public decimal GetSBelance(long SupplierId)
        {
            if (dbContext != null)
            {
                var getSupplier = dbContext.Suppliers.Where(x => x.DeletedAt == null && x.Id == SupplierId).ToList();
                decimal pBalance = 0;
                foreach (var Belance in getSupplier)
                {
                    pBalance = dbContext.SupplierLedgers.Where(x => x.EntityId == Belance.Id).Sum(x => x.Debit) - dbContext.SupplierLedgers.Where(x => x.EntityId == Belance.Id).Sum(x => x.Credit);
                    return pBalance;
                }
            }
            return 1;
        }

        public Supplier AddSupplier(Supplier supplier)
        {
            if (dbContext != null)
            {

                supplier.UserId = pmsHelper.GetCurrentUserId();
                supplier.UserName = pmsHelper.GetUserName(supplier.UserId);
                supplier.CreatedAt = DateTime.Now;
                supplier.UpdatedAt = DateTime.Now;

                if (supplier.PreviousBalance == 0)
                {
                    dbContext.Suppliers.Add(supplier);
                    dbContext.SaveChanges();

                    return supplier;
                }
                else if (supplier.PreviousBalance > 0)
                {
                    //Transcation to SupplierLedger
                    //1. Add Supplier
                    //2. Add Supplier Ledger
                    //3. Add Transaction Log
                    //4. Add Cash Ledger

                    using var transaction = dbContext.Database.BeginTransaction();
                    try
                    {
                        var SupplierId = AddSupplierDetails(supplier);

                        if (SupplierId != 0)
                        {
                            var transCode = helperRepository.GetTransactionCode();

                            var spl = AddSupplierLedgerDetails(transCode, SupplierId, supplier);

                            if (spl != 0)
                            {
                                var spcl = AddSupplierCashLedgerDetails(transCode, SupplierId, supplier);
                                if (spcl == 0)
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }

                        transaction.Commit();

                        return supplier;
                    }
                    catch (Exception)
                    {
                        return null;
                    }

                }
                else
                {
                    //In case of negitive balance
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public bool DeleteSupplier(long id)
        {
            if (dbContext != null)
            {
                var m = dbContext.Suppliers.FirstOrDefault(x => x.Id == id);
                if (m != null)
                {
                    m.UserId = pmsHelper.GetCurrentUserId();
                    m.UserName = pmsHelper.GetUserName(m.UserId);
                    m.DeletedAt = DateTime.Now;
                    dbContext.Suppliers.Update(m);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            return false;
        }

        public IEnumerable<SupplierViewModel> GetAllSupplier()
        {
            if (dbContext != null)
            {
                List<SupplierViewModel> list = new List<SupplierViewModel>();
                var models = dbContext.Suppliers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = dbContext.SupplierLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Debit) - dbContext.SupplierLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Credit);
                    SupplierViewModel model = new SupplierViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        Name = m.Name,
                        Phone = m.Phone,
                        Address = m.Address,
                        Details = m.Details,
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt,
                        Balance = pBalance,
                        BalanceFlg = bFlg,
                        UserId = m.UserId,
                        UserName = pmsHelper.GetUserName(m.UserId)
                    };
                    list.Add(model);
                }

                return list;
            }

            return null;
        }

        public Supplier GetByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                var supplier = dbContext.Suppliers.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                return supplier;
            }
            return null;
        }

        public SupplierViewModel GetByIdSupplier(long id)
        {
            if (dbContext != null)
            {
                var m = dbContext.Suppliers.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                decimal pBalance = 0;
                string bFlg = "+";

                pBalance = dbContext.SupplierLedgers.Where(x => x.EntityId == id).Sum(x => x.Debit) - dbContext.SupplierLedgers.Where(x => x.EntityId == id).Sum(x => x.Credit);

                SupplierViewModel model = new SupplierViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Phone = m.Phone,
                    Email = m.Email,
                    Address = m.Address,
                    Details = m.Details,
                    CreatedAt = m.CreatedAt,
                    UpdatedAt = m.UpdatedAt,
                    DeletedAt = m.DeletedAt,
                    Balance = pBalance,
                    BalanceFlg = bFlg,
                    UserId = m.UserId,
                    UserName = pmsHelper.GetUserName(m.UserId)
                };

                return model;
            }
            return null;
        }

        public Supplier UpdateSupplier(Supplier supplier)
        {
            if (dbContext != null)
            {
                supplier.UserId = pmsHelper.GetCurrentUserId();
                supplier.UserName = pmsHelper.GetUserName(supplier.UserId);
                supplier.UpdatedAt = DateTime.Now;
                dbContext.Suppliers.Update(supplier);
                dbContext.SaveChanges();
                return supplier;
            }
            return null;
        }


        // Local methods
        private long AddSupplierDetails(Supplier supplier)
        {
            if (dbContext != null)
            {
                //supplier.PreviousBalance = 0;
                dbContext.Suppliers.Add(supplier);
                dbContext.SaveChanges();

                var maxId = dbContext.Suppliers.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        private int AddSupplierLedgerDetails(string trc, long SupplierId, Supplier supplier)
        {
            if (dbContext != null)
            {

                SupplierLedger supplierLedger = new SupplierLedger
                {
                    EntityId = SupplierId,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierPreviousBalanceMsg(supplier.PreviousBalance),
                    Debit = supplier.PreviousBalance,
                    Credit = 0,
                    Balance = supplier.PreviousBalance - 0,
                    TransCode = trc,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.SupplierPreviousBalanceMsg(supplier.PreviousBalance),
                    Amount = supplier.PreviousBalance,
                    Operation = Operation.Create
                };

                if (transactionRepository.AddTransactionLog(transaction))
                {
                    var res = transactionRepository.AddSupplierLedger(supplierLedger);
                    if (res != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }


        private int AddSupplierCashLedgerDetails(string transCode, long SupplierId, Supplier supplier)
        {
            if (dbContext != null)
            {
                CashLedger cashLedger = new CashLedger
                {
                    EntityId = SupplierId,
                    EntityType = EntityType.Supplier,
                    Date = DateTime.Now,
                    Description = helperRepository.SupplierCashPreviousBalanceMsg(supplier.PreviousBalance),
                    VoucherNo = null,
                    Debit = 0,
                    Credit = supplier.PreviousBalance,
                    Balance = supplier.PreviousBalance - 0,
                    TransCode = transCode,
                    TransType = CashType.SupplierPreviousBalance,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.SupplierCashPreviousBalanceMsg(supplier.PreviousBalance),
                    Amount = supplier.PreviousBalance,
                    Operation = Operation.Create
                };

                if (transactionRepository.AddTransactionLog(transaction))
                {
                    var res = transactionRepository.AddCashLedger(cashLedger);

                    if (res != null)
                    {
                        return 1;
                    }
                }

            }
            return 0;
        }

        public IEnumerable<SupplierLedgerViewModel> GetSupplierLedgers(long supplierId = 0, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (dbContext != null)
            {
                List<SupplierLedgerViewModel> list = new List<SupplierLedgerViewModel>();
                var models = dbContext.SupplierLedgers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = m.Debit - m.Credit;

                    //long cid = dbContext.Suppliers.FirstOrDefault(x => x.Id == m.EntityId).Countryid;
                    //long pid = dbContext.Suppliers.FirstOrDefault(x => x.Id == m.EntityId).Provinceid;

                    //string address = "";
                    //string country = helperRepository.GetCountry().FirstOrDefault(a => a.Id == dbContext.Suppliers.FirstOrDefault(x => x.Id == m.EntityId).Countryid)?.Name;
                    //string province = helperRepository.GetProvinces().FirstOrDefault(a => a.Id == dbContext.Suppliers.FirstOrDefault(x => x.Id == m.EntityId).Provinceid)?.Name; 

                    SupplierLedgerViewModel model = new SupplierLedgerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        EntityId = m.EntityId,
                        EntityName = dbContext.Suppliers.FirstOrDefault(x => x.Id == m.EntityId).Name,
                        EntityPhone = dbContext.Suppliers.FirstOrDefault(x => x.Id == m.EntityId).Phone,
                        EntityAddress = dbContext.Suppliers.FirstOrDefault(x => x.Id == m.EntityId).Address,
                        Date = m.Date,
                        Description = m.Description,
                        Debit = m.Debit,
                        Credit = m.Credit,
                        VoucherNo = m.VoucherNo,
                        TransCode = m.TransCode,
                        isClosed = m.isClosed,
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt,
                        Balance = pBalance,
                        BalanceFlag = bFlg,
                        UserId = m.UserId,
                        UserName = pmsHelper.GetUserName(m.UserId)
                    };
                    list.Add(model);
                }

                if (supplierId != 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.EntityId == supplierId && x.Date >= startDate && x.Date <= endDate).ToList();

                }
                else if (supplierId == 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
                else if (supplierId != 0 && startDate == null && endDate == null)
                {
                    list = list.Where(x => x.EntityId == supplierId).ToList();
                }
                else
                {
                    //do nothing
                }

                return list;
            }

            return null;
        }


        public IEnumerable<SupplierPayment> GetSupplierPayments()
        {
            if (dbContext != null)
            {
                var models = dbContext.SupplierPayments.ToList();
                return models;
            }

            return null;
        }

        public IEnumerable<SupplierPayment> GetSupplierPayments(long supplierId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                var models = dbContext.SupplierPayments.ToList();
                if (supplierId > 0)
                {
                    models = models.Where(x => x.SupplierId == supplierId).ToList();
                }

                if (startDate != null)
                {
                    models = models.Where(x => x.Date >= startDate).ToList();
                }

                if (endDate != null)
                {
                    models = models.Where(x => x.Date <= endDate).ToList();
                }

                return models;
            }
            return null;
        }

        public SupplierPayment GetSupplierPayment(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.SupplierPayments.FirstOrDefault(x => x.Id == id);
                return model;
            }

            return null;
        }
        public SupplierPayment AddSupplierPayment(SupplierPayment supplier)
        {
            if (dbContext != null)
            {
                supplier.UserId = pmsHelper.GetCurrentUserId();
                supplier.UserName = pmsHelper.GetUserName(supplier.UserId);
                supplier.CreatedAt = DateTime.Now;
                supplier.UpdatedAt = DateTime.Now;

                if (supplier.PaymentType == 1)
                {
                    supplier.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == supplier.BankId).BankName;
                }

                supplier.SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == supplier.SupplierId).Name;
                var transCode = helperRepository.GetTransactionCode();
                supplier.TransCode = transCode;

                //Add Partner... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.SupplierPayments.Add(supplier);
                    dbContext.SaveChanges();

                    SupplierLedger supplierLedger = new SupplierLedger
                    {
                        EntityId = supplier.SupplierId,
                        Date = DateTime.Now,
                        Description = helperRepository.SupplierPaymentMsg(supplier.Amount),
                        VoucherNo = null,
                        Debit = supplier.Amount,
                        Credit = 0,
                        Balance = supplier.Amount - 0,
                        TransCode = transCode
                    };

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.SupplierPaymentMsg(supplier.Amount),
                        Amount = supplier.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.AddSupplierLedger(supplierLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (supplier.PaymentType == 0)
                    {
                        //cash
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = supplier.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierPaymentMsg_Cash(supplier.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = supplier.Amount,
                            Balance = 0 - supplier.Amount,
                            TransCode = transCode,
                            TransType = CashType.SupplierPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.SupplierPaymentMsg_Cash(supplier.Amount),
                            Amount = supplier.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction2))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else if (supplier.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = supplier.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierPaymentMsg_Bank(supplier.Amount),
                            Debit = 0,
                            Credit = supplier.Amount,
                            Balance = 0 - supplier.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.SupplierPaymentMsg_Bank(supplier.Amount),
                            Amount = supplier.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction3))
                        {
                            var res = transactionRepository.AddBankLedger(bankLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else
                    {
                        return null;
                    }

                    transaction.Commit();
                    return supplier;
                }
                catch
                {
                    return null;
                }

            }
            return null;
        }
        public SupplierPayment EditSupplierPayment(SupplierPayment supplier)
        {
            if (dbContext != null)
            {
                supplier.UserId = pmsHelper.GetCurrentUserId();
                supplier.UserName = pmsHelper.GetUserName(supplier.UserId);
                supplier.CreatedAt = supplier.CreatedAt;
                supplier.UpdatedAt = DateTime.Now;

                if (supplier.PaymentType == 1)
                {
                    supplier.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == supplier.BankId).BankName;
                }

                if (supplier.PaymentType == 0)
                {
                    supplier.BankId = 0;
                    supplier.BankName = "";
                }

                supplier.SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == supplier.SupplierId).Name;
                var transCode = supplier.TransCode;

                //Edit Suppler... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.SupplierPayments.Update(supplier);
                    dbContext.SaveChanges();

                    var cLedger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);
                    var bLedger = dbContext.BankLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    if (cLedger != null)
                    {
                        var res = transactionRepository.DeleteCashLedger(cLedger);
                    }

                    if (bLedger != null)
                    {
                        var res = transactionRepository.DeleteBankLedger(bLedger);
                    }

                    var sledger = dbContext.SupplierLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    sledger.EntityId = supplier.SupplierId;
                    sledger.Debit = supplier.Amount;
                    sledger.Balance = supplier.Amount - 0;
                    sledger.Description = helperRepository.SupplierPaymentMsg(supplier.Amount);


                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.SupplierPaymentMsg(supplier.Amount),
                        Amount = supplier.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdateSupplierLedger(sledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (supplier.PaymentType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = supplier.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = supplier.Date,
                            Description = helperRepository.SupplierPaymentMsg_Cash(supplier.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = supplier.Amount,
                            Balance = 0 - supplier.Amount,
                            TransCode = transCode,
                            TransType = CashType.SupplierPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.SupplierPaymentMsg_Cash(supplier.Amount),
                            Amount = supplier.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction2))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else if (supplier.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = supplier.BankId,
                            EntityType = EntityType.Bank,
                            Date = supplier.Date,
                            Description = helperRepository.SupplierPaymentMsg_Bank(supplier.Amount),
                            Debit = 0,
                            Credit = supplier.Amount,
                            Balance = 0 - supplier.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.SupplierPaymentMsg_Bank(supplier.Amount),
                            Amount = supplier.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction3))
                        {
                            var res = transactionRepository.AddBankLedger(bankLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else
                    {
                        return null;
                    }

                    transaction.Commit();
                    return supplier;
                }
                catch
                {
                    return null;
                }

            }
            return null;
        }

        public IEnumerable<SupplierAdvanced> GetSupplierAdvanceds()
        {
            if (dbContext != null)
            {
                var models = dbContext.SupplierAdvanceds.ToList();
                return models;
            }
            return null;
        }

        public IEnumerable<SupplierAdvanced> GetSupplierAdvanceds(long supplierId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                var models = dbContext.SupplierAdvanceds.ToList();
                if (supplierId > 0)
                {
                    models = models.Where(x => x.SupplierId == supplierId).ToList();
                }

                if (startDate != null)
                {
                    models = models.Where(x => x.Date >= startDate).ToList();
                }

                if (endDate != null)
                {
                    models = models.Where(x => x.Date <= endDate).ToList();
                }

                return models;
            }
            return null;
        }
        public SupplierAdvanced GetSupplierAdvanced(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.SupplierAdvanceds.FirstOrDefault(x => x.Id == id);
                return model;
            }
            return null;
        }
        public SupplierAdvanced AddSupplierAdvanced(SupplierAdvanced supplier)
        {
            if (dbContext != null)
            {
                supplier.UserId = pmsHelper.GetCurrentUserId();
                supplier.UserName = pmsHelper.GetUserName(supplier.UserId);
                supplier.CreatedAt = DateTime.Now;
                supplier.UpdatedAt = DateTime.Now;

                if (supplier.PaymentType == 1)
                {
                    supplier.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == supplier.BankId).BankName;
                }

                supplier.SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == supplier.SupplierId).Name;
                var transCode = helperRepository.GetTransactionCode();
                supplier.TransCode = transCode;

                //Add Partner... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.SupplierAdvanceds.Add(supplier);
                    dbContext.SaveChanges();

                    SupplierLedger supplierLedger = new SupplierLedger
                    {
                        EntityId = supplier.SupplierId,
                        Date = DateTime.Now,
                        Description = helperRepository.SupplierAdvancedMsg(supplier.Amount),
                        VoucherNo = null,
                        Debit = supplier.Amount,
                        Credit = 0,
                        Balance = supplier.Amount - 0,
                        TransCode = transCode
                    };

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.SupplierAdvancedMsg(supplier.Amount),
                        Amount = supplier.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.AddSupplierLedger(supplierLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (supplier.PaymentType == 0)
                    {
                        //cash
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = supplier.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierAdvancedMsg_Cash(supplier.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = supplier.Amount,
                            Balance = 0 - supplier.Amount,
                            TransCode = transCode,
                            TransType = CashType.SupplierPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.SupplierAdvancedMsg_Cash(supplier.Amount),
                            Amount = supplier.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction2))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else if (supplier.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = supplier.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.SupplierAdvancedMsg_Bank(supplier.Amount),
                            Debit = 0,
                            Credit = supplier.Amount,
                            Balance = 0 - supplier.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.SupplierAdvancedMsg_Bank(supplier.Amount),
                            Amount = supplier.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction3))
                        {
                            var res = transactionRepository.AddBankLedger(bankLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else
                    {
                        return null;
                    }

                    transaction.Commit();
                    return supplier;
                }
                catch
                {
                    return null;
                }

            }
            return null;
        }
        public SupplierAdvanced EditSupplierAdvanced(SupplierAdvanced supplier)
        {
            if (dbContext != null)
            {
                supplier.UserId = pmsHelper.GetCurrentUserId();
                supplier.UserName = pmsHelper.GetUserName(supplier.UserId);
                supplier.CreatedAt = supplier.CreatedAt;
                supplier.UpdatedAt = DateTime.Now;

                if (supplier.PaymentType == 1)
                {
                    supplier.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == supplier.BankId).BankName;
                }

                if (supplier.PaymentType == 0)
                {
                    supplier.BankId = 0;
                    supplier.BankName = "";
                }

                supplier.SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == supplier.SupplierId).Name;
                var transCode = supplier.TransCode;

                //Edit Suppler... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.SupplierAdvanceds.Update(supplier);
                    dbContext.SaveChanges();

                    var cLedger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);
                    var bLedger = dbContext.BankLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    if (cLedger != null)
                    {
                        var res = transactionRepository.DeleteCashLedger(cLedger);
                    }

                    if (bLedger != null)
                    {
                        var res = transactionRepository.DeleteBankLedger(bLedger);
                    }

                    var sledger = dbContext.SupplierLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    sledger.EntityId = supplier.SupplierId;
                    sledger.Debit = supplier.Amount;
                    sledger.Balance = supplier.Amount - 0;
                    sledger.Description = helperRepository.SupplierAdvancedMsg(supplier.Amount);


                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.SupplierAdvancedMsg(supplier.Amount),
                        Amount = supplier.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdateSupplierLedger(sledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (supplier.PaymentType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = supplier.SupplierId,
                            EntityType = EntityType.Supplier,
                            Date = supplier.Date,
                            Description = helperRepository.SupplierAdvancedMsg_Cash(supplier.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = supplier.Amount,
                            Balance = 0 - supplier.Amount,
                            TransCode = transCode,
                            TransType = CashType.SupplierPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.SupplierAdvancedMsg_Cash(supplier.Amount),
                            Amount = supplier.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction2))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else if (supplier.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = supplier.BankId,
                            EntityType = EntityType.Bank,
                            Date = supplier.Date,
                            Description = helperRepository.SupplierAdvancedMsg_Bank(supplier.Amount),
                            Debit = 0,
                            Credit = supplier.Amount,
                            Balance = 0 - supplier.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.SupplierAdvancedMsg_Bank(supplier.Amount),
                            Amount = supplier.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction3))
                        {
                            var res = transactionRepository.AddBankLedger(bankLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else
                    {
                        return null;
                    }

                    transaction.Commit();
                    return supplier;
                }
                catch
                {
                    return null;
                }

            }
            return null;
        }


    }
}
