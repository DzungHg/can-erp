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
    public partial class TblGnShipViaComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnShipVium> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnShipVium> _getTblGnShipViaResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnShipVium> getTblGnShipViaResult
        {
            get
            {
                return _getTblGnShipViaResult;
            }
            set
            {
                if(_getTblGnShipViaResult != value)
                {
                    _getTblGnShipViaResult = value;
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
            var canErpDbAt132GetTblGnShipViaResult = await CanErpDbAt132.GetTblGnShipVia();
            getTblGnShipViaResult = canErpDbAt132GetTblGnShipViaResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnShipVium>("Add Tbl Gn Ship Vium", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnShipVium args)
        {
            var result = await DialogService.OpenAsync<EditTblGnShipVium>("Edit Tbl Gn Ship Vium", new Dictionary<string, object>() { {"ShipVia_SEQ", args.ShipVia_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnShipVium data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnShipViumResult = await CanErpDbAt132.DeleteTblGnShipVium(data.ShipVia_SEQ);
                if (canErpDbAt132DeleteTblGnShipViumResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnShipViumException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnShipVium");
            }
        }
    }
}
