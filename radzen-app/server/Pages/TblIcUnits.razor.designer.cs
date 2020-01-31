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
    public partial class TblIcUnitsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcUnit> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcUnit> _getTblIcUnitsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcUnit> getTblIcUnitsResult
        {
            get
            {
                return _getTblIcUnitsResult;
            }
            set
            {
                if(_getTblIcUnitsResult != value)
                {
                    _getTblIcUnitsResult = value;
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
            var canErpDbAt132GetTblIcUnitsResult = await CanErpDbAt132.GetTblIcUnits();
            getTblIcUnitsResult = canErpDbAt132GetTblIcUnitsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblIcUnit>("Add Tbl Ic Unit", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblIcUnit args)
        {
            var result = await DialogService.OpenAsync<EditTblIcUnit>("Edit Tbl Ic Unit", new Dictionary<string, object>() { {"Unit_SEQ", args.Unit_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblIcUnit data)
        {
            try
            {
                var canErpDbAt132DeleteTblIcUnitResult = await CanErpDbAt132.DeleteTblIcUnit(data.Unit_SEQ);
                if (canErpDbAt132DeleteTblIcUnitResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblIcUnitException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblIcUnit");
            }
        }
    }
}
