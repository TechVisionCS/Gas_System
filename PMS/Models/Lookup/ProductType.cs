using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models.Lookup
{
    public class ProductType : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please select product category!")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Enter Product Type Name!")]
        public string TypeName { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } = 1;
        public ICollection<Product> products { get; set; }
    }
}
