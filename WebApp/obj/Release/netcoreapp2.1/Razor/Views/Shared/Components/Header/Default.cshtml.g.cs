#pragma checksum "C:\Users\Kanan\Desktop\WebApp\WebApp\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a31c082d352a62a375c842c8ee334b844139ee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Header/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Header_Default))]
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
#line 1 "C:\Users\Kanan\Desktop\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Kanan\Desktop\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a31c082d352a62a375c842c8ee334b844139ee5", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b09af506bf4e7cf674a65bc45d0858af3b99284", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 262, true);
            WriteLiteral(@"
<header>
    <nav id=""main_nav"">
        <div class=""container"">
            <div class=""row no-gutters "">

                <!-- logo part begins -->
                <div class=""col-lg-2"">
                    <div class=""logo"">
                        ");
            EndContext();
            BeginContext(276, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b2da6bcab484646884a31bfd2a6feb8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 286, "~/img/", 286, 6, true);
#line 11 "C:\Users\Kanan\Desktop\WebApp\WebApp\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 292, Model.Logo, 292, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(312, 865, true);
            WriteLiteral(@"
                    </div>
                    <i class=""fas fa-bars fa-2x d-none""></i>
                </div>
                <!-- logo part ends -->
                <!-- navigation part begins -->
                <div class=""col-lg-8 col-6 sidebar"">
                    <div class=""navigator"">
                        <div class=""headers"">
                            <i class=""fas fa-window-close fa-2x d-none""></i>
                            <ul class=""margin-left"">
                                <li class=""main"">
                                    <div class=""header"">
                                        <a class=""activeelement"">HOME</a>
                                    </div>
                                    <div class=""content"">
                                        <ul>
                                            <li>");
            EndContext();
            BeginContext(1177, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6957617b824b42d483928ae8cd134fc9", async() => {
                BeginContext(1221, 9, true);
                WriteLiteral("Main Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1234, 4569, true);
            WriteLiteral(@"</li>
                                            <li><a href="""">Grid Home</a></li>
                                            <li><a href="""">Flower Shop</a></li>
                                            <li><a href="""">Animated Slider</a></li>
                                            <li><a href="""">Metro Showcase</a></li>
                                            <li><a href="""">Carousel Showcase</a></li>
                                            <li><a href="""">Landing</a></li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""main"">
                                    <div class=""header"">
                                        <a>PAGES</a>
                                    </div>
                                    <div class=""content"">
                                        <ul>
                                            <li><a href="""">About us</a></li>
    ");
            WriteLiteral(@"                                        <li><a href="""">FAQ Page</a></li>
                                            <li><a href="""">Contact Us</a></li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""main"">
                                    <div class=""header"">
                                        <a>SHOP</a>
                                    </div>
                                    <div class=""content"">
                                        <ul class=""subss"">
                                            <li class=""subs"">
                                                <div class=""subheader"">
                                                    <h2>Product Types</h2>
                                                </div>
                                                <div class=""subcontent"">
                                                    <ul>
               ");
            WriteLiteral(@"                                         <li><a href=""orange_amaryllis.html"">Standart Product</a></li>
                                                        <li><a href="""">Grouped Product</a></li>
                                                        <li><a href="""">Variable Product</a></li>
                                                        <li><a href="""">Virtual Product</a></li>
                                                        <li><a href="""">External Product</a></li>
                                                        <li><a href="""">Downloadable Product</a></li>
                                                        <li><a href="""">On Sale Product</a></li>
                                                        <li><a href="""">Out Of Stock Product</a></li>
                                                        <li><a href="""">New Product</a></li>
                                                    </ul>
                                                </div>
                     ");
            WriteLiteral(@"                       </li>
                                            <li class=""subs"">
                                                <div class=""subheader"">
                                                    <h2>Shop Pages</h2>
                                                </div>
                                                <div class=""subcontent"">
                                                    <ul>
                                                        <li><a href="""">My Account</a></li>
                                                        <li><a href="""">Cart</a></li>
                                                        <li><a href="""">Checkout</a></li>
                                                        <li><a href="""">Orders</a></li>
                                                        <li><a href="""">Downloads</a></li>
                                                    </ul>
                                                </div>
                                   ");
            WriteLiteral(@"         </li>
                                            <li class=""subs"">
                                                <div class=""subheader"">
                                                    <h2>Shop Types</h2>
                                                </div>
                                                <div class=""subcontent"">
                                                    <ul>
                                                        <li>");
            EndContext();
            BeginContext(5803, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b664cea5c846ca8ccf7206a5e22aa5", async() => {
                BeginContext(5850, 12, true);
                WriteLiteral("Product List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5866, 14786, true);
            WriteLiteral(@"</li>
                                                        <li><a href="""">Without Sidebar</a></li>
                                                        <li><a href="""">With Category Filter</a></li>
                                                        <li><a href="""">With Ordering Filter</a></li>
                                                        <li><a href="""">Shop Carousel</a></li>
                                                        <li><a href="""">Product Categories</a></li>
                                                        <li><a href="""">Single Category</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                            <li class=""subs"">
                                                <div class=""subheader"">
                                                    <h2>Shop Layouts</h2>
                                               ");
            WriteLiteral(@" </div>
                                                <div class=""subcontent"">
                                                    <ul>
                                                        <li><a href="""">Two Columns Grid</a></li>
                                                        <li><a href="""">Three Columns Grid</a></li>
                                                        <li><a href="""">Four Columns Grid</a></li>
                                                        <li><a href="""">Four Columns Wide</a></li>
                                                        <li><a href="""">Five Columns Wide</a></li>
                                                        <li><a href="""">Six Columns Wide</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                <");
            WriteLiteral(@"/li>
                                <li class=""main"">
                                    <div class=""header"">
                                        <a>PORTFOLIO</a>
                                    </div>
                                    <div class=""content"">
                                        <ul>
                                            <li><a href="""">Standart</a></li>
                                            <li><a href="""">Gallery</a></li>
                                            <li><a href="""">Masonry</a></li>
                                            <li class=""rightarrow"">
                                                <a href="""">
                                                    Portfolio Layouts <i class=""fa fa-angle-right""></i>
                                                </a>
                                                <div class=""rightarrowinfo"">
                                                    <ul>
                                             ");
            WriteLiteral(@"           <li><a href="""">Two Columns</a></li>
                                                        <li><a href="""">Three Columns</a></li>
                                                        <li><a href="""">Four Columns</a></li>
                                                        <li><a href="""">Four Columns Wide</a></li>
                                                        <li><a href="""">Five Columns Wide</a></li>
                                                    </ul>
                                                </div>

                                            </li>
                                            <li class=""rightarrow"">
                                                <a href="""">
                                                    Portfolio Single <i class=""fa fa-angle-right""></i>
                                                </a>
                                                <div class=""rightarrowinfo"">
                                                    <ul");
            WriteLiteral(@">
                                                        <li><a href=""a"">Small Images</a></li>
                                                        <li><a href="""">Small Slider</a></li>
                                                        <li><a href="""">Big Images</a></li>
                                                        <li><a href="""">Big Slider</a></li>
                                                        <li><a href="""">Gallery</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""main"">
                                    <div class=""header"">
                                        <a>BLOG</a>
                                    </div>
                                    <div class=""content"">");
            WriteLiteral(@"
                                        <ul>
                                            <li><a href="""">Masonry</a></li>
                                            <li><a href="""">Standart</a></li>
                                            <li class=""rightarrow"">
                                                <a href="""">
                                                    Post Types <i class=""fa fa-angle-right""></i>
                                                </a>
                                                <div class=""rightarrowinfo"">
                                                    <ul>
                                                        <li><a href="""">Standart</a></li>
                                                        <li><a href="""">Gallery</a></li>
                                                        <li><a href="""">Link</a></li>
                                                        <li><a href="""">Quote</a></li>
                                                   ");
            WriteLiteral(@"     <li><a href="""">Gallery</a></li>
                                                        <li><a href="""">Audio</a></li>
                                                        <li><a href="""">Video</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""main"">
                                    <div class=""header"">
                                        <a>ELEMENTS</a>
                                    </div>
                                    <div class=""content"">
                                        <ul>
                                            <li class=""leftarrow"">
                                                <a href="""">
                                                    <i class=""fa fa-angl");
            WriteLiteral(@"e-left""></i></i>Classic
                                                </a>
                                                <div class=""leftarrowinfo"">
                                                    <ul>
                                                        <li><a href=""accordions.html"">Accordions</a></li>
                                                        <li><a href=""tabs.html"">Tabs</a></li>
                                                        <li><a href="""">Buttons</a></li>
                                                        <li><a href="""">Video Button</a></li>
                                                        <li><a href="""">Contact Form</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                            <li class=""leftarrow"">
                                                <a href="""">
                                    ");
            WriteLiteral(@"                <i class=""fa fa-angle-left""></i></i>
                                                    Infographic
                                                </a>
                                                <div class=""leftarrowinfo"">
                                                    <ul>
                                                        <li><a href="""">Blog List</a></li>
                                                        <li><a href="""">Counters</a></li>
                                                        <li><a href="""">Countdown</a></li>
                                                        <li><a href="""">Google Maps</a></li>
                                                        <li><a href=""progress.html"">Progress Bar</a></li>
                                                        <li><a href="""">Pies Charts</a></li>
                                                    </ul>
                                                </div>
                                    ");
            WriteLiteral(@"        </li>
                                            <li class=""leftarrow"">
                                                <a href="""">
                                                    <i class=""fa fa-angle-left""></i>
                                                    Interactive
                                                </a>
                                                <div class=""leftarrowinfo"">
                                                    <ul>
                                                        <li><a href="""">Image Gallery</a></li>
                                                        <li><a href="""">Testimonials</a></li>
                                                        <li><a href="""">Team</a></li>
                                                        <li><a href="""">Banner</a></li>
                                                        <li><a href=""shop_list.html"">Shop List</a></li>
                                                        <li><a href="""">P");
            WriteLiteral(@"ortfolio List</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                            <li class=""leftarrow"">
                                                <a href="""">
                                                    <i class=""fa fa-angle-left""></i>
                                                    Typography
                                                </a>
                                                <div class=""leftarrowinfo"">
                                                    <ul>
                                                        <li><a href="""">Headings</a></li>
                                                        <li><a href="""">Columns</a></li>
                                                        <li><a href="""">Section Title</a></li>
                                                        <li><a href="""">Blockquote</a></li>
");
            WriteLiteral(@"                                                        <li><a href="""">Dropcaps</a></li>
                                                        <li><a href="""">Highlights</a></li>
                                                        <li><a href="""">Separators</a></li>
                                                        <li><a href="""">Custom Font</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </li>

                            </ul>

                        </div>
                    </div>
                </div>
                <!-- navigation part ends -->
                <!-- two little icon part begins -->
                <div class=""col-lg-2"">
                    <div class=""icons"">
                        <div class=""search"">
          ");
            WriteLiteral(@"                  <span><i class=""fas fa-search searchicon""></i></span>
                            <div class=""search-box d-none"">
                                <input type=""text"" placeholder=""Search"" id=""search-box"">
                                <a href=""""><i class=""fas fa-search""></i></a>
                            </div>
                        </div>
                        <div class=""cartdiv"">
                            <a href=""#"" class=""cart"">
                                <span class=""bag-icon"">
                                    <i class=""fas fa-shopping-bag bag"">
                                        <sup>
                                            <p class=""amount"">0</p>
                                        </sup>
                                    </i>
                                </span><span class=""total"">
                                    CART(<span class=""price"">0</span>)
                                </span>
                            </a>

      ");
            WriteLiteral(@"                      <div class=""cart-dropdown"" style=""display: none;"">
                                <!-- <p class=""text-center no-product"" style=""display: none;"">No products in the cart</p> -->
                                <div class=""cart-header"">
                                    <ul>
                                    </ul>
                                </div>
                                <div class=""cart-bottom"">
                                    <div class=""subtotal-holder"">
                                        <span class=""total"">TOTAL:</span>
                                        <span class=""amount text-right"">
                                            <p>259</p>
                                        </span>
                                    </div>
                                    <div class=""cart-buttons"">
                                        <input type=""submit"" value=""VIEW CART"" class=""button view-cart"">
                                        <inpu");
            WriteLiteral(@"t type=""submit"" value=""CHECKOUT"" class=""button checkout"">
                                    </div>

                                </div>
                            </div>
                        </div>


                        <span><i class=""fas fa-bars bar""></i></span>
                    </div>
                </div>

                <!-- two little icon part ends -->
            </div>
        </div>
    </nav>
</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data> Html { get; private set; }
    }
}
#pragma warning restore 1591
