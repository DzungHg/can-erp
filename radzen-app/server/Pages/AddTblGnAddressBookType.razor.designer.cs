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
    public partial class AddTblGnAddressBookTypeComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblgnaddressbooktype = new ErpCan.Models.CanErpDbAt132.TblGnAddressBookType();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnAddressBookType args)
        {
            try
            {
                var canErpDbAt132CreateTblGnAddressBookTypeResult = await CanErpDbAt132.CreateTblGnAddressBookType(tblgnaddressbooktype);
                DialogService.Close(tblgnaddressbooktype);
            }
            catch (Exception canErpDbAt132CreateTblGnAddressBookTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnAddressBookType!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
