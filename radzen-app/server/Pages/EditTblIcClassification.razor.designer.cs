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
    public partial class EditTblIcClassificationComponent : ComponentBase
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
        public dynamic Classifi_ID { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblIcClassification _tblicclassification;
        protected ErpCan.Models.CanErpDbAt132.TblIcClassification tblicclassification
        {
            get
            {
                return _tblicclassification;
            }
            set
            {
                if(_tblicclassification != value)
                {
                    _tblicclassification = value;
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

            var canErpDbAt132GetTblIcClassificationByClassifiIdResult = await CanErpDbAt132.GetTblIcClassificationByClassifiId($"{Classifi_ID}");
            tblicclassification = canErpDbAt132GetTblIcClassificationByClassifiIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcClassification args)
        {
            try
            {
                var canErpDbAt132UpdateTblIcClassificationResult = await CanErpDbAt132.UpdateTblIcClassification($"{Classifi_ID}", tblicclassification);
                DialogService.Close(tblicclassification);
            }
            catch (Exception canErpDbAt132UpdateTblIcClassificationException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIcClassification");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
