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
    public partial class AddTblPoAccountsPayableAdjustmentComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblpoaccountspayableadjustment = new ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment args)
        {
            try
            {
                var canErpDbAt132CreateTblPoAccountsPayableAdjustmentResult = await CanErpDbAt132.CreateTblPoAccountsPayableAdjustment(tblpoaccountspayableadjustment);
                DialogService.Close(tblpoaccountspayableadjustment);
            }
            catch (Exception canErpDbAt132CreateTblPoAccountsPayableAdjustmentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoAccountsPayableAdjustment!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
