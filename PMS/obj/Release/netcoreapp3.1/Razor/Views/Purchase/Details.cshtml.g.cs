#pragma checksum "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8f1ecf3280c8d06a5f69d5941ba6c226dd83c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_Details), @"mvc.1.0.view", @"/Views/Purchase/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8f1ecf3280c8d06a5f69d5941ba6c226dd83c4", @"/Views/Purchase/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c988150c4fa84b28b6ef034ddc763942ed574f", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewPurchaseDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-mat btn-primary mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Modal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/popupModel.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
  
    ViewData["Title"] = "Purchases";

    var Purchase = Model.purchase;
    var PurchaseDetails = Model.purchaseDetails;

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
                        <h5 class=""m-b-10"">Purchases Administration</h5>
                        <ul class=""breadcrumb-title b-t-default p-t-10"">
                            <li class=""breadcrumb-item pull-right"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8f1ecf3280c8d06a5f69d5941ba6c226dd83c412036", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-list\"></i> Purchases List\r\n                                ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8f1ecf3280c8d06a5f69d5941ba6c226dd83c413713", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-shopping-cart\"></i> Add New Purchase\r\n                                ");
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

                <div class=""page-body"">

                    <div class=""card"">
                        <div class=""card-header"">
                            <h5>Purchase Details</h5>
                            <div class=""card-header-right"">
                                <ul class=""list-unstyled card-option"">
                                    <li><i class=""fa fa-chevron-left""></i></li>
                                    <li><i class=""fa fa-window-maximize full-card""></i></li>
                                    <li><i class=""fa fa-minus minimize-card""></i></li>
                                    <li><i class=""fa fa-refresh reload-card""></i></li>
                                    <li><i class=""fa fa-times close-card""></i></li>
                                </ul>
                   ");
            WriteLiteral(@"         </div>
                        </div>

                        <div class=""card-block table-border-style"">
                            <div class=""row"">
                                <div class=""col-12"">
                                    <h6>General Info</h6>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-3 col-sm-6"">
                                    <h6>Purchase No.</h6>
                                    <p>");
#nullable restore
#line 64 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>
                                <div class=""col-lg-3 col-md-3 col-sm-6"">
                                    <h6>Purchase Date</h6>
                                    <p>");
#nullable restore
#line 69 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.PurchaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>
                                <div class=""col-lg-3 col-md-3 col-sm-6"">
                                    <h6>Invoice No.</h6>
                                    <p>");
#nullable restore
#line 74 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.InvoiceNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>
                                <div class=""col-lg-3 col-md-3 col-sm-6"">
                                    <h6>Supplier Name</h6>
                                    <p>");
#nullable restore
#line 79 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.SupplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>
                                <div class=""col-lg-12 col-md-12 col-sm-12"">
                                    <h6>Description</h6>
                                    <p>");
#nullable restore
#line 84 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-12"">
                                    <h6>Items</h6>
                                    <hr />
                                </div>

                                <div class=""col-12"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th>SNo.</th>
                                                    <th>Product</th>
                                                    <th>Unit</th>
                                                    <th>Unit Price</th>
                                                    <th>Qty</th>
                                                    <th>Total Price</th>
                ");
            WriteLiteral("                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 107 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                 if (PurchaseDetails.Any())
                                                {
                                                    foreach (var m in PurchaseDetails)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
#nullable restore
#line 112 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                           Write(m.Sno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 113 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                           Write(m.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 114 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                           Write(m.Unit.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 115 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                           Write(m.PurchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 116 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                           Write(m.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 117 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                           Write(m.TotalPurchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 119 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                    }
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <tr>
                                                        <td colspan=""7"">
                                                            <span class=""text text-info"">No item available in this purchase!</span>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 128 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                    <hr />
                                </div>

                                <div class=""col-12"">
                                    <h6>Payment Details</h6>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6"">
                                    <h6>Payment Type</h6>
                                    <p>
");
#nullable restore
#line 143 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                         if (Purchase.PaymentType == 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge badge-info\">Cash</span>\r\n");
#nullable restore
#line 146 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge badge-info\">Bank</span>\r\n");
#nullable restore
#line 150 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </p>\r\n                                    <hr />\r\n                                </div>\r\n\r\n");
#nullable restore
#line 155 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                 if (Purchase.PaymentType == 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n                                        <h6>Bank Name</h6>\r\n                                        <p>");
#nullable restore
#line 159 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                      Write(Purchase.BankName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <hr />\r\n                                    </div>\r\n");
#nullable restore
#line 162 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n                                    <h6>Total Purchase</h6>\r\n                                    <p>");
#nullable restore
#line 166 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.SubTotal.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6"">
                                    <h6>Discount</h6>
                                    <p>
");
#nullable restore
#line 173 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                           var disc_per = (100 * Purchase.DiscountAmount) / Purchase.SubTotal; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
#nullable restore
#line 174 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                   Write(Purchase.DiscountAmount.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 174 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                                                           Write(disc_per);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" %)
                                    </p>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6"">
                                    <h6>Rent</h6>
                                    <p>");
#nullable restore
#line 181 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.RentAmount.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <hr />\r\n                                </div>\r\n\r\n                                <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n                                    <h6>Tax</h6>\r\n                                    <p>");
#nullable restore
#line 187 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.TaxAmount.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6  text text-primary"">
                                    <h6>Total Amount</h6>
                                    <p>");
#nullable restore
#line 193 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.TotalAmount.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6 text text-success"">
                                    <h6>Paid Amount</h6>
                                    <p>");
#nullable restore
#line 199 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.PaidAmount.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6 text text-warning"">
                                    <h6>Due Amount</h6>
                                    <p>");
#nullable restore
#line 205 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.DueAmount.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-12"">
                                    <h6>System Info</h6>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6"">
                                    <h6>Purchase Performed By</h6>
                                    <p>");
#nullable restore
#line 216 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6"">
                                    <h6>Created At</h6>
                                    <p>");
#nullable restore
#line 222 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-lg-3 col-md-4 col-sm-6"">
                                    <h6>Update At</h6>
                                    <p>");
#nullable restore
#line 228 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
                                  Write(Purchase.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                </div>

                                <div class=""col-12"">
                                    <br />
                                </div>

                                <div class=""col-12 text text-right"">
                                    <a class=""btn btn-info text-white"">
                                        <i class=""fa fa-print""></i> Print
                                    </a>
                                </div>

                            </div>

                        </div>
                    </div>
                    <!-- Basic table card end -->
                </div>
                <!-- Page-body end -->

                <div class=""page-header card"">
                    <div class=""card-block"">
                        <ul");
            BeginWriteAttribute("class", " class=\"", 12541, "\"", 12549, 0);
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
<!-- Main-body end -->

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff8f1ecf3280c8d06a5f69d5941ba6c226dd83c434759", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8f1ecf3280c8d06a5f69d5941ba6c226dd83c435974", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 272 "E:\001_GasGroups\GasGroupApp2\GasGroupApp\PMS\Views\Purchase\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewPurchaseDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
