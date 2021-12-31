using PMS.ViewModels.Finance;
using System.Collections.Generic;

namespace PMS.ViewModels.OfficeLoanViewModels
{
    public class OfficePersonLoanDetailsViewModel
    {
        public OfficePersonViewModel OfficePersonViewModel { get; set; }
        public IEnumerable<OfficePersonLedgerViewModel> officePersonLedgerViewModels { get; set; }
    }
}
