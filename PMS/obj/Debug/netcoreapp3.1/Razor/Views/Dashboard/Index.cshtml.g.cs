#pragma checksum "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8fd585022fb967e3dca5c53db0780563d4335c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Lookup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Purchase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Sale;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.FixedAsset;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.ProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.PurchaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.SaleViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Stock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.StockViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Finance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Asset;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Quote;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.QuoteViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.OfficeLoan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.OfficeLoanViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.PersonalLoan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.PersonalLoanViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.ReturnViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Wastages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8fd585022fb967e3dca5c53db0780563d4335c7", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c988150c4fa84b28b6ef034ddc763942ed574f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = localizer["Dashboard"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-body"">

    <div class=""page-wrapper"">
        <div class=""page-body"">
            <div class=""row"">
                <!-- order-card start -->

                <div class=""col-md-6 col-xl-2"">
                    <div class=""card bg-c-blue order-card"">
                        <div class=""card-block"">
                            <h6 class=""m-b-20"">");
#nullable restore
#line 18 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                          Write(localizer["Purchase Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <h2 class=\"text-right\"><i class=\"ti-shopping-cart f-left\"></i><span>");
#nullable restore
#line 19 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                           Write(ViewBag.TotalPurchase.ToString(@ViewBag.TotalPurchase % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            <p class=\"m-b-0\">");
#nullable restore
#line 20 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                        Write(localizer["This Month"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"f-right\">");
#nullable restore
#line 20 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                      Write(ViewBag.TotalPurchasePerMonth.ToString(@ViewBag.TotalPurchasePerMonth % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                            <p class=\"m-b-0\">");
#nullable restore
#line 21 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                        Write(localizer["Purchased In Kg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"f-right\">");
#nullable restore
#line 21 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                           Write(ViewBag.PurchaseQty.ToString(@ViewBag.PurchaseQty % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-xl-2"">
                    <div class=""card bg-c-green order-card"">
                        <div class=""card-block"">
                            <h6 class=""m-b-20"">");
#nullable restore
#line 29 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                          Write(localizer["Sales Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <h2 class=\"text-right\"><i class=\"ti-tag f-left\"></i><span>");
#nullable restore
#line 30 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                 Write(ViewBag.TotalSale.ToString(@ViewBag.TotalSale % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            <p class=\"m-b-0\">");
#nullable restore
#line 31 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                        Write(localizer["This Month"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"f-right\">");
#nullable restore
#line 31 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                      Write(ViewBag.TotalSalePerMonth.ToString(@ViewBag.TotalSalePerMonth % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                            <p class=\"m-b-0\">");
#nullable restore
#line 32 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                        Write(localizer["Saled In Kg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"f-right\">");
#nullable restore
#line 32 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                       Write(ViewBag.SaleQty.ToString(@ViewBag.SaleQty % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                        </div>
                    </div>
                </div>


                <div class=""col-md-6 col-xl-2"">
                    <div class=""card bg-c-yellow order-card"">
                        <div class=""card-block"">
                            <h6 class=""m-b-20"">");
#nullable restore
#line 41 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                          Write(localizer["Revenue Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <h2 class=\"text-right\"><i class=\"ti-reload f-left\"></i><span>");
#nullable restore
#line 42 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                    Write(ViewBag.SaleRevenue.ToString(@ViewBag.SaleRevenue % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            <p class=\"m-b-20\">");
#nullable restore
#line 43 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                         Write(localizer["This Month"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"f-right\">");
#nullable restore
#line 43 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                       Write(ViewBag.SaleRevenuePerMonth.ToString(@ViewBag.SaleRevenuePerMonth % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                        </div>
                    </div>
                </div>


                <div class=""col-md-6 col-xl-2"">
                    <div class=""card bg-c-pink order-card"">
                        <div class=""card-block"">
                            <h6 class=""m-b-20"">");
#nullable restore
#line 52 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                          Write(localizer["Expense Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <h2 class=\"text-right\"><i class=\"ti-wallet f-left\"></i><span>");
#nullable restore
#line 53 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                    Write(ViewBag.TotalExpenses.ToString(@ViewBag.TotalExpenses % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            <p class=\"m-b-20\">");
#nullable restore
#line 54 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                         Write(localizer["This Month"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"f-right\">");
#nullable restore
#line 54 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                       Write(ViewBag.TotalExpensesMonth.ToString(@ViewBag.TotalExpensesMonth % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-xl-2"">
                    <div class=""card bg-c-orenge order-card"">
                        <div class=""card-block"">
                            <h6 class=""m-b-20"">");
#nullable restore
#line 62 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                          Write(localizer["Profit Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <h2 class=\"text-right\"><i class=\"fa fa-money f-left\"></i><span>");
#nullable restore
#line 63 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                      Write(ViewBag.TotalProfit.ToString(@ViewBag.TotalProfit % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            <p class=\"m-b-20\">");
#nullable restore
#line 64 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                         Write(localizer["This Month"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"f-right\">");
#nullable restore
#line 64 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                       Write(ViewBag.TotalProfitPerMonth.ToString(@ViewBag.TotalProfitPerMonth % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>

                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-xl-2"">
                    <div class=""card bg-c-blue order-card"">
                        <div class=""card-block"">
                            <h6 class=""m-b-20"">");
