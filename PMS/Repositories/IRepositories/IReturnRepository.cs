using PMS.Models;
using PMS.ViewModels.ReturnViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IReturnRepository
    {
        IEnumerable<ReturnModelViewModel> GetAllSaleReturns();
        IEnumerable<ReturnModelViewModel> GetAllSaleReturnsByDate(DateTime? startDate, DateTime? endDate);
        IEnumerable<ReturnModelViewModel> GetAllPurchaseReturns();
        IEnumerable<ReturnModelViewModel> GetAllPurchaseReturnsByDate(DateTime? startDate, DateTime? endDate);
        ReturnViewModel GetPurchaseReturn(long returnId);
        ReturnViewModel GetSaleReturn(long returnId);
        IEnumerable<Return> GetAllWastages();
        bool AddPurchaseReturn(Return rtn, IEnumerable<ReturnDetails> returnDetails);
        bool AddSaleReturn(Return rtn, IEnumerable<ReturnDetails> returnDetails);
        bool UpdatePurchaseReturn(Return rtn, IEnumerable<ReturnDetails> returnDetails);
        bool UpdateSaleReturn(Return rtn, IEnumerable<ReturnDetails> returnDetails);
        bool DeletePurchaseReturn(long returnId, long purchaseId);
        bool DeleteSaleReturn(long returnId, long purchaseId);

        Return GetReturnById(long returnId);
        IEnumerable<ReturnDetails> GetReturnDetailsByReturnId(long returnId);
        IEnumerable<ReturnDetails> GetSaleReturnDetailsByReturnId(long returnId);

        ProductBatch GetProductBatchDetails(string batchId);
    }

}
