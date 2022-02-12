using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using NToastNotify;
using PMS.Data;
using PMS.Models;
using PMS.Repositories;
using PMS.Repositories.IRepositories;
using PMS.Repositories.IRepositories.Settings;
using PMS.Repositories.Settings;
using PMS.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Local Connection
            services.AddDbContext<ApplicationDbContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("LocalConnectionString"))); //Remote ConnectoinString Name: RemoteConnectString / Local ConnectionString Name: LocalConnectionString

            //services.AddScoped<ITestRepository, TestRespository>();
            services.AddScoped<PMSHelper, PMSHelper>();
            services.AddScoped<ITaxRepository, TaxRepository>();
            services.AddScoped<IDashboardRepository, DashboardRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<IHelperRepository, HelperRepository>();
            services.AddScoped<IPartnerRepository, PartnerRepository>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IStockRepository, StockRepository>();

            services.AddScoped<ITransactionRepository, TransactionRepository>();

            services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();

            services.AddScoped<IShopRepository, ShopRepository>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IFixedAssetRepository, FixedAssetRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();

            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IQuoteReposoitory, QuoteRepository>();

            services.AddScoped<IPersonalLoanRepository, PersonalLoanRepository>();
            services.AddScoped<IOfficeLoanRepository, OfficeLoanRepository>();

            services.AddScoped<IReturnRepository, ReturnRepository>();
            services.AddScoped<IWastageRepository, WastageRepository>();
            services.AddScoped<ISarafRepository, SarafRepository>();

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                  .RequireAuthenticatedUser()
                  .Build();
            });

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.  
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 1;
                //options.Password.RequiredUniqueChars = 1;

                // Lockout settings.  
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.  
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+#";
                options.User.RequireUniqueEmail = true;
            });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions()
            {
                Path = "/",
                HttpOnly = false,
                IsEssential = true, //<- there
                Expires = DateTime.Now.AddMinutes(2),
            };
            //middel ware confi guration for cultures 

            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });

            services.AddMvc().AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix,
                opt => { opt.ResourcesPath = "Resources"; }).AddDataAnnotationsLocalization();

            services.Configure<RequestLocalizationOptions>(
                opt =>
                {
                    var SupportedCultures = new List<CultureInfo>
                        {
                            new CultureInfo("en"),
                            new CultureInfo("ps"),
                            new CultureInfo("da")
                        };

                    opt.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en");

                    opt.SupportedCultures = SupportedCultures;

                    opt.SupportedUICultures = SupportedCultures;
                });

            services.AddMvc().AddXmlSerializerFormatters();

            services.AddMvc(o =>
            {
                var policy = new AuthorizationPolicyBuilder()

                    .RequireAuthenticatedUser()

                    .Build();
                o.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc().AddNToastNotifyToastr(new ToastrOptions()
            {
                ProgressBar = true,

                PositionClass = ToastPositions.TopCenter
            });
            services.AddDistributedMemoryCache();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //add this , ApplicationDbContext db in folling function to create database
        // db.Database.EnsureCreated(); this iut of functions
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            ///db.Database.EnsureCreated();
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSession();

            app.UseStatusCodePages();

            app.UseNToastNotify();

            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Dashboard}/{action=index}/{id?}");
                endpoints.MapDefaultControllerRoute().RequireAuthorization();
                endpoints.MapRazorPages();
            });
        }
    }
}
