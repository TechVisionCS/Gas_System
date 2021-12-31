using PMS.Models;
using PMS.ViewModels.Stock;
using PMS.ViewModels.StockViewModels;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IStockRepository
    {
        Stock AddProduct(Stock stock);

        IEnumerable<CurrentStockViewModel> GetCurrentStockDetails();
        IEnumerable<CurrentStockViewModel> GetCurrentStockDetails(long unitId);
        IEnumerable<StockDetaillsViewModel> GetProductStockDetailsById(long id);
        IEnumerable<StockDetaillsViewModel> GetProductStockDetailsById(long id, long unitId);
        IEnumerable<StockDetaillsViewModel> GetStockDetailsList();
        IEnumerable<StockDetaillsViewModel> GetStockDetailsList(long unitId);

        StockDetaillsViewModel GetEachStockDetails(long id);
        StockDetaillsViewModel GetEachStockDetails(long id, long unitId);
    }
}
