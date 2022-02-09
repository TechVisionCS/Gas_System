using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    //  0778996583

    public class Employee : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Enter Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Employee Father Name")]
        public string Fathername { get; set; }
        public string NationalIdnumber { get; set; }

        [Required(ErrorMessage = "Enter Employee Phone Number")]
        public string Phone { get; set; }
        public string Address { get; set; }


        [Column(TypeName = "decimal (38,2)")]
        public decimal BaseSalary { get; set; }
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
