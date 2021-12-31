using PMS.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models.Finance
{
    public class Transaction: BaseEntity.BaseEntity
    {
        public string TransCode { get; set; }
        public DateTime TransDate { get; set; }
        public string Description { get; set; }
        public TType TransType { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal Amount { get; set; }
        public Operation Operation { get; set; }

        [DefaultValue(false)]
        public bool isClosed { get; set; }
    }
}
