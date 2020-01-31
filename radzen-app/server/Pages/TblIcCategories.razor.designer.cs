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
    public partial class TblIcCategoriesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcCategory> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcCategory> _getTblIcCategoriesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcCategory> getTblIcCategoriesResult
        {
            get
            {
                return _getTblIcCategoriesResult;
            }
            set
            {
                if(_getTblIcCategoriesResult != value)
                {
                    _getTblIcCategoriesResult = value;
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
            var canErpDbAt132GetTblIcCategoriesResult = await CanErpDbAt132.GetTblIcCategories();
            getTblIcCategoriesResult = canErpDbAt132GetTblIcCategoriesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblIcCategory>("Add Tbl Ic Category", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblIcCategory args)
        {
            var result = await DialogService.OpenAsync<EditTblIcCategory>("Edit Tbl Ic Category", new Dictionary<string, object>() { {"Category_ID", args.Category_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblIcCategory data)
        {
            try
            {
                var canErpDbAt132DeleteTblIcCategoryResult = await CanErpDbAt132.DeleteTblIcCategory($"{data.Category_ID}");
                if (canErpDbAt132DeleteTblIcCategoryResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblIcCategoryException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblIcCategory");
            }
        }
    }
}
