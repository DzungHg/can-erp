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
    public partial class EditTblIcUnitComponent : ComponentBase
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
        public dynamic Unit_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblIcUnit _tblicunit;
        protected ErpCan.Models.CanErpDbAt132.TblIcUnit tblicunit
        {
            get
            {
                return _tblicunit;
            }
            set
            {
                if(_tblicunit != value)
                {
                    _tblicunit = value;
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

            var canErpDbAt132GetTblIcUnitByUnitSeqResult = await CanErpDbAt132.GetTblIcUnitByUnitSeq(int.Parse($"{Unit_SEQ}"));
            tblicunit = canErpDbAt132GetTblIcUnitByUnitSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcUnit args)
        {
            try
            {
                var canErpDbAt132UpdateTblIcUnitResult = await CanErpDbAt132.UpdateTblIcUnit(int.Parse($"{Unit_SEQ}"), tblicunit);
                DialogService.Close(tblicunit);
            }
            catch (Exception canErpDbAt132UpdateTblIcUnitException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIcUnit");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
