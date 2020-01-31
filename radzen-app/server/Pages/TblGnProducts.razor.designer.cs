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
    public partial class TblGnProductsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnProduct> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnProduct> _getTblGnProductsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnProduct> getTblGnProductsResult
        {
            get
            {
                return _getTblGnProductsResult;
            }
            set
            {
                if(_getTblGnProductsResult != value)
                {
                    _getTblGnProductsResult = value;
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
            var canErpDbAt132GetTblGnProductsResult = await CanErpDbAt132.GetTblGnProducts();
            getTblGnProductsResult = canErpDbAt132GetTblGnProductsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnProduct>("Add Tbl Gn Product", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnProduct args)
        {
            var result = await DialogService.OpenAsync<EditTblGnProduct>("Edit Tbl Gn Product", new Dictionary<string, object>() { {"Product_SEQ", args.Product_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnProduct data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnProductResult = await CanErpDbAt132.DeleteTblGnProduct(data.Product_SEQ);
                if (canErpDbAt132DeleteTblGnProductResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnProductException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnProduct");
            }
        }
    }
}
