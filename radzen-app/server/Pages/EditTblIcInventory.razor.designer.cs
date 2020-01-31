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
    public partial class EditTblIcInventoryComponent : ComponentBase
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
        public dynamic Inventory_SEQ { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblIcInventory _tblicinventory;
        protected ErpCan.Models.CanErpDbAt132.TblIcInventory tblicinventory
        {
            get
            {
                return _tblicinventory;
            }
            set
            {
                if(_tblicinventory != value)
                {
                    _tblicinventory = value;
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcCategory> _getTblIcCategoriesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcCategory> getTblIcCategoriesResult
        {
            get
            {
                return _getTblIcCategoriesResult;
            }
            set
            {
                if(_getTblIcCategoriesResult != value)
                {
                    _getTblIcCategoriesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcClassification> _getTblIcClassificationsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcClassification> getTblIcClassificationsResult
        {
            get
            {
                return _getTblIcClassificationsResult;
            }
            set
            {
                if(_getTblIcClassificationsResult != value)
                {
                    _getTblIcClassificationsResult = value;
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcUnit> _getTblIcUnitsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcUnit> getTblIcUnitsResult
        {
            get
            {
                return _getTblIcUnitsResult;
            }
            set
            {
                if(_getTblIcUnitsResult != value)
                {
                    _getTblIcUnitsResult = value;
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

            var canErpDbAt132GetTblIcInventoryByInventorySeqResult = await CanErpDbAt132.GetTblIcInventoryByInventorySeq(int.Parse($"{Inventory_SEQ}"));
            tblicinventory = canErpDbAt132GetTblIcInventoryByInventorySeqResult;

            var canErpDbAt132GetTblIcWarehousesResult = await CanErpDbAt132.GetTblIcWarehouses();
            getTblIcWarehousesResult = canErpDbAt132GetTblIcWarehousesResult;

            var canErpDbAt132GetTblIcCategoriesResult = await CanErpDbAt132.GetTblIcCategories();
            getTblIcCategoriesResult = canErpDbAt132GetTblIcCategoriesResult;

            var canErpDbAt132GetTblIcClassificationsResult = await CanErpDbAt132.GetTblIcClassifications();
            getTblIcClassificationsResult = canErpDbAt132GetTblIcClassificationsResult;

            var canErpDbAt132GetTblGnProductsResult = await CanErpDbAt132.GetTblGnProducts();
            getTblGnProductsResult = canErpDbAt132GetTblGnProductsResult;

            var canErpDbAt132GetTblIcUnitsResult = await CanErpDbAt132.GetTblIcUnits();
            getTblIcUnitsResult = canErpDbAt132GetTblIcUnitsResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcInventory args)
        {
            try
            {
                var canErpDbAt132UpdateTblIcInventoryResult = await CanErpDbAt132.UpdateTblIcInventory(int.Parse($"{Inventory_SEQ}"), tblicinventory);
                DialogService.Close(tblicinventory);
            }
            catch (Exception canErpDbAt132UpdateTblIcInventoryException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIcInventory");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
