using PMS.Models.Lookup;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Sale
{
    public class SaleDetails : BaseEntity.BaseEntity
    {
        public long SaleId { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long UnitId { get; set; }
        public Unit Unit { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Qty { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalSalePrice { get; set; }
    }
}
