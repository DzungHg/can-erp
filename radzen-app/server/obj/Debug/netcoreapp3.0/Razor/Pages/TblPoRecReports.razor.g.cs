#pragma checksum "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1785724b50621cf4d2a1342f7760780715617c7"
// <auto-generated/>
#pragma warning disable 1591
namespace ErpCan.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using ErpCan.Shared;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-rec-reports")]
    public class TblPoRecReports : ErpCan.Pages.TblPoRecReportsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "contentContainer0");
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
#line 14 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                                      getTblPoRecReportsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoRecReport>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                                                                                                                                Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(28);
                    __builder3.AddAttribute(29, "Property", "RR_No");
                    __builder3.AddAttribute(30, "Title", "RR No");
                    __builder3.AddAttribute(31, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(33);
                    __builder3.AddAttribute(34, "Format", "date-time");
                    __builder3.AddAttribute(35, "Property", "RRDate");
                    __builder3.AddAttribute(36, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(37, "Title", "RR Date");
                    __builder3.AddAttribute(38, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(40);
                    __builder3.AddAttribute(41, "Property", "CreatedBy_FK");
                    __builder3.AddAttribute(42, "SortProperty", "TblGnAddressBook.AddressBook_ID");
                    __builder3.AddAttribute(43, "FilterProperty", "TblGnAddressBook.AddressBook_ID");
                    __builder3.AddAttribute(44, "Title", "Tbl Gn Address Book");
                    __builder3.AddAttribute(45, "Type", "string");
                    __builder3.AddAttribute(46, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoRecReport>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(47, "\n              ");
                        __builder4.AddContent(48, 
#line 24 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
               data.TblGnAddressBook?.AddressBook_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(49, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(51);
                    __builder3.AddAttribute(52, "Property", "PO_ID");
                    __builder3.AddAttribute(53, "Title", "PO ID");
                    __builder3.AddAttribute(54, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(56);
                    __builder3.AddAttribute(57, "Property", "POStatus_FK");
                    __builder3.AddAttribute(58, "Title", "PO Status FK");
                    __builder3.AddAttribute(59, "Type", "integer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(61);
                    __builder3.AddAttribute(62, "Format", "date-time");
                    __builder3.AddAttribute(63, "Property", "PODate");
                    __builder3.AddAttribute(64, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(65, "Title", "PO Date");
                    __builder3.AddAttribute(66, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(68);
                    __builder3.AddAttribute(69, "Property", "Vendor_FK");
                    __builder3.AddAttribute(70, "SortProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(71, "FilterProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(72, "Title", "Tbl Po Vendor");
                    __builder3.AddAttribute(73, "Type", "string");
                    __builder3.AddAttribute(74, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoRecReport>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(75, "\n              ");
                        __builder4.AddContent(76, 
#line 35 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
               data.TblPoVendor?.LastName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(77, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(79);
                    __builder3.AddAttribute(80, "Property", "Description");
                    __builder3.AddAttribute(81, "Title", "Description");
                    __builder3.AddAttribute(82, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(84);
                    __builder3.AddAttribute(85, "Property", "Invoice_No");
                    __builder3.AddAttribute(86, "Title", "Invoice No");
                    __builder3.AddAttribute(87, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(89);
                    __builder3.AddAttribute(90, "Format", "date-time");
                    __builder3.AddAttribute(91, "Property", "Invoice_Date");
                    __builder3.AddAttribute(92, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(93, "Title", "Invoice Date");
                    __builder3.AddAttribute(94, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(96);
                    __builder3.AddAttribute(97, "Property", "Ship_No");
                    __builder3.AddAttribute(98, "Title", "Ship No");
                    __builder3.AddAttribute(99, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(101);
                    __builder3.AddAttribute(102, "Format", "date-time");
                    __builder3.AddAttribute(103, "Property", "Ship_Date");
                    __builder3.AddAttribute(104, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(105, "Title", "Ship Date");
                    __builder3.AddAttribute(106, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(108);
                    __builder3.AddAttribute(109, "Property", "Receiver_FK");
                    __builder3.AddAttribute(110, "Title", "Receiver FK");
                    __builder3.AddAttribute(111, "Type", "integer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(113);
                    __builder3.AddAttribute(114, "Property", "BillOf_Loading_No");
                    __builder3.AddAttribute(115, "Title", "Bill Of Loading No");
                    __builder3.AddAttribute(116, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(118);
                    __builder3.AddAttribute(119, "Format", "decimal");
                    __builder3.AddAttribute(120, "Property", "PO_Amount");
                    __builder3.AddAttribute(121, "Title", "PO Amount");
                    __builder3.AddAttribute(122, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(123, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(124);
                    __builder3.AddAttribute(125, "Property", "Inactive");
                    __builder3.AddAttribute(126, "Title", "Inactive");
                    __builder3.AddAttribute(127, "Type", "boolean");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(128, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(129);
                    __builder3.AddAttribute(130, "Property", "Warhoused");
                    __builder3.AddAttribute(131, "Title", "Warhoused");
                    __builder3.AddAttribute(132, "Type", "boolean");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRecReport>>(134);
                    __builder3.AddAttribute(135, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 58 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                                                                               false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(136, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 58 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(137, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 58 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                                                                                                               false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(138, "Width", "70px");
                    __builder3.AddAttribute(139, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 58 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                                                                                                                                              TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(140, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoRecReport>)((erpCanModelsCanErpDbAt132TblPoRecReport) => (__builder4) => {
                        __builder4.AddMarkupContent(141, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(142);
                        __builder4.AddAttribute(143, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 60 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(144, "Icon", "close");
                        __builder4.AddAttribute(145, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 60 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(146, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 60 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblPoRecReport)

#line default
#line hidden
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(147, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(148, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(149, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRecReports.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoRecReport>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(150, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591