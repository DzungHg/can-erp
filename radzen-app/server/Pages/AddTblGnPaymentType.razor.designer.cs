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
    public partial class AddTblGnPaymentTypeComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblgnpaymenttype = new ErpCan.Models.CanErpDbAt132.TblGnPaymentType();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnPaymentType args)
        {
            try
            {
                var canErpDbAt132CreateTblGnPaymentTypeResult = await CanErpDbAt132.CreateTblGnPaymentType(tblgnpaymenttype);
                DialogService.Close(tblgnpaymenttype);
            }
            catch (Exception canErpDbAt132CreateTblGnPaymentTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnPaymentType!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
