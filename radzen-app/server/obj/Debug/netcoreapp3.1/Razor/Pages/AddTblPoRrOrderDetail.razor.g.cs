#pragma checksum "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b558ebf4c527652f4a36f2b96be6a622f5580d8d"
// <auto-generated/>
#pragma warning disable 1591
namespace CanErp2.Pages
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
#line 5 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-po-rr-order-detail")]
    public partial class AddTblPoRrOrderDetail : CanErp2.Pages.AddTblPoRrOrderDetailComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>(
#line 12 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                    tblporrorderdetail

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                    tblporrorderdetail != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblPoRrOrderDetail>(this, 
#line 12 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                                                                                             Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "Tbl Po Rec Report");
                    __builder3.AddAttribute(25, "Component", "RR_FK");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.CanErp2.Pages.AddTblPoRrOrderDetail.TypeInference.CreateRadzenDropDown_0(__builder3, 32, 33, 
#line 20 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                        getTblPoRecReportsResult

#line default
#line hidden
                    , 34, "PO_ID", 35, "RR_No", 36, "Choose TblPoRecReport", 37, "display: block; width: 100%", 38, "RR_FK", 39, 
#line 20 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                                                                                                                                     tblporrorderdetail.RR_FK

#line default
#line hidden
                    , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblporrorderdetail.RR_FK = __value, tblporrorderdetail.RR_FK)), 41, () => tblporrorderdetail.RR_FK);
                    __builder3.AddMarkupContent(42, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(43);
                    __builder3.AddAttribute(44, "Component", "RR_FK");
                    __builder3.AddAttribute(45, "Text", "RR_FK is required");
                    __builder3.AddAttribute(46, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(52, "class", "row");
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-3");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(57);
                    __builder3.AddAttribute(58, "Text", "Tbl Ic Inventory");
                    __builder3.AddAttribute(59, "Component", "Inventory_FK");
                    __builder3.AddAttribute(60, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\n              ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "col-md-9");
                    __builder3.AddMarkupContent(65, "\n                ");
                    __Blazor.CanErp2.Pages.AddTblPoRrOrderDetail.TypeInference.CreateRadzenDropDown_1(__builder3, 66, 67, 
#line 32 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                        getTblIcInventoriesResult

#line default
#line hidden
                    , 68, "Warehouse_FK", 69, "Inventory_SEQ", 70, "Choose TblIcInventory", 71, "display: block; width: 100%", 72, "Inventory_FK", 73, 
#line 32 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                                                                                                                                                     tblporrorderdetail.Inventory_FK

#line default
#line hidden
                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblporrorderdetail.Inventory_FK = __value, tblporrorderdetail.Inventory_FK)), 75, () => tblporrorderdetail.Inventory_FK);
                    __builder3.AddMarkupContent(76, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(77);
                    __builder3.AddAttribute(78, "Component", "Inventory_FK");
                    __builder3.AddAttribute(79, "Text", "Inventory_FK is required");
                    __builder3.AddAttribute(80, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(86, "class", "row");
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "col-md-3");
                    __builder3.AddMarkupContent(90, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(91);
                    __builder3.AddAttribute(92, "Text", "Unit Price");
                    __builder3.AddAttribute(93, "Component", "Unit_Price");
                    __builder3.AddAttribute(94, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\n              ");
                    __builder3.OpenElement(97, "div");
                    __builder3.AddAttribute(98, "class", "col-md-9");
                    __builder3.AddMarkupContent(99, "\n                ");
                    __Blazor.CanErp2.Pages.AddTblPoRrOrderDetail.TypeInference.CreateRadzenNumeric_2(__builder3, 100, 101, "width: 100%", 102, "Unit_Price", 103, 
#line 44 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                  tblporrorderdetail.Unit_Price

#line default
#line hidden
                    , 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblporrorderdetail.Unit_Price = __value, tblporrorderdetail.Unit_Price)), 105, () => tblporrorderdetail.Unit_Price);
                    __builder3.AddMarkupContent(106, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(108, "\n            ");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(111, "class", "row");
                    __builder3.AddMarkupContent(112, "\n              ");
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "class", "col-md-3");
                    __builder3.AddMarkupContent(115, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(116);
                    __builder3.AddAttribute(117, "Text", "Qty Ordered");
                    __builder3.AddAttribute(118, "Component", "QtyOrdered");
                    __builder3.AddAttribute(119, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\n              ");
                    __builder3.OpenElement(122, "div");
                    __builder3.AddAttribute(123, "class", "col-md-9");
                    __builder3.AddMarkupContent(124, "\n                ");
                    __Blazor.CanErp2.Pages.AddTblPoRrOrderDetail.TypeInference.CreateRadzenNumeric_3(__builder3, 125, 126, "width: 100%", 127, "QtyOrdered", 128, 
#line 54 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                  tblporrorderdetail.QtyOrdered

#line default
#line hidden
                    , 129, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblporrorderdetail.QtyOrdered = __value, tblporrorderdetail.QtyOrdered)), 130, () => tblporrorderdetail.QtyOrdered);
                    __builder3.AddMarkupContent(131, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\n            ");
                    __builder3.OpenElement(134, "div");
                    __builder3.AddAttribute(135, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(136, "class", "row");
                    __builder3.AddMarkupContent(137, "\n              ");
                    __builder3.OpenElement(138, "div");
                    __builder3.AddAttribute(139, "class", "col-md-3");
                    __builder3.AddMarkupContent(140, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(141);
                    __builder3.AddAttribute(142, "Text", "Qty Received");
                    __builder3.AddAttribute(143, "Component", "QtyReceived");
                    __builder3.AddAttribute(144, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(145, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\n              ");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "col-md-9");
                    __builder3.AddMarkupContent(149, "\n                ");
                    __Blazor.CanErp2.Pages.AddTblPoRrOrderDetail.TypeInference.CreateRadzenNumeric_4(__builder3, 150, 151, "width: 100%", 152, "QtyReceived", 153, 
#line 64 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                  tblporrorderdetail.QtyReceived

#line default
#line hidden
                    , 154, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblporrorderdetail.QtyReceived = __value, tblporrorderdetail.QtyReceived)), 155, () => tblporrorderdetail.QtyReceived);
                    __builder3.AddMarkupContent(156, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(157, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(158, "\n            ");
                    __builder3.OpenElement(159, "div");
                    __builder3.AddAttribute(160, "class", "row");
                    __builder3.AddMarkupContent(161, "\n              ");
                    __builder3.OpenElement(162, "div");
                    __builder3.AddAttribute(163, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(164, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(165);
                    __builder3.AddAttribute(166, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 70 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(167, "Icon", "save");
                    __builder3.AddAttribute(168, "Text", "Save");
                    __builder3.AddAttribute(169, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 70 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(170, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(171);
                    __builder3.AddAttribute(172, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 72 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(173, "Text", "Cancel");
                    __builder3.AddAttribute(174, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 72 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(175, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(176, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(177, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(178, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CanErp2.Pages.AddTblPoRrOrderDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
