using PMS.Data;
using PMS.Models.FixedAsset;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels;
using PMS.ViewModels.Asset;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class FixedAssetRepository : IFixedAssetRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;

        public FixedAssetRepository(ApplicationDbContext dbContext,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository)
        {
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
        }
        public Asset AddFixedAsset(Asset fixedAsset)
        {
            if (dbContext != null)
            {
                fixedAsset.UserId = pmsHelper.GetCurrentUserId();
                fixedAsset.UserName = pmsHelper.GetUserName(fixedAsset.UserId);
                fixedAsset.CreatedAt = DateTime.Now;
                fixedAsset.UpdatedAt = DateTime.Now;

                dbContext.Assets.Add(fixedAsset);
                dbContext.SaveChanges();
                return fixedAsset;
            }
            return null;
        }
        public bool DeleteFixedAsset(long fixedAssetId)
        {
            if (dbContext != null)
            {
                var DeleteQuerySelection = dbContext.Assets.FirstOrDefault(x => x.Id == fixedAssetId);

                if (DeleteQuerySelection != null)
                {
                    DeleteQuerySelection.UserId = pmsHelper.GetCurrentUserId();
                    DeleteQuerySelection.UserName = pmsHelper.GetUserName(DeleteQuerySelection.UserId);
                    DeleteQuerySelection.DeletedAt = DateTime.Now;

                    dbContext.Assets.Update(DeleteQuerySelection);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            return false;
        }
        public IEnumerable<FixedAssetViewModel> GetAllFixedAssets()
        {
            if (dbContext != null)
            {
                List<FixedAssetViewModel> list = new List<FixedAssetViewModel>();
                var ModelList = dbContext.Assets.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                foreach (var fixedAsset in ModelList)
                {

                    FixedAssetViewModel model = new FixedAssetViewModel
                    {
                        Id = fixedAsset.Id,
                        SNO = sno++,
                        AssetTitle = fixedAsset.Name,
                        AssetCategoryId = fixedAsset.AssetCategoryId,
                        AssetCategoryName = dbContext.AssetsCategories.FirstOrDefault(x => x.Id == fixedAsset.AssetCategoryId).Name,
                        Description = fixedAsset.Description,
                        Model = fixedAsset.Model,
                        CreatedAt = fixedAsset.CreatedAt,
                        UpdatedAt = fixedAsset.UpdatedAt,
                        DeletedAt = fixedAsset.DeletedAt,
                        UserId = fixedAsset.UserId,
                        UserName = pmsHelper.GetUserName(fixedAsset.UserId),
                        TotalAvailStockQtys = dbContext.AssetStocks.Where(x => x.AssetId == fixedAsset.Id).Sum(x => x.StockQty) + fixedAsset.StockQty
                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }
        public FixedAssetViewModel GetByIdFixedAsset(long id)
        {
            if (dbContext != null)
            {
                var fixedAsset = dbContext.Assets.FirstOrDefault(x => x.Id == id);
                FixedAssetViewModel model = new FixedAssetViewModel
                {
                    Id = fixedAsset.Id,
                    AssetTitle = fixedAsset.Name,
                    AssetCategoryId = fixedAsset.AssetCategoryId,
                    AssetCategoryName = dbContext.AssetsCategories.FirstOrDefault(x => x.Id == fixedAsset.AssetCategoryId).Name,
                    Description = fixedAsset.Description,
                    Model = fixedAsset.Model,
                    CreatedAt = fixedAsset.CreatedAt,
                    UpdatedAt = fixedAsset.UpdatedAt,
                    DeletedAt = fixedAsset.DeletedAt,
                    UserId = fixedAsset.UserId,
                    UserName = pmsHelper.GetUserName(fixedAsset.UserId),
                    TotalAvailStockQtys = dbContext.AssetStocks.Where(x => x.AssetId == fixedAsset.Id).Sum(x => x.StockQty) + fixedAsset.StockQty
                };

                return model;
            }
            return null;
        }
        public Asset GetByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                var fixedAsset = dbContext.Assets.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                return fixedAsset;
            }
            return null;
        }
        public Asset UpdateFixedAsset(Asset fixedAsset)
        {
            if (dbContext != null)
            {
                fixedAsset.UpdatedAt = DateTime.Now;
                fixedAsset.UserId = helperRepository.GetCurrentUserId();
                fixedAsset.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Assets.Update(fixedAsset);
                dbContext.SaveChanges();
                return fixedAsset;
            }

            return null;
        }


        //To Add New Items into Asset Stock 
        //
        //
        //
        public AssetStock AddAssetStock(AssetStock assetStock)
        {
            if (dbContext != null)
            {
                assetStock.UserId = pmsHelper.GetCurrentUserId();
                assetStock.UserName = pmsHelper.GetUserName(assetStock.UserId);
                assetStock.CreatedAt = DateTime.Now;
                assetStock.UpdatedAt = DateTime.Now;
                assetStock.OutQty = 0;
                assetStock.StockQty = assetStock.InQty - assetStock.OutQty;

                dbContext.AssetStocks.Add(assetStock);
                dbContext.SaveChanges();
                return assetStock;
            }
            return null;
        }
        public AssetStock GetByIdForUpdateStock(long id)
        {
            if (dbContext != null)
            {
                var assetStock = dbContext.AssetStocks.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                return assetStock;
            }
            return null;
        }
        public AssetStock UpdateAssetStock(AssetStock assetStock)
        {
            if (dbContext != null)
            {
                assetStock.UpdatedAt = DateTime.Now;
                assetStock.UserId = helperRepository.GetCurrentUserId();
                assetStock.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());
                assetStock.OutQty = 0;
                assetStock.StockQty = assetStock.InQty - assetStock.OutQty;

                dbContext.AssetStocks.Update(assetStock);
                dbContext.SaveChanges();
                return assetStock;
            }

            return null;
        }
        public IEnumerable<AssetStockViewModel> GetAssetStockDetails()
        {
            if (dbContext != null)
            {
                List<AssetStockViewModel> list = new List<AssetStockViewModel>();
                var ModelList = dbContext.AssetStocks.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                foreach (var m in ModelList)
                {
                    AssetStockViewModel model = new AssetStockViewModel
                    {
                        Id = m.Id,
                        SNO = sno++,
                        AssetId = m.AssetId,
                        AssetName = dbContext.Assets.FirstOrDefault(x => x.Id == m.AssetId).Name,
                        Description = m.Description,
                        ExpiryDate = m.ExpiryDate,
                        PurchaseDate = m.PurchaseDate,
                        Status = m.Status,
                        TotalAvailStockQtys = dbContext.Assets.Where(x => x.Id == m.Id).Sum(x => x.StockQty) + m.StockQty,
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt,
                        UserId = m.UserId,
                        UserName = pmsHelper.GetUserName(m.UserId),
                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        //Asset Handover Moduls
        //
        //
        //Manage Asset To Be HandOverd to Employees
        public CreateAssetHandoverViewModel AddStockHandover(CreateAssetHandoverViewModel createAssetHandoverViewModel)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                var AssetHandoverId = AddAssetHandover(createAssetHandoverViewModel.AssetHandover);

                if (AssetHandoverId != 0)
                {
                    //Save Asset Handover  Details 
                    var AssetHandoverDetails = AddAssetHandoverDetails(AssetHandoverId, createAssetHandoverViewModel.AssetHandoverDetailss);

                    if (AssetHandoverDetails != 0)
                    {
                        // decrement Asset Handover in AssetStock Model by adding oUt Qty 
                        // var AssetStock = DecremenctAssetStock(createAssetHandoverViewModel.AssetHandoverDetailss);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }

                transaction.Commit();

                return createAssetHandoverViewModel;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }

            return null;
        }
        private long AddAssetHandover(AssetHandover assetHandover)
        {
            if (dbContext != null)
            {
                assetHandover.CreatedAt = DateTime.Now;
                assetHandover.UpdatedAt = DateTime.Now;
                assetHandover.UserId = helperRepository.GetCurrentUserId();
                assetHandover.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.AssetHandovers.Add(assetHandover);
                dbContext.SaveChanges();
                var maxId = dbContext.AssetHandovers.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        private long AddAssetHandoverDetails(long assetHandoverId, IEnumerable<AssetHandoverDetails> assetHandoverDetails)
        {
            if (dbContext != null)
            {
                foreach (var d in assetHandoverDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());
                    d.AssetHandoverId = assetHandoverId;
                }

                dbContext.AssetHandoverDetails.AddRange(assetHandoverDetails);
                dbContext.SaveChanges();
                return 1;
            }
            return 0;
        }
        private bool DecremenctAssetStock(IEnumerable<AssetHandoverDetails> assetHandoverDetails)
        {
            if (dbContext != null)
            {
                List<AssetStock> list = new List<AssetStock>();

                foreach (var p in assetHandoverDetails)
                {
                    AssetStock model = new AssetStock
                    {
                        PurchaseDate = DateTime.Now,
                        AssetId = p.AssetId,
                        Id = p.Id,
                        OutQty = p.Qty,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        Status = p.Status,
                        Description = "Asset Handoverd To Employee",
                        UserId = helperRepository.GetCurrentUserId(),
                        UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId())
                    };
                    list.Add(model);
                }

                dbContext.AssetStocks.UpdateRange(list);

                dbContext.SaveChanges();

                return true;
            }

            return false;
        }
        public IEnumerable<AssetHandoverViewModel> GetAllAssetHandover()
        {
            if (dbContext != null)
            {
                List<AssetHandoverViewModel> list = new List<AssetHandoverViewModel>();

                var models = dbContext.AssetHandovers.Where(x => x.DeletedAt == null).ToList();

                long sno = 1;

                foreach (var m in models)
                {
                    AssetHandoverViewModel model = new AssetHandoverViewModel
                    {
                        Id = m.Id,
                        SNo = sno,
                        EmployeeId = m.EmployeeId,
                        EmployeeName = dbContext.Employees.FirstOrDefault(x => x.Id == m.EmployeeId).Name,
                        HandoverDate = m.HandoverDate,
                        HandoverRequestId = m.HandoverRequestId,
                        HandoverRemarks = m.HandoverRemarks,
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt,
                        UserId = m.UserId,
                        UserName = pmsHelper.GetUserName(m.UserId)
                    };
                    sno++;
                    list.Add(model);
                }

                return list;
            }
            return null;
        }
        public IEnumerable<AssetHandoverDetailsViewModel> GetAllAssetHandoverDetails(long id)
        {
            if (dbContext != null)
            {
                List<AssetHandoverDetailsViewModel> list = new List<AssetHandoverDetailsViewModel>();
                var details = dbContext.AssetHandoverDetails.Where(x => x.AssetHandoverId == id).ToList();
                var sno = 1;
                foreach (var d in details)
                {
                    AssetHandoverDetailsViewModel model = new AssetHandoverDetailsViewModel
                    {
                        SNO = sno,
                        AssetHandoverId = d.AssetHandoverId,
                        AssetId = d.AssetId,
                        AssetName = dbContext.Assets.FirstOrDefault(x => x.Id == d.AssetId).Name,
                        Status = d.Status,
                        Qty = d.Qty,
                        Details = d.Details
                    };

                    sno++;

                    list.Add(model);
                }
                return list;
            }
            return null;
        }
        public ViewAssetHandoverDetailViewModel GetAssetGeneralDetails(long id)
        {
            if (dbContext != null)
            {
                var AssetHandoverView = GetAllAssetHandover().FirstOrDefault(x => x.Id == id);
                var AssetHandoverDetails = GetAllAssetHandoverDetails(id);

                ViewAssetHandoverDetailViewModel model = new ViewAssetHandoverDetailViewModel
                {
                    AssetHandoverViewModel = AssetHandoverView,
                    AssetHandoverDetailsViewModels = AssetHandoverDetails
                };

                return model;
            }

            return null;
        }
        public CreateAssetHandoverViewModel GetStockHandoverForEdit(long id)
        {
            if (dbContext != null)
            {
                var Assethandover = dbContext.AssetHandovers.FirstOrDefault(x => x.Id == id);
                var AssethandoverDetails = dbContext.AssetHandoverDetails.Where(x => x.AssetHandoverId == id).ToList();

                CreateAssetHandoverViewModel model = new CreateAssetHandoverViewModel
                {
                    AssetHandover = Assethandover,
                    AssetHandoverDetailss = AssethandoverDetails
                };

                return model;
            }
            return null;
        }
        public CreateAssetHandoverViewModel EditStockHandover(CreateAssetHandoverViewModel editAssetHandoverViewModel)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();

                try
                {
                    var handover = StockHandoverEdit(editAssetHandoverViewModel.AssetHandover);

                    if (handover != 0)
                    {
                        //save asset handover details 
                        var assethandoverdetails = AssetHandoverDetailsEdit(editAssetHandoverViewModel.AssetHandoverDetailss);
                        if (assethandoverdetails != 0)
                        {
                            // decrement asset handover in assetstock model by adding out qty 

                            // var assetstock = DecremenctAssetStock( editAssetHandoverViewModel.AssetHandoverDetailss);
                        }
                        else
                        {
                            return null;
                        }

                    }
                    else
                    {
                        return null;
                    }

                    transaction.Commit();

                    return editAssetHandoverViewModel;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }
        private long StockHandoverEdit(AssetHandover assetHandoverEdit)
        {
            if (dbContext != null)
            {
                assetHandoverEdit.CreatedAt = assetHandoverEdit.CreatedAt;
                assetHandoverEdit.UpdatedAt = DateTime.Now;
                assetHandoverEdit.UserId = helperRepository.GetCurrentUserId();
                assetHandoverEdit.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.AssetHandovers.Update(assetHandoverEdit);
                dbContext.SaveChanges();

                return 1;
            }
            return 0;
        }
        private long AssetHandoverDetailsEdit(IEnumerable<AssetHandoverDetails> assetHandoverDetails)
        {
            if (dbContext != null)
            {
                foreach (var d in assetHandoverDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                }
                dbContext.AssetHandoverDetails.UpdateRange(assetHandoverDetails);

                dbContext.SaveChanges();

                return 1;
            }
            return 0;
        }
        public bool DeleteStockHandover(long StockHandoverId)
        {
            if (dbContext != null)
            {
                var DeleteQuerySelection = dbContext.AssetHandovers.FirstOrDefault(x => x.Id == StockHandoverId);

                var StockAssetHandover = dbContext.AssetHandoverDetails.Where(x => x.AssetHandoverId == StockHandoverId).ToList();

                if (DeleteQuerySelection != null)
                {
                    //Delete AssetHandover Requested Id From View
                    dbContext.AssetHandovers.Remove(DeleteQuerySelection);

                    //Delete AssetHandover Request Id From View about above Handovers
                    dbContext.AssetHandoverDetails.RemoveRange(StockAssetHandover);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {

                }
                return false;
            }
            return false;
        }
    }
}