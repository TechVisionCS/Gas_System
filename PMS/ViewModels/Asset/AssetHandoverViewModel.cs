using System;

namespace PMS.ViewModels.Asset
{
    public class AssetHandoverViewModel
    {
        public long Id { get; set; }
        public long SNo { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? HandoverDate { get; set; }
        public string HandoverRequestId { get; set; }
        public string HandoverRemarks { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
