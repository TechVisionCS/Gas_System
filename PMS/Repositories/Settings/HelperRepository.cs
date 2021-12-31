using Microsoft.AspNetCore.Http;
using NToastNotify;
using PMS.Data;
using PMS.Models;
using PMS.Models.FixedAsset;
using PMS.Models.Lookup;
using PMS.Models.OfficeLoan;
using PMS.Models.PersonalLoan;
using PMS.Repositories.IRepositories;
using PMS.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PMS.Repositories
{
    public class HelperRepository : IHelperRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IToastNotification toastNotification;

        public HelperRepository(ApplicationDbContext dbContext, IToastNotification toastNotification)
        {
            this.dbContext = dbContext;
            this.toastNotification = toastNotification;
        }

        public IEnumerable<Category> GetCategory()
        {
            return dbContext.Categories.OrderByDescending(x => x.Id).Where(x => x.DeletedAt == null && x.Status == 1).ToList();
        }

        public IEnumerable<Country> GetCountry()
        {
            return dbContext.Countries.Where(x => x.DeletedAt == null).ToList();
        }

        public IEnumerable<Customer> GetCustomer()
        {

            return dbContext.Customers.OrderByDescending(x => x.Id).Where(x => x.DeletedAt == null).ToList();

        }
        public IEnumerable<Partner> GetPartner()
        {
            return dbContext.Partners.OrderByDescending(x => x.Id).Where(x => x.DeletedAt == null).ToList();
        }

        public IEnumerable<Province> GetProvinces()
        {
            return dbContext.Provinces.Where(x => x.DeletedAt == null).ToList();
        }

        public IEnumerable<Province> GetProvincesById(long id)
        {
            return dbContext.Provinces.Where(x => x.DeletedAt == null && x.CountryId == id).ToList();
        }


        public IEnumerable<Supplier> GetSupplier()
        {
            return dbContext.Suppliers.OrderByDescending(x => x.Id).Where(x => x.DeletedAt == null).ToList();

        }

        public IEnumerable<Supplier> GetAllSupplier()
        {
            return dbContext.Suppliers.OrderByDescending(x => x.Id).ToList();
        }

        public IEnumerable<Unit> GetUnit()
        {
            return dbContext.Units.Where(x => x.DeletedAt == null && x.Status == 1).ToList();
        }
        public IEnumerable<ProductType> GetProductType()
        {
            return dbContext.ProductTypes.OrderByDescending(x => x.Id).Where(x => x.DeletedAt == null && x.Status == 1).ToList();
        }

        public IEnumerable<ProductType> GetProductTypesById(long CategoryName)
        {
            var categoryNamerecived = dbContext.Categories.FirstOrDefault(x => x.Id == CategoryName).Name;

            return dbContext.ProductTypes.Where(x => x.DeletedAt == null && x.Status == 1 && x.CategoryName == categoryNamerecived).ToList();
        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            return dbContext.Manufacturers.OrderByDescending(x => x.Id).Where(x => x.DeletedAt == null && x.Status == 1).ToList();
        }

        public IEnumerable<Bank> GetBanks()
        {
            return dbContext.Banks.OrderByDescending(x => x.Id).Where(x => x.DeletedAt == null).ToList();
        }

        public IEnumerable<ProductDropDownListViewModel> GetProducts()
        {
            if (dbContext != null)
            {
                var models = dbContext.Products.OrderByDescending(x => x.Id).Where(x => x.DeletedAt == null).ToList();
                List<ProductDropDownListViewModel> list = new List<ProductDropDownListViewModel>();
                foreach (var model in models)
                {
                    ProductDropDownListViewModel m = new ProductDropDownListViewModel
                    {
                        Id = model.Id,
                        Name = model.Name// + " - " + dbContext.ProductTypes.FirstOrDefault(x => x.Id == model.TypeId).TypeName
                    };

                    list.Add(m);
                }

                return list;

            }
            return null;
        }


        public string CustomerServiceMsg(long serviceid, decimal amount)
        {
            var msg = "Customer Debited with " + amount + ", for Service " + serviceid + " invoice no.";
            return msg;
        }

        public string CustomerServicePaidMsg(long serviceid, decimal amount)
        {
            var msg = "Customer Credited with " + amount + ", for Service " + serviceid + "invoice no.";
            return msg;
        }

        public IEnumerable<Person> GetLoanPersons()
        {
            return dbContext.Persons.Where(x => x.DeletedAt == null).ToList();
        }
        public IEnumerable<OfficePerson> GetOfficeLoanPersons()
        {
            return dbContext.OfficePeople.Where(x => x.DeletedAt == null).ToList();
        }

        public IEnumerable<ServiceCategory> GetServiceCategories()
        {
            return dbContext.ServiceCategories.Where(x => x.DeletedAt == null && x.Status == 1).ToList();
        }

        public IEnumerable<ProductBatch> GetProductBatchesForEdit()
        {

            if (dbContext != null)
            {
                return dbContext.ProductBatches.Where(x => x.DeletedAt == null).ToList();

                //var batches = dbContext.ProductBatches.Where(x => x.StockQty != 0 && x.DeletedAt == null).ToList();
                //List<ProductBatch> list = new List<ProductBatch>();

                //foreach (var model in batches)
                //{
                //    ProductBatch m = new ProductBatch
                //    {
                //        Id = model.Id,
                //        BatchId = model.BatchId,
                //        BatchIdName = model.BatchId + " | " + model.ExpireDate?.ToString("dd/MM/yyyy"),
                //        ProductId = model.ProductId,
                //        ExpireDate = model.ExpireDate
                //    };

                //    list.Add(m);
                //}
                //return list;
            }
            return null;
        }

        public string getExpenseCategoryName(long id)
        {
            if (id != 0)
                return dbContext.ExpensesCategories.FirstOrDefault(x => x.Id == id).Name;
            else
                return null;
        }
        public string GetCurrentUserId()
        {
            HttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            return httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public string GetUserName(string UserId)
        {
            return dbContext.Users.FirstOrDefault(x => x.Id == UserId).FullName;
        }


        public void SuccessMessage()
        {
            toastNotification.AddSuccessToastMessage("Operation has been completed successfully!");
        }
        public void ErrorMessage()
        {
            toastNotification.AddErrorToastMessage("Something went wrong, please try again later!\nPlease view errors in system error logs file.");
        }
        public void WarningMessage(string msg)
        {
            toastNotification.AddWarningToastMessage(msg);
        }
        public void InfoMessage(string msg)
        {
            toastNotification.AddInfoToastMessage(msg);
        }
        public void AlertMessage(string msg)
        {
            toastNotification.AddAlertToastMessage(msg);
        }
        public void LogError()
        {

        }

        //Transaction Code

        public string GetTransactionCode()
        {
            string code = "TRC-" + DateTime.Now.Year.ToString() + "" + DateTime.Now.Month.ToString() + "" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour + "" + DateTime.Now.Minute + "" + DateTime.Now.Second;
            return code;
        }

        public string GetBatchId(long productId)
        {
            string code = DateTime.Now.Year.ToString() + "" + DateTime.Now.Month.ToString() + "" + DateTime.Now.Day.ToString() + "" + DateTime.Now.Hour + "" + DateTime.Now.Minute + "" + productId;
            return code;
        }


        public string SupplierPreviousBalanceMsg(decimal amount)
        {
            var msg = "Supplier Account Debited with " + amount + " amount from Previous Balance";
            return msg;
        }

        public string SupplierDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Supplier Account Debited with " + amount + " amount from voucher No. " + voucherId;
            return msg;
        }

        public string SupplierCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Supplier Account Credited with " + amount + " amount from voucher No. " + voucherId;
            return msg;
        }

        public string SupplierCashPreviousBalanceMsg(decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Supplier Previous Balance";
            return msg;
        }

        public string SupplierCashDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Cash Debited with " + amount + " amount from Supplier voucher No. " + voucherId;
            return msg;
        }

        public string SupplierCashCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Supplier voucher No. " + voucherId;
            return msg;
        }

        public string SupplierBankDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + " amount from Supplier voucher No. " + voucherId;
            return msg;
        }

        public string SupplierBankCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Bank Account Credited with " + amount + " amount from Supplier voucher No. " + voucherId;
            return msg;
        }

        public string SupplierPurchaseMsg(string voucherId, decimal amount)
        {
            var msg = "Purchase performed from Supplier on Invoice No. " + voucherId + " with " + amount + " amount.";
            return msg;
        }
        public string SupplierPaidMsg(string voucherId, decimal amount)
        {
            var msg = amount + " paid to Supplier from Invoice No. " + voucherId;
            return msg;
        }

        public string SupplierPaymentMsg(decimal amount)
        {
            var msg = "Supplier Debited with " + amount + ", due to Supplier Payment.";
            return msg;
        }
        public string SupplierPaymentMsg_Cash(decimal amount)
        {
            var msg = "Cash Credited with " + amount + ", due to Supplier Payment.";
            return msg;
        }
        public string SupplierPaymentMsg_Bank(decimal amount)
        {
            var msg = "Bach account Credited with " + amount + ", due to Supplier Payment.";
            return msg;
        }

        public string SupplierAdvancedMsg(decimal amount)
        {
            var msg = "Supplier Debited with " + amount + ", due to Advance payment to supplier.";
            return msg;
        }
        public string SupplierAdvancedMsg_Cash(decimal amount)
        {
            var msg = "Cash Credited with " + amount + ", due to Advance payment to supplier.";
            return msg;
        }
        public string SupplierAdvancedMsg_Bank(decimal amount)
        {
            var msg = "Bach account Credited with " + amount + ", due to Advance payment to supplier.";
            return msg;
        }


        //Customer Ledger Message 
        public string CustomerPreviousBalanceMsg(decimal amount)
        {
            var msg = "Customer Account Debited with " + amount + " amount from Previous Balance";
            return msg;
        }

        public string CustomerDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Customer Account Debited with " + amount + " amount from voucher No. " + voucherId;
            return msg;
        }

        public string CustomerCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Customer Account Credited with " + amount + " amount from voucher No. " + voucherId;
            return msg;
        }

        public string CustomerCashPreviousBalanceMsg(decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Customer Previous Balance";
            return msg;
        }

        public string CustomerCashDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Cash Debited with " + amount + " amount from Customer voucher No. " + voucherId;
            return msg;
        }

        public string CustomerCashCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Customer voucher No. " + voucherId;
            return msg;
        }

        public string CustomerBankDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + " amount from Customer voucher No. " + voucherId;
            return msg;
        }

        public string CustomerBankCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Bank Account Credited with " + amount + " amount from Customer voucher No. " + voucherId;
            return msg;
        }
        public string CustomerReceiveMsg(decimal amount)
        {
            var msg = "Customer Credited with " + amount + ", for Customer Receive.";
            return msg;
        }
        public string CustomerReceiveMsg_Cash(decimal amount)
        {
            var msg = "Cash Debited with " + amount + ", due to Customer Receive.";
            return msg;
        }
        public string CustomerReceiveMsg_Bank(decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + ", due to Customer Receive.";
            return msg;
        }
        public string CustomerAdvancedMsg(decimal amount)
        {
            var msg = "Customer Credited with " + amount + ", for Customer Advanced Payment.";
            return msg;
        }
        public string CustomerAdvancedMsg_Cash(decimal amount)
        {
            var msg = "Cash Debited with " + amount + ", due to Customer Advanced Payment.";
            return msg;
        }
        public string CustomerAdvancedMsg_Bank(decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + ", due to Customer Advanced Payment.";
            return msg;
        }

        public string CustomerSaleMsg(long saleId, decimal amount)
        {
            var msg = "Customer Debited with " + amount + ", for " + saleId + " invoice no.";
            return msg;
        }
        public string CustomerPaidMsg(long saleId, decimal amount)
        {
            var msg = "Customer Credited with " + amount + ", for " + saleId + "invoice no.";
            return msg;
        }


        public string PartnerPreviousBalanceMsg(decimal amount)
        {
            var msg = "Partner Account Debited with " + amount + " amount from Previous Balance";
            return msg;
        }

        public string PartnerDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Partner Account Debited with " + amount + " amount from voucher No. " + voucherId;
            return msg;
        }

        public string PartnerCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Partner Account Credited with " + amount + " amount from voucher No. " + voucherId;
            return msg;
        }

        public string PartnerCashPreviousBalanceMsg(decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Partner Previous Balance";
            return msg;
        }

        public string PartnerCashDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Cash Debited with " + amount + " amount from Partner voucher No. " + voucherId;
            return msg;
        }

        public string PartnerCashCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Partner voucher No. " + voucherId;
            return msg;
        }

        public string PartnerBankDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + " amount from Partner voucher No. " + voucherId;
            return msg;
        }

        public string PartnerBankCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Bank Account Credited with " + amount + " amount from Partner voucher No. " + voucherId;
            return msg;
        }

        public string PartnerInvestmentCreditMsg(decimal amount)
        {
            var msg = "Partner Account Credited with " + amount + " amount for his investment";
            return msg;
        }
        public string PartnerInvestmentDebitMsg_Bank(decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + " amount due to partner investment";
            return msg;
        }

        public string PartnerInvestmentDebitMsg_Cash(decimal amount)
        {
            var msg = "Cash Debited with " + amount + " amount due to partner investment";
            return msg;
        }

        public string PartnerPaymentDebitMsg(decimal amount)
        {
            var msg = "Partner Account Debited with " + amount + " amount for payment to him";
            return msg;
        }
        public string PartnerPaymentCreditMsg_Bank(decimal amount)
        {
            var msg = "Bank Account Credited with " + amount + " amount due to partner payment";
            return msg;
        }

        public string PartnerPaymentCreditMsg_Cash(decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount due to partner payment";
            return msg;
        }



        public string BankDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + " amount from Bank Transaction " + voucherId;
            return msg;
        }

        public string BankCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Bank Account Credited with " + amount + " amount from Bank Transaction " + voucherId;
            return msg;
        }

        public string BankCashDebitMsg(string voucherId, decimal amount)
        {
            var msg = "Cash Debited with " + amount + " amount from Bank Transaction " + voucherId;
            return msg;
        }

        public string BankCashCreditMsg(string voucherId, decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Bank Transaction " + voucherId;
            return msg;
        }

        // Stock Details Description 

        public string StockDetailsMsg(long p, long s, string inv)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var sn = dbContext.Suppliers.FirstOrDefault(x => x.Id == s).Name;
            var msg = pn + " purchased from " + sn + " with voucher no. " + inv;
            return msg;
        }

        public string StockDetailsMsg_Sale(long p, long s, long inv)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var sn = "WALKING CUSTOMER";
            if (s != 0)
                sn = dbContext.Customers.FirstOrDefault(x => x.Id == s).Name;
            var msg = pn + " sold on " + sn + " with invoice no. " + inv;
            return msg;
        }

        public string StockDetailsMsg_Sale_Update(long p, long s, long inv)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var sn = "WALKING CUSTOMER";
            if (s != 0)
                sn = dbContext.Customers.FirstOrDefault(x => x.Id == s).Name;
            var msg = pn + " sold on " + sn + " with invoice no. " + inv + ". (Record updated)";
            return msg;
        }

        public string StockDetailsMsg_Purchase_Return(long p, long s, long purchaseId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var sn = dbContext.Suppliers.FirstOrDefault(x => x.Id == s).Name;
            var msg = pn + " returned to " + sn + " with purchase Id: " + purchaseId;
            return msg;
        }

        public string StockDetailsMsg_Purchase_Return_Delete(long p, long s, long purchaseId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var sn = dbContext.Suppliers.FirstOrDefault(x => x.Id == s).Name;
            var msg = pn + " returned to " + sn + " with purchase Id: " + purchaseId + ", has been Deleted";
            return msg;
        }

        public string StockDetailsMsg_Sale_Return(long p, long s, long saleId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var customerName = "WALKING CUSTOMER";
            if (s > 0)
            {
                customerName = dbContext.Customers.FirstOrDefault(x => x.Id == s).Name;
            }
            var msg = pn + " returned from " + customerName + " with sale Id: " + saleId;
            return msg;
        }

        public string StockDetailsMsg_Sale_Return_Delete(long p, long s, long saleId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var customerName = "WALKING CUSTOMER";
            if (s > 0)
            {
                customerName = dbContext.Customers.FirstOrDefault(x => x.Id == s).Name;
            }
            var msg = pn + " returned from " + customerName + " with sale Id: " + saleId + ", has been Deleted";
            return msg;
        }

        public string StockDetailsMsg_Purchase_Delete(long p, long s, long purchaseId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var supplierName = "";
            if (s > 0)
            {
                supplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == s).Name;
            }
            var msg = pn + " deleted due to purchase deletion, from " + supplierName + " with purchase Id: " + purchaseId;
            return msg;
        }

        public string StockDetailsMsg_PurchaseUpdate_Delete(long p, long s, long purchaseId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var supplierName = "";
            if (s > 0)
            {
                supplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == s).Name;
            }
            var msg = pn + " deleted due to purchase updation, from " + supplierName + " with purchase Id: " + purchaseId;
            return msg;
        }


        public string StockDetailsMsg_PurchaseUpdate_Add(long p, long s, long purchaseId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var supplierName = "";
            if (s > 0)
            {
                supplierName = dbContext.Suppliers.FirstOrDefault(x => x.Id == s).Name;
            }
            var msg = pn + " added after purchase updation, from " + supplierName + " with purchase Id: " + purchaseId;
            return msg;
        }

        public string StockDetailsMsg_Sale_Delete(long p, long c, long saleId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == p).Name;
            var customerName = "WALKING CUSTOMER";
            if (c > 0)
            {
                customerName = dbContext.Customers.FirstOrDefault(x => x.Id == c).Name;
            }

            var msg = pn + " deleted due sale deletion, from " + customerName + " with Sale Id: " + saleId;
            return msg;
        }

        public IEnumerable<ExpensesCategory> GetExpenseCategory()
        {
            return dbContext.ExpensesCategories.Where(x => x.DeletedAt == null && x.Status == 1).ToList();
        }

        public IEnumerable<Designation> GetDesignations()
        {
            return dbContext.Designations.Where(x => x.DeletedAt == null).ToList();
        }

        public IEnumerable<AssetsCategory> GetAssetCategories()
        {
            return dbContext.AssetsCategories.Where(x => x.DeletedAt == null).ToList();
        }

        public IEnumerable<Asset> GetAssets()
        {
            return dbContext.Assets.Where(x => x.DeletedAt == null).ToList();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return dbContext.Employees.Where(x => x.DeletedAt == null && x.Leavedate == null).ToList();
        }

        // Expense Payment
        public string ExpensePaymentMsg(decimal amount)
        {
            var msg = "Expense Debited with " + amount + ", due to Owner equity.";
            return msg;
        }
        public string ExpensePaymentMsg_Cash(decimal amount)
        {
            var msg = "Cash Credited with " + amount + ", due to Expense Payment.";
            return msg;
        }
        public string ExpensePaymentMsg_Bank(decimal amount)
        {
            var msg = "Bank account Credited with " + amount + ", due to Expense Payment.";
            return msg;
        }

        public string ExpenseTransactionDelete_Msg(decimal amount)
        {
            var msg = "Transiction Debited with " + amount + ", due to User Delete Record";
            return msg;
        }

        public string ExpenseDeletePaymentMsg_Cash(decimal amount)
        {
            var msg = "Cash debited with " + amount + ", due to User Delete Record";
            return msg;
        }

        public string ExpenseDeletePaymentMsg_Bank(decimal amount)
        {
            var msg = "Bank account debited  with " + amount + ", due to User Delete Record";
            return msg;
        }


        public string PersonLoanPreviousBalanceMsg(decimal amount)
        {
            var msg = "Person Loan Account Debited with " + amount + " amount from Previous Balance";
            return msg;
        }

        public string PersonLoanCashPreviousBalanceMsg(decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Person Loan Previous Balance";
            return msg;
        }

        public string PersonLoanPaymentMsg(decimal amount)
        {
            var msg = "Person Loan Debited with " + amount + ", due to Person Payment.";
            return msg;
        }

        public string PersonLoanPaymentMsg_Cash(decimal amount)
        {
            var msg = "Cash Credited with " + amount + ", due to Person Payment.";
            return msg;
        }

        public string PersonLoanPaymentMsg_Bank(decimal amount)
        {
            var msg = "Bank account Credited with " + amount + ", due to Person Payment.";
            return msg;
        }

        public string PersonLoanReceiveMsg(decimal amount)
        {
            var msg = "Person Credited with " + amount + ", for Person Loan Receive.";
            return msg;
        }
        public string PersonLoanReceiveMsg_Cash(decimal amount)
        {
            var msg = "Cash Debited with " + amount + ", due to Person Loan Receive.";
            return msg;
        }

        public string PersonLoanReceiveMsg_Bank(decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + ", due to Person Loan Receive.";
            return msg;
        }

        public string OfficeLoanPreviousBalanceMsg(decimal amount)
        {
            var msg = "Office Person Account Debited with " + amount + " amount from Previous Loan Balance";
            return msg;
        }

        public string OfficeLoanCashPreviousBalanceMsg(decimal amount)
        {
            var msg = "Cash Credited with " + amount + " amount from Office  Previous Loan Balance";
            return msg;
        }

        public string OfficeLoanPaymentMsg(decimal amount)
        {
            var msg = "Office Person Debited with " + amount + ", due to Loan Payment.";
            return msg;
        }

        public string OfficeLoanPaymentMsg_Cash(decimal amount)
        {
            var msg = "Cash Credited with " + amount + ", due to Office Loan Payment.";
            return msg;
        }

        public string OfficeLoanPaymentMsg_Bank(decimal amount)
        {

            var msg = "Bank account Credited with " + amount + ", due to Office Loan Payment.";
            return msg;
        }

        public string OfficeLoanReceiveMsg(decimal amount)
        {
            var msg = "Person Credited with " + amount + ", for Office Loan Receive.";
            return msg;
        }

        public string OfficeLoanReceiveMsg_Cash(decimal amount)
        {
            var msg = "Cash Debited with " + amount + ", due to Office Loan Receive.";
            return msg;
        }

        public string OfficeLoanReceiveMsg_Bank(decimal amount)
        {
            var msg = "Bank Account Debited with " + amount + ", due to Office Loan Receive.";
            return msg;
        }


        public string SupplierReturnMsg(long returnId, decimal amount)
        {
            var msg = "Supplier Account Debited with " + amount + " amount from Return Id. " + returnId;
            return msg;
        }

        public string SupplierReturnMsg_Delete(long returnId, decimal amount)
        {
            var msg = "Supplier Account Credited due to Return Deletion with " + amount + " amount from Return Id. " + returnId;
            return msg;
        }
        public string SupplierReturnPaidMsg(long returnId, decimal amount)
        {
            var msg = "Supplier Account Credited with " + amount + " amount from Return Id. " + returnId;
            return msg;
        }

        public string SupplierReturnPaidMsg_Delete(long returnId, decimal amount)
        {
            var msg = "Supplier Account Debited due to Return Deletion with " + amount + " amount from Return Id. " + returnId;
            return msg;
        }

        public string CustomerReturnMsg(long returnId, decimal amount)
        {
            var msg = "Customer Account Credited with " + amount + " amount from Return Id. " + returnId;
            return msg;
        }

        public string CustomerReturnMsg_Delete(long returnId, decimal amount)
        {
            var msg = "Customer Account Debited due to Return Deletion with " + amount + " amount from Return Id. " + returnId;
            return msg;
        }
        public string CustomerReturnPaidMsg(long returnId, decimal amount)
        {
            var msg = "Customer Account Debited with " + amount + " amount from Return Id. " + returnId;
            return msg;
        }

        public string CustomerReturnPaidMsg_Delete(long returnId, decimal amount)
        {
            var msg = "Customer Account Credited due to Return Deletion with " + amount + " amount from Return Id. " + returnId;
            return msg;
        }


        public string WastageStockMsg(long productId, long wastageId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == productId).Name;
            var msg = pn + " has been removed from stock due to ID# " + wastageId + " wastage/damage";
            return msg;
        }

        public string WastageStockMsg_Delete(long productId, long wastageId)
        {
            var pn = dbContext.Products.FirstOrDefault(x => x.Id == productId).Name;
            var msg = pn + " added to stock from ID# " + wastageId + " wastage/damage delete";
            return msg;
        }

        public string SupplierPurchaseTotalMsg_Delete(long purchaseId, decimal amount)
        {
            var msg = amount + " has been debited of supplier for purchase (ID#:" + purchaseId + ") deletion";
            return msg;
        }
        public string SupplierPurchasePaidMsg_Delete(long purchaseId, decimal amount)
        {
            var msg = amount + " has been credited of supplier for purchase (ID#:" + purchaseId + ") deletion";
            return msg;
        }

        public string CashBankPurchasePaidMsg_Delete(long purchaseId, decimal amount)
        {
            var msg = amount + " has Debited of Cash/Bank for purchase (ID#:" + purchaseId + ") deletion";
            return msg;
        }

        public string CustomerSaleTotalMsg_Delete(long saleId, decimal amount)
        {
            var msg = amount + " has been credited of customer for sale (ID#: " + saleId + ") deletion";
            return msg;
        }
        public string CustomerSalePaidMsg_Delete(long saleId, decimal amount)
        {
            var msg = amount + " has been debited of customer for sale (ID#: " + saleId + ") deletion";
            return msg;
        }
        public string CashBankSalePaidMsg_Delete(long saleId, decimal amount)
        {
            var msg = amount + " has Credited of Cash/Bank for sale (ID#: " + saleId + ") deletion";
            return msg;
        }


        public string EmployeeSalaryPaymentMsg(decimal amount)
        {
            var msg = "Employee Debited with " + amount + ", due to Salary Payment";
            return msg;
        }

        public string EmployeeSalaryTransictionMsg(decimal amount)
        {
            var msg = "Employee Debited with " + amount + ", Ledger - due to Salary Payment.";
            return msg;
        }

        public string EmployeeSalaryPaymentMsg_Cash(decimal amount)
        {
            var msg = "Cash Credited with " + amount + ", due to Salary Payment.";
            return msg;
        }

        public string EmployeeSalaryTransactionDelete_Msg(decimal amount)
        {
            var msg = "Transiction Amount with " + amount + ", due to User Delete Record";
            return msg;
        }

        public string EmployeeSalaryDeletePaymentMsg_Cash(decimal amount)
        {
            var msg = "Cash debited with " + amount + ", due to User Delete Record";
            return msg;
        }

    }
}
