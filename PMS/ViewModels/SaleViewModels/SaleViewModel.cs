using PMS.Models;
using System;

namespace PMS.ViewModels.SaleViewModels
{
    public class SaleViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string SaleDate { get; set; }
        public Customer Customer { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
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
