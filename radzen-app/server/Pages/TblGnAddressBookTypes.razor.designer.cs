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
    public partial class TblGnAddressBookTypesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnAddressBookType> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBookType> _getTblGnAddressBookTypesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBookType> getTblGnAddressBookTypesResult
        {
            get
            {
                return _getTblGnAddressBookTypesResult;
            }
            set
            {
                if(_getTblGnAddressBookTypesResult != value)
                {
                    _getTblGnAddressBookTypesResult = value;
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
            var canErpDbAt132GetTblGnAddressBookTypesResult = await CanErpDbAt132.GetTblGnAddressBookTypes();
            getTblGnAddressBookTypesResult = canErpDbAt132GetTblGnAddressBookTypesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnAddressBookType>("Add Tbl Gn Address Book Type", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnAddressBookType args)
        {
            var result = await DialogService.OpenAsync<EditTblGnAddressBookType>("Edit Tbl Gn Address Book Type", new Dictionary<string, object>() { {"AddressBookType_SEQ", args.AddressBookType_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnAddressBookType data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnAddressBookTypeResult = await CanErpDbAt132.DeleteTblGnAddressBookType(data.AddressBookType_SEQ);
                if (canErpDbAt132DeleteTblGnAddressBookTypeResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnAddressBookTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnAddressBookType");
            }
        }
    }
}
