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
    public partial class EditTblGnShipViumComponent : ComponentBase
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
        public dynamic ShipVia_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblGnShipVium _tblgnshipvium;
        protected ErpCan.Models.CanErpDbAt132.TblGnShipVium tblgnshipvium
        {
            get
            {
                return _tblgnshipvium;
            }
            set
            {
                if(_tblgnshipvium != value)
                {
                    _tblgnshipvium = value;
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

            var canErpDbAt132GetTblGnShipViumByShipViaSeqResult = await CanErpDbAt132.GetTblGnShipViumByShipViaSeq(int.Parse($"{ShipVia_SEQ}"));
            tblgnshipvium = canErpDbAt132GetTblGnShipViumByShipViaSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnShipVium args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnShipViumResult = await CanErpDbAt132.UpdateTblGnShipVium(int.Parse($"{ShipVia_SEQ}"), tblgnshipvium);
                DialogService.Close(tblgnshipvium);
            }
            catch (Exception canErpDbAt132UpdateTblGnShipViumException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnShipVium");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
