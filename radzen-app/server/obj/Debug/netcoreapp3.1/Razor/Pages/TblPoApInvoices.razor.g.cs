#pragma checksum "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "680771f7b8d33e83f8ae8e7564be5d584538980e"
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
#line 5 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-ap-invoices")]
    public partial class TblPoApInvoices : CanErp2.Pages.TblPoApInvoicesComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Po Ap Invoices");
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
#line 14 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                                     getTblPoApInvoicesResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblPoApInvoice>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                                                                                                                          Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(28);
                    __builder3.AddAttribute(29, "Property", "Vendor_ID");
                    __builder3.AddAttribute(30, "SortProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(31, "FilterProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(32, "Title", "Tbl Po Vendor");
                    __builder3.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoApInvoice>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(34, "\n              ");
                        __builder4.AddContent(35, 
#line 20 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                data.TblPoVendor?.LastName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(36, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(38);
                    __builder3.AddAttribute(39, "Property", "Invoice_No");
                    __builder3.AddAttribute(40, "Title", "Invoice No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(42);
                    __builder3.AddAttribute(43, "Property", "Invoice_Date");
                    __builder3.AddAttribute(44, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(45, "Title", "Invoice Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(47);
                    __builder3.AddAttribute(48, "Property", "PO_ID");
                    __builder3.AddAttribute(49, "Title", "PO ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(51);
                    __builder3.AddAttribute(52, "Property", "PO_Date");
                    __builder3.AddAttribute(53, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(54, "Title", "PO Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(56);
                    __builder3.AddAttribute(57, "Property", "Description");
                    __builder3.AddAttribute(58, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(60);
                    __builder3.AddAttribute(61, "Property", "Invoice_Amount");
                    __builder3.AddAttribute(62, "Title", "Invoice Amount");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(64);
                    __builder3.AddAttribute(65, "Property", "Discount_Amount");
                    __builder3.AddAttribute(66, "Title", "Discount Amount");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(68);
                    __builder3.AddAttribute(69, "Property", "Due_Date");
                    __builder3.AddAttribute(70, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(71, "Title", "Due Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(73);
                    __builder3.AddAttribute(74, "Property", "Paid");
                    __builder3.AddAttribute(75, "Title", "Paid");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblPoApInvoice>>(77);
                    __builder3.AddAttribute(78, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(79, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(80, "Width", "70px");
                    __builder3.AddAttribute(81, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 41 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(82, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblPoApInvoice>)((canErp2ModelsDbAtVdc2TblPoApInvoice) => (__builder4) => {
                        __builder4.AddMarkupContent(83, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                        __builder4.AddAttribute(85, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 43 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(86, "Icon", "close");
                        __builder4.AddAttribute(87, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 43 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(88, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErp2ModelsDbAtVdc2TblPoApInvoice)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(89, "onclick", 
#line 43 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
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
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblPoApInvoices.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblPoApInvoice>)__value;

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
