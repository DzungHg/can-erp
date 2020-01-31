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
    public partial class EditTblSoOrderStatusComponent : ComponentBase
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
        public dynamic SOStatus_SEQ { get; set; }

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
            canEdit = true;

            var canErpDbAt132GetTblSoOrderStatusBySoStatusSeqResult = await CanErpDbAt132.GetTblSoOrderStatusBySoStatusSeq(int.Parse($"{SOStatus_SEQ}"));
            tblsoorderstatus = canErpDbAt132GetTblSoOrderStatusBySoStatusSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoOrderStatus args)
        {
            try
            {
                var canErpDbAt132UpdateTblSoOrderStatusResult = await CanErpDbAt132.UpdateTblSoOrderStatus(int.Parse($"{SOStatus_SEQ}"), tblsoorderstatus);
                DialogService.Close(tblsoorderstatus);
            }
            catch (Exception canErpDbAt132UpdateTblSoOrderStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSoOrderStatus");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
