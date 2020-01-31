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
    public partial class TblGnGendersComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnGender> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnGender> _getTblGnGendersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnGender> getTblGnGendersResult
        {
            get
            {
                return _getTblGnGendersResult;
            }
            set
            {
                if(_getTblGnGendersResult != value)
                {
                    _getTblGnGendersResult = value;
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
            var canErpDbAt132GetTblGnGendersResult = await CanErpDbAt132.GetTblGnGenders();
            getTblGnGendersResult = canErpDbAt132GetTblGnGendersResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnGender>("Add Tbl Gn Gender", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnGender args)
        {
            var result = await DialogService.OpenAsync<EditTblGnGender>("Edit Tbl Gn Gender", new Dictionary<string, object>() { {"Gender_SEQ", args.Gender_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnGender data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnGenderResult = await CanErpDbAt132.DeleteTblGnGender(data.Gender_SEQ);
                if (canErpDbAt132DeleteTblGnGenderResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnGenderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnGender");
            }
        }
    }
}
