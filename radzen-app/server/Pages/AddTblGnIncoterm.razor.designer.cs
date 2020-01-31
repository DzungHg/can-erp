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
    public partial class AddTblGnIncotermComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        ErpCan.Models.CanErpDbAt132.TblGnIncoterm _tblgnincoterm;
        protected ErpCan.Models.CanErpDbAt132.TblGnIncoterm tblgnincoterm
        {
            get
            {
                return _tblgnincoterm;
            }
            set
            {
                if(_tblgnincoterm != value)
                {
                    _tblgnincoterm = value;
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
            tblgnincoterm = new ErpCan.Models.CanErpDbAt132.TblGnIncoterm();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnIncoterm args)
        {
            try
            {
                var canErpDbAt132CreateTblGnIncotermResult = await CanErpDbAt132.CreateTblGnIncoterm(tblgnincoterm);
                DialogService.Close(tblgnincoterm);
            }
            catch (Exception canErpDbAt132CreateTblGnIncotermException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnIncoterm!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
