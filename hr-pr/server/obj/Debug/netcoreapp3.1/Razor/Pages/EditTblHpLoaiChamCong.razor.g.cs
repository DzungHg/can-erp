#pragma checksum "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91ac4ee4df88483feb32c0e5adfc2d08ac835521"
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
#line 5 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
using CanErpHp.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-hp-loai-cham-cong/{LoaiChamCong_ID}")]
    public partial class EditTblHpLoaiChamCong : CanErpHp.Pages.EditTblHpLoaiChamCongComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "style", true);
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "\n      ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-9");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                __builder2.AddAttribute(12, "style", "font-weight: bold");
                __builder2.AddAttribute(13, "Text", "Item no longer available.");
                __builder2.AddAttribute(14, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                           !canEdit

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n      ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-3");
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(20);
                __builder2.AddAttribute(21, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Text", "Close");
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                                              !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                                                                 CloseButtonClick

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddMarkupContent(31, "\n      ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-12");
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErpHp.Models.DbAtVdc2.TblHpLoaiChamCong>>(35);
                __builder2.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErpHp.Models.DbAtVdc2.TblHpLoaiChamCong>(
#line 22 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                      tblhploaichamcong

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                                                    tblhploaichamcong != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHp.Models.DbAtVdc2.TblHpLoaiChamCong>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHp.Models.DbAtVdc2.TblHpLoaiChamCong>(this, 
#line 22 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                                                                                                    Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                    __builder3.AddAttribute(49, "Text", "Loai Cham Cong Id");
                    __builder3.AddAttribute(50, "Component", "LoaiChamCong_ID");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(57);
                    __builder3.AddAttribute(58, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                          3

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(59, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(60, "Name", "LoaiChamCong_ID");
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                                tblhploaichamcong.LoaiChamCong_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.LoaiChamCong_ID = __value, tblhploaichamcong.LoaiChamCong_ID))));
                    __builder3.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhploaichamcong.LoaiChamCong_ID));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(65);
                    __builder3.AddAttribute(66, "Component", "LoaiChamCong_ID");
                    __builder3.AddAttribute(67, "Text", "LoaiChamCong_ID is required");
                    __builder3.AddAttribute(68, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(74, "class", "row");
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col-md-3");
                    __builder3.AddMarkupContent(78, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(79);
                    __builder3.AddAttribute(80, "Text", "Loai Cham Cong Name");
                    __builder3.AddAttribute(81, "Component", "LoaiChamCong_Name");
                    __builder3.AddAttribute(82, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.OpenElement(85, "div");
                    __builder3.AddAttribute(86, "class", "col-md-9");
                    __builder3.AddMarkupContent(87, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(88);
                    __builder3.AddAttribute(89, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                          65

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(90, "style", "width: 100%");
                    __builder3.AddAttribute(91, "Name", "LoaiChamCong_Name");
                    __builder3.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 42 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                 tblhploaichamcong.LoaiChamCong_Name

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.LoaiChamCong_Name = __value, tblhploaichamcong.LoaiChamCong_Name))));
                    __builder3.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhploaichamcong.LoaiChamCong_Name));
                    __builder3.CloseComponent();
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
                    __builder3.AddAttribute(106, "Text", "Ty Le Huong Luong");
                    __builder3.AddAttribute(107, "Component", "TyLeHuongLuong");
                    __builder3.AddAttribute(108, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-9");
                    __builder3.AddMarkupContent(113, "\n                ");
                    __Blazor.CanErpHp.Pages.EditTblHpLoaiChamCong.TypeInference.CreateRadzenNumeric_0(__builder3, 114, 115, "width: 100%", 116, "TyLeHuongLuong", 117, 
#line 52 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                  tblhploaichamcong.TyLeHuongLuong

#line default
#line hidden
                    , 118, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.TyLeHuongLuong = __value, tblhploaichamcong.TyLeHuongLuong)), 119, () => tblhploaichamcong.TyLeHuongLuong);
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
                    __builder3.AddAttribute(131, "Text", "Huong Luong Co Ban");
                    __builder3.AddAttribute(132, "Component", "HuongLuongCoBan");
                    __builder3.AddAttribute(133, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\n              ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "class", "col-md-9");
                    __builder3.AddMarkupContent(138, "\n                ");
                    __Blazor.CanErpHp.Pages.EditTblHpLoaiChamCong.TypeInference.CreateRadzenCheckBox_1(__builder3, 139, 140, 
#line 62 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                          true

#line default
#line hidden
                    , 141, "HuongLuongCoBan", 142, 
#line 62 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                               tblhploaichamcong.HuongLuongCoBan

#line default
#line hidden
                    , 143, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.HuongLuongCoBan = __value, tblhploaichamcong.HuongLuongCoBan)), 144, () => tblhploaichamcong.HuongLuongCoBan);
                    __builder3.AddMarkupContent(145, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\n            ");
                    __builder3.OpenElement(148, "div");
                    __builder3.AddAttribute(149, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(150, "class", "row");
                    __builder3.AddMarkupContent(151, "\n              ");
                    __builder3.OpenElement(152, "div");
                    __builder3.AddAttribute(153, "class", "col-md-3");
                    __builder3.AddMarkupContent(154, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(155);
                    __builder3.AddAttribute(156, "Text", "Description");
                    __builder3.AddAttribute(157, "Component", "Description");
                    __builder3.AddAttribute(158, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(159, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(160, "\n              ");
                    __builder3.OpenElement(161, "div");
                    __builder3.AddAttribute(162, "class", "col-md-9");
                    __builder3.AddMarkupContent(163, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(164);
                    __builder3.AddAttribute(165, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 72 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                          250

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(166, "style", "width: 100%");
                    __builder3.AddAttribute(167, "Name", "Description");
                    __builder3.AddAttribute(168, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 72 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                  tblhploaichamcong.Description

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(169, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhploaichamcong.Description = __value, tblhploaichamcong.Description))));
                    __builder3.AddAttribute(170, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhploaichamcong.Description));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(171, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(172, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(173, "\n            ");
                    __builder3.OpenElement(174, "div");
                    __builder3.AddAttribute(175, "class", "row");
                    __builder3.AddMarkupContent(176, "\n              ");
                    __builder3.OpenElement(177, "div");
                    __builder3.AddAttribute(178, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(179, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(180);
                    __builder3.AddAttribute(181, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 78 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(182, "Icon", "save");
                    __builder3.AddAttribute(183, "Text", "Save");
                    __builder3.AddAttribute(184, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 78 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(185, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(186);
                    __builder3.AddAttribute(187, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 80 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(188, "Text", "Cancel");
                    __builder3.AddAttribute(189, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 80 "F:\GitHub02\can-erp\hr-pr\server\Pages\EditTblHpLoaiChamCong.razor"
                                                                                    Button3Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(190, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(191, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(192, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(193, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(194, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CanErpHp.Pages.EditTblHpLoaiChamCong
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
