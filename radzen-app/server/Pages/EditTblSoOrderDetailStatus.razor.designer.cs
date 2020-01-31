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
    public partial class EditTblSoOrderDetailStatusComponent : ComponentBase
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
        public dynamic SODetailStatus_SEQ { get; set; }

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
            canEdit = true;

            var canErpDbAt132GetTblSoOrderDetailStatusBySoDetailStatusSeqResult = await CanErpDbAt132.GetTblSoOrderDetailStatusBySoDetailStatusSeq(int.Parse($"{SODetailStatus_SEQ}"));
            tblsoorderdetailstatus = canErpDbAt132GetTblSoOrderDetailStatusBySoDetailStatusSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus args)
        {
            try
            {
                var canErpDbAt132UpdateTblSoOrderDetailStatusResult = await CanErpDbAt132.UpdateTblSoOrderDetailStatus(int.Parse($"{SODetailStatus_SEQ}"), tblsoorderdetailstatus);
                DialogService.Close(tblsoorderdetailstatus);
            }
            catch (Exception canErpDbAt132UpdateTblSoOrderDetailStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSoOrderDetailStatus");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
