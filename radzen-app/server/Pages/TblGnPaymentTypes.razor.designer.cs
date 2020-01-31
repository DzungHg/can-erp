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
    public partial class TblGnPaymentTypesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnPaymentType> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentType> _getTblGnPaymentTypesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentType> getTblGnPaymentTypesResult
        {
            get
            {
                return _getTblGnPaymentTypesResult;
            }
            set
            {
                if(_getTblGnPaymentTypesResult != value)
                {
                    _getTblGnPaymentTypesResult = value;
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
            var canErpDbAt132GetTblGnPaymentTypesResult = await CanErpDbAt132.GetTblGnPaymentTypes();
            getTblGnPaymentTypesResult = canErpDbAt132GetTblGnPaymentTypesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnPaymentType>("Add Tbl Gn Payment Type", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnPaymentType args)
        {
            var result = await DialogService.OpenAsync<EditTblGnPaymentType>("Edit Tbl Gn Payment Type", new Dictionary<string, object>() { {"PaymentType_SEQ", args.PaymentType_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnPaymentType data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnPaymentTypeResult = await CanErpDbAt132.DeleteTblGnPaymentType(data.PaymentType_SEQ);
                if (canErpDbAt132DeleteTblGnPaymentTypeResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnPaymentTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnPaymentType");
            }
        }
    }
}
