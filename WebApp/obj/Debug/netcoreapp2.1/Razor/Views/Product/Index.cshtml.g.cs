#pragma checksum "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "328bfe3fa5fbc2f19a4165b13422c1afbfd166a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\_ViewImports.cshtml"
using WebApp.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"328bfe3fa5fbc2f19a4165b13422c1afbfd166a6", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db46d8d3b5ca74f3e9c90eca25b2885d25d72ba5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
            BeginContext(74, 468, true);
            WriteLiteral(@"
<!-- header part begins -->
<section id=""header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""header"">
                <h1>Product List</h1>
                <div class=""content"">
                    <p>Where flowers are our inspiration</p>
                </div>
            </div>

        </div>
    </div>
</section>

<section id=""flower"">
    <div class=""container"">
        <div class=""row product_mainlist"">
");
            EndContext();
            BeginContext(593, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(606, 61, false);
#line 25 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
       Write(await Component.InvokeAsync("Products",ViewBag.pageIndicator));

#line default
#line hidden
            EndContext();
            BeginContext(667, 159, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row justify-content-center\">\r\n            <nav aria-label=\"...\">\r\n                <ul class=\"pagination pagination-sm\">\r\n");
            EndContext();
#line 30 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
                     for (int i = 1; i <= ViewBag.Page; i++)
                    {
                        if (ViewBag.pageIndicator == i)
                        {

#line default
#line hidden
            BeginContext(995, 107, true);
            WriteLiteral("                            <li class=\"page-item disabled\" style=\"border-color:black;\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1102, "\"", 1131, 2);
            WriteAttributeValue("", 1109, "/product/index?page=", 1109, 20, true);
#line 34 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1129, i, 1129, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1132, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1134, 1, false);
#line 34 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
                                                                                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 35 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1230, 121, true);
            WriteLiteral("                            <li class=\"page-item\" style=\"border-color:black;\"><a style=\"color:#f34f3f\"  class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1351, "\"", 1380, 2);
            WriteAttributeValue("", 1358, "/product/index?page=", 1358, 20, true);
#line 38 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1378, i, 1378, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1381, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1383, 1, false);
#line 38 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
                                                                                                                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1384, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 39 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Product\Index.cshtml"
                        }


                    }

#line default
#line hidden
            BeginContext(1449, 87, true);
            WriteLiteral("                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
