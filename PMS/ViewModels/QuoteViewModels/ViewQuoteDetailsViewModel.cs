using PMS.Models;
using System.Collections.Generic;

namespace PMS.ViewModels.QuoteViewModels
{
    public class ViewQuoteDetailsViewModel
    {
        public QuoteViewModel Quote { get; set; }
        public IEnumerable<QuoteDetailsViewModel> QuoteDetails { get; set; }
        public Shop ShopModelDetails { get; set; }
    }
}
