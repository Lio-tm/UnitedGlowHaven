#pragma checksum "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79f5ea9811ad0f0fd0c2f08566b3d1955f2f0ece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductDetails), @"mvc.1.0.view", @"/Views/Admin/ProductDetails.cshtml")]
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
#line 1 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\_ViewImports.cshtml"
using UnitedGlowHaven;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\_ViewImports.cshtml"
using UnitedGlowHaven.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f5ea9811ad0f0fd0c2f08566b3d1955f2f0ece", @"/Views/Admin/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d62f7c8db58915f94040bda6b2aa61c3f906ce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UnitedGlowHaven.ViewModels.ProductDetailsViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
  
    ViewData["Title"] = Model.Naam;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mt-5\">");
#nullable restore
#line 6 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"table table-bordered table-striped mt-5\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 10 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => this.Model.ProductNummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Model.ProductNummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => this.Model.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => this.Model.Beschrijving));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Model.Beschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => this.Model.Kleur));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Model.Kleur.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => this.Model.Categorie));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Model.Categorie.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => this.Model.Prijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Admin\ProductDetails.cshtml"
       Write(Model.Prijs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    \r\n</table>\r\n\r\n");
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UnitedGlowHaven.ViewModels.ProductDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
