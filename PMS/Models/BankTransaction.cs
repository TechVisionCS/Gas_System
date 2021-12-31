using PMS.Data.Enums;
using PMS.Models.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class BankTransaction: BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Transaction Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please Select Bank")]
        public long BankId { get; set; }

        [Required(ErrorMessage = "Please Select Transaction Type")]
        public TType TransType { get; set; }

        [Required(ErrorMessage = "Please Enter Withdraw / Deposit ID")]
        public string BankTransactionId { get; set; }

        [Required(ErrorMessage = "Please Enter Transaction Amount")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Please Enter Transaction Details")]
        public string Description { get; set; }

    }
}
