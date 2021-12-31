using System;

namespace PMS.ViewModels.StockViewModels
{
    public class StockDetaillsViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }

        public float InQty { get; set; }
        public float OutQty { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string TransCode { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
