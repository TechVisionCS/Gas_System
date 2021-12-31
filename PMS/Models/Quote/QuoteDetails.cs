using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Quote
{
    public class QuoteDetails : BaseEntity.BaseEntity
    {
        public long QuoteId { get; set; }
        public long ProductId { get; set; }
        public string BatchId { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Qty { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalQuotePrice { get; set; }

    }
}
