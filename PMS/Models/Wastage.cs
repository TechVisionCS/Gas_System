using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class Wastage : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please enter Wastage Date!")]
        public DateTime? WastageDate { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal SubTotal { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal IncomeFromWastage { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal ExCharges { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalAmount { get; set; }
        public string Description { get; set; }
        public string TransCode { get; set; }
        public int Flg { get; set; }

        //[EnumDataType(typeof(CurrencyEnum))]
        //public CurrencyEnum currencyEnum { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal ExchangeRate { get; set; }

    }
}
