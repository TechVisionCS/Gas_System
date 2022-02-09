using PMS.Models;
using PMS.Models.Lookup;

namespace PMS.ViewModels.Wastages
{
    public class WastageDetailsViewModel
    {
        public long Id { get; set; }
        public long WastageId { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long UnitId { get; set; }
        public Unit Unit { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }


    }
}
