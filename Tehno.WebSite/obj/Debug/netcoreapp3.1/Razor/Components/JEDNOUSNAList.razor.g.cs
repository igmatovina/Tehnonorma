#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b7ebd2dc2131e0e7887318d7bb318d48f8652f8"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class JEDNOUSNAList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
     foreach (var torro in TorroService.GetJEDNOUSNA())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
         if (Convert.ToInt32(torro.id) <= 5)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "            ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-wider");
            __builder.AddMarkupContent(6, "\r\n                ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 12 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
                           torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "h5");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "b");
            __builder.AddContent(16, 
#nullable restore
#line 15 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
                            torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "h5");
            __builder.AddContent(20, 
#nullable restore
#line 17 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
                         torro.izvedba

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "h5");
            __builder.AddContent(23, 
#nullable restore
#line 18 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
                         torro.materijal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "h5");
            __builder.AddContent(26, 
#nullable restore
#line 19 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
                         torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "h5");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.AddContent(30, 
#nullable restore
#line 21 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
                         torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n\r\n                ");
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
#line 29 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
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
#line 36 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 42 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
 if (selectedTorro != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "modal fade");
            __builder.AddAttribute(54, "id", "productModal");
            __builder.AddAttribute(55, "tabindex", "-1");
            __builder.AddAttribute(56, "role", "dialog");
            __builder.AddAttribute(57, "aria-labelledby", "productTitle");
            __builder.AddAttribute(58, "aria-hidden", "true");
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(62, "role", "document");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-content");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-header");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "h5");
            __builder.AddAttribute(71, "class", "modal-title");
            __builder.AddAttribute(72, "id", "productTitle");
            __builder.AddContent(73, 
#nullable restore
#line 48 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
                                                               selectedTorro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.AddMarkupContent(75, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "modal-body");
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "card-dimension");
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "card-body-dimension");
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.OpenElement(86, "img");
            __builder.AddAttribute(87, "class", "new");
            __builder.AddAttribute(88, "src", 
#nullable restore
#line 56 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
                                                   selectedTorro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 63 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\JEDNOUSNAList.razor"
       
    Torro selectedTorro;
    string selectedTorroId;

    void SelectTorro(string torroId)
    {
        selectedTorroId = torroId;
        selectedTorro = TorroService.GetJEDNOUSNA().First(x => x.id == torroId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591