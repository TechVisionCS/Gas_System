using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models
{
    public class Product : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please enter product name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select product category!")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "Please select product manufacturer!")]
        public long ManufacturerId { get; set; }

        [Required(ErrorMessage = "Please select product unit!")]
        //public long UnitId { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal UnitSellPrice { get; set; }
        public string Description { get; set; }

        public ICollection<ProductUnit> ProductsUnits { get; set; }
    }
}
