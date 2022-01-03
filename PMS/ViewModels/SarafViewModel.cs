using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.ViewModels
{
    public class SarafViewModel
    {
        public long Id { get; set; }
        public string SarafName { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public string Branch { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal CurrentAmount { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
