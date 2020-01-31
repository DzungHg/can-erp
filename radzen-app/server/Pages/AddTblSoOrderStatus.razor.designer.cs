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
    public partial class AddTblSoOrderStatusComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        ErpCan.Models.CanErpDbAt132.TblSoOrderStatus _tblsoorderstatus;
        protected ErpCan.Models.CanErpDbAt132.TblSoOrderStatus tblsoorderstatus
        {
            get
            {
                return _tblsoorderstatus;
            }
            set
            {
                if(_tblsoorderstatus != value)
                {
                    _tblsoorderstatus = value;
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
            tblsoorderstatus = new ErpCan.Models.CanErpDbAt132.TblSoOrderStatus();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoOrderStatus args)
        {
            try
            {
                var canErpDbAt132CreateTblSoOrderStatusResult = await CanErpDbAt132.CreateTblSoOrderStatus(tblsoorderstatus);
                DialogService.Close(tblsoorderstatus);
            }
            catch (Exception canErpDbAt132CreateTblSoOrderStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSoOrderStatus!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
