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
    public partial class EditTblPoPurchaseOrderDetailComponent : ComponentBase
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
        public dynamic PO_FK { get; set; }

        [Parameter]
        public dynamic Inventory_FK { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail _tblpopurchaseorderdetail;
        protected ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail tblpopurchaseorderdetail
        {
            get
            {
                return _tblpopurchaseorderdetail;
            }
            set
            {
                if(_tblpopurchaseorderdetail != value)
                {
                    _tblpopurchaseorderdetail = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder> _getTblPoPurchaseOrdersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder> getTblPoPurchaseOrdersResult
        {
            get
            {
                return _getTblPoPurchaseOrdersResult;
            }
            set
            {
                if(_getTblPoPurchaseOrdersResult != value)
                {
                    _getTblPoPurchaseOrdersResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcInventory> _getTblIcInventoriesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcInventory> getTblIcInventoriesResult
        {
            get
            {
                return _getTblIcInventoriesResult;
            }
            set
            {
                if(_getTblIcInventoriesResult != value)
                {
                    _getTblIcInventoriesResult = value;
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

            var canErpDbAt132GetTblPoPurchaseOrderDetailByPoFkAndInventoryFkResult = await CanErpDbAt132.GetTblPoPurchaseOrderDetailByPoFkAndInventoryFk($"{PO_FK}", int.Parse($"{Inventory_FK}"));
            tblpopurchaseorderdetail = canErpDbAt132GetTblPoPurchaseOrderDetailByPoFkAndInventoryFkResult;

            var canErpDbAt132GetTblPoPurchaseOrdersResult = await CanErpDbAt132.GetTblPoPurchaseOrders();
            getTblPoPurchaseOrdersResult = canErpDbAt132GetTblPoPurchaseOrdersResult;

            var canErpDbAt132GetTblIcInventoriesResult = await CanErpDbAt132.GetTblIcInventories();
            getTblIcInventoriesResult = canErpDbAt132GetTblIcInventoriesResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoPurchaseOrderDetailResult = await CanErpDbAt132.UpdateTblPoPurchaseOrderDetail($"{PO_FK}", int.Parse($"{Inventory_FK}"), tblpopurchaseorderdetail);
                DialogService.Close(tblpopurchaseorderdetail);
            }
            catch (Exception canErpDbAt132UpdateTblPoPurchaseOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoPurchaseOrderDetail");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
