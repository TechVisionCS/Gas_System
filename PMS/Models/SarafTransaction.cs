using PMS.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class SarafTransaction : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Transaction Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please Select Bank")]
        public long SarafId { get; set; }

        [Required(ErrorMessage = "Please Select Transaction Type")]
        public TType TransType { get; set; }

        [Required(ErrorMessage = "Please Enter Withdraw / Deposit ID")]
        public string SarafTransactionId { get; set; }

        [Required(ErrorMessage = "Please Enter Transaction Amount")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Please Enter Transaction Details")]
        public string Description { get; set; }

        //[EnumDataType(typeof(CurrencyEnum))]
        //public CurrencyEnum currencyEnum { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal ExchangeRate { get; set; }


    }
}
