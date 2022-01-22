using PMS.Data.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Sale
{
    public class Sale : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Sale Date")]
        public DateTime SaleDate { get; set; }

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
        public decimal PaidAmount { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal DueAmount { get; set; }
        public string Description { get; set; }
        public string TransCode { get; set; }

        [EnumDataType(typeof(SaleType))]
        public SaleType SaleType { get; set; }

        [EnumDataType(typeof(Currency))]
        public Currency SaleCurrency { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal ExchangeRate { get; set; } = 0;
        [Column(TypeName = "decimal(38, 2)")]
        public decimal ExchangeAmount { get; set; } = 0;
    }
}
