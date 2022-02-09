using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.ViewModels.Finance
{
    public class SarafsLedgerViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public long EntityId { get; set; }
        public string EntityName { get; set; }
        public string EntityAccountName { get; set; }
        public string EntityAccountNo { get; set; }
        public string EntityBranch { get; set; }
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
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

    }
}
