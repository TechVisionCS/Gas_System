﻿using PMS.Models.Finance;
using PMS.Models.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class Supplier: BaseEntity.BaseEntity
    {
 
        [Required(ErrorMessage = "Please Enter Supplier Name")]
        public string Name { get; set; }

        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public long Countryid { get; set; }
        public long Provinceid { get; set; }
        public string Address { get; set; }
        public string Details { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        public decimal PreviousBalance { get; set; }

        //[ForeignKey("Countryid")]
        //public Country country { get; set; }

        //ForeignKey("Provinceid")]
        //public Province province { get; set; }
        //public ICollection<SupplierLedger> SupplierLedgers { get; set; }
    }
}
