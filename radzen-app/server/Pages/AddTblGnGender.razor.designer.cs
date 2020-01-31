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
    public partial class AddTblGnGenderComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        ErpCan.Models.CanErpDbAt132.TblGnGender _tblgngender;
        protected ErpCan.Models.CanErpDbAt132.TblGnGender tblgngender
        {
            get
            {
                return _tblgngender;
            }
            set
            {
                if(_tblgngender != value)
                {
                    _tblgngender = value;
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
            tblgngender = new ErpCan.Models.CanErpDbAt132.TblGnGender();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnGender args)
        {
            try
            {
                var canErpDbAt132CreateTblGnGenderResult = await CanErpDbAt132.CreateTblGnGender(tblgngender);
                DialogService.Close(tblgngender);
            }
            catch (Exception canErpDbAt132CreateTblGnGenderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnGender!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
