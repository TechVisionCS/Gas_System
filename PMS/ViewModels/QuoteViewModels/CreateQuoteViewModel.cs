using PMS.Models.Quote;
using System.Collections.Generic;

namespace PMS.ViewModels.QuoteViewModels
{
    public class CreateQuoteViewModel
    {
        public Quote Quote { get; set; }
        public IEnumerable<QuoteDetails> QuoteDetails { get; set; }
    }
}
