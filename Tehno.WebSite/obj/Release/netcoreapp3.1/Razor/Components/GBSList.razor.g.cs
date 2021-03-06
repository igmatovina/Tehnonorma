#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "764e311f1e024e9a7cfcc576549015890d345fe8"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class GBSList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
     foreach (var torro in TorroService.GetGBS())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 10 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
                       torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "h5");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "b");
            __builder.AddContent(16, 
#nullable restore
#line 13 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
                        torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "h5");
            __builder.AddContent(20, 
#nullable restore
#line 15 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
                     torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "h5");
            __builder.AddContent(23, 
#nullable restore
#line 16 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
                     torro.materijal

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
#line 18 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
                     torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card-footer");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "small");
            __builder.AddAttribute(35, "class", "text-mutted");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
                                      (e => SelectTorro(torro.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "data-toggle", "modal");
            __builder.AddAttribute(40, "data-target", "#productModal");
            __builder.AddAttribute(41, "class", "button");
            __builder.AddMarkupContent(42, "\r\n                        Dimenzije\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 33 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 39 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
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
#line 45 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
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
#line 53 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
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
#line 60 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\GBSList.razor"
       
    Torro selectedTorro;
    string selectedTorroId;

    void SelectTorro(string torroId)
    {
        selectedTorroId = torroId;
        selectedTorro = TorroService.GetGBS().First(x => x.id == torroId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591
