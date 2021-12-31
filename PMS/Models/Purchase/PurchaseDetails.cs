using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Purchase
{
    public class PurchaseDetails : BaseEntity.BaseEntity
    {
        public long PurchaseId { get; set; }
        public long ProductId { get; set; }
        public long UnitId { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Qty { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalPurchasePrice { get; set; }
    }
}
