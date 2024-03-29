#pragma checksum "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ded83ba860234103d3d65c051892fa4e20889f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\_ViewImports.cshtml"
using is_aud1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\_ViewImports.cshtml"
using EShop.Domain.DomainModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ded83ba860234103d3d65c051892fa4e20889f", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6533cef3c3a04c4c64139bb4d6e351146fa90649", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop.Domain.DTO.ShoppingCartDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PayOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Shopping Cart</h1>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
 if (Model.ProductsInShoppingCarts.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>No products in shopping cart</h5>\r\n");
#nullable restore
#line 16 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n");
#nullable restore
#line 22 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
             if (Model.TotalPrice != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ded83ba860234103d3d65c051892fa4e20889f5395", async() => {
                WriteLiteral("\r\n                    <article>\r\n                        <script src=\"https://checkout.stripe.com/checkout.js\"\r\n                                class=\"stripe-button\"\r\n                                data-key=\"");
#nullable restore
#line 28 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                                     Write(Stripe.Value.PublishableKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                data-locale=\"auto\"\r\n                                data-description=\"EShop Application Payment\"\r\n                                data-amount=\"");
#nullable restore
#line 31 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                                         Write(Model.TotalPrice * 100);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                data-label=\"Pay $");
#nullable restore
#line 32 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                                            Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                        </script>\r\n                    </article>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <table class=""table"">
        <thead>
            <tr>
                <th class=""col-md-1"">
                    #
                </th>
                <th class=""col"">
                    Product Name
                </th>
                <th class=""col"">
                    Quantity
                </th>
                <th class=""col"">
                    Price
                </th>
                <th>

                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 60 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
              
                var i = 1;
                foreach (var item in Model.ProductsInShoppingCarts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                        Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                       Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                       Write(item.Product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2521, "\"", 2581, 2);
            WriteAttributeValue("", 2528, "/ShoppingCart/DeleteFromShoppingCart/", 2528, 37, true);
#nullable restore
#line 78 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2565, item.Product.Id, 2565, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n        <tfoot>\r\n            <tr>\r\n                <th>Total: </th>\r\n                <th></th>\r\n                <th></th>\r\n                <th></th>\r\n                <th> ");
#nullable restore
#line 92 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
                Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </tfoot>\r\n\r\n    </table>\r\n");
#nullable restore
#line 97 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\ShoppingCart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<EShop.Domain.StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop.Domain.DTO.ShoppingCartDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
