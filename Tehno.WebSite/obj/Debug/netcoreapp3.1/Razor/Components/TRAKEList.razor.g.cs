#pragma checksum "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb24f3afb93354c5539af8ffba70b67101d5d15"
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
#line 1 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
using Tehno.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
using Tehno.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class TRAKEList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<strong>\r\n    <font style=\"font-size:16px;\">NORMA</font>\r\n    <font style=\"font-size:16px; color:#00b2b0;\">CONNECT®</font>\r\n</strong>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"https://www.bandimex.de/wp-content/uploads/2018/12/Bandimex_Catalog_english_2016.pdf\">\r\n    <h5 style=\"font-size:20px\">\r\n        <b>\r\n            Katalog BANDIMEX®\r\n        </b>\r\n    </h5>\r\n</a>\r\n<br>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"naziv\">\r\n    <strong>\r\n        <font style=\"font-size:15px;\">Trake i vezice</font>\r\n    </strong>\r\n</div>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-columns");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 24 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
     foreach (var torro in TorroService.GetTRAKE())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
         if (Convert.ToInt32(torro.id) <= 8)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 29 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                           torro.img

#line default
#line hidden
#nullable disable
            );
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
#line 32 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                            torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                  \r\n                    ");
            __builder.OpenElement(22, "h5");
            __builder.AddContent(23, 
#nullable restore
#line 35 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.din

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
#line 37 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
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
#line 39 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.materijal

#line default
#line hidden
#nullable disable
            );
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
#line 46 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
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
#line 53 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.AddMarkupContent(51, "<div class=\"naziv\">\r\n    <strong>\r\n        <font style=\"font-size:15px;\">Kopče</font>\r\n    </strong>\r\n</div>\r\n");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-columns");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 63 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
     foreach (var torro in TorroService.GetTRAKE())
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
         if (Convert.ToInt32(torro.id) >= 10 && Convert.ToInt32(torro.id) <= 17)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "card");
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "img");
            __builder.AddAttribute(60, "src", 
#nullable restore
#line 69 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                           torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(61, "class", "img-special");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card-body");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "h5");
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "b");
            __builder.AddContent(69, 
#nullable restore
#line 72 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                            torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "h5");
            __builder.AddContent(73, 
#nullable restore
#line 74 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.izvedba

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "h5");
            __builder.AddContent(76, 
#nullable restore
#line 75 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.materijal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "h5");
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.AddContent(80, 
#nullable restore
#line 77 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "h5");
            __builder.AddContent(84, 
#nullable restore
#line 79 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "card-footer");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "small");
            __builder.AddAttribute(91, "class", "text-mutted");
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                                          (e => SelectTorro(torro.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "data-toggle", "modal");
            __builder.AddAttribute(96, "data-target", "#productModal");
            __builder.AddAttribute(97, "class", "button");
            __builder.AddMarkupContent(98, "\r\n                            Dimenzije\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 90 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n");
            __builder.AddMarkupContent(104, "<div>\r\n    <strong>\r\n        <font style=\"font-size:15px;\">Alat</font>\r\n    </strong>\r\n</div>\r\n");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "card-columns");
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 100 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
     foreach (var torro in TorroService.GetTRAKE())
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
         if (Convert.ToInt32(torro.id) >= 18)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "            ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "card");
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "img");
            __builder.AddAttribute(113, "src", 
#nullable restore
#line 106 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                           torro.img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(114, "class", "img-special");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "card-body");
            __builder.AddMarkupContent(118, "\r\n                    ");
            __builder.OpenElement(119, "h5");
            __builder.AddMarkupContent(120, "\r\n                        ");
            __builder.AddContent(121, 
#nullable restore
#line 109 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.OpenElement(124, "h5");
            __builder.AddContent(125, 
#nullable restore
#line 111 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.izvedba

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.OpenElement(127, "h5");
            __builder.AddContent(128, 
#nullable restore
#line 112 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.materijal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.OpenElement(130, "h5");
            __builder.AddMarkupContent(131, "\r\n                        ");
            __builder.AddContent(132, 
#nullable restore
#line 114 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.opis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.OpenElement(135, "h5");
            __builder.AddContent(136, 
#nullable restore
#line 116 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                         torro.din

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
#nullable restore
#line 120 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 126 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
 if (selectedTorro != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(141, "    ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "modal fade");
            __builder.AddAttribute(144, "id", "productModal");
            __builder.AddAttribute(145, "tabindex", "-1");
            __builder.AddAttribute(146, "role", "dialog");
            __builder.AddAttribute(147, "aria-labelledby", "productTitle");
            __builder.AddAttribute(148, "aria-hidden", "true");
            __builder.AddMarkupContent(149, "\r\n        ");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(152, "role", "document");
            __builder.AddMarkupContent(153, "\r\n            ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "modal-content");
            __builder.AddMarkupContent(156, "\r\n                ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "modal-header");
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.OpenElement(160, "h5");
            __builder.AddAttribute(161, "class", "modal-title");
            __builder.AddAttribute(162, "id", "productTitle");
            __builder.AddContent(163, 
#nullable restore
#line 132 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                                                               selectedTorro.naziv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                    ");
            __builder.AddMarkupContent(165, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                ");
            __builder.OpenElement(167, "div");
            __builder.AddAttribute(168, "class", "modal-body");
            __builder.AddMarkupContent(169, "\r\n                    ");
            __builder.OpenElement(170, "div");
            __builder.AddAttribute(171, "class", "card-dimension");
            __builder.AddMarkupContent(172, "\r\n                        ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "card-body-dimension");
            __builder.AddMarkupContent(175, "\r\n                            ");
            __builder.OpenElement(176, "img");
            __builder.AddAttribute(177, "class", "new");
            __builder.AddAttribute(178, "src", 
#nullable restore
#line 140 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
                                                   selectedTorro.velicinaimg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n");
#nullable restore
#line 147 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 149 "C:\Users\ja\source\repos\Tehno\Tehno.WebSite\Components\TRAKEList.razor"
       
    Torro selectedTorro;
    string selectedTorroId;

    void SelectTorro(string torroId)
    {
        selectedTorroId = torroId;
        selectedTorro = TorroService.GetTRAKE().First(x => x.id == torroId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileTorroService TorroService { get; set; }
    }
}
#pragma warning restore 1591
