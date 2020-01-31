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
    public partial class AddTblSoOrderDetailComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var canErpDbAt132GetTblSoOrderDetailStatusesResult = await CanErpDbAt132.GetTblSoOrderDetailStatuses();
            getTblSoOrderDetailStatusesResult = canErpDbAt132GetTblSoOrderDetailStatusesResult;

            var canErpDbAt132GetTblSoSalesOrdersResult = await CanErpDbAt132.GetTblSoSalesOrders();
            getTblSoSalesOrdersResult = canErpDbAt132GetTblSoSalesOrdersResult;

            var canErpDbAt132GetTblIcInventoriesResult = await CanErpDbAt132.GetTblIcInventories();
            getTblIcInventoriesResult = canErpDbAt132GetTblIcInventoriesResult;

            tblsoorderdetail = new ErpCan.Models.CanErpDbAt132.TblSoOrderDetail();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoOrderDetail args)
        {
            try
            {
                var canErpDbAt132CreateTblSoOrderDetailResult = await CanErpDbAt132.CreateTblSoOrderDetail(tblsoorderdetail);
                DialogService.Close(tblsoorderdetail);
            }
            catch (Exception canErpDbAt132CreateTblSoOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSoOrderDetail!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
