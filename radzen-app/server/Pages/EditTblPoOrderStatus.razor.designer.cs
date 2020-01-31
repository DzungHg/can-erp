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
    public partial class EditTblPoOrderStatusComponent : ComponentBase
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
        public dynamic POStatus_ID { get; set; }

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
            canEdit = true;

            var canErpDbAt132GetTblPoOrderStatusByPoStatusIdResult = await CanErpDbAt132.GetTblPoOrderStatusByPoStatusId($"{POStatus_ID}");
            tblpoorderstatus = canErpDbAt132GetTblPoOrderStatusByPoStatusIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoOrderStatus args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoOrderStatusResult = await CanErpDbAt132.UpdateTblPoOrderStatus($"{POStatus_ID}", tblpoorderstatus);
                DialogService.Close(tblpoorderstatus);
            }
            catch (Exception canErpDbAt132UpdateTblPoOrderStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoOrderStatus");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
