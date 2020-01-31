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
    public partial class AddTblGnDepartmentComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblgndepartment = new ErpCan.Models.CanErpDbAt132.TblGnDepartment();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnDepartment args)
        {
            try
            {
                var canErpDbAt132CreateTblGnDepartmentResult = await CanErpDbAt132.CreateTblGnDepartment(tblgndepartment);
                DialogService.Close(tblgndepartment);
            }
            catch (Exception canErpDbAt132CreateTblGnDepartmentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnDepartment!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
