using PMS.Models;
using PMS.ViewModels.ProductViewModels;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductIndexViewModel> GetAllProducts();
        ProductIndexViewModel GetById(long id);
        Product GetByIdForUpdate(long id);
        Product AddProduct(Product product, List<ProductUnit> list);
        Product UpdateProduct(Product product, List<ProductUnit> list);
        bool DeleteProduct(long Id);
        ProductDetailsViewModel GetProductDetails(long id);
        ProductDetailsViewModel GetProductDetails(long id, long unitId);

        IEnumerable<ProductBatch> GetAllProductBatches(long productId);
        IEnumerable<ProductUnit> GetAllProductUnits(long productId);

        decimal GetProductAvailQty(long productId, long unitId);

        decimal UpdateSalePrice(decimal SalePrice, long UnitId, long ProductId);

        IEnumerable<ProductDropDownListViewModel> ProductsList();
    }
}
