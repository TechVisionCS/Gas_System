using PMS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace PMS.Models.FixedAsset
{
    public class AssetHandoverDetails : BaseEntity.BaseEntity
    {
        [Required]
        public long AssetHandoverId { get; set; }

        [Required(ErrorMessage = "please select asset !")]
        public long AssetId { get; set; }
        [EnumDataType(typeof(AssetStatus))]
        public AssetStatus Status { get; set; }
        public int Qty { get; set; }
        public string Details { get; set; }

    }
}
