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
    public partial class VwEmpAndVendsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.VwEmpAndVend> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.VwEmpAndVend> _getVwEmpAndVendsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.VwEmpAndVend> getVwEmpAndVendsResult
        {
            get
            {
                return _getVwEmpAndVendsResult;
            }
            set
            {
                if(_getVwEmpAndVendsResult != value)
                {
                    _getVwEmpAndVendsResult = value;
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
            var canErpDbAt132GetVwEmpAndVendsResult = await CanErpDbAt132.GetVwEmpAndVends();
            getVwEmpAndVendsResult = canErpDbAt132GetVwEmpAndVendsResult;
        }
    }
}
