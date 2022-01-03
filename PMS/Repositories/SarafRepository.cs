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
    public class SarafRepository : ISarafRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;

        public SarafRepository(ApplicationDbContext dbContext,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository,
            ITransactionRepository transactionRepository)
        {
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
            this.transactionRepository = transactionRepository;
        }

        public IEnumerable<SarafViewModel> GetAll()
        {
            if (dbContext != null)
            {
                List<SarafViewModel> list = new List<SarafViewModel>();
                var models = dbContext.Sarafs.Where(x => x.DeletedAt == null).ToList();

                decimal pBalance = 0;

                foreach (var m in models)
                {
                    pBalance = dbContext.SarafLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Debit) - dbContext.BankLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Credit);

                    SarafViewModel model = new SarafViewModel
                    {
                        Id = m.Id,
                        SarafName = m.SarafName,
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
        public SarafDetailsViewModel GetSarafDetails(long id)
        {
            if (dbContext != null)
            {
                var sarafDetails = GetAll().FirstOrDefault(x => x.Id == id);
                var sarafLedgers = GetSarafLedgers().Where(x => x.EntityId == id).ToList();
                var sarafTransactions = dbContext.SarafTransactions.Where(x => x.SarafId == id).ToList();

                SarafDetailsViewModel model = new SarafDetailsViewModel
                {
                    sarafViewModel = sarafDetails,
                    sarafTransactions = sarafTransactions,
                    SarafsLedgers = sarafLedgers
                };

                return model;
            }
            return null;
        }
        public IEnumerable<SarafsLedgerViewModel> GetSarafLedgers(long sarafId = 0, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (dbContext != null)
            {
                List<SarafsLedgerViewModel> list = new List<SarafsLedgerViewModel>();
                var models = dbContext.BankLedgers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;

                foreach (var m in models)
                {
                    pBalance = m.Debit - m.Credit;

                    SarafsLedgerViewModel model = new SarafsLedgerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        EntityId = m.EntityId,
                        EntityName = dbContext.Sarafs.FirstOrDefault(x => x.Id == m.EntityId).SarafName,
                        EntityAccountName = dbContext.Sarafs.FirstOrDefault(x => x.Id == m.EntityId).AccountName,
                        EntityAccountNo = dbContext.Sarafs.FirstOrDefault(x => x.Id == m.EntityId).AccountNo,
                        EntityBranch = dbContext.Sarafs.FirstOrDefault(x => x.Id == m.EntityId).Branch,
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

                if (sarafId != 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.EntityId == sarafId && x.Date >= startDate && x.Date <= endDate).ToList();

                }
                else if (sarafId == 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
                else if (sarafId != 0 && startDate == null && endDate == null)
                {
                    list = list.Where(x => x.EntityId == sarafId).ToList();
                }
                else
                {
                    //do nothing
                }

                return list;
            }

            return null;
        }
        public Saraf GetByIdSaraf(long id)
        {
            if (dbContext != null)
            {
                var saraf = dbContext.Sarafs.FirstOrDefault(x => x.Id == id);
                return saraf;
            }
            return null;
        }
        public Saraf AddSaraf(Saraf saraf)
        {
            if (dbContext != null)
            {
                saraf.CreatedAt = DateTime.Now;
                saraf.UpdatedAt = DateTime.Now;

                dbContext.Sarafs.Add(saraf);
                dbContext.SaveChanges();
                return saraf;
            }
            return null;
        }
        public Saraf UpdateSaraf(Saraf saraf)
        {
            if (dbContext != null)
            {
                saraf.UpdatedAt = DateTime.Now;
                dbContext.Sarafs.Update(saraf);
                dbContext.SaveChanges();
                return saraf;
            }
            return null;
        }
        public SarafTransaction AddSarafTransaction(SarafTransaction sarafTransaction)
        {
            if (dbContext != null)
            {

                sarafTransaction.UserId = pmsHelper.GetCurrentUserId();
                sarafTransaction.UserName = pmsHelper.GetUserName(sarafTransaction.UserId);
                sarafTransaction.CreatedAt = DateTime.Now;
                sarafTransaction.UpdatedAt = DateTime.Now;

                decimal tcr = 0;
                decimal tdr = 0;
                int tty = 0;

                decimal ccr = 0;
                decimal cdr = 0;
                int cty = 0;

                if (sarafTransaction.TransType == 0)
                {
                    tcr = 0;
                    tdr = sarafTransaction.Amount;
                    tty = 0;

                    ccr = sarafTransaction.Amount;
                    cdr = 0;
                    cty = 1;
                }
                else
                {
                    tcr = sarafTransaction.Amount;
                    tdr = 0;
                    tty = 1;

                    ccr = 0;
                    cdr = sarafTransaction.Amount;
                    cty = 0;
                }


                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var sarafTransactionId = AddSarafTransactionDetails(sarafTransaction);

                if (sarafTransactionId != 0)
                {
                    var transCode = helperRepository.GetTransactionCode();

                    var spl = AddSarafLedgerDetails(transCode, sarafTransactionId, sarafTransaction, tcr, tdr, tty);

                    if (spl != 0)
                    {
                        var spcl = AddSarafCashLedgerDetails(transCode, sarafTransactionId, sarafTransaction, ccr, cdr, cty);
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

                return sarafTransaction;
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
        //Private Methods

        private long AddSarafTransactionDetails(SarafTransaction sarafTransaction)
        {
            if (dbContext != null)
            {
                dbContext.SarafTransactions.Add(sarafTransaction);
                dbContext.SaveChanges();

                var maxId = dbContext.BankTransactions.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        private int AddSarafLedgerDetails(string trc, long sarafTransactionId, SarafTransaction sarafTransaction, decimal cr, decimal dr, int ty)
        {
            if (dbContext != null)
            {

                string msg = "";

                if (ty == 0)
                {
                    msg = helperRepository.SarafDebitMsg(sarafTransaction.SarafTransactionId, sarafTransaction.Amount);
                }
                else
                {
                    msg = helperRepository.SarafCreditMsg(sarafTransaction.SarafTransactionId, sarafTransaction.Amount);
                }

                SarafLedger sarafLedger = new SarafLedger
                {
                    EntityId = sarafTransaction.SarafId,
                    EntityType = EntityType.Saraf,
                    Date = DateTime.Now,
                    Description = msg,
                    Debit = dr,
                    Credit = cr,
                    Balance = dr - cr,
                    TransCode = trc,
                    SarafTransactionId = sarafTransactionId
                };

                Transaction transaction = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = (TType)ty,
                    Description = msg,
                    Amount = sarafTransaction.Amount,
                    Operation = Operation.Create
                };

                if (transactionRepository.AddTransactionLog(transaction))
                {
                    var res = transactionRepository.AddSarafLedger(sarafLedger);
                    if (res != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private int AddSarafCashLedgerDetails(string transCode, long sarafTransactionId, SarafTransaction sarafTransaction, decimal cr, decimal dr, int ty)
        {
            if (dbContext != null)
            {
                string msg = "";
                if (ty == 0)
                {
                    msg = helperRepository.SarafCashDebitMsg(sarafTransaction.SarafTransactionId, sarafTransaction.Amount);
                }
                else
                {
                    msg = helperRepository.SarafCashCreditMsg(sarafTransaction.SarafTransactionId, sarafTransaction.Amount);
                }

                CashLedger cashLedger = new CashLedger
                {
                    EntityId = sarafTransaction.SarafId,
                    EntityType = EntityType.Saraf,
                    Date = DateTime.Now,
                    Description = msg,
                    VoucherNo = sarafTransaction.SarafTransactionId,
                    Debit = dr,
                    Credit = cr,
                    Balance = dr - cr,
                    TransCode = transCode,
                    TransType = CashType.SarafBalance,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = (TType)ty,
                    Description = msg,
                    Amount = sarafTransaction.Amount,
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

        public SarafTransaction AddSarafTransaction_Purchase(SarafTransaction sarafTransaction, string transCode)
        {
            if (dbContext != null)
            {

                sarafTransaction.UserId = pmsHelper.GetCurrentUserId();
                sarafTransaction.UserName = pmsHelper.GetUserName(sarafTransaction.UserId);
                sarafTransaction.CreatedAt = DateTime.Now;
                sarafTransaction.UpdatedAt = DateTime.Now;

                decimal tcr = 0;
                decimal tdr = 0;
                int tty = 0;

                decimal ccr = 0;
                decimal cdr = 0;
                int cty = 0;

                if (sarafTransaction.TransType == 0)
                {
                    tcr = 0;
                    tdr = sarafTransaction.Amount;
                    tty = 0;

                    ccr = sarafTransaction.Amount;
                    cdr = 0;
                    cty = 1;
                }
                else
                {
                    tcr = sarafTransaction.Amount;
                    tdr = 0;
                    tty = 1;

                    ccr = 0;
                    cdr = sarafTransaction.Amount;
                    cty = 0;
                }


                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    var bankTransactionId = AddSarafTransactionDetails(sarafTransaction);

                    if (bankTransactionId != 0)
                    {

                        var spl = AddSarafLedgerDetails(transCode, bankTransactionId, sarafTransaction, tcr, tdr, tty);

                        if (spl != 0)
                        {
                            var spcl = AddSarafCashLedgerDetails(transCode, bankTransactionId, sarafTransaction, ccr, cdr, cty);
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

                    return sarafTransaction;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

    }
}
