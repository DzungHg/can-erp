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
    public partial class TblGnAddressBooksComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnAddressBook> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBook> _getTblGnAddressBooksResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBook> getTblGnAddressBooksResult
        {
            get
            {
                return _getTblGnAddressBooksResult;
            }
            set
            {
                if(_getTblGnAddressBooksResult != value)
                {
                    _getTblGnAddressBooksResult = value;
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
            var canErpDbAt132GetTblGnAddressBooksResult = await CanErpDbAt132.GetTblGnAddressBooks();
            getTblGnAddressBooksResult = canErpDbAt132GetTblGnAddressBooksResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnAddressBook>("Add Tbl Gn Address Book", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnAddressBook args)
        {
            var result = await DialogService.OpenAsync<EditTblGnAddressBook>("Edit Tbl Gn Address Book", new Dictionary<string, object>() { {"AddressBook_SEQ", args.AddressBook_SEQ} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnAddressBook data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnAddressBookResult = await CanErpDbAt132.DeleteTblGnAddressBook(data.AddressBook_SEQ);
                if (canErpDbAt132DeleteTblGnAddressBookResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnAddressBookException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnAddressBook");
            }
        }
    }
}
