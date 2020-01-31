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
    public partial class TblGnDepartmentsComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnDepartment> grid0;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnDepartment> _getTblGnDepartmentsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnDepartment> getTblGnDepartmentsResult
        {
            get
            {
                return _getTblGnDepartmentsResult;
            }
            set
            {
                if(_getTblGnDepartmentsResult != value)
                {
                    _getTblGnDepartmentsResult = value;
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
            var canErpDbAt132GetTblGnDepartmentsResult = await CanErpDbAt132.GetTblGnDepartments();
            getTblGnDepartmentsResult = canErpDbAt132GetTblGnDepartmentsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnDepartment>("Add Tbl Gn Department", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(ErpCan.Models.CanErpDbAt132.TblGnDepartment args)
        {
            var result = await DialogService.OpenAsync<EditTblGnDepartment>("Edit Tbl Gn Department", new Dictionary<string, object>() { {"Department_ID", args.Department_ID} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, ErpCan.Models.CanErpDbAt132.TblGnDepartment data)
        {
            try
            {
                var canErpDbAt132DeleteTblGnDepartmentResult = await CanErpDbAt132.DeleteTblGnDepartment($"{data.Department_ID}");
                if (canErpDbAt132DeleteTblGnDepartmentResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception canErpDbAt132DeleteTblGnDepartmentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnDepartment");
            }
        }
    }
}
