#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603be0d31b31eda6f2d70afd23446beefa66af8e"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class KLIZNIList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\r\n        <strong>\r\n            <font style=\"font-size:16px;\">NORMA</font>\r\n            <font style=\"font-size:16px; color:#00b2b0;\">CONNECT®</font>\r\n        </strong>\r\n    </div>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 13 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
         foreach (var torro in TorroService.GetKLIZNI())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 16 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
                           torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "width", "100px");
            __builder.AddAttribute(11, "height", "100px");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "h5");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "b");
            __builder.AddContent(19, 
#nullable restore
#line 19 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
                            torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "h5");
            __builder.AddContent(23, 
#nullable restore
#line 21 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
                         torro.materijal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "h5");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.AddContent(27, 
#nullable restore
#line 23 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
                         torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "h5");
            __builder.AddContent(31, 
#nullable restore
#line 25 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
                         torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card-footer");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "small");
            __builder.AddAttribute(38, "class", "text-mutted");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
                                          (e => SelectTorro(torro.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "data-toggle", "modal");
            __builder.AddAttribute(43, "data-target", "#productModal");
            __builder.AddAttribute(44, "class", "button");
            __builder.AddMarkupContent(45, "\r\n                            Dimenzije\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 38 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 43 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
     if (selectedTorro != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal fade");
            __builder.AddAttribute(55, "id", "productModal");
            __builder.AddAttribute(56, "tabindex", "-1");
            __builder.AddAttribute(57, "role", "dialog");
            __builder.AddAttribute(58, "aria-labelledby", "productTitle");
            __builder.AddAttribute(59, "aria-hidden", "true");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(63, "role", "document");
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "modal-content");
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "modal-header");
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "h5");
            __builder.AddAttribute(72, "class", "modal-title");
            __builder.AddAttribute(73, "id", "productTitle");
            __builder.AddContent(74, 
#nullable restore
#line 49 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
                                                                   selectedTorro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.AddMarkupContent(76, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                            <span aria-hidden=\"true\">&times;</span>\r\n                        </button>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "modal-body");
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "card-dimension");
            __builder.AddMarkupContent(83, "\r\n                            ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "card-body-dimension");
            __builder.AddMarkupContent(86, "\r\n                                ");
            __builder.OpenElement(87, "img");
            __builder.AddAttribute(88, "class", "new");
            __builder.AddAttribute(89, "src", 
#nullable restore
#line 57 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
                                                       selectedTorro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                            ");
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
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 64 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\KLIZNIList.razor"
           
        Torro selectedTorro;
        string selectedTorroId;

        void SelectTorro(string torroId)
        {
            selectedTorroId = torroId;
            selectedTorro = TorroService.GetKLIZNI().First(x => x.id == torroId);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591
