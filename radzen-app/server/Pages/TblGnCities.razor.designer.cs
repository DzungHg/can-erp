using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CanErp2.Models.DbAtVdc2;
using Microsoft.EntityFrameworkCore;

namespace CanErp2.Pages
{
    public partial class TblGnCitiesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected DbAtVdc2Service DbAtVdc2 { get; set; }

        protected RadzenGrid<CanErp2.Models.DbAtVdc2.TblGnCity> grid0;

        IEnumerable<CanErp2.Models.DbAtVdc2.TblGnCity> _getTblGnCitiesResult;
        protected IEnumerable<CanErp2.Models.DbAtVdc2.TblGnCity> getTblGnCitiesResult
        {
            get
            {
                return _getTblGnCitiesResult;
            }
            set
            {
                if(!object.Equals(_getTblGnCitiesResult, value))
                {
                    _getTblGnCitiesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var dbAtVdc2GetTblGnCitiesResult = await DbAtVdc2.GetTblGnCities();
            getTblGnCitiesResult = dbAtVdc2GetTblGnCitiesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnCity>("Add Tbl Gn City", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErp2.Models.DbAtVdc2.TblGnCity args)
        {
            var result = await DialogService.OpenAsync<EditTblGnCity>("Edit Tbl Gn City", new Dictionary<string, object>() { {"City_SEQ", args.City_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var dbAtVdc2DeleteTblGnCityResult = await DbAtVdc2.DeleteTblGnCity(data.City_SEQ);
                if (dbAtVdc2DeleteTblGnCityResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblGnCityException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnCity");
            }
        }
    }
}
