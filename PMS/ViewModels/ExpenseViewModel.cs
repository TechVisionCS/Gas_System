using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.ViewModels
{
    public class ExpenseViewModel
    {
        public long Id { get; set; }
        public long SNO { get; set; }
        public Nullable<long> BankId { get; set; }
        public string BankName { get; set; }
        public string BillNumber { get; set; }
        public long ExpenseCategoryId { get; set; }
        public string ExpenseCategoryName { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int PaymentType { get; set; } //0 Cash 1 Bank
        public string TransCode { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
