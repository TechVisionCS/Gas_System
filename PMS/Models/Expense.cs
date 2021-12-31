using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class Expense : BaseEntity.BaseEntity
    {
        //[BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string BillNumber { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }

        [Required(ErrorMessage = "Expense Category is required")]
        public long ExpenseCategory { get; set; }
        public long EmployeeId { get; set; }

        [Required(ErrorMessage = "Payment Type is required")]
        public int PaymentType { get; set; } //0 Cash 1 Bank

        [Required(ErrorMessage = "Amount is required")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string TransCode { get; set; }
    }
}
