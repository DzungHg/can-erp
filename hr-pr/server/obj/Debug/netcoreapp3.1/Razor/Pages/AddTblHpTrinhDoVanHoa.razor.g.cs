#pragma checksum "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cadfacb7f9a3aca0f7cfa66924f3066a74de50ee"
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
#line 5 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
using CanErpHp.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-hp-trinh-do-van-hoa")]
    public partial class AddTblHpTrinhDoVanHoa : CanErpHp.Pages.AddTblHpTrinhDoVanHoaComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErpHp.Models.DbAtVdc2.TblHpTrinhDoVanHoa>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErpHp.Models.DbAtVdc2.TblHpTrinhDoVanHoa>(
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                   tblhptrinhdovanhoa

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                                                  tblhptrinhdovanhoa != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHp.Models.DbAtVdc2.TblHpTrinhDoVanHoa>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHp.Models.DbAtVdc2.TblHpTrinhDoVanHoa>(this, 
#line 12 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
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
                    __builder3.AddAttribute(24, "Text", "Trinh Do Van Hoa Id");
                    __builder3.AddAttribute(25, "Component", "TrinhDoVanHoa_ID");
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
#line 20 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                          2

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "TrinhDoVanHoa_ID");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                                                                                tblhptrinhdovanhoa.TrinhDoVanHoa_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhptrinhdovanhoa.TrinhDoVanHoa_ID = __value, tblhptrinhdovanhoa.TrinhDoVanHoa_ID))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhptrinhdovanhoa.TrinhDoVanHoa_ID));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "TrinhDoVanHoa_ID");
                    __builder3.AddAttribute(42, "Text", "TrinhDoVanHoa_ID is required");
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
                    __builder3.AddAttribute(55, "Text", "Trinh Do Van Hoa Name");
                    __builder3.AddAttribute(56, "Component", "TrinhDoVanHoa_Name");
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
#line 32 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                          20

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "width: 100%");
                    __builder3.AddAttribute(66, "Name", "TrinhDoVanHoa_Name");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                                                                 tblhptrinhdovanhoa.TrinhDoVanHoa_Name

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhptrinhdovanhoa.TrinhDoVanHoa_Name = __value, tblhptrinhdovanhoa.TrinhDoVanHoa_Name))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhptrinhdovanhoa.TrinhDoVanHoa_Name));
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
                    __builder3.AddAttribute(81, "Text", "Description");
                    __builder3.AddAttribute(82, "Component", "Description");
                    __builder3.AddAttribute(83, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-9");
                    __builder3.AddMarkupContent(88, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(89);
                    __builder3.AddAttribute(90, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                          250

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(91, "style", "width: 100%");
                    __builder3.AddAttribute(92, "Name", "Description");
                    __builder3.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 42 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                                                                  tblhptrinhdovanhoa.Description

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblhptrinhdovanhoa.Description = __value, tblhptrinhdovanhoa.Description))));
                    __builder3.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblhptrinhdovanhoa.Description));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\n            ");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "row");
                    __builder3.AddMarkupContent(101, "\n              ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(104, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(105);
                    __builder3.AddAttribute(106, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 48 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(107, "Icon", "save");
                    __builder3.AddAttribute(108, "Text", "Save");
                    __builder3.AddAttribute(109, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 48 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(110, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(111);
                    __builder3.AddAttribute(112, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 50 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(113, "Text", "Cancel");
                    __builder3.AddAttribute(114, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 50 "F:\GitHub02\can-erp\hr-pr\server\Pages\AddTblHpTrinhDoVanHoa.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(118, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
