using System.Collections.Generic;

namespace PMS.ViewModels.Asset
{
    public class ViewAssetHandoverDetailViewModel
    {
        public AssetHandoverViewModel AssetHandoverViewModel { get; set; }
        public IEnumerable<AssetHandoverDetailsViewModel> AssetHandoverDetailsViewModels { get; set; }

    }
}
