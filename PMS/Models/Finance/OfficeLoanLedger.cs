using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Finance
{
    public class OfficeLoanLedger : BaseEntity.BaseEntity
    {
        public long EntityId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string VoucherNo { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Debit { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Credit { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Balance { get; set; }
        public string TransCode { get; set; }

        [DefaultValue(false)]
        public bool isClosed { get; set; }
    }
}
