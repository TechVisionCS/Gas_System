using PMS.Models;
using PMS.ViewModels;
using PMS.ViewModels.Finance;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IBankRepository
    {
        IEnumerable<BankViewModel> GetAll();
        Bank GetByIdBank(long id);
        BankDetailsViewModel GetBankDetails(long id);
        Bank AddBank(Bank bank);
        Bank UpdateBank(Bank bank);
        IEnumerable<BanksLedgerViewModel> GetBankLedgers(long bankId, DateTime? startDate, DateTime? endDate);

        BankTransaction AddBankTransaction(BankTransaction bankTransaction);
        BankTransaction AddBankTransaction_Purchase(BankTransaction bankTransaction, string transCode);
    }
}
