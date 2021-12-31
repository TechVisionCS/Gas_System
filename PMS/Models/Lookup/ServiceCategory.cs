using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Lookup
{
    public class ServiceCategory : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Enter Services Category Name")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        [DefaultValue(0)]
        public decimal Fee { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } = 1;
    }
}
