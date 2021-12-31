using PMS.Models;
using PMS.ViewModels.StockViewModels;
using System.Collections.Generic;

namespace PMS.ViewModels.ProductViewModels
{
    public class ProductDetailsViewModel
    {
        public ProductIndexViewModel ProductDetails { get; set; }
        public IEnumerable<StockDetaillsViewModel> StockDetails { get; set; }
        public ICollection<ProductUnit> ProductUnits { get; set; }
    }
}
