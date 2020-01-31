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
    public partial class TblSoOrderDetailStatusesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus> grid0;

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var canErpDbAt132GetTblSoOrderDetailStatusesResult = await CanErpDbAt132.GetTblSoOrderDetailStatuses();
            getTblSoOrderDetailStatusesResult = canErpDbAt132GetTblSoOrderDetailStatusesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoOrderDetailStatus>("Add Tbl So Order Detail Status", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus args)
        {
            var result = await DialogService.OpenAsync<EditTblSoOrderDetailStatus>("Edit Tbl So Order Detail Status", new Dictionary<string, object>() { {"SODetailStatus_SEQ", args.SODetailStatus_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus data)
        {
            try
            {
                var canErpDbAt132DeleteTblSoOrderDetailStatusResult = await CanErpDbAt132.DeleteTblSoOrderDetailStatus(data.SODetailStatus_SEQ);
                if (canErpDbAt132DeleteTblSoOrderDetailStatusResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblSoOrderDetailStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSoOrderDetailStatus");
            }
        }
    }
}
