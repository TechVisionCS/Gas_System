using PMS.Models;
using PMS.ViewModels.Wastages;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IWastageRepository
    {
        IEnumerable<Wastage> GetAllWastages();

        IEnumerable<Wastage> GetAllWastagesByDate(DateTime? startDate = null, DateTime? endDate = null);
        WastageViewModel GetWastage(long id);
        bool AddWastage(Wastage wastage, IEnumerable<WastageDetails> wastageDetails);
        bool DeleteWastage(long wastageId);

        bool UpdateWastage(Wastage wastage, IEnumerable<WastageDetails> wastageDetails);
    }
}
