using System.Collections.Generic;

namespace PMS.Models.Lookup
{
    public class Country: BaseEntity.BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
