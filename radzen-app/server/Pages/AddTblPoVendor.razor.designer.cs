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
    public partial class AddTblPoVendorComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        IEnumerable<VwVendor> _getVwVendorsResult;
        protected IEnumerable<VwVendor> getVwVendorsResult
        {
            get
            {
                return _getVwVendorsResult;
            }
            set
            {
                if(_getVwVendorsResult != value)
                {
                    _getVwVendorsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblPoVendor _tblpovendor;
        protected ErpCan.Models.CanErpDbAt132.TblPoVendor tblpovendor
        {
            get
            {
                return _tblpovendor;
            }
            set
            {
                if(_tblpovendor != value)
                {
                    _tblpovendor = value;
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
            var canErpDbAt132GetVwVendorsResult = await CanErpDbAt132.GetVwVendors();
            getVwVendorsResult = canErpDbAt132GetVwVendorsResult;

            tblpovendor = new ErpCan.Models.CanErpDbAt132.TblPoVendor();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoVendor args)
        {
            try
            {
                var canErpDbAt132CreateTblPoVendorResult = await CanErpDbAt132.CreateTblPoVendor(tblpovendor);
                DialogService.Close(tblpovendor);
            }
            catch (Exception canErpDbAt132CreateTblPoVendorException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoVendor!");
            }
        }

        protected async void VendorAddressBookFkChange(dynamic args)
        {
            FillData(tblpovendor.VendorAddressBook_FK);
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
