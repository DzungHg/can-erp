#pragma checksum "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a76c3969549201913c267068779a9435cf0914c"
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
#line 1 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\_Imports.razor"
using CanErp2.Shared;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-account-payables")]
    public partial class TblPoAccountPayables : CanErp2.Pages.TblPoAccountPayablesComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Tbl Po Account Payables");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                                     getTblPoAccountPayablesResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                                                                    Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(28);
                    __builder3.AddAttribute(29, "Property", "AP_No");
                    __builder3.AddAttribute(30, "Title", "AP No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(32);
                    __builder3.AddAttribute(33, "Property", "Vendor_FK");
                    __builder3.AddAttribute(34, "SortProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(35, "FilterProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(36, "Title", "Tbl Po Vendor");
                    __builder3.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(38, "\n              ");
                        __builder4.AddContent(39, 
#line 22 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                data.TblPoVendor?.LastName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(40, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(42);
                    __builder3.AddAttribute(43, "Property", "Transact_No");
                    __builder3.AddAttribute(44, "Title", "Transact No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(46);
                    __builder3.AddAttribute(47, "Property", "Record_Code");
                    __builder3.AddAttribute(48, "Title", "Record Code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(50);
                    __builder3.AddAttribute(51, "Property", "PO_No");
                    __builder3.AddAttribute(52, "Title", "PO No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(54);
                    __builder3.AddAttribute(55, "Property", "Transact_Date");
                    __builder3.AddAttribute(56, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(57, "Title", "Transact Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(59);
                    __builder3.AddAttribute(60, "Property", "Description");
                    __builder3.AddAttribute(61, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(63);
                    __builder3.AddAttribute(64, "Property", "Amount");
                    __builder3.AddAttribute(65, "Title", "Amount");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(67);
                    __builder3.AddAttribute(68, "Property", "Department_FK");
                    __builder3.AddAttribute(69, "SortProperty", "TblGnDepartment.Deparment_Name");
                    __builder3.AddAttribute(70, "FilterProperty", "TblGnDepartment.Deparment_Name");
                    __builder3.AddAttribute(71, "Title", "Tbl Gn Department");
                    __builder3.AddAttribute(72, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(73, "\n              ");
                        __builder4.AddContent(74, 
#line 39 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                data.TblGnDepartment?.Deparment_Name

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(75, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>>(77);
                    __builder3.AddAttribute(78, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 42 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(79, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 42 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                                  false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(80, "Width", "70px");
                    __builder3.AddAttribute(81, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 42 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                                                                 TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(82, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>)((canErp2ModelsDbAtVdc2TblPoAccountPayable) => (__builder4) => {
                        __builder4.AddMarkupContent(83, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                        __builder4.AddAttribute(85, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 44 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(86, "Icon", "close");
                        __builder4.AddAttribute(87, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 44 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(88, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 44 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErp2ModelsDbAtVdc2TblPoAccountPayable)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(89, "onclick", 
#line 44 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                                                                                        true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(90, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(92, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoAccountPayables.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoAccountPayable>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
