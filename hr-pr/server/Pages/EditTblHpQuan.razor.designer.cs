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
<<<<<<< Updated upstream:radzen-app/server/Pages/EditTblHpTinhTp.razor.designer.cs
    public partial class EditTblHpTinhTpComponent : ComponentBase
=======
    public partial class EditTblHpQuanComponent : ComponentBase
>>>>>>> Stashed changes:hr-pr/server/Pages/EditTblHpQuan.razor.designer.cs
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

        [Parameter]
<<<<<<< Updated upstream:radzen-app/server/Pages/EditTblHpTinhTp.razor.designer.cs
        public dynamic TinhTP_ID { get; set; }
=======
        public dynamic Quan_ID { get; set; }
>>>>>>> Stashed changes:hr-pr/server/Pages/EditTblHpQuan.razor.designer.cs

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(!object.Equals(_canEdit, value))
                {
                    _canEdit = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

<<<<<<< Updated upstream:radzen-app/server/Pages/EditTblHpTinhTp.razor.designer.cs
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
>>>>>>> Stashed changes:hr-pr/server/Pages/EditTblHpQuan.razor.designer.cs
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
            canEdit = true;

<<<<<<< Updated upstream:radzen-app/server/Pages/EditTblHpTinhTp.razor.designer.cs
            var dbAtVdc2GetTblHpTinhTpByTinhTpIdResult = await DbAtVdc2.GetTblHpTinhTpByTinhTpId($"{TinhTP_ID}");
            tblhptinhtp = dbAtVdc2GetTblHpTinhTpByTinhTpIdResult;
=======
            var dbAtVdc2GetTblHpQuanByQuanIdResult = await DbAtVdc2.GetTblHpQuanByQuanId($"{Quan_ID}");
            tblhpquan = dbAtVdc2GetTblHpQuanByQuanIdResult;
>>>>>>> Stashed changes:hr-pr/server/Pages/EditTblHpQuan.razor.designer.cs
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

<<<<<<< Updated upstream:radzen-app/server/Pages/EditTblHpTinhTp.razor.designer.cs
        protected async System.Threading.Tasks.Task Form0Submit(CanErp2.Models.DbAtVdc2.TblHpTinhTp args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpTinhTpResult = await DbAtVdc2.UpdateTblHpTinhTp($"{TinhTP_ID}", tblhptinhtp);
                DialogService.Close(tblhptinhtp);
            }
            catch (Exception dbAtVdc2UpdateTblHpTinhTpException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpTinhTp");
=======
        protected async System.Threading.Tasks.Task Form0Submit(CanErpHp.Models.DbAtVdc2.TblHpQuan args)
        {
            try
            {
                var dbAtVdc2UpdateTblHpQuanResult = await DbAtVdc2.UpdateTblHpQuan($"{Quan_ID}", tblhpquan);
                DialogService.Close(tblhpquan);
            }
            catch (Exception dbAtVdc2UpdateTblHpQuanException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblHpQuan");
>>>>>>> Stashed changes:hr-pr/server/Pages/EditTblHpQuan.razor.designer.cs
            }
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
