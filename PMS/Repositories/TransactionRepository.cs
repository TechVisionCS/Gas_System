using PMS.Data;
using PMS.Models.Finance;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using System;
using System.Linq;

namespace PMS.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;

        public TransactionRepository(ApplicationDbContext _dbContext, PMSHelper pmsHelper)
        {
            dbContext = _dbContext;
            this.pmsHelper = pmsHelper;
        }

        public bool AddTransactionLog(Transaction transaction)
        {
            if (dbContext != null)
            {
                transaction.CreatedAt = DateTime.Now;
                transaction.UpdatedAt = DateTime.Now;
                transaction.UserId = pmsHelper.GetCurrentUserId();
                transaction.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.Transactions.Add(transaction);
                dbContext.SaveChanges();

                return true;
            }

            return false;
        }
        public CashLedger AddCashLedger(CashLedger cashLedger)
        {
            if (dbContext != null)
            {
                cashLedger.CreatedAt = DateTime.Now;
                cashLedger.UpdatedAt = DateTime.Now;
                cashLedger.UserId = pmsHelper.GetCurrentUserId();
                cashLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.CashLedgers.Add(cashLedger);
                dbContext.SaveChanges();

                return cashLedger;
            }

            return null;
        }

        public CashLedger UpdateCashLedger(CashLedger cashLedger)
        {
            if (dbContext != null)
            {
                cashLedger.CreatedAt = cashLedger.CreatedAt;
                cashLedger.UpdatedAt = DateTime.Now;
                cashLedger.UserId = pmsHelper.GetCurrentUserId();
                cashLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.CashLedgers.Update(cashLedger);
                dbContext.SaveChanges();

                return cashLedger;
            }

            return null;
        }

        public CashLedger DeleteCashLedger(CashLedger cashLedger)
        {
            if (dbContext != null)
            {
                dbContext.CashLedgers.Remove(cashLedger);
                dbContext.SaveChanges();

                return cashLedger;
            }

            return null;
        }

        public SupplierLedger AddSupplierLedger(SupplierLedger supplierLedger)
        {
            if (dbContext != null)
            {
                supplierLedger.CreatedAt = DateTime.Now;
                supplierLedger.UpdatedAt = DateTime.Now;
                supplierLedger.UserId = pmsHelper.GetCurrentUserId();
                supplierLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.SupplierLedgers.Add(supplierLedger);
                dbContext.SaveChanges();

                return supplierLedger;
            }

            return null;
        }

        public SupplierLedger UpdateSupplierLedger(SupplierLedger supplierLedger)
        {
            if (dbContext != null)
            {
                supplierLedger.CreatedAt = supplierLedger.CreatedAt;
                supplierLedger.UpdatedAt = DateTime.Now;
                supplierLedger.UserId = pmsHelper.GetCurrentUserId();
                supplierLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.SupplierLedgers.Update(supplierLedger);
                dbContext.SaveChanges();

                return supplierLedger;
            }

            return null;
        }

        public SupplierLedger DeleteSupplierLedger(SupplierLedger supplierLedger)
        {
            if (dbContext != null)
            {
                var deleteSupplierLedgers = dbContext.SupplierLedgers.Where(x => x.TransCode == supplierLedger.TransCode).ToList();
                dbContext.SupplierLedgers.RemoveRange(deleteSupplierLedgers);
                dbContext.SaveChanges();

                return supplierLedger;
            }

            return null;
        }

        public CustomerLedger AddCustomerLedger(CustomerLedger customerLedger)
        {
            if (dbContext != null)
            {
                customerLedger.CreatedAt = DateTime.Now;
                customerLedger.UpdatedAt = DateTime.Now;
                customerLedger.UserId = pmsHelper.GetCurrentUserId();
                customerLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.CustomerLedgers.Add(customerLedger);
                dbContext.SaveChanges();

                return customerLedger;
            }

            return null;
        }

        public CustomerLedger UpdateCustomerLedger(CustomerLedger customerLedger)
        {
            if (dbContext != null)
            {
                customerLedger.CreatedAt = customerLedger.CreatedAt;
                customerLedger.UpdatedAt = DateTime.Now;
                customerLedger.UserId = pmsHelper.GetCurrentUserId();
                customerLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.CustomerLedgers.Update(customerLedger);
                dbContext.SaveChanges();

                return customerLedger;
            }

            return null;
        }

        public CustomerLedger DeleteCustomerLedger(CustomerLedger customerLedger)
        {
            if (dbContext != null)
            {
                var deleteCustomerLedgers = dbContext.CustomerLedgers.Where(x => x.TransCode == customerLedger.TransCode).ToList();
                dbContext.CustomerLedgers.RemoveRange(deleteCustomerLedgers);
                dbContext.SaveChanges();

                return customerLedger;
            }

            return null;
        }

        public PartnerLedger AddPartnerLedger(PartnerLedger partnerLedger)
        {
            if (dbContext != null)
            {
                partnerLedger.CreatedAt = DateTime.Now;
                partnerLedger.UpdatedAt = DateTime.Now;
                partnerLedger.UserId = pmsHelper.GetCurrentUserId();
                partnerLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.PartnerLedgers.Add(partnerLedger);
                dbContext.SaveChanges();

                return partnerLedger;
            }

            return null;
        }

        public PartnerLedger UpdatePartnerLedger(PartnerLedger partnerLedger)
        {
            if (dbContext != null)
            {
                partnerLedger.CreatedAt = partnerLedger.CreatedAt;
                partnerLedger.UpdatedAt = DateTime.Now;
                partnerLedger.UserId = pmsHelper.GetCurrentUserId();
                partnerLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.PartnerLedgers.Update(partnerLedger);
                dbContext.SaveChanges();

                return partnerLedger;
            }

            return null;
        }

        public PartnerLedger DeletePartnerLedger(PartnerLedger partnerLedger)
        {
            if (dbContext != null)
            {
                var deletePartnerLedgers = dbContext.PartnerLedgers.Where(x => x.TransCode == partnerLedger.TransCode).ToList();
                dbContext.PartnerLedgers.RemoveRange(partnerLedger);
                dbContext.SaveChanges();

                return partnerLedger;
            }

            return null;
        }

        public BankLedger AddBankLedger(BankLedger bankLedger)
        {
            if (dbContext != null)
            {
                bankLedger.CreatedAt = DateTime.Now;
                bankLedger.UpdatedAt = DateTime.Now;
                bankLedger.UserId = pmsHelper.GetCurrentUserId();
                bankLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.BankLedgers.Add(bankLedger);
                dbContext.SaveChanges();

                return bankLedger;
            }

            return null;
        }

        public BankLedger UpdateBankLedger(BankLedger bankLedger)
        {
            if (dbContext != null)
            {
                bankLedger.CreatedAt = bankLedger.CreatedAt;
                bankLedger.UpdatedAt = DateTime.Now;
                bankLedger.UserId = pmsHelper.GetCurrentUserId();
                bankLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.BankLedgers.Update(bankLedger);
                dbContext.SaveChanges();

                return bankLedger;
            }

            return null;
        }

        public BankLedger DeleteBankLedger(BankLedger bankLedger)
        {
            if (dbContext != null)
            {
                dbContext.BankLedgers.Remove(bankLedger);
                dbContext.SaveChanges();

                return bankLedger;
            }

            return null;
        }

        public PersonalLoanLedger AddPersonalLoanLedger(PersonalLoanLedger personalLoanLedger)
        {
            if (dbContext != null)
            {
                personalLoanLedger.CreatedAt = DateTime.Now;
                personalLoanLedger.UpdatedAt = DateTime.Now;
                personalLoanLedger.UserId = pmsHelper.GetCurrentUserId();
                personalLoanLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.PersonalLoanLedgers.Add(personalLoanLedger);
                dbContext.SaveChanges();
                return personalLoanLedger;
            }
            return null;
        }

        public PersonalLoanLedger UpdatePersonalLoanLedger(PersonalLoanLedger personalLoanLedger)
        {
            if (dbContext != null)
            {
                personalLoanLedger.CreatedAt = personalLoanLedger.CreatedAt;
                personalLoanLedger.UpdatedAt = DateTime.Now;
                personalLoanLedger.UserId = pmsHelper.GetCurrentUserId();
                personalLoanLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.PersonalLoanLedgers.Update(personalLoanLedger);
                dbContext.SaveChanges();
                return personalLoanLedger;
            }
            return null;
        }

        public PersonalLoanLedger DeletePersonalLoanLedger(PersonalLoanLedger personalLoanLedger)
        {
            if (dbContext != null)
            {
                var deletePersonalLoanLedger = dbContext.PersonalLoanLedgers.Where(x => x.TransCode == personalLoanLedger.TransCode).ToList();
                dbContext.PersonalLoanLedgers.RemoveRange(deletePersonalLoanLedger);
                dbContext.SaveChanges();

                return personalLoanLedger;
            }
            return null;
        }

        public OfficeLoanLedger AddOfficeLoanLedger(OfficeLoanLedger officeLoanLedger)
        {
            if (dbContext != null)
            {
                officeLoanLedger.CreatedAt = DateTime.Now;
                officeLoanLedger.UpdatedAt = DateTime.Now;
                officeLoanLedger.UserId = pmsHelper.GetCurrentUserId();
                officeLoanLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.OfficeLoanLedgers.Add(officeLoanLedger);
                dbContext.SaveChanges();
                return officeLoanLedger;
            }
            return null;
        }

        public OfficeLoanLedger UpdateOfficeLoanLedger(OfficeLoanLedger officeLoanLedger)
        {
            if (dbContext != null)
            {
                officeLoanLedger.CreatedAt = officeLoanLedger.CreatedAt;
                officeLoanLedger.UpdatedAt = DateTime.Now;
                officeLoanLedger.UserId = pmsHelper.GetCurrentUserId();
                officeLoanLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.OfficeLoanLedgers.Update(officeLoanLedger);
                dbContext.SaveChanges();
                return officeLoanLedger;
            }
            return null;
        }

        public OfficeLoanLedger DeleteOfficeLoanLedger(OfficeLoanLedger officeLoanLedger)
        {
            if (dbContext != null)
            {
                var deleteOfficeLoanLedgers = dbContext.OfficeLoanLedgers.Where(x => x.TransCode == officeLoanLedger.TransCode).ToList();
                dbContext.OfficeLoanLedgers.RemoveRange(deleteOfficeLoanLedgers);
                dbContext.SaveChanges();

                return officeLoanLedger;
            }
            return null;
        }


        public EmployeeLedger AddEmployeeSalaryLedger(EmployeeLedger employeeLedger)
        {
            if (dbContext != null)
            {
                employeeLedger.CreatedAt = DateTime.Now;
                employeeLedger.UpdatedAt = DateTime.Now;
                employeeLedger.UserId = pmsHelper.GetCurrentUserId();
                employeeLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.EmployeeLedgers.Add(employeeLedger);
                dbContext.SaveChanges();
                return employeeLedger;
            }
            return null;

        }

        public EmployeeLedger UpdateEmployeeSalaryLedger(EmployeeLedger employeeLedger)
        {
            if (dbContext != null)
            {
                employeeLedger.CreatedAt = employeeLedger.CreatedAt;
                employeeLedger.UpdatedAt = DateTime.Now;
                employeeLedger.UserId = pmsHelper.GetCurrentUserId();
                employeeLedger.UserName = pmsHelper.GetUserName(pmsHelper.GetCurrentUserId());

                dbContext.EmployeeLedgers.Update(employeeLedger);
                dbContext.SaveChanges();
                return employeeLedger;
            }
            return null;
        }

        public EmployeeLedger DeleteEmployeeSalaryLedger(EmployeeLedger employeeLedger)
        {
            if (dbContext != null)
            {
                var deleteEmployeeLedgers = dbContext.EmployeeLedgers.Where(x => x.TransCode == employeeLedger.TransCode).ToList();
                dbContext.EmployeeLedgers.RemoveRange(deleteEmployeeLedgers);
                dbContext.SaveChanges();

                return employeeLedger;
            }
            return null;
        }

    }
}
