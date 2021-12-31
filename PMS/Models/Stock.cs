using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class Stock: BaseEntity.BaseEntity
    {
        public long ProductId { get; set; }
        public float InQty { get; set; }
        public float OutQty { get; set; }
        public float StockQty { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalStockPurchasePrice { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalStockSalePrice { get; set; }

    }
}
