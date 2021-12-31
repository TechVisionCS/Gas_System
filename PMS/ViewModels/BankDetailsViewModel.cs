using PMS.Models;
using PMS.ViewModels.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.ViewModels
{
    public class BankDetailsViewModel
    {
        public BankViewModel bankViewModel { get; set; }

        public IEnumerable<BankTransaction> bankTransactions { get; set; }
        public IEnumerable<BanksLedgerViewModel> banksLedger { get; set; }

    }
}
