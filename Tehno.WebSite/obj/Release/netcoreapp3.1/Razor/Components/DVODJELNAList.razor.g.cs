#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffc574c3cbdd819a7f8e0e3a3c8f7d22a4d6b616"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class DVODJELNAList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<strong>\r\n        <font style=\"font-size:16px;\">NORMA</font>\r\n        <font style=\"font-size:16px; color:#00b2b0;\">CONNECT®</font>\r\n    </strong>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 10 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
     foreach (var torro in TorroService.GetDVODJELNA())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 13 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
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
#line 16 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
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
#line 19 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
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
#line 21 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
                     torro.materijal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "h5");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.AddContent(30, 
#nullable restore
#line 23 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
                     torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "h5");
            __builder.AddContent(34, 
#nullable restore
#line 25 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
                     torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card-footer");
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "small");
            __builder.AddAttribute(41, "class", "text-mutted");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
                                      (e => SelectTorro(torro.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "data-toggle", "modal");
            __builder.AddAttribute(46, "data-target", "#productModal");
            __builder.AddAttribute(47, "class", "button");
            __builder.AddMarkupContent(48, "\r\n                        Dimenzije\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 38 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n\r\n");
#nullable restore
#line 42 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
 if (selectedTorro != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal fade");
            __builder.AddAttribute(57, "id", "productModal");
            __builder.AddAttribute(58, "tabindex", "-1");
            __builder.AddAttribute(59, "role", "dialog");
            __builder.AddAttribute(60, "aria-labelledby", "productTitle");
            __builder.AddAttribute(61, "aria-hidden", "true");
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(65, "role", "document");
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-content");
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "modal-header");
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "h5");
            __builder.AddAttribute(74, "class", "modal-title");
            __builder.AddAttribute(75, "id", "productTitle");
            __builder.AddContent(76, 
#nullable restore
#line 48 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
                                                               selectedTorro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.AddMarkupContent(78, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "modal-body");
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "card-dimension");
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "card-body-dimension");
            __builder.AddMarkupContent(88, "\r\n                            ");
            __builder.OpenElement(89, "img");
            __builder.AddAttribute(90, "class", "new");
            __builder.AddAttribute(91, "src", 
#nullable restore
#line 56 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
                                                   selectedTorro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 63 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\DVODJELNAList.razor"
       
    Torro selectedTorro;
    string selectedTorroId;

    void SelectTorro(string torroId)
    {
        selectedTorroId = torroId;
        selectedTorro = TorroService.GetDVODJELNA().First(x => x.id == torroId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591
