using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class PartnerPayment : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please select Partner!")]
        public long PartnerId { get; set; }
        public string PartnerName { get; set; }

        [Required(ErrorMessage = "Please enter opening balance date!")]
        public DateTime Date { get; set; }

        public long BankId { get; set; }
        public string BankName { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Description is Requried")]
        public string Desciption { get; set; }
        public string TransCode { get; set; }
        public int PaymentType { get; set; } //0 Cash 1 Bank

        //[EnumDataType(typeof(CurrencyEnum))]
        //public CurrencyEnum currencyEnum { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal ExchangeRate { get; set; }

    }
}
