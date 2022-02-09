﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class Supplier : BaseEntity.BaseEntity
    {

        [Required(ErrorMessage = "Please Enter Supplier Name")]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Details { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal PreviousBalance { get; set; }

        //[EnumDataType(typeof(CurrencyEnum))]
        //public CurrencyEnum currencyEnum { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal ExchangeRate { get; set; }
    }
}
