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
        private string p_strSessionValue = "";

        protected override async Task OnInitializedAsync()
        {
            p_strSessionValue = await iLocalStorage.GetItemAsync<string>("SessionValue");
        }
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
                IList<CAD_Dia_Chi_Benh_Vien> v_arrDia_Chi_Benh_Vien = _db_Dia_Chi_Benh_Vien.F3_1_List_AD_Dia_Chi_Benh_Vien_By_Benh_Vien_ID(p_objItem.Auto_ID);
                foreach (var item in v_arrDia_Chi_Benh_Vien)
                {
                    _db_Dia_Chi_Benh_Vien.Delete_AD_Dia_Chi_Benh_Vien(item.Auto_ID, "admin");
                    _db_Dia_chi.Delete_AD_Dia_Chi(item.Dia_Chi_ID,"admin");
                }
                IList<CAD_Khoa_Kham_Benh_Vien> v_arrKhoa_Kham_Benh_Vien = _db_Khoa_Kham_Benh_Vien.F5_1_List_AD_Khoa_Kham_Benh_Vien_By_Benh_Vien_ID(p_objItem.Auto_ID);
                foreach (var item in v_arrKhoa_Kham_Benh_Vien)
                {
                    _db_Khoa_Kham_Benh_Vien.Delete_AD_Khoa_Kham_Benh_Vien(item.Auto_ID,"admin");
                }

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
