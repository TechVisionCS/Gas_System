using PMS.Data;
using PMS.Data.Enums;
using PMS.Models;
using PMS.Models.Finance;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels;
using PMS.ViewModels.Finance;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PMS.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;
        private readonly IProductRepository productRepository;

        public CustomerRepository(ApplicationDbContext dbContext,
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

        public decimal GetCLedgerBelance(long CustomerId)
        {
            if (dbContext != null)
            {
                var models = dbContext.Customers.Where(x => x.DeletedAt == null && x.Id == CustomerId).ToList();

                decimal pBalance = 0;
                foreach (var m in models)
                {
                    pBalance = dbContext.CustomerLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Debit) - dbContext.CustomerLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Credit);
                    return pBalance;
                }
                return 1;
            }
            return 0;
        }

        public CustomerDetailsViewModel GetCustomerDetails(long id)
        {
            if (dbContext != null)
            {
                var customer = dbContext.Customers.FirstOrDefault(x => x.Id == id);
                if (customer != null)
                {
                    var customerViewModel = GetByIdCustomer(id);
                    var customerLedger = GetCustomerLedgers(id, null, null);
                    //var products = productRepository.GetAllProducts().Where(x => x.SupplierId == id).ToList(); //replace it with customer invovices 

                    CustomerDetailsViewModel model = new CustomerDetailsViewModel()
                    {
                        CustomerDetails = customerViewModel,
                        CustomerLedgerDetails = customerLedger,
                        //ProductDetails = products
                    };

                    return model;

                }
                return null;
            }
            return null;
        }

        public Customer AddCustomer(Customer customer)
        {
            if (dbContext != null)
            {

                customer.UserId = pmsHelper.GetCurrentUserId();
                customer.UserName = pmsHelper.GetUserName(customer.UserId);
                customer.CreatedAt = DateTime.Now;
                customer.UpdatedAt = DateTime.Now;

                if (customer.PreviousBalance == 0)
                {
                    dbContext.Customers.Add(customer);
                    dbContext.SaveChanges();

                    return customer;
                }
                else if (customer.PreviousBalance > 0)
                {
                    //Transcation to CustomerLedger
                    //1. Add Customer
                    //2. Add Customer Ledger
                    //3. Add Transaction Log
                    //4. Add Cash Ledger

                    using var transaction = dbContext.Database.BeginTransaction();
                    try
                    {
                        var CustomerId = AddCutomerDetails(customer);

                        if (CustomerId != 0)
                        {
                            var transCode = helperRepository.GetTransactionCode();

                            var cpl = AddCustomerLedgerDetails(transCode, CustomerId, customer);

                            if (cpl != 0)
                            {
                                var cpcl = AddCustomerCashLedgerDetails(transCode, CustomerId, customer);
                                if (cpcl == 0)
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

                        return customer;
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

        public bool DeleteCustomer(long customerid)
        {
            if (dbContext != null)
            {
                var m = dbContext.Customers.FirstOrDefault(x => x.Id == customerid);
                if (m != null)
                {
                    m.UserId = pmsHelper.GetCurrentUserId();
                    m.UserName = pmsHelper.GetUserName(m.UserId);
                    m.DeletedAt = DateTime.Now;
                    dbContext.Customers.Update(m);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            return false;
        }

        public IEnumerable<CustomerViewModel> GetAllCustomer()
        {
            if (dbContext != null)
            {
                List<CustomerViewModel> list = new List<CustomerViewModel>();
                var models = dbContext.Customers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";
                foreach (var m in models)
                {
                    pBalance = dbContext.CustomerLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Debit) - dbContext.CustomerLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Credit);
                    CustomerViewModel model = new CustomerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
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
                    list.Add(model);
                }

                return list;
            }

            return null;
        }

        public Customer GetByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                var customer = dbContext.Customers.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                return customer;
            }
            return null;
        }

        public CustomerViewModel GetByIdCustomer(long id)
        {
            if (dbContext != null)
            {
                var m = dbContext.Customers.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                decimal pBalance = 0;
                string bFlg = "+";

                pBalance = dbContext.CustomerLedgers.Where(x => x.EntityId == id).Sum(x => x.Debit) - dbContext.CustomerLedgers.Where(x => x.EntityId == id).Sum(x => x.Credit);
                CustomerViewModel model = new CustomerViewModel
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

        public Customer UpdateCustomer(Customer customer)
        {
            if (dbContext != null)
            {
                customer.UserId = pmsHelper.GetCurrentUserId();
                customer.UserName = pmsHelper.GetUserName(customer.UserId);
                customer.CreatedAt = customer.CreatedAt;
                customer.UpdatedAt = DateTime.Now;
                dbContext.Customers.Update(customer);
                dbContext.SaveChanges();
                return customer;
            }
            return null;
        }

        // Local methods
        private long AddCutomerDetails(Customer customer)
        {
            if (dbContext != null)
            {
                //customer.PreviousBalance = 0;
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();

                var maxId = dbContext.Customers.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        private int AddCustomerLedgerDetails(string trc, long CustomerId, Customer customer)
        {
            if (dbContext != null)
            {

                CustomerLedger customerLedger = new CustomerLedger
                {
                    EntityId = CustomerId,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerPreviousBalanceMsg(customer.PreviousBalance),
                    Debit = customer.PreviousBalance,
                    Credit = 0,
                    Balance = customer.PreviousBalance - 0,
                    TransCode = trc,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerPreviousBalanceMsg(customer.PreviousBalance),
                    Amount = customer.PreviousBalance,
                    Operation = Operation.Create
                };

                if (transactionRepository.AddTransactionLog(transaction))
                {
                    var res = transactionRepository.AddCustomerLedger(customerLedger);
                    if (res != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private int AddCustomerCashLedgerDetails(string transCode, long CustomerId, Customer customer)
        {
            if (dbContext != null)
            {
                CashLedger cashLedger = new CashLedger
                {
                    EntityId = CustomerId,
                    EntityType = EntityType.Customer,
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerCashPreviousBalanceMsg(customer.PreviousBalance),
                    VoucherNo = null,
                    Debit = 0,
                    Credit = customer.PreviousBalance,
                    Balance = customer.PreviousBalance - 0,
                    TransCode = transCode,
                    TransType = CashType.CustomerPreviousBalance,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CustomerCashPreviousBalanceMsg(customer.PreviousBalance),
                    Amount = customer.PreviousBalance,
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

        public IEnumerable<CustomerLedgerViewModel> GetCustomerLedgers(long CustomerId = 0, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (dbContext != null)
            {
                List<CustomerLedgerViewModel> list = new List<CustomerLedgerViewModel>();
                var models = dbContext.CustomerLedgers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = m.Debit - m.Credit;



                    string address = "";

                    string addr = "";

                    string entityName = "WALKING CUSTOMER";
                    string entityPhone = "";

                    if (m.EntityId != 0)
                    {

                        //cid = dbContext.Customers.FirstOrDefault(x => x.Id == m.EntityId).Countryid;
                        //pid = dbContext.Customers.FirstOrDefault(x => x.Id == m.EntityId).Provinceid;

                        //country = helperRepository.GetCountry().FirstOrDefault(a => a.Id == dbContext.Customers.FirstOrDefault(x => x.Id == m.EntityId).Countryid)?.Name;
                        //province = helperRepository.GetProvinces().FirstOrDefault(a => a.Id == dbContext.Customers.FirstOrDefault(x => x.Id == m.EntityId).Provinceid)?.Name;

                        addr = dbContext.Customers.FirstOrDefault(x => x.Id == m.EntityId).Address;
                        entityName = dbContext.Customers.FirstOrDefault(x => x.Id == m.EntityId).Name;
                        entityPhone = dbContext.Customers.FirstOrDefault(x => x.Id == m.EntityId).Phone;
                    }

                    address = addr;

                    CustomerLedgerViewModel model = new CustomerLedgerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        EntityId = m.EntityId,
                        EntityName = entityName,
                        EntityPhone = entityPhone,
                        EntityAddress = address,
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

                if (CustomerId != 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.EntityId == CustomerId && x.Date >= startDate && x.Date <= endDate).ToList();

                }
                else if (CustomerId == 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
                else if (CustomerId != 0 && startDate == null && endDate == null)
                {
                    list = list.Where(x => x.EntityId == CustomerId).ToList();
                }
                else
                {
                    //do nothing
                }

                return list;
            }

            return null;
        }


        public IEnumerable<CustomerReceive> GetCustomerReceives()
        {
            if (dbContext != null)
            {
                var models = dbContext.CustomerReceives.ToList();
                return models;
            }

            return null;
        }
        public IEnumerable<CustomerReceive> GetCustomerReceives(long customerId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                var models = dbContext.CustomerReceives.ToList();
                if (customerId > 0)
                {
                    models = models.Where(x => x.CustomerId == customerId).ToList();
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
        public CustomerReceive GetCustomerReceive(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.CustomerReceives.FirstOrDefault(x => x.Id == id);
                return model;
            }

            return null;

        }

        public CustomerReceive AddCustomerReceive(CustomerReceive customer)
        {
            if (dbContext != null)
            {
                customer.UserId = pmsHelper.GetCurrentUserId();
                customer.UserName = pmsHelper.GetUserName(customer.UserId);
                customer.CreatedAt = DateTime.Now;
                customer.UpdatedAt = DateTime.Now;

                if (customer.PaymentType == 1)
                {
                    customer.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == customer.BankId).BankName;
                }

                customer.CustomerName = dbContext.Customers.FirstOrDefault(x => x.Id == customer.CustomerId).Name;
                var transCode = helperRepository.GetTransactionCode();
                customer.TransCode = transCode;

                //Add Customer... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.CustomerReceives.Add(customer);
                    dbContext.SaveChanges();

                    CustomerLedger customerLedger = new CustomerLedger
                    {
                        EntityId = customer.CustomerId,
                        Date = DateTime.Now,
                        Description = helperRepository.CustomerReceiveMsg(customer.Amount),
                        VoucherNo = null,
                        Debit = 0,
                        Credit = customer.Amount,
                        Balance = 0 - customer.Amount,
                        TransCode = transCode
                    };

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.CustomerReceiveMsg(customer.Amount),
                        Amount = customer.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.AddCustomerLedger(customerLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (customer.PaymentType == 0)
                    {
                        //cash
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = customer.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerReceiveMsg_Cash(customer.Amount),
                            VoucherNo = null,
                            Debit = customer.Amount,
                            Credit = 0,
                            Balance = customer.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.CustomerReceive
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.CustomerReceiveMsg_Cash(customer.Amount),
                            Amount = customer.Amount,
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
                    else if (customer.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = customer.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerReceiveMsg_Bank(customer.Amount),
                            Debit = customer.Amount,
                            Credit = 0,
                            Balance = customer.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.CustomerReceiveMsg_Bank(customer.Amount),
                            Amount = customer.Amount,
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
                    return customer;
                }
                catch
                {
                    return null;
                }

            }
            return null;

        }
        public CustomerReceive EditCustomerReceive(CustomerReceive customer)
        {
            if (dbContext != null)
            {
                customer.UserId = pmsHelper.GetCurrentUserId();
                customer.UserName = pmsHelper.GetUserName(customer.UserId);
                customer.CreatedAt = customer.CreatedAt;
                customer.UpdatedAt = DateTime.Now;

                if (customer.PaymentType == 1)
                {
                    customer.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == customer.BankId).BankName;
                }

                if (customer.PaymentType == 0)
                {
                    customer.BankId = 0;
                    customer.BankName = "";
                }

                customer.CustomerName = dbContext.Customers.FirstOrDefault(x => x.Id == customer.CustomerId).Name;
                var transCode = customer.TransCode;

                //Edit Customer... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.CustomerReceives.Update(customer);
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

                    var cledger = dbContext.CustomerLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    cledger.EntityId = customer.CustomerId;
                    cledger.Credit = customer.Amount;
                    cledger.Balance = 0 - customer.Amount;
                    cledger.Description = helperRepository.CustomerReceiveMsg(customer.Amount);


                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.CustomerReceiveMsg(customer.Amount),
                        Amount = customer.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdateCustomerLedger(cledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (customer.PaymentType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = customer.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = customer.Date,
                            Description = helperRepository.CustomerReceiveMsg_Cash(customer.Amount),
                            VoucherNo = null,
                            Debit = customer.Amount,
                            Credit = 0,
                            Balance = customer.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.CustomerReceive
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.CustomerReceiveMsg_Cash(customer.Amount),
                            Amount = customer.Amount,
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
                    else if (customer.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = customer.BankId,
                            EntityType = EntityType.Bank,
                            Date = customer.Date,
                            Description = helperRepository.CustomerReceiveMsg_Bank(customer.Amount),
                            Debit = customer.Amount,
                            Credit = 0,
                            Balance = customer.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.CustomerReceiveMsg_Bank(customer.Amount),
                            Amount = customer.Amount,
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
                    return customer;
                }
                catch
                {
                    return null;
                }

            }
            return null;

        }

        public IEnumerable<CustomerAdvanced> GetCustomerAdvances()
        {
            if (dbContext != null)
            {
                var models = dbContext.CustomerAdvanceds.ToList();
                return models;
            }

            return null;

        }
        public IEnumerable<CustomerAdvanced> GetCustomerAdvances(long customerId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                var models = dbContext.CustomerAdvanceds.ToList();
                if (customerId > 0)
                {
                    models = models.Where(x => x.CustomerId == customerId).ToList();
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
        public CustomerAdvanced GetCustomerAdvance(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.CustomerAdvanceds.FirstOrDefault(x => x.Id == id);
                return model;
            }

            return null;

        }
        public CustomerAdvanced AddCustomerAdvance(CustomerAdvanced customer)
        {
            if (dbContext != null)
            {
                customer.UserId = pmsHelper.GetCurrentUserId();
                customer.UserName = pmsHelper.GetUserName(customer.UserId);
                customer.CreatedAt = DateTime.Now;
                customer.UpdatedAt = DateTime.Now;

                if (customer.PaymentType == 1)
                {
                    customer.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == customer.BankId).BankName;
                }

                customer.CustomerName = dbContext.Customers.FirstOrDefault(x => x.Id == customer.CustomerId).Name;
                var transCode = helperRepository.GetTransactionCode();
                customer.TransCode = transCode;

                //Add Customer... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.CustomerAdvanceds.Add(customer);
                    dbContext.SaveChanges();

                    CustomerLedger customerLedger = new CustomerLedger
                    {
                        EntityId = customer.CustomerId,
                        Date = DateTime.Now,
                        Description = helperRepository.CustomerAdvancedMsg(customer.Amount),
                        VoucherNo = null,
                        Debit = 0,
                        Credit = customer.Amount,
                        Balance = 0 - customer.Amount,
                        TransCode = transCode
                    };

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.CustomerAdvancedMsg(customer.Amount),
                        Amount = customer.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.AddCustomerLedger(customerLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (customer.PaymentType == 0)
                    {
                        //cash
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = customer.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerAdvancedMsg_Cash(customer.Amount),
                            VoucherNo = null,
                            Debit = customer.Amount,
                            Credit = 0,
                            Balance = customer.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.CustomerAdvanced
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.CustomerAdvancedMsg_Cash(customer.Amount),
                            Amount = customer.Amount,
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
                    else if (customer.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = customer.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerAdvancedMsg_Bank(customer.Amount),
                            Debit = customer.Amount,
                            Credit = 0,
                            Balance = customer.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.CustomerAdvancedMsg_Bank(customer.Amount),
                            Amount = customer.Amount,
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
                    return customer;
                }
                catch
                {
                    return null;
                }

            }
            return null;

        }
        public CustomerAdvanced EditCustomerAdvance(CustomerAdvanced customer)
        {
            if (dbContext != null)
            {
                customer.UserId = pmsHelper.GetCurrentUserId();
                customer.UserName = pmsHelper.GetUserName(customer.UserId);
                customer.CreatedAt = customer.CreatedAt;
                customer.UpdatedAt = DateTime.Now;

                if (customer.PaymentType == 1)
                {
                    customer.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == customer.BankId).BankName;
                }

                if (customer.PaymentType == 0)
                {
                    customer.BankId = 0;
                    customer.BankName = "";
                }

                customer.CustomerName = dbContext.Customers.FirstOrDefault(x => x.Id == customer.CustomerId).Name;
                var transCode = customer.TransCode;

                //Edit Suppler... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.CustomerAdvanceds.Update(customer);
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

                    var cledger = dbContext.CustomerLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    cledger.EntityId = customer.CustomerId;
                    cledger.Credit = customer.Amount;
                    cledger.Balance = 0 - customer.Amount;
                    cledger.Description = helperRepository.CustomerAdvancedMsg(customer.Amount);


                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.CustomerAdvancedMsg(customer.Amount),
                        Amount = customer.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdateCustomerLedger(cledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (customer.PaymentType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = customer.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = customer.Date,
                            Description = helperRepository.CustomerAdvancedMsg_Cash(customer.Amount),
                            VoucherNo = null,
                            Debit = customer.Amount,
                            Credit = 0,
                            Balance = customer.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.CustomerAdvanced
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.CustomerAdvancedMsg_Cash(customer.Amount),
                            Amount = customer.Amount,
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
                    else if (customer.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = customer.BankId,
                            EntityType = EntityType.Bank,
                            Date = customer.Date,
                            Description = helperRepository.CustomerAdvancedMsg_Bank(customer.Amount),
                            Debit = customer.Amount,
                            Credit = 0,
                            Balance = customer.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.CustomerAdvancedMsg_Bank(customer.Amount),
                            Amount = customer.Amount,
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
                    return customer;
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
