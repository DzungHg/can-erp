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
    public partial class TblPoRecReportsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoRecReport> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRecReport> _getTblPoRecReportsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRecReport> getTblPoRecReportsResult
        {
            get
            {
                return _getTblPoRecReportsResult;
            }
            set
            {
                if(_getTblPoRecReportsResult != value)
                {
                    _getTblPoRecReportsResult = value;
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
            var canErpDbAt132GetTblPoRecReportsResult = await CanErpDbAt132.GetTblPoRecReports();
            getTblPoRecReportsResult = canErpDbAt132GetTblPoRecReportsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoRecReport>("Add Tbl Po Rec Report", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoRecReport args)
        {
            var result = await DialogService.OpenAsync<EditTblPoRecReport>("Edit Tbl Po Rec Report", new Dictionary<string, object>() { {"RR_No", args.RR_No} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoRecReport data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoRecReportResult = await CanErpDbAt132.DeleteTblPoRecReport($"{data.RR_No}");
                if (canErpDbAt132DeleteTblPoRecReportResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoRecReportException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoRecReport");
            }
        }
    }
}
