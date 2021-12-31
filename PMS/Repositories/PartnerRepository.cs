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
    public class PartnerRepository : IPartnerRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;
        private readonly IProductRepository productRepository;

        public PartnerRepository(ApplicationDbContext dbContext,
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

        public PartnerDetailsViewModel GetPartnerDetails(long id)
        {
            if (dbContext != null)
            {
                var partner = dbContext.Partners.FirstOrDefault(x => x.Id == id);
                if (partner != null)
                {
                    var partnerViewModel = GetByIdPartner(id);
                    var partnerLedger = GetPartnerLedgers(id, null, null).OrderByDescending(x => x.Id).ToList();
                    var partnerInvestments = dbContext.PartnerInvestments.Where(x => x.PartnerId == id).OrderByDescending(x => x.Id).ToList();
                    var partnerPayments = dbContext.PartnerPayments.Where(x => x.PartnerId == id).OrderByDescending(x => x.Id).ToList();

                    PartnerDetailsViewModel model = new PartnerDetailsViewModel()
                    {
                        PartnerDetails = partnerViewModel,
                        PartnerLedgerDetails = partnerLedger,
                        ProductInvestmentDetails = partnerInvestments,
                        PartnerPaymentDetails = partnerPayments

                    };
                    return model;
                }
                return null;
            }
            return null;
        }

        public Partner AddPartner(Partner partner)
        {
            if (dbContext != null)
            {

                partner.UserId = pmsHelper.GetCurrentUserId();
                partner.UserName = pmsHelper.GetUserName(partner.UserId);
                partner.CreatedAt = DateTime.Now;
                partner.UpdatedAt = DateTime.Now;

                if (partner.PreviousBalance == 0)
                {
                    dbContext.Partners.Add(partner);
                    dbContext.SaveChanges();

                    return partner;
                }
                else if (partner.PreviousBalance > 0)
                {
                    //Transcation to PartnerLedger
                    //1. Add Partner
                    //2. Add Partner Ledger
                    //3. Add Transaction Log
                    //4. Add Cash Ledger

                    using var transaction = dbContext.Database.BeginTransaction();
                    try
                    {
                        var PartnerId = AddPartnerDetails(partner);

                        if (PartnerId != 0)
                        {
                            var transCode = helperRepository.GetTransactionCode();

                            var cpl = AddPartnerLedgerDetails(transCode, PartnerId, partner);

                            if (cpl != 0)
                            {
                                var cpcl = AddPartnerCashLedgerDetails(transCode, PartnerId, partner);
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

                        return partner;
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


        public IEnumerable<PartnerLedgerViewModel> GetPartnerLedgers(long PartnerId = 0, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (dbContext != null)
            {
                List<PartnerLedgerViewModel> list = new List<PartnerLedgerViewModel>();
                var models = dbContext.PartnerLedgers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = m.Debit - m.Credit;

                    long cid = dbContext.Partners.FirstOrDefault(x => x.Id == m.EntityId).Countryid;
                    long pid = dbContext.Partners.FirstOrDefault(x => x.Id == m.EntityId).Provinceid;

                    string address = "";
                    string country = helperRepository.GetCountry().FirstOrDefault(x => x.Id == cid).Name;
                    string province = helperRepository.GetProvinces().FirstOrDefault(x => x.Id == pid).Name;
                    string addr = dbContext.Partners.FirstOrDefault(x => x.Id == m.EntityId).Address;

                    address = address + ", " + province + ", " + country;


                    PartnerLedgerViewModel model = new PartnerLedgerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        EntityId = m.EntityId,
                        EntityName = dbContext.Partners.FirstOrDefault(x => x.Id == m.EntityId).Name,
                        EntityPhone = dbContext.Partners.FirstOrDefault(x => x.Id == m.EntityId).Phone,
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

                if (PartnerId != 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.EntityId == PartnerId && x.Date >= startDate && x.Date <= endDate).ToList();

                }
                else if (PartnerId == 0 && startDate != null && endDate != null)
                {
                    list = list.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
                else if (PartnerId != 0 && startDate == null && endDate == null)
                {
                    list = list.Where(x => x.EntityId == PartnerId).ToList();
                }
                else
                {
                    //do nothing
                }

                return list;
            }

            return null;
        }

        public bool DeletePartner(long partnerid)
        {
            if (dbContext != null)
            {
                var m = dbContext.Partners.FirstOrDefault(x => x.Id == partnerid);
                if (m != null)
                {
                    m.UserId = pmsHelper.GetCurrentUserId();
                    m.UserName = pmsHelper.GetUserName(m.UserId);
                    m.DeletedAt = DateTime.Now;
                    dbContext.Partners.Update(m);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            return false;
        }

        public IEnumerable<PartnerViewModel> GetAllPartner()
        {
            if (dbContext != null)
            {
                List<PartnerViewModel> list = new List<PartnerViewModel>();
                var models = dbContext.Partners.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = dbContext.PartnerLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Debit) - dbContext.PartnerLedgers.Where(x => x.EntityId == m.Id).Sum(x => x.Credit);

                    PartnerViewModel model = new PartnerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        Name = m.Name,
                        Phone = m.Phone,
                        Email = m.Email,
                        Countryid = m.Countryid,
                        CountryName = dbContext.Countries.FirstOrDefault(x => x.Id == m.Countryid).Name,
                        Provinceid = m.Provinceid,
                        ProvinceName = dbContext.Provinces.FirstOrDefault(x => x.Id == m.Provinceid).Name,
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

        public Partner GetByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                var partner = dbContext.Partners.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                return partner;
            }
            return null;
        }


        public PartnerViewModel GetByIdPartner(long id)
        {
            if (dbContext != null)
            {
                var m = dbContext.Partners.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                decimal pBalance = 0;
                string bFlg = "+";

                pBalance = dbContext.PartnerLedgers.Where(x => x.EntityId == id).Sum(x => x.Debit) - dbContext.PartnerLedgers.Where(x => x.EntityId == id).Sum(x => x.Credit);

                PartnerViewModel model = new PartnerViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Phone = m.Phone,
                    Email = m.Email,
                    Countryid = m.Countryid,
                    CountryName = dbContext.Countries.FirstOrDefault(x => x.Id == m.Countryid).Name,
                    Provinceid = m.Provinceid,
                    ProvinceName = dbContext.Provinces.FirstOrDefault(x => x.Id == m.Provinceid).Name,
                    Address = m.Address + ", " + dbContext.Provinces.FirstOrDefault(x => x.Id == m.Provinceid).Name + ", " + dbContext.Countries.FirstOrDefault(x => x.Id == m.Countryid).Name,
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

        public Partner UpdatePartner(Partner partner)
        {
            if (dbContext != null)
            {
                partner.UserId = pmsHelper.GetCurrentUserId();
                partner.UserName = pmsHelper.GetUserName(partner.UserId);
                partner.UpdatedAt = DateTime.Now;
                dbContext.Partners.Update(partner);
                dbContext.SaveChanges();
                return partner;
            }
            return null;
        }


        //Local Defination 


        private long AddPartnerDetails(Partner partner)
        {
            if (dbContext != null)
            {
                //partner.PreviousBalance = 0;
                dbContext.Partners.Add(partner);
                dbContext.SaveChanges();

                var maxId = dbContext.Partners.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        private int AddPartnerLedgerDetails(string trc, long PartnerId, Partner partner)
        {
            if (dbContext != null)
            {

                PartnerLedger partnerLedger = new PartnerLedger
                {
                    EntityId = PartnerId,
                    Date = DateTime.Now,
                    Description = helperRepository.PartnerPreviousBalanceMsg(partner.PreviousBalance),
                    Debit = partner.PreviousBalance,
                    Credit = 0,
                    Balance = partner.PreviousBalance - 0,
                    TransCode = trc,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.PartnerPreviousBalanceMsg(partner.PreviousBalance),
                    Amount = partner.PreviousBalance,
                    Operation = Operation.Create
                };

                if (transactionRepository.AddTransactionLog(transaction))
                {
                    var res = transactionRepository.AddPartnerLedger(partnerLedger);
                    if (res != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private int AddPartnerCashLedgerDetails(string transCode, long PartnerId, Partner partner)
        {
            if (dbContext != null)
            {
                CashLedger cashLedger = new CashLedger
                {
                    EntityId = PartnerId,
                    EntityType = EntityType.Partner,
                    Date = DateTime.Now,
                    Description = helperRepository.PartnerCashPreviousBalanceMsg(partner.PreviousBalance),
                    VoucherNo = null,
                    Debit = 0,
                    Credit = partner.PreviousBalance,
                    Balance = partner.PreviousBalance - 0,
                    TransCode = transCode,
                    TransType = CashType.PartnerPreviousBalance,
                };

                Transaction transaction = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.PartnerCashPreviousBalanceMsg(partner.PreviousBalance),
                    Amount = partner.PreviousBalance,
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



        public IEnumerable<PartnerInvestment> GetAllPartnersInvestments()
        {
            if (dbContext != null)
            {
                var models = dbContext.PartnerInvestments.ToList();
                return models;
            }

            return null;
        }

        public PartnerInvestment AddPartnerInvestment(PartnerInvestment partner)
        {
            if (dbContext != null)
            {
                partner.UserId = pmsHelper.GetCurrentUserId();
                partner.UserName = pmsHelper.GetUserName(partner.UserId);
                partner.CreatedAt = DateTime.Now;
                partner.UpdatedAt = DateTime.Now;

                if (partner.InvestmetType == 1)
                {
                    partner.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == partner.BankId).BankName;
                }

                partner.PartnerName = dbContext.Partners.FirstOrDefault(x => x.Id == partner.PartnerId).Name;
                var transCode = helperRepository.GetTransactionCode();
                partner.TransCode = transCode;

                //Add Partner... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.PartnerInvestments.Add(partner);
                    dbContext.SaveChanges();

                    PartnerLedger partnerLedger = new PartnerLedger
                    {
                        EntityId = partner.PartnerId,
                        Date = DateTime.Now,
                        Description = helperRepository.PartnerInvestmentCreditMsg(partner.Amount),
                        VoucherNo = null,
                        Debit = 0,
                        Credit = partner.Amount,
                        Balance = 0 - partner.Amount,
                        TransCode = transCode
                    };

                    Transaction transaction3 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.PartnerInvestmentCreditMsg(partner.Amount),
                        Amount = partner.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction3))
                    {
                        var res = transactionRepository.AddPartnerLedger(partnerLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (partner.InvestmetType == 0)
                    {
                        //cash
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = partner.PartnerId,
                            EntityType = EntityType.Partner,
                            Date = DateTime.Now,
                            Description = helperRepository.PartnerInvestmentDebitMsg_Cash(partner.Amount),
                            VoucherNo = null,
                            Debit = partner.Amount,
                            Credit = 0,
                            Balance = partner.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.OwnerEquity
                        };

                        Transaction transaction0 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.PartnerInvestmentDebitMsg_Cash(partner.Amount),
                            Amount = partner.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction0))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else if (partner.InvestmetType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = partner.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.PartnerInvestmentDebitMsg_Bank(partner.Amount),
                            Debit = partner.Amount,
                            Credit = 0,
                            Balance = partner.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction1 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.PartnerInvestmentDebitMsg_Bank(partner.Amount),
                            Amount = partner.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction1))
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
                    return partner;
                }
                catch
                {
                    return null;
                }

            }
            return null;
        }


        public PartnerInvestment GetPartnerInvestment(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.PartnerInvestments.FirstOrDefault(x => x.Id == id);

                return model;
            }

            return null;
        }

        public PartnerInvestment EditPartnerInvestment(PartnerInvestment partner)
        {
            if (dbContext != null)
            {
                partner.UserId = pmsHelper.GetCurrentUserId();
                partner.UserName = pmsHelper.GetUserName(partner.UserId);
                partner.UpdatedAt = DateTime.Now;

                if (partner.InvestmetType == 1)
                {
                    partner.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == partner.BankId).BankName;
                }

                if (partner.InvestmetType == 0)
                {
                    partner.BankId = 0;
                    partner.BankName = "";
                }

                partner.PartnerName = dbContext.Partners.FirstOrDefault(x => x.Id == partner.PartnerId).Name;
                var transCode = partner.TransCode;

                //Add Partner... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.PartnerInvestments.Update(partner);
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

                    var pledger = dbContext.PartnerLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    pledger.EntityId = partner.PartnerId;
                    pledger.Credit = partner.Amount;
                    pledger.Balance = 0 - partner.Amount;
                    pledger.Description = helperRepository.PartnerInvestmentCreditMsg(partner.Amount);


                    Transaction transaction3 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.PartnerInvestmentCreditMsg(partner.Amount),
                        Amount = partner.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction3))
                    {
                        var res = transactionRepository.UpdatePartnerLedger(pledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (partner.InvestmetType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = partner.PartnerId,
                            EntityType = EntityType.Partner,
                            Date = partner.InvestmentDate,
                            Description = helperRepository.PartnerInvestmentDebitMsg_Cash(partner.Amount),
                            VoucherNo = null,
                            Debit = partner.Amount,
                            Credit = 0,
                            Balance = partner.Amount - 0,
                            TransCode = transCode,
                            TransType = CashType.OwnerEquity
                        };

                        Transaction transaction0 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.PartnerInvestmentDebitMsg_Cash(partner.Amount),
                            Amount = partner.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction0))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else if (partner.InvestmetType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = partner.BankId,
                            EntityType = EntityType.Bank,
                            Date = partner.InvestmentDate,
                            Description = helperRepository.PartnerInvestmentDebitMsg_Bank(partner.Amount),
                            Debit = partner.Amount,
                            Credit = 0,
                            Balance = partner.Amount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction1 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.PartnerInvestmentDebitMsg_Bank(partner.Amount),
                            Amount = partner.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction1))
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
                    return partner;
                }
                catch
                {
                    return null;
                }

            }
            return null;
        }


        public IEnumerable<PartnerPayment> GetAllPartnersPayments()
        {
            if (dbContext != null)
            {
                var model = dbContext.PartnerPayments.ToList();
                return model;
            }

            return null;
        }
        public PartnerPayment AddPartnerPayment(PartnerPayment partner)
        {
            if (dbContext != null)
            {
                partner.UserId = pmsHelper.GetCurrentUserId();
                partner.UserName = pmsHelper.GetUserName(partner.UserId);
                partner.CreatedAt = DateTime.Now;
                partner.UpdatedAt = DateTime.Now;

                if (partner.PaymentType == 1)
                {
                    partner.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == partner.BankId).BankName;
                }

                partner.PartnerName = dbContext.Partners.FirstOrDefault(x => x.Id == partner.PartnerId).Name;
                var transCode = helperRepository.GetTransactionCode();
                partner.TransCode = transCode;

                //Add Partner... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.PartnerPayments.Add(partner);
                    dbContext.SaveChanges();

                    PartnerLedger partnerLedger = new PartnerLedger
                    {
                        EntityId = partner.PartnerId,
                        Date = DateTime.Now,
                        Description = helperRepository.PartnerPaymentDebitMsg(partner.Amount),
                        VoucherNo = null,
                        Debit = partner.Amount,
                        Credit = 0,
                        Balance = partner.Amount - 0,
                        TransCode = transCode
                    };

                    Transaction transaction3 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.PartnerPaymentDebitMsg(partner.Amount),
                        Amount = partner.Amount,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction3))
                    {
                        var res = transactionRepository.AddPartnerLedger(partnerLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (partner.PaymentType == 0)
                    {
                        //cash
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = partner.PartnerId,
                            EntityType = EntityType.Partner,
                            Date = DateTime.Now,
                            Description = helperRepository.PartnerPaymentCreditMsg_Cash(partner.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = partner.Amount,
                            Balance = 0 - partner.Amount,
                            TransCode = transCode,
                            TransType = CashType.PartnerPayment
                        };

                        Transaction transaction0 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.PartnerPaymentCreditMsg_Cash(partner.Amount),
                            Amount = partner.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction0))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else if (partner.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = partner.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.PartnerPaymentCreditMsg_Bank(partner.Amount),
                            Debit = 0,
                            Credit = partner.Amount,
                            Balance = 0 - partner.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction1 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.PartnerPaymentCreditMsg_Bank(partner.Amount),
                            Amount = partner.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction1))
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
                    return partner;
                }
                catch
                {
                    return null;
                }

            }
            return null;
        }
        public PartnerPayment GetPartnerPayment(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.PartnerPayments.FirstOrDefault(x => x.Id == id);

                return model;
            }

            return null;
        }
        public PartnerPayment EditPartnerPayment(PartnerPayment partner)
        {
            if (dbContext != null)
            {
                partner.UserId = pmsHelper.GetCurrentUserId();
                partner.UserName = pmsHelper.GetUserName(partner.UserId);
                partner.UpdatedAt = DateTime.Now;

                if (partner.PaymentType == 1)
                {
                    partner.BankName = dbContext.Banks.FirstOrDefault(x => x.Id == partner.BankId).BankName;
                }

                if (partner.PaymentType == 0)
                {
                    partner.BankId = 0;
                    partner.BankName = "";
                }

                partner.PartnerName = dbContext.Partners.FirstOrDefault(x => x.Id == partner.PartnerId).Name;
                var transCode = partner.TransCode;

                //Add Partner... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.PartnerPayments.Update(partner);
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

                    var pledger = dbContext.PartnerLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    pledger.EntityId = partner.PartnerId;
                    pledger.Debit = partner.Amount;
                    pledger.Balance = partner.Amount - 0;
                    pledger.Description = helperRepository.PartnerPaymentDebitMsg(partner.Amount);


                    Transaction transaction3 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.PartnerPaymentDebitMsg(partner.Amount),
                        Amount = partner.Amount,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction3))
                    {
                        var res = transactionRepository.UpdatePartnerLedger(pledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    if (partner.PaymentType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = partner.PartnerId,
                            EntityType = EntityType.Partner,
                            Date = partner.Date,
                            Description = helperRepository.PartnerPaymentCreditMsg_Cash(partner.Amount),
                            VoucherNo = null,
                            Debit = 0,
                            Credit = partner.Amount,
                            Balance = 0 - partner.Amount,
                            TransCode = transCode,
                            TransType = CashType.PartnerPayment
                        };

                        Transaction transaction0 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.PartnerPaymentCreditMsg_Cash(partner.Amount),
                            Amount = partner.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction0))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }

                    }
                    else if (partner.PaymentType == 1)
                    {
                        //bank

                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = partner.BankId,
                            EntityType = EntityType.Bank,
                            Date = partner.Date,
                            Description = helperRepository.PartnerPaymentCreditMsg_Bank(partner.Amount),
                            Debit = 0,
                            Credit = partner.Amount,
                            Balance = 0 - partner.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction1 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.PartnerPaymentCreditMsg_Bank(partner.Amount),
                            Amount = partner.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction1))
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
                    return partner;
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
