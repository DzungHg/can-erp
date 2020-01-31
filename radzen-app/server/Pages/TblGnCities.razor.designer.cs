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
    public partial class TblGnCitiesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnCity> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnCity> _getTblGnCitiesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnCity> getTblGnCitiesResult
        {
            get
            {
                return _getTblGnCitiesResult;
            }
            set
            {
                if(_getTblGnCitiesResult != value)
                {
                    _getTblGnCitiesResult = value;
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
            var canErpDbAt132GetTblGnCitiesResult = await CanErpDbAt132.GetTblGnCities();
            getTblGnCitiesResult = canErpDbAt132GetTblGnCitiesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnCity>("Add Tbl Gn City", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnCity args)
        {
            var result = await DialogService.OpenAsync<EditTblGnCity>("Edit Tbl Gn City", new Dictionary<string, object>() { {"City_SEQ", args.City_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnCity data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnCityResult = await CanErpDbAt132.DeleteTblGnCity(data.City_SEQ);
                if (canErpDbAt132DeleteTblGnCityResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnCityException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnCity");
            }
        }
    }
}
