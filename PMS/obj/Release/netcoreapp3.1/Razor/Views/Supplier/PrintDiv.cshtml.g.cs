#pragma checksum "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8242fe951a350b2defcedd5e7b86e640502847"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_PrintDiv), @"mvc.1.0.view", @"/Views/Supplier/PrintDiv.cshtml")]
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
#line 1 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Lookup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Purchase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Sale;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.FixedAsset;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.ProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.PurchaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.SaleViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Stock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.StockViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Finance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Asset;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Quote;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.QuoteViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.OfficeLoan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.OfficeLoanViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Models.PersonalLoan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.PersonalLoanViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.ReturnViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.ViewModels.Wastages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8242fe951a350b2defcedd5e7b86e640502847", @"/Views/Supplier/PrintDiv.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c988150c4fa84b28b6ef034ddc763942ed574f", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_PrintDiv : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SupplierLedgerViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Supplier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-mat btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
  
    ViewData["Title"] = "Suppliers Ledger";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style id=""table_style"" type=""text/css"">
    body {
        font-family: Arial;
        font-size: 10pt;
    }

    table {
        border: 1px solid #ccc;
        border-collapse: collapse;
    }

        table th {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }

        table th, table td {
            padding: 5px;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            border: 1px solid #ccc;
        }
</style>

