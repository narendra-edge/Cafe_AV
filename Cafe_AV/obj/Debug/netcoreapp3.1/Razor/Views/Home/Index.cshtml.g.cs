#pragma checksum "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0203e80462bf2a9791680030745780dd0018173"
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
#line 1 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\_ViewImports.cshtml"
using Cafe_AV.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\_ViewImports.cshtml"
using Cafe_AV.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0203e80462bf2a9791680030745780dd0018173", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"122165d39348a79a14e1467d00313305a229bdaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<h2>Items of the week</h2>\n<h4>Our weekly selection - just for you!</h4>\n\n<div>\n\n");
#nullable restore
#line 10 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Home\Index.cshtml"
     foreach (var item in Model.ItemsOfTheWeek)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Home\Index.cshtml"
Write(Html.Partial("ItemOfTheWeek", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591