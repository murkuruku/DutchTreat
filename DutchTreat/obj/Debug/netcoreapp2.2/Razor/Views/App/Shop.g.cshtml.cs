#pragma checksum "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc08cd180b2400141c4f96625c70ce668cc9490a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Shop.cshtml", typeof(AspNetCore.Views_App_Shop))]
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
#line 1 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#line 2 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc08cd180b2400141c4f96625c70ce668cc9490a", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402ff29ed5304f90d7247425045b59e26db665d3", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 28, true);
            WriteLiteral("\r\n    <h1>Shop</h1>\r\n    <p>");
            EndContext();
            BeginContext(59, 13, false);
#line 4 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
  Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(72, 29, true);
            WriteLiteral("</p>\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 6 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
            BeginContext(147, 115, true);
            WriteLiteral("            <div class=\"col-md-3\">\r\n                <div class=\"border bg-light rounded p-1\">\r\n                    ");
            EndContext();
            BeginContext(262, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc08cd180b2400141c4f96625c70ce668cc9490a4433", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 272, "~/img/", 272, 6, true);
#line 10 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 278, p.ArtId, 278, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 288, ".jpg", 288, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 317, p.Title, 317, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 26, true);
            WriteLiteral("\r\n                    <h3>");
            EndContext();
            BeginContext(355, 10, false);
#line 11 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                   Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(365, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(369, 6, false);
#line 11 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                                 Write(p.Size);

#line default
#line hidden
            EndContext();
            BeginContext(375, 68, true);
            WriteLiteral("</h3>\r\n                    <ul>\r\n                        <li>Price: ");
            EndContext();
            BeginContext(444, 7, false);
#line 13 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                              Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(451, 43, true);
            WriteLiteral("</li>\r\n                        <li>Artist: ");
            EndContext();
            BeginContext(495, 8, false);
#line 14 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                               Write(p.Artist);

#line default
#line hidden
            EndContext();
            BeginContext(503, 42, true);
            WriteLiteral("</li>\r\n                        <li>Title: ");
            EndContext();
            BeginContext(546, 7, false);
#line 15 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                              Write(p.Title);

#line default
#line hidden
            EndContext();
            BeginContext(553, 47, true);
            WriteLiteral("</li>\r\n                        <li>Description:");
            EndContext();
            BeginContext(601, 16, false);
#line 16 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                                   Write(p.ArtDescription);

#line default
#line hidden
            EndContext();
            BeginContext(617, 159, true);
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <button id=\"buyButton\" class=\"btn btn-success\">Buy</button>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 21 "C:\Users\HP\source\repos\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
        }

#line default
#line hidden
            BeginContext(787, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
