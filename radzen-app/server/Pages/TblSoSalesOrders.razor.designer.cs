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
    public partial class TblSoSalesOrdersComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder> grid0;

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var canErpDbAt132GetTblSoSalesOrdersResult = await CanErpDbAt132.GetTblSoSalesOrders();
            getTblSoSalesOrdersResult = canErpDbAt132GetTblSoSalesOrdersResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoSalesOrder>("Add Tbl So Sales Order", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblSoSalesOrder args)
        {
            var result = await DialogService.OpenAsync<EditTblSoSalesOrder>("Edit Tbl So Sales Order", new Dictionary<string, object>() { {"SO_SEQ", args.SO_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblSoSalesOrder data)
        {
            try
            {
                var canErpDbAt132DeleteTblSoSalesOrderResult = await CanErpDbAt132.DeleteTblSoSalesOrder(data.SO_SEQ);
                if (canErpDbAt132DeleteTblSoSalesOrderResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblSoSalesOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSoSalesOrder");
            }
        }
    }
}
