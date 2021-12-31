using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models.Settings
{
    public class Tax: BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Enter Tax Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Tax Amount by Percentage(%)")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Select Tax Status")]
        public int Status { get; set; }

        public ICollection<ProductTax> productTaxes { get; set; }
    }
}
