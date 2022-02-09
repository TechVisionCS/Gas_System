using System;

namespace PMS.ViewModels.ReturnViewModels
{
    public class ReturnModelViewModel
    {
        public long Id { get; set; }
        public long PurchaseId { get; set; }
        public long SaleId { get; set; }
        public string InvoiceNo { get; set; }
        public int ReturnType { get; set; }
        public DateTime ReturnDate { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int PaymentType { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }
        public decimal SubTotal { get; set; }
        public decimal RentAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string Description { get; set; }
        public string TransCode { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
