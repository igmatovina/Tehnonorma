#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Pages\CIJEVNESVJETILJKE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869906eef5bbf7ce0d3f1cf812381ead240f8c18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tehno.WebSite.Pages.Pages_CIJEVNESVJETILJKE), @"mvc.1.0.razor-page", @"/Pages/CIJEVNESVJETILJKE.cshtml")]
namespace Tehno.WebSite.Pages
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Pages\_ViewImports.cshtml"
using Tehno.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Pages\CIJEVNESVJETILJKE.cshtml"
using Tehno.WebSite.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869906eef5bbf7ce0d3f1cf812381ead240f8c18", @"/Pages/CIJEVNESVJETILJKE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1cb74f2c7f2775a2a99ca92e931fc6b27c998a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CIJEVNESVJETILJKE : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Pages\CIJEVNESVJETILJKE.cshtml"
  
    ViewData["Title"] = "NORMA CLAMP TORO";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Pages\CIJEVNESVJETILJKE.cshtml"
Write(await Html.RenderComponentAsync<CIJEVNESVJETILJKEList>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<script src=\"_framework/blazor.server.js\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
