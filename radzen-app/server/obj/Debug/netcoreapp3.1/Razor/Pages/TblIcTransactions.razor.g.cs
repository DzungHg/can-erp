#pragma checksum "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7bd35f7c3eafbe5c679c0677a52661b9958fd97"
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
#line 5 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-ic-transactions")]
    public partial class TblIcTransactions : CanErp2.Pages.TblIcTransactionsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Ic Transactions");
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
#line 14 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                                      getTblIcTransactionsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblIcTransaction>(this, 
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                                                                                                                                Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(28);
                    __builder3.AddAttribute(29, "Property", "Trans_No");
                    __builder3.AddAttribute(30, "Title", "Trans No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(32);
                    __builder3.AddAttribute(33, "Property", "Trans_Code");
                    __builder3.AddAttribute(34, "SortProperty", "TblIcTransactionType.Transaction_Name");
                    __builder3.AddAttribute(35, "FilterProperty", "TblIcTransactionType.Transaction_Name");
                    __builder3.AddAttribute(36, "Title", "Tbl Ic Transaction Type");
                    __builder3.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcTransaction>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(38, "\n              ");
                        __builder4.AddContent(39, 
#line 22 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                data.TblIcTransactionType?.Transaction_Name

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(40, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(42);
                    __builder3.AddAttribute(43, "Property", "Trans_Date");
                    __builder3.AddAttribute(44, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(45, "Title", "Trans Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(47);
                    __builder3.AddAttribute(48, "Property", "Warehouse_ID");
                    __builder3.AddAttribute(49, "SortProperty", "TblIcWarehouse.WarehouseName");
                    __builder3.AddAttribute(50, "FilterProperty", "TblIcWarehouse.WarehouseName");
                    __builder3.AddAttribute(51, "Title", "Tbl Ic Warehouse");
                    __builder3.AddAttribute(52, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcTransaction>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(53, "\n              ");
                        __builder4.AddContent(54, 
#line 29 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                data.TblIcWarehouse?.WarehouseName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(55, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(57);
                    __builder3.AddAttribute(58, "Property", "Item_FK");
                    __builder3.AddAttribute(59, "SortProperty", "TblGnProduct.Product_ID");
                    __builder3.AddAttribute(60, "FilterProperty", "TblGnProduct.Product_ID");
                    __builder3.AddAttribute(61, "Title", "Tbl Gn Product");
                    __builder3.AddAttribute(62, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcTransaction>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(63, "\n              ");
                        __builder4.AddContent(64, 
#line 34 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                data.TblGnProduct?.Product_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(65, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(67);
                    __builder3.AddAttribute(68, "Property", "Reference_No");
                    __builder3.AddAttribute(69, "Title", "Reference No");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(71);
                    __builder3.AddAttribute(72, "Property", "Reference_Date");
                    __builder3.AddAttribute(73, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(74, "Title", "Reference Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(76);
                    __builder3.AddAttribute(77, "Property", "Taxable");
                    __builder3.AddAttribute(78, "Title", "Taxable");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(80);
                    __builder3.AddAttribute(81, "Property", "Cust_Vend_WarID");
                    __builder3.AddAttribute(82, "Title", "Cust Vend War ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(84);
                    __builder3.AddAttribute(85, "Property", "Trans_Qty");
                    __builder3.AddAttribute(86, "Title", "Trans Qty");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(88);
                    __builder3.AddAttribute(89, "Property", "UOM");
                    __builder3.AddAttribute(90, "Title", "UOM");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(92);
                    __builder3.AddAttribute(93, "Property", "Trans_Amount");
                    __builder3.AddAttribute(94, "Title", "Trans Amount");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(96);
                    __builder3.AddAttribute(97, "Property", "Qty_On_Hand_EOB");
                    __builder3.AddAttribute(98, "Title", "Qty On Hand EOB");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(100);
                    __builder3.AddAttribute(101, "Property", "Qty_On_Order_EOB");
                    __builder3.AddAttribute(102, "Title", "Qty On Order EOB");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(104);
                    __builder3.AddAttribute(105, "Property", "Qty_On_Allowed_EOB");
                    __builder3.AddAttribute(106, "Title", "Qty On Allowed EOB");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(108);
                    __builder3.AddAttribute(109, "Property", "GL_Asset");
                    __builder3.AddAttribute(110, "Title", "GL Asset");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(112);
                    __builder3.AddAttribute(113, "Property", "GL_COGS");
                    __builder3.AddAttribute(114, "Title", "GL COGS");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(116);
                    __builder3.AddAttribute(117, "Property", "GL_Sales");
                    __builder3.AddAttribute(118, "Title", "GL Sales");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcTransaction>>(120);
                    __builder3.AddAttribute(121, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 63 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                                                                           false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(122, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 63 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                                                                                            false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(123, "Width", "70px");
                    __builder3.AddAttribute(124, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 63 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                                                                                                                           TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(125, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcTransaction>)((canErp2ModelsDbAtVdc2TblIcTransaction) => (__builder4) => {
                        __builder4.AddMarkupContent(126, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(127);
                        __builder4.AddAttribute(128, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 65 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(129, "Icon", "close");
                        __builder4.AddAttribute(130, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 65 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(131, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 65 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErp2ModelsDbAtVdc2TblIcTransaction)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(132, "onclick", 
#line 65 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                                                                                                                                                                                                                     true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(133, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(135, (__value) => {
#line 16 "F:\GitHub02\can-erp\radzen-app\server\Pages\TblIcTransactions.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblIcTransaction>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(136, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
