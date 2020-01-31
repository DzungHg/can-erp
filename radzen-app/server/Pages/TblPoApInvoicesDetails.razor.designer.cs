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
    public partial class TblPoApInvoicesDetailsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail> _getTblPoApInvoicesDetailsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail> getTblPoApInvoicesDetailsResult
        {
            get
            {
                return _getTblPoApInvoicesDetailsResult;
            }
            set
            {
                if(_getTblPoApInvoicesDetailsResult != value)
                {
                    _getTblPoApInvoicesDetailsResult = value;
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
            var canErpDbAt132GetTblPoApInvoicesDetailsResult = await CanErpDbAt132.GetTblPoApInvoicesDetails();
            getTblPoApInvoicesDetailsResult = canErpDbAt132GetTblPoApInvoicesDetailsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoApInvoicesDetail>("Add Tbl Po Ap Invoices Detail", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail args)
        {
            var result = await DialogService.OpenAsync<EditTblPoApInvoicesDetail>("Edit Tbl Po Ap Invoices Detail", new Dictionary<string, object>() { {"Vendor_ID", args.Vendor_ID}, {"Invoice_No", args.Invoice_No} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoApInvoicesDetailResult = await CanErpDbAt132.DeleteTblPoApInvoicesDetail($"{data.Vendor_ID}", $"{data.Invoice_No}");
                if (canErpDbAt132DeleteTblPoApInvoicesDetailResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoApInvoicesDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoApInvoicesDetail");
            }
        }
    }
}
