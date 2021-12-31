using PMS.Data.Enums;
using System;

namespace PMS.ViewModels.PurchaseViewModels
{
    public class PurchaseViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public string PurchaseDate { get; set; }
        public string InvoiceNo { get; set; }
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
        public PurchaseType PurchaseTypeId { get; set; }
        public string PurchaseType { get; set; }
        public string Description { get; set; }
        public string TransCode { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
