#pragma checksum "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7ce67573f027cff31a15fbe7d8b041f0188b32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssetType__DataListPartialView), @"mvc.1.0.view", @"/Views/AssetType/_DataListPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a7ce67573f027cff31a15fbe7d8b041f0188b32", @"/Views/AssetType/_DataListPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c988150c4fa84b28b6ef034ddc763942ed574f", @"/Views/_ViewImports.cshtml")]
    public class Views_AssetType__DataListPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AssetsCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card-block table-border-style"">
    <div class=""table-responsive"">
        <table id=""example1"" class=""table table-bordered table-hover"">
            <thead>
                <tr>
                    <th>SNo.</th>
                    <th>Asset Category</th>
                    <th>Description</th>
                    <th>Status</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 15 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                   var sno = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                 if (Model.Any())
                {
                    foreach (var assettype in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 21 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                           Write(sno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 22 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                           Write(assettype.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 23 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                           Write(assettype.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 25 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                                 if (assettype.Status == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-primary\">Enabled</span>\r\n");
#nullable restore
#line 28 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-warning\">Disabled</span>\r\n");
#nullable restore
#line 32 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <a data-toggle=\"ajax-modal\" data-target=\"#exampleModal\" data-url=\"");
#nullable restore
#line 35 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                                                                                             Write(Url.Action($"Edit/{assettype.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                   data-redirect=\"");
#nullable restore
#line 36 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                                             Write(Url.Action("Success", "AssetType"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text text-primary\" style=\"cursor: pointer;\">\r\n                                    <i class=\"fa fa-edit\"></i>\r\n                                </a>\r\n                                <a class=\"delete-link\"");
            BeginWriteAttribute("href", " href=\"", 1795, "\"", 1847, 1);
#nullable restore
#line 39 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
WriteAttributeValue("", 1802, Url.Action("Delete", new {id =assettype.Id}), 1802, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash text-warning\"></i></a>\r\n                                <div class=\"delete-confirm\" style=\"display:none\" data-delete-id=\"");
#nullable restore
#line 40 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                                                                                            Write(assettype.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-trash text-danger\"></i></div>\r\n                                <span class=\"d-none\">");
#nullable restore
#line 41 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                                                       sno++;

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 44 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\AssetType\_DataListPartialView.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AssetsCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
