#pragma checksum "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1ba19fdaeb23f72e522770fc0f2293b60b82808"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quote_PrintDiv), @"mvc.1.0.view", @"/Views/Quote/PrintDiv.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ba19fdaeb23f72e522770fc0f2293b60b82808", @"/Views/Quote/PrintDiv.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c988150c4fa84b28b6ef034ddc763942ed574f", @"/Views/_ViewImports.cshtml")]
    public class Views_Quote_PrintDiv : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewQuoteDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Qoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-mat btn-primary mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
  
    ViewData["Title"] = "Qoutation";

    var Quote = Model.Quote;
    var QouteDetails = Model.QuoteDetails;
    var shopDetails = Model.ShopModelDetails;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main-body start -->
<div class=""main-body"">
    <div class=""page-wrapper"">

        <div class=""row"">
            <div class=""col-lg-10 col-md-12 col-sm-12"" style=""margin:0 auto;"">
                <!-- Page-header start-->
                <div class=""page-header card"">
                    <div class=""card-block"">
                        <h5 class=""m-b-10"">Services Administration</h5>
                        <ul class=""breadcrumb-title b-t-default p-t-10"">

                            <li class=""breadcrumb-item pull-right"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1ba19fdaeb23f72e522770fc0f2293b60b8280811029", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-list\"></i> Qoute List\r\n                                ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1ba19fdaeb23f72e522770fc0f2293b60b8280812702", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-shopping-cart\"></i> Add New Qoute\r\n                                ");
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

                <div class=""page-body PrintArea"">

                    <div class=""card"">
                        <div class=""card-header"">
                            <h5>Print Invoice</h5>
                            <div class=""card-header-right"">
                                <ul class=""list-unstyled card-option"">
                                    <li><i class=""fa fa-chevron-left""></i></li>
                                    <li><i class=""fa fa-window-maximize full-card""></i></li>
                                    <li><i class=""fa fa-minus minimize-card""></i></li>
                                    <li><i class=""fa fa-refresh reload-card""></i></li>
                                    <li><i class=""fa fa-times close-card""></i></li>
                                </ul>
          ");
            WriteLiteral(@"                  </div>
                        </div>

                        <div class=""card-block table-border-style"" id=""DivIdToPrint"">

                            <div class=""row"">
                                <div class=""col-lg-6 col-md-6 col-sm-6"">
                                    <div class=""d-flex flex-column flex-root"">
                                        <h3 class=""display-5 font-weight-bolder mb-2""> INVOICE - # ");
#nullable restore
#line 63 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                                                              Write(Quote.InvoiceNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <span class=\"font-weight-bolder mb-2\"> <b> Date : </b>");
#nullable restore
#line 64 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                                                         Write(Quote.QuoteDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"opacity-60\">\r\n                                            <b>Customer:</b> ");
#nullable restore
#line 66 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                        Write(Quote.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / &nbsp; ");
#nullable restore
#line 66 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                                                   Write(Quote.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br />
                                        </span>
                                    </div>
                                    <hr />
                                </div>

                                <div class=""col-lg-6 col-md-6 col-sm-6"">
                                    <div class=""d-flex flex-column flex-root"">
                                        <span class=""font-weight-bolder mb-2""><h3>");
#nullable restore
#line 74 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                                             Write(shopDetails.Name_en);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3></span>
                                        <span class=""opacity-60"" style=""font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size:large"">
                                            ");
#nullable restore
#line 76 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                       Write(shopDetails.Phone1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 76 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                             Write(shopDetails.Email1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                            ");
#nullable restore
#line 77 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                       Write(shopDetails.Address_en);

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
                                        <table class=""table table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th>SNo.</th>
                                                    <th>Product</th>
                                                    <th>Batch</th>
                                                    <th>Qty</th>
                                                    <th>Unit Price</th>
                                                    <th>Discount</th>
                                        ");
            WriteLiteral("            <th>Total Price</th>\r\n                                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 99 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                 if (QouteDetails.Any())
                                                {
                                                    foreach (var m in QouteDetails)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
#nullable restore
#line 104 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                           Write(m.Sno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 105 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                           Write(m.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 106 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                           Write(m.BatchId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 107 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                           Write(m.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 108 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                           Write(m.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>\r\n");
#nullable restore
#line 110 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                                   var res = (100 * m.Discount) / (m.Discount + m.TotalQuotePrice); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
#nullable restore
#line 111 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                           Write(m.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>");
#nullable restore
#line 113 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                           Write(m.TotalQuotePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 115 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </tbody>
                                            <tbody>
                                                <tr>
                                                    <td colspan=""6"" class=""text text-right"">Sub Total</td>
                                                    <td>
                                                        ");
#nullable restore
#line 123 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                   Write(Quote.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </td>
                                                </tr>

                                                <tr>
                                                    <td colspan=""6"" class=""text text-right"">Tax</td>
                                                    <td>
                                                        ");
#nullable restore
#line 130 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                   Write(Quote.TaxAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </td>

                                                </tr>

                                                <tr>
                                                    <td colspan=""6"" class=""text text-right"">Total Discount (%)</td>
                                                    <td>
                                                        ");
#nullable restore
#line 138 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                   Write(Quote.DiscountAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </td>

                                                </tr>

                                                <tr>
                                                    <td colspan=""6"" class=""text text-right"">Grand Total</td>
                                                    <td>
                                                        ");
#nullable restore
#line 146 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                   Write(Quote.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td colspan=""6"" class=""text text-right"">Paid Amount</td>
                                                    <td>
                                                        ");
#nullable restore
#line 153 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                   Write(Quote.PaidAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td colspan=""6"" class=""text text-right"">Due Amount</td>
                                                    <td>
                                                        ");
#nullable restore
#line 160 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Quote\PrintDiv.cshtml"
                                                   Write(Quote.DueAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""col-12 text text-right"">
                            <button type=""button"" class=""btn btn-info"" style=""padding:8px"" value='Print' onclick='printtag(""DivIdToPrint"");'>Print</button>
                        </div>
                    </div>
                    <!-- Basic table card end -->
                </div>
                <!-- Page-body end -->

                <div class=""page-header card"">
                    <div class=""card-block"">
                        <ul");
            BeginWriteAttribute("class", " class=\"", 9886, "\"", 9894, 0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewQuoteDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
