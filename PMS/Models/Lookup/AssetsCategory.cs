using System.ComponentModel.DataAnnotations;

namespace PMS.Models.Lookup
{
    public class AssetsCategory : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Enter Asstes Type Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } = 1;

    }
}
