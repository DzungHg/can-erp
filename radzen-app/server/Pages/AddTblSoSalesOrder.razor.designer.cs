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
    public partial class AddTblSoSalesOrderComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderStatus> _getTblSoOrderStatusesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderStatus> getTblSoOrderStatusesResult
        {
            get
            {
                return _getTblSoOrderStatusesResult;
            }
            set
            {
                if(_getTblSoOrderStatusesResult != value)
                {
                    _getTblSoOrderStatusesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoCustomer> _getTblSoCustomersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoCustomer> getTblSoCustomersResult
        {
            get
            {
                return _getTblSoCustomersResult;
            }
            set
            {
                if(_getTblSoCustomersResult != value)
                {
                    _getTblSoCustomersResult = value;
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

        ErpCan.Models.CanErpDbAt132.TblSoSalesOrder _tblsosalesorder;
        protected ErpCan.Models.CanErpDbAt132.TblSoSalesOrder tblsosalesorder
        {
            get
            {
                return _tblsosalesorder;
            }
            set
            {
                if(_tblsosalesorder != value)
                {
                    _tblsosalesorder = value;
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
            var canErpDbAt132GetTblSoOrderStatusesResult = await CanErpDbAt132.GetTblSoOrderStatuses();
            getTblSoOrderStatusesResult = canErpDbAt132GetTblSoOrderStatusesResult;

            var canErpDbAt132GetTblSoCustomersResult = await CanErpDbAt132.GetTblSoCustomers();
            getTblSoCustomersResult = canErpDbAt132GetTblSoCustomersResult;

            var canErpDbAt132GetTblGnShipViaResult = await CanErpDbAt132.GetTblGnShipVia();
            getTblGnShipViaResult = canErpDbAt132GetTblGnShipViaResult;

            var canErpDbAt132GetTblGnPaymentTermsResult = await CanErpDbAt132.GetTblGnPaymentTerms();
            getTblGnPaymentTermsResult = canErpDbAt132GetTblGnPaymentTermsResult;

            var canErpDbAt132GetTblGnPaymentTypesResult = await CanErpDbAt132.GetTblGnPaymentTypes();
            getTblGnPaymentTypesResult = canErpDbAt132GetTblGnPaymentTypesResult;

            tblsosalesorder = new ErpCan.Models.CanErpDbAt132.TblSoSalesOrder();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoSalesOrder args)
        {
            try
            {
                var canErpDbAt132CreateTblSoSalesOrderResult = await CanErpDbAt132.CreateTblSoSalesOrder(tblsosalesorder);
                DialogService.Close(tblsosalesorder);
            }
            catch (Exception canErpDbAt132CreateTblSoSalesOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSoSalesOrder!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
