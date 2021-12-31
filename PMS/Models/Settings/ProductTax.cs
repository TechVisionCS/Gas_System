using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models.Settings
{
    public class ProductTax
    {
        public long ProductId { get; set; }
        public long TaxId { get; set; }
        public Product product { get; set; }
        public Tax Tax { get; set; }

    }
}
