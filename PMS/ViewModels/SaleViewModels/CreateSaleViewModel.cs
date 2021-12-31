using PMS.Models.Sale;
using System.Collections.Generic;

namespace PMS.ViewModels.SaleViewModels
{
    public class CreateSaleViewModel
    {
        public Sale Sale { get; set; }
        public IEnumerable<SaleDetails> SaleDetails { get; set; }
    }
}
