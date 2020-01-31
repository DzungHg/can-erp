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
    public partial class EditTblPoCashDisbursementComponent : ComponentBase
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
        public dynamic PO_CashDisb_No { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement _tblpocashdisbursement;
        protected ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement tblpocashdisbursement
        {
            get
            {
                return _tblpocashdisbursement;
            }
            set
            {
                if(_tblpocashdisbursement != value)
                {
                    _tblpocashdisbursement = value;
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var canErpDbAt132GetTblPoCashDisbursementByPoCashDisbNoResult = await CanErpDbAt132.GetTblPoCashDisbursementByPoCashDisbNo($"{PO_CashDisb_No}");
            tblpocashdisbursement = canErpDbAt132GetTblPoCashDisbursementByPoCashDisbNoResult;

            var canErpDbAt132GetTblGnAddressBooksResult = await CanErpDbAt132.GetTblGnAddressBooks();
            getTblGnAddressBooksResult = canErpDbAt132GetTblGnAddressBooksResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoCashDisbursementResult = await CanErpDbAt132.UpdateTblPoCashDisbursement($"{PO_CashDisb_No}", tblpocashdisbursement);
                DialogService.Close(tblpocashdisbursement);
            }
            catch (Exception canErpDbAt132UpdateTblPoCashDisbursementException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoCashDisbursement");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
