using PMS.Data;
using PMS.Data.Enums;
using PMS.Models.Finance;
using PMS.Models.OfficeLoan;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.Finance;
using PMS.ViewModels.OfficeLoanViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class OfficeLoanRepository : IOfficeLoanRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;

        public OfficeLoanRepository(ApplicationDbContext dbContext,
            IHelperRepository helperRepository,
            ITransactionRepository transactionRepository)
        {
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<OfficePersonViewModel> GetAllOfficePerson()
        {
            if (dbContext != null)
            {
                List<OfficePersonViewModel> list = new List<OfficePersonViewModel>();
                var models = dbContext.OfficePeople.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = dbContext.OfficeLoanLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Debit) - dbContext.OfficeLoanLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Credit);

                    OfficePersonViewModel model = new OfficePersonViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        Name = m.Name,
                        FatherName = m.FatherName,
                        Phone = m.Phone,
                        Address = m.Address,
                        Details = m.Details,
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt,
                        Balance = pBalance,
                        BalanceFlg = bFlg,
                        UserId = m.UserId,
                        UserName = helperRepository.GetUserName(m.UserId)
                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }
        public OfficePersonViewModel GetByIdOfficePerson(long id)
        {
            if (dbContext != null)
            {
                var m = dbContext.OfficePeople.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                decimal pBalance = 0;
                string bFlg = "+";
                pBalance = dbContext.OfficeLoanLedgers.Where(x => x.EntityId == id).Sum(x => x.Debit) - dbContext.OfficeLoanLedgers.Where(x => x.EntityId == id).Sum(x => x.Credit);

                OfficePersonViewModel model = new OfficePersonViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    FatherName = m.FatherName,
                    Phone = m.Phone,
                    Address = m.Address,
                    Details = m.Details,
                    CreatedAt = m.CreatedAt,
                    UpdatedAt = m.UpdatedAt,
                    DeletedAt = m.DeletedAt,
                    Balance = pBalance,
                    BalanceFlg = bFlg,
                    UserId = m.UserId,
                    UserName = helperRepository.GetUserName(m.UserId)
                };

                return model;
            }
            return null;
        }
        public IEnumerable<OfficePersonLedgerViewModel> GetOfficePersonLedgers(long personId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                List<OfficePersonLedgerViewModel> list = new List<OfficePersonLedgerViewModel>();
                var models = dbContext.OfficeLoanLedgers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = m.Debit - m.Credit;
                    string addr = dbContext.OfficePeople.FirstOrDefault(x => x.Id == m.EntityId).Address;
                    OfficePersonLedgerViewModel model = new OfficePersonLedgerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        EntityId = m.EntityId,
                        EntityName = dbContext.OfficePeople.FirstOrDefault(x => x.Id == m.EntityId).Name,
                        EntityPhone = dbContext.OfficePeople.FirstOrDefault(x => x.Id == m.EntityId).Phone,
                        EntityAddress = addr,
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
                        UserName = helperRepository.GetUserName(m.UserId)
                    };
                    list.Add(model);
                }

                if (personId != 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.EntityId == personId && x.Date >= startDate && x.Date <= endDate).ToList();

                }
                else if (personId == 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
                else if (personId != 0 && startDate == null && endDate == null)
                {
                    list = list.Where(x => x.EntityId == personId).ToList();
                }
                else
                {
                    //do nothing
                }

                return list;
            }

            return null;
        }
        public OfficePersonLoanDetailsViewModel GetOfficePersonDetails(long id)
        {
            if (dbContext != null)
            {
                var person = dbContext.OfficePeople.FirstOrDefault(x => x.Id == id);
                if (person != null)
                {
                    var personViewModel = GetByIdOfficePerson(id);
                    var personLedger = GetOfficePersonLedgers(id, null, null);

                    OfficePersonLoanDetailsViewModel model = new OfficePersonLoanDetailsViewModel()
                    {
                        OfficePersonViewModel = personViewModel,
                        officePersonLedgerViewModels = personLedger
                    };

                    return model;
                }
                return null;
            }
            return null;
        }
        public OfficePerson GetOfficePersonByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                var person = dbContext.OfficePeople.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                return person;
            }
            return null;
        }
        public OfficePerson AddOfficePerson(OfficePerson person)
        {
            if (dbContext != null)
            {
                person.UserId = helperRepository.GetCurrentUserId();
                person.UserName = helperRepository.GetUserName(person.UserId);
                person.CreatedAt = DateTime.Now;
                person.UpdatedAt = DateTime.Now;

                if (person.PreviousBalance == 0)
                {
                    dbContext.OfficePeople.Add(person);
                    dbContext.SaveChanges();

                    return person;
                }
                else if (person.PreviousBalance > 0)
                {
                    //Transcation to Peronal Loan Ledger
                    //1. Add Person
                    //2. Add Person Ledger
                    //3. Add Transaction Log
                    //4. Add Cash Ledger

                    using var transaction = dbContext.Database.BeginTransaction();
                    try
                    {
                        var PersonId = AddPersonDetails(person);

                        if (PersonId != 0)
                        {
                            var transCode = helperRepository.GetTransactionCode();

                            var spl = AddOfficePersonLedgerDetails(transCode, PersonId, person);

                            if (spl != 0)
                            {
                                var spcl = AddOfficePersonLoanCashLedgerDetails(transCode, PersonId, person);
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

                        return person;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
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

        // Local methods
        private long AddPersonDetails(OfficePerson person)
        {
            if (dbContext != null)
            {
                dbContext.OfficePeople.Add(person);
                dbContext.SaveChanges();
                var maxId = dbContext.OfficePeople.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }
        private int AddOfficePersonLedgerDetails(string trc, long PersonId, OfficePerson person)
        {
            if (dbContext != null)
            {
                OfficeLoanLedger personLedger = new OfficeLoanLedger
                {
                    EntityId = PersonId,
                    Date = DateTime.Now,
                    Description = helperRepository.OfficeLoanPreviousBalanceMsg(person.PreviousBalance),
                    Debit = person.PreviousBalance,
                    Credit = 0,
                    Balance = person.PreviousBalance - 0,
                    TransCode = trc,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.OfficeLoanPreviousBalanceMsg(person.PreviousBalance),
                    Amount = person.PreviousBalance,
                    Operation = Operation.Create
                };

                if (transactionRepository.AddTransactionLog(transaction))
                {
                    var res = transactionRepository.AddOfficeLoanLedger(personLedger);
                    if (res != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
        private int AddOfficePersonLoanCashLedgerDetails(string transCode, long PersonId, OfficePerson person)
        {
            if (dbContext != null)
            {
                CashLedger cashLedger = new CashLedger
                {
                    EntityId = PersonId,
                    EntityType = EntityType.OfficeLoan,
                    Date = DateTime.Now,
                    Description = helperRepository.OfficeLoanCashPreviousBalanceMsg(person.PreviousBalance),
                    VoucherNo = null,
                    Debit = 0,
                    Credit = person.PreviousBalance,
                    Balance = person.PreviousBalance - 0,
                    TransCode = transCode,
                    TransType = CashType.OfficeLoanPayment,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.OfficeLoanCashPreviousBalanceMsg(person.PreviousBalance),
                    Amount = person.PreviousBalance,
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
        public bool DeleteOfficePerson(long personId)
        {
            if (dbContext != null)
            {
                var m = dbContext.OfficePeople.FirstOrDefault(x => x.Id == personId);
                if (m != null)
                {
                    m.UserId = helperRepository.GetCurrentUserId();
                    m.UserName = helperRepository.GetUserName(m.UserId);
                    m.DeletedAt = DateTime.Now;
                    dbContext.OfficePeople.Update(m);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            return false;
        }
        public OfficePerson UpdateOfficePerson(OfficePerson person)
        {
            if (dbContext != null)
            {
                person.UserId = helperRepository.GetCurrentUserId();
                person.UserName = helperRepository.GetUserName(person.UserId);
                person.UpdatedAt = DateTime.Now;
                dbContext.OfficePeople.Update(person);
                dbContext.SaveChanges();
                return person;
            }
            return null;
        }


        // Office Loans Payment 
        public IEnumerable<OfficeLoanPayment> GetOfficePersonPayments()
        {
            if (dbContext != null)
            {
                var models = dbContext.OfficeLoanPayments.ToList();
                return models;
            }
            return null;
        }
        public IEnumerable<OfficeLoanPayment> GetOfficePersonPayments(long personId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                var models = dbContext.OfficeLoanPayments.ToList();
                if (personId > 0)
                {
                    models = models.Where(x => x.PersonId == personId).ToList();
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
        public OfficeLoanPayment GetOfficePersonPaymentbyId(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.OfficeLoanPayments.FirstOrDefault(x => x.Id == id);
                return model;
            }

            return null;
        }
        public OfficeLoanPayment AddOfficePersonPayment(OfficeLoanPayment officeLoanPayment)
        {
            if (dbContext != null)
            {
                officeLoanPayment.UserId = helperRepository.GetCurrentUserId();
                officeLoanPayment.UserName = helperRepository.GetUserName(officeLoanPayment.UserId);
                officeLoanPayment.CreatedAt = DateTime.Now;
                officeLoanPayment.UpdatedAt = DateTime.Now;

                if (officeLoanPayment.PaymentType == 1)
                {
                    officeLoanPayment.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == officeLoanPayment.BankId).BankName;
                }

                officeLoanPayment.PersonName = dbContext.OfficePeople.FirstOrDefault(x => x.Id == officeLoanPayment.PersonId).Name;

                var transCode = helperRepository.GetTransactionCode();

                officeLoanPayment.TransCode = transCode;
                //Add Office Loan ... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.OfficeLoanPayments.Add(officeLoanPayment);
                    dbContext.SaveChanges();

                    OfficeLoanLedger OfficeLedger = new OfficeLoanLedger
                    {
                        EntityId = officeLoanPayment.PersonId,
                        Date = DateTime.Now,
                        Description = helperRepository.OfficeLoanPaymentMsg(officeLoanPayment.Amount),
                        VoucherNo = null,
                        Debit = officeLoanPayment.Amount,
                        Credit = 0,
                        Balance = officeLoanPayment.Amount - 0,
                        TransCode = transCode
                    };

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.OfficeLoanPaymentMsg(officeLoanPayment.Amount),
                        Amount = officeLoanPayment.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.AddOfficeLoanLedger(OfficeLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (officeLoanPayment.PaymentType == 0)
                    {
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = officeLoanPayment.PersonId,
                            EntityType = EntityType.OfficeLoan,
                            Date = DateTime.Now,
                            Description = helperRepository.OfficeLoanPaymentMsg_Cash(officeLoanPayment.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = officeLoanPayment.Amount,
                            Balance = 0 - officeLoanPayment.Amount,
                            TransCode = transCode,
                            TransType = CashType.OfficeLoanPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.OfficeLoanPaymentMsg_Cash(officeLoanPayment.Amount),
                            Amount = officeLoanPayment.Amount,
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
                    else if (officeLoanPayment.PaymentType == 1)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = officeLoanPayment.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.OfficeLoanPaymentMsg_Bank(officeLoanPayment.Amount),
                            Debit = 0,
                            Credit = officeLoanPayment.Amount,
                            Balance = 0 - officeLoanPayment.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.OfficeLoanPaymentMsg_Bank(officeLoanPayment.Amount),
                            Amount = officeLoanPayment.Amount,
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
                    return officeLoanPayment;
                }
                catch
                {
                    transaction.Rollback();
                    return null;
                }
            }
            return null;
        }
        public OfficeLoanPayment EditOfficePersonPayment(OfficeLoanPayment OfficeLoan)
        {
            if (dbContext != null)
            {
                OfficeLoan.UserId = helperRepository.GetCurrentUserId();
                OfficeLoan.UserName = helperRepository.GetUserName(OfficeLoan.UserId);
                OfficeLoan.CreatedAt = OfficeLoan.CreatedAt;
                OfficeLoan.UpdatedAt = DateTime.Now;

                if (OfficeLoan.PaymentType == 1)
                {
                    OfficeLoan.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == OfficeLoan.BankId).BankName;
                }

                if (OfficeLoan.PaymentType == 0)
                {
                    OfficeLoan.BankId = 0;
                    OfficeLoan.BankName = "";
                }

                OfficeLoan.PersonName = dbContext.OfficePeople.FirstOrDefault(x => x.Id == OfficeLoan.PersonId).Name;
                var transCode = OfficeLoan.TransCode;

                //Edit Office Loan Payment ... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.OfficeLoanPayments.Update(OfficeLoan);
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

                    var OLledger = dbContext.OfficeLoanLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    OLledger.EntityId = OfficeLoan.PersonId;
                    OLledger.Debit = OfficeLoan.Amount;
                    OLledger.Balance = OfficeLoan.Amount - 0;
                    OLledger.Description = helperRepository.OfficeLoanPaymentMsg(OfficeLoan.Amount);


                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.OfficeLoanPaymentMsg(OfficeLoan.Amount),
                        Amount = OfficeLoan.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdateOfficeLoanLedger(OLledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (OfficeLoan.PaymentType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = OfficeLoan.PersonId,
                            EntityType = EntityType.OfficeLoan,
                            Date = OfficeLoan.Date,
                            Description = helperRepository.OfficeLoanPaymentMsg_Cash(OfficeLoan.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = OfficeLoan.Amount,
                            Balance = 0 - OfficeLoan.Amount,
                            TransCode = transCode,
                            TransType = CashType.OfficeLoanPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.OfficeLoanPaymentMsg_Cash(OfficeLoan.Amount),
                            Amount = OfficeLoan.Amount,
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
                    else if (OfficeLoan.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = OfficeLoan.BankId,
                            EntityType = EntityType.Bank,
                            Date = OfficeLoan.Date,
                            Description = helperRepository.OfficeLoanPaymentMsg_Bank(OfficeLoan.Amount),
                            Debit = 0,
                            Credit = OfficeLoan.Amount,
                            Balance = 0 - OfficeLoan.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.OfficeLoanPaymentMsg_Bank(OfficeLoan.Amount),
                            Amount = OfficeLoan.Amount,
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
                    return OfficeLoan;
                }
                catch
                {
                    transaction.Rollback();
                    return null;
                }

            }
            return null;
        }

        public IEnumerable<OfficeLoanReceive> GetOfficePersonLoanReceives()
        {
            if (dbContext != null)
            {
                var LoanReceivemodel = dbContext.OfficeLoanReceives.ToList();
                return LoanReceivemodel;
            }

            return null;
        }

        public IEnumerable<OfficeLoanReceive> GetOfficePersonLoanReceives(long personId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                var models = dbContext.OfficeLoanReceives.ToList();
                if (personId > 0)
                {
                    models = models.Where(x => x.PersonId == personId).ToList();
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

        public OfficeLoanReceive GetOfficePersonLoanReceivesById(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.OfficeLoanReceives.FirstOrDefault(x => x.Id == id);
                return model;
            }

            return null;
        }

        public OfficeLoanReceive AddOfficePersonLoanReceive(OfficeLoanReceive officeLoan)
        {
            if (dbContext != null)
            {
                officeLoan.UserId = helperRepository.GetCurrentUserId();
                officeLoan.UserName = helperRepository.GetUserName(officeLoan.UserId);
                officeLoan.CreatedAt = DateTime.Now;
                officeLoan.UpdatedAt = DateTime.Now;

                if (officeLoan.PaymentType == 1)
                {
                    officeLoan.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == officeLoan.BankId).BankName;
                }

                officeLoan.PersonName = dbContext.OfficePeople.FirstOrDefault(x => x.Id == officeLoan.PersonId).Name;
                var transCode = helperRepository.GetTransactionCode();
                officeLoan.TransCode = transCode;

                //Add Persons Receives... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.OfficeLoanReceives.Add(officeLoan);
                    dbContext.SaveChanges();

                    OfficeLoanLedger officeLoanLedger = new OfficeLoanLedger
                    {
                        EntityId = officeLoan.PersonId,
                        Date = DateTime.Now,
                        Description = helperRepository.OfficeLoanReceiveMsg(officeLoan.Amount),
                        VoucherNo = null,
                        Debit = 0,
                        Credit = officeLoan.Amount,
                        Balance = 0 - officeLoan.Amount,
                        TransCode = transCode
                    };

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.OfficeLoanReceiveMsg(officeLoan.Amount),
                        Amount = officeLoan.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.AddOfficeLoanLedger(officeLoanLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (officeLoan.PaymentType == 0)
                    {
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = officeLoan.PersonId,
                            EntityType = EntityType.OfficeLoan,
                            Date = DateTime.Now,
                            Description = helperRepository.OfficeLoanReceiveMsg_Cash(officeLoan.Amount),
                            VoucherNo = null,
                            Debit = officeLoan.Amount,
                            Credit = 0,
                            Balance = officeLoan.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.OfficeLoanReceive
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.OfficeLoanReceiveMsg_Cash(officeLoan.Amount),
                            Amount = officeLoan.Amount,
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
                    else if (officeLoan.PaymentType == 1)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = officeLoan.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.OfficeLoanReceiveMsg_Bank(officeLoan.Amount),
                            Debit = officeLoan.Amount,
                            Credit = 0,
                            Balance = officeLoan.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.OfficeLoanReceiveMsg_Bank(officeLoan.Amount),
                            Amount = officeLoan.Amount,
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
                    return officeLoan;
                }
                catch
                {
                    transaction.Rollback();
                    return null;
                }

            }
            return null;
        }

        public OfficeLoanReceive EditOfficePersonLoanReceives(OfficeLoanReceive officeLoan)
        {
            if (dbContext != null)
            {
                officeLoan.UserId = helperRepository.GetCurrentUserId();
                officeLoan.UserName = helperRepository.GetUserName(officeLoan.UserId);
                officeLoan.CreatedAt = officeLoan.CreatedAt;
                officeLoan.UpdatedAt = DateTime.Now;

                if (officeLoan.PaymentType == 1)
                {
                    officeLoan.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == officeLoan.BankId).BankName;
                }

                if (officeLoan.PaymentType == 0)
                {
                    officeLoan.BankId = 0;
                    officeLoan.BankName = "";
                }

                officeLoan.PersonName = dbContext.OfficePeople.FirstOrDefault(x => x.Id == officeLoan.PersonId).Name;
                var transCode = officeLoan.TransCode;

                //Edit Person Receives... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.OfficeLoanReceives.Update(officeLoan);
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

                    var oledger = dbContext.OfficeLoanLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    oledger.EntityId = officeLoan.PersonId;
                    oledger.Credit = officeLoan.Amount;
                    oledger.Balance = 0 - officeLoan.Amount;
                    oledger.Description = helperRepository.OfficeLoanReceiveMsg(officeLoan.Amount);

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.OfficeLoanReceiveMsg(officeLoan.Amount),
                        Amount = officeLoan.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdateOfficeLoanLedger(oledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (officeLoan.PaymentType == 0)
                    {

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = officeLoan.PersonId,
                            EntityType = EntityType.OfficeLoan,
                            Date = officeLoan.Date,
                            Description = helperRepository.OfficeLoanReceiveMsg_Cash(officeLoan.Amount),
                            VoucherNo = null,
                            Debit = officeLoan.Amount,
                            Credit = 0,
                            Balance = officeLoan.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.OfficeLoanReceive
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.OfficeLoanReceiveMsg_Cash(officeLoan.Amount),
                            Amount = officeLoan.Amount,
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
                    else if (officeLoan.PaymentType == 1)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = officeLoan.BankId,
                            EntityType = EntityType.Bank,
                            Date = officeLoan.Date,
                            Description = helperRepository.OfficeLoanReceiveMsg_Bank(officeLoan.Amount),
                            Debit = officeLoan.Amount,
                            Credit = 0,
                            Balance = officeLoan.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.OfficeLoanReceiveMsg_Bank(officeLoan.Amount),
                            Amount = officeLoan.Amount,
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
                    return officeLoan;
                }
                catch
                {
                    transaction.Rollback();
                    return null;
                }
            }
            return null;
        }
    }
}
