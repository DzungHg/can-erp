#pragma checksum "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1373b8bee9e2553cce217e242bf23f2f6e1cba33"
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
#line 5 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
using CanErpHp.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-hp-chi-tiet-luongs")]
    public partial class TblHpChiTietLuongs : CanErpHp.Pages.TblHpChiTietLuongsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Hp Chi Tiet Luongs");
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
#line 14 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                                     getTblHpChiTietLuongsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>(this, 
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                                                                                                                                 Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(28);
                    __builder3.AddAttribute(29, "Property", "ChiTietLuong_SEQ");
                    __builder3.AddAttribute(30, "Title", "Chi Tiet Luong SEQ");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(32);
                    __builder3.AddAttribute(33, "Property", "NhanVien_FK");
                    __builder3.AddAttribute(34, "SortProperty", "TblHpNhanVien.HoTenLot");
                    __builder3.AddAttribute(35, "FilterProperty", "TblHpNhanVien.HoTenLot");
                    __builder3.AddAttribute(36, "Title", "Tbl Hp Nhan Vien");
                    __builder3.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(38, "\n              ");
                        __builder4.AddContent(39, 
#line 22 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                data.TblHpNhanVien?.HoTenLot

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(40, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(42);
                    __builder3.AddAttribute(43, "Property", "NgayHuongLuong");
                    __builder3.AddAttribute(44, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(45, "Title", "Ngay Huong Luong");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(47);
                    __builder3.AddAttribute(48, "Property", "QuyetDinhSo");
                    __builder3.AddAttribute(49, "Title", "Quyet Dinh So");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(51);
                    __builder3.AddAttribute(52, "Property", "NgayKy");
                    __builder3.AddAttribute(53, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(54, "Title", "Ngay Ky");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(56);
                    __builder3.AddAttribute(57, "Property", "CoQuanKy");
                    __builder3.AddAttribute(58, "Title", "Co Quan Ky");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(60);
                    __builder3.AddAttribute(61, "Property", "Ngach");
                    __builder3.AddAttribute(62, "Title", "Ngach");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(64);
                    __builder3.AddAttribute(65, "Property", "Bac");
                    __builder3.AddAttribute(66, "Title", "Bac");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(68);
                    __builder3.AddAttribute(69, "Property", "HeSoLuong");
                    __builder3.AddAttribute(70, "Title", "He So Luong");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(72);
                    __builder3.AddAttribute(73, "Property", "HeSoPhuCapChucVu");
                    __builder3.AddAttribute(74, "Title", "He So Phu Cap Chuc Vu");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(76);
                    __builder3.AddAttribute(77, "Property", "HeSoPhuCapDocHai");
                    __builder3.AddAttribute(78, "Title", "He So Phu Cap Doc Hai");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(80);
                    __builder3.AddAttribute(81, "Property", "DienGiai");
                    __builder3.AddAttribute(82, "Title", "Dien Giai");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>>(84);
                    __builder3.AddAttribute(85, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 45 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                                                                               false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(86, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 45 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(87, "Width", "70px");
                    __builder3.AddAttribute(88, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 45 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                                                                                                                               TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(89, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>)((canErpHpModelsDbAtVdc2TblHpChiTietLuong) => (__builder4) => {
                        __builder4.AddMarkupContent(90, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(91);
                        __builder4.AddAttribute(92, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 47 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(93, "Icon", "close");
                        __builder4.AddAttribute(94, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 47 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(95, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 47 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErpHpModelsDbAtVdc2TblHpChiTietLuong)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(96, "onclick", 
#line 47 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                                                                                                                                                                                                                       true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(97, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(99, (__value) => {
#line 16 "F:\GitHub02\can-erp\hr-pr\server\Pages\TblHpChiTietLuongs.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErpHp.Models.DbAtVdc2.TblHpChiTietLuong>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
