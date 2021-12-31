using PMS.Data;
using PMS.Data.Enums;
using PMS.Models.Finance;
using PMS.Models.PersonalLoan;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.Finance;
using PMS.ViewModels.PersonalLoanViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class PersonalLoanRepository : IPersonalLoanRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;

        public PersonalLoanRepository(ApplicationDbContext dbContext,
            IHelperRepository helperRepository,
            ITransactionRepository transactionRepository)
        {
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<PersonViewModel> GetAllPerson()
        {
            if (dbContext != null)
            {
                List<PersonViewModel> list = new List<PersonViewModel>();
                var models = dbContext.Persons.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = dbContext.PersonalLoanLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Debit) - dbContext.PersonalLoanLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Credit);

                    PersonViewModel model = new PersonViewModel
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

        public PersonalLoanDetailsViewModel GetPersonDetails(long id)
        {
            if (dbContext != null)
            {
                var person = dbContext.Persons.FirstOrDefault(x => x.Id == id);
                if (person != null)
                {
                    var personViewModel = GetByIdPerson(id);
                    var personLedger = GetPersonLedgers(id, null, null);

                    PersonalLoanDetailsViewModel model = new PersonalLoanDetailsViewModel()
                    {
                        PersonalLoanViewModel = personViewModel,
                        PersonLedgerViewModels = personLedger
                    };

                    return model;
                }
                return null;
            }
            return null;
        }

        public PersonViewModel GetByIdPerson(long id)
        {
            if (dbContext != null)
            {
                var m = dbContext.Persons.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                decimal pBalance = 0;
                string bFlg = "+";
                pBalance = dbContext.PersonalLoanLedgers.Where(x => x.EntityId == id).Sum(x => x.Debit) - dbContext.PersonalLoanLedgers.Where(x => x.EntityId == id).Sum(x => x.Credit);

                PersonViewModel model = new PersonViewModel
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

        public Person GetByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                var person = dbContext.Persons.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                return person;
            }
            return null;
        }

        public IEnumerable<PersonLedgerViewModel> GetPersonLedgers(long personId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                List<PersonLedgerViewModel> list = new List<PersonLedgerViewModel>();
                var models = dbContext.PersonalLoanLedgers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = m.Debit - m.Credit;
                    string addr = dbContext.Persons.FirstOrDefault(x => x.Id == m.EntityId).Address;
                    PersonLedgerViewModel model = new PersonLedgerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        EntityId = m.EntityId,
                        EntityName = dbContext.Persons.FirstOrDefault(x => x.Id == m.EntityId).Name,
                        EntityPhone = dbContext.Persons.FirstOrDefault(x => x.Id == m.EntityId).Phone,
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
        public Person AddPerson(Person person)
        {
            if (dbContext != null)
            {
                person.UserId = helperRepository.GetCurrentUserId();
                person.UserName = helperRepository.GetUserName(person.UserId);
                person.CreatedAt = DateTime.Now;
                person.UpdatedAt = DateTime.Now;

                if (person.PreviousBalance == 0)
                {
                    dbContext.Persons.Add(person);
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

                            var spl = AddPersonLedgerDetails(transCode, PersonId, person);

                            if (spl != 0)
                            {
                                var spcl = AddPersonLoanrCashLedgerDetails(transCode, PersonId, person);
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
        public bool DeletePerson(long personId)
        {
            if (dbContext != null)
            {
                var m = dbContext.Persons.FirstOrDefault(x => x.Id == personId);
                if (m != null)
                {
                    m.UserId = helperRepository.GetCurrentUserId();
                    m.UserName = helperRepository.GetUserName(m.UserId);
                    m.DeletedAt = DateTime.Now;
                    dbContext.Persons.Update(m);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            return false;
        }
        public Person UpdatePerson(Person person)
        {
            if (dbContext != null)
            {
                person.UserId = helperRepository.GetCurrentUserId();
                person.UserName = helperRepository.GetUserName(person.UserId);
                person.UpdatedAt = DateTime.Now;
                dbContext.Persons.Update(person);
                dbContext.SaveChanges();
                return person;
            }
            return null;
        }

        // Local methods
        private long AddPersonDetails(Person person)
        {
            if (dbContext != null)
            {
                dbContext.Persons.Add(person);
                dbContext.SaveChanges();
                var maxId = dbContext.Persons.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }
        private int AddPersonLedgerDetails(string trc, long PersonId, Person person)
        {
            if (dbContext != null)
            {
                PersonalLoanLedger personLedger = new PersonalLoanLedger
                {
                    EntityId = PersonId,
                    Date = DateTime.Now,
                    Description = helperRepository.PersonLoanPreviousBalanceMsg(person.PreviousBalance),
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
                    Description = helperRepository.PersonLoanPreviousBalanceMsg(person.PreviousBalance),
                    Amount = person.PreviousBalance,
                    Operation = Operation.Create
                };

                if (transactionRepository.AddTransactionLog(transaction))
                {
                    var res = transactionRepository.AddPersonalLoanLedger(personLedger);
                    if (res != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
        private int AddPersonLoanrCashLedgerDetails(string transCode, long PersonId, Person person)
        {
            if (dbContext != null)
            {
                CashLedger cashLedger = new CashLedger
                {
                    EntityId = PersonId,
                    EntityType = EntityType.PersonLoan,
                    Date = DateTime.Now,
                    Description = helperRepository.PersonLoanCashPreviousBalanceMsg(person.PreviousBalance),
                    VoucherNo = null,
                    Debit = 0,
                    Credit = person.PreviousBalance,
                    Balance = person.PreviousBalance - 0,
                    TransCode = transCode,
                    TransType = CashType.PersonalLoanPayment,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.PersonLoanCashPreviousBalanceMsg(person.PreviousBalance),
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


        //Personal Loan Payment Modules
        public IEnumerable<PersonalLoanPayment> GetPersonPayments()
        {
            if (dbContext != null)
            {
                var models = dbContext.PersonalLoanPayments.ToList();
                return models;
            }
            return null;
        }

        public IEnumerable<PersonalLoanPayment> GetPersonPayments(long personId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                var models = dbContext.PersonalLoanPayments.ToList();
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

        public PersonalLoanPayment GetPersonPaymentbyId(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.PersonalLoanPayments.FirstOrDefault(x => x.Id == id);
                return model;
            }

            return null;
        }
        public PersonalLoanPayment AddPersonPayment(PersonalLoanPayment personalLoanPayment)
        {
            if (dbContext != null)
            {
                personalLoanPayment.UserId = helperRepository.GetCurrentUserId();
                personalLoanPayment.UserName = helperRepository.GetUserName(personalLoanPayment.UserId);
                personalLoanPayment.CreatedAt = DateTime.Now;
                personalLoanPayment.UpdatedAt = DateTime.Now;

                if (personalLoanPayment.PaymentType == 1)
                {
                    personalLoanPayment.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == personalLoanPayment.BankId).BankName;
                }

                personalLoanPayment.PersonName = dbContext.Persons.FirstOrDefault(x => x.Id == personalLoanPayment.PersonId).Name;

                var transCode = helperRepository.GetTransactionCode();

                personalLoanPayment.TransCode = transCode;
                //Add Partner... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.PersonalLoanPayments.Add(personalLoanPayment);
                    dbContext.SaveChanges();

                    PersonalLoanLedger PersonLedger = new PersonalLoanLedger
                    {
                        EntityId = personalLoanPayment.PersonId,
                        Date = DateTime.Now,
                        Description = helperRepository.PersonLoanPaymentMsg(personalLoanPayment.Amount),
                        VoucherNo = null,
                        Debit = personalLoanPayment.Amount,
                        Credit = 0,
                        Balance = personalLoanPayment.Amount - 0,
                        TransCode = transCode
                    };

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.PersonLoanPaymentMsg(personalLoanPayment.Amount),
                        Amount = personalLoanPayment.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.AddPersonalLoanLedger(PersonLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (personalLoanPayment.PaymentType == 0)
                    {
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = personalLoanPayment.PersonId,
                            EntityType = EntityType.PersonLoan,
                            Date = DateTime.Now,
                            Description = helperRepository.PersonLoanPaymentMsg_Cash(personalLoanPayment.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = personalLoanPayment.Amount,
                            Balance = 0 - personalLoanPayment.Amount,
                            TransCode = transCode,
                            TransType = CashType.PersonalLoanPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.PersonLoanPaymentMsg_Cash(personalLoanPayment.Amount),
                            Amount = personalLoanPayment.Amount,
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
                    else if (personalLoanPayment.PaymentType == 1)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = personalLoanPayment.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.PersonLoanPaymentMsg_Bank(personalLoanPayment.Amount),
                            Debit = 0,
                            Credit = personalLoanPayment.Amount,
                            Balance = 0 - personalLoanPayment.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.PersonLoanPaymentMsg_Bank(personalLoanPayment.Amount),
                            Amount = personalLoanPayment.Amount,
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
                    return personalLoanPayment;
                }
                catch
                {
                    transaction.Rollback();
                    return null;
                }
            }
            return null;
        }
        public PersonalLoanPayment EditPersonPayment(PersonalLoanPayment PersonLoan)
        {
            if (dbContext != null)
            {
                PersonLoan.UserId = helperRepository.GetCurrentUserId();
                PersonLoan.UserName = helperRepository.GetUserName(PersonLoan.UserId);
                PersonLoan.CreatedAt = PersonLoan.CreatedAt;
                PersonLoan.UpdatedAt = DateTime.Now;

                if (PersonLoan.PaymentType == 1)
                {
                    PersonLoan.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == PersonLoan.BankId).BankName;
                }

                if (PersonLoan.PaymentType == 0)
                {
                    PersonLoan.BankId = 0;
                    PersonLoan.BankName = "";
                }

                PersonLoan.PersonName = dbContext.Persons.FirstOrDefault(x => x.Id == PersonLoan.PersonId).Name;
                var transCode = PersonLoan.TransCode;

                //Edit Person Receives ... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.PersonalLoanPayments.Update(PersonLoan);
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

                    var sledger = dbContext.PersonalLoanLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    sledger.EntityId = PersonLoan.PersonId;
                    sledger.Debit = PersonLoan.Amount;
                    sledger.Balance = PersonLoan.Amount - 0;
                    sledger.Description = helperRepository.PersonLoanPaymentMsg(PersonLoan.Amount);


                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.PersonLoanPaymentMsg(PersonLoan.Amount),
                        Amount = PersonLoan.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdatePersonalLoanLedger(sledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (PersonLoan.PaymentType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = PersonLoan.PersonId,
                            EntityType = EntityType.PersonLoan,
                            Date = PersonLoan.Date,
                            Description = helperRepository.PersonLoanPaymentMsg_Cash(PersonLoan.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = PersonLoan.Amount,
                            Balance = 0 - PersonLoan.Amount,
                            TransCode = transCode,
                            TransType = CashType.PersonalLoanPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.PersonLoanPaymentMsg_Cash(PersonLoan.Amount),
                            Amount = PersonLoan.Amount,
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
                    else if (PersonLoan.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = PersonLoan.BankId,
                            EntityType = EntityType.Bank,
                            Date = PersonLoan.Date,
                            Description = helperRepository.PersonLoanPaymentMsg_Bank(PersonLoan.Amount),
                            Debit = 0,
                            Credit = PersonLoan.Amount,
                            Balance = 0 - PersonLoan.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.PersonLoanPaymentMsg_Bank(PersonLoan.Amount),
                            Amount = PersonLoan.Amount,
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
                    return PersonLoan;
                }
                catch
                {
                    transaction.Rollback();
                    return null;
                }

            }
            return null;
        }
        public bool DeletePersonPayment(long personId)
        {
            throw new NotImplementedException();
        }


        //Perosnal Loan Receive 
        public IEnumerable<PersonalLoanReceive> GetPersonLoanReceives()
        {
            if (dbContext != null)
            {
                var LoanReceivemodel = dbContext.PersonalLoanReceives.ToList();
                return LoanReceivemodel;
            }

            return null;
        }

        public IEnumerable<PersonalLoanReceive> GetPersonLoanReceives(long personId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                var models = dbContext.PersonalLoanReceives.ToList();
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

        public PersonalLoanReceive GetPersonLoanReceivesById(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.PersonalLoanReceives.FirstOrDefault(x => x.Id == id);
                return model;
            }

            return null;
        }

        public PersonalLoanReceive AddPersonLoanReceive(PersonalLoanReceive personalLoan)
        {
            if (dbContext != null)
            {
                personalLoan.UserId = helperRepository.GetCurrentUserId();
                personalLoan.UserName = helperRepository.GetUserName(personalLoan.UserId);
                personalLoan.CreatedAt = DateTime.Now;
                personalLoan.UpdatedAt = DateTime.Now;

                if (personalLoan.PaymentType == 1)
                {
                    personalLoan.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == personalLoan.BankId).BankName;
                }

                personalLoan.PersonName = dbContext.Persons.FirstOrDefault(x => x.Id == personalLoan.PersonId).Name;
                var transCode = helperRepository.GetTransactionCode();
                personalLoan.TransCode = transCode;

                //Add Persons Receives... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.PersonalLoanReceives.Add(personalLoan);
                    dbContext.SaveChanges();

                    PersonalLoanLedger personLedger = new PersonalLoanLedger
                    {
                        EntityId = personalLoan.PersonId,
                        Date = DateTime.Now,
                        Description = helperRepository.PersonLoanReceiveMsg(personalLoan.Amount),
                        VoucherNo = null,
                        Debit = 0,
                        Credit = personalLoan.Amount,
                        Balance = 0 - personalLoan.Amount,
                        TransCode = transCode
                    };

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.PersonLoanReceiveMsg(personalLoan.Amount),
                        Amount = personalLoan.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.AddPersonalLoanLedger(personLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (personalLoan.PaymentType == 0)
                    {
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = personalLoan.PersonId,
                            EntityType = EntityType.PersonLoan,
                            Date = DateTime.Now,
                            Description = helperRepository.PersonLoanReceiveMsg_Cash(personalLoan.Amount),
                            VoucherNo = null,
                            Debit = personalLoan.Amount,
                            Credit = 0,
                            Balance = personalLoan.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.PersonalLoanPayment
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.PersonLoanReceiveMsg_Cash(personalLoan.Amount),
                            Amount = personalLoan.Amount,
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
                    else if (personalLoan.PaymentType == 1)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = personalLoan.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.PersonLoanReceiveMsg_Bank(personalLoan.Amount),
                            Debit = personalLoan.Amount,
                            Credit = 0,
                            Balance = personalLoan.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.PersonLoanReceiveMsg_Bank(personalLoan.Amount),
                            Amount = personalLoan.Amount,
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
                    return personalLoan;
                }
                catch
                {
                    transaction.Rollback();
                    return null;
                }

            }
            return null;
        }
        public PersonalLoanReceive EditPersonLoanReceives(PersonalLoanReceive personalLoan)
        {
            if (dbContext != null)
            {
                personalLoan.UserId = helperRepository.GetCurrentUserId();
                personalLoan.UserName = helperRepository.GetUserName(personalLoan.UserId);
                personalLoan.CreatedAt = personalLoan.CreatedAt;
                personalLoan.UpdatedAt = DateTime.Now;

                if (personalLoan.PaymentType == 1)
                {
                    personalLoan.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == personalLoan.BankId).BankName;
                }

                if (personalLoan.PaymentType == 0)
                {
                    personalLoan.BankId = 0;
                    personalLoan.BankName = "";
                }

                personalLoan.PersonName = dbContext.Persons.FirstOrDefault(x => x.Id == personalLoan.PersonId).Name;
                var transCode = personalLoan.TransCode;

                //Edit Person Receives... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.PersonalLoanReceives.Update(personalLoan);
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

                    var pledger = dbContext.PersonalLoanLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    pledger.EntityId = personalLoan.PersonId;
                    pledger.Credit = personalLoan.Amount;
                    pledger.Balance = 0 - personalLoan.Amount;
                    pledger.Description = helperRepository.PersonLoanReceiveMsg(personalLoan.Amount);


                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.PersonLoanReceiveMsg(personalLoan.Amount),
                        Amount = personalLoan.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdatePersonalLoanLedger(pledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (personalLoan.PaymentType == 0)
                    {

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = personalLoan.PersonId,
                            EntityType = EntityType.PersonLoan,
                            Date = personalLoan.Date,
                            Description = helperRepository.PersonLoanReceiveMsg_Cash(personalLoan.Amount),
                            VoucherNo = null,
                            Debit = personalLoan.Amount,
                            Credit = 0,
                            Balance = personalLoan.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.PersonalLoanReceive
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.PersonLoanReceiveMsg_Cash(personalLoan.Amount),
                            Amount = personalLoan.Amount,
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
                    else if (personalLoan.PaymentType == 1)
                    {

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = personalLoan.BankId,
                            EntityType = EntityType.Bank,
                            Date = personalLoan.Date,
                            Description = helperRepository.PersonLoanReceiveMsg_Bank(personalLoan.Amount),
                            Debit = personalLoan.Amount,
                            Credit = 0,
                            Balance = personalLoan.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.PersonLoanReceiveMsg_Bank(personalLoan.Amount),
                            Amount = personalLoan.Amount,
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
                    return personalLoan;
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
