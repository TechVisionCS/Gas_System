using PMS.Models;
using PMS.Models.Lookup;

namespace PMS.ViewModels.ReturnViewModels
{
    public class ReturnDetailsViewModel
    {
        public long ReturnId { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long UnitId { get; set; }
        public Unit Unit { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public long DetailsId { get; set; }
    }
}
