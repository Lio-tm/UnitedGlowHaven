#pragma checksum "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "295c1c229e3bc31191895db1a28204ce2aa2043d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295c1c229e3bc31191895db1a28204ce2aa2043d", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d62f7c8db58915f94040bda6b2aa61c3f906ce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UnitedGlowHaven.ViewModels.ProductDetailsViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Product\Details.cshtml"
  
    ViewData["Title"] = @Model.Naam;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card flex-row flex-wrap bg-custom-lighter p-2\">\r\n        <div class=\"card-header\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 217, "\"", 240, 1);
#nullable restore
#line 9 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Product\Details.cshtml"
WriteAttributeValue("", 223, Model.Afbeelding, 223, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" style=\"width: 30rem;\"/>\r\n        </div>\r\n        <div class=\"card-block\">\r\n        <div class=\"card-block px-2\">\r\n            <h4 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Product\Details.cshtml"
                              Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item bg-custom-lighter list-group-item-product\">Productnummer : ");
#nullable restore
#line 15 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Product\Details.cshtml"
                                                                                                 Write(Model.ProductNummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item bg-custom-lighter list-group-item-product\">Prijs : ");
#nullable restore
#line 16 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Product\Details.cshtml"
                                                                                         Write(Model.Prijs);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</li>\r\n                <li class=\"list-group-item bg-custom-lighter list-group-item-product\">Beschrijving : ");
#nullable restore
#line 17 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Product\Details.cshtml"
                                                                                                Write(Model.Beschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n");
            WriteLiteral("        </div>\r\n            \r\n        </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Product\Details.cshtml"
Write(Html.ActionLink("Terug", "Index", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
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