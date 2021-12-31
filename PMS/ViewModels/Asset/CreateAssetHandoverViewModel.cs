using PMS.Models.FixedAsset;
using System.Collections.Generic;

namespace PMS.ViewModels.Asset
{
    public class CreateAssetHandoverViewModel
    {
        public AssetHandover AssetHandover { get; set; }
        public IEnumerable<AssetHandoverDetails> AssetHandoverDetailss { get; set; }
    }
}
