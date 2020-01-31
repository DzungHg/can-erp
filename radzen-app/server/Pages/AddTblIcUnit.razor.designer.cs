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
    public partial class AddTblIcUnitComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblicunit = new ErpCan.Models.CanErpDbAt132.TblIcUnit();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcUnit args)
        {
            try
            {
                var canErpDbAt132CreateTblIcUnitResult = await CanErpDbAt132.CreateTblIcUnit(tblicunit);
                DialogService.Close(tblicunit);
            }
            catch (Exception canErpDbAt132CreateTblIcUnitException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblIcUnit!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
