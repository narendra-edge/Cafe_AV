#pragma checksum "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Item\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75e1a8a96b3f66c0a52f82048eb8c44ac93b3c08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_List), @"mvc.1.0.view", @"/Views/Item/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e1a8a96b3f66c0a52f82048eb8c44ac93b3c08", @"/Views/Item/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"122165d39348a79a14e1467d00313305a229bdaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Item\List.cshtml"
Write(ViewBag.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>");
#nullable restore
#line 4 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Item\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 5 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Item\List.cshtml"
 foreach (var item in Model.Items)
{


#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Item\List.cshtml"
Write(Html.Partial("ItemOverviewSummary", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Narendra\source\repos\Cafe_AV\Cafe_AV\Views\Item\List.cshtml"
                                          }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591