using PMS.Data.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Finance
{
    public class BankLedger : BaseEntity.BaseEntity
    {
        public long EntityId { get; set; }
        public EntityType EntityType { get; set; }

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
        public CashType TransType { get; set; }

        [DefaultValue(false)]
        public bool isClosed { get; set; }

        public long BankTransactionId { get; set; }
    }
}
