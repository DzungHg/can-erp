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
    public partial class EditTblGnIncotermComponent : ComponentBase
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
        public dynamic Incoterm_ID { get; set; }

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
            canEdit = true;

            var canErpDbAt132GetTblGnIncotermByIncotermIdResult = await CanErpDbAt132.GetTblGnIncotermByIncotermId($"{Incoterm_ID}");
            tblgnincoterm = canErpDbAt132GetTblGnIncotermByIncotermIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnIncoterm args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnIncotermResult = await CanErpDbAt132.UpdateTblGnIncoterm($"{Incoterm_ID}", tblgnincoterm);
                DialogService.Close(tblgnincoterm);
            }
            catch (Exception canErpDbAt132UpdateTblGnIncotermException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnIncoterm");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
