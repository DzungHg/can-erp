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
    public partial class AddTblSoOrderDetailStatusComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus _tblsoorderdetailstatus;
        protected ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus tblsoorderdetailstatus
        {
            get
            {
                return _tblsoorderdetailstatus;
            }
            set
            {
                if(_tblsoorderdetailstatus != value)
                {
                    _tblsoorderdetailstatus = value;
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
            tblsoorderdetailstatus = new ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus args)
        {
            try
            {
                var canErpDbAt132CreateTblSoOrderDetailStatusResult = await CanErpDbAt132.CreateTblSoOrderDetailStatus(tblsoorderdetailstatus);
                DialogService.Close(tblsoorderdetailstatus);
            }
            catch (Exception canErpDbAt132CreateTblSoOrderDetailStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSoOrderDetailStatus!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
