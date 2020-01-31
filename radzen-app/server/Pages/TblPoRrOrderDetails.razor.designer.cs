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
    public partial class TblPoRrOrderDetailsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail> _getTblPoRrOrderDetailsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail> getTblPoRrOrderDetailsResult
        {
            get
            {
                return _getTblPoRrOrderDetailsResult;
            }
            set
            {
                if(_getTblPoRrOrderDetailsResult != value)
                {
                    _getTblPoRrOrderDetailsResult = value;
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
            var canErpDbAt132GetTblPoRrOrderDetailsResult = await CanErpDbAt132.GetTblPoRrOrderDetails();
            getTblPoRrOrderDetailsResult = canErpDbAt132GetTblPoRrOrderDetailsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoRrOrderDetail>("Add Tbl Po Rr Order Detail", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail args)
        {
            var result = await DialogService.OpenAsync<EditTblPoRrOrderDetail>("Edit Tbl Po Rr Order Detail", new Dictionary<string, object>() { {"RR_FK", args.RR_FK}, {"Inventory_FK", args.Inventory_FK} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoRrOrderDetailResult = await CanErpDbAt132.DeleteTblPoRrOrderDetail($"{data.RR_FK}", data.Inventory_FK);
                if (canErpDbAt132DeleteTblPoRrOrderDetailResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoRrOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoRrOrderDetail");
            }
        }
    }
}
