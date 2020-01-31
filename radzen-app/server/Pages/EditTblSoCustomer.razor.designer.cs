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
    public partial class EditTblSoCustomerComponent : ComponentBase
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
        public dynamic Customer_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblSoCustomer _tblsocustomer;
        protected ErpCan.Models.CanErpDbAt132.TblSoCustomer tblsocustomer
        {
            get
            {
                return _tblsocustomer;
            }
            set
            {
                if(_tblsocustomer != value)
                {
                    _tblsocustomer = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm> _getTblGnPaymentTermsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm> getTblGnPaymentTermsResult
        {
            get
            {
                return _getTblGnPaymentTermsResult;
            }
            set
            {
                if(_getTblGnPaymentTermsResult != value)
                {
                    _getTblGnPaymentTermsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentType> _getTblGnPaymentTypesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentType> getTblGnPaymentTypesResult
        {
            get
            {
                return _getTblGnPaymentTypesResult;
            }
            set
            {
                if(_getTblGnPaymentTypesResult != value)
                {
                    _getTblGnPaymentTypesResult = value;
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

            var canErpDbAt132GetTblSoCustomerByCustomerSeqResult = await CanErpDbAt132.GetTblSoCustomerByCustomerSeq(int.Parse($"{Customer_SEQ}"));
            tblsocustomer = canErpDbAt132GetTblSoCustomerByCustomerSeqResult;

            var canErpDbAt132GetTblGnAddressBooksResult = await CanErpDbAt132.GetTblGnAddressBooks();
            getTblGnAddressBooksResult = canErpDbAt132GetTblGnAddressBooksResult;

            var canErpDbAt132GetTblGnPaymentTermsResult = await CanErpDbAt132.GetTblGnPaymentTerms();
            getTblGnPaymentTermsResult = canErpDbAt132GetTblGnPaymentTermsResult;

            var canErpDbAt132GetTblGnPaymentTypesResult = await CanErpDbAt132.GetTblGnPaymentTypes();
            getTblGnPaymentTypesResult = canErpDbAt132GetTblGnPaymentTypesResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoCustomer args)
        {
            try
            {
                var canErpDbAt132UpdateTblSoCustomerResult = await CanErpDbAt132.UpdateTblSoCustomer(int.Parse($"{Customer_SEQ}"), tblsocustomer);
                DialogService.Close(tblsocustomer);
            }
            catch (Exception canErpDbAt132UpdateTblSoCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSoCustomer");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
