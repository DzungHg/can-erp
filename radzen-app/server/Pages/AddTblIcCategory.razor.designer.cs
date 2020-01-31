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
    public partial class AddTblIcCategoryComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        ErpCan.Models.CanErpDbAt132.TblIcCategory _tbliccategory;
        protected ErpCan.Models.CanErpDbAt132.TblIcCategory tbliccategory
        {
            get
            {
                return _tbliccategory;
            }
            set
            {
                if(_tbliccategory != value)
                {
                    _tbliccategory = value;
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
            tbliccategory = new ErpCan.Models.CanErpDbAt132.TblIcCategory();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcCategory args)
        {
            try
            {
                var canErpDbAt132CreateTblIcCategoryResult = await CanErpDbAt132.CreateTblIcCategory(tbliccategory);
                DialogService.Close(tbliccategory);
            }
            catch (Exception canErpDbAt132CreateTblIcCategoryException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblIcCategory!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
