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
    public partial class TblSoOrderDetailsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblSoOrderDetail> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderDetail> _getTblSoOrderDetailsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderDetail> getTblSoOrderDetailsResult
        {
            get
            {
                return _getTblSoOrderDetailsResult;
            }
            set
            {
                if(_getTblSoOrderDetailsResult != value)
                {
                    _getTblSoOrderDetailsResult = value;
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
            var canErpDbAt132GetTblSoOrderDetailsResult = await CanErpDbAt132.GetTblSoOrderDetails();
            getTblSoOrderDetailsResult = canErpDbAt132GetTblSoOrderDetailsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoOrderDetail>("Add Tbl So Order Detail", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblSoOrderDetail args)
        {
            var result = await DialogService.OpenAsync<EditTblSoOrderDetail>("Edit Tbl So Order Detail", new Dictionary<string, object>() { {"SODetail_SEQ", args.SODetail_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblSoOrderDetail data)
        {
            try
            {
                var canErpDbAt132DeleteTblSoOrderDetailResult = await CanErpDbAt132.DeleteTblSoOrderDetail(data.SODetail_SEQ);
                if (canErpDbAt132DeleteTblSoOrderDetailResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblSoOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSoOrderDetail");
            }
        }
    }
}
