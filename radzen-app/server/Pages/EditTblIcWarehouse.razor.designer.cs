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
    public partial class EditTblIcWarehouseComponent : ComponentBase
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
        public dynamic Warehouse_ID { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblIcWarehouse _tblicwarehouse;
        protected ErpCan.Models.CanErpDbAt132.TblIcWarehouse tblicwarehouse
        {
            get
            {
                return _tblicwarehouse;
            }
            set
            {
                if(_tblicwarehouse != value)
                {
                    _tblicwarehouse = value;
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

            var canErpDbAt132GetTblIcWarehouseByWarehouseIdResult = await CanErpDbAt132.GetTblIcWarehouseByWarehouseId($"{Warehouse_ID}");
            tblicwarehouse = canErpDbAt132GetTblIcWarehouseByWarehouseIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcWarehouse args)
        {
            try
            {
                var canErpDbAt132UpdateTblIcWarehouseResult = await CanErpDbAt132.UpdateTblIcWarehouse($"{Warehouse_ID}", tblicwarehouse);
                DialogService.Close(tblicwarehouse);
            }
            catch (Exception canErpDbAt132UpdateTblIcWarehouseException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIcWarehouse");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
