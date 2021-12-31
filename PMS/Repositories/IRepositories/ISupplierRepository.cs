using PMS.Models;
using PMS.ViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface ISupplierRepository
    {
        IEnumerable<SupplierViewModel> GetAllSupplier();
        SupplierViewModel GetByIdSupplier(long id);
        SupplierDetailsViewModel GetSupplierDetails(long id);
        Supplier GetByIdForUpdate(long id);
        Supplier AddSupplier(Supplier supplier);
        Supplier UpdateSupplier(Supplier supplier);
        bool DeleteSupplier(long supplierid);

        IEnumerable<SupplierLedgerViewModel> GetSupplierLedgers(long supplierId, DateTime? startDate, DateTime? endDate);
        decimal GetSBelance(long SupplierId);

        IEnumerable<SupplierPayment> GetSupplierPayments();
        IEnumerable<SupplierPayment> GetSupplierPayments(long supplierId, DateTime? startDate, DateTime? endDate);
        SupplierPayment GetSupplierPayment(long id);
        SupplierPayment AddSupplierPayment(SupplierPayment supplier);
        SupplierPayment EditSupplierPayment(SupplierPayment supplier);

        IEnumerable<SupplierAdvanced> GetSupplierAdvanceds();
        IEnumerable<SupplierAdvanced> GetSupplierAdvanceds(long supplierId, DateTime? startDate, DateTime? endDate);

        SupplierAdvanced GetSupplierAdvanced(long id);
        SupplierAdvanced AddSupplierAdvanced(SupplierAdvanced supplier);
        SupplierAdvanced EditSupplierAdvanced(SupplierAdvanced supplier);
    }
}