<!-- Main-body start -->
<div class=""main-body"">
    <div class=""page-wrapper"">

        <div class=""row"">
            <div class=""col-lg-10 col-md-12 col-sm-12"" style=""margin:0 auto;"">
                <!-- Page-header start-->
                <div class=""page-header card"">
                    <div class=""card-block"">
                        <h5 class=""m-b-10"">Suppliers Administration</h5>
                        <ul class=""breadcrumb-title b-t-default p-t-10"">
               ");
            WriteLiteral("             <li class=\"breadcrumb-item pull-right\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8242fe951a350b2defcedd5e7b86e64050284711503", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-user-plus\"></i> Add New Supplier\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8242fe951a350b2defcedd5e7b86e64050284713187", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-list\"></i> Suppliers List\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </li>
                        </ul>
                    </div>
                </div>

                <!-- Page-header end -->
                <!-- Page-body start -->
                <div class=""page-body "">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h5>Supplier Ledger Print</h5>
                            <div class=""card-header-right"">
                                <ul class=""list-unstyled card-option"">
                                    <li><i class=""fa fa-chevron-left""></i></li>
                                    <li><i class=""fa fa-window-maximize full-card""></i></li>
                                    <li><i class=""fa fa-minus minimize-card""></i></li>
                                    <li><i class=""fa fa-refresh reload-card""></i></li>
                                    <li><i class=""fa fa-times close-card""></i></li>
                                </ul>
                 ");
            WriteLiteral("           </div>\r\n                        </div>\r\n\r\n                        <div class=\"card-block table-border-style\" id=\"dvContents\">\r\n                            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 76 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                 if (Model.Any())
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                     foreach (var m in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                                            <div class=""d-flex flex-column flex-root"">
                                                <h3> <span class=""font-weight-bolder mb-2""> <b> Supplier : </b>");
#nullable restore
#line 82 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                                                                          Write(m.EntityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span></h3>
                                                <span class=""opacity-60"" style=""font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size:large"">
                                                    / ");
#nullable restore
#line 84 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                 Write(m.EntityPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / &nbsp; ");
#nullable restore
#line 84 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                                         Write(m.EntityAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                                </span>\r\n                                            </div>\r\n                                            <hr />\r\n                                        </div>\r\n");
#nullable restore
#line 89 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                        break;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                                    <div class=\"d-flex flex-column flex-root\">\r\n                                        <span class=\"font-weight-bolder mb-2\"><h3>");
#nullable restore
#line 95 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                                             Write(ViewBag.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3></span>
                                        <span class=""opacity-60"" style=""font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size:large"">
                                            ");
#nullable restore
#line 97 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                       Write(ViewBag.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 97 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                        Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                            ");
#nullable restore
#line 98 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                       Write(ViewBag.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </span>
                                    </div>
                                    <hr />
                                </div>

                            </div>
                            <div class=""row"">
                                <div class=""col-12"">
                                    <div class=""table-responsive"">
                                        <table id=""table_style"" class=""table table-bordered table-hover"">
                                            <thead>
                                                <tr>
                                                    <th>SNo</th>
                                                    <th>Date</th>
                                                    <th>Description</th>
                                                    <th>Debit</th>
                                                    <th>Credit</th>
                                                    <th>Balance</th>
          ");
            WriteLiteral("                                      </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 120 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                  
                                                    decimal totalDebit = 0;
                                                    decimal totalCredit = 0;
                                                    decimal totalBalance = 0;
                                                    string balanceFlg = "+";
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                 if (Model.Any())
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                     foreach (var m in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
#nullable restore
#line 131 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                           Write(m.SNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td style=\"width:10%; word-wrap: break-word\">");
#nullable restore
#line 132 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                                                                    Write(m.Date.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td style=\"width:45%; word-wrap: break-word\">");
#nullable restore
#line 133 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                                                                    Write(m.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 134 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                           Write(m.Debit.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 135 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                           Write(m.Credit.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>\r\n                                                                ");
#nullable restore
#line 137 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                           Write(m.Balance.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                <span class=\"d-none\">\r\n");
#nullable restore
#line 139 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                                      
                                                                        totalDebit += m.Debit;
                                                                        totalCredit += m.Credit;
                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                </span>\r\n                                                            </td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 146 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                     
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                            <tfoot>
                                                <tr style=""background-color: lightgray;"">
                                                    <td></td>
                                                    <td></td>
                                                    <td style=""text-align:right"">Total</td>
                                                    <td><b>");
#nullable restore
#line 154 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                      Write(totalDebit.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                                    <td><b>");
#nullable restore
#line 155 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                      Write(totalCredit.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                                    <td>\r\n                                                        <span class=\"d-none\">\r\n");
#nullable restore
#line 158 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                              
                                                                totalBalance = totalDebit - totalCredit;
                                                                if (totalBalance < 0)
                                                                {
                                                                    balanceFlg = "-";
                                                                }
                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </span>\r\n                                                        ");
#nullable restore
#line 166 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Supplier\PrintDiv.cshtml"
                                                   Write(totalBalance.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </td>
                                                </tr>
                                            </tfoot>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""col-12 text text-right"">
                            <button type=""button"" class=""btn btn-info"" onclick=""PrintTable();"" style=""padding:8px"" value='Print'>Print</button>
                        </div>
                    </div>
                    <!-- Basic table card end -->
                </div>
                <!-- Page-body end -->
                <div class=""page-header card"">
                    <div class=""card-block"">
                        <ul");
            BeginWriteAttribute("class", " class=\"", 10381, "\"", 10389, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <li class=""breadcrumb-item pull-left"">
                                <a onclick=""window.history.back();""
                                   class=""text text-danger font-weight-bold"" style=""cursor: pointer;"">
                                    <i class=""fa fa-arrow-left""></i> Back
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        function PrintTable() {
            var printWindow = window.open();
            printWindow.document.write('<html><head><title>Table Contents</title>');

            //Print the Table CSS.
            var table_style = document.getElementById(""table_style"").innerHTML;
            printWindow.document.write('<style type = ""text/css"">');
            printWindow.document.write(table_style);
            printWindow.document.write('</style>');
            printWindow.document.write('</head>');

            //Print the DIV contents i.e. the HTML Table.
            printWindow.document.write('<body>');
            var divContents = document.getElementById(""dvContents"").innerHTML;
            printWindow.document.write(divContents);
            printWindow.document.write('</body>');

            printWindow.document.write('</html>');
            printWindow.document.close();
            printWindow.print();
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SupplierLedgerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
