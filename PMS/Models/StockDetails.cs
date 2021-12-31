using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class StockDetails : BaseEntity.BaseEntity
    {
        public long ProductId { get; set; }
        public long CustomerId { get; set; } // this give error not migrated into data
        public long SupplierId { get; set; }
        public float InQty { get; set; }
        public float OutQty { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal SalePrice { get; set; }
        public string TransCode { get; set; }
        public string Description { get; set; }

    }
}