#nullable restore
#line 73 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                          Write(localizer["Produts"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <h2 class=\"text-right\"><i class=\"ti-wallet f-left\"></i><span>");
#nullable restore
#line 74 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                    Write(ViewBag.TotalProducts.ToString(@ViewBag.TotalProducts % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            <p class=\"m-b-20\">");
#nullable restore
#line 75 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                         Write(localizer["This Month"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"f-right\">");
#nullable restore
#line 75 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                                                                                       Write(ViewBag.TotalProductMonth.ToString(@ViewBag.TotalProductMonth % 1 == 0 ? "N0" : "N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                        </div>
                    </div>
                    <!--end::Nav-->
                </div>

                <div class=""col-lg-8 col-md-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h5>Statistics</h5>
                            <div class=""card-header-right"">
                                <ul class=""list-unstyled card-option"">
                                    <li><i class=""fa fa-chevron-left""></i></li>
                                    <li><i class=""fa fa-window-maximize full-card""></i></li>
                                    <li><i class=""fa fa-minus minimize-card""></i></li>
                                    <li><i class=""fa fa-refresh reload-card""></i></li>
                                    <li><i class=""fa fa-times close-card""></i></li>
                                </ul>
                            </div>
                        </div>
                      ");
            WriteLiteral(@"  <div class=""card-block"">
                            <canvas id=""Statistics-chart"" height=""250""></canvas>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h5>Customer Feedback</h5>
                        </div>
                        <div class=""card-block"">
                            <iframe class=""chartjs-hidden-iframe"" tabindex=""-1"" style=""display: block; overflow: hidden; border: 0px; margin: 0px; inset: 0px; height: 100%; width: 100%; position: absolute; pointer-events: none; z-index: -1;""></iframe><iframe class=""chartjs-hidden-iframe"" tabindex=""-1"" style=""display: block; overflow: hidden; border: 0px; margin: 0px; inset: 0px; height: 100%; width: 100%; position: absolute; pointer-events: none; z-index: -1;""></iframe>
                            <span class=""d-block text-c-blue f-24 f-w-600");
            WriteLiteral(@" text-center"">365247</span>
                            <canvas id=""feedback-chart"" height=""267"" width=""810"" style=""display: block; height: 89px; width: 270px;""></canvas>
                            <div class=""row justify-content-center m-t-15"">
                                <div class=""col-auto b-r-default m-t-5 m-b-5"">
                                    <h4>83%</h4>
                                    <p class=""text-success m-b-0""><i class=""ti-hand-point-up m-r-5""></i>Positive</p>
                                </div>
                                <div class=""col-auto m-t-5 m-b-5"">
                                    <h4>17%</h4>
                                    <p class=""text-danger m-b-0""><i class=""ti-hand-point-down m-r-5""></i>Negative</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- tabs card start -->
                <div class=""col-sm-12"">
      ");
            WriteLiteral(@"              <div class=""card tabs-card"">
                        <div class=""card-block p-0"">
                            <!-- Nav tabs -->
                            <ul class=""nav nav-tabs md-tabs"" role=""tablist"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" data-toggle=""tab"" href=""#home3"" role=""tab""><i class=""fa fa-shopping-cart""></i>Sale</a>
                                    <div class=""slide""></div>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" data-toggle=""tab"" href=""#purchase"" role=""tab""><i class=""fa fa-edge""></i>Purchase</a>
                                    <div class=""slide""></div>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" data-toggle=""tab"" href=""#Expenses"" role=""tab""><i class=""fa fa-credit-card""></i>Expe");
            WriteLiteral(@"nse</a>
                                    <div class=""slide""></div>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" data-toggle=""tab"" href=""#stock"" role=""tab""><i class=""fa fa-database""></i>Stock</a>
                                    <div class=""slide""></div>
                                </li>
                            </ul>

                            <!-- Tab panes -->
                            <div class=""tab-content card-block"">
                                <div class=""tab-pane active"" id=""home3"" role=""tabpanel"">

                                </div>
                                <div class=""tab-pane"" id=""purchase"" role=""tabpanel"">

                                </div>
                                <div class=""tab-pane"" id=""Expenses"" role=""tabpanel"">

                                </div>
                                <div class=""tab-pane"" id=""stock"" role=""tabpan");
            WriteLiteral(@"el"">

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- tabs card end -->
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function (){\r\n            $.ajax({\r\n                    cache: false,\r\n                    url: \'");
#nullable restore
#line 176 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                     Write(Url.Action("Sale", "Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    dataType: ""html"",

                    type: ""GET"",
                    contentType: ""application/json"",
                    success: function (response) {
                        $('#home3').append(response);
                    },
                    error: function (err) {
                        alert(err.responseText);
                    }
             });

            $.ajax({
                    cache: false,
                    url: '");
#nullable restore
#line 191 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                     Write(Url.Action("Purchase", "Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    dataType: ""html"",
                    type: ""GET"",
                    contentType: ""application/json"",
                    success: function (response) {
                        $('#purchase').append(response);
                    },
                    error: function (err) {
                        alert(err.responseText);
                    }
            });

            $.ajax({
                        cache: false,
                        url: '");
#nullable restore
#line 205 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                         Write(Url.Action("Expenses", "Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataType: ""html"",
                        type: ""GET"",
                        contentType: ""application/json"",
                        success: function (response) {
                            $('#Expenses').append(response);
                        },
                        error: function (err) {
                            alert(err.responseText);
                        }
              });

            $.ajax({
                        cache: false,
                        url: '");
#nullable restore
#line 219 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                         Write(Url.Action("Stock", "Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataType: ""html"",
                        type: ""GET"",
                        contentType: ""application/json"",
                        success: function (response) {
                            $('#stock').append(response);
                        },
                        error: function (err) {
                            alert(err.responseText);
                        }
              });
        });
             $.ajax({
                    cache: false,
                    url: '");
#nullable restore
#line 233 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Dashboard\Index.cshtml"
                     Write(Url.Action("TotalSalesPerMonth", "Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    dataType: ""html"",
                    type: ""GET"",
                    contentType: ""application/json"",
                    success: function (response) {
                        $('#TotalProjectsPerYear').html(response);
                    },
                    error: function (err) {
                        alert(err.responseText);
                    }
            });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
