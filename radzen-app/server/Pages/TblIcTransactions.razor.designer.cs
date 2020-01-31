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
    public partial class TblIcTransactionsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcTransaction> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransaction> _getTblIcTransactionsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransaction> getTblIcTransactionsResult
        {
            get
            {
                return _getTblIcTransactionsResult;
            }
            set
            {
                if(_getTblIcTransactionsResult != value)
                {
                    _getTblIcTransactionsResult = value;
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
            var canErpDbAt132GetTblIcTransactionsResult = await CanErpDbAt132.GetTblIcTransactions();
            getTblIcTransactionsResult = canErpDbAt132GetTblIcTransactionsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblIcTransaction>("Add Tbl Ic Transaction", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblIcTransaction args)
        {
            var result = await DialogService.OpenAsync<EditTblIcTransaction>("Edit Tbl Ic Transaction", new Dictionary<string, object>() { {"Trans_No", args.Trans_No} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblIcTransaction data)
        {
            try
            {
                var canErpDbAt132DeleteTblIcTransactionResult = await CanErpDbAt132.DeleteTblIcTransaction($"{data.Trans_No}");
                if (canErpDbAt132DeleteTblIcTransactionResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblIcTransactionException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblIcTransaction");
            }
        }
    }
}
