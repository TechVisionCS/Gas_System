namespace PMS.Data.Constants
{
    public class TablesConstants
    {
        //lookup
        public const string Category = "wms_category_tbl";
        public const string Unit = "wms_unit_tbl";
        public const string Country = "wms_country_tbl";
        public const string Province = "wms_province_tbl";
        public const string ProductType = "wms_product_type_tbl";
        public const string Manufacturer = "wms_manufacturer_tbl";
        public const string Shop = "wms_shop_tbl";

        //Ledgers
        public const string SupplierLedger = "wms_supplier_ledger_tbl";
        public const string CustomerLedger = "wms_customer_ledger_tbl";
        public const string PartnerLedger = "wms_partner_ledger_tbl";
        public const string CashLedger = "wms_cash_ledger_tbl";
        public const string BankLedger = "wms_bank_ledger_tbl";

        //System Required
        public const string Tax = "wms_tax_tbl";
        public const string ProductTax = "wms_product_tax_tbl";
        public const string Supplier = "wms_supplier_tbl";
        public const string SupplierPayment = "wms_supplier_payment_tbl";
        public const string SupplierAdvanced = "wms_supplier_advanced_tbl";
        public const string Customer = "wms_customer_tbl";
        public const string CustomerReceive = "wms_customer_receive_tbl";
        public const string CustomerAdvanced = "wms_customer_advanced_tbl";
        public const string Bank = "wms_bank_tbl";

        //Product
        public const string Product = "wms_product_tbl";
        public const string ProductSupplier = "wms_product_supplier_tbl";
        public const string ProductBatch = "wms_product_batch_tbl";
        public const string Stock = "wms_stock_tbl";
        public const string StockDetails = "wms_stock_details_tbl";
        public const string StockLog = "wms_stock_purchase_log_tbl";

        public const string Transaction = "wms_transaction_tbl";
        public const string BankTransaction = "wms_bank_transaction_tbl";
        public const string Partner = "wms_partner_tbl";
        public const string PartnerInvestment = "wms_partner_investment_tbl";
        public const string PartnerPayment = "wms_partner_payment_tbl";

        //Purchase
        public const string Purchase = "wms_purchase_tbl";
        public const string PurchaseDetails = "wms_purchase_details_tbl";
        public const string PartnersPurchaseShare = "wms_partners_purchase_shares_tbl";

        //Sale
        public const string Sale = "wms_sale_tbl";
        public const string SaleDetails = "wms_sale_details_tbl";

        //Employee
        public const string Designation = "wms_designation_tbl";
        public const string Employee = "wms_employee_tbl";
        public const string EmployeeSalary = "pms_employee_salaries_tbl";
        public const string EmployeeLedger = "pms_employee_ledger_tbl";


        //Assets 
        public const string AssetsCategory = "wms_assets_category_tbl";
        public const string Asset = "wms_asset_tbl";
        public const string AssetStock = "wms_asset_stock_tbl";
        public const string AssetHandover = "wms_asset_handover_tbl";
        public const string AssetHandoverDetails = "wms_asset_handover_Details_tbl";
        public const string AssetReturn = "wms_asset_return";

        //Expense
        public const string Expense = "wms_expense_tbl";
        public const string ExpenseCategory = "wms_expense_category_tbl";


        //Services 
        public const string ServiceCategory = "wms_service_category_tbl";
        public const string Service = "wms_service_tbl";
        public const string ServiceDetails = "wms_service_details_tbl";

        //Qoute
        public const string Quote = "wms_quote_tbl";
        public const string QuoteDetails = "wms_quote_details_tbl";

        //Personal Loan
        public const string Person = "wms_person_tbl";
        public const string PersonalLoanPayment = "wms_person_loan_payment_tbl";
        public const string PersonalLoanReceive = "wms_person_loan_receive_tbl";
        public const string PersonalLoanLedger = "wms_person_loan_ledger_tbl";

        //Office Loans
        public const string OfficePerson = "wms_office_person_tbl";
        public const string OfficeLoanPayment = "wms_office_loan_payment_tbl";
        public const string OfficeLoanReceive = "wms_office_loan_receive_tbl";
        public const string OfficeLoanLedger = "wms_office_loan_ledger_tbl";

        //returns
        public const string Return = "wms_return_tbl";
        public const string ReturnDetails = "wms_return_details_tbl";
        public const string Wastage = "wms_wastage_tbl";
        public const string WastageDetails = "wms_wastage_details_tbl";

        public const string Saraf = "wms_saraf_tbl";
        public const string SarafLedger = "wms_saraf_leger_tbl";
        public const string SarafTransaction = "wms_saraf_transaction_tbl";



    }
}
