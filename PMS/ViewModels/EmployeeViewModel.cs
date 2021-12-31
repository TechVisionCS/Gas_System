using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.ViewModels
{
    public class EmployeeViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Fathername { get; set; }
        public string NationalIdnumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public long Countryid { get; set; }
        public string CountryName { get; set; }
        public long Provinceid { get; set; }
        public string ProvinceName { get; set; }
        public string Address { get; set; }
        public int Gender { get; set; }
        public int MaritalStatus { get; set; }
        public int EducationalDegree { get; set; }

        [Column(TypeName = "decimal (38,2)")]
        public decimal BaseSalary { get; set; }
        public string Birthdate { get; set; }
        public string Hidredate { get; set; }
        public DateTime? Leavedate { get; set; }
        public string Image { get; set; }
        public long DesignationId { get; set; }
        public string DesignationName { get; set; }

        public string ManagerName { get; set; }
        public string Details { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
