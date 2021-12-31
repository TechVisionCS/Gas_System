using System;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models.FixedAsset
{
    public class AssetHandover : BaseEntity.BaseEntity
    {
        [Required(ErrorMessage = "please select employee name !")]
        public long EmployeeId { get; set; }
        public DateTime? HandoverDate { get; set; }
        public string HandoverRequestId { get; set; }
        public string HandoverRemarks { get; set; }
        // public long HandoverBy { get; set; }
    }
}
