using PMS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models.FixedAsset
{
    public class Asset : BaseEntity.BaseEntity
    {
        public long AssetCategoryId { get; set; }
        [Required(ErrorMessage = "Please enter asset title!")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public int InQty { get; set; }
        public int OutQty { get; set; }
        public int StockQty { get; set; }

        [EnumDataType(typeof(AssetStatus))]
        public AssetStatus Status { get; set; }
    }
}