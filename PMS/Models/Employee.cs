using Microsoft.AspNetCore.Http;
using PMS.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class Employee : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Enter Employee Name")]
        public string Name { get; set; }

        public string Lastname { get; set; }

        [Required(ErrorMessage = "Enter Employee Father Name")]
        public string Fathername { get; set; }
        public string NationalIdnumber { get; set; }

        [Required(ErrorMessage = "Enter Employee Phone Number")]
        public string Phone { get; set; }
        public string Email { get; set; }
        public long Countryid { get; set; }
        public long Provinceid { get; set; }
        public string Address { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [EnumDataType(typeof(MaritalState))]
        public MaritalState MaritalStatus { get; set; }
        [EnumDataType(typeof(EducationDegree))]
        public EducationDegree EducationalDegree { get; set; }

        [Column(TypeName = "decimal (38,2)")]
        public decimal BaseSalary { get; set; }
        public string Birthdate { get; set; }
        public string Hiredate { get; set; }
        public DateTime? Leavedate { get; set; }

        public string Image { get; set; }

        [Display(Name = "Image Picture")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Details { get; set; }
        public long DesignationId { get; set; }
    }

}
