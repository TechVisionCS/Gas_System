using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.OfficeLoan
{
    public class OfficePerson : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Person Name")]
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Details { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal PreviousBalance { get; set; }
    }
}
