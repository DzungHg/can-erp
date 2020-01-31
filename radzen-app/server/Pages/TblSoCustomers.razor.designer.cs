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
    public partial class TblSoCustomersComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblSoCustomer> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoCustomer> _getTblSoCustomersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoCustomer> getTblSoCustomersResult
        {
            get
            {
                return _getTblSoCustomersResult;
            }
            set
            {
                if(_getTblSoCustomersResult != value)
                {
                    _getTblSoCustomersResult = value;
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
            var canErpDbAt132GetTblSoCustomersResult = await CanErpDbAt132.GetTblSoCustomers();
            getTblSoCustomersResult = canErpDbAt132GetTblSoCustomersResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoCustomer>("Add Tbl So Customer", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblSoCustomer args)
        {
            var result = await DialogService.OpenAsync<EditTblSoCustomer>("Edit Tbl So Customer", new Dictionary<string, object>() { {"Customer_SEQ", args.Customer_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblSoCustomer data)
        {
            try
            {
                var canErpDbAt132DeleteTblSoCustomerResult = await CanErpDbAt132.DeleteTblSoCustomer(data.Customer_SEQ);
                if (canErpDbAt132DeleteTblSoCustomerResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblSoCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSoCustomer");
            }
        }
    }
}
