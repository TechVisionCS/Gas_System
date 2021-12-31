using PMS.Data;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using System;
using System.Linq;

namespace PMS.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;

        public ShopRepository(ApplicationDbContext dbContext,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository)
        {
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
        }
        public Shop AddShop(Shop shop)
        {
            if (dbContext != null)
            {
                shop.UserId = pmsHelper.GetCurrentUserId();
                shop.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());
                shop.CreatedAt = DateTime.Now;
                shop.UpdatedAt = DateTime.Now;

                dbContext.Shops.Add(shop);
                dbContext.SaveChanges();

                return shop;
            }
            return null;
        }

        public Shop GetShop()
        {
            if (dbContext != null)
            {
                var shop = dbContext.Shops.FirstOrDefault();
                if (shop != null)
                {
                    return shop;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        public Shop UpdateShop(Shop shop)
        {
            if (dbContext != null)
            {
                shop.UserId = pmsHelper.GetCurrentUserId();
                shop.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());
                shop.UpdatedAt = DateTime.Now;

                dbContext.Shops.Update(shop);
                dbContext.SaveChanges();

                return shop;
            }
            return null;
        }
    }
}
