using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using ErpCan.Models.CanErpDbAt132;

namespace ErpCan.Pages
{
    public partial class EditTblPoApInvoicesDetailComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        [Parameter]
        public dynamic Vendor_ID { get; set; }

        [Parameter]
        public dynamic Invoice_No { get; set; }

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(_canEdit != value)
                {
                    _canEdit = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail _tblpoapinvoicesdetail;
        protected ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail tblpoapinvoicesdetail
        {
            get
            {
                return _tblpoapinvoicesdetail;
            }
            set
            {
                if(_tblpoapinvoicesdetail != value)
                {
                    _tblpoapinvoicesdetail = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> _getTblPoVendorsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> getTblPoVendorsResult
        {
            get
            {
                return _getTblPoVendorsResult;
            }
            set
            {
                if(_getTblPoVendorsResult != value)
                {
                    _getTblPoVendorsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcInventory> _getTblIcInventoriesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcInventory> getTblIcInventoriesResult
        {
            get
            {
                return _getTblIcInventoriesResult;
            }
            set
            {
                if(_getTblIcInventoriesResult != value)
                {
                    _getTblIcInventoriesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcUnit> _getTblIcUnitsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcUnit> getTblIcUnitsResult
        {
            get
            {
                return _getTblIcUnitsResult;
            }
            set
            {
                if(_getTblIcUnitsResult != value)
                {
                    _getTblIcUnitsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var canErpDbAt132GetTblPoApInvoicesDetailByVendorIdAndInvoiceNoResult = await CanErpDbAt132.GetTblPoApInvoicesDetailByVendorIdAndInvoiceNo($"{Vendor_ID}", $"{Invoice_No}");
            tblpoapinvoicesdetail = canErpDbAt132GetTblPoApInvoicesDetailByVendorIdAndInvoiceNoResult;

            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;

            var canErpDbAt132GetTblIcInventoriesResult = await CanErpDbAt132.GetTblIcInventories();
            getTblIcInventoriesResult = canErpDbAt132GetTblIcInventoriesResult;

            var canErpDbAt132GetTblIcUnitsResult = await CanErpDbAt132.GetTblIcUnits();
            getTblIcUnitsResult = canErpDbAt132GetTblIcUnitsResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoApInvoicesDetailResult = await CanErpDbAt132.UpdateTblPoApInvoicesDetail($"{Vendor_ID}", $"{Invoice_No}", tblpoapinvoicesdetail);
                DialogService.Close(tblpoapinvoicesdetail);
            }
            catch (Exception canErpDbAt132UpdateTblPoApInvoicesDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoApInvoicesDetail");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
