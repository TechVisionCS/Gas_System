using System.ComponentModel.DataAnnotations;

namespace PMS.Models.Lookup
{
    public class Manufacturer : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Manufacturer Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Select Manufacturer Country")]
        public string Description { get; set; }
        public int Status { get; set; } = 1;
    }
}
