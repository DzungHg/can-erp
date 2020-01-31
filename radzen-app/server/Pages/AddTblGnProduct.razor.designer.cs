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
    public partial class AddTblGnProductComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        ErpCan.Models.CanErpDbAt132.TblGnProduct _tblgnproduct;
        protected ErpCan.Models.CanErpDbAt132.TblGnProduct tblgnproduct
        {
            get
            {
                return _tblgnproduct;
            }
            set
            {
                if(_tblgnproduct != value)
                {
                    _tblgnproduct = value;
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
            tblgnproduct = new ErpCan.Models.CanErpDbAt132.TblGnProduct();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnProduct args)
        {
            try
            {
                var canErpDbAt132CreateTblGnProductResult = await CanErpDbAt132.CreateTblGnProduct(tblgnproduct);
                DialogService.Close(tblgnproduct);
            }
            catch (Exception canErpDbAt132CreateTblGnProductException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnProduct!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
