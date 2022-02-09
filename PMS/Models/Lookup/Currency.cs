using System.ComponentModel.DataAnnotations;

namespace PMS.Models.Lookup
{
    public class Currency : BaseEntity.BaseEntity
    {

        [Required(ErrorMessage = "please Enter Currency Name")]
        public string CurrencyName { get; set; }
        [Required(ErrorMessage = "Please Enter Currency ISO Code")]
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
    }
}
