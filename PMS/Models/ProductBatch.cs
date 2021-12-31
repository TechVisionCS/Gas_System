using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class ProductBatch : BaseEntity.BaseEntity
    {
        public long PurchaseId { get; set; }
        public long ProductId { get; set; }
        public string BatchId { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal StockQty { get; set; } = 0;

        [Column(TypeName = "decimal(38, 2)")]
        public decimal PurchasePrice { get; set; } = 0;
        public DateTime? PurchaseDate { get; set; }

        [NotMapped]
        public string BatchIdName { get; set; }

    }
}
