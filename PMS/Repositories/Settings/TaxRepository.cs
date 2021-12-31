using PMS.Data;
using PMS.Models.Settings;
using PMS.Repositories.IRepositories.Settings;
using PMS.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repositories.Settings
{
    public class TaxRepository: ITaxRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public TaxRepository(ApplicationDbContext _dbContext, PMSHelper pmsHelper)
        {
            dbContext = _dbContext;
            this.pmsHelper = pmsHelper;
        }

        public Tax Add(Tax tax)
        {
            if(dbContext != null)
            {
                dbContext.Taxes.Add(tax);
                dbContext.SaveChanges();
                return tax;
            }
            return null;
        }

        public IEnumerable<Tax> GetAll()
        {
            if(dbContext != null)
            {
                var taxes = dbContext.Taxes.ToList();
                foreach(var tax in taxes)
                {
                    tax.UserName = pmsHelper.GetUserName(tax.UserId);
                }
                return taxes;
            }
            return null;
        }

        public Tax GetById(long id)
        {
            if(dbContext != null)
            {
                var tax = dbContext.Taxes.FirstOrDefault(x => x.Id == id);
                tax.UserName = pmsHelper.GetUserName(tax.UserId);
                return tax;

            }
            return null;
        }

        public Tax Update(Tax tax)
        {
            if(dbContext != null)
            {
                dbContext.Taxes.Update(tax);
                dbContext.SaveChanges();
                return tax;
            }
            return null;
        }
    }
}
