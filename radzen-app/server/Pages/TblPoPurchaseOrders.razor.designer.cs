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
    public partial class TblPoPurchaseOrdersComponent : ComponentBase
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
            var result = await DialogService.OpenAsync<AddTblPoPurchaseOrder>("Add Tbl Po Purchase Order", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder args)
        {
            var result = await DialogService.OpenAsync<EditTblPoPurchaseOrder>("Edit Tbl Po Purchase Order", new Dictionary<string, object>() { {"PO_ID", args.PO_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder data)
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
    }
}
