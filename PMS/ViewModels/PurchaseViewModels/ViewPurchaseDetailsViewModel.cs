using PMS.Models;
using System.Collections.Generic;

namespace PMS.ViewModels.PurchaseViewModels
{
    public class ViewPurchaseDetailsViewModel
    {
        public PurchaseViewModel purchase { get; set; }
        public IEnumerable<PurchaseDetailsViewModel> purchaseDetails { get; set; }
        public Shop ShopModelDetails { get; set; }
    }
}
