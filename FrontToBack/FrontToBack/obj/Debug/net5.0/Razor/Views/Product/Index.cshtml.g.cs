#pragma checksum "C:\Users\aytac\Desktop\adminPanel-Ajax-task\FrontToBack\FrontToBack\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "200e4209239064d4e958f18a348f1edf6a963c8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\aytac\Desktop\adminPanel-Ajax-task\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aytac\Desktop\adminPanel-Ajax-task\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aytac\Desktop\adminPanel-Ajax-task\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200e4209239064d4e958f18a348f1edf6a963c8f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91e45d94b3fdac1291515b2a24b25d901babe52", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\aytac\Desktop\adminPanel-Ajax-task\FrontToBack\FrontToBack\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <section id=\"products\">\r\n        <div class=\"container\">\r\n            <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3 m-auto\">\r\n                <div class=\"product-item text-center\">\r\n                    <div class=\"img\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 310, "\"", 317, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "200e4209239064d4e958f18a348f1edf6a963c8f4755", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 359, "~/img/", 359, 6, true);
#nullable restore
#line 13 "C:\Users\aytac\Desktop\adminPanel-Ajax-task\FrontToBack\FrontToBack\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 365, Model.Image, 365, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"title mt-3\">\r\n                        <h6>");
#nullable restore
#line 17 "C:\Users\aytac\Desktop\adminPanel-Ajax-task\FrontToBack\FrontToBack\Views\Product\Index.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <div class=\"price\">\r\n                        <span class=\"text-black-50\">Add to cart</span>\r\n                        <span class=\"text-black-50\">$");
#nullable restore
#line 21 "C:\Users\aytac\Desktop\adminPanel-Ajax-task\FrontToBack\FrontToBack\Views\Product\Index.cshtml"
                                                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
