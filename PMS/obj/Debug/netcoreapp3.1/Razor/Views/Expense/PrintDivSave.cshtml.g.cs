#pragma checksum "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87b7e49bac458e05138e76603693406942dedfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense_PrintDivSave), @"mvc.1.0.view", @"/Views/Expense/PrintDivSave.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87b7e49bac458e05138e76603693406942dedfe", @"/Views/Expense/PrintDivSave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c988150c4fa84b28b6ef034ddc763942ed574f", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense_PrintDivSave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExpenseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
  
    ViewData["Title"] = "Expense";

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
                        <h5 class=""m-b-10"">Expenses Administration</h5>
                        <ul class=""breadcrumb-title b-t-default p-t-10"">
                            <li class=""breadcrumb-item pull-right"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87b7e49bac458e05138e76603693406942dedfe10595", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-user-plus\"></i> Add New Expense\r\n                                ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87b7e49bac458e05138e76603693406942dedfe12278", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-list\"></i> Expenses List\r\n                                ");
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
                            <h5>Expense Slip Print</h5>
                            <div class=""card-header-right"">
                                <ul class=""list-unstyled card-option"">
                                    <li><i class=""fa fa-chevron-left""></i></li>
                                    <li><i class=""fa fa-window-maximize full-card""></i></li>
                                    <li><i class=""fa fa-minus minimize-card""></i></li>
                                    <li><i class=""fa fa-refresh reload-card""></i></li>
                                    <li><i class=""fa fa-times close-card""></i></li>
                                </ul>
                    ");
            WriteLiteral("        </div>\r\n                        </div>\r\n\r\n                        <div class=\"card-block table-border-style PrintArea\"");
            BeginWriteAttribute("id", " id=\"", 2345, "\"", 2350, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""row"">

                                <div class=""col-lg-6 col-md-6 col-sm-6"">
                                    <div class=""d-flex flex-column flex-root"">
                                        <span class=""font-weight-bolder mb-2""><h3>");
#nullable restore
#line 56 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                                             Write(ViewBag.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3></span>
                                        <span class=""opacity-60"" style=""font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size:large"">
                                            ");
#nullable restore
#line 58 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                       Write(ViewBag.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 58 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                        Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                            ");
#nullable restore
#line 59 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                       Write(ViewBag.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </span>
                                    </div>
                                    <hr />
                                </div>
                                <div class=""col-lg-6 col-md-6 col-sm-6"">
                                    <div class=""d-flex flex-column flex-root"">
                                        <h2> <span class=""font-weight-bolder mb-2"" style=""font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size:large""> <b> Expense Slip</h2>
                                        <span class=""opacity-60"">
                                            Date :  ");
#nullable restore
#line 68 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                               Write(DateTime.Now.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <br />
                                        </span>
                                    </div>
                                    <hr />
                                </div>

                            </div>
                            <div class=""row"">
                                <div class=""col-12"">
                                    <div class=""table-responsive"">
                                        <table");
            BeginWriteAttribute("id", " id=\"", 4206, "\"", 4211, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""table table-bordered table-hover"">
                                            <tbody>
                                                <tr>
                                                    <th>Expense Id</th>
                                                    <td>");
#nullable restore
#line 82 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                    <th>Date</th>\r\n                                                    <td>");
#nullable restore
#line 85 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                   Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                </tr>\r\n                                                <tr>\r\n                                                    <th>Amount</th>\r\n                                                    <td>");
#nullable restore
#line 89 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                   Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <th>Category</th>\r\n                                                    <td>");
#nullable restore
#line 91 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                   Write(Model.ExpenseCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                </tr>\r\n                                                <tr>\r\n                                                    <th>Employee </th>\r\n                                                    <td>");
#nullable restore
#line 95 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                   Write(Model.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                    <th>Bill Number</th>\r\n\r\n                                                    <td>");
#nullable restore
#line 99 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                   Write(Model.BillNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                                                </tr>
                                                <tr>
                                                    <th>Descriptions</th>
                                                    <td colspan=""4"">");
#nullable restore
#line 104 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Expense\PrintDivSave.cshtml"
                                                               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""col-12 text text-right mb-4 mr-4"">
                            <a class=""btn btn-info text-white"" id=""btnprint"">
                                <i class=""fa fa-print""></i> Print
                            </a>
                        </div>
                    </div>
                    <!-- Basic table card end -->
                </div>
                <!-- Page-body end -->
                <div class=""page-header card"">
                    <div class=""card-block"">
                        <ul");
            BeginWriteAttribute("class", " class=\"", 6626, "\"", 6634, 0);
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


        $('#btnprint').click(function () {
            $("".PrintArea"").printThis({
                debug: false,                      // show the iframe for debugging
                importCSS: true,                  // import parent page css
                importStyle: true,                // import style tags
                printContainer: true,            // print outer container/$.selector
                loadCSS: ""~/css/PrintArea.css"",                // path to additional css file - use an array [] for multiple
                pageTitle: ""Expence Slip"",              // add title to print page
                removeInline: false,             // remove inline styles from print elements
                removeInlineSelector: ""*"",      // custom selectors to filter inline styles. removeInline must be true
                printDelay: 333,                 // variable print delay
                header: ""<h1>Expense Slip Print</h1>"",               // prefix");
                WriteLiteral(@" to html
                footer: null,                    // postfix to html
                base: false,                    // preserve the BASE tag or accept a string for the URL
                formValues: true,           // preserve input/form values
                canvas: false,              // copy canvas content
                doctypeString: '...',       // enter a different doctype for older markup
                removeScripts: false,       // remove script tags from print content
                copyTagClasses: false,      // copy classes from the html & body tag
                beforePrintEvent: null,     // function for printEvent in iframe
                beforePrint: null,          // function called before iframe is filled
                afterPrint: null            // function called before iframe is removed
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExpenseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
