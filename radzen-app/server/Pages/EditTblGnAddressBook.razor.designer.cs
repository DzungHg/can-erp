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
    public partial class EditTblGnAddressBookComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        [Parameter]
        public dynamic AddressBook_SEQ { get; set; }

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(_canEdit != value)
                {
                    _canEdit = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblGnAddressBook _tblgnaddressbook;
        protected ErpCan.Models.CanErpDbAt132.TblGnAddressBook tblgnaddressbook
        {
            get
            {
                return _tblgnaddressbook;
            }
            set
            {
                if(_tblgnaddressbook != value)
                {
                    _tblgnaddressbook = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

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
            canEdit = true;

            var canErpDbAt132GetTblGnAddressBookByAddressBookSeqResult = await CanErpDbAt132.GetTblGnAddressBookByAddressBookSeq(int.Parse($"{AddressBook_SEQ}"));
            tblgnaddressbook = canErpDbAt132GetTblGnAddressBookByAddressBookSeqResult;

            var canErpDbAt132GetTblGnAddressBookTypesResult = await CanErpDbAt132.GetTblGnAddressBookTypes();
            getTblGnAddressBookTypesResult = canErpDbAt132GetTblGnAddressBookTypesResult;

            var canErpDbAt132GetTblGnGendersResult = await CanErpDbAt132.GetTblGnGenders();
            getTblGnGendersResult = canErpDbAt132GetTblGnGendersResult;

            var canErpDbAt132GetTblGnCitiesResult = await CanErpDbAt132.GetTblGnCities();
            getTblGnCitiesResult = canErpDbAt132GetTblGnCitiesResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnAddressBook args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnAddressBookResult = await CanErpDbAt132.UpdateTblGnAddressBook(int.Parse($"{AddressBook_SEQ}"), tblgnaddressbook);
                DialogService.Close(tblgnaddressbook);
            }
            catch (Exception canErpDbAt132UpdateTblGnAddressBookException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnAddressBook");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
