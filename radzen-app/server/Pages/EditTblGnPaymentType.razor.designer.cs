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
    public partial class EditTblGnPaymentTypeComponent : ComponentBase
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
        public dynamic PaymentType_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblGnPaymentType _tblgnpaymenttype;
        protected ErpCan.Models.CanErpDbAt132.TblGnPaymentType tblgnpaymenttype
        {
            get
            {
                return _tblgnpaymenttype;
            }
            set
            {
                if(_tblgnpaymenttype != value)
                {
                    _tblgnpaymenttype = value;
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

            var canErpDbAt132GetTblGnPaymentTypeByPaymentTypeSeqResult = await CanErpDbAt132.GetTblGnPaymentTypeByPaymentTypeSeq(int.Parse($"{PaymentType_SEQ}"));
            tblgnpaymenttype = canErpDbAt132GetTblGnPaymentTypeByPaymentTypeSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnPaymentType args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnPaymentTypeResult = await CanErpDbAt132.UpdateTblGnPaymentType(int.Parse($"{PaymentType_SEQ}"), tblgnpaymenttype);
                DialogService.Close(tblgnpaymenttype);
            }
            catch (Exception canErpDbAt132UpdateTblGnPaymentTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnPaymentType");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
