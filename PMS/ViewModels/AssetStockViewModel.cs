using PMS.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PMS.ViewModels
{
    public class AssetStockViewModel
    {
        public long Id { get; set; }
        public long SNO { get; set; }
        public long AssetId { get; set; }
        public string AssetName { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }

        [EnumDataType(typeof(AssetStatus))]
        public AssetStatus Status { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int TotalAvailStockQtys { get; set; }


    }
}
