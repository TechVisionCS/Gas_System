﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models.Lookup
{
    public class Category: BaseEntity.BaseEntity
    {
        [Required(ErrorMessage="Enter Category Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } = 1;
        
    }
}
