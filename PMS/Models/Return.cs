using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class Return : BaseEntity.BaseEntity
    {
        public long PurchaseId { get; set; }
        public string InvoiceNo { get; set; }
        public long SaleId { get; set; }
        public int ReturnType { get; set; }

        [Required(ErrorMessage = "Please Enter Return's Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReturnDate { get; set; }

        public long CustomerId { get; set; }
        public long SupplierId { get; set; }

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
    }
}
