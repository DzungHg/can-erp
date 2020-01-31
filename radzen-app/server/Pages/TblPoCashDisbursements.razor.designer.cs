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
    public partial class TblPoCashDisbursementsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement> _getTblPoCashDisbursementsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement> getTblPoCashDisbursementsResult
        {
            get
            {
                return _getTblPoCashDisbursementsResult;
            }
            set
            {
                if(_getTblPoCashDisbursementsResult != value)
                {
                    _getTblPoCashDisbursementsResult = value;
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
            var canErpDbAt132GetTblPoCashDisbursementsResult = await CanErpDbAt132.GetTblPoCashDisbursements();
            getTblPoCashDisbursementsResult = canErpDbAt132GetTblPoCashDisbursementsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoCashDisbursement>("Add Tbl Po Cash Disbursement", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement args)
        {
            var result = await DialogService.OpenAsync<EditTblPoCashDisbursement>("Edit Tbl Po Cash Disbursement", new Dictionary<string, object>() { {"PO_CashDisb_No", args.PO_CashDisb_No} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoCashDisbursementResult = await CanErpDbAt132.DeleteTblPoCashDisbursement($"{data.PO_CashDisb_No}");
                if (canErpDbAt132DeleteTblPoCashDisbursementResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoCashDisbursementException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoCashDisbursement");
            }
        }
    }
}
