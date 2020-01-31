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
    public partial class TblPoVendorsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoVendor> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> _getTblPoVendorsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> getTblPoVendorsResult
        {
            get
            {
                return _getTblPoVendorsResult;
            }
            set
            {
                if(_getTblPoVendorsResult != value)
                {
                    _getTblPoVendorsResult = value;
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
            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblPoVendor>("Add Tbl Po Vendor", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblPoVendor args)
        {
            var result = await DialogService.OpenAsync<EditTblPoVendor>("Edit Tbl Po Vendor", new Dictionary<string, object>() { {"Vendor_ID", args.Vendor_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var canErpDbAt132DeleteTblPoVendorResult = await CanErpDbAt132.DeleteTblPoVendor($"{data.Vendor_ID}");
                if (canErpDbAt132DeleteTblPoVendorResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblPoVendorException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPoVendor");
            }
        }
    }
}
