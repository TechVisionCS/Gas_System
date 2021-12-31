using System.ComponentModel.DataAnnotations;

namespace PMS.Models.Lookup
{
    public class ExpensesCategory : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Enter Expenses Category Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } = 1;
    }
}
