#pragma checksum "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6730cfbcc0ba9eae6d36f2789c9867a7a62b235c"
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
#line 5 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
using CanErp2.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-ic-inventories")]
    public partial class TblIcInventories : CanErp2.Pages.TblIcInventoriesComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Ic Inventories");
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
#line 14 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblIcInventory>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErp2.Models.DbAtVdc2.TblIcInventory>>(
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                                     getTblIcInventoriesResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErp2.Models.DbAtVdc2.TblIcInventory>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErp2.Models.DbAtVdc2.TblIcInventory>(this, 
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                                                                                                                           Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(28);
                    __builder3.AddAttribute(29, "Property", "Inventory_SEQ");
                    __builder3.AddAttribute(30, "Title", "Inventory SEQ");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(32);
                    __builder3.AddAttribute(33, "Property", "Warehouse_FK");
                    __builder3.AddAttribute(34, "SortProperty", "TblIcWarehouse.WarehouseName");
                    __builder3.AddAttribute(35, "FilterProperty", "TblIcWarehouse.WarehouseName");
                    __builder3.AddAttribute(36, "Title", "Tbl Ic Warehouse");
                    __builder3.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcInventory>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(38, "\n              ");
                        __builder4.AddContent(39, 
#line 22 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                data.TblIcWarehouse?.WarehouseName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(40, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(42);
                    __builder3.AddAttribute(43, "Property", "Category_FK");
                    __builder3.AddAttribute(44, "SortProperty", "TblIcCategory.CategoryText");
                    __builder3.AddAttribute(45, "FilterProperty", "TblIcCategory.CategoryText");
                    __builder3.AddAttribute(46, "Title", "Tbl Ic Category");
                    __builder3.AddAttribute(47, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcInventory>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(48, "\n              ");
                        __builder4.AddContent(49, 
#line 27 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                data.TblIcCategory?.CategoryText

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(50, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(52);
                    __builder3.AddAttribute(53, "Property", "Classifi_FK");
                    __builder3.AddAttribute(54, "SortProperty", "TblIcClassification.Classifi_Name");
                    __builder3.AddAttribute(55, "FilterProperty", "TblIcClassification.Classifi_Name");
                    __builder3.AddAttribute(56, "Title", "Tbl Ic Classification");
                    __builder3.AddAttribute(57, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcInventory>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(58, "\n              ");
                        __builder4.AddContent(59, 
#line 32 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                data.TblIcClassification?.Classifi_Name

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(60, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(62);
                    __builder3.AddAttribute(63, "Property", "Item_FK");
                    __builder3.AddAttribute(64, "SortProperty", "TblGnProduct.Product_ID");
                    __builder3.AddAttribute(65, "FilterProperty", "TblGnProduct.Product_ID");
                    __builder3.AddAttribute(66, "Title", "Tbl Gn Product");
                    __builder3.AddAttribute(67, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcInventory>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(68, "\n              ");
                        __builder4.AddContent(69, 
#line 37 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                data.TblGnProduct?.Product_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(70, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(72);
                    __builder3.AddAttribute(73, "Property", "Product_Code");
                    __builder3.AddAttribute(74, "Title", "Product Code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(76);
                    __builder3.AddAttribute(77, "Property", "ProductDesc");
                    __builder3.AddAttribute(78, "Title", "Product Desc");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(80);
                    __builder3.AddAttribute(81, "Property", "FixAsset");
                    __builder3.AddAttribute(82, "Title", "Fix Asset");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(84);
                    __builder3.AddAttribute(85, "Property", "Unit_FK");
                    __builder3.AddAttribute(86, "SortProperty", "TblIcUnit.UnitText");
                    __builder3.AddAttribute(87, "FilterProperty", "TblIcUnit.UnitText");
                    __builder3.AddAttribute(88, "Title", "Tbl Ic Unit");
                    __builder3.AddAttribute(89, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcInventory>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(90, "\n              ");
                        __builder4.AddContent(91, 
#line 48 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                data.TblIcUnit?.UnitText

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(92, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(94);
                    __builder3.AddAttribute(95, "Property", "QuantityPerUnit");
                    __builder3.AddAttribute(96, "Title", "Quantity Per Unit");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(98);
                    __builder3.AddAttribute(99, "Property", "Location");
                    __builder3.AddAttribute(100, "Title", "Location");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(102);
                    __builder3.AddAttribute(103, "Property", "Taxable");
                    __builder3.AddAttribute(104, "Title", "Taxable");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(106);
                    __builder3.AddAttribute(107, "Property", "TaxRate");
                    __builder3.AddAttribute(108, "Title", "Tax Rate");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(110);
                    __builder3.AddAttribute(111, "Property", "ROP");
                    __builder3.AddAttribute(112, "Title", "ROP");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(114);
                    __builder3.AddAttribute(115, "Property", "EOQ");
                    __builder3.AddAttribute(116, "Title", "EOQ");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(118);
                    __builder3.AddAttribute(119, "Property", "UnitPrice");
                    __builder3.AddAttribute(120, "Title", "Unit Price");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(121, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(122);
                    __builder3.AddAttribute(123, "Property", "GL_Asset");
                    __builder3.AddAttribute(124, "Title", "GL Asset");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(126);
                    __builder3.AddAttribute(127, "Property", "GL_COGS");
                    __builder3.AddAttribute(128, "Title", "GL COGS");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(130);
                    __builder3.AddAttribute(131, "Property", "GL_Sales");
                    __builder3.AddAttribute(132, "Title", "GL Sales");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(134);
                    __builder3.AddAttribute(135, "Property", "GL_NonTaxSales");
                    __builder3.AddAttribute(136, "Title", "GL Non Tax Sales");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(138);
                    __builder3.AddAttribute(139, "Property", "LastSaleDate");
                    __builder3.AddAttribute(140, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(141, "Title", "Last Sale Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(142, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(143);
                    __builder3.AddAttribute(144, "Property", "LastPODate");
                    __builder3.AddAttribute(145, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(146, "Title", "Last PO Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(147, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(148);
                    __builder3.AddAttribute(149, "Property", "LastReceiptDate");
                    __builder3.AddAttribute(150, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(151, "Title", "Last Receipt Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(152, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(153);
                    __builder3.AddAttribute(154, "Property", "Leadtime");
                    __builder3.AddAttribute(155, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(156, "Title", "Leadtime");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(157, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(158);
                    __builder3.AddAttribute(159, "Property", "LastCost");
                    __builder3.AddAttribute(160, "Title", "Last Cost");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(161, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(162);
                    __builder3.AddAttribute(163, "Property", "EverageCost");
                    __builder3.AddAttribute(164, "Title", "Everage Cost");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(165, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(166);
                    __builder3.AddAttribute(167, "Property", "Qty_On_Order");
                    __builder3.AddAttribute(168, "Title", "Qty On Order");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(169, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(170);
                    __builder3.AddAttribute(171, "Property", "Qty_In_Stock");
                    __builder3.AddAttribute(172, "Title", "Qty In Stock");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(173, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(174);
                    __builder3.AddAttribute(175, "Property", "Qty_On_Hand");
                    __builder3.AddAttribute(176, "Title", "Qty On Hand");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(177, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(178);
                    __builder3.AddAttribute(179, "Property", "Qty_Allocated");
                    __builder3.AddAttribute(180, "Title", "Qty Allocated");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(181, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(182);
                    __builder3.AddAttribute(183, "Property", "TotalInventory");
                    __builder3.AddAttribute(184, "Title", "Total Inventory");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(185, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(186);
                    __builder3.AddAttribute(187, "Property", "MTD_Qty_Sold");
                    __builder3.AddAttribute(188, "Title", "MTD Qty Sold");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(189, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(190);
                    __builder3.AddAttribute(191, "Property", "MTD_Gross_Sales");
                    __builder3.AddAttribute(192, "Title", "MTD Gross Sales");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(193, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(194);
                    __builder3.AddAttribute(195, "Property", "MTD_COGS");
                    __builder3.AddAttribute(196, "Title", "MTD COGS");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(197, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(198);
                    __builder3.AddAttribute(199, "Property", "YTD_Qty_Sold");
                    __builder3.AddAttribute(200, "Title", "YTD Qty Sold");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(201, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(202);
                    __builder3.AddAttribute(203, "Property", "YTD_Gross_Sales");
                    __builder3.AddAttribute(204, "Title", "YTD Gross Sales");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(205, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(206);
                    __builder3.AddAttribute(207, "Property", "YTD_COGS");
                    __builder3.AddAttribute(208, "Title", "YTD COGS");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(209, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(210);
                    __builder3.AddAttribute(211, "Property", "YTD_Qty_Returned");
                    __builder3.AddAttribute(212, "Title", "YTD Qty Returned");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(213, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(214);
                    __builder3.AddAttribute(215, "Property", "LTD_Qty_Sold");
                    __builder3.AddAttribute(216, "Title", "LTD Qty Sold");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(217, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(218);
                    __builder3.AddAttribute(219, "Property", "LTD_Gross_Sales");
                    __builder3.AddAttribute(220, "Title", "LTD Gross Sales");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(221, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(222);
                    __builder3.AddAttribute(223, "Property", "LTD_COGS");
                    __builder3.AddAttribute(224, "Title", "LTD COGS");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(225, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(226);
                    __builder3.AddAttribute(227, "Property", "NetGrossRate");
                    __builder3.AddAttribute(228, "Title", "Net Gross Rate");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(229, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(230);
                    __builder3.AddAttribute(231, "Property", "VendorNumber_FK");
                    __builder3.AddAttribute(232, "Title", "Vendor Number FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(233, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(234);
                    __builder3.AddAttribute(235, "Property", "LastUpdatedDate");
                    __builder3.AddAttribute(236, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(237, "Title", "Last Updated Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(238, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(239);
                    __builder3.AddAttribute(240, "Property", "LastUpdatedBy_FK");
                    __builder3.AddAttribute(241, "Title", "Last Updated By FK");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(242, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(243);
                    __builder3.AddAttribute(244, "Property", "Notes");
                    __builder3.AddAttribute(245, "Title", "Notes");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(246, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(247);
                    __builder3.AddAttribute(248, "Property", "Inactive");
                    __builder3.AddAttribute(249, "Title", "Inactive");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(250, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErp2.Models.DbAtVdc2.TblIcInventory>>(251);
                    __builder3.AddAttribute(252, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 127 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(253, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 127 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(254, "Width", "70px");
                    __builder3.AddAttribute(255, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 127 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(256, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErp2.Models.DbAtVdc2.TblIcInventory>)((canErp2ModelsDbAtVdc2TblIcInventory) => (__builder4) => {
                        __builder4.AddMarkupContent(257, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(258);
                        __builder4.AddAttribute(259, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 129 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(260, "Icon", "close");
                        __builder4.AddAttribute(261, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 129 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(262, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 129 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErp2ModelsDbAtVdc2TblIcInventory)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(263, "onclick", 
#line 129 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                                                                                                                                                                                                                   true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(264, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(265, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(266, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\can-erp\radzen-app\server\Pages\TblIcInventories.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErp2.Models.DbAtVdc2.TblIcInventory>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(267, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(268, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(269, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
