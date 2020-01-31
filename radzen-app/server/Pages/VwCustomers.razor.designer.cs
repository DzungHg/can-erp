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
    public partial class VwCustomersComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.VwCustomer> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.VwCustomer> _getVwCustomersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.VwCustomer> getVwCustomersResult
        {
            get
            {
                return _getVwCustomersResult;
            }
            set
            {
                if(_getVwCustomersResult != value)
                {
                    _getVwCustomersResult = value;
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
            var canErpDbAt132GetVwCustomersResult = await CanErpDbAt132.GetVwCustomers();
            getVwCustomersResult = canErpDbAt132GetVwCustomersResult;
        }
    }
}
