#pragma checksum "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92dce9ffccb17d0f3a50fea152d159cbf450ce24"
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
#line 5 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-ic-unit")]
    public partial class AddTblIcUnit : CanErp2.Pages.AddTblIcUnitComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CanErp2.Models.DbAtVdc2.TblIcUnit>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CanErp2.Models.DbAtVdc2.TblIcUnit>(
#line 12 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                    tblicunit

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                                           tblicunit != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblIcUnit>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblIcUnit>(this, 
#line 12 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
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
                    __builder3.AddAttribute(24, "Text", "Unit Text");
                    __builder3.AddAttribute(25, "Component", "UnitText");
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
#line 20 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                          25

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "UnitText");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                                                                                 tblicunit.UnitText

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblicunit.UnitText = __value, tblicunit.UnitText))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblicunit.UnitText));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "UnitText");
                    __builder3.AddAttribute(42, "Text", "UnitText is required");
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
                    __builder3.AddAttribute(55, "Text", "Unit Fk");
                    __builder3.AddAttribute(56, "Component", "Unit_FK");
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
#line 32 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                          20

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(66, "Name", "Unit_FK");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                                                                                 tblicunit.Unit_FK

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblicunit.Unit_FK = __value, tblicunit.Unit_FK))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblicunit.Unit_FK));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(71);
                    __builder3.AddAttribute(72, "Component", "Unit_FK");
                    __builder3.AddAttribute(73, "Text", "Unit_FK is required");
                    __builder3.AddAttribute(74, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "row");
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(83, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                    __builder3.AddAttribute(85, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 40 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(86, "Icon", "save");
                    __builder3.AddAttribute(87, "Text", "Save");
                    __builder3.AddAttribute(88, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 40 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(90);
                    __builder3.AddAttribute(91, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 42 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(92, "Text", "Cancel");
                    __builder3.AddAttribute(93, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 42 "F:\GitHub02\can-erp\radzen-app\server\Pages\AddTblIcUnit.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
