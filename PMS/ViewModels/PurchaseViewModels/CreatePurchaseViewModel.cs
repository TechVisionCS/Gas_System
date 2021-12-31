using PMS.Models.Purchase;
using System.Collections.Generic;

namespace PMS.ViewModels.PurchaseViewModels
{
    public class CreatePurchaseViewModel
    {
        public Purchase Purchase { get; set; }
        public IEnumerable<PurchaseDetails> PurchaseDetails { get; set; }
    }
}
