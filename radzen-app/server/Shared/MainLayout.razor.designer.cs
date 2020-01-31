using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using ErpCan.Models.CanErpDbAt132;
namespace ErpCan.Layouts
{
    public partial class MainLayoutComponent : LayoutComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenBody body0;

        protected RadzenSidebar sidebar0;

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }


        protected async void Load()
        {

        }

        protected async void SidebarToggle0Click(dynamic args)
        {
            sidebar0.Toggle();

            body0.Toggle();
        }
    }
}
