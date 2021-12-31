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
    public class BankRepository : IBankRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;

        public BankRepository(ApplicationDbContext _dbContext,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository,
            ITransactionRepository transactionRepository)
        {
            dbContext = _dbContext;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
            this.transactionRepository = transactionRepository;
        }
        public Bank AddBank(Bank bank)
        {
            if (dbContext != null)
            {
                bank.CreatedAt = DateTime.Now;
                bank.UpdatedAt = DateTime.Now;

                dbContext.Banks.Add(bank);
                dbContext.SaveChanges();
                return bank;
            }
            return null;
        }

        public IEnumerable<BankViewModel> GetAll()
        {
            if (dbContext != null)
            {
                List<BankViewModel> list = new List<BankViewModel>();
                var models = dbContext.Banks.Where(x => x.DeletedAt == null).ToList();

                decimal pBalance = 0;

                foreach (var m in models)
                {
                    pBalance = dbContext.BankLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Debit) - dbContext.BankLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Credit);

                    BankViewModel model = new BankViewModel
                    {
                        Id = m.Id,
                        BankName = m.BankName,
                        AccountName = m.AccountName,
                        AccountNo = m.AccountNo,
                        Branch = m.Branch,
                        Description = m.Description,
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt,
                        CurrentAmount = pBalance,
                        UserId = m.UserId,
                        UserName = pmsHelper.GetUserName(m.UserId)
                    };
                    list.Add(model);
                }

                return list;
            }

            return null;
        }

        public Bank GetByIdBank(long id)
        {
            if (dbContext != null)
            {
                var bank = dbContext.Banks.FirstOrDefault(x => x.Id == id);

                return bank;
            }
            return null;
        }

        public BankDetailsViewModel GetBankDetails(long id)
        {
            if (dbContext != null)
            {
                var bankDetails = GetAll().FirstOrDefault(x => x.Id == id);
                var bankLedgers = GetBankLedgers().Where(x => x.EntityId == id).ToList();
                var bankTransaction = dbContext.BankTransactions.Where(x => x.BankId == id).ToList();

                BankDetailsViewModel model = new BankDetailsViewModel
                {
                    bankViewModel = bankDetails,
                    bankTransactions = bankTransaction,
                    banksLedger = bankLedgers
                };

                return model;

            }
            return null;
        }

        public Bank UpdateBank(Bank bank)
        {
            if (dbContext != null)
            {
                bank.UpdatedAt = DateTime.Now;
                dbContext.Banks.Update(bank);
                dbContext.SaveChanges();
                return bank;
            }
            return null;
        }


        public IEnumerable<BanksLedgerViewModel> GetBankLedgers(long bankId = 0, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (dbContext != null)
            {
                List<BanksLedgerViewModel> list = new List<BanksLedgerViewModel>();
                var models = dbContext.BankLedgers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;

                foreach (var m in models)
                {
                    pBalance = m.Debit - m.Credit;

                    BanksLedgerViewModel model = new BanksLedgerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        EntityId = m.EntityId,
                        EntityName = dbContext.Banks.FirstOrDefault(x => x.Id == m.EntityId).BankName,
                        EntityAccountName = dbContext.Banks.FirstOrDefault(x => x.Id == m.EntityId).AccountName,
                        EntityAccountNo = dbContext.Banks.FirstOrDefault(x => x.Id == m.EntityId).AccountNo,
                        EntityBranch = dbContext.Banks.FirstOrDefault(x => x.Id == m.EntityId).Branch,
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
                        UserId = m.UserId,
                        UserName = pmsHelper.GetUserName(m.UserId)
                    };

                    list.Add(model);
                }

                if (bankId != 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.EntityId == bankId && x.Date >= startDate && x.Date <= endDate).ToList();

                }
                else if (bankId == 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
                else if (bankId != 0 && startDate == null && endDate == null)
                {
                    list = list.Where(x => x.EntityId == bankId).ToList();
                }
                else
                {
                    //do nothing
                }

                return list;
            }

            return null;
        }

        public BankTransaction AddBankTransaction(BankTransaction bankTransaction)
        {
            if (dbContext != null)
            {

                bankTransaction.UserId = pmsHelper.GetCurrentUserId();
                bankTransaction.UserName = pmsHelper.GetUserName(bankTransaction.UserId);
                bankTransaction.CreatedAt = DateTime.Now;
                bankTransaction.UpdatedAt = DateTime.Now;

                decimal tcr = 0;
                decimal tdr = 0;
                int tty = 0;

                decimal ccr = 0;
                decimal cdr = 0;
                int cty = 0;

                if (bankTransaction.TransType == 0)
                {
                    tcr = 0;
                    tdr = bankTransaction.Amount;
                    tty = 0;

                    ccr = bankTransaction.Amount;
                    cdr = 0;
                    cty = 1;
                }
                else
                {
                    tcr = bankTransaction.Amount;
                    tdr = 0;
                    tty = 1;

                    ccr = 0;
                    cdr = bankTransaction.Amount;
                    cty = 0;
                }


                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var bankTransactionId = AddBankTransactionDetails(bankTransaction);

                if (bankTransactionId != 0)
                {
                    var transCode = helperRepository.GetTransactionCode();

                    var spl = AddBankLedgerDetails(transCode, bankTransactionId, bankTransaction, tcr, tdr, tty);

                    if (spl != 0)
                    {
                        var spcl = AddBankCashLedgerDetails(transCode, bankTransactionId, bankTransaction, ccr, cdr, cty);
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

                return bankTransaction;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }
            else
            {
                return null;
            }
        }

        public BankTransaction AddBankTransaction_Purchase(BankTransaction bankTransaction, string transCode)
        {
            if (dbContext != null)
            {

                bankTransaction.UserId = pmsHelper.GetCurrentUserId();
                bankTransaction.UserName = pmsHelper.GetUserName(bankTransaction.UserId);
                bankTransaction.CreatedAt = DateTime.Now;
                bankTransaction.UpdatedAt = DateTime.Now;

                decimal tcr = 0;
                decimal tdr = 0;
                int tty = 0;

                decimal ccr = 0;
                decimal cdr = 0;
                int cty = 0;

                if (bankTransaction.TransType == 0)
                {
                    tcr = 0;
                    tdr = bankTransaction.Amount;
                    tty = 0;

                    ccr = bankTransaction.Amount;
                    cdr = 0;
                    cty = 1;
                }
                else
                {
                    tcr = bankTransaction.Amount;
                    tdr = 0;
                    tty = 1;

                    ccr = 0;
                    cdr = bankTransaction.Amount;
                    cty = 0;
                }


                //using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var bankTransactionId = AddBankTransactionDetails(bankTransaction);

                if (bankTransactionId != 0)
                {

                    var spl = AddBankLedgerDetails(transCode, bankTransactionId, bankTransaction, tcr, tdr, tty);

                    if (spl != 0)
                    {
                        var spcl = AddBankCashLedgerDetails(transCode, bankTransactionId, bankTransaction, ccr, cdr, cty);
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

                //transaction.Commit();

                return bankTransaction;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }
            else
            {
                return null;
            }
        }

        private long AddBankTransactionDetails(BankTransaction bankTransaction)
        {
            if (dbContext != null)
            {
                dbContext.BankTransactions.Add(bankTransaction);
                dbContext.SaveChanges();

                var maxId = dbContext.BankTransactions.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        private int AddBankLedgerDetails(string trc, long bankTransactionId, BankTransaction bankTransaction, decimal cr, decimal dr, int ty)
        {
            if (dbContext != null)
            {

                string msg = "";

                if (ty == 0)
                {
                    msg = helperRepository.BankDebitMsg(bankTransaction.BankTransactionId, bankTransaction.Amount);
                }
                else
                {
                    msg = helperRepository.BankCreditMsg(bankTransaction.BankTransactionId, bankTransaction.Amount);
                }

                BankLedger bankLedger = new BankLedger
                {
                    EntityId = bankTransaction.BankId,
                    EntityType = EntityType.Bank,
                    Date = DateTime.Now,
                    Description = msg,
                    Debit = dr,
                    Credit = cr,
                    Balance = dr - cr,
                    TransCode = trc,
                    BankTransactionId = bankTransactionId
                };

                Transaction transaction = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = (TType)ty,
                    Description = msg,
                    Amount = bankTransaction.Amount,
                    Operation = Operation.Create
                };

                if (transactionRepository.AddTransactionLog(transaction))
                {
                    var res = transactionRepository.AddBankLedger(bankLedger);
                    if (res != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }


        private int AddBankCashLedgerDetails(string transCode, long bankTransactionId, BankTransaction bankTransaction, decimal cr, decimal dr, int ty)
        {
            if (dbContext != null)
            {
                string msg = "";
                if (ty == 0)
                {
                    msg = helperRepository.BankCashDebitMsg(bankTransaction.BankTransactionId, bankTransaction.Amount);
                }
                else
                {
                    msg = helperRepository.BankCashCreditMsg(bankTransaction.BankTransactionId, bankTransaction.Amount);
                }

                CashLedger cashLedger = new CashLedger
                {
                    EntityId = bankTransaction.BankId,
                    EntityType = EntityType.Bank,
                    Date = DateTime.Now,
                    Description = msg,
                    VoucherNo = bankTransaction.BankTransactionId,
                    Debit = dr,
                    Credit = cr,
                    Balance = dr - cr,
                    TransCode = transCode,
                    TransType = CashType.BankBalance,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = (TType)ty,
                    Description = msg,
                    Amount = bankTransaction.Amount,
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

    }
}
