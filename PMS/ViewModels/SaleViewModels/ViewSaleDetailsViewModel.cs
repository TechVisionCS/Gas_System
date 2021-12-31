using PMS.Models;
using System.Collections.Generic;

namespace PMS.ViewModels.SaleViewModels
{
    public class ViewSaleDetailsViewModel
    {
        public SaleViewModel Sale { get; set; }
        public IEnumerable<SaleDetailsViewModel> SaleDetails { get; set; }
        public Shop ShopModelDetails { get; set; }
    }
}
