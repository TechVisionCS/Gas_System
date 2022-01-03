using PMS.Models;
using PMS.ViewModels.Finance;
using System.Collections.Generic;

namespace PMS.ViewModels
{
    public class SarafDetailsViewModel
    {
        public SarafViewModel sarafViewModel { get; set; }
        public IEnumerable<SarafTransaction> sarafTransactions { get; set; }
        public IEnumerable<SarafsLedgerViewModel> SarafsLedgers { get; set; }

    }
}
