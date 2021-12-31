using PMS.Data;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.Stock;
using PMS.ViewModels.StockViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;

        public StockRepository(ApplicationDbContext _dbContext, IHelperRepository _helperRepository)
        {
            dbContext = _dbContext;
            helperRepository = _helperRepository;
        }
        public Stock AddProduct(Stock stock)
        {
            if (dbContext != null)
            {
                stock.CreatedAt = DateTime.Now;
                stock.UpdatedAt = DateTime.Now;
                stock.UserId = helperRepository.GetCurrentUserId();
                stock.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Stocks.Add(stock);
                dbContext.SaveChanges();

                return stock;
            }

            return null;
        }

        public IEnumerable<CurrentStockViewModel> GetCurrentStockDetails()
        {
            if (dbContext != null)
            {
                List<CurrentStockViewModel> list = new List<CurrentStockViewModel>();
                var stockList = dbContext.Stocks.Where(x => x.StockQty > 0).ToList(); //Where condition for 0 amount of items was requested by Eng.Bismillah.... 
                var models2 = from s in stockList
                              group s by s.ProductId;

                if (models2 != null)
                {
                    foreach (var m2 in models2)
                    {
                        long sno = 1;
                        long cId = 0;
                        long tId = 0;
                        long sId = 0;
                        long uId = 0;
                        long mId = 0;

                        decimal totalPurchasedPrice = 0;
                        decimal totalSalePrice = 0;
                        decimal inQty = 0;
                        decimal outQty = 0;
                        decimal stockQty = 0;
                        var m = new Stock();

                        bool stop = false;
                        foreach (var nm in m2)
                        {
                            if (nm.StockQty != 0 && !stop)
                            {
                                var pDeletedAt = dbContext.Products.FirstOrDefault(x => x.Id == nm.ProductId).DeletedAt;
                                if (pDeletedAt != null && nm.StockQty == 0)
                                {
                                    continue;
                                }

                                var productBatches = dbContext.ProductBatches.Where(x => x.ProductId == nm.ProductId && x.DeletedAt == null && x.StockQty != 0).ToList();
                                if (productBatches.Any())
                                {
                                    foreach (var pb in productBatches)
                                    {
                                        totalPurchasedPrice += pb.StockQty * pb.PurchasePrice;
                                        //totalSalePrice += pb.StockQty * pb.SellPrice; //sell price will be calculated later
                                    }
                                }
                                else
                                {
                                    totalPurchasedPrice = 0;
                                    totalSalePrice = 0;
                                }
                                var stockItems = dbContext.Stocks.Where(x => x.ProductId == nm.ProductId && x.DeletedAt == null).ToList();

                                if (stockItems.Any())
                                {

                                    foreach (var item in stockItems)
                                    {
                                        inQty += (decimal)item.InQty;
                                        outQty += (decimal)item.OutQty;
                                        stockQty += (decimal)item.StockQty;
                                    }
                                }
                                else
                                {
                                    inQty = 0;
                                    outQty = 0;
                                    stockQty = 0;
                                }
                                stop = true; // Stop Repeted Loop Point
                            }
                            m = nm;
                        }

                        cId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).CategoryId;
                        mId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).ManufacturerId;
                        //tId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).TypeId;
                        //sId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).SupplierId;
                        //uId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).UnitId;

                        CurrentStockViewModel model = new CurrentStockViewModel
                        {
                            Id = m.Id,
                            SNo = sno++,
                            ProductId = m.ProductId,
                            ProductName = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Name,
                            ManufacturerId = mId,
                            ManufacturerName = dbContext.Manufacturers.FirstOrDefault(x => x.Id == mId).Name,
                            CategoryId = cId,
                            CategoryName = dbContext.Categories.FirstOrDefault(x => x.Id == cId).Name,
                            //TypeId = tId,
                            //TypeName = dbContext.ProductTypes.FirstOrDefault(x => x.Id == tId).TypeName,
                            //Model = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Model,
                            //UnitId = uId,
                            //UnitName = dbContext.Units.FirstOrDefault(x => x.Id == uId).Name,
                            //SupplierId = sId,
                            //SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == sId).Name,
                            TotalInQty = (float)inQty,
                            TotalOutQty = (float)outQty,
                            CurrentStockQty = (float)stockQty,
                            StockPurchasedPrice = totalPurchasedPrice,
                            StockSalesPrice = totalSalePrice

                        };
                        list.Add(model);
                    }
                }
                return list;
            }

            return null;
        }

        public IEnumerable<CurrentStockViewModel> GetCurrentStockDetails(long unitId)
        {
            if (dbContext != null)
            {
                var unitAmount = dbContext.Units.FirstOrDefault(x => x.Id == unitId).KgAmount;

                List<CurrentStockViewModel> list = new List<CurrentStockViewModel>();
                var stockList = dbContext.Stocks.Where(x => x.StockQty > 0).ToList(); //Where condition for 0 amount of items was requested by Eng.Bismillah.... 
                var models2 = from s in stockList
                              group s by s.ProductId;

                if (models2 != null)
                {
                    foreach (var m2 in models2)
                    {
                        long sno = 1;
                        long cId = 0;
                        long tId = 0;
                        long sId = 0;
                        long uId = 0;
                        long mId = 0;

                        decimal totalPurchasedPrice = 0;
                        decimal totalSalePrice = 0;
                        decimal inQty = 0;
                        decimal outQty = 0;
                        decimal stockQty = 0;
                        var m = new Stock();

                        bool stop = false;
                        foreach (var nm in m2)
                        {
                            if (nm.StockQty != 0 && !stop)
                            {
                                var pDeletedAt = dbContext.Products.FirstOrDefault(x => x.Id == nm.ProductId).DeletedAt;
                                if (pDeletedAt != null && nm.StockQty == 0)
                                {
                                    continue;
                                }

                                var productBatches = dbContext.ProductBatches.Where(x => x.ProductId == nm.ProductId && x.DeletedAt == null && x.StockQty != 0).ToList();
                                if (productBatches.Any())
                                {
                                    foreach (var pb in productBatches)
                                    {
                                        totalPurchasedPrice += pb.StockQty * pb.PurchasePrice;
                                        //totalSalePrice += pb.StockQty * pb.SellPrice; //sale price will be calculated later 
                                    }
                                }
                                else
                                {
                                    totalPurchasedPrice = 0;
                                    totalSalePrice = 0;
                                }
                                var stockItems = dbContext.Stocks.Where(x => x.ProductId == nm.ProductId && x.DeletedAt == null).ToList();

                                if (stockItems.Any())
                                {

                                    foreach (var item in stockItems)
                                    {
                                        inQty += (decimal)item.InQty;
                                        outQty += (decimal)item.OutQty;
                                        stockQty += (decimal)item.StockQty;
                                    }
                                }
                                else
                                {
                                    inQty = 0;
                                    outQty = 0;
                                    stockQty = 0;
                                }
                                stop = true; // Stop Repeted Loop Point
                            }
                            m = nm;
                        }

                        cId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).CategoryId;
                        mId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).ManufacturerId;
                        //tId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).TypeId;
                        //sId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).SupplierId;
                        //uId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).UnitId;

                        CurrentStockViewModel model = new CurrentStockViewModel
                        {
                            Id = m.Id,
                            SNo = sno++,
                            ProductId = m.ProductId,
                            ProductName = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Name,
                            ManufacturerId = mId,
                            ManufacturerName = dbContext.Manufacturers.FirstOrDefault(x => x.Id == mId).Name,
                            CategoryId = cId,
                            CategoryName = dbContext.Categories.FirstOrDefault(x => x.Id == cId).Name,
                            //TypeId = tId,
                            //TypeName = dbContext.ProductTypes.FirstOrDefault(x => x.Id == tId).TypeName,
                            //Model = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Model,
                            //UnitId = uId,
                            //UnitName = dbContext.Units.FirstOrDefault(x => x.Id == uId).Name,
                            //SupplierId = sId,
                            //SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == sId).Name,
                            TotalInQty = (float)inQty / (float)unitAmount,
                            TotalOutQty = (float)outQty / (float)unitAmount,
                            CurrentStockQty = (float)stockQty / (float)unitAmount,
                            StockPurchasedPrice = totalPurchasedPrice,
                            StockSalesPrice = totalSalePrice

                        };
                        list.Add(model);
                    }
                }
                return list;
            }

            return null;
        }

        public IEnumerable<StockDetaillsViewModel> GetProductStockDetailsById(long id)
        {
            if (dbContext != null)
            {
                List<StockDetaillsViewModel> list = new List<StockDetaillsViewModel>();
                var ModelList = dbContext.StockDetails.Where(x => x.ProductId == id).ToList(); // Only Releted To Product View Is Viewd
                long sno = 1;
                long cId = 0;
                long tId = 0;
                long sId = 0;
                long uId = 0;
                long mId = 0;

                foreach (var m in ModelList)
                {
                    cId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).CategoryId;
                    mId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).ManufacturerId;
                    //tId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).TypeId;
                    //sId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).SupplierId;
                    //uId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).UnitId;

                    StockDetaillsViewModel model = new StockDetaillsViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        ProductId = m.ProductId,
                        ProductName = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Name,
                        ManufacturerId = mId,
                        ManufacturerName = dbContext.Manufacturers.FirstOrDefault(x => x.Id == mId).Name,
                        CategoryId = cId,
                        CategoryName = dbContext.Categories.FirstOrDefault(x => x.Id == cId).Name,
                        //TypeId = tId,
                        //TypeName = dbContext.ProductTypes.FirstOrDefault(x => x.Id == tId).TypeName,
                        //Model = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Model,
                        //UnitId = uId,
                        //UnitName = dbContext.Units.FirstOrDefault(x => x.Id == uId).Name,
                        //SupplierId = sId,
                        //SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == sId).Name,
                        InQty = m.InQty,
                        OutQty = m.OutQty,
                        PurchasePrice = m.PurchasePrice,
                        SalePrice = m.SalePrice,
                        TransCode = m.TransCode,
                        Description = m.Description,
                        UserId = m.UserId,
                        UserName = helperRepository.GetUserName(m.UserId),
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt
                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public IEnumerable<StockDetaillsViewModel> GetProductStockDetailsById(long id, long unitId)
        {
            if (dbContext != null)
            {
                var unitAmount = dbContext.Units.FirstOrDefault(x => x.Id == unitId).KgAmount;

                List<StockDetaillsViewModel> list = new List<StockDetaillsViewModel>();
                var ModelList = dbContext.StockDetails.Where(x => x.ProductId == id).ToList(); // Only Releted To Product View Is Viewd
                long sno = 1;
                long cId = 0;
                long tId = 0;
                long sId = 0;
                long uId = 0;
                long mId = 0;

                foreach (var m in ModelList)
                {
                    cId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).CategoryId;
                    mId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).ManufacturerId;
                    //tId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).TypeId;
                    //sId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).SupplierId;
                    //uId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).UnitId;

                    StockDetaillsViewModel model = new StockDetaillsViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        ProductId = m.ProductId,
                        ProductName = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Name,
                        ManufacturerId = mId,
                        ManufacturerName = dbContext.Manufacturers.FirstOrDefault(x => x.Id == mId).Name,
                        CategoryId = cId,
                        CategoryName = dbContext.Categories.FirstOrDefault(x => x.Id == cId).Name,
                        //TypeId = tId,
                        //TypeName = dbContext.ProductTypes.FirstOrDefault(x => x.Id == tId).TypeName,
                        //Model = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Model,
                        //UnitId = uId,
                        //UnitName = dbContext.Units.FirstOrDefault(x => x.Id == uId).Name,
                        //SupplierId = sId,
                        //SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == sId).Name,
                        InQty = m.InQty / unitAmount,
                        OutQty = m.OutQty / unitAmount,
                        PurchasePrice = m.PurchasePrice,
                        SalePrice = m.SalePrice,
                        TransCode = m.TransCode,
                        Description = m.Description,
                        UserId = m.UserId,
                        UserName = helperRepository.GetUserName(m.UserId),
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt
                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public IEnumerable<StockDetaillsViewModel> GetStockDetailsList()
        {
            if (dbContext != null)
            {
                List<StockDetaillsViewModel> list = new List<StockDetaillsViewModel>();

                var ModelList = dbContext.StockDetails.ToList(); // Only Selected Id Details is Views Over all
                long sno = 1;
                long cId = 0;
                long tId = 0;
                long sId = 0;
                long uId = 0;
                long mId = 0;

                foreach (var m in ModelList)
                {
                    cId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).CategoryId;
                    mId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).ManufacturerId;
                    //tId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).TypeId;
                    //sId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).SupplierId;
                    //uId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).UnitId;

                    StockDetaillsViewModel model = new StockDetaillsViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        ProductId = m.ProductId,
                        ProductName = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Name,
                        ManufacturerId = mId,
                        ManufacturerName = dbContext.Manufacturers.FirstOrDefault(x => x.Id == mId).Name,
                        CategoryId = cId,
                        CategoryName = dbContext.Categories.FirstOrDefault(x => x.Id == cId).Name,
                        //TypeId = tId,
                        //TypeName = dbContext.ProductTypes.FirstOrDefault(x => x.Id == tId).TypeName,
                        //Model = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Model,
                        //UnitId = uId,
                        //UnitName = dbContext.Units.FirstOrDefault(x => x.Id == uId).Name,
                        //SupplierId = sId,
                        //SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == sId).Name,
                        InQty = m.InQty,
                        OutQty = m.OutQty,
                        PurchasePrice = m.PurchasePrice,
                        SalePrice = m.SalePrice,
                        TransCode = m.TransCode,
                        Description = m.Description,
                        UserId = m.UserId,
                        UserName = helperRepository.GetUserName(m.UserId),
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt

                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public IEnumerable<StockDetaillsViewModel> GetStockDetailsList(long unitId)
        {
            if (dbContext != null)
            {
                var unitAmount = dbContext.Units.FirstOrDefault(x => x.Id == unitId).KgAmount;

                List<StockDetaillsViewModel> list = new List<StockDetaillsViewModel>();

                var ModelList = dbContext.StockDetails.ToList(); // Only Selected Id Details is Views Over all
                long sno = 1;
                long cId = 0;
                long tId = 0;
                long sId = 0;
                long uId = 0;
                long mId = 0;

                foreach (var m in ModelList)
                {
                    cId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).CategoryId;
                    mId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).ManufacturerId;
                    //tId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).TypeId;
                    //sId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).SupplierId;
                    //uId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).UnitId;

                    StockDetaillsViewModel model = new StockDetaillsViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        ProductId = m.ProductId,
                        ProductName = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Name,
                        ManufacturerId = mId,
                        ManufacturerName = dbContext.Manufacturers.FirstOrDefault(x => x.Id == mId).Name,
                        CategoryId = cId,
                        CategoryName = dbContext.Categories.FirstOrDefault(x => x.Id == cId).Name,
                        //TypeId = tId,
                        //TypeName = dbContext.ProductTypes.FirstOrDefault(x => x.Id == tId).TypeName,
                        //Model = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Model,
                        //UnitId = uId,
                        //UnitName = dbContext.Units.FirstOrDefault(x => x.Id == uId).Name,
                        //SupplierId = sId,
                        //SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == sId).Name,
                        InQty = m.InQty / unitAmount,
                        OutQty = m.OutQty / unitAmount,
                        PurchasePrice = m.PurchasePrice,
                        SalePrice = m.SalePrice,
                        TransCode = m.TransCode,
                        Description = m.Description,
                        UserId = m.UserId,
                        UserName = helperRepository.GetUserName(m.UserId),
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt

                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }
        public StockDetaillsViewModel GetEachStockDetails(long id)
        {
            if (dbContext != null)
            {

                var m = dbContext.StockDetails.FirstOrDefault(x => x.Id == id); // Only Selected Id Details is Views Over all
                long sno = 1;
                long cId = 0;
                long tId = 0;
                long sId = 0;
                long uId = 0;
                long mId = 0;


                cId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).CategoryId;
                mId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).ManufacturerId;
                //tId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).TypeId;
                //sId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).SupplierId;
                //uId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).UnitId;

                StockDetaillsViewModel model = new StockDetaillsViewModel
                {
                    Id = m.Id,
                    SNo = sno++,
                    ProductId = m.ProductId,
                    ProductName = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Name,
                    ManufacturerId = mId,
                    ManufacturerName = dbContext.Manufacturers.FirstOrDefault(x => x.Id == mId).Name,
                    CategoryId = cId,
                    CategoryName = dbContext.Categories.FirstOrDefault(x => x.Id == cId).Name,
                    //TypeId = tId,
                    //TypeName = dbContext.ProductTypes.FirstOrDefault(x => x.Id == tId).TypeName,
                    //Model = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Model,
                    //UnitId = uId,
                    //UnitName = dbContext.Units.FirstOrDefault(x => x.Id == uId).Name,
                    //SupplierId = sId,
                    //SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == sId).Name,
                    InQty = m.InQty,
                    OutQty = m.OutQty,
                    PurchasePrice = m.PurchasePrice,
                    SalePrice = m.SalePrice,
                    TransCode = m.TransCode,
                    Description = m.Description,
                    UserId = m.UserId,
                    UserName = helperRepository.GetUserName(m.UserId),
                    CreatedAt = m.CreatedAt,
                    UpdatedAt = m.UpdatedAt,
                    DeletedAt = m.DeletedAt

                };

                return model;
            }
            return null;
        }

        public StockDetaillsViewModel GetEachStockDetails(long id, long unitId)
        {
            if (dbContext != null)
            {
                var unitAmount = dbContext.Units.FirstOrDefault(x => x.Id == unitId).KgAmount;

                var m = dbContext.StockDetails.FirstOrDefault(x => x.Id == id); // Only Selected Id Details is Views Over all
                long sno = 1;
                long cId = 0;
                long tId = 0;
                long sId = 0;
                long uId = 0;
                long mId = 0;


                cId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).CategoryId;
                mId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).ManufacturerId;
                //tId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).TypeId;
                //sId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).SupplierId;
                //uId = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).UnitId;

                StockDetaillsViewModel model = new StockDetaillsViewModel
                {
                    Id = m.Id,
                    SNo = sno++,
                    ProductId = m.ProductId,
                    ProductName = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Name,
                    ManufacturerId = mId,
                    ManufacturerName = dbContext.Manufacturers.FirstOrDefault(x => x.Id == mId).Name,
                    CategoryId = cId,
                    CategoryName = dbContext.Categories.FirstOrDefault(x => x.Id == cId).Name,
                    //TypeId = tId,
                    //TypeName = dbContext.ProductTypes.FirstOrDefault(x => x.Id == tId).TypeName,
                    //Model = dbContext.Products.FirstOrDefault(x => x.Id == m.ProductId).Model,
                    //UnitId = uId,
                    //UnitName = dbContext.Units.FirstOrDefault(x => x.Id == uId).Name,
                    //SupplierId = sId,
                    //SupplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == sId).Name,
                    InQty = m.InQty / unitAmount,
                    OutQty = m.OutQty / unitAmount,
                    PurchasePrice = m.PurchasePrice,
                    SalePrice = m.SalePrice,
                    TransCode = m.TransCode,
                    Description = m.Description,
                    UserId = m.UserId,
                    UserName = helperRepository.GetUserName(m.UserId),
                    CreatedAt = m.CreatedAt,
                    UpdatedAt = m.UpdatedAt,
                    DeletedAt = m.DeletedAt

                };

                return model;
            }
            return null;
        }

    }
}
