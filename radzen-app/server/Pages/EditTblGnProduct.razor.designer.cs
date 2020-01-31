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
    public partial class EditTblGnProductComponent : ComponentBase
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
        public dynamic Product_SEQ { get; set; }

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
            canEdit = true;

            var canErpDbAt132GetTblGnProductByProductSeqResult = await CanErpDbAt132.GetTblGnProductByProductSeq(int.Parse($"{Product_SEQ}"));
            tblgnproduct = canErpDbAt132GetTblGnProductByProductSeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnProduct args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnProductResult = await CanErpDbAt132.UpdateTblGnProduct(int.Parse($"{Product_SEQ}"), tblgnproduct);
                DialogService.Close(tblgnproduct);
            }
            catch (Exception canErpDbAt132UpdateTblGnProductException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnProduct");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
