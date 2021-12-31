using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.OfficeLoan
{
    public class OfficeLoanReceive : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please select Person!")]
        public long PersonId { get; set; }
        public string PersonName { get; set; }

        [Required(ErrorMessage = "Please enter payment date!")]
        public DateTime Date { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Amount { get; set; }
        public string Desciption { get; set; }
        public string TransCode { get; set; }
        public int PaymentType { get; set; } //0 Cash 1 Bank
    }
}
