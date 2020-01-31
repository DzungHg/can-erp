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
    public partial class EditTblIcTransactionComponent : ComponentBase
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
        public dynamic Trans_No { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblIcTransaction _tblictransaction;
        protected ErpCan.Models.CanErpDbAt132.TblIcTransaction tblictransaction
        {
            get
            {
                return _tblictransaction;
            }
            set
            {
                if(_tblictransaction != value)
                {
                    _tblictransaction = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransactionType> _getTblIcTransactionTypesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransactionType> getTblIcTransactionTypesResult
        {
            get
            {
                return _getTblIcTransactionTypesResult;
            }
            set
            {
                if(_getTblIcTransactionTypesResult != value)
                {
                    _getTblIcTransactionTypesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcWarehouse> _getTblIcWarehousesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcWarehouse> getTblIcWarehousesResult
        {
            get
            {
                return _getTblIcWarehousesResult;
            }
            set
            {
                if(_getTblIcWarehousesResult != value)
                {
                    _getTblIcWarehousesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnProduct> _getTblGnProductsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnProduct> getTblGnProductsResult
        {
            get
            {
                return _getTblGnProductsResult;
            }
            set
            {
                if(_getTblGnProductsResult != value)
                {
                    _getTblGnProductsResult = value;
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

            var canErpDbAt132GetTblIcTransactionByTransNoResult = await CanErpDbAt132.GetTblIcTransactionByTransNo($"{Trans_No}");
            tblictransaction = canErpDbAt132GetTblIcTransactionByTransNoResult;

            var canErpDbAt132GetTblIcTransactionTypesResult = await CanErpDbAt132.GetTblIcTransactionTypes();
            getTblIcTransactionTypesResult = canErpDbAt132GetTblIcTransactionTypesResult;

            var canErpDbAt132GetTblIcWarehousesResult = await CanErpDbAt132.GetTblIcWarehouses();
            getTblIcWarehousesResult = canErpDbAt132GetTblIcWarehousesResult;

            var canErpDbAt132GetTblGnProductsResult = await CanErpDbAt132.GetTblGnProducts();
            getTblGnProductsResult = canErpDbAt132GetTblGnProductsResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcTransaction args)
        {
            try
            {
                var canErpDbAt132UpdateTblIcTransactionResult = await CanErpDbAt132.UpdateTblIcTransaction($"{Trans_No}", tblictransaction);
                DialogService.Close(tblictransaction);
            }
            catch (Exception canErpDbAt132UpdateTblIcTransactionException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIcTransaction");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
