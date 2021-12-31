using PMS.Data;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly IStockRepository stockRepository;

        public ProductRepository(ApplicationDbContext _dbContext,
            IHelperRepository _helperRepository,
            IStockRepository _stockRepository)
        {
            dbContext = _dbContext;
            helperRepository = _helperRepository;
            stockRepository = _stockRepository;
        }

        public IEnumerable<ProductIndexViewModel> GetAllProducts()
        {
            if (dbContext != null)
            {
                List<ProductIndexViewModel> list = new List<ProductIndexViewModel>();
                var models = dbContext.Products.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                var Category = "";
                var Unit = "";
                var Manufecture = "";

                foreach (var m in models)
                {

                    if (m.CategoryId == 0)
                    {
                        Category = "";
                    }

                    else
                    {
                        Category = dbContext.Categories.FirstOrDefault(x => x.Id == m.CategoryId).Name;
                    }

                    if (m.ManufacturerId == 0)
                    {
                        Manufecture = "";
                    }

                    else
                    {
                        Manufecture = dbContext.Manufacturers.FirstOrDefault(x => x.Id == m.ManufacturerId).Name;
                    }

                    ProductIndexViewModel model = new ProductIndexViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        Name = m.Name,
                        CategoryId = m.CategoryId,
                        CategoryName = Category,
                        ManufacturerId = m.ManufacturerId,
                        ManufacturerName = Manufecture,
                        TotalAvailStockQtys = dbContext.Stocks.Where(x => x.ProductId == m.Id).Sum(x => x.StockQty)
                    };

                    list.Add(model);

                }
                return list;
            }

            return null;
        }

        public ProductIndexViewModel GetById(long id)
        {
            if (dbContext != null)
            {
                var models = dbContext.Products.Where(x => x.Id == id && x.DeletedAt == null).ToList();
                var Category = "";
                var Unit = "";
                var Manufecture = "";

                foreach (var m in models)
                {


                    if (m.CategoryId == 0)
                    {
                        Category = "";
                    }

                    else
                    {
                        Category = dbContext.Categories.FirstOrDefault(x => x.Id == m.CategoryId).Name;
                    }


                    if (m.ManufacturerId == 0)
                    {
                        Manufecture = "";
                    }

                    else
                    {
                        Manufecture = dbContext.Manufacturers.FirstOrDefault(x => x.Id == m.ManufacturerId).Name;
                    }

                    ProductIndexViewModel model = new ProductIndexViewModel
                    {
                        Id = m.Id,
                        Name = m.Name,
                        CategoryId = m.CategoryId,
                        CategoryName = Category,
                        ManufacturerId = m.ManufacturerId,
                        ManufacturerName = Manufecture,
                        TotalAvailStockQtys = dbContext.Stocks.Where(x => x.ProductId == m.Id).Sum(x => x.StockQty),
                        Description = m.Description,
                        UserName = helperRepository.GetUserName(m.UserId),
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt
                    };

                    return model;
                }
                return null;
            }

            return null;
        }

        public ProductDetailsViewModel GetProductDetails(long id)
        {
            if (dbContext != null)
            {
                var product = dbContext.Products.FirstOrDefault(x => x.Id == id);
                if (product != null)
                {
                    var productViewModel = GetById(id);
                    var stockDetails = stockRepository.GetProductStockDetailsById(id).ToList();

                    var productUnits = dbContext.ProductUnits.Where(x => x.ProductId == id);
                    List<ProductUnit> list = new List<ProductUnit>();
                    if (productUnits.Any())
                    {
                        foreach (var pu in productUnits)
                        {
                            ProductUnit u = new ProductUnit
                            {
                                ProductId = id,
                                UnitId = pu.UnitId,
                                UnitSellPrice = pu.UnitSellPrice,
                                Unit = dbContext.Units.FirstOrDefault(x => x.Id == pu.UnitId)
                            };
                            list.Add(u);
                        }
                    }

                    ProductDetailsViewModel model = new ProductDetailsViewModel()
                    {
                        ProductDetails = productViewModel,
                        StockDetails = stockDetails,
                        ProductUnits = list
                    };
                    return model;
                }
                return null;
            }
            return null;
        }

        public ProductDetailsViewModel GetProductDetails(long id, long unitId)
        {
            if (dbContext != null)
            {
                var product = dbContext.Products.FirstOrDefault(x => x.Id == id);
                if (product != null)
                {
                    var unitAmount = dbContext.Units.FirstOrDefault(x => x.Id == unitId).KgAmount;

                    var productViewModel = GetById(id);
                    productViewModel.TotalAvailStockQtys = productViewModel.TotalAvailStockQtys / unitAmount;

                    var stockDetails = stockRepository.GetProductStockDetailsById(id).ToList();

                    foreach (var sd in stockDetails)
                    {
                        sd.InQty = sd.InQty / unitAmount;
                        sd.OutQty = sd.OutQty / unitAmount;
                    }

                    var productUnits = dbContext.ProductUnits.Where(x => x.ProductId == id);
                    List<ProductUnit> list = new List<ProductUnit>();
                    if (productUnits.Any())
                    {
                        foreach (var pu in productUnits)
                        {
                            ProductUnit u = new ProductUnit
                            {
                                ProductId = id,
                                UnitId = pu.UnitId,
                                UnitSellPrice = pu.UnitSellPrice,
                                Unit = dbContext.Units.FirstOrDefault(x => x.Id == pu.UnitId)
                            };
                            list.Add(u);
                        }
                    }

                    ProductDetailsViewModel model = new ProductDetailsViewModel()
                    {
                        ProductDetails = productViewModel,
                        StockDetails = stockDetails,
                        ProductUnits = list
                    };
                    return model;
                }
                return null;
            }
            return null;
        }

        public Product GetByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                var product = dbContext.Products.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                return product;
            }
            return null;
        }
        public Product AddProduct(Product product, List<ProductUnit> list)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                product.CreatedAt = DateTime.Now;
                product.UpdatedAt = DateTime.Now;
                product.UserId = helperRepository.GetCurrentUserId();
                product.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                var ProductId = AddProductDetails(product, list);


                if (ProductId != 0)
                {
                    Stock stock = new Stock
                    {
                        ProductId = ProductId,
                        InQty = 0,
                        OutQty = 0,
                        StockQty = 0,
                        TotalStockPurchasePrice = 0,
                        TotalStockSalePrice = 0
                    };

                    stockRepository.AddProduct(stock);
                }
                else
                {
                    return null;
                }
                transaction.Commit();

                return product;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }

            return null;
        }
        public Product UpdateProduct(Product product, List<ProductUnit> list)
        {
            if (dbContext != null)
            {
                product.UpdatedAt = DateTime.Now;
                product.UserId = helperRepository.GetCurrentUserId();
                product.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Products.Update(product);
                dbContext.SaveChanges();

                var oldunits = dbContext.ProductUnits.Where(x => x.ProductId == product.Id).ToList();
                dbContext.RemoveRange(oldunits);
                dbContext.SaveChanges();

                List<ProductUnit> updatedlist = new List<ProductUnit>();
                foreach (var u in list)
                {
                    ProductUnit unit = new ProductUnit
                    {
                        UnitId = u.UnitId,
                        ProductId = product.Id,
                        UnitSellPrice = u.UnitSellPrice
                    };

                    updatedlist.Add(unit);
                }

                dbContext.ProductUnits.AddRange(updatedlist);
                dbContext.SaveChanges();

                return product;
            }

            return null;
        }
        public bool DeleteProduct(long id)
        {
            if (dbContext != null)
            {
                var product = dbContext.Products.FirstOrDefault(x => x.Id == id);
                product.DeletedAt = DateTime.Now;
                product.UserId = helperRepository.GetCurrentUserId();
                product.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Products.Update(product);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }


        private long AddProductDetails(Product product, List<ProductUnit> list)
        {
            if (dbContext != null)
            {
                product.CreatedAt = DateTime.Now;
                product.UpdatedAt = DateTime.Now;
                product.UserId = helperRepository.GetCurrentUserId();
                product.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Products.Add(product);
                dbContext.SaveChanges();

                var maxId = dbContext.Products.Max(x => x.Id);

                List<ProductUnit> updatedlist = new List<ProductUnit>();
                foreach (var u in list)
                {
                    ProductUnit unit = new ProductUnit
                    {
                        UnitId = u.UnitId,
                        ProductId = maxId,
                        UnitSellPrice = u.UnitSellPrice
                    };

                    updatedlist.Add(unit);
                }

                dbContext.ProductUnits.AddRange(updatedlist);
                dbContext.SaveChanges();

                return maxId;
            }
            return 0;
        }

        public IEnumerable<ProductBatch> GetAllProductBatches(long productId)
        {
            if (dbContext != null)
            {
                var prodcutBatches = dbContext.ProductBatches.Where(x => x.ProductId == productId && x.DeletedAt == null).ToList();
                return prodcutBatches;
            }
            return null;
        }

        public IEnumerable<ProductUnit> GetAllProductUnits(long productId)
        {
            if (dbContext != null)
            {
                var prodcutUnits = dbContext.ProductUnits.Where(x => x.ProductId == productId).ToList();
                List<ProductUnit> list = new List<ProductUnit>();
                if (prodcutUnits.Any())
                {
                    foreach (var p in prodcutUnits)
                    {
                        ProductUnit unit = new ProductUnit
                        {
                            UnitId = p.UnitId,
                            ProductId = productId,
                            Unit = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId),
                            UnitSellPrice = p.UnitSellPrice
                        };

                        list.Add(unit);
                    }
                }

                return list;
            }
            return null;
        }

        public decimal GetProductAvailQty(long productId, long unitId)
        {
            if (dbContext != null)
            {
                var qty = dbContext.Stocks.Where(x => x.ProductId == productId).Sum(x => x.StockQty);
                var unitAmount = dbContext.Units.FirstOrDefault(x => x.Id == unitId).KgAmount;
                var currentQty = qty / unitAmount;

                return (decimal)currentQty;
            }
            return 0;
        }

        public decimal UpdateSalePrice(decimal SalePrice, long UnitId, long ProductId)
        {
            if (dbContext != null)
            {
                var model = dbContext.ProductUnits.FirstOrDefault(x => x.ProductId == ProductId && x.UnitId == UnitId);

                if (model != null)
                {
                    model.UnitSellPrice = SalePrice;

                    dbContext.ProductUnits.Update(model);
                    dbContext.SaveChanges();
                }
                return 1;
            }
            return 0;
        }

        public IEnumerable<ProductDropDownListViewModel> ProductsList()
        {
            if (dbContext != null)
            {
                var models = dbContext.Products.Where(x => x.DeletedAt == null).ToList();
                List<ProductDropDownListViewModel> list = new List<ProductDropDownListViewModel>();
                foreach (var model in models)
                {
                    ProductDropDownListViewModel m = new ProductDropDownListViewModel
                    {
                        Id = model.Id,
                        Name = model.Name
                    };

                    list.Add(m);
                }

                return list;

            }
            return null;
        }
    }
}
