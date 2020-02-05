using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CanErpHp.Models.DbAtVdc2;
using Microsoft.EntityFrameworkCore;

namespace CanErpHp.Pages
{
<<<<<<< Updated upstream:radzen-app/server/Pages/TblHpTinhTps.razor.designer.cs
    public partial class TblHpTinhTpsComponent : ComponentBase
=======
    public partial class TblHpBacsComponent : ComponentBase
>>>>>>> Stashed changes:hr-pr/server/Pages/TblHpBacs.razor.designer.cs
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected DbAtVdc2Service DbAtVdc2 { get; set; }

<<<<<<< Updated upstream:radzen-app/server/Pages/TblHpTinhTps.razor.designer.cs
        protected RadzenGrid<CanErp2.Models.DbAtVdc2.TblHpTinhTp> grid0;

        IEnumerable<CanErp2.Models.DbAtVdc2.TblHpTinhTp> _getTblHpTinhTpsResult;
        protected IEnumerable<CanErp2.Models.DbAtVdc2.TblHpTinhTp> getTblHpTinhTpsResult
        {
            get
            {
                return _getTblHpTinhTpsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpTinhTpsResult, value))
                {
                    _getTblHpTinhTpsResult = value;
=======
        protected RadzenGrid<CanErpHp.Models.DbAtVdc2.TblHpBac> grid0;

        IEnumerable<CanErpHp.Models.DbAtVdc2.TblHpBac> _getTblHpBacsResult;
        protected IEnumerable<CanErpHp.Models.DbAtVdc2.TblHpBac> getTblHpBacsResult
        {
            get
            {
                return _getTblHpBacsResult;
            }
            set
            {
                if(!object.Equals(_getTblHpBacsResult, value))
                {
                    _getTblHpBacsResult = value;
>>>>>>> Stashed changes:hr-pr/server/Pages/TblHpBacs.razor.designer.cs
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
<<<<<<< Updated upstream:radzen-app/server/Pages/TblHpTinhTps.razor.designer.cs
            var dbAtVdc2GetTblHpTinhTpsResult = await DbAtVdc2.GetTblHpTinhTps();
            getTblHpTinhTpsResult = dbAtVdc2GetTblHpTinhTpsResult;
=======
            var dbAtVdc2GetTblHpBacsResult = await DbAtVdc2.GetTblHpBacs();
            getTblHpBacsResult = dbAtVdc2GetTblHpBacsResult;
>>>>>>> Stashed changes:hr-pr/server/Pages/TblHpBacs.razor.designer.cs
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
<<<<<<< Updated upstream:radzen-app/server/Pages/TblHpTinhTps.razor.designer.cs
            var result = await DialogService.OpenAsync<AddTblHpTinhTp>("Add Tbl Hp Tinh Tp", null);
=======
            var result = await DialogService.OpenAsync<AddTblHpBac>("Add Tbl Hp Bac", null);
>>>>>>> Stashed changes:hr-pr/server/Pages/TblHpBacs.razor.designer.cs
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

<<<<<<< Updated upstream:radzen-app/server/Pages/TblHpTinhTps.razor.designer.cs
        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErp2.Models.DbAtVdc2.TblHpTinhTp args)
        {
            var result = await DialogService.OpenAsync<EditTblHpTinhTp>("Edit Tbl Hp Tinh Tp", new Dictionary<string, object>() { {"TinhTP_ID", args.TinhTP_ID} });
=======
        protected async System.Threading.Tasks.Task Grid0RowSelect(CanErpHp.Models.DbAtVdc2.TblHpBac args)
        {
            var result = await DialogService.OpenAsync<EditTblHpBac>("Edit Tbl Hp Bac", new Dictionary<string, object>() { {"Bac_ID", args.Bac_ID} });
>>>>>>> Stashed changes:hr-pr/server/Pages/TblHpBacs.razor.designer.cs
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
<<<<<<< Updated upstream:radzen-app/server/Pages/TblHpTinhTps.razor.designer.cs
                var dbAtVdc2DeleteTblHpTinhTpResult = await DbAtVdc2.DeleteTblHpTinhTp($"{data.TinhTP_ID}");
                if (dbAtVdc2DeleteTblHpTinhTpResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpTinhTpException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpTinhTp");
=======
                var dbAtVdc2DeleteTblHpBacResult = await DbAtVdc2.DeleteTblHpBac($"{data.Bac_ID}");
                if (dbAtVdc2DeleteTblHpBacResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception dbAtVdc2DeleteTblHpBacException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblHpBac");
>>>>>>> Stashed changes:hr-pr/server/Pages/TblHpBacs.razor.designer.cs
            }
        }
    }
}
