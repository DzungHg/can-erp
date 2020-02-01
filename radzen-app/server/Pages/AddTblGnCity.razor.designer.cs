using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CanErp2.Models.DbAtVdc2;
using Microsoft.EntityFrameworkCore;

namespace CanErp2.Pages
{
    public partial class AddTblGnCityComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected DbAtVdc2Service DbAtVdc2 { get; set; }

        CanErp2.Models.DbAtVdc2.TblGnCity _tblgncity;
        protected CanErp2.Models.DbAtVdc2.TblGnCity tblgncity
        {
            get
            {
                return _tblgncity;
            }
            set
            {
                if(!object.Equals(_tblgncity, value))
                {
                    _tblgncity = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            tblgncity = new CanErp2.Models.DbAtVdc2.TblGnCity();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErp2.Models.DbAtVdc2.TblGnCity args)
        {
            try
            {
                var dbAtVdc2CreateTblGnCityResult = await DbAtVdc2.CreateTblGnCity(tblgncity);
                DialogService.Close(tblgncity);
            }
            catch (Exception dbAtVdc2CreateTblGnCityException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnCity!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
