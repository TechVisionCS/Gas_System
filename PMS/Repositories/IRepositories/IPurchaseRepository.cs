using PMS.Models.Purchase;
using PMS.ViewModels.PurchaseViewModels;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IPurchaseRepository
    {
        IEnumerable<PurchaseViewModel> GetAllPurchases();

        IEnumerable<PurchaseDetailsViewModel> GetAllPurchaseDetails(long id);

        ViewPurchaseDetailsViewModel GetPurchase(long id);

        long AddPurchase(CreatePurchaseViewModel createPurchaseViewModel);
        CreatePurchaseViewModel GetPurchaseForEdit(long id); // Purchase Id
        PurchaseDetails GetPurchaseDetailsById(long id); //purchase details id...
        string GetProductBatchByPurchaseId_ProductId(long purchaseId, long productId);

        decimal GetUnitPrice(long unitId, long productId);
        decimal GetLastPurchasedUnitPrice(long unitId, long productId);

        bool DeletePurchase(long purchaseId);
        CreatePurchaseViewModel UpdatePurchase(CreatePurchaseViewModel createPurchaseViewModel);
    }
}
