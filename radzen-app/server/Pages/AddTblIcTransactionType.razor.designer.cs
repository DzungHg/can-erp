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
    public partial class AddTblIcTransactionTypeComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblictransactiontype = new ErpCan.Models.CanErpDbAt132.TblIcTransactionType();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcTransactionType args)
        {
            try
            {
                var canErpDbAt132CreateTblIcTransactionTypeResult = await CanErpDbAt132.CreateTblIcTransactionType(tblictransactiontype);
                DialogService.Close(tblictransactiontype);
            }
            catch (Exception canErpDbAt132CreateTblIcTransactionTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblIcTransactionType!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
