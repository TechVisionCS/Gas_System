using PMS.Models;
using PMS.ViewModels.QuoteViewModels;
using PMS.ViewModels.SaleViewModels;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IQuoteReposoitory
    {
        IEnumerable<QuoteViewModel> GetAllQuotes();
        IEnumerable<QuoteViewModel> GetAllQuotesWithStatus();
        IEnumerable<QuoteDetailsViewModel> GetAllQuoteDetails(long id);
        ViewQuoteDetailsViewModel GetQuote(long id);
        long AddQuote(CreateQuoteViewModel createQuoteViewModel);
        CreateQuoteViewModel GetQuoteForEdit(long id); //Quote Id... 
        string GetQuoteInvoiceNo();
        CreateQuoteViewModel EditQuote(CreateQuoteViewModel EditQuoteViewModel);
        bool DeleteQuote(long QuoteId);

        IEnumerable<ProductBatch> GetProductBatches(long productId);
        IEnumerable<ProductBatch> GetProductBatchesWithExpireDate(long productId);
        decimal GetProductBatchQty(string batchId, long productId);
        decimal GetUnitPrice(string batchId, long productId);
        ProductBatch GetQuoteDetailsByBatchId(string batchId);
        //mapping to sale
        CreateSaleViewModel MapQuoteToSale(long QuoteId);

    }
}
