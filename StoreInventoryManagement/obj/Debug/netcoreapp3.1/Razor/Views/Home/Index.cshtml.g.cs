#pragma checksum "C:\Users\Me\source\repos\StoreInventoryManagement\StoreInventoryManagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3617f5170e8210e78a2f2738b2ad5d0615b5f67b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Me\source\repos\StoreInventoryManagement\StoreInventoryManagement\Views\_ViewImports.cshtml"
using StoreInventoryManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Me\source\repos\StoreInventoryManagement\StoreInventoryManagement\Views\_ViewImports.cshtml"
using StoreInventoryManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3617f5170e8210e78a2f2738b2ad5d0615b5f67b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1eaba952970b268dac620d617e2cb89a36a627a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Me\source\repos\StoreInventoryManagement\StoreInventoryManagement\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Main Menu</h1>
</div>

<table class=""table"">
    <tr>
        <th>Function</th>
        <th>Description</th>
    </tr>
    <tr>
        <td>Residual Items</td>
        <td>Verify residual items are properly accounted for.</td>
        <td><button>Select</button></td>
    </tr>
    <tr>
        <td>Low/Empty Items</td>
        <td>Verify the balance of items that are low or empty on shelf.</td>
        <td><button>Select</button></td>
    </tr>
    <tr>
        <td>Markdown Items</td>
        <td>Lower the price of damaged items or items approaching expiration.</td>
        <td><button>Select</button></td>
    </tr>
    <tr>
        <td>Remove Items</td>
        <td>Remove items from inventory due to severe damage, expiration, theft, etc.</td>
        <td><button>Select</button></td>
    </tr>
    <tr>
        <td>Item Info</td>
        <td>Get various information on selected item.</td>
        <td><button>Select</button></td");
            WriteLiteral(">\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
