using PMS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace PMS.ViewModels.Asset
{
    public class AssetHandoverDetailsViewModel
    {
        public int SNO { get; set; }
        public long AssetHandoverId { get; set; }
        public long AssetId { get; set; }
        public string AssetName { get; set; }
        [EnumDataType(typeof(AssetStatus))]
        public AssetStatus Status { get; set; }
        public int Qty { get; set; }
        public string Details { get; set; }
    }
}
