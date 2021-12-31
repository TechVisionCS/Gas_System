using PMS.Data;
using PMS.Models;
using PMS.Models.Quote;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels.QuoteViewModels;
using PMS.ViewModels.SaleViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class QuoteRepository : IQuoteReposoitory
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly PMSHelper pmsHelper;
        private readonly IShopRepository shopRepository;

        public QuoteRepository(ApplicationDbContext dbContext,
            IHelperRepository helperRepository,
            PMSHelper pmsHelper, IShopRepository shopRepository)
        {
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
            this.pmsHelper = pmsHelper;
            this.shopRepository = shopRepository;
        }

        public IEnumerable<QuoteViewModel> GetAllQuotes()
        {
            if (dbContext != null)
            {
                List<QuoteViewModel> list = new List<QuoteViewModel>();
                var models = dbContext.Quote.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;

                foreach (var m in models)
                {
                    var bId = (long)0;
                    var bName = "";


                    if (m.PaymentType != 1)
                    {
                        bId = m.BankId;
                        bName = dbContext.Banks.FirstOrDefault(x => x.Id == m.BankId).BankName;
                    }


                    var cName = "WALKING CUSTOMER";
                    var cAddress = "";
                    var cPhone = "";
                    var cEmail = "";

                    if (m.CustomerId != 0)
                    {
                        cName = dbContext.Customers.FirstOrDefault(x => x.Id == m.CustomerId).Name;
                        cAddress = dbContext.Customers.FirstOrDefault(x => x.Id == m.CustomerId).Address;
                        cPhone = dbContext.Customers.FirstOrDefault(x => x.Id == m.CustomerId).Phone;
                        cEmail = dbContext.Customers.FirstOrDefault(x => x.Id == m.CustomerId).Email;
                    }

                    QuoteViewModel model = new QuoteViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        QuoteDate = m.QuoteDate.Date.ToString(),
                        InvoiceNo = m.InvoiceNo,//m.Id.ToString(), // only for ozair ....
                        QuoteStatus = (int)m.QuoteStatus,
                        CustomerId = m.CustomerId,
                        CustomerName = cName,
                        CustomeraAddress = cAddress,
                        CustomerPhone = cPhone,
                        CustomerEmail = cEmail,
                        PaymentType = m.PaymentType,
                        BankId = bId,
                        BankName = bName,
                        SubTotal = m.SubTotal,
                        RentAmount = m.RentAmount,
                        TaxAmount = m.TaxAmount,
                        DiscountAmount = m.DiscountAmount,
                        TotalAmount = m.TotalAmount,
                        PaidAmount = m.PaidAmount,
                        DueAmount = m.DueAmount,
                        Description = m.Description,
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

        public IEnumerable<QuoteViewModel> GetAllQuotesWithStatus()
        {
            if (dbContext != null)
            {
                List<QuoteViewModel> list = new List<QuoteViewModel>();
                var models = dbContext.Quote.Where(x => x.DeletedAt == null && ((int)x.QuoteStatus == 1 || (int)x.QuoteStatus == 3)).ToList();
                long sno = 1;

                foreach (var m in models)
                {
                    var bId = (long)0;
                    var bName = "";


                    if (m.PaymentType != 1)
                    {
                        bId = m.BankId;
                        bName = dbContext.Banks.FirstOrDefault(x => x.Id == m.BankId).BankName;
                    }

                    var cName = "WALKING CUSTOMER";
                    if (m.CustomerId != 0)
                    {
                        cName = dbContext.Customers.FirstOrDefault(x => x.Id == m.CustomerId).Name;
                    }

                    QuoteViewModel model = new QuoteViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        QuoteDate = m.QuoteDate.Date.ToString(),
                        InvoiceNo = m.InvoiceNo,//m.Id.ToString(), // only for ozair ....
                        QuoteStatus = (int)m.QuoteStatus,
                        CustomerId = m.CustomerId,
                        CustomerName = cName,
                        PaymentType = m.PaymentType,
                        BankId = bId,
                        BankName = bName,
                        SubTotal = m.SubTotal,
                        RentAmount = m.RentAmount,
                        TaxAmount = m.TaxAmount,
                        DiscountAmount = m.DiscountAmount,
                        TotalAmount = m.TotalAmount,
                        PaidAmount = m.PaidAmount,
                        DueAmount = m.DueAmount,
                        Description = m.Description,
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
        public IEnumerable<QuoteDetailsViewModel> GetAllQuoteDetails(long id)
        {
            if (dbContext != null)
            {
                List<QuoteDetailsViewModel> list = new List<QuoteDetailsViewModel>();
                var details = dbContext.QuoteDetails.Where(x => x.QuoteId == id).ToList();
                var sno = 1;

                foreach (var d in details)
                {
                    QuoteDetailsViewModel model = new QuoteDetailsViewModel
                    {
                        ProductId = d.ProductId,
                        ProductName = dbContext.Products.FirstOrDefault(x => x.Id == d.ProductId).Name,
                        BatchId = d.BatchId,
                        Qty = d.Qty,
                        UnitPrice = d.UnitPrice,
                        Discount = d.Discount,
                        TotalQuotePrice = d.TotalQuotePrice,
                        Sno = sno
                    };

                    sno++;

                    list.Add(model);
                }

                return list;
            }
            return null;
        }

        public ViewQuoteDetailsViewModel GetQuote(long id)
        {
            if (dbContext != null)
            {
                var quote = GetAllQuotes().FirstOrDefault(x => x.Id == id);
                var details = GetAllQuoteDetails(id);
                var ShopDetails = shopRepository.GetShop();

                ViewQuoteDetailsViewModel model = new ViewQuoteDetailsViewModel
                {
                    Quote = quote,
                    QuoteDetails = details,
                    ShopModelDetails = ShopDetails
                };

                return model;
            }

            return null;
        }

        public CreateQuoteViewModel GetQuoteForEdit(long id)
        {
            if (dbContext != null)
            {
                var quote = dbContext.Quote.FirstOrDefault(x => x.Id == id);
                var details = dbContext.QuoteDetails.Where(x => x.QuoteId == id).ToList();

                CreateQuoteViewModel model = new CreateQuoteViewModel
                {
                    Quote = quote,
                    QuoteDetails = details
                };

                return model;
            }
            return null;
        }

        public long AddQuote(CreateQuoteViewModel createQuoteViewModel)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    var quoteId = AddNewQuote(createQuoteViewModel.Quote);

                    if (quoteId != 0)
                    {
                        var quoteDetails = AddquoteDetails(quoteId, createQuoteViewModel.QuoteDetails);
                    }
                    else
                    {
                        return 0;
                    }

                    transaction.Commit();

                    return quoteId;
                }
                catch (Exception)
                {
                    return 0;
                }
            }

            return 0;
        }

        private long AddNewQuote(Quote quote)
        {
            if (dbContext != null)
            {
                quote.CreatedAt = DateTime.Now;
                quote.UpdatedAt = DateTime.Now;
                quote.UserId = helperRepository.GetCurrentUserId();
                quote.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Quote.Add(quote);
                dbContext.SaveChanges();

                var maxId = dbContext.Quote.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }
        private long AddquoteDetails(long quoteId, IEnumerable<QuoteDetails> quoteDetails)
        {
            if (dbContext != null)
            {
                foreach (var d in quoteDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.QuoteId = quoteId;
                }

                dbContext.AddRange(quoteDetails);
                dbContext.SaveChanges();

                return 1;
            }

            return 0;
        }

        public string GetQuoteInvoiceNo()
        {
            if (dbContext != null)
            {
                var sales = dbContext.Quote.ToList();
                long maxId = 1;
                if (sales.Any())
                {
                    maxId = dbContext.Quote.Max(x => x.Id) + 1;
                }

                return maxId.ToString();

            }
            return null;
        }

        public CreateQuoteViewModel EditQuote(CreateQuoteViewModel EditQuoteViewModel)
        {

            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                //try
                //{
                //Save Quote

                var quoteId = QuoteEdit(EditQuoteViewModel.Quote);

                if (quoteId != 0)
                {
                    //Save Service Details 
                    var DeleteServiceDetailRecoreds = dbContext.QuoteDetails.Where(x => x.QuoteId == EditQuoteViewModel.Quote.Id).ToList();
                    dbContext.QuoteDetails.RemoveRange(DeleteServiceDetailRecoreds);
                    dbContext.SaveChanges();

                    var quoteDetails = AddquoteDetails(EditQuoteViewModel.Quote.Id, EditQuoteViewModel.QuoteDetails);
                }
                else
                {
                    return null;
                }

                transaction.Commit();

                return EditQuoteViewModel;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}
            }
            return null;
        }

        public IEnumerable<ProductBatch> GetProductBatches(long productId)
        {
            if (dbContext != null)
            {
                var batches = dbContext.ProductBatches.Where(x => x.ProductId == productId && x.StockQty != 0 && x.DeletedAt == null).ToList();
                return batches;
            }
            return null;
        }

        public IEnumerable<ProductBatch> GetProductBatchesWithExpireDate(long productId)
        {
            if (dbContext != null)
            {
                var batches = dbContext.ProductBatches.Where(x => x.ProductId == productId && x.StockQty != 0 && x.DeletedAt == null).ToList();
                List<ProductBatch> list = new List<ProductBatch>();

                foreach (var model in batches)
                {
                    ProductBatch m = new ProductBatch
                    {
                        Id = model.Id,
                        BatchId = model.BatchId,
                        BatchIdName = model.BatchId,// + " | " + model.ExpireDate?.ToString("dd/MM/yyyy"),
                        ProductId = model.ProductId
                        //ExpireDate = model.ExpireDate
                    };

                    list.Add(m);
                }
                return list;
            }
            return null;
        }

        public decimal GetProductBatchQty(string batchId, long productId)
        {
            if (dbContext != null)
            {
                var qty = dbContext.ProductBatches.FirstOrDefault(x => x.ProductId == productId && x.BatchId == batchId).StockQty;
                return qty;
            }

            return 0;
        }

        public ProductBatch GetQuoteDetailsByBatchId(string batchId)
        {
            if (dbContext != null)
            {
                var batch = dbContext.ProductBatches.FirstOrDefault(x => x.BatchId == batchId && x.StockQty > 0 && x.DeletedAt == null);
                if (batch != null)
                {
                    return batch;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public decimal GetUnitPrice(string batchId, long productId)
        {
            if (dbContext != null)
            {
                //var prc = dbContext.ProductBatches.FirstOrDefault(x => x.ProductId == productId && x.BatchId == batchId).SellPrice;
                return 0;
            }

            return 0;
        }

        //local Methods
        private long QuoteEdit(Quote quoteedit)
        {
            if (dbContext != null)
            {
                quoteedit.CreatedAt = quoteedit.CreatedAt;
                quoteedit.UpdatedAt = DateTime.Now;
                quoteedit.UserId = helperRepository.GetCurrentUserId();
                quoteedit.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Quote.Update(quoteedit);
                dbContext.SaveChanges();

                return 1;
            }
            return 0;
        }

        public bool DeleteQuote(long QuoteId)
        {
            if (dbContext != null)
            {
                var DeleteServiceRecored = dbContext.Quote.FirstOrDefault(x => x.Id == QuoteId);
                var DeleteServiceDetailRecoreds = dbContext.QuoteDetails.Where(x => x.QuoteId == QuoteId).ToList();

                if (DeleteServiceRecored != null)
                {
                    //Delete Service Requested Id From View
                    dbContext.Quote.Remove(DeleteServiceRecored);

                    //Delete DeleteServiceDetails Request Id From View about above Handovers
                    dbContext.QuoteDetails.RemoveRange(DeleteServiceDetailRecoreds);
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

        //Map To Sale 
        public CreateSaleViewModel MapQuoteToSale(CreateSaleViewModel saleViewModel, long QuoteId)
        {
            if (dbContext != null)
            {
                var Quotation = dbContext.Quote.FirstOrDefault(x => x.Id == QuoteId);

                if (Quotation != null)
                {
                    var QutationModel = GetQuoteToMap(QuoteId);

                    CreateSaleViewModel model = new CreateSaleViewModel()
                    {
                        //

                    };

                    return model;

                }
                return null;
            }
            return null;
        }
        private CreateQuoteViewModel GetQuoteToMap(long id)
        {
            if (dbContext != null)
            {
                var quote = dbContext.Quote.FirstOrDefault(x => x.Id == id);
                var details = dbContext.QuoteDetails.Where(x => x.QuoteId == id).ToList();

                CreateQuoteViewModel model = new CreateQuoteViewModel
                {
                    Quote = quote,
                    QuoteDetails = details
                };

                return model;
            }
            return null;
        }

        public CreateSaleViewModel MapQuoteToSale(long QuoteId)
        {
            throw new NotImplementedException();
        }
    }
}
