using PMS.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repositories.IRepositories.Settings
{
    public interface ITaxRepository
    {
        IEnumerable<Tax> GetAll();
        Tax GetById(long id);
        Tax Add(Tax tax);
        Tax Update(Tax tax);

    }
}
