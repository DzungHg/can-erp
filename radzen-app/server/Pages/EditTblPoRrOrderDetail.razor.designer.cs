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
    public partial class EditTblPoRrOrderDetailComponent : ComponentBase
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
        public dynamic RR_FK { get; set; }

        [Parameter]
        public dynamic Inventory_FK { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail _tblporrorderdetail;
        protected ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail tblporrorderdetail
        {
            get
            {
                return _tblporrorderdetail;
            }
            set
            {
                if(_tblporrorderdetail != value)
                {
                    _tblporrorderdetail = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRecReport> _getTblPoRecReportsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRecReport> getTblPoRecReportsResult
        {
            get
            {
                return _getTblPoRecReportsResult;
            }
            set
            {
                if(_getTblPoRecReportsResult != value)
                {
                    _getTblPoRecReportsResult = value;
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var canErpDbAt132GetTblPoRrOrderDetailByRrFkAndInventoryFkResult = await CanErpDbAt132.GetTblPoRrOrderDetailByRrFkAndInventoryFk($"{RR_FK}", int.Parse($"{Inventory_FK}"));
            tblporrorderdetail = canErpDbAt132GetTblPoRrOrderDetailByRrFkAndInventoryFkResult;

            var canErpDbAt132GetTblPoRecReportsResult = await CanErpDbAt132.GetTblPoRecReports();
            getTblPoRecReportsResult = canErpDbAt132GetTblPoRecReportsResult;

            var canErpDbAt132GetTblIcInventoriesResult = await CanErpDbAt132.GetTblIcInventories();
            getTblIcInventoriesResult = canErpDbAt132GetTblIcInventoriesResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoRrOrderDetailResult = await CanErpDbAt132.UpdateTblPoRrOrderDetail($"{RR_FK}", int.Parse($"{Inventory_FK}"), tblporrorderdetail);
                DialogService.Close(tblporrorderdetail);
            }
            catch (Exception canErpDbAt132UpdateTblPoRrOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoRrOrderDetail");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
