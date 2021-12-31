using PMS.Models;
using System.Collections.Generic;

namespace PMS.ViewModels
{
    public class PartnerDetailsViewModel
    {
        public PartnerViewModel PartnerDetails { get; set; }
        public IEnumerable<PartnerLedgerViewModel> PartnerLedgerDetails { get; set; }

        public IEnumerable<PartnerInvestment> ProductInvestmentDetails { get; set; }
        public IEnumerable<PartnerPayment> PartnerPaymentDetails { get; set; }
    }
}
