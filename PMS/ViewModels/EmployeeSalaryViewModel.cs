using System;

namespace PMS.ViewModels
{
    public class EmployeeSalaryViewModel
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeFatherName { get; set; }

        public long DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string Hiredate { get; set; }
        public string Leavedate { get; set; }
        public decimal BasicSalary { get; set; }
        public int TotalWorkDays { get; set; }
        public int SalaryYear { get; set; }
        public int SalaryMonth { get; set; }
        public decimal OverTime { get; set; }
        public decimal Bounce { get; set; }
        public decimal Tax { get; set; }
        public decimal NetSalary { get; set; }
        public decimal Paid { get; set; }
        public decimal Balanced { get; set; }
        public DateTime DueDate { get; set; }
        public bool isPaid { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
