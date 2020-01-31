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
    public partial class TblIcInventoriesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcInventory> grid0;

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
            var canErpDbAt132GetTblIcInventoriesResult = await CanErpDbAt132.GetTblIcInventories();
            getTblIcInventoriesResult = canErpDbAt132GetTblIcInventoriesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblIcInventory>("Add Tbl Ic Inventory", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblIcInventory args)
        {
            var result = await DialogService.OpenAsync<EditTblIcInventory>("Edit Tbl Ic Inventory", new Dictionary<string, object>() { {"Inventory_SEQ", args.Inventory_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblIcInventory data)
        {
            try
            {
                var canErpDbAt132DeleteTblIcInventoryResult = await CanErpDbAt132.DeleteTblIcInventory(data.Inventory_SEQ);
                if (canErpDbAt132DeleteTblIcInventoryResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblIcInventoryException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblIcInventory");
            }
        }
    }
}
