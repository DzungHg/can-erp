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
    public partial class AddTblPoPurchaseOrderComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoOrderStatus> _getTblPoOrderStatusesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoOrderStatus> getTblPoOrderStatusesResult
        {
            get
            {
                return _getTblPoOrderStatusesResult;
            }
            set
            {
                if(_getTblPoOrderStatusesResult != value)
                {
                    _getTblPoOrderStatusesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<VwVendor> _getTblPoVendorsResult;
        protected IEnumerable<VwVendor> getTblPoVendorsResult
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnIncoterm> _getTblGnIncotermsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnIncoterm> getTblGnIncotermsResult
        {
            get
            {
                return _getTblGnIncotermsResult;
            }
            set
            {
                if(_getTblGnIncotermsResult != value)
                {
                    _getTblGnIncotermsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnShipVium> _getTblGnShipViaResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnShipVium> getTblGnShipViaResult
        {
            get
            {
                return _getTblGnShipViaResult;
            }
            set
            {
                if(_getTblGnShipViaResult != value)
                {
                    _getTblGnShipViaResult = value;
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

        ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder _tblpopurchaseorder;
        protected ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder tblpopurchaseorder
        {
            get
            {
                return _tblpopurchaseorder;
            }
            set
            {
                if(_tblpopurchaseorder != value)
                {
                    _tblpopurchaseorder = value;
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

            var canErpDbAt132GetTblPoOrderStatusesResult = await CanErpDbAt132.GetTblPoOrderStatuses();
            getTblPoOrderStatusesResult = canErpDbAt132GetTblPoOrderStatusesResult;

            var canErpDbAt132GetVwVendorsResult = await CanErpDbAt132.GetVwVendors();
            getTblPoVendorsResult = canErpDbAt132GetVwVendorsResult;

            var canErpDbAt132GetTblGnIncotermsResult = await CanErpDbAt132.GetTblGnIncoterms();
            getTblGnIncotermsResult = canErpDbAt132GetTblGnIncotermsResult;

            var canErpDbAt132GetTblGnIncotermsResult = await CanErpDbAt132.GetTblGnIncoterms();
            getTblGnIncotermsResult = canErpDbAt132GetTblGnIncotermsResult;

            var canErpDbAt132GetTblGnShipViaResult = await CanErpDbAt132.GetTblGnShipVia();
            getTblGnShipViaResult = canErpDbAt132GetTblGnShipViaResult;

            var canErpDbAt132GetTblGnPaymentTermsResult = await CanErpDbAt132.GetTblGnPaymentTerms();
            getTblGnPaymentTermsResult = canErpDbAt132GetTblGnPaymentTermsResult;

            var canErpDbAt132GetTblGnPaymentTypesResult = await CanErpDbAt132.GetTblGnPaymentTypes();
            getTblGnPaymentTypesResult = canErpDbAt132GetTblGnPaymentTypesResult;

            tblpopurchaseorder = new ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder args)
        {
            try
            {
                var canErpDbAt132CreateTblPoPurchaseOrderResult = await CanErpDbAt132.CreateTblPoPurchaseOrder(tblpopurchaseorder);
                DialogService.Close(tblpopurchaseorder);
            }
            catch (Exception canErpDbAt132CreateTblPoPurchaseOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoPurchaseOrder!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
