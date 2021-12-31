using PMS.Models.FixedAsset;
using PMS.ViewModels;
using PMS.ViewModels.Asset;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IFixedAssetRepository
    {
        IEnumerable<FixedAssetViewModel> GetAllFixedAssets();
        FixedAssetViewModel GetByIdFixedAsset(long id);
        Asset GetByIdForUpdate(long id);
        Asset AddFixedAsset(Asset fixedAsset);
        Asset UpdateFixedAsset(Asset fixedAsset);
        bool DeleteFixedAsset(long fixedAssetId);

        AssetStock GetByIdForUpdateStock(long id);
        AssetStock AddAssetStock(AssetStock assetStock);
        AssetStock UpdateAssetStock(AssetStock assetStock);
        IEnumerable<AssetStockViewModel> GetAssetStockDetails();

        // Stock Handover add 
        CreateAssetHandoverViewModel AddStockHandover(CreateAssetHandoverViewModel createAssetHandoverViewModel);
        CreateAssetHandoverViewModel GetStockHandoverForEdit(long id); // hANDOVERiD Id
        CreateAssetHandoverViewModel EditStockHandover(CreateAssetHandoverViewModel editAssetHandoverViewModel);
        bool DeleteStockHandover(long StockHandoverId);
        IEnumerable<AssetHandoverViewModel> GetAllAssetHandover();
        IEnumerable<AssetHandoverDetailsViewModel> GetAllAssetHandoverDetails(long id);
        ViewAssetHandoverDetailViewModel GetAssetGeneralDetails(long id);
    }
}
