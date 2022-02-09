using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class Bank : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Bank Name")]
        public string BankName { get; set; }

        [Required(ErrorMessage = "Please Enter Account Name")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Please Enter Account No")]
        public string AccountNo { get; set; }

        public string Branch { get; set; }

        public string Description { get; set; }

        public string Signature { get; set; }
        //public long CurrecnyId { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal ExchangeRate { get; set; } = 0;


    }
}
