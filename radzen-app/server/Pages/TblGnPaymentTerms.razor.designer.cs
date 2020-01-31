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
    public partial class TblGnPaymentTermsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm> _getTblGnPaymentTermsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm> getTblGnPaymentTermsResult
        {
            get
            {
                return _getTblGnPaymentTermsResult;
            }
            set
            {
                if(_getTblGnPaymentTermsResult != value)
                {
                    _getTblGnPaymentTermsResult = value;
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
            var canErpDbAt132GetTblGnPaymentTermsResult = await CanErpDbAt132.GetTblGnPaymentTerms();
            getTblGnPaymentTermsResult = canErpDbAt132GetTblGnPaymentTermsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnPaymentTerm>("Add Tbl Gn Payment Term", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm args)
        {
            var result = await DialogService.OpenAsync<EditTblGnPaymentTerm>("Edit Tbl Gn Payment Term", new Dictionary<string, object>() { {"PaymentTerm_SEQ", args.PaymentTerm_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnPaymentTermResult = await CanErpDbAt132.DeleteTblGnPaymentTerm(data.PaymentTerm_SEQ);
                if (canErpDbAt132DeleteTblGnPaymentTermResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnPaymentTermException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnPaymentTerm");
            }
        }
    }
}
