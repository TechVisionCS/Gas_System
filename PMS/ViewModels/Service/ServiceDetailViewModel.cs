using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.ViewModels.Service
{
    public class ServiceDetailViewModel
    {
        public int Sno { get; set; }
        public long ServiceId { get; set; }
        public long ServiceCatergoryId { get; set; }
        public string ServiceCategoryName { get; set; }

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
