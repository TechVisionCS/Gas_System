using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class EmployeeSalary : BaseEntity.BaseEntity
    {
        [ForeignKey("Employee")]
        public long EmployeeId { get; set; }

        [Required(ErrorMessage = "Please Select Year")]
        public int SalaryYear { get; set; }

        [Required(ErrorMessage = "Please Select Month")]
        public int SalaryMonth { get; set; }

        [Required(ErrorMessage = "Please Enter Total Days of WOrk")]
        public int TotalWorkDays { get; set; }

        [Required(ErrorMessage = "Please Enter OverTime Amount")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal OverTime { get; set; }

        [Required(ErrorMessage = "Please Enter Bounse Amount")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Bounce { get; set; }

        [Required(ErrorMessage = "Please Enter Tax Amount")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Tax { get; set; }

        [Required(ErrorMessage = "Auto Calculate NetSalary")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal NetSalary { get; set; }

        [Required(ErrorMessage = "Please Enter Paid Amount")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Paid { get; set; }

        [Required(ErrorMessage = "Auto Calcualte Balanced")]
        [Column(TypeName = "decimal(38, 2)")]
        public decimal Balanced { get; set; }
        public DateTime DueDate { get; set; }
        public bool isPaid { get; set; }
        public string TransCode { get; set; }
        public Employee Employee { get; set; }

        //[EnumDataType(typeof(CurrencyEnum))]
        //public CurrencyEnum currencyEnum { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal ExchangeRate { get; set; }

    }
}
