#pragma checksum "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Product\_BatchDetailsPartials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea13e451d9ecddc2c1ed3f724b3745530788098a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__BatchDetailsPartials), @"mvc.1.0.view", @"/Views/Product/_BatchDetailsPartials.cshtml")]
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
#nullable restore
#line 35 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\_ViewImports.cshtml"
using PMS.Data.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea13e451d9ecddc2c1ed3f724b3745530788098a", @"/Views/Product/_BatchDetailsPartials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1294a065003cd80f0d0b51345d2b1e10ab7a6a9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__BatchDetailsPartials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductBatch>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--Modal Body Start-->
<div class=""modal-content p-2 m-2"">
    <!--Modal Header Start-->
    <div class=""modal-header"">
        <h5 class=""modal-title"">Product Batch Details</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">
                <i class=""fa fa-times text text-danger""></i>
            </span>
        </button>
    </div>
    <!--Modal Header End-->
    <!--Modal Content here ...-->
    <div class=""table-responsive"">
        <table class=""table table-responsive table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Batch ID</th>
                    <th>Purchase Date</th>
                    <th>Stock Qty</th>
                    <th>Purchase Price</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Product\_BatchDetailsPartials.cshtml"
                 if (Model.Any())
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 31 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Product\_BatchDetailsPartials.cshtml"
                           Write(m.BatchId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Product\_BatchDetailsPartials.cshtml"
                           Write(m.PurchaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Product\_BatchDetailsPartials.cshtml"
                           Write(m.StockQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Product\_BatchDetailsPartials.cshtml"
                           Write(m.PurchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 36 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Product\_BatchDetailsPartials.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <!--Modal Contents end-->\r\n</div>\r\n<!--Modal Body End-->\r\n<script>\r\n    $(\'input\').attr(\'autocomplete\', \'off\');\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductBatch>> Html { get; private set; }
    }
}
#pragma warning restore 1591
