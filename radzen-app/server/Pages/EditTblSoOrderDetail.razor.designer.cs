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
    public partial class EditTblSoOrderDetailComponent : ComponentBase
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
        public dynamic SODetail_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblSoOrderDetail _tblsoorderdetail;
        protected ErpCan.Models.CanErpDbAt132.TblSoOrderDetail tblsoorderdetail
        {
            get
            {
                return _tblsoorderdetail;
            }
            set
            {
                if(_tblsoorderdetail != value)
                {
                    _tblsoorderdetail = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus> _getTblSoOrderDetailStatusesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus> getTblSoOrderDetailStatusesResult
        {
            get
            {
                return _getTblSoOrderDetailStatusesResult;
            }
            set
            {
                if(_getTblSoOrderDetailStatusesResult != value)
                {
                    _getTblSoOrderDetailStatusesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder> _getTblSoSalesOrdersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder> getTblSoSalesOrdersResult
        {
            get
            {
                return _getTblSoSalesOrdersResult;
            }
            set
            {
                if(_getTblSoSalesOrdersResult != value)
                {
                    _getTblSoSalesOrdersResult = value;
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

            var canErpDbAt132GetTblSoOrderDetailBySoDetailSeqResult = await CanErpDbAt132.GetTblSoOrderDetailBySoDetailSeq(int.Parse($"{SODetail_SEQ}"));
            tblsoorderdetail = canErpDbAt132GetTblSoOrderDetailBySoDetailSeqResult;

            var canErpDbAt132GetTblSoOrderDetailStatusesResult = await CanErpDbAt132.GetTblSoOrderDetailStatuses();
            getTblSoOrderDetailStatusesResult = canErpDbAt132GetTblSoOrderDetailStatusesResult;

            var canErpDbAt132GetTblSoSalesOrdersResult = await CanErpDbAt132.GetTblSoSalesOrders();
            getTblSoSalesOrdersResult = canErpDbAt132GetTblSoSalesOrdersResult;

            var canErpDbAt132GetTblIcInventoriesResult = await CanErpDbAt132.GetTblIcInventories();
            getTblIcInventoriesResult = canErpDbAt132GetTblIcInventoriesResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoOrderDetail args)
        {
            try
            {
                var canErpDbAt132UpdateTblSoOrderDetailResult = await CanErpDbAt132.UpdateTblSoOrderDetail(int.Parse($"{SODetail_SEQ}"), tblsoorderdetail);
                DialogService.Close(tblsoorderdetail);
            }
            catch (Exception canErpDbAt132UpdateTblSoOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSoOrderDetail");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
