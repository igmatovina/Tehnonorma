#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bb0f6ea669500897a3ec03360f992049a31673b"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class FBSList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<strong>\r\n        <font style=\"font-size:16px;\">NORMA</font>\r\n        <font style=\"font-size:16px; color:#00b2b0;\">CLAMP® FBS®</font>\r\n    </strong>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 10 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
     foreach (var torro in TorroService.GetFBS())
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
#line 14 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                       torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "width", "100px");
            __builder.AddAttribute(11, "height", "100px");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "h5");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "b");
            __builder.AddContent(19, 
#nullable restore
#line 17 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                        torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "h5");
            __builder.AddContent(23, 
#nullable restore
#line 19 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                     torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "h5");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.AddContent(27, 
#nullable restore
#line 21 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                     torro.izvedba

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "h5");
            __builder.AddContent(31, 
#nullable restore
#line 23 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                     torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                ");
            __builder.OpenElement(33, "h5");
            __builder.AddContent(34, 
#nullable restore
#line 25 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                     torro.materijal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card-footer");
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "small");
            __builder.AddAttribute(41, "class", "text-mutted");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", 
#nullable restore
#line 33 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                              torro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "class", "button");
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.AddMarkupContent(47, "<h5><b>Katalog</b></h5>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 39 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 45 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
 if (selectedTorro != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal fade");
            __builder.AddAttribute(56, "id", "productModal");
            __builder.AddAttribute(57, "tabindex", "-1");
            __builder.AddAttribute(58, "role", "dialog");
            __builder.AddAttribute(59, "aria-labelledby", "productTitle");
            __builder.AddAttribute(60, "aria-hidden", "true");
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(64, "role", "document");
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "modal-content");
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "modal-header");
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "h5");
            __builder.AddAttribute(73, "class", "modal-title");
            __builder.AddAttribute(74, "id", "productTitle");
            __builder.AddContent(75, 
#nullable restore
#line 51 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                                                               selectedTorro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.AddMarkupContent(77, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "modal-body");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "card-dimension");
            __builder.AddMarkupContent(84, "\r\n                        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "card-body-dimension");
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.OpenElement(88, "img");
            __builder.AddAttribute(89, "class", "new");
            __builder.AddAttribute(90, "src", 
#nullable restore
#line 59 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
                                                   selectedTorro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 66 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\FBSList.razor"
       
    Torro selectedTorro;
    string selectedTorroId;

    void SelectTorro(string torroId)
    {
        selectedTorroId = torroId;
        selectedTorro = TorroService.GetFBS().First(x => x.id == torroId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591
