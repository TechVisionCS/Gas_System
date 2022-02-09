using PMS.Data.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Purchase
{
    public class Purchase : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Please Enter Invoice No")]
        public string InvoiceNo { get; set; }

        [Required(ErrorMessage = "Please Select the Supplier")]
        public long SupplierId { get; set; }

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
        public PurchaseType PurchaseType { get; set; }
        public string TransCode { get; set; }
        [EnumDataType(typeof(CurrencyEnum))]
        public CurrencyEnum currencyEnum { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal ExchangeRate { get; set; }
        [Column(TypeName = "decimal(38, 2)")]

        public decimal ExchangeAmount { get; set; }


    }
}
