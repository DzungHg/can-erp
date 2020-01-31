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
    public partial class TblIcTransactionTypesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcTransactionType> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransactionType> _getTblIcTransactionTypesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransactionType> getTblIcTransactionTypesResult
        {
            get
            {
                return _getTblIcTransactionTypesResult;
            }
            set
            {
                if(_getTblIcTransactionTypesResult != value)
                {
                    _getTblIcTransactionTypesResult = value;
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
            var canErpDbAt132GetTblIcTransactionTypesResult = await CanErpDbAt132.GetTblIcTransactionTypes();
            getTblIcTransactionTypesResult = canErpDbAt132GetTblIcTransactionTypesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblIcTransactionType>("Add Tbl Ic Transaction Type", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblIcTransactionType args)
        {
            var result = await DialogService.OpenAsync<EditTblIcTransactionType>("Edit Tbl Ic Transaction Type", new Dictionary<string, object>() { {"Transaction_ID", args.Transaction_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblIcTransactionType data)
        {
            try
            {
                var canErpDbAt132DeleteTblIcTransactionTypeResult = await CanErpDbAt132.DeleteTblIcTransactionType($"{data.Transaction_ID}");
                if (canErpDbAt132DeleteTblIcTransactionTypeResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblIcTransactionTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblIcTransactionType");
            }
        }
    }
}
