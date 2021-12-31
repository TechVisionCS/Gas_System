using PMS.Data.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Quote
{
    public class Quote : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Sale Date")]
        public DateTime QuoteDate { get; set; }

        [Required(ErrorMessage = "Please Select the Customer")]
        public long CustomerId { get; set; }

        [Required(ErrorMessage = "Please Select Payment Type")]
        public int PaymentType { get; set; }
        public long BankId { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal SubTotal { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        [DefaultValue(0)]
        public decimal RentAmount { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        [DefaultValue(0)]
        public decimal TaxAmount { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        [DefaultValue(0)]
        public decimal DiscountAmount { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalAmount { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        [DefaultValue(0)]
        public decimal PaidAmount { get; set; } = 0;
        [Column(TypeName = "decimal(38, 2)")]
        public decimal DueAmount { get; set; }
        public string Description { get; set; }
        public string InvoiceNo { get; set; }

        [EnumDataType(typeof(QuoteStatus))]
        public QuoteStatus QuoteStatus { get; set; }

    }
}