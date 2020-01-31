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
    public partial class AddTblPoApInvoiceComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> _getTblPoVendorsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> getTblPoVendorsResult
        {
            get
            {
                return _getTblPoVendorsResult;
            }
            set
            {
                if(_getTblPoVendorsResult != value)
                {
                    _getTblPoVendorsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblPoApInvoice _tblpoapinvoice;
        protected ErpCan.Models.CanErpDbAt132.TblPoApInvoice tblpoapinvoice
        {
            get
            {
                return _tblpoapinvoice;
            }
            set
            {
                if(_tblpoapinvoice != value)
                {
                    _tblpoapinvoice = value;
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
            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;

            tblpoapinvoice = new ErpCan.Models.CanErpDbAt132.TblPoApInvoice();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoApInvoice args)
        {
            try
            {
                var canErpDbAt132CreateTblPoApInvoiceResult = await CanErpDbAt132.CreateTblPoApInvoice(tblpoapinvoice);
                DialogService.Close(tblpoapinvoice);
            }
            catch (Exception canErpDbAt132CreateTblPoApInvoiceException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoApInvoice!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
