﻿using System.ComponentModel.DataAnnotations;

namespace PMS.Models
{
    public class Saraf : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Bank Name")]
        public string SarafName { get; set; }

        [Required(ErrorMessage = "Please Enter Account Name")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Please Enter Account No")]
        public string AccountNo { get; set; }

        public string Branch { get; set; }

        public string Description { get; set; }

        public string Signature { get; set; }

    }
}
