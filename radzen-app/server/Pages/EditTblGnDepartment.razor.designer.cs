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
    public partial class EditTblGnDepartmentComponent : ComponentBase
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
        public dynamic Department_ID { get; set; }

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

        ErpCan.Models.CanErpDbAt132.TblGnDepartment _tblgndepartment;
        protected ErpCan.Models.CanErpDbAt132.TblGnDepartment tblgndepartment
        {
            get
            {
                return _tblgndepartment;
            }
            set
            {
                if(_tblgndepartment != value)
                {
                    _tblgndepartment = value;
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

            var canErpDbAt132GetTblGnDepartmentByDepartmentIdResult = await CanErpDbAt132.GetTblGnDepartmentByDepartmentId($"{Department_ID}");
            tblgndepartment = canErpDbAt132GetTblGnDepartmentByDepartmentIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnDepartment args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnDepartmentResult = await CanErpDbAt132.UpdateTblGnDepartment($"{Department_ID}", tblgndepartment);
                DialogService.Close(tblgndepartment);
            }
            catch (Exception canErpDbAt132UpdateTblGnDepartmentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnDepartment");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
