using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models.Lookup
{
    public class Province: BaseEntity.BaseEntity
    {
        public string Name { get; set; } 
        public long CountryId { get; set; }    
        public string CountryName { get; set; }     
        public string CountryCode { get; set; }
        public Country Country { get; set; }
    }
}
