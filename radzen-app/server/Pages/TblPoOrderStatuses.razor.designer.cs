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
    public partial class TblPoOrderStatusesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoOrderStatus> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoOrderStatus> _getTblPoOrderStatusesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoOrderStatus> getTblPoOrderStatusesResult
        {
            get
            {
                return _getTblPoOrderStatusesResult;
            }
            set
            {
                if(_getTblPoOrderStatusesResult != value)
                {
                    _getTblPoOrderStatusesResult = value;
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
            var canErpDbAt132GetTblPoOrderStatusesResult = await CanErpDbAt132.GetTblPoOrderStatuses();
            getTblPoOrderStatusesResult = canErpDbAt132GetTblPoOrderStatusesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoOrderStatus>("Add Tbl Po Order Status", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoOrderStatus args)
        {
            var result = await DialogService.OpenAsync<EditTblPoOrderStatus>("Edit Tbl Po Order Status", new Dictionary<string, object>() { {"POStatus_ID", args.POStatus_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoOrderStatus data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoOrderStatusResult = await CanErpDbAt132.DeleteTblPoOrderStatus($"{data.POStatus_ID}");
                if (canErpDbAt132DeleteTblPoOrderStatusResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoOrderStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoOrderStatus");
            }
        }
    }
}
