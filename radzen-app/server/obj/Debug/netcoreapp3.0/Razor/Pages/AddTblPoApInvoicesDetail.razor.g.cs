#pragma checksum "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d59b7e9d4ed5aca7ef9a6a8792763264600ef27"
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
#line 5 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-po-ap-invoices-detail")]
    public class AddTblPoApInvoicesDetail : ErpCan.Pages.AddTblPoApInvoicesDetailComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "contentContainer0");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>(
#line 12 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                    tblpoapinvoicesdetail

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                       tblpoapinvoicesdetail != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>(this, 
#line 12 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                                                                                                                          Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "Tbl Po Vendor");
                    __builder3.AddAttribute(25, "Component", "Vendor_ID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.ErpCan.Pages.AddTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_0(__builder3, 32, 33, 
#line 20 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                        getTblPoVendorsResult

#line default
#line hidden
                    , 34, "LastName", 35, "Vendor_ID", 36, "Choose TblPoVendor", 37, "display: block; width: 100%", 38, "Vendor_ID", 39, 
#line 20 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                                                                                                                                                      (tblpoapinvoicesdetail.Vendor_ID)

#line default
#line hidden
                    , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblpoapinvoicesdetail.Vendor_ID) = __value, (tblpoapinvoicesdetail.Vendor_ID))));
                    __builder3.AddMarkupContent(41, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(42);
                    __builder3.AddAttribute(43, "Component", "Vendor_ID");
                    __builder3.AddAttribute(44, "Text", "Vendor_ID is required");
                    __builder3.AddAttribute(45, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(51, "class", "row");
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "class", "col-md-3");
                    __builder3.AddMarkupContent(55, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(56);
                    __builder3.AddAttribute(57, "Text", "Invoice No");
                    __builder3.AddAttribute(58, "Component", "Invoice_No");
                    __builder3.AddAttribute(59, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\n              ");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "col-md-9");
                    __builder3.AddMarkupContent(64, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(65);
                    __builder3.AddAttribute(66, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 32 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                          15

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(67, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(68, "Name", "Invoice_No");
                    __builder3.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                                                 (tblpoapinvoicesdetail.Invoice_No)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblpoapinvoicesdetail.Invoice_No) = __value, (tblpoapinvoicesdetail.Invoice_No)))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(72);
                    __builder3.AddAttribute(73, "Component", "Invoice_No");
                    __builder3.AddAttribute(74, "Text", "Invoice_No is required");
                    __builder3.AddAttribute(75, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\n            ");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(81, "class", "row");
                    __builder3.AddMarkupContent(82, "\n              ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "class", "col-md-3");
                    __builder3.AddMarkupContent(85, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(86);
                    __builder3.AddAttribute(87, "Text", "Invoice Date");
                    __builder3.AddAttribute(88, "Component", "Invoice_Date");
                    __builder3.AddAttribute(89, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n              ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "col-md-9");
                    __builder3.AddMarkupContent(94, "\n                ");
                    __Blazor.ErpCan.Pages.AddTblPoApInvoicesDetail.TypeInference.CreateRadzenDatePicker_1(__builder3, 95, 96, "MM/dd/yyyy", 97, "width: 100%", 98, "Invoice_Date", 99, 
#line 44 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                                             (tblpoapinvoicesdetail.Invoice_Date)

#line default
#line hidden
                    , 100, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblpoapinvoicesdetail.Invoice_Date) = __value, (tblpoapinvoicesdetail.Invoice_Date))));
                    __builder3.AddMarkupContent(101, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(106, "class", "row");
                    __builder3.AddMarkupContent(107, "\n              ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "class", "col-md-3");
                    __builder3.AddMarkupContent(110, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(111);
                    __builder3.AddAttribute(112, "Text", "Tbl Ic Inventory");
                    __builder3.AddAttribute(113, "Component", "Inventory_FK");
                    __builder3.AddAttribute(114, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\n              ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "col-md-9");
                    __builder3.AddMarkupContent(119, "\n                ");
                    __Blazor.ErpCan.Pages.AddTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_2(__builder3, 120, 121, 
#line 54 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                        getTblIcInventoriesResult

#line default
#line hidden
                    , 122, "Warehouse_FK", 123, "Inventory_SEQ", 124, "Choose TblIcInventory", 125, "width: 100%", 126, "Inventory_FK", 127, 
#line 54 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                                                                                                                                                     (tblpoapinvoicesdetail.Inventory_FK)

#line default
#line hidden
                    , 128, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblpoapinvoicesdetail.Inventory_FK) = __value, (tblpoapinvoicesdetail.Inventory_FK))));
                    __builder3.AddMarkupContent(129, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\n            ");
                    __builder3.OpenElement(132, "div");
                    __builder3.AddAttribute(133, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(134, "class", "row");
                    __builder3.AddMarkupContent(135, "\n              ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "class", "col-md-3");
                    __builder3.AddMarkupContent(138, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(139);
                    __builder3.AddAttribute(140, "Text", "Tbl Ic Unit");
                    __builder3.AddAttribute(141, "Component", "Unit_FK");
                    __builder3.AddAttribute(142, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(143, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(144, "\n              ");
                    __builder3.OpenElement(145, "div");
                    __builder3.AddAttribute(146, "class", "col-md-9");
                    __builder3.AddMarkupContent(147, "\n                ");
                    __Blazor.ErpCan.Pages.AddTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_3(__builder3, 148, 149, 
#line 64 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                        getTblIcUnitsResult

#line default
#line hidden
                    , 150, "UnitText", 151, "Unit_SEQ", 152, "Choose TblIcUnit", 153, "width: 100%", 154, "Unit_FK", 155, 
#line 64 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                                                                                                                                 (tblpoapinvoicesdetail.Unit_FK)

#line default
#line hidden
                    , 156, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblpoapinvoicesdetail.Unit_FK) = __value, (tblpoapinvoicesdetail.Unit_FK))));
                    __builder3.AddMarkupContent(157, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(158, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(159, "\n            ");
                    __builder3.OpenElement(160, "div");
                    __builder3.AddAttribute(161, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(162, "class", "row");
                    __builder3.AddMarkupContent(163, "\n              ");
                    __builder3.OpenElement(164, "div");
                    __builder3.AddAttribute(165, "class", "col-md-3");
                    __builder3.AddMarkupContent(166, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(167);
                    __builder3.AddAttribute(168, "Text", "Unit Price");
                    __builder3.AddAttribute(169, "Component", "Unit_Price");
                    __builder3.AddAttribute(170, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(171, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(172, "\n              ");
                    __builder3.OpenElement(173, "div");
                    __builder3.AddAttribute(174, "class", "col-md-9");
                    __builder3.AddMarkupContent(175, "\n                ");
                    __Blazor.ErpCan.Pages.AddTblPoApInvoicesDetail.TypeInference.CreateRadzenNumeric_4(__builder3, 176, 177, "width: 100%", 178, "Unit_Price", 179, 
#line 74 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                  (tblpoapinvoicesdetail.Unit_Price)

#line default
#line hidden
                    , 180, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblpoapinvoicesdetail.Unit_Price) = __value, (tblpoapinvoicesdetail.Unit_Price))));
                    __builder3.AddMarkupContent(181, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(182, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(183, "\n            ");
                    __builder3.OpenElement(184, "div");
                    __builder3.AddAttribute(185, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(186, "class", "row");
                    __builder3.AddMarkupContent(187, "\n              ");
                    __builder3.OpenElement(188, "div");
                    __builder3.AddAttribute(189, "class", "col-md-3");
                    __builder3.AddMarkupContent(190, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(191);
                    __builder3.AddAttribute(192, "Text", "Qty Ordered");
                    __builder3.AddAttribute(193, "Component", "Qty_Ordered");
                    __builder3.AddAttribute(194, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(195, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(196, "\n              ");
                    __builder3.OpenElement(197, "div");
                    __builder3.AddAttribute(198, "class", "col-md-9");
                    __builder3.AddMarkupContent(199, "\n                ");
                    __Blazor.ErpCan.Pages.AddTblPoApInvoicesDetail.TypeInference.CreateRadzenNumeric_5(__builder3, 200, 201, "width: 100%", 202, "Qty_Ordered", 203, 
#line 84 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                  (tblpoapinvoicesdetail.Qty_Ordered)

#line default
#line hidden
                    , 204, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblpoapinvoicesdetail.Qty_Ordered) = __value, (tblpoapinvoicesdetail.Qty_Ordered))));
                    __builder3.AddMarkupContent(205, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(206, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(207, "\n            ");
                    __builder3.OpenElement(208, "div");
                    __builder3.AddAttribute(209, "class", "row");
                    __builder3.AddMarkupContent(210, "\n              ");
                    __builder3.OpenElement(211, "div");
                    __builder3.AddAttribute(212, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(213, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(214);
                    __builder3.AddAttribute(215, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 90 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(216, "Icon", "save");
                    __builder3.AddAttribute(217, "Text", "Save");
                    __builder3.AddAttribute(218, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 90 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(219, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(220);
                    __builder3.AddAttribute(221, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 92 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(222, "Text", "Cancel");
                    __builder3.AddAttribute(223, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 92 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoApInvoicesDetail.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(224, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(225, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(226, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(227, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(228, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(229, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ErpCan.Pages.AddTblPoApInvoicesDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<global::System.Object> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7)
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
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<global::System.Object> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7)
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
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<global::System.Object> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7)
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
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591