#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "535724372c3d3b1e6f896b8153c324d8e5603b9f"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class RSGUList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<strong>\r\n        <font style=\"font-size:16px;\">NORMA</font>\r\n        <font style=\"font-size:16px; color:#00b2b0;\">FIX® RSGU</font>\r\n    </strong>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 10 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
     foreach (var torro in TorroService.GetRSGU())
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
#line 13 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
                       torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body card-body-higher");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h5");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "b");
            __builder.AddContent(17, 
#nullable restore
#line 16 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
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
#line 18 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
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
#line 20 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
                     torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 22 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
                 if (Int32.Parse(@torro.id) == 1)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                    ");
            __builder.AddMarkupContent(29, @"<h5>
                        - širina 12 provrt za vijak M5<br>
                        - širina 15 provrt za vijak M6<br>
                        - širina 20 provrt za vijak M8<br>
                        sve navedene dimenzije rade se i u inox izvedbi W5 1.4401<br>
                        Napomena: dimenzije iznad Φ40 po upitu
                    </h5>
");
#nullable restore
#line 31 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-footer");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "small");
            __builder.AddAttribute(36, "class", "text-mutted");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
                                      (e => SelectTorro(torro.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "data-toggle", "modal");
            __builder.AddAttribute(41, "data-target", "#productModal");
            __builder.AddAttribute(42, "class", "button");
            __builder.AddMarkupContent(43, "\r\n                        Dimenzije\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 44 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.AddMarkupContent(49, "<a href=\"katalozi/NORMAFIX RS_RSGU_RLGU.PDF\">\r\n    <h5>\r\n        <b>Katalog NORMAFIX® RSGU</b>\r\n    </h5>\r\n</a>\r\n\r\n\r\n");
#nullable restore
#line 53 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
 if (selectedTorro != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal fade");
            __builder.AddAttribute(53, "id", "productModal");
            __builder.AddAttribute(54, "tabindex", "-1");
            __builder.AddAttribute(55, "role", "dialog");
            __builder.AddAttribute(56, "aria-labelledby", "productTitle");
            __builder.AddAttribute(57, "aria-hidden", "true");
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(61, "role", "document");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "modal-content");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "modal-header");
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "h5");
            __builder.AddAttribute(70, "class", "modal-title");
            __builder.AddAttribute(71, "id", "productTitle");
            __builder.AddContent(72, 
#nullable restore
#line 59 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
                                                               selectedTorro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.AddMarkupContent(74, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-body");
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "card-dimension");
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "card-body-dimension");
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "img");
            __builder.AddAttribute(86, "class", "new");
            __builder.AddAttribute(87, "src", 
#nullable restore
#line 67 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
                                                   selectedTorro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 74 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\RSGUList.razor"
       
    Torro selectedTorro;
    string selectedTorroId;

    void SelectTorro(string torroId)
    {
        selectedTorroId = torroId;
        selectedTorro = TorroService.GetRSGU().First(x => x.id == torroId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591