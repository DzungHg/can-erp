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
    public partial class TblGnIncotermsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnIncoterm> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnIncoterm> _getTblGnIncotermsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnIncoterm> getTblGnIncotermsResult
        {
            get
            {
                return _getTblGnIncotermsResult;
            }
            set
            {
                if(_getTblGnIncotermsResult != value)
                {
                    _getTblGnIncotermsResult = value;
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
            var canErpDbAt132GetTblGnIncotermsResult = await CanErpDbAt132.GetTblGnIncoterms();
            getTblGnIncotermsResult = canErpDbAt132GetTblGnIncotermsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnIncoterm>("Add Tbl Gn Incoterm", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnIncoterm args)
        {
            var result = await DialogService.OpenAsync<EditTblGnIncoterm>("Edit Tbl Gn Incoterm", new Dictionary<string, object>() { {"Incoterm_ID", args.Incoterm_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnIncoterm data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnIncotermResult = await CanErpDbAt132.DeleteTblGnIncoterm($"{data.Incoterm_ID}");
                if (canErpDbAt132DeleteTblGnIncotermResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnIncotermException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnIncoterm");
            }
        }
    }
}
