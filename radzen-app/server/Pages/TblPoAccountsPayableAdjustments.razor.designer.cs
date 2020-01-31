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
    public partial class TblPoAccountsPayableAdjustmentsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> _getTblPoAccountsPayableAdjustmentsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> getTblPoAccountsPayableAdjustmentsResult
        {
            get
            {
                return _getTblPoAccountsPayableAdjustmentsResult;
            }
            set
            {
                if(_getTblPoAccountsPayableAdjustmentsResult != value)
                {
                    _getTblPoAccountsPayableAdjustmentsResult = value;
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
            var canErpDbAt132GetTblPoAccountsPayableAdjustmentsResult = await CanErpDbAt132.GetTblPoAccountsPayableAdjustments();
            getTblPoAccountsPayableAdjustmentsResult = canErpDbAt132GetTblPoAccountsPayableAdjustmentsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoAccountsPayableAdjustment>("Add Tbl Po Accounts Payable Adjustment", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment args)
        {
            var result = await DialogService.OpenAsync<EditTblPoAccountsPayableAdjustment>("Edit Tbl Po Accounts Payable Adjustment", new Dictionary<string, object>() { {"Voucher_No", args.Voucher_No} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoAccountsPayableAdjustmentResult = await CanErpDbAt132.DeleteTblPoAccountsPayableAdjustment($"{data.Voucher_No}");
                if (canErpDbAt132DeleteTblPoAccountsPayableAdjustmentResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoAccountsPayableAdjustmentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoAccountsPayableAdjustment");
            }
        }
    }
}
