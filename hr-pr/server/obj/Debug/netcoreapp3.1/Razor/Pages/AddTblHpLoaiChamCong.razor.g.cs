#pragma checksum "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613bd4d87096181b7220dffd2ef5b5391384ee2f"
// <auto-generated/>
#pragma warning disable 1591
namespace CanErpHp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "F:\GitHub02\can-erp\hr-pr\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\GitHub02\can-erp\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\GitHub02\can-erp\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "F:\GitHub02\can-erp\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "F:\GitHub02\can-erp\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\hr-pr\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\hr-pr\server\_Imports.razor"
using CanErpHp.Shared;

#line default
#line hidden
#line 5 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
using CanErpHp.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-hp-loai-cham-cong")]
    public partial class AddTblHpLoaiChamCong : CanErpHp.Pages.AddTblHpLoaiChamCongComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErpHp.Models.DbAtVdc2.TblHpLoaiChamCong>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErpHp.Models.DbAtVdc2.TblHpLoaiChamCong>(
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                   tblhploaichamcong

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                                                 tblhploaichamcong != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHp.Models.DbAtVdc2.TblHpLoaiChamCong>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHp.Models.DbAtVdc2.TblHpLoaiChamCong>(this, 
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
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
                    __builder3.AddAttribute(24, "Text", "Loai Cham Cong Id");
                    __builder3.AddAttribute(25, "Component", "LoaiChamCong_ID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 20 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                          3

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "LoaiChamCong_ID");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                                                                                tblhploaichamcong.LoaiChamCong_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.LoaiChamCong_ID = __value, tblhploaichamcong.LoaiChamCong_ID))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhploaichamcong.LoaiChamCong_ID));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "LoaiChamCong_ID");
                    __builder3.AddAttribute(42, "Text", "LoaiChamCong_ID is required");
                    __builder3.AddAttribute(43, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(49, "class", "row");
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-3");
                    __builder3.AddMarkupContent(53, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", "Loai Cham Cong Name");
                    __builder3.AddAttribute(56, "Component", "LoaiChamCong_Name");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\n              ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-9");
                    __builder3.AddMarkupContent(62, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                    __builder3.AddAttribute(64, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 32 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                          65

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "width: 100%");
                    __builder3.AddAttribute(66, "Name", "LoaiChamCong_Name");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                                                                 tblhploaichamcong.LoaiChamCong_Name

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.LoaiChamCong_Name = __value, tblhploaichamcong.LoaiChamCong_Name))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhploaichamcong.LoaiChamCong_Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddAttribute(74, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(75, "class", "row");
                    __builder3.AddMarkupContent(76, "\n              ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col-md-3");
                    __builder3.AddMarkupContent(79, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(80);
                    __builder3.AddAttribute(81, "Text", "Ty Le Huong Luong");
                    __builder3.AddAttribute(82, "Component", "TyLeHuongLuong");
                    __builder3.AddAttribute(83, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-9");
                    __builder3.AddMarkupContent(88, "\n                ");
                    __Blazor.CanErpHp.Pages.AddTblHpLoaiChamCong.TypeInference.CreateRadzenNumeric_0(__builder3, 89, 90, "width: 100%", 91, "TyLeHuongLuong", 92, 
#line 42 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                                                  tblhploaichamcong.TyLeHuongLuong

#line default
#line hidden
                    , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.TyLeHuongLuong = __value, tblhploaichamcong.TyLeHuongLuong)), 94, () => tblhploaichamcong.TyLeHuongLuong);
                    __builder3.AddMarkupContent(95, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(100, "class", "row");
                    __builder3.AddMarkupContent(101, "\n              ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "col-md-3");
                    __builder3.AddMarkupContent(104, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(105);
                    __builder3.AddAttribute(106, "Text", "Huong Luong Co Ban");
                    __builder3.AddAttribute(107, "Component", "HuongLuongCoBan");
                    __builder3.AddAttribute(108, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-9");
                    __builder3.AddMarkupContent(113, "\n                ");
                    __Blazor.CanErpHp.Pages.AddTblHpLoaiChamCong.TypeInference.CreateRadzenCheckBox_1(__builder3, 114, 115, 
#line 52 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                          true

#line default
#line hidden
                    , 116, "HuongLuongCoBan", 117, 
#line 52 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                                               tblhploaichamcong.HuongLuongCoBan

#line default
#line hidden
                    , 118, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.HuongLuongCoBan = __value, tblhploaichamcong.HuongLuongCoBan)), 119, () => tblhploaichamcong.HuongLuongCoBan);
                    __builder3.AddMarkupContent(120, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(122, "\n            ");
                    __builder3.OpenElement(123, "div");
                    __builder3.AddAttribute(124, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(125, "class", "row");
                    __builder3.AddMarkupContent(126, "\n              ");
                    __builder3.OpenElement(127, "div");
                    __builder3.AddAttribute(128, "class", "col-md-3");
                    __builder3.AddMarkupContent(129, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(130);
                    __builder3.AddAttribute(131, "Text", "Description");
                    __builder3.AddAttribute(132, "Component", "Description");
                    __builder3.AddAttribute(133, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\n              ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "class", "col-md-9");
                    __builder3.AddMarkupContent(138, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(139);
                    __builder3.AddAttribute(140, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 62 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                          250

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(141, "style", "width: 100%");
                    __builder3.AddAttribute(142, "Name", "Description");
                    __builder3.AddAttribute(143, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 62 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                                                                  tblhploaichamcong.Description

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(144, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.Description = __value, tblhploaichamcong.Description))));
                    __builder3.AddAttribute(145, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhploaichamcong.Description));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(148, "\n            ");
                    __builder3.OpenElement(149, "div");
                    __builder3.AddAttribute(150, "class", "row");
                    __builder3.AddMarkupContent(151, "\n              ");
                    __builder3.OpenElement(152, "div");
                    __builder3.AddAttribute(153, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(154, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(155);
                    __builder3.AddAttribute(156, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 68 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(157, "Icon", "save");
                    __builder3.AddAttribute(158, "Text", "Save");
                    __builder3.AddAttribute(159, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 68 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(160, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(161);
                    __builder3.AddAttribute(162, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 70 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(163, "Text", "Cancel");
                    __builder3.AddAttribute(164, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 70 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpLoaiChamCong.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(165, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(166, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(167, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(168, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(169, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(170, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CanErpHp.Pages.AddTblHpLoaiChamCong
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenCheckBox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "TriState", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
