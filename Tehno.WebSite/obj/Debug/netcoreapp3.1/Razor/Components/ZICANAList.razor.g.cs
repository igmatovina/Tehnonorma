#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ab0d29519efeb2ee87880c2fac2bdce678b7f7"
// <auto-generated/>
#pragma warning disable 1591
namespace Tehno.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class ZICANAList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<strong>\r\n    <font style=\"font-size:16px;\">NORMA</font>\r\n    <font style=\"font-size:16px; color:#00b2b0;\">CONNECT®</font>\r\n</strong>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 10 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
     foreach (var torro in TorroService.GetZICANA())
    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-wider");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 14 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
                       torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h5");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "b");
            __builder.AddContent(17, 
#nullable restore
#line 17 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
                        torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "h5");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.AddContent(22, 
#nullable restore
#line 20 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
                     torro.izvedba

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "h5");
            __builder.AddContent(26, 
#nullable restore
#line 22 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
                     torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n                ");
            __builder.OpenElement(28, "h5");
            __builder.AddContent(29, 
#nullable restore
#line 24 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
                     torro.materijal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n                ");
            __builder.OpenElement(31, "h5");
            __builder.AddContent(32, 
#nullable restore
#line 26 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
                     torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-footer");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "small");
            __builder.AddAttribute(39, "class", "text-mutted");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "href", 
#nullable restore
#line 33 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"
                              torro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "class", "button");
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.AddMarkupContent(45, "<h5><b>Katalog</b></h5>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 39 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\ZICANAList.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591