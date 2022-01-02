using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models.Lookup
{
    public class Unit : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Enter Category Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter unit sell price")]
        public float KgAmount { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } = 1;

        public ICollection<ProductUnit> ProductsUnits { get; set; }
    }
}
