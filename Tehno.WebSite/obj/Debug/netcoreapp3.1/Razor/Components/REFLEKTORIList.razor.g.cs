#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea3e370b85656a6538d77b86c01a64bddff3b08"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class REFLEKTORIList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<strong>\r\n    <font style=\"font-size:16px;\">NORMA</font>\r\n    <font style=\"font-size:16px; color:#00b2b0;\">TECHMALUX®</font>\r\n</strong>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns-wider columncount");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 10 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor"
     foreach (var torro in TorroService.GetREFLEKTORI())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "h5");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "b");
            __builder.AddContent(8, 
#nullable restore
#line 13 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor"
                torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-wider");
            __builder.AddAttribute(13, "style", "width:auto");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 16 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor"
                       torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "imgreflektori");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-footer lampe");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "small");
            __builder.AddAttribute(23, "class", "text-mutted");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 20 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor"
                              torro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "button");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.AddMarkupContent(29, "<h5><b>Katalog</b></h5>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 26 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\REFLEKTORIList.razor"

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
