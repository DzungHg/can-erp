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
    public partial class TblIcClassificationsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcClassification> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcClassification> _getTblIcClassificationsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcClassification> getTblIcClassificationsResult
        {
            get
            {
                return _getTblIcClassificationsResult;
            }
            set
            {
                if(_getTblIcClassificationsResult != value)
                {
                    _getTblIcClassificationsResult = value;
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
            var canErpDbAt132GetTblIcClassificationsResult = await CanErpDbAt132.GetTblIcClassifications();
            getTblIcClassificationsResult = canErpDbAt132GetTblIcClassificationsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblIcClassification>("Add Tbl Ic Classification", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblIcClassification args)
        {
            var result = await DialogService.OpenAsync<EditTblIcClassification>("Edit Tbl Ic Classification", new Dictionary<string, object>() { {"Classifi_ID", args.Classifi_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblIcClassification data)
        {
            try
            {
                var canErpDbAt132DeleteTblIcClassificationResult = await CanErpDbAt132.DeleteTblIcClassification($"{data.Classifi_ID}");
                if (canErpDbAt132DeleteTblIcClassificationResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblIcClassificationException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblIcClassification");
            }
        }
    }
}
