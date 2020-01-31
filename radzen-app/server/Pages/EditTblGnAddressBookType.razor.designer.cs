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
    public partial class EditTblGnAddressBookTypeComponent : ComponentBase
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
        public dynamic AddressBookType_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblGnAddressBookType _tblgnaddressbooktype;
        protected ErpCan.Models.CanErpDbAt132.TblGnAddressBookType tblgnaddressbooktype
        {
            get
            {
                return _tblgnaddressbooktype;
            }
            set
            {
                if(_tblgnaddressbooktype != value)
                {
                    _tblgnaddressbooktype = value;
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

            var canErpDbAt132GetTblGnAddressBookTypeByAddressBookTypeSeqResult = await CanErpDbAt132.GetTblGnAddressBookTypeByAddressBookTypeSeq(int.Parse($"{AddressBookType_SEQ}"));
            tblgnaddressbooktype = canErpDbAt132GetTblGnAddressBookTypeByAddressBookTypeSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnAddressBookType args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnAddressBookTypeResult = await CanErpDbAt132.UpdateTblGnAddressBookType(int.Parse($"{AddressBookType_SEQ}"), tblgnaddressbooktype);
                DialogService.Close(tblgnaddressbooktype);
            }
            catch (Exception canErpDbAt132UpdateTblGnAddressBookTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnAddressBookType");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
