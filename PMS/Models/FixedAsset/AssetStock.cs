using PMS.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models.FixedAsset
{
    public class AssetStock : BaseEntity.BaseEntity
    {
        public long AssetId { get; set; }

        [Required(ErrorMessage = "Please Enter Purchase Date")]
        public DateTime? PurchaseDate { get; set; }
        public DateTime? ExpiryDate { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity")]
        public int InQty { get; set; }
        public int OutQty { get; set; }
        public int StockQty { get; set; }
        public string Description { get; set; }

        [EnumDataType(typeof(AssetStatus))]
        public AssetStatus Status { get; set; }
    }
}
