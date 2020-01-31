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
    public partial class EditTblIcCategoryComponent : ComponentBase
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
        public dynamic Category_ID { get; set; }

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
            canEdit = true;

            var canErpDbAt132GetTblIcCategoryByCategoryIdResult = await CanErpDbAt132.GetTblIcCategoryByCategoryId($"{Category_ID}");
            tbliccategory = canErpDbAt132GetTblIcCategoryByCategoryIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcCategory args)
        {
            try
            {
                var canErpDbAt132UpdateTblIcCategoryResult = await CanErpDbAt132.UpdateTblIcCategory($"{Category_ID}", tbliccategory);
                DialogService.Close(tbliccategory);
            }
            catch (Exception canErpDbAt132UpdateTblIcCategoryException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIcCategory");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
