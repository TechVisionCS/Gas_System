using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.ViewModels.Service
{
    public class ServiceViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? ServiceDate { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomeraAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int PaymentType { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        [DefaultValue(0)]
        public decimal TaxAmount { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        [DefaultValue(0)]
        public decimal DiscountAmount { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal SubTotal { get; set; }
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        [DefaultValue(0)]
        public decimal PaidAmount { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal DueAmount { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
