#pragma checksum "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c33e979601fab599fd40236060c31bd2cff726c"
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
#line 5 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-purchase-orders")]
    public class TblPoPurchaseOrders : ErpCan.Pages.TblPoPurchaseOrdersComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Po Purchase Orders");
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
#line 14 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                                      getTblPoPurchaseOrdersResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                                                                                                                                        Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(28);
                    __builder3.AddAttribute(29, "Property", "PO_ID");
                    __builder3.AddAttribute(30, "Title", "PO ID");
                    __builder3.AddAttribute(31, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(33);
                    __builder3.AddAttribute(34, "Format", "date-time");
                    __builder3.AddAttribute(35, "Property", "PODate");
                    __builder3.AddAttribute(36, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(37, "Title", "PO Date");
                    __builder3.AddAttribute(38, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(40);
                    __builder3.AddAttribute(41, "Property", "CreatedBy_FK");
                    __builder3.AddAttribute(42, "SortProperty", "TblGnAddressBook.AddressBook_ID");
                    __builder3.AddAttribute(43, "FilterProperty", "TblGnAddressBook.AddressBook_ID");
                    __builder3.AddAttribute(44, "Title", "Tbl Gn Address Book");
                    __builder3.AddAttribute(45, "Type", "string");
                    __builder3.AddAttribute(46, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(47, "\n              ");
                        __builder4.AddContent(48, 
#line 24 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
               data.TblGnAddressBook?.AddressBook_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(49, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(51);
                    __builder3.AddAttribute(52, "Property", "POStatus_FK");
                    __builder3.AddAttribute(53, "SortProperty", "TblPoOrderStatus.POStatusText");
                    __builder3.AddAttribute(54, "FilterProperty", "TblPoOrderStatus.POStatusText");
                    __builder3.AddAttribute(55, "Title", "Tbl Po Order Status");
                    __builder3.AddAttribute(56, "Type", "string");
                    __builder3.AddAttribute(57, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(58, "\n              ");
                        __builder4.AddContent(59, 
#line 29 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
               data.TblPoOrderStatus?.POStatusText

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(60, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(62);
                    __builder3.AddAttribute(63, "Property", "Vendor_FK");
                    __builder3.AddAttribute(64, "SortProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(65, "FilterProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(66, "Title", "Tbl Po Vendor");
                    __builder3.AddAttribute(67, "Type", "string");
                    __builder3.AddAttribute(68, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(69, "\n              ");
                        __builder4.AddContent(70, 
#line 34 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
               data.TblPoVendor?.LastName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(71, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(73);
                    __builder3.AddAttribute(74, "Property", "Description");
                    __builder3.AddAttribute(75, "Title", "Description");
                    __builder3.AddAttribute(76, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(78);
                    __builder3.AddAttribute(79, "Property", "Incoterm_ID");
                    __builder3.AddAttribute(80, "Title", "Incoterm ID");
                    __builder3.AddAttribute(81, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(83);
                    __builder3.AddAttribute(84, "Property", "ShipVia_FK");
                    __builder3.AddAttribute(85, "SortProperty", "TblGnShipVium.ShipVia_ID");
                    __builder3.AddAttribute(86, "FilterProperty", "TblGnShipVium.ShipVia_ID");
                    __builder3.AddAttribute(87, "Title", "Tbl Gn Ship Vium");
                    __builder3.AddAttribute(88, "Type", "string");
                    __builder3.AddAttribute(89, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(90, "\n              ");
                        __builder4.AddContent(91, 
#line 43 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
               data.TblGnShipVium?.ShipVia_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(92, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(94);
                    __builder3.AddAttribute(95, "Property", "PaymentTerm_FK");
                    __builder3.AddAttribute(96, "SortProperty", "TblGnPaymentTerm.PaymentTerm_ID");
                    __builder3.AddAttribute(97, "FilterProperty", "TblGnPaymentTerm.PaymentTerm_ID");
                    __builder3.AddAttribute(98, "Title", "Tbl Gn Payment Term");
                    __builder3.AddAttribute(99, "Type", "string");
                    __builder3.AddAttribute(100, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(101, "\n              ");
                        __builder4.AddContent(102, 
#line 48 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
               data.TblGnPaymentTerm?.PaymentTerm_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(103, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(105);
                    __builder3.AddAttribute(106, "Property", "PaymentType_FK");
                    __builder3.AddAttribute(107, "SortProperty", "TblGnPaymentType.PaymentType_ID");
                    __builder3.AddAttribute(108, "FilterProperty", "TblGnPaymentType.PaymentType_ID");
                    __builder3.AddAttribute(109, "Title", "Tbl Gn Payment Type");
                    __builder3.AddAttribute(110, "Type", "string");
                    __builder3.AddAttribute(111, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(112, "\n              ");
                        __builder4.AddContent(113, 
#line 53 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
               data.TblGnPaymentType?.PaymentType_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(114, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(116);
                    __builder3.AddAttribute(117, "Property", "Buyer_FK");
                    __builder3.AddAttribute(118, "Title", "Buyer FK");
                    __builder3.AddAttribute(119, "Type", "integer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(121);
                    __builder3.AddAttribute(122, "Property", "TaxYN");
                    __builder3.AddAttribute(123, "Title", "Tax YN");
                    __builder3.AddAttribute(124, "Type", "boolean");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(126);
                    __builder3.AddAttribute(127, "Format", "double");
                    __builder3.AddAttribute(128, "Property", "TaxtRate");
                    __builder3.AddAttribute(129, "Title", "Taxt Rate");
                    __builder3.AddAttribute(130, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(131, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(132);
                    __builder3.AddAttribute(133, "Property", "Department_FK");
                    __builder3.AddAttribute(134, "Title", "Department FK");
                    __builder3.AddAttribute(135, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(136, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(137);
                    __builder3.AddAttribute(138, "Format", "decimal");
                    __builder3.AddAttribute(139, "Property", "PO_Amount");
                    __builder3.AddAttribute(140, "Title", "PO Amount");
                    __builder3.AddAttribute(141, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(142, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>>(143);
                    __builder3.AddAttribute(144, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 66 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(145, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 66 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(146, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 66 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(147, "Width", "70px");
                    __builder3.AddAttribute(148, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 66 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                                                                                                                                                      TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(149, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>)((erpCanModelsCanErpDbAt132TblPoPurchaseOrder) => (__builder4) => {
                        __builder4.AddMarkupContent(150, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(151);
                        __builder4.AddAttribute(152, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 68 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(153, "Icon", "close");
                        __builder4.AddAttribute(154, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 68 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(155, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 68 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblPoPurchaseOrder)

#line default
#line hidden
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(156, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(157, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(158, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoPurchaseOrders.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(159, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
