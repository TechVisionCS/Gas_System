using PMS.Models;
using PMS.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.ViewModels
{
    public class SupplierDetailsViewModel
    {
        public SupplierViewModel SupplierDetails { get; set; }
        public IEnumerable<SupplierLedgerViewModel> SupplierLedgerDetails { get; set; }
        public IEnumerable<ProductIndexViewModel> ProductDetails { get; set; }
    }
}
