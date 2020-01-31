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
    public partial class TblPoApInvoicesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoApInvoice> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoApInvoice> _getTblPoApInvoicesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoApInvoice> getTblPoApInvoicesResult
        {
            get
            {
                return _getTblPoApInvoicesResult;
            }
            set
            {
                if(_getTblPoApInvoicesResult != value)
                {
                    _getTblPoApInvoicesResult = value;
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
            var canErpDbAt132GetTblPoApInvoicesResult = await CanErpDbAt132.GetTblPoApInvoices();
            getTblPoApInvoicesResult = canErpDbAt132GetTblPoApInvoicesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoApInvoice>("Add Tbl Po Ap Invoice", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoApInvoice args)
        {
            var result = await DialogService.OpenAsync<EditTblPoApInvoice>("Edit Tbl Po Ap Invoice", new Dictionary<string, object>() { {"Vendor_ID", args.Vendor_ID}, {"Invoice_No", args.Invoice_No} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoApInvoice data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoApInvoiceResult = await CanErpDbAt132.DeleteTblPoApInvoice($"{data.Vendor_ID}", $"{data.Invoice_No}");
                if (canErpDbAt132DeleteTblPoApInvoiceResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoApInvoiceException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoApInvoice");
            }
        }
    }
}
