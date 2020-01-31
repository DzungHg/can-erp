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
    public partial class AddTblGnShipViumComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        ErpCan.Models.CanErpDbAt132.TblGnShipVium _tblgnshipvium;
        protected ErpCan.Models.CanErpDbAt132.TblGnShipVium tblgnshipvium
        {
            get
            {
                return _tblgnshipvium;
            }
            set
            {
                if(_tblgnshipvium != value)
                {
                    _tblgnshipvium = value;
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
            tblgnshipvium = new ErpCan.Models.CanErpDbAt132.TblGnShipVium();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnShipVium args)
        {
            try
            {
                var canErpDbAt132CreateTblGnShipViumResult = await CanErpDbAt132.CreateTblGnShipVium(tblgnshipvium);
                DialogService.Close(tblgnshipvium);
            }
            catch (Exception canErpDbAt132CreateTblGnShipViumException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnShipVium!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
