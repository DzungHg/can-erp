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
    public partial class EditTblPoAccountsPayableAdjustmentComponent : ComponentBase
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
        public dynamic Voucher_No { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment _tblpoaccountspayableadjustment;
        protected ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment tblpoaccountspayableadjustment
        {
            get
            {
                return _tblpoaccountspayableadjustment;
            }
            set
            {
                if(_tblpoaccountspayableadjustment != value)
                {
                    _tblpoaccountspayableadjustment = value;
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

            var canErpDbAt132GetTblPoAccountsPayableAdjustmentByVoucherNoResult = await CanErpDbAt132.GetTblPoAccountsPayableAdjustmentByVoucherNo($"{Voucher_No}");
            tblpoaccountspayableadjustment = canErpDbAt132GetTblPoAccountsPayableAdjustmentByVoucherNoResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoAccountsPayableAdjustmentResult = await CanErpDbAt132.UpdateTblPoAccountsPayableAdjustment($"{Voucher_No}", tblpoaccountspayableadjustment);
                DialogService.Close(tblpoaccountspayableadjustment);
            }
            catch (Exception canErpDbAt132UpdateTblPoAccountsPayableAdjustmentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoAccountsPayableAdjustment");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
