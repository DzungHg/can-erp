#pragma checksum "F:\GitHub02\can-erp\radzen-app\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d6fab42ae49c9e7d57512672135b79771930da"
// <auto-generated/>
#pragma warning disable 1591
namespace CanErp2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "F:\GitHub02\can-erp\radzen-app\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\GitHub02\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\GitHub02\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "F:\GitHub02\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "F:\GitHub02\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\radzen-app\server\_Imports.razor"
using CanErp2.Shared;

#line default
#line hidden
#line 3 "F:\GitHub02\can-erp\radzen-app\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "F:\GitHub02\can-erp\radzen-app\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "F:\GitHub02\can-erp\radzen-app\server\Shared\MainLayout.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    public partial class MainLayout : CanErp2.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row justify-content-start align-items-center");
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-6 d-flex align-items-center");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(13);
                __builder2.AddAttribute(14, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#line 13 "F:\GitHub02\can-erp\radzen-app\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(16);
                __builder2.AddAttribute(17, "Text", "CanErp2");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      ");
                __builder2.AddMarkupContent(20, "<div class=\"col-md-6 text-lg-right\">\n      </div>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(23);
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(26);
                __builder2.AddAttribute(27, "Name", "main");
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\n    ");
                    __builder3.AddContent(30, 
#line 26 "F:\GitHub02\can-erp\radzen-app\server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(31, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(33, (__value) => {
#line 23 "F:\GitHub02\can-erp\radzen-app\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(35);
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(38);
                __builder2.AddAttribute(39, "style", "height: 100%");
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(41, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(42);
                    __builder3.AddAttribute(43, "Text", "Đơn Hàng");
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(45, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(46);
                        __builder4.AddAttribute(47, "Path", "tbl-po-purchase-orders");
                        __builder4.AddAttribute(48, "Text", "DS Đơn");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\n          ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(51);
                    __builder3.AddAttribute(52, "Text", "Mua Hàng");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(54);
                    __builder3.AddAttribute(55, "Text", "Cài Đặt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(58, (__value) => {
#line 30 "F:\GitHub02\can-erp\radzen-app\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(60);
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(63);
                __builder2.AddAttribute(64, "Text", "CanErp2, Copyright Ⓒ 2020");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
