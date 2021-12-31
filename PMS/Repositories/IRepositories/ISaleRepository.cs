using PMS.Models;
using PMS.Models.Sale;
using PMS.ViewModels.SaleViewModels;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface ISaleRepository
    {
        IEnumerable<SaleViewModel> GetAllSales();
        IEnumerable<SaleDetailsViewModel> GetAllSaleDetails(long id);
        ViewSaleDetailsViewModel GetSale(long id);
        long AddSale(CreateSaleViewModel createSaleViewModel);
        CreateSaleViewModel GetSaleForEdit(long id); //Sale Id... 
        string GetInvoiceNo();

        IEnumerable<ProductBatch> GetProductBatches(long productId);
        IEnumerable<ProductBatch> GetProductBatchesWithExpireDate(long productId);
        decimal GetProductUnitQty(long productId, long unitId);
        decimal GetUnitPrice(long productId, long unitId);

        ProductBatch GetSaleDetailsByBatchId(string batchId);
        SaleDetails GetSaleDetailsById(long id); //purchase details id...

        bool DeleteSale(long saleId);

        CreateSaleViewModel UpdateSale(CreateSaleViewModel createSaleViewModel);
    }
}
