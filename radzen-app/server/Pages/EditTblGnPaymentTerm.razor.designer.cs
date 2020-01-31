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
    public partial class EditTblGnPaymentTermComponent : ComponentBase
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
        public dynamic PaymentTerm_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm _tblgnpaymentterm;
        protected ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm tblgnpaymentterm
        {
            get
            {
                return _tblgnpaymentterm;
            }
            set
            {
                if(_tblgnpaymentterm != value)
                {
                    _tblgnpaymentterm = value;
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

            var canErpDbAt132GetTblGnPaymentTermByPaymentTermSeqResult = await CanErpDbAt132.GetTblGnPaymentTermByPaymentTermSeq(int.Parse($"{PaymentTerm_SEQ}"));
            tblgnpaymentterm = canErpDbAt132GetTblGnPaymentTermByPaymentTermSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnPaymentTermResult = await CanErpDbAt132.UpdateTblGnPaymentTerm(int.Parse($"{PaymentTerm_SEQ}"), tblgnpaymentterm);
                DialogService.Close(tblgnpaymentterm);
            }
            catch (Exception canErpDbAt132UpdateTblGnPaymentTermException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnPaymentTerm");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
