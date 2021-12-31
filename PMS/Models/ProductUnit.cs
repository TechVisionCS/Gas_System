using PMS.Models.Lookup;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class ProductUnit
    {
        [Key]
        public long Id { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long UnitId { get; set; }
        public Unit Unit { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal UnitSellPrice { get; set; }
    }
}
