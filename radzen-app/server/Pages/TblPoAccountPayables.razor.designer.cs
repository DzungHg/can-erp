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
    public partial class TblPoAccountPayablesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable> _getTblPoAccountPayablesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable> getTblPoAccountPayablesResult
        {
            get
            {
                return _getTblPoAccountPayablesResult;
            }
            set
            {
                if(_getTblPoAccountPayablesResult != value)
                {
                    _getTblPoAccountPayablesResult = value;
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
            var canErpDbAt132GetTblPoAccountPayablesResult = await CanErpDbAt132.GetTblPoAccountPayables();
            getTblPoAccountPayablesResult = canErpDbAt132GetTblPoAccountPayablesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoAccountPayable>("Add Tbl Po Account Payable", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoAccountPayable args)
        {
            var result = await DialogService.OpenAsync<EditTblPoAccountPayable>("Edit Tbl Po Account Payable", new Dictionary<string, object>() { {"AP_No", args.AP_No} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoAccountPayable data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoAccountPayableResult = await CanErpDbAt132.DeleteTblPoAccountPayable($"{data.AP_No}");
                if (canErpDbAt132DeleteTblPoAccountPayableResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoAccountPayableException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoAccountPayable");
            }
        }
    }
}
