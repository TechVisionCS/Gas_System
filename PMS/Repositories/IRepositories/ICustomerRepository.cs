using PMS.Models;
using PMS.ViewModels;
using PMS.ViewModels.Finance;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerViewModel> GetAllCustomer();
        CustomerViewModel GetByIdCustomer(long id);
        CustomerDetailsViewModel GetCustomerDetails(long id);
        Customer GetByIdForUpdate(long id);
        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        bool DeleteCustomer(long customerid);

        IEnumerable<CustomerLedgerViewModel> GetCustomerLedgers(long customerId, DateTime? startDate, DateTime? endDate);

        IEnumerable<CustomerReceive> GetCustomerReceives();
        IEnumerable<CustomerReceive> GetCustomerReceives(long customerId, DateTime? startDate, DateTime? endDate);
        CustomerReceive GetCustomerReceive(long id);
        decimal GetCLedgerBelance(long CustomerId);

        CustomerReceive AddCustomerReceive(CustomerReceive customer);
        CustomerReceive EditCustomerReceive(CustomerReceive customer);

        IEnumerable<CustomerAdvanced> GetCustomerAdvances();
        IEnumerable<CustomerAdvanced> GetCustomerAdvances(long customerId, DateTime? startDate, DateTime? endDate);
        CustomerAdvanced GetCustomerAdvance(long id);
        CustomerAdvanced AddCustomerAdvance(CustomerAdvanced customer);
        CustomerAdvanced EditCustomerAdvance(CustomerAdvanced customer);
    }
}
