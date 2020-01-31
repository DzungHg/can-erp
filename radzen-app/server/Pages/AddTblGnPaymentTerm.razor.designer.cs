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
    public partial class AddTblGnPaymentTermComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblgnpaymentterm = new ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm args)
        {
            try
            {
                var canErpDbAt132CreateTblGnPaymentTermResult = await CanErpDbAt132.CreateTblGnPaymentTerm(tblgnpaymentterm);
                DialogService.Close(tblgnpaymentterm);
            }
            catch (Exception canErpDbAt132CreateTblGnPaymentTermException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnPaymentTerm!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
