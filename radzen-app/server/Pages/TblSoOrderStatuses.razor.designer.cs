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
    public partial class TblSoOrderStatusesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblSoOrderStatus> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderStatus> _getTblSoOrderStatusesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderStatus> getTblSoOrderStatusesResult
        {
            get
            {
                return _getTblSoOrderStatusesResult;
            }
            set
            {
                if(_getTblSoOrderStatusesResult != value)
                {
                    _getTblSoOrderStatusesResult = value;
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
            var canErpDbAt132GetTblSoOrderStatusesResult = await CanErpDbAt132.GetTblSoOrderStatuses();
            getTblSoOrderStatusesResult = canErpDbAt132GetTblSoOrderStatusesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoOrderStatus>("Add Tbl So Order Status", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblSoOrderStatus args)
        {
            var result = await DialogService.OpenAsync<EditTblSoOrderStatus>("Edit Tbl So Order Status", new Dictionary<string, object>() { {"SOStatus_SEQ", args.SOStatus_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblSoOrderStatus data)
        {
            try
            {
                var canErpDbAt132DeleteTblSoOrderStatusResult = await CanErpDbAt132.DeleteTblSoOrderStatus(data.SOStatus_SEQ);
                if (canErpDbAt132DeleteTblSoOrderStatusResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblSoOrderStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSoOrderStatus");
            }
        }
    }
}
