using PMS.Data;
using PMS.Data.Enums;
using PMS.Models.Finance;
using PMS.Models.Service;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;
        private readonly IShopRepository shopRepository;

        public ServiceRepository(ApplicationDbContext dbContext,
            IHelperRepository helperRepository,
            ITransactionRepository transactionRepository, IShopRepository shopRepository)
        {
            this.dbContext = dbContext;
            this.helperRepository = helperRepository;
            this.transactionRepository = transactionRepository;
            this.shopRepository = shopRepository;

        }

        //Index Page List
        public IEnumerable<ServiceViewModel> GetAllServices()
        {
            if (dbContext != null)
            {
                List<ServiceViewModel> list = new List<ServiceViewModel>();

                var models = dbContext.Services.Where(x => x.DeletedAt == null).ToList();
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

                    ServiceViewModel model = new ServiceViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        InvoiceNo = m.InvoiceNo,
                        ServiceDate = m.ServiceDate,
                        CustomerId = m.CustomerId,
                        CustomerName = cName,
                        CustomeraAddress = cAddress,
                        CustomerPhone = cPhone,
                        CustomerEmail = cEmail,
                        EmployeeId = m.EmployeeId,
                        EmployeeName = dbContext.Employees.FirstOrDefault(x => x.Id == m.EmployeeId).Name,
                        PaymentType = m.PaymentType,
                        BankId = bId,
                        BankName = bName,
                        SubTotal = m.SubTotal,
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
                        UserName = helperRepository.GetUserName(m.UserId)
                    };
                    sno++;

                    list.Add(model);
                }

                return list;
            }
            return null;
        }

        //Index Page List Details Button Click
        public IEnumerable<ServiceDetailViewModel> GetAllServiceDetails(long id)
        {
            if (dbContext != null)
            {
                List<ServiceDetailViewModel> list = new List<ServiceDetailViewModel>();
                var details = dbContext.ServiceDetails.Where(x => x.ServiceId == id).ToList();
                var sno = 1;

                foreach (var d in details)
                {
                    ServiceDetailViewModel model = new ServiceDetailViewModel
                    {
                        ServiceId = d.ServiceId,
                        ServiceCatergoryId = d.ServiceCatergoryId,
                        ServiceCategoryName = dbContext.ServiceCategories.FirstOrDefault(x => x.Id == d.ServiceCatergoryId).Name,
                        Qty = d.Qty,
                        Fee_Charges = d.Fee_Charges,
                        Discount = d.Discount,
                        TotalServicePrice = d.TotalServicePrice,
                        Descriptions = d.Descriptions,
                        Sno = sno
                    };

                    sno++;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        //Index Page Each Recoded Detail View 
        public ViewServiceDetailViewModel GetService(long id)
        {
            if (dbContext != null)
            {
                var ServiceModel = GetAllServices().FirstOrDefault(x => x.Id == id);
                var ServiceDetailModel = GetAllServiceDetails(id);
                var ShopDetails = shopRepository.GetShop();

                ViewServiceDetailViewModel model = new ViewServiceDetailViewModel
                {
                    ServiceViewModel = ServiceModel,
                    ShopModelDetails = ShopDetails,
                    ServiceDetailViewModels = ServiceDetailModel
                };
                return model;
            }
            return null;
        }

        //Auto Generate Invoice Number 
        public string GetInvoiceNo()
        {
            if (dbContext != null)
            {
                var services = dbContext.Services.ToList();
                long maxId = 1;
                if (services.Any())
                {
                    maxId = dbContext.Services.Max(x => x.Id) + 1;
                }

                return maxId.ToString();
            }
            return null;
        }

        //Create And Add Servicess
        public long AddService(CreateServiceViewModel createServiceViewModel)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    //Save Service 
                    var transCode = helperRepository.GetTransactionCode();

                    var serviceId = AddNewServices(createServiceViewModel.Services);

                    if (serviceId != 0)
                    {
                        //Save Service Details 
                        var ServiceDetails = AddServicesDetails(serviceId, createServiceViewModel.ServiceDetails);

                        if (ServiceDetails != 0)
                        {
                            // Add Customer Ledger

                            // Add Cash or Bank Ledger
                            var sl = AddCustomerLedgerDetails(transCode, createServiceViewModel.Services, serviceId);
                            if (sl == 0)
                            {
                                return 0;
                            }

                            var cl = AddCustomerCashLedgerDetails(transCode, createServiceViewModel.Services, serviceId);
                            if (cl == 0)
                            {
                                return 0;
                            }

                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }

                    transaction.Commit();

                    return serviceId;
                }
                catch (Exception)
                {
                    return 0;
                }
            }

            return 0;
        }

        // Local Methods 

        //Add NewService and Return Max Id Which is the last Recored in Table
        private long AddNewServices(Services services)
        {
            if (dbContext != null)
            {
                services.CreatedAt = DateTime.Now;
                services.UpdatedAt = DateTime.Now;
                services.UserId = helperRepository.GetCurrentUserId();
                services.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Services.Add(services);
                dbContext.SaveChanges();

                var maxId = dbContext.Services.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }

        // While you have Service Id Then Add Range Details of Selected Serviceid 
        private long AddServicesDetails(long serviceId, IEnumerable<ServiceDetails> serviceDetails)
        {
            if (dbContext != null)
            {
                foreach (var d in serviceDetails)
                {
                    d.CreatedAt = DateTime.Now;
                    d.UpdatedAt = DateTime.Now;
                    d.UserId = helperRepository.GetCurrentUserId();
                    d.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                    d.ServiceId = serviceId;
                }

                dbContext.AddRange(serviceDetails);
                dbContext.SaveChanges();

                return 1;
            }
            return 0;
        }
        private int AddCustomerLedgerDetails(string trc, Services services, long serviceId)
        {
            if (dbContext != null)
            {
                CustomerLedger customerLedger_total = new CustomerLedger
                {
                    EntityId = services.CustomerId,
                    VoucherNo = services.Id.ToString(),
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerServiceMsg(serviceId, services.TotalAmount),
                    Debit = services.TotalAmount,
                    Credit = 0,
                    Balance = services.TotalAmount - 0,
                    TransCode = trc,
                };

                CustomerLedger customerLedger_paid = new CustomerLedger
                {
                    EntityId = services.CustomerId,
                    VoucherNo = services.Id.ToString(),
                    Date = DateTime.Now,
                    Description = helperRepository.CustomerServicePaidMsg(serviceId, services.PaidAmount),
                    Debit = 0,
                    Credit = services.PaidAmount,
                    Balance = 0 - services.PaidAmount,
                    TransCode = trc,
                };

                Transaction transaction1 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerServiceMsg(serviceId, services.TotalAmount),
                    Amount = services.TotalAmount,
                    Operation = Operation.Create
                };

                Transaction transaction2 = new Transaction
                {
                    TransCode = trc,
                    TransDate = DateTime.Now,
                    TransType = TType.Credit,
                    Description = helperRepository.CustomerServicePaidMsg(serviceId, services.PaidAmount),
                    Amount = services.PaidAmount,
                    Operation = Operation.Create
                };

                var tr1 = transactionRepository.AddTransactionLog(transaction1);
                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr1 == true && tr2 == true)
                {
                    var res1 = transactionRepository.AddCustomerLedger(customerLedger_total);
                    var res2 = transactionRepository.AddCustomerLedger(customerLedger_paid);
                    if (res1 != null && res2 != null)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
        private int AddCustomerCashLedgerDetails(string transCode, Services services, long serviceId)
        {
            if (dbContext != null)
            {
                Transaction transaction2 = new Transaction
                {
                    TransCode = transCode,
                    TransDate = DateTime.Now,
                    TransType = TType.Debit,
                    Description = helperRepository.CustomerServicePaidMsg(serviceId, services.PaidAmount),
                    Amount = services.PaidAmount,
                    Operation = Operation.Create
                };

                var tr2 = transactionRepository.AddTransactionLog(transaction2);

                if (tr2 == true)
                {
                    //Cash Ledger
                    if (services.BankId != 0)
                    {
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = services.BankId,
                            EntityType = EntityType.Bank,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerServicePaidMsg(serviceId, services.PaidAmount),
                            Debit = services.PaidAmount,
                            Credit = 0,
                            Balance = services.PaidAmount - 0,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };
                        var res = transactionRepository.AddBankLedger(bankLedger);
                        if (res != null)
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        CashLedger cashLedger_paid = new CashLedger
                        {
                            EntityId = services.CustomerId,
                            EntityType = EntityType.Customer,
                            Date = DateTime.Now,
                            Description = helperRepository.CustomerServicePaidMsg(serviceId, services.PaidAmount),
                            VoucherNo = services.Id.ToString(),
                            Debit = services.PaidAmount,
                            Credit = 0,
                            Balance = services.PaidAmount - 0,
                            TransCode = transCode,
                            TransType = CashType.Services,
                        };
                        var res2 = transactionRepository.AddCashLedger(cashLedger_paid);

                        if (res2 != null)
                        {
                            return 1;
                        }
                    }
                }
            }
            return 0;
        }
        public decimal GetFeePrice(long CategoryId)
        {
            if (dbContext != null)
            {
                var prc = dbContext.ServiceCategories.FirstOrDefault(x => x.Id == CategoryId).Fee;

                return prc;
            }

            return 0;
        }

        //Edit Portion 

        //Get Recoreds for Edit Purpose 
        public CreateServiceViewModel GetServiceForEdit(long id)
        {
            if (dbContext != null)
            {
                var service = dbContext.Services.FirstOrDefault(x => x.Id == id);
                var details = dbContext.ServiceDetails.Where(x => x.ServiceId == id).ToList();
                CreateServiceViewModel model = new CreateServiceViewModel
                {
                    Services = service,
                    ServiceDetails = details
                };

                return model;
            }
            return null;
        }

        public CreateServiceViewModel EditService(CreateServiceViewModel editServices)
        {
            if (dbContext != null)
            {
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    //Save Service
                    var transCode = dbContext.CustomerLedgers.FirstOrDefault(x => x.VoucherNo == editServices.Services.Id.ToString()).TransCode;

                    var cLedger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    var bLedger = dbContext.BankLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    var CustomerLedger = dbContext.CustomerLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    if (cLedger != null)
                    {
                        var res = transactionRepository.DeleteCashLedger(cLedger);
                    }

                    if (bLedger != null)
                    {
                        var res = transactionRepository.DeleteBankLedger(bLedger);
                    }

                    if (CustomerLedger != null)
                    {
                        var res = transactionRepository.DeleteCustomerLedger(CustomerLedger);
                    }

                    var serviceId = ServiceEdit(editServices.Services);

                    if (serviceId != 0)
                    {
                        //Save Service Details 
                        var DeleteServiceDetailRecoreds = dbContext.ServiceDetails.Where(x => x.ServiceId == editServices.Services.Id).ToList();
                        dbContext.ServiceDetails.RemoveRange(DeleteServiceDetailRecoreds);
                        dbContext.SaveChanges();

                        var ServiceDetails = AddServicesDetails(editServices.Services.Id, editServices.ServiceDetails);

                        if (ServiceDetails != 0)
                        {

                            var sl = AddCustomerLedgerDetails(transCode, editServices.Services, serviceId);
                            if (sl == 0)
                            {
                                return null;
                            }

                            var cl = AddCustomerCashLedgerDetails(transCode, editServices.Services, serviceId);
                            if (cl == 0)
                            {
                                return null;
                            }

                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                    transaction.Commit();

                    return editServices;
                }
                catch (Exception)
                {
                    return null;
                }
            }

            return null;
        }

        //Local Methods
        private long ServiceEdit(Services services)
        {
            if (dbContext != null)
            {
                services.CreatedAt = services.CreatedAt;
                services.UpdatedAt = DateTime.Now;
                services.UserId = helperRepository.GetCurrentUserId();
                services.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Services.Update(services);
                dbContext.SaveChanges();

                return 1;
            }
            return 0;
        }

        public bool DeleteService(long ServiceId)
        {
            if (dbContext != null)
            {
                var DeleteServiceRecored = dbContext.Services.FirstOrDefault(x => x.Id == ServiceId);

                var DeleteServiceDetailRecoreds = dbContext.ServiceDetails.Where(x => x.ServiceId == ServiceId).ToList();

                var transCode = dbContext.CustomerLedgers.FirstOrDefault(x => x.VoucherNo == ServiceId.ToString()).TransCode;
                var cLedger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);
                var bLedger = dbContext.BankLedgers.FirstOrDefault(x => x.TransCode == transCode);
                var CustomerLedger = dbContext.CustomerLedgers.FirstOrDefault(x => x.TransCode == transCode);

                if (cLedger != null)
                {
                    var res = transactionRepository.DeleteCashLedger(cLedger);
                }

                if (bLedger != null)
                {
                    var res = transactionRepository.DeleteBankLedger(bLedger);
                }
                if (CustomerLedger != null)
                {
                    var res = transactionRepository.DeleteCustomerLedger(CustomerLedger);
                }

                if (DeleteServiceRecored != null)
                {
                    //Delete Service Requested Id From View
                    dbContext.Services.Remove(DeleteServiceRecored);

                    //Delete DeleteServiceDetails Request Id From View about above Handovers
                    dbContext.ServiceDetails.RemoveRange(DeleteServiceDetailRecoreds);
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
    }
}
