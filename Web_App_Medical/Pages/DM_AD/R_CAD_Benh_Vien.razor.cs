using DevExpress.Blazor;
using Entity.DM_AD;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Medical.Pages.DM_AD
{
    public partial class R_CAD_Benh_Vien
    {
        DxDataGrid<CAD_Benh_Vien> _Grid_Benh_Vien;

        #region Bệnh viện
        private IList<CAD_Benh_Vien> p_arrBenh_Vien;
        private CAD_Benh_Vien p_objBenh_Vien;
        #endregion

        #region Khoa Khám
        private IList<CAD_Khoa_Kham> p_arrKhoa_Kham;
        #endregion
        private bool IsNewRow { get; set; }
        public string Error { get; set; }

        protected override void OnInitialized()
        {
            p_arrBenh_Vien = _db_Benh_Vien.List_AD_Benh_Vien();
            p_arrKhoa_Kham = _db_Khoa_Kham.List_AD_Khoa_Kham();
        }
        #region CRUD
        async void OnRowDeleting(CAD_Benh_Vien p_objItem)
        {

            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db_Benh_Vien.Delete_AD_Benh_Vien(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            OnInitialized();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting(CAD_Benh_Vien p_objItem)
        {
            if (p_objItem == null)
            {
                p_objBenh_Vien = new CAD_Benh_Vien();
                IsNewRow = true;
            }
            else
            {
                p_objBenh_Vien = p_objItem;
                IsNewRow = false;
            }

        }
        void HandleValiSubmit()
        {
            try
            {
                CAD_Benh_Vien v_objItem = p_objBenh_Vien;
                if (IsNewRow == true)
                {
                    v_objItem.Last_Updated_By = "admin";
                    _db_Benh_Vien.Insert_AD_Benh_Vien(v_objItem);
                }
                else
                {
                    v_objItem.Last_Updated_By = "admin";
                    _db_Benh_Vien.Update_AD_Benh_Vien(v_objItem);
                }
                _Grid_Benh_Vien.CancelRowEdit();
                LoadData();
                Error = "";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
        #endregion
        async void LoadData()
        {
            OnInitialized();
            await InvokeAsync(StateHasChanged);
        }
        void OnCancelButtonClick()
        {
            _Grid_Benh_Vien.CancelRowEdit();
            p_objBenh_Vien = null;
            Error = "";
        }
    }
}
