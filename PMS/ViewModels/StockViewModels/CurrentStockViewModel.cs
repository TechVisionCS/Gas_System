using System;

namespace PMS.ViewModels.Stock
{
    public class CurrentStockViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public float TotalInQty { get; set; }
        public float TotalOutQty { get; set; }
        public float CurrentStockQty { get; set; }
        public decimal StockPurchasedPrice { get; set; }
        public decimal StockSalesPrice { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
