using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class StockLog : BaseEntity.BaseEntity
    {
        public long ProductId { get; set; }
        public long SupplierId { get; set; }
        public string BatchId { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal InQty { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal OutQty { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal StockQty { get; set; }
        public DateTime? PurchaseDate { get; set; }
    }
}
