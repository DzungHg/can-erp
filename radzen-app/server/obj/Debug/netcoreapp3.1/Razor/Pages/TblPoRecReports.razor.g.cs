#pragma checksum "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f45091417cd51b8b2fc1f4b4173a56af230a6b"
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
#line 5 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-rec-reports")]
    public partial class TblPoRecReports : CanErp2.Pages.TblPoRecReportsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Po Rec Reports");
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
#line 14 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                                      getTblPoRecReportsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblPoRecReport>(this, 
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                                                                                                                            Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(28);
                    __builder3.AddAttribute(29, "Property", "RR_No");
                    __builder3.AddAttribute(30, "Title", "RR No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(32);
                    __builder3.AddAttribute(33, "Property", "RRDate");
                    __builder3.AddAttribute(34, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(35, "Title", "RR Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(37);
                    __builder3.AddAttribute(38, "Property", "CreatedBy_FK");
                    __builder3.AddAttribute(39, "SortProperty", "TblGnAddressBook.AddressBook_ID");
                    __builder3.AddAttribute(40, "FilterProperty", "TblGnAddressBook.AddressBook_ID");
                    __builder3.AddAttribute(41, "Title", "Tbl Gn Address Book");
                    __builder3.AddAttribute(42, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoRecReport>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(43, "\n              ");
                        __builder4.AddContent(44, 
#line 24 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                data.TblGnAddressBook?.AddressBook_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(45, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(47);
                    __builder3.AddAttribute(48, "Property", "PO_ID");
                    __builder3.AddAttribute(49, "Title", "PO ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(51);
                    __builder3.AddAttribute(52, "Property", "POStatus_FK");
                    __builder3.AddAttribute(53, "Title", "PO Status FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(55);
                    __builder3.AddAttribute(56, "Property", "PODate");
                    __builder3.AddAttribute(57, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(58, "Title", "PO Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(60);
                    __builder3.AddAttribute(61, "Property", "Vendor_FK");
                    __builder3.AddAttribute(62, "SortProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(63, "FilterProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(64, "Title", "Tbl Po Vendor");
                    __builder3.AddAttribute(65, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoRecReport>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(66, "\n              ");
                        __builder4.AddContent(67, 
#line 35 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                data.TblPoVendor?.LastName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(68, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(70);
                    __builder3.AddAttribute(71, "Property", "Description");
                    __builder3.AddAttribute(72, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(74);
                    __builder3.AddAttribute(75, "Property", "Invoice_No");
                    __builder3.AddAttribute(76, "Title", "Invoice No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(78);
                    __builder3.AddAttribute(79, "Property", "Invoice_Date");
                    __builder3.AddAttribute(80, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(81, "Title", "Invoice Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(83);
                    __builder3.AddAttribute(84, "Property", "Ship_No");
                    __builder3.AddAttribute(85, "Title", "Ship No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(87);
                    __builder3.AddAttribute(88, "Property", "Ship_Date");
                    __builder3.AddAttribute(89, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(90, "Title", "Ship Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(92);
                    __builder3.AddAttribute(93, "Property", "Receiver_FK");
                    __builder3.AddAttribute(94, "Title", "Receiver FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(96);
                    __builder3.AddAttribute(97, "Property", "BillOf_Loading_No");
                    __builder3.AddAttribute(98, "Title", "Bill Of Loading No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(100);
                    __builder3.AddAttribute(101, "Property", "PO_Amount");
                    __builder3.AddAttribute(102, "Title", "PO Amount");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(104);
                    __builder3.AddAttribute(105, "Property", "Inactive");
                    __builder3.AddAttribute(106, "Title", "Inactive");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(108);
                    __builder3.AddAttribute(109, "Property", "Warhoused");
                    __builder3.AddAttribute(110, "Title", "Warhoused");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoRecReport>>(112);
                    __builder3.AddAttribute(113, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 58 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(114, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 58 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(115, "Width", "70px");
                    __builder3.AddAttribute(116, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 58 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(117, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoRecReport>)((canErp2ModelsDbAtVdc2TblPoRecReport) => (__builder4) => {
                        __builder4.AddMarkupContent(118, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(119);
                        __builder4.AddAttribute(120, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 60 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(121, "Icon", "close");
                        __builder4.AddAttribute(122, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 60 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(123, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 60 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErp2ModelsDbAtVdc2TblPoRecReport)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(124, "onclick", 
#line 60 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                                                                                                                                                                                                                   true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(125, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(126, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(127, (__value) => {
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblPoRecReports.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoRecReport>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
