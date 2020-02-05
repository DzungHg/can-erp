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
<<<<<<< Updated upstream:radzen-app/server/Pages/AddTblHpTinhTp.razor.designer.cs
    public partial class AddTblHpTinhTpComponent : ComponentBase
=======
    public partial class AddTblHpQuanComponent : ComponentBase
>>>>>>> Stashed changes:hr-pr/server/Pages/AddTblHpQuan.razor.designer.cs
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

<<<<<<< Updated upstream:radzen-app/server/Pages/AddTblHpTinhTp.razor.designer.cs
        CanErp2.Models.DbAtVdc2.TblHpTinhTp _tblhptinhtp;
        protected CanErp2.Models.DbAtVdc2.TblHpTinhTp tblhptinhtp
        {
            get
            {
                return _tblhptinhtp;
            }
            set
            {
                if(!object.Equals(_tblhptinhtp, value))
                {
                    _tblhptinhtp = value;
=======
        CanErpHp.Models.DbAtVdc2.TblHpQuan _tblhpquan;
        protected CanErpHp.Models.DbAtVdc2.TblHpQuan tblhpquan
        {
            get
            {
                return _tblhpquan;
            }
            set
            {
                if(!object.Equals(_tblhpquan, value))
                {
                    _tblhpquan = value;
>>>>>>> Stashed changes:hr-pr/server/Pages/AddTblHpQuan.razor.designer.cs
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
<<<<<<< Updated upstream:radzen-app/server/Pages/AddTblHpTinhTp.razor.designer.cs
            tblhptinhtp = new CanErp2.Models.DbAtVdc2.TblHpTinhTp();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErp2.Models.DbAtVdc2.TblHpTinhTp args)
        {
            try
            {
                var dbAtVdc2CreateTblHpTinhTpResult = await DbAtVdc2.CreateTblHpTinhTp(tblhptinhtp);
                DialogService.Close(tblhptinhtp);
            }
            catch (Exception dbAtVdc2CreateTblHpTinhTpException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpTinhTp!");
=======
            tblhpquan = new CanErpHp.Models.DbAtVdc2.TblHpQuan();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CanErpHp.Models.DbAtVdc2.TblHpQuan args)
        {
            try
            {
                var dbAtVdc2CreateTblHpQuanResult = await DbAtVdc2.CreateTblHpQuan(tblhpquan);
                DialogService.Close(tblhpquan);
            }
            catch (Exception dbAtVdc2CreateTblHpQuanException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblHpQuan!");
>>>>>>> Stashed changes:hr-pr/server/Pages/AddTblHpQuan.razor.designer.cs
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
