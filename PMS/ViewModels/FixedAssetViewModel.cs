using System;

namespace PMS.ViewModels
{
    public class FixedAssetViewModel
    {
        public long Id { get; set; }
        public long SNO { get; set; }
        public long AssetCategoryId { get; set; }
        public string AssetCategoryName { get; set; }
        public string AssetTitle { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int TotalAvailStockQtys { get; set; }


    }
}
