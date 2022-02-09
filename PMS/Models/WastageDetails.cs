using PMS.Models.Lookup;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class WastageDetails : BaseEntity.BaseEntity
    {
        public long WastageId { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long UnitId { get; set; }
        public Unit Unit { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Qty { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalPrice { get; set; }

        //[EnumDataType(typeof(CurrencyEnum))]
        //public CurrencyEnum currencyEnum { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal ExchangeRate { get; set; }

    }
}
