using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Service
{
    public class ServiceDetails : BaseEntity.BaseEntity
    {
        public long ServiceId { get; set; }
        public long ServiceCatergoryId { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Qty { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Fee_Charges { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalServicePrice { get; set; }
        public string Descriptions { get; set; }
    }
}
