#pragma checksum "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Categorie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "754a88e81edd199cf6faaffe78cbcc4f2fcb234d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorie_Index), @"mvc.1.0.view", @"/Views/Categorie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"754a88e81edd199cf6faaffe78cbcc4f2fcb234d", @"/Views/Categorie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d62f7c8db58915f94040bda6b2aa61c3f906ce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categorie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UnitedGlowHaven.ViewModels.ProductListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"container p-5 bg-custom-lighter\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Categorie\Index.cshtml"
         foreach (var product in Model.Producten)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card bg-custom-lighter p-2\" style=\"width: 16rem; height: 28rem;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "754a88e81edd199cf6faaffe78cbcc4f2fcb234d4265", async() => {
                WriteLiteral("\r\n                    <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 430, "\"", 455, 1);
#nullable restore
#line 10 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Categorie\Index.cshtml"
WriteAttributeValue("", 436, product.Afbeelding, 436, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Card image cap\" style=\"height:20rem\">\r\n                    <div class=\"card-body\">\r\n                        <ul class=\"list-group\">\r\n                            <li class=\"list-group-item bg-custom-lighter list-group-item-product\">");
#nullable restore
#line 13 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Categorie\Index.cshtml"
                                                                                             Write(product.Naam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            <li class=\"list-group-item bg-custom-lighter list-group-item-product\">");
#nullable restore
#line 14 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Categorie\Index.cshtml"
                                                                                             Write(product.Prijs);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Categorie\Index.cshtml"
                                                                   WriteLiteral(product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\Lio\Desktop\WEBAPP\UnitedGlowHaven\UnitedGlowHaven\Views\Categorie\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UnitedGlowHaven.ViewModels.ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
