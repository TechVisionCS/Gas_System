using PMS.Models.Finance;

namespace PMS.Repositories.IRepositories
{
    public interface ITransactionRepository
    {
        bool AddTransactionLog(Transaction transaction);

        SupplierLedger AddSupplierLedger(SupplierLedger supplierLedger);
        SupplierLedger UpdateSupplierLedger(SupplierLedger supplierLedger);
        SupplierLedger DeleteSupplierLedger(SupplierLedger supplierLedger);

        CustomerLedger AddCustomerLedger(CustomerLedger customerLedger);
        CustomerLedger UpdateCustomerLedger(CustomerLedger customerLedger);
        CustomerLedger DeleteCustomerLedger(CustomerLedger customerLedger);

        PartnerLedger AddPartnerLedger(PartnerLedger partnerLedger);
        PartnerLedger UpdatePartnerLedger(PartnerLedger partnerLedger);
        PartnerLedger DeletePartnerLedger(PartnerLedger partnerLedger);

        CashLedger AddCashLedger(CashLedger cashLedger);
        CashLedger UpdateCashLedger(CashLedger cashLedger);
        CashLedger DeleteCashLedger(CashLedger cashLedger);

        BankLedger AddBankLedger(BankLedger bankLedger);
        BankLedger UpdateBankLedger(BankLedger bankLedger);
        BankLedger DeleteBankLedger(BankLedger bankLedger);

        //Saraf Ledger
        SarafLedger AddSarafLedger(SarafLedger sarafLedger);
        SarafLedger UpdateSarafLedger(SarafLedger sarafLedger);
        SarafLedger DeleteSarafLedger(SarafLedger sarafLedger);

        //Personal Loan   
        PersonalLoanLedger AddPersonalLoanLedger(PersonalLoanLedger personalLoanLedger);
        PersonalLoanLedger UpdatePersonalLoanLedger(PersonalLoanLedger personalLoanLedger);
        PersonalLoanLedger DeletePersonalLoanLedger(PersonalLoanLedger personalLoanLedger);

        //Office Loan   
        OfficeLoanLedger AddOfficeLoanLedger(OfficeLoanLedger officeLoanLedger);
        OfficeLoanLedger UpdateOfficeLoanLedger(OfficeLoanLedger officeLoanLedger);
        OfficeLoanLedger DeleteOfficeLoanLedger(OfficeLoanLedger officeLoanLedger);



        //Employee Ledger   
        EmployeeLedger AddEmployeeSalaryLedger(EmployeeLedger employeeLedger);
        EmployeeLedger UpdateEmployeeSalaryLedger(EmployeeLedger employeeLedger);
        EmployeeLedger DeleteEmployeeSalaryLedger(EmployeeLedger employeeLedger);
    }
}
