#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e00e4f8c2fc2737ee41ce3c98e14fcc8832f8c4"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class RSList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\r\n        <strong>\r\n            <font style=\"font-size:16px;\">NORMA</font>\r\n            <font style=\"font-size:16px; color:#00b2b0;\">CONNECT® RS/DIN</font>\r\n        </strong>\r\n    </div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 12 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
     foreach (var torro in TorroService.GetRS())
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
#line 15 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
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
#line 18 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
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
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
                     torro.materijal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "h5");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.AddContent(25, 
#nullable restore
#line 22 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
                     torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "h5");
            __builder.AddContent(29, 
#nullable restore
#line 24 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
                     torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-footer");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "small");
            __builder.AddAttribute(36, "class", "text-mutted");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", 
#nullable restore
#line 30 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
                              torro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "class", "button");
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.AddMarkupContent(42, "<h5><b>Katalog</b></h5>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 36 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 41 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
 if (selectedTorro != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal fade");
            __builder.AddAttribute(51, "id", "productModal");
            __builder.AddAttribute(52, "tabindex", "-1");
            __builder.AddAttribute(53, "role", "dialog");
            __builder.AddAttribute(54, "aria-labelledby", "productTitle");
            __builder.AddAttribute(55, "aria-hidden", "true");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(59, "role", "document");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-content");
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-header");
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "h5");
            __builder.AddAttribute(68, "class", "modal-title");
            __builder.AddAttribute(69, "id", "productTitle");
            __builder.AddContent(70, 
#nullable restore
#line 47 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
                                                               selectedTorro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.AddMarkupContent(72, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "modal-body");
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "card-dimension");
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "card-body-dimension");
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.OpenElement(83, "img");
            __builder.AddAttribute(84, "class", "new");
            __builder.AddAttribute(85, "src", 
#nullable restore
#line 55 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
                                                   selectedTorro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 62 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSList.razor"
       
    Torro selectedTorro;
    string selectedTorroId;

    void SelectTorro(string torroId)
    {
        selectedTorroId = torroId;
        selectedTorro = TorroService.GetRS().First(x => x.id == torroId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591
