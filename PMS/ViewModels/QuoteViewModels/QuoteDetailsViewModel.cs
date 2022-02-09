namespace PMS.ViewModels.QuoteViewModels
{
    public class QuoteDetailsViewModel
    {
        public int Sno { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string BatchId { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalQuotePrice { get; set; }

    }

}
