using PMS.ViewModels.Finance;
using PMS.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public CustomerViewModel CustomerDetails { get; set; }
        public IEnumerable<CustomerLedgerViewModel> CustomerLedgerDetails { get; set; }
        //public IEnumerable<ProductIndexViewModel> ProductDetails { get; set; }
    }
}
