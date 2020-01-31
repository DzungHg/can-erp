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
    public partial class TblPoPurchaseOrderDetailsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail> _getTblPoPurchaseOrderDetailsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail> getTblPoPurchaseOrderDetailsResult
        {
            get
            {
                return _getTblPoPurchaseOrderDetailsResult;
            }
            set
            {
                if(_getTblPoPurchaseOrderDetailsResult != value)
                {
                    _getTblPoPurchaseOrderDetailsResult = value;
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
            var canErpDbAt132GetTblPoPurchaseOrderDetailsResult = await CanErpDbAt132.GetTblPoPurchaseOrderDetails();
            getTblPoPurchaseOrderDetailsResult = canErpDbAt132GetTblPoPurchaseOrderDetailsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoPurchaseOrderDetail>("Add Tbl Po Purchase Order Detail", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail args)
        {
            var result = await DialogService.OpenAsync<EditTblPoPurchaseOrderDetail>("Edit Tbl Po Purchase Order Detail", new Dictionary<string, object>() { {"PO_FK", args.PO_FK}, {"Inventory_FK", args.Inventory_FK} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoPurchaseOrderDetailResult = await CanErpDbAt132.DeleteTblPoPurchaseOrderDetail($"{data.PO_FK}", data.Inventory_FK);
                if (canErpDbAt132DeleteTblPoPurchaseOrderDetailResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoPurchaseOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoPurchaseOrderDetail");
            }
        }
    }
}
