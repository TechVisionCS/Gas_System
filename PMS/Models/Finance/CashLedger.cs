using PMS.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models.Finance
{
    public class CashLedger : BaseEntity.BaseEntity
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

    }
}
