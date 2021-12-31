using PMS.Models;
using PMS.Models.Lookup;
using System;

namespace PMS.ViewModels.PurchaseViewModels
{
    public class PurchaseDetailsViewModel
    {
        public int Sno { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }

        public long UnitId { get; set; }
        public Unit Unit { get; set; }
        public decimal Qty { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal TotalPurchasePrice { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
