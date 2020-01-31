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
    public partial class EditTblIcTransactionTypeComponent : ComponentBase
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
        public dynamic Transaction_ID { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblIcTransactionType _tblictransactiontype;
        protected ErpCan.Models.CanErpDbAt132.TblIcTransactionType tblictransactiontype
        {
            get
            {
                return _tblictransactiontype;
            }
            set
            {
                if(_tblictransactiontype != value)
                {
                    _tblictransactiontype = value;
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

            var canErpDbAt132GetTblIcTransactionTypeByTransactionIdResult = await CanErpDbAt132.GetTblIcTransactionTypeByTransactionId($"{Transaction_ID}");
            tblictransactiontype = canErpDbAt132GetTblIcTransactionTypeByTransactionIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcTransactionType args)
        {
            try
            {
                var canErpDbAt132UpdateTblIcTransactionTypeResult = await CanErpDbAt132.UpdateTblIcTransactionType($"{Transaction_ID}", tblictransactiontype);
                DialogService.Close(tblictransactiontype);
            }
            catch (Exception canErpDbAt132UpdateTblIcTransactionTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIcTransactionType");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
