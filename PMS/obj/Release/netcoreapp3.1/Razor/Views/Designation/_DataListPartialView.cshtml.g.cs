#pragma checksum "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20e34832178eebb158c4e3a8a39d41c3130fb958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Designation__DataListPartialView), @"mvc.1.0.view", @"/Views/Designation/_DataListPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e34832178eebb158c4e3a8a39d41c3130fb958", @"/Views/Designation/_DataListPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1294a065003cd80f0d0b51345d2b1e10ab7a6a9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Designation__DataListPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Designation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-block table-border-style\">\r\n    <div class=\"table-responsive\">\r\n        <table id=\"example1\" class=\"table table-bordered table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 9 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                   Write(localizer["SNo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</th>\r\n                    <th>");
#nullable restore
#line 10 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                   Write(localizer["Designation"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 11 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                   Write(localizer["Description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 12 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                   Write(localizer["Status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 13 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                   Write(localizer["Action"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 17 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                   var sno = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                 if (Model.Any())
                {
                    foreach (var Type in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 23 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                           Write(sno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                           Write(Type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                           Write(Type.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 27 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                                 if (Type.Status == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-primary\">");
#nullable restore
#line 29 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                                                                 Write(localizer["Enabled"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 30 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-warning\">");
#nullable restore
#line 33 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                                                                 Write(localizer["Enabled"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 34 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <a data-toggle=\"ajax-modal\" data-target=\"#exampleModal\" data-url=\"");
#nullable restore
#line 37 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                                                                                             Write(Url.Action($"Edit/{Type.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                   data-redirect=\"");
#nullable restore
#line 38 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                                             Write(Url.Action("Success", "Designation"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text text-primary\" style=\"cursor: pointer;\">\r\n                                    <i class=\"fa fa-edit\"></i>\r\n                                </a>\r\n                                <span class=\"d-none\">");
#nullable restore
#line 41 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                                                       sno++;

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 44 "E:\0110\GasGroupApp\GasGroupApp\PMS\Views\Designation\_DataListPartialView.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Designation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
