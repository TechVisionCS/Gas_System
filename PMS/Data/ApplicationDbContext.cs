using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PMS.Data.Constants;
using PMS.Models;
using PMS.Models.Finance;
using PMS.Models.FixedAsset;
using PMS.Models.Lookup;
using PMS.Models.OfficeLoan;
using PMS.Models.PersonalLoan;
using PMS.Models.Purchase;
using PMS.Models.Quote;
using PMS.Models.Sale;
using PMS.Models.Service;
using PMS.Models.Settings;
using System.Linq;

namespace PMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        //lookup
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Shop> Shops { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<ProductBatch> ProductBatches { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockDetails> StockDetails { get; set; }
        public DbSet<StockLog> StockLogs { get; set; }

        //System Required
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PartnerInvestment> PartnerInvestments { get; set; }
        public DbSet<PartnerPayment> PartnerPayments { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<ProductTax> ProductTaxes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierPayment> SupplierPayments { get; set; }
        public DbSet<SupplierAdvanced> SupplierAdvanceds { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerReceive> CustomerReceives { get; set; }
        public DbSet<CustomerAdvanced> CustomerAdvanceds { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Saraf> Sarafs { get; set; }

        //Ledger bankTransiction
        public DbSet<PartnerLedger> PartnerLedgers { get; set; }
        public DbSet<SupplierLedger> SupplierLedgers { get; set; }
        public DbSet<CustomerLedger> CustomerLedgers { get; set; }
        public DbSet<CashLedger> CashLedgers { get; set; }
        public DbSet<BankLedger> BankLedgers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<SarafTransaction> SarafTransactions { get; set; }
        public DbSet<SarafLedger> SarafLedgers { get; set; }

        //Purchase
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetails { get; set; }
        public DbSet<PartnersPurchaseShare> PartnersPurchaseShares { get; set; }

        //Sale
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetails> SaleDetails { get; set; }

        //Expense
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpensesCategory> ExpensesCategories { get; set; }

        //HRM 
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public DbSet<EmployeeLedger> EmployeeLedgers { get; set; }

        //Assets 
        public DbSet<AssetsCategory> AssetsCategories { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetStock> AssetStocks { get; set; }
        public DbSet<AssetHandover> AssetHandovers { get; set; }
        public DbSet<AssetHandoverDetails> AssetHandoverDetails { get; set; }
        public DbSet<AssetReturn> AssetReturns { get; set; }

        //Services
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ServiceDetails> ServiceDetails { get; set; }

        //Qoutes 
        public DbSet<Quote> Quote { get; set; }
        public DbSet<QuoteDetails> QuoteDetails { get; set; }

        // Personal laon
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonalLoanPayment> PersonalLoanPayments { get; set; }
        public DbSet<PersonalLoanReceive> PersonalLoanReceives { get; set; }
        public DbSet<PersonalLoanLedger> PersonalLoanLedgers { get; set; }

        // Office laon
        public DbSet<OfficePerson> OfficePeople { get; set; }
        public DbSet<OfficeLoanPayment> OfficeLoanPayments { get; set; }
        public DbSet<OfficeLoanReceive> OfficeLoanReceives { get; set; }
        public DbSet<OfficeLoanLedger> OfficeLoanLedgers { get; set; }

        //return
        public DbSet<Return> Returns { get; set; }
        public DbSet<ReturnDetails> ReturnDetails { get; set; }

        public DbSet<Wastage> Wastages { get; set; }
        public DbSet<WastageDetails> WastageDetails { get; set; }

        public DbSet<ProductUnit> ProductUnits { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var foreignKey in builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
            //builder.Entity<ProductBatch>().HasIndex(x => x.BarCode).IsUnique();
            //builder.Entity<ProductBatch>().HasIndex(x => x.BatchId).IsUnique();
            builder.Entity<ProductTax>().HasKey(mt => new { mt.ProductId, mt.TaxId });
            //builder.Entity<ProductTax>().HasOne(mt => mt.Tax).WithMany(t => t.productTaxes).HasForeignKey(mt => mt.TaxId);

            builder.Entity<ProductUnit>()
        .HasKey(bc => new { bc.ProductId, bc.UnitId });
            builder.Entity<ProductUnit>()
                .HasOne(bc => bc.Product)
                .WithMany(b => b.ProductsUnits)
                .HasForeignKey(bc => bc.ProductId);
            builder.Entity<ProductUnit>()
                .HasOne(bc => bc.Unit)
                .WithMany(c => c.ProductsUnits)
                .HasForeignKey(bc => bc.UnitId);

            builder.Entity<Manufacturer>().HasData(
             new Manufacturer { Id = 1, Name = "2A Muhendislik San.- Tur ", Description = "Turkey", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 2, Name = "Sinopec", Description = "China Petroleum and Chemical Corporation, also known as Sinopec, is the second-largest company behind US retailer Walmart and ", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 3, Name = "China National Petroleum", Description = "China National Petroleum is the state-owned parent company of PetroChina – the country’s second-largest oil producer.", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 4, Name = " Saudi Aramco", Description = "Saudi Aramco is the state-owned oil company of the Kingdom of Saudi Arabia and is the third-largest oil and gas company in Asia and the fourth-largest in the world by revenue.", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 5, Name = "Eneos Holdings ", Description = "Eneos Holdings is a Japanese petroleum and metals conglomerate and the fifth-largest oil and gas company in Asia by revenue.The Tokyo - headquartered firm brought in $75.9bn at the end of the 2019 - 20 fiscal year and recorded a $1.7bn loss across the same period.", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 6, Name = "Adeel Industry(Shan Gas)", Description = "", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 7, Name = "Bashir gas pvt limited", Description = "", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 8, Name = "Burhan Gas Company", Description = "", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 9, Name = "Country Autogas", Description = "", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 10, Name = "Engineering solution international", Description = "", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 11, Name = "ExpoMughal International", Description = "", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 12, Name = "HI-Tek Manufacturing (Pvt) Ltd", Description = "", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 13, Name = "Pak Engineering and Automation", Description = "", Status = 1, UserName = "System_Populated" },
             new Manufacturer { Id = 14, Name = "Engineering solution international", Description = "", Status = 1, UserName = "System_Populated" }
             );

            builder.Entity<Category>().HasData(
                      new Category { Id = 1, Name = "Liquefied petroleum gas LPG", Status = 1, Description = "Liquefied petroleum gas (LPG, LP gas, or condensate), is a flammable mixture of hydrocarbon gases, most commonly propane, butane, and propylene. However, the latter two typically comprise 5% or less of the mixture.", UserName = "System Defined" },
                      new Category { Id = 2, Name = "Syngas", Status = 1, Description = "Syngas, or synthesis gas, is a fuel gas mixture consisting primarily of hydrogen, carbon monoxide, and very often some carbon dioxide. Syngas can be produced from many sources, including natural gas, coal, biomass, or virtually any hydrocarbon feedstock, by reaction with steam (steam reforming), carbon dioxide (dry reforming) or oxygen (partial oxidation).", UserName = "System Defined" },
                      new Category { Id = 3, Name = "Natural gas", Status = 1, Description = "Natural gas is colorless and odorless, and explosive, so a sulfur-smell (similar to rotten eggs) is usually added for early detection of leaks", UserName = "System Defined" },
                      new Category { Id = 4, Name = "Propane", Status = 1, Description = "Propane (/ˈproʊpeɪn/) is a three-carbon alkane with the molecular formula C3H8. It is a gas at standard temperature and pressure, but compressible to a transportable liquid.", UserName = "System Defined" },
                      new Category { Id = 5, Name = "Gas stove", Status = 1, Description = "A gas stove is a stove that is fuelled by combustible gas such as syngas, natural gas, propane, butane, liquefied petroleum gas or other flammable gas.", UserName = "System Defined" },
                      new Category { Id = 6, Name = "Butane", Status = 1, Description = "Butane is a gas at room temperature and atmospheric pressure. Butane is a highly flammable, colorless, easily liquefied gas that quickly vaporizes at room temperature.", UserName = "System Defined" }
                  );

            builder.Entity<Country>().HasData(
                   new Country { Id = 1, Name = "Afghanistan", Code = "AFN", UserName = "System_Populated" },
                   new Country { Id = 2, Name = "Pakistan", Code = "PK", UserName = "System_Populated" },
                   new Country { Id = 3, Name = "India", Code = "IND", UserName = "System_Populated" },
                   new Country { Id = 4, Name = "Turkey", Code = "TUR", UserName = "System_Populated" },
                   new Country { Id = 5, Name = "Iran", Code = "IR", UserName = "System_Populated" }
                   );

            builder.Entity<Province>().HasData(
                  new Province { Id = 1, Name = "Badakhshan", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 2, Name = "Badghis", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 3, Name = "Baghlan", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 4, Name = "Balkh", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 5, Name = "Bamyan", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 6, Name = "Daykundi", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 7, Name = "Farah", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },

                  new Province { Id = 8, Name = "Faryab", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 9, Name = "Ghazni", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 10, Name = "Ghor", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 11, Name = "Helmand", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 12, Name = "Herat", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 13, Name = "Jowzjan", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 14, Name = "Kabul", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 15, Name = "Kandahar", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 16, Name = "Kapisa", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 17, Name = "Khost", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 18, Name = "Kunar", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 19, Name = "Kunduz", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 20, Name = "Laghman", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 21, Name = "Logar", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 22, Name = "Nangarhar", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 23, Name = "Nimruz", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 24, Name = "Nuristan", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 25, Name = "Urozgan", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 26, Name = "Paktia", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 27, Name = "Paktika", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 28, Name = "Panjshir", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 29, Name = "Parwan", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 30, Name = "Samangan", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 31, Name = "Sar-e Pol", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 32, Name = "Takhar", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 33, Name = "Wardak", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },
                  new Province { Id = 34, Name = "Zabul", CountryId = 1, CountryCode = "AFN", CountryName = "Afghanistan", UserName = "System_Populated" },

                  new Province { Id = 35, Name = "Punjab", CountryId = 2, CountryCode = "PK", CountryName = "Pakistan", UserName = "System_Populated" },
                  new Province { Id = 36, Name = "RawalPindi", CountryId = 2, CountryCode = "PK", CountryName = "Pakistan", UserName = "System_Populated" },
                  new Province { Id = 37, Name = "Jehlum", CountryId = 2, CountryCode = "PK", CountryName = "Pakistan", UserName = "System_Populated" },
                  new Province { Id = 38, Name = "Sohawa", CountryId = 2, CountryCode = "PK", CountryName = "Pakistan", UserName = "System_Populated" },
                  new Province { Id = 39, Name = "Peshawar", CountryId = 2, CountryCode = "PK", CountryName = "Pakistan", UserName = "System_Populated" },

                  new Province { Id = 40, Name = "Andhra Pradesh", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 41, Name = "Arunachal Pradesh", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 42, Name = "Assam", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 43, Name = "Bihar", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 44, Name = "Chhattisgarh", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 45, Name = "Goa", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 46, Name = "Gujarat", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 47, Name = "Haryana", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 48, Name = "Himachal Pradesh", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 49, Name = "Jharkhand", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 50, Name = "Karnataka", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 51, Name = "Kerala", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 52, Name = "Madhya Pradesh", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 53, Name = "Maharashtra", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 54, Name = "Manipur", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 55, Name = "Meghalaya", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 56, Name = "Mizoram", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 57, Name = "Nagaland", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 58, Name = "Odisha", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 59, Name = "Punjab", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 60, Name = "Rajasthan", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 61, Name = "Sikkim", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 62, Name = "Tamil Nadu", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 63, Name = "Telangana", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 64, Name = "Telangana", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 65, Name = "Tripura", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 66, Name = "Uttar Pradesh", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },
                  new Province { Id = 67, Name = "Uttarakhand", CountryId = 3, CountryCode = "IND", CountryName = "India", UserName = "System_Populated" },


                  new Province { Id = 68, Name = "Adana", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 69, Name = "Adıyaman", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 70, Name = "Afyonkarahisar", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 71, Name = "Ağri", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 72, Name = "Aksaray", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 73, Name = "Amasya", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 74, Name = "Ankara", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 75, Name = "Antalya", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 76, Name = "Ardahan", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 77, Name = "Artvin", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 78, Name = "Aydın", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 79, Name = "Balıkesir", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 80, Name = "Bartın", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 81, Name = "Batman", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 82, Name = "Bayburt", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 83, Name = "Bilecik", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 84, Name = "Bingöl", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 85, Name = "Bitlis", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 86, Name = "Bolu", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 87, Name = "Burdur", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 88, Name = "Bursa", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 90, Name = "Çanakkale", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 91, Name = "Çankırı", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 92, Name = "Çorum", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 93, Name = "Denizli", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 94, Name = "Diyarbakır", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },
                  new Province { Id = 95, Name = "Düzce", CountryId = 4, CountryCode = "TUR", CountryName = "Turkey", UserName = "System_Populated" },


                  new Province { Id = 96, Name = "Alborz", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 97, Name = "South Khorasan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 98, Name = "Razavi Khorasan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 99, Name = "North Khorasan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 100, Name = "Golestan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 101, Name = "Mazandaran", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 102, Name = "Semnan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 103, Name = "Esfahan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 104, Name = "Yazd", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 105, Name = "Kerman", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 106, Name = "Sistan-Baluchistan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 107, Name = "Hormozgan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 108, Name = "Fars", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 109, Name = "Bushehr", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 110, Name = "Buyer Ahmad", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 111, Name = "Kohkiluyeh", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 112, Name = "Bakhtiari", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 113, Name = "Chahar Mahaal", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 114, Name = "Khuzestan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 115, Name = "Lorestan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 116, Name = "Ilam", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 128, Name = "Kermanshah", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 117, Name = "Hamadan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 118, Name = "Kurdistan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 119, Name = "West Azarbaijan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 120, Name = "East Azarbaijan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 121, Name = "Zanjan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 122, Name = "Ardabil", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 123, Name = "Gilan", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 124, Name = "Qazvin", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 125, Name = "Markazi", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 126, Name = "Qom", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" },
                  new Province { Id = 127, Name = "Tehran", CountryId = 5, CountryCode = "IR", CountryName = "Iran", UserName = "System_Populated" }
                  );

            builder.Entity<Designation>().HasData(
               new Designation { Id = 1, Name = "Admin", UserName = "System Defined" },
               new Designation { Id = 2, Name = "Cashir", UserName = "System Defined" },
               new Designation { Id = 3, Name = "Feul Attendant", UserName = "System Defined" },
               new Designation { Id = 4, Name = "Mechanic", UserName = "System Defined" },
               new Designation { Id = 5, Name = "Car Wash", UserName = "System Defined" },
               new Designation { Id = 6, Name = "Gaurd", UserName = "System Defined" },
               new Designation { Id = 7, Name = "Pharmacist", UserName = "System Defined" }
               );

            builder.Entity<ExpensesCategory>().HasData(
              new ExpensesCategory { Id = 1, Name = "Rent", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 2, Name = "Electricity", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 3, Name = "Gas", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 4, Name = "Water", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 5, Name = "Air conditioning", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 6, Name = "Trash", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 7, Name = "Cellphones", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 8, Name = "Office supplies", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 9, Name = "Advertising", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 10, Name = "marketing", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 11, Name = "Website", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 12, Name = "Software", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 13, Name = "Entertainment", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 14, Name = "Business meals", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 15, Name = "travel expenses", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 16, Name = "Vehicle expenses", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 17, Name = "Insurance", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 18, Name = "Health Insurance", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 19, Name = "Meals", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 20, Name = "Bank fees", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 21, Name = "Maintenance", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 22, Name = "repairs", UserName = "System Defined", Status = 1, Description = "" },
              new ExpensesCategory { Id = 23, Name = "Printing", UserName = "System Defined", Status = 1, Description = "" }
              );

            //lookup
            builder.Entity<Category>();
            builder.Entity<Unit>();
            builder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            builder.Entity<Province>();
            builder.Entity<ProductType>();
            builder.Entity<Manufacturer>();
            builder.Entity<Shop>();

            builder.Entity<Product>();
            builder.Entity<ProductSupplier>();
            builder.Entity<ProductBatch>();
            builder.Entity<Stock>();
            builder.Entity<StockDetails>();
            builder.Entity<StockLog>();


            builder.Entity<Tax>();
            builder.Entity<ProductTax>();
            builder.Entity<Supplier>();
            builder.Entity<SupplierPayment>();
            builder.Entity<SupplierAdvanced>();
            builder.Entity<Customer>();
            builder.Entity<CustomerReceive>();
            builder.Entity<CustomerAdvanced>();
            builder.Entity<SupplierLedger>();
            builder.Entity<CustomerLedger>();
            builder.Entity<PartnerLedger>();
            builder.Entity<Bank>();
            builder.Entity<CashLedger>();
            builder.Entity<BankLedger>();
            builder.Entity<Transaction>();
            builder.Entity<PartnerInvestment>();
            builder.Entity<PartnerPayment>();


            builder.Entity<Purchase>();
            builder.Entity<PurchaseDetails>();
            builder.Entity<PartnersPurchaseShare>();

            builder.Entity<Sale>();
            builder.Entity<SaleDetails>();

            builder.Entity<Designation>();
            builder.Entity<Employee>().HasIndex(x => x.NationalIdnumber).IsUnique();
            builder.Entity<EmployeeSalary>()
              .HasKey(o => new
              {
                  o.EmployeeId,
                  o.SalaryYear,
                  o.SalaryMonth
              });
            builder.Entity<EmployeeLedger>();

            builder.Entity<Expense>();
            builder.Entity<ExpensesCategory>().HasIndex(x => x.Name).IsUnique();

            builder.Entity<AssetsCategory>().HasIndex(x => x.Name).IsUnique();
            builder.Entity<Asset>().HasIndex(x => x.Name).IsUnique();
            builder.Entity<AssetStock>();
            builder.Entity<AssetHandover>();
            builder.Entity<AssetHandoverDetails>();
            builder.Entity<AssetReturn>();

            //Servicess
            builder.Entity<ServiceCategory>().HasIndex(x => x.Name).IsUnique();
            builder.Entity<Services>();
            builder.Entity<ServiceDetails>();


            //Quote
            builder.Entity<Quote>();
            builder.Entity<QuoteDetails>();

            //Personal Loans
            builder.Entity<Person>();
            builder.Entity<PersonalLoanPayment>();
            builder.Entity<PersonalLoanReceive>();
            builder.Entity<PersonalLoanLedger>();

            //Office Loans
            builder.Entity<OfficePerson>();
            builder.Entity<OfficeLoanPayment>();
            builder.Entity<OfficeLoanReceive>();
            builder.Entity<OfficeLoanLedger>();

            //return
            builder.Entity<Return>();
            builder.Entity<ReturnDetails>();
            builder.Entity<Wastage>();
            builder.Entity<WastageDetails>();

            ConfigureIdentityContext(builder);
        }

        private void ConfigureIdentityContext(ModelBuilder builder)
        {
            builder.Entity<Category>().ToTable(TablesConstants.Category);
            builder.Entity<Unit>().ToTable(TablesConstants.Unit);
            builder.Entity<Country>().ToTable(TablesConstants.Country);
            builder.Entity<Province>().ToTable(TablesConstants.Province);
            builder.Entity<Manufacturer>().ToTable(TablesConstants.Manufacturer);
            builder.Entity<Shop>().ToTable(TablesConstants.Shop);


            //lookup
            builder.Entity<ProductType>().ToTable(TablesConstants.ProductType);
            builder.Entity<ProductTax>().ToTable(TablesConstants.ProductTax);
            builder.Entity<Product>().ToTable(TablesConstants.Product);
            builder.Entity<ProductSupplier>().ToTable(TablesConstants.ProductSupplier);
            builder.Entity<ProductBatch>().ToTable(TablesConstants.ProductBatch);
            builder.Entity<Stock>().ToTable(TablesConstants.Stock);
            builder.Entity<StockDetails>().ToTable(TablesConstants.StockDetails);
            builder.Entity<StockLog>().ToTable(TablesConstants.StockLog);

            builder.Entity<Tax>().ToTable(TablesConstants.Tax);
            builder.Entity<Partner>().ToTable(TablesConstants.Partner);
            builder.Entity<PartnerInvestment>().ToTable(TablesConstants.PartnerInvestment);
            builder.Entity<PartnerPayment>().ToTable(TablesConstants.PartnerPayment);
            builder.Entity<Supplier>().ToTable(TablesConstants.Supplier);
            builder.Entity<SupplierPayment>().ToTable(TablesConstants.SupplierPayment);
            builder.Entity<SupplierAdvanced>().ToTable(TablesConstants.SupplierAdvanced);
            builder.Entity<Customer>().ToTable(TablesConstants.Customer);
            builder.Entity<CustomerReceive>().ToTable(TablesConstants.CustomerReceive);
            builder.Entity<CustomerAdvanced>().ToTable(TablesConstants.CustomerAdvanced);

            builder.Entity<SupplierLedger>().ToTable(TablesConstants.SupplierLedger);
            builder.Entity<CustomerLedger>().ToTable(TablesConstants.CustomerLedger);
            builder.Entity<PartnerLedger>().ToTable(TablesConstants.PartnerLedger);
            builder.Entity<Bank>().ToTable(TablesConstants.Bank);
            builder.Entity<CashLedger>().ToTable(TablesConstants.CashLedger);
            builder.Entity<BankLedger>().ToTable(TablesConstants.BankLedger);
            builder.Entity<Transaction>().ToTable(TablesConstants.Transaction);
            builder.Entity<BankTransaction>().ToTable(TablesConstants.BankTransaction);
            builder.Entity<Purchase>().ToTable(TablesConstants.Purchase);
            builder.Entity<PurchaseDetails>().ToTable(TablesConstants.PurchaseDetails);
            builder.Entity<PartnersPurchaseShare>().ToTable(TablesConstants.PartnersPurchaseShare);

            //Sales 
            builder.Entity<Sale>().ToTable(TablesConstants.Sale);
            builder.Entity<SaleDetails>().ToTable(TablesConstants.SaleDetails);

            //Expense
            builder.Entity<Expense>().ToTable(TablesConstants.Expense);
            builder.Entity<ExpensesCategory>().ToTable(TablesConstants.ExpenseCategory);

            //HRM
            builder.Entity<Designation>().ToTable(TablesConstants.Designation);
            builder.Entity<Employee>().ToTable(TablesConstants.Employee);
            builder.Entity<EmployeeSalary>().ToTable(TablesConstants.EmployeeSalary);
            builder.Entity<EmployeeLedger>().ToTable(TablesConstants.EmployeeLedger);

            builder.Entity<AssetsCategory>().ToTable(TablesConstants.AssetsCategory);
            builder.Entity<Asset>().ToTable(TablesConstants.Asset);
            builder.Entity<AssetStock>().ToTable(TablesConstants.AssetStock);
            builder.Entity<AssetHandover>().ToTable(TablesConstants.AssetHandover);
            builder.Entity<AssetHandoverDetails>().ToTable(TablesConstants.AssetHandoverDetails);
            builder.Entity<AssetReturn>().ToTable(TablesConstants.AssetReturn);

            //services
            builder.Entity<ServiceCategory>().ToTable(TablesConstants.ServiceCategory);
            builder.Entity<Services>().ToTable(TablesConstants.Service);
            builder.Entity<ServiceDetails>().ToTable(TablesConstants.ServiceDetails);

            builder.Entity<Quote>().ToTable(TablesConstants.Quote);
            builder.Entity<QuoteDetails>().ToTable(TablesConstants.QuoteDetails);

            //Personal Loans
            builder.Entity<Person>().ToTable(TablesConstants.Person);
            builder.Entity<PersonalLoanPayment>().ToTable(TablesConstants.PersonalLoanPayment);
            builder.Entity<PersonalLoanReceive>().ToTable(TablesConstants.PersonalLoanReceive);
            builder.Entity<PersonalLoanLedger>().ToTable(TablesConstants.PersonalLoanLedger);

            //Office Loans
            builder.Entity<OfficePerson>().ToTable(TablesConstants.OfficePerson);
            builder.Entity<OfficeLoanPayment>().ToTable(TablesConstants.OfficeLoanPayment);
            builder.Entity<OfficeLoanReceive>().ToTable(TablesConstants.OfficeLoanReceive);
            builder.Entity<OfficeLoanLedger>().ToTable(TablesConstants.OfficeLoanLedger);
            builder.Entity<Saraf>().ToTable(TablesConstants.Saraf);
            builder.Entity<SarafLedger>().ToTable(TablesConstants.SarafLedger);
            builder.Entity<SarafTransaction>().ToTable(TablesConstants.SarafTransaction);

            //Return
            builder.Entity<Return>().ToTable(TablesConstants.Return);
            builder.Entity<ReturnDetails>().ToTable(TablesConstants.ReturnDetails);
            builder.Entity<Wastage>().ToTable(TablesConstants.Wastage);
            builder.Entity<WastageDetails>().ToTable(TablesConstants.WastageDetails);

        }
    }
}