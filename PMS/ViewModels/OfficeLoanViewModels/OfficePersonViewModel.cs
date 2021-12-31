using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.ViewModels.OfficeLoanViewModels
{
    public class OfficePersonViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Details { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Balance { get; set; }
        public string BalanceFlg { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
