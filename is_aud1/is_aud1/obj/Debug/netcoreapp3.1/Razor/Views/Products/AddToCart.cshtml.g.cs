#pragma checksum "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\Products\AddToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c3a1e44adf4e4cacfff760c8b558f03ac2bac8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_AddToCart), @"mvc.1.0.view", @"/Views/Products/AddToCart.cshtml")]
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
using is_aud1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3a1e44adf4e4cacfff760c8b558f03ac2bac8a", @"/Views/Products/AddToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab917f06ea533e689aea35a068cd1b16f8669eba", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_AddToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<is_aud1.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>\r\n    The product ");
#nullable restore
#line 9 "C:\Users\Lenovo\Documents\GitHub\Integrated_Systems\is_aud1\is_aud1\Views\Products\AddToCart.cshtml"
           Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is added to your shopping cart.\r\n</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<is_aud1.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591