#pragma checksum "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daa1119351effcfbf3ff117f9734ef3696245344"
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
#line 5 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
using CanErpHp.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-hp-bac")]
    public partial class AddTblHpBac : CanErpHp.Pages.AddTblHpBacComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErpHp.Models.DbAtVdc2.TblHpBac>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErpHp.Models.DbAtVdc2.TblHpBac>(
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                   tblhpbac

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                                        tblhpbac != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHp.Models.DbAtVdc2.TblHpBac>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHp.Models.DbAtVdc2.TblHpBac>(this, 
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
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
                    __builder3.AddAttribute(24, "Text", "Bac Id");
                    __builder3.AddAttribute(25, "Component", "Bac_ID");
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
#line 20 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                          2

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "Bac_ID");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                                                                                tblhpbac.Bac_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpbac.Bac_ID = __value, tblhpbac.Bac_ID))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhpbac.Bac_ID));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "Bac_ID");
                    __builder3.AddAttribute(42, "Text", "Bac_ID is required");
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
                    __builder3.AddAttribute(55, "Text", "Bac Name");
                    __builder3.AddAttribute(56, "Component", "Bac_Name");
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
#line 32 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                          35

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "width: 100%");
                    __builder3.AddAttribute(66, "Name", "Bac_Name");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                                                                 tblhpbac.Bac_Name

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpbac.Bac_Name = __value, tblhpbac.Bac_Name))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhpbac.Bac_Name));
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
                    __builder3.AddAttribute(81, "Text", "He So Luong");
                    __builder3.AddAttribute(82, "Component", "HeSoLuong");
                    __builder3.AddAttribute(83, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-9");
                    __builder3.AddMarkupContent(88, "\n                ");
                    __Blazor.CanErpHp.Pages.AddTblHpBac.TypeInference.CreateRadzenNumeric_0(__builder3, 89, 90, "width: 100%", 91, "HeSoLuong", 92, 
#line 42 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                                                  tblhpbac.HeSoLuong

#line default
#line hidden
                    , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpbac.HeSoLuong = __value, tblhpbac.HeSoLuong)), 94, () => tblhpbac.HeSoLuong);
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
                    __builder3.AddAttribute(106, "Text", "Tbl Hp Ngach");
                    __builder3.AddAttribute(107, "Component", "Ngach_FK");
                    __builder3.AddAttribute(108, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-9");
                    __builder3.AddMarkupContent(113, "\n                ");
                    __Blazor.CanErpHp.Pages.AddTblHpBac.TypeInference.CreateRadzenDropDown_1(__builder3, 114, 115, 
#line 52 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                       getTblHpNgachesResult

#line default
#line hidden
                    , 116, "Ngach_Name", 117, "Ngach_ID", 118, "Choose TblHpNgach", 119, "width: 100%", 120, "Ngach_FK", 121, 
#line 52 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                                                                                                                                                                    tblhpbac.Ngach_FK

#line default
#line hidden
                    , 122, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpbac.Ngach_FK = __value, tblhpbac.Ngach_FK)), 123, () => tblhpbac.Ngach_FK);
                    __builder3.AddMarkupContent(124, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(126, "\n            ");
                    __builder3.OpenElement(127, "div");
                    __builder3.AddAttribute(128, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(129, "class", "row");
                    __builder3.AddMarkupContent(130, "\n              ");
                    __builder3.OpenElement(131, "div");
                    __builder3.AddAttribute(132, "class", "col-md-3");
                    __builder3.AddMarkupContent(133, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(134);
                    __builder3.AddAttribute(135, "Text", "Description");
                    __builder3.AddAttribute(136, "Component", "Description");
                    __builder3.AddAttribute(137, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(138, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(139, "\n              ");
                    __builder3.OpenElement(140, "div");
                    __builder3.AddAttribute(141, "class", "col-md-9");
                    __builder3.AddMarkupContent(142, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(143);
                    __builder3.AddAttribute(144, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 62 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                          250

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(145, "style", "width: 100%");
                    __builder3.AddAttribute(146, "Name", "Description");
                    __builder3.AddAttribute(147, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 62 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                                                                  tblhpbac.Description

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(148, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhpbac.Description = __value, tblhpbac.Description))));
                    __builder3.AddAttribute(149, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhpbac.Description));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(150, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(151, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(152, "\n            ");
                    __builder3.OpenElement(153, "div");
                    __builder3.AddAttribute(154, "class", "row");
                    __builder3.AddMarkupContent(155, "\n              ");
                    __builder3.OpenElement(156, "div");
                    __builder3.AddAttribute(157, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(158, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(159);
                    __builder3.AddAttribute(160, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 68 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(161, "Icon", "save");
                    __builder3.AddAttribute(162, "Text", "Save");
                    __builder3.AddAttribute(163, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 68 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(164, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(165);
                    __builder3.AddAttribute(166, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 70 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(167, "Text", "Cancel");
                    __builder3.AddAttribute(168, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 70 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpBac.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(169, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(170, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(171, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(172, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CanErpHp.Pages.AddTblHpBac
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
    }
}
#pragma warning restore 1591
