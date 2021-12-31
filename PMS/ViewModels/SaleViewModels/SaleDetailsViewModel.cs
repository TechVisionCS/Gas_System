using PMS.Models;
using PMS.Models.Lookup;
using System;

namespace PMS.ViewModels.SaleViewModels
{
    public class SaleDetailsViewModel
    {
        public int Sno { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long UnitId { get; set; }
        public Unit Unit { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalSalePrice { get; set; }

        public DateTime? CreatedAt { get; set; }

    }
}
