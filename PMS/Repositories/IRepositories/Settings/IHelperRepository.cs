using PMS.Models;
using PMS.Models.FixedAsset;
using PMS.Models.Lookup;
using PMS.Models.OfficeLoan;
using PMS.Models.PersonalLoan;
using PMS.ViewModels.ProductViewModels;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IHelperRepository
    {
        IEnumerable<Country> GetCountry();
        IEnumerable<Province> GetProvinces();
        IEnumerable<Province> GetProvincesById(long id);
        IEnumerable<Unit> GetUnit();
        IEnumerable<Category> GetCategory();
        IEnumerable<Customer> GetCustomer();
        IEnumerable<Supplier> GetSupplier();
        IEnumerable<Supplier> GetAllSupplier();
        IEnumerable<Partner> GetPartner();
        IEnumerable<ProductType> GetProductType();
        IEnumerable<ProductType> GetProductTypesById(long CategoryName);
        IEnumerable<Manufacturer> GetManufacturers();
        IEnumerable<ProductDropDownListViewModel> GetProducts();
        IEnumerable<ServiceCategory> GetServiceCategories();
        IEnumerable<ProductBatch> GetProductBatchesForEdit();
        IEnumerable<Person> GetLoanPersons();
        IEnumerable<OfficePerson> GetOfficeLoanPersons();

        string getExpenseCategoryName(long id);

        IEnumerable<Bank> GetBanks();
        IEnumerable<Saraf> GetSarafs();
        string GetCurrentUserId();
        string GetUserName(string userId);

        void SuccessMessage();
        void ErrorMessage();
        void WarningMessage(string msg);
        void InfoMessage(string msg);
        void AlertMessage(string msg);
        void LogError();

        //Transaction Code
        string GetTransactionCode();
        string GetBatchId(long productId);

        //Supplier Messages
        string SupplierPreviousBalanceMsg(decimal amount);
        string SupplierDebitMsg(string voucherId, decimal amount);
        string SupplierCreditMsg(string voucherId, decimal amount);
        string SupplierCashPreviousBalanceMsg(decimal amount);
        string SupplierCashDebitMsg(string voucherId, decimal amount);
        string SupplierCashCreditMsg(string voucherId, decimal amount);
        string SupplierBankDebitMsg(string voucherId, decimal amount);
        string SupplierBankCreditMsg(string voucherId, decimal amount);
        string SupplierPurchaseMsg(string voucherId, decimal amount);
        string SupplierPaidMsg(string voucherId, decimal amount);
        string SupplierPaymentMsg(decimal amount);
        string SupplierPaymentMsg_Cash(decimal amount);
        string SupplierPaymentMsg_Bank(decimal amount);

        string SupplierAdvancedMsg(decimal amount);
        string SupplierAdvancedMsg_Cash(decimal amount);
        string SupplierAdvancedMsg_Bank(decimal amount);

        //Customer Messages
        string CustomerPreviousBalanceMsg(decimal amount);
        string CustomerDebitMsg(string voucherId, decimal amount);
        string CustomerCreditMsg(string voucherId, decimal amount);
        string CustomerCashPreviousBalanceMsg(decimal amount);
        string CustomerCashDebitMsg(string voucherId, decimal amount);
        string CustomerCashCreditMsg(string voucherId, decimal amount);
        string CustomerBankDebitMsg(string voucherId, decimal amount);
        string CustomerBankCreditMsg(string voucherId, decimal amount);

        string CustomerReceiveMsg(decimal amount);
        string CustomerReceiveMsg_Cash(decimal amount);
        string CustomerReceiveMsg_Bank(decimal amount);

        string CustomerAdvancedMsg(decimal amount);
        string CustomerAdvancedMsg_Cash(decimal amount);
        string CustomerAdvancedMsg_Bank(decimal amount);

        string CustomerSaleMsg(long saleId, decimal amount);
        string CustomerPaidMsg(long saleId, decimal amount);
        string CustomerServiceMsg(long serviceid, decimal amount);
        string CustomerServicePaidMsg(long serviceid, decimal amount);

        //Partner Messages
        string PartnerPreviousBalanceMsg(decimal amount);
        string PartnerDebitMsg(string voucherId, decimal amount);
        string PartnerCreditMsg(string voucherId, decimal amount);
        string PartnerCashPreviousBalanceMsg(decimal amount);
        string PartnerCashDebitMsg(string voucherId, decimal amount);
        string PartnerCashCreditMsg(string voucherId, decimal amount);
        string PartnerBankDebitMsg(string voucherId, decimal amount);
        string PartnerBankCreditMsg(string voucherId, decimal amount);
        string PartnerInvestmentCreditMsg(decimal amount);
        string PartnerInvestmentDebitMsg_Bank(decimal amount);
        string PartnerInvestmentDebitMsg_Cash(decimal amount);
        string PartnerPaymentDebitMsg(decimal amount);
        string PartnerPaymentCreditMsg_Bank(decimal amount);
        string PartnerPaymentCreditMsg_Cash(decimal amount);

        //Bank Messages 
        string BankDebitMsg(string voucherId, decimal amount);
        string BankCreditMsg(string voucherId, decimal amount);
        string BankCashDebitMsg(string voucherId, decimal amount);
        string BankCashCreditMsg(string voucherId, decimal amount);

        //Saraf Messages

        string SarafDebitMsg(string voucherId, decimal amount);
        string SarafCreditMsg(string voucherId, decimal amount);
        string SarafCashDebitMsg(string voucherId, decimal amount);
        string SarafCashCreditMsg(string voucherId, decimal amount);


        // Stock Details Description

        string StockDetailsMsg(long p, long s, string inv);
        string StockDetailsMsg_Sale(long p, long s, long inv);
        string StockDetailsMsg_Sale_Update(long p, long s, long inv);

        string StockDetailsMsg_Purchase_Return(long p, long s, long purchaseId);
        string StockDetailsMsg_Purchase_Return_Delete(long p, long s, long purchaseId);

        string StockDetailsMsg_Sale_Return(long p, long s, long saleId);
        string StockDetailsMsg_Sale_Return_Delete(long p, long s, long saleId);
        string StockDetailsMsg_Purchase_Delete(long p, long s, long purchaseId);
        string StockDetailsMsg_PurchaseUpdate_Delete(long p, long s, long purchaseId);
        string StockDetailsMsg_PurchaseUpdate_Add(long p, long s, long purchaseId);
        string StockDetailsMsg_Sale_Delete(long p, long c, long saleId);

        //Expense related ...
        IEnumerable<ExpensesCategory> GetExpenseCategory();
        IEnumerable<Designation> GetDesignations();

        IEnumerable<AssetsCategory> GetAssetCategories();
        IEnumerable<Asset> GetAssets();
        IEnumerable<Employee> GetEmployees();

        // Expense Payment Msg
        string ExpensePaymentMsg(decimal amount);
        string ExpensePaymentMsg_Cash(decimal amount);
        string ExpensePaymentMsg_Bank(decimal amount);
        string ExpenseTransactionDelete_Msg(decimal amount);
        string ExpenseDeletePaymentMsg_Cash(decimal amount);
        string ExpenseDeletePaymentMsg_Bank(decimal amount);


        //Personal Loan 
        string PersonLoanPreviousBalanceMsg(decimal amount);
        string PersonLoanCashPreviousBalanceMsg(decimal amount);
        string PersonLoanPaymentMsg(decimal amount);
        string PersonLoanPaymentMsg_Cash(decimal amount);
        string PersonLoanPaymentMsg_Bank(decimal amount);
        string PersonLoanReceiveMsg(decimal amount);
        string PersonLoanReceiveMsg_Cash(decimal amount);
        string PersonLoanReceiveMsg_Bank(decimal amount);

        //Personal Loan 
        string OfficeLoanPreviousBalanceMsg(decimal amount);
        string OfficeLoanCashPreviousBalanceMsg(decimal amount);
        string OfficeLoanPaymentMsg(decimal amount);
        string OfficeLoanPaymentMsg_Cash(decimal amount);
        string OfficeLoanPaymentMsg_Bank(decimal amount);
        string OfficeLoanReceiveMsg(decimal amount);
        string OfficeLoanReceiveMsg_Cash(decimal amount);
        string OfficeLoanReceiveMsg_Bank(decimal amount);

        string SupplierReturnMsg(long returnId, decimal amount);
        string SupplierReturnMsg_Delete(long returnId, decimal amount);
        string SupplierReturnPaidMsg(long returnId, decimal amount);
        string SupplierReturnPaidMsg_Delete(long returnId, decimal amount);

        string CustomerReturnMsg(long returnId, decimal amount);
        string CustomerReturnMsg_Delete(long returnId, decimal amount);
        string CustomerReturnPaidMsg(long returnId, decimal amount);
        string CustomerReturnPaidMsg_Delete(long returnId, decimal amount);

        string WastageStockMsg(long productId, long wastageId);
        string WastageStockMsg_Delete(long productId, long wastageId);


        string SupplierPurchaseTotalMsg_Delete(long purchaseId, decimal amount);
        string SupplierPurchasePaidMsg_Delete(long purchaseId, decimal amount);
        string CashBankPurchasePaidMsg_Delete(long purchaseId, decimal amount);

        string CustomerSaleTotalMsg_Delete(long saleId, decimal amount);
        string CustomerSalePaidMsg_Delete(long saleId, decimal amount);
        string CashBankSalePaidMsg_Delete(long saleId, decimal amount);


        //Employee ledger

        // Expense Payment Msg
        string EmployeeSalaryPaymentMsg(decimal amount);
        string EmployeeSalaryTransictionMsg(decimal amount);
        string EmployeeSalaryPaymentMsg_Cash(decimal amount);
        string EmployeeSalaryTransactionDelete_Msg(decimal amount);
        string EmployeeSalaryDeletePaymentMsg_Cash(decimal amount);

    }
}
