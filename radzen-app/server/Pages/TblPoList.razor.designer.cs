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
    public partial class TblPoListComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder> grid0;

        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail> grid1;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder> _getTblPoPurchaseOrdersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder> getTblPoPurchaseOrdersResult
        {
            get
            {
                return _getTblPoPurchaseOrdersResult;
            }
            set
            {
                if(_getTblPoPurchaseOrdersResult != value)
                {
                    _getTblPoPurchaseOrdersResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder _master;
        protected ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder master
        {
            get
            {
                return _master;
            }
            set
            {
                if(_master != value)
                {
                    _master = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail> _TblPoPurchaseOrderDetails;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail> TblPoPurchaseOrderDetails
        {
            get
            {
                return _TblPoPurchaseOrderDetails;
            }
            set
            {
                if(_TblPoPurchaseOrderDetails != value)
                {
                    _TblPoPurchaseOrderDetails = value;
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
            var canErpDbAt132GetTblPoPurchaseOrdersResult = await CanErpDbAt132.GetTblPoPurchaseOrders();
            getTblPoPurchaseOrdersResult = canErpDbAt132GetTblPoPurchaseOrdersResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoList>("Add Tbl PO List", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowDoubleClick(dynamic args)
        {
            DialogService.Open<EditTblPoList>("Edit Tbl PO List", new Dictionary<string, object>() { {"PO_ID", args.PO_ID} });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder args)
        {
            master = args;

            var canErpDbAt132GetTblPoPurchaseOrderDetailsResult = await CanErpDbAt132.GetTblPoPurchaseOrderDetails(new Query() { Filter = $"i => i.PO_FK == '{args.PO_ID}'" });
            TblPoPurchaseOrderDetails = canErpDbAt132GetTblPoPurchaseOrderDetailsResult;
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoPurchaseOrderResult = await CanErpDbAt132.DeleteTblPoPurchaseOrder($"{data.PO_ID}");
                if (canErpDbAt132DeleteTblPoPurchaseOrderResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoPurchaseOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoPurchaseOrder");
            }
        }

        protected async void ChildAddButtonClick(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoPurchaseOrderDetail>("Add Tbl Po Purchase Order Detail", new Dictionary<string, object>() { {"PO_FK", master.PO_ID} });
              grid1.Reload();
        }

        protected async void Grid1RowSelect(ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail args)
        {
            var result = await DialogService.OpenAsync<EditTblPoPurchaseOrderDetail>("Edit Tbl Po Purchase Order Detail", new Dictionary<string, object>() { {"PO_FK", args.PO_FK}, {"Inventory_FK", args.Inventory_FK} });
              grid1.Reload();
        }

        protected async void ChildGridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoPurchaseOrderDetailResult = await CanErpDbAt132.DeleteTblPoPurchaseOrderDetail($"{data.PO_FK}", data.Inventory_FK);
                if (canErpDbAt132DeleteTblPoPurchaseOrderDetailResult != null) {
                    grid1.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoPurchaseOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoPurchaseOrder");
            }
        }
    }
}
