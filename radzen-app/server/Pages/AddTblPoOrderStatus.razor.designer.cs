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
    public partial class AddTblPoOrderStatusComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        ErpCan.Models.CanErpDbAt132.TblPoOrderStatus _tblpoorderstatus;
        protected ErpCan.Models.CanErpDbAt132.TblPoOrderStatus tblpoorderstatus
        {
            get
            {
                return _tblpoorderstatus;
            }
            set
            {
                if(_tblpoorderstatus != value)
                {
                    _tblpoorderstatus = value;
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
            tblpoorderstatus = new ErpCan.Models.CanErpDbAt132.TblPoOrderStatus();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoOrderStatus args)
        {
            try
            {
                var canErpDbAt132CreateTblPoOrderStatusResult = await CanErpDbAt132.CreateTblPoOrderStatus(tblpoorderstatus);
                DialogService.Close(tblpoorderstatus);
            }
            catch (Exception canErpDbAt132CreateTblPoOrderStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoOrderStatus!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
