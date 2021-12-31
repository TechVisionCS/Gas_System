using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class ProductSupplier: BaseEntity.BaseEntity
    {
        public long ProductId { get; set; }
        public long SupplierId { get; set; }
    }
}
