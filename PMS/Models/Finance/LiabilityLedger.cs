using PMS.Data.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models.Finance
{
    public class LiabilityLedger : BaseEntity.BaseEntity
    {
        public LaibilityType LaibilityType { get; set; }
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

        [DefaultValue(false)]
        public bool isClosed { get; set; }

        //[EnumDataType(typeof(CurrencyEnum))]
        //public CurrencyEnum currencyEnum { get; set; }

        //[Column(TypeName = "decimal(38, 2)")]
        //public decimal ExchangeRate { get; set; }



    }
}
