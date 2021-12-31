using PMS.ViewModels.Service;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IServiceRepository
    {
        IEnumerable<ServiceViewModel> GetAllServices();
        IEnumerable<ServiceDetailViewModel> GetAllServiceDetails(long id);
        ViewServiceDetailViewModel GetService(long id);
        string GetInvoiceNo();
        long AddService(CreateServiceViewModel createServiceViewModel);
        CreateServiceViewModel GetServiceForEdit(long id); //Serviec Id... 
        CreateServiceViewModel EditService(CreateServiceViewModel editServices);
        decimal GetFeePrice(long CategoryId);
        bool DeleteService(long ServiceId);


    }
}
