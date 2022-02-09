using System;

namespace PMS.ViewModels.QuoteViewModels
{
    public class QuoteViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public string QuoteDate { get; set; }
        public string InvoiceNo { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomeraAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

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
        public int QuoteStatus { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }


    }
}
