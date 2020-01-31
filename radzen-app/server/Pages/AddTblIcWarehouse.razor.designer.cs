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
    public partial class AddTblIcWarehouseComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblicwarehouse = new ErpCan.Models.CanErpDbAt132.TblIcWarehouse();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcWarehouse args)
        {
            try
            {
                var canErpDbAt132CreateTblIcWarehouseResult = await CanErpDbAt132.CreateTblIcWarehouse(tblicwarehouse);
                DialogService.Close(tblicwarehouse);
            }
            catch (Exception canErpDbAt132CreateTblIcWarehouseException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblIcWarehouse!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
