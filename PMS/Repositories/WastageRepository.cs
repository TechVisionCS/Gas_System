using PMS.Data;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels.Wastages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class WastageRepository : IWastageRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly PMSHelper pmsHelper;
        private readonly ITransactionRepository transactionRepository;
        private readonly IStockRepository stockRepository;
        private readonly IProductRepository productRepository;

        public WastageRepository(ApplicationDbContext dbContext,
                                  IHelperRepository helperRepository,
                                  PMSHelper pmsHelper,
                                  ITransactionRepository transactionRepository,
                                  IStockRepository stockRepository,
                                  IProductRepository productRepository)
        {
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
            this.pmsHelper = pmsHelper;
            this.transactionRepository = transactionRepository;
            this.stockRepository = stockRepository;
            this.productRepository = productRepository;
        }

        public IEnumerable<Wastage> GetAllWastages()
        {
            if (dbContext != null)
            {
                var models = dbContext.Wastages.Where(x => x.DeletedAt == null).ToList();
                if (models != null)
                {
                    return models;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public IEnumerable<Wastage> GetAllWastagesByDate(DateTime? startDate = null, DateTime? endDate = null)
        {
            if (dbContext != null)
            {
                var models = dbContext.Wastages.Where(x => x.DeletedAt == null).ToList();
                if (startDate != null)
                {
                    models = models.Where(x => x.WastageDate >= startDate).ToList();
                }

                if (endDate != null)
                {
                    models = models.Where(x => x.WastageDate <= endDate).ToList();
                }

                if (models != null)
                {
                    return models;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public WastageViewModel GetWastage(long id)
        {
            if (dbContext != null)
            {
                var wastage = dbContext.Wastages.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                var wastageDetails = dbContext.WastageDetails.Where(x => x.WastageId == id).ToList();

                List<WastageDetailsViewModel> list = new List<WastageDetailsViewModel>();
                if (wastageDetails.Any())
                {
                    foreach (var w in wastageDetails)
                    {
                        var pro = dbContext.Products.FirstOrDefault(x => x.Id == w.ProductId);
                        var productName = pro.Name;// + "-" + pro.Model;
                        WastageDetailsViewModel m = new WastageDetailsViewModel
                        {
                            Id = w.Id,
                            ProductId = w.ProductId,
                            Product = pro,
                            UnitId = w.UnitId,
                            Unit = dbContext.Units.FirstOrDefault(x => x.Id == w.UnitId),
                            Qty = w.Qty,
                            UnitPrice = w.UnitPrice,
                            TotalPrice = w.TotalPrice,
                            WastageId = id
                        };
                        list.Add(m);
                    }
                }

                WastageViewModel model = new WastageViewModel
                {
                    Wastage = wastage,
                    WastageDetails = list
                };

                return model;
            }
            return null;
        }

        public bool AddWastage(Wastage wastage, IEnumerable<WastageDetails> wastageDetails)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var transCode = helperRepository.GetTransactionCode();
                var wastageId = SaveWastage(wastage, transCode);

                if (wastageId != 0)
                {
                    var wastageDetail = AddWastageDetails(wastageId, wastageDetails);
                    if (wastageDetail)
                    {
                        //Add to Stock
                        var stockDetails = AddStockDetails(wastageDetails, transCode, wastageId);
                        if (!stockDetails)
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }


                transaction.Commit();
                return true;
                //}
                //catch (Exception)
                //{
                //    return false;
                //}
            }
            return false;
        }

        private long SaveWastage(Wastage model, string transCode)
        {
            if (dbContext != null)
            {
                model.CreatedAt = DateTime.Now;
                model.UpdatedAt = DateTime.Now;
                model.UserId = helperRepository.GetCurrentUserId();
                model.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                model.TransCode = transCode;

                dbContext.Wastages.Add(model);
                dbContext.SaveChanges();

                var maxId = dbContext.Wastages.Max(x => x.Id);
                return maxId;
            }

            return 0;
        }

        private bool AddWastageDetails(long wastageId, IEnumerable<WastageDetails> details)
        {
            if (dbContext != null)
            {
                foreach (var d in details)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.WastageId = wastageId;
                }
                dbContext.WastageDetails.AddRange(details);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        private bool AddStockDetails(IEnumerable<WastageDetails> wastageDetails, string transCode, long wastageId)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in wastageDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = 0,
                        OutQty = QtyUnits,
                        StockQty = 0 - QtyUnits,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list.Add(model);

                    //Add Stock Details
                    if (!StockDetails(p, transCode, wastageId))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool StockDetails(WastageDetails p, string tcode, long wastageId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = -2,
                    CustomerId = -2,
                    InQty = 0,
                    OutQty = QtyUnits,
                    PurchasePrice = p.UnitPrice,
                    SalePrice = 0,
                    TransCode = tcode,
                    Description = helperRepository.WastageStockMsg(p.ProductId, wastageId),

                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = helperRepository.GetCurrentUserId(),
                    UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                };

                dbContext.StockDetails.Add(model);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        public bool DeleteWastage(long wastageId)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var Wastage = dbContext.Wastages.FirstOrDefault(x => x.Id == wastageId && x.DeletedAt == null);
                var WastageDetails = dbContext.WastageDetails.Where(x => x.WastageId == wastageId && x.DeletedAt == null).ToList();
                if (Wastage != null)
                {
                    var transCode = Wastage.TransCode;

                    Wastage.DeletedAt = DateTime.Now;
                    Wastage.UpdatedAt = DateTime.Now;
                    Wastage.UserId = helperRepository.GetCurrentUserId();
                    Wastage.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    dbContext.Wastages.Update(Wastage);
                    dbContext.SaveChanges();

                    if (WastageDetails.Any())
                    {
                        foreach (var d in WastageDetails)
                        {
                            d.DeletedAt = DateTime.Now;
                            d.UpdatedAt = DateTime.Now;
                            d.UserId = helperRepository.GetCurrentUserId();
                            d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());
                        }
                        dbContext.WastageDetails.UpdateRange(WastageDetails);
                        dbContext.SaveChanges();

                        //Update Stock
                        var stk = DeleteWastage_UpdateStock(Wastage, WastageDetails);
                        if (!stk)
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

                transaction.Commit();
                return true;
                //}
                //catch (Exception)
                //{
                //    return false;
                //}
            }
            return false;
        }
        private bool DeleteWastage_UpdateStock(Wastage wastage, IEnumerable<WastageDetails> wastageDetails)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in wastageDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = QtyUnits,
                        OutQty = 0,
                        StockQty = QtyUnits - 0,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list.Add(model);

                    //Add Stock Details
                    if (!DeleteWastage_StockDetails(p, wastage.TransCode, wastage.Id))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool DeleteWastage_StockDetails(WastageDetails p, string tcode, long wastageId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = -2,
                    CustomerId = -2,
                    InQty = QtyUnits,
                    OutQty = 0,
                    PurchasePrice = p.UnitPrice,
                    SalePrice = 0,
                    TransCode = tcode,
                    Description = helperRepository.WastageStockMsg_Delete(p.ProductId, wastageId),

                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = helperRepository.GetCurrentUserId(),
                    UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                };

                dbContext.StockDetails.Add(model);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        public bool UpdateWastage(Wastage wastage, IEnumerable<WastageDetails> wastageDetails)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var transCode = wastage.TransCode;
                var oldWastageDetails = dbContext.WastageDetails.Where(x => x.WastageId == wastage.Id).ToList();

                if (wastage != null)
                {
                    wastage.UpdatedAt = DateTime.Now;
                    wastage.UserId = helperRepository.GetCurrentUserId();
                    wastage.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    dbContext.Wastages.Update(wastage);
                    dbContext.SaveChanges();

                    if (oldWastageDetails.Any())
                    {
                        dbContext.WastageDetails.RemoveRange(oldWastageDetails);
                        dbContext.SaveChanges();

                        var wastageDetail = AddWastageDetails(wastage.Id, wastageDetails);
                        if (wastageDetail)
                        {
                            //Stock...
                            var stk = UpdateWastage_UpdateStock(wastage, wastageDetails, oldWastageDetails);
                            if (!stk)
                            {
                                return false;
                            }

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }

                transaction.Commit();
                return true;
                //}
                //catch (Exception)
                //{
                //    return false;
                //}
            }
            return false;
        }

        private bool UpdateWastage_UpdateStock(Wastage wastage, IEnumerable<WastageDetails> wastageDetails, IEnumerable<WastageDetails> oldWastageDetails)
        {
            if (dbContext != null)
            {
                List<Stock> list = new List<Stock>();
                foreach (var p in oldWastageDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = QtyUnits,
                        OutQty = 0,
                        StockQty = QtyUnits - 0,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list.Add(model);

                    //Add Stock Details
                    if (!UpdateWastage_StockDetails_Remove(p, wastage.TransCode, wastage.Id))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list);
                dbContext.SaveChanges();


                List<Stock> list2 = new List<Stock>();
                foreach (var p in wastageDetails)
                {
                    var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                    float QtyUnits = (float)p.Qty * kgunits;

                    Stock model = new Stock
                    {
                        ProductId = p.ProductId,
                        InQty = 0,
                        OutQty = QtyUnits,
                        StockQty = 0 - QtyUnits,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };

                    list2.Add(model);

                    //Add Stock Details
                    if (!UpdateWastage_StockDetails_Add(p, wastage.TransCode, wastage.Id))
                    {
                        return false;
                    }
                }

                dbContext.Stocks.AddRange(list2);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool UpdateWastage_StockDetails_Remove(WastageDetails p, string tcode, long wastageId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = -2,
                    CustomerId = -2,
                    InQty = QtyUnits,
                    OutQty = 0,
                    PurchasePrice = p.UnitPrice,
                    SalePrice = 0,
                    TransCode = tcode,
                    Description = helperRepository.WastageStockMsg_Delete(p.ProductId, wastageId),

                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = helperRepository.GetCurrentUserId(),
                    UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                };

                dbContext.StockDetails.Add(model);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool UpdateWastage_StockDetails_Add(WastageDetails p, string tcode, long wastageId)
        {
            if (dbContext != null)
            {
                var kgunits = dbContext.Units.FirstOrDefault(x => x.Id == p.UnitId).KgAmount;
                float QtyUnits = (float)p.Qty * kgunits;

                StockDetails model = new StockDetails
                {
                    ProductId = p.ProductId,
                    SupplierId = -2,
                    CustomerId = -2,
                    InQty = 0,
                    OutQty = QtyUnits,
                    PurchasePrice = p.UnitPrice,
                    SalePrice = 0,
                    TransCode = tcode,
                    Description = helperRepository.WastageStockMsg(p.ProductId, wastageId),

                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = helperRepository.GetCurrentUserId(),
                    UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                };

                dbContext.StockDetails.Add(model);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

    }
}
