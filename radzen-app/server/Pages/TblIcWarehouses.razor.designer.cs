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
    public partial class TblIcWarehousesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcWarehouse> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcWarehouse> _getTblIcWarehousesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcWarehouse> getTblIcWarehousesResult
        {
            get
            {
                return _getTblIcWarehousesResult;
            }
            set
            {
                if(_getTblIcWarehousesResult != value)
                {
                    _getTblIcWarehousesResult = value;
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
            var canErpDbAt132GetTblIcWarehousesResult = await CanErpDbAt132.GetTblIcWarehouses();
            getTblIcWarehousesResult = canErpDbAt132GetTblIcWarehousesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblIcWarehouse>("Add Tbl Ic Warehouse", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblIcWarehouse args)
        {
            var result = await DialogService.OpenAsync<EditTblIcWarehouse>("Edit Tbl Ic Warehouse", new Dictionary<string, object>() { {"Warehouse_ID", args.Warehouse_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblIcWarehouse data)
        {
            try
            {
                var canErpDbAt132DeleteTblIcWarehouseResult = await CanErpDbAt132.DeleteTblIcWarehouse($"{data.Warehouse_ID}");
                if (canErpDbAt132DeleteTblIcWarehouseResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblIcWarehouseException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblIcWarehouse");
            }
        }
    }
}
