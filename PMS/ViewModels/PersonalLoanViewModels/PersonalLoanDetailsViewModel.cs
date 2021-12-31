using PMS.ViewModels.Finance;
using System.Collections.Generic;

namespace PMS.ViewModels.PersonalLoanViewModels
{
    public class PersonalLoanDetailsViewModel
    {
        public PersonViewModel PersonalLoanViewModel { get; set; }
        public IEnumerable<PersonLedgerViewModel> PersonLedgerViewModels { get; set; }
    }
}
