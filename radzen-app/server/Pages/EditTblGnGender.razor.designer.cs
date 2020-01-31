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
    public partial class EditTblGnGenderComponent : ComponentBase
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
        public dynamic Gender_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblGnGender _tblgngender;
        protected ErpCan.Models.CanErpDbAt132.TblGnGender tblgngender
        {
            get
            {
                return _tblgngender;
            }
            set
            {
                if(_tblgngender != value)
                {
                    _tblgngender = value;
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

            var canErpDbAt132GetTblGnGenderByGenderSeqResult = await CanErpDbAt132.GetTblGnGenderByGenderSeq(int.Parse($"{Gender_SEQ}"));
            tblgngender = canErpDbAt132GetTblGnGenderByGenderSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnGender args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnGenderResult = await CanErpDbAt132.UpdateTblGnGender(int.Parse($"{Gender_SEQ}"), tblgngender);
                DialogService.Close(tblgngender);
            }
            catch (Exception canErpDbAt132UpdateTblGnGenderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnGender");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
