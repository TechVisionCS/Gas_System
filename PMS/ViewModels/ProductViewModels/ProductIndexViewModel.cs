using PMS.Models;
using System;
using System.Collections.Generic;

namespace PMS.ViewModels.ProductViewModels
{
    public class ProductIndexViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public string Name { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public long UnitId { get; set; }
        public string UnitName { get; set; }
        public long ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        //public decimal UnitSellPrice { get; set; }
        public float TotalAvailStockQtys { get; set; }

        public string Description { get; set; }

        public ICollection<ProductUnit> ProductUnits { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
