using DevExpress.Blazor;
using Entity.DM_AD;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Medical.Pages.DM_AD
{
    public partial class R_CAD_Thong_Tin_Chi_Tiet_Benh_Vien
    {
        #region Bệnh viện
        private IList<CAD_Benh_Vien> p_arrBenh_Vien;
        private CAD_Benh_Vien p_objBenh_Vien = null;
        #endregion

        #region Khoa khám
        DxDataGrid<CAD_Khoa_Kham_Benh_Vien> _Grid_Khoa_Kham_Benh_Vien;
        private IList<CAD_Khoa_Kham> p_arrKhoa_Kham;
        private IList<CAD_Khoa_Kham_Benh_Vien> p_arrKhoa_Kham_Benh_Vien;

        private CAD_Khoa_Kham_Benh_Vien p_objKhoa_Kham_Benh_Vien;
        private CAD_Khoa_Kham p_objChuyen_Khoa_Benh_Vien;
        #endregion

        #region Địa chỉ
        DxDataGrid<CAD_Dia_Chi> _Grid_Dia_Chi;
        private IList<CAD_Dia_Chi> p_arrDia_Chi = new List<CAD_Dia_Chi>();
        private IList<CAD_Dia_Chi_Benh_Vien> p_arrDia_Chi_Benh_Vien;
        private IList<CAD_Quan> p_arrQuan;

        private CAD_Dia_Chi p_objDia_Chi;
        #endregion

        private bool IsNewRow { get; set; }
        public string Error { get; set; }

        #region Loading khi vào page
        protected override void OnInitialized()
        {
            p_arrBenh_Vien = _db_Benh_Vien.List_AD_Benh_Vien();
            p_arrQuan = _db_Quan.List_AD_Quan();
            p_arrKhoa_Kham = _db_Khoa_Kham.List_AD_Khoa_Kham();
            Selected_Benh_Vien_Changed(p_objBenh_Vien);
        }
        private void Selected_Benh_Vien_Changed(CAD_Benh_Vien p_objItem)
        {
            if (p_objItem != null)
            {
                p_objBenh_Vien = p_objItem;
                //Lấy obj khoa khám dựa vào Field của table bệnh viện
                p_objChuyen_Khoa_Benh_Vien = _db_Khoa_Kham.Get_AD_Khoa_Kham_By_ID(p_objItem.Chuyen_Khoa);
                //Lấy list địa chỉ bệnh viện dựa vào Field auto id của table bệnh viện
                p_arrDia_Chi_Benh_Vien = _db_Dia_Chi_Benh_Vien.F3_1_List_AD_Dia_Chi_Benh_Vien_By_Benh_Vien_ID(p_objItem.Auto_ID);
                //Lấy list địa chỉ dựa vào Field địa chỉ id của table địa chỉ bệnh viện
                foreach (CAD_Dia_Chi_Benh_Vien item in p_arrDia_Chi_Benh_Vien)
                {
                    CAD_Dia_Chi v_objITem = _db_Dia_Chi.Get_AD_Dia_Chi_By_ID(item.Dia_Chi_ID);
                    p_arrDia_Chi.Add(v_objITem);
                }
                //Lấy list khoa khám bệnh viện dựa vào Field auto id của table bệnh viện
                p_arrKhoa_Kham_Benh_Vien = _db_Khoa_Kham_Benh_Vien.F5_1_List_AD_Khoa_Kham_Benh_Vien_By_Benh_Vien_ID(p_objItem.Auto_ID);
            }
        }
        #endregion

        #region CRUD Địa chỉ
        async void OnRowDeleting_Dia_Chi(CAD_Dia_Chi p_objItem)
        {

            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db_Dia_Chi.Delete_AD_Dia_Chi(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
                _db_Dia_Chi_Benh_Vien.F3_2_Delete_AD_Dia_Chi_Benh_Vien_By_Dia_Chi_ID(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            LoadData_Dia_Chi();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting_Dia_Chi(CAD_Dia_Chi p_objItem)
        {
            if (p_objItem == null)
            {
                p_objDia_Chi = new CAD_Dia_Chi();
                IsNewRow = true;
            }
            else
            {
                p_objDia_Chi = p_objItem;
                IsNewRow = false;
            }

        }
        void HandleValiSubmit_Dia_Chi()
        {
            try
            {
                CAD_Dia_Chi v_objItem_Dia_chi = p_objDia_Chi;
                CAD_Dia_Chi_Benh_Vien v_objItem_Dia_Chi_Benh_Vien = new CAD_Dia_Chi_Benh_Vien();
                if (IsNewRow == true)
                {
                    v_objItem_Dia_chi.Last_Updated_By = "admin";
                    int v_intDia_Chi_ID = _db_Dia_Chi.Insert_AD_Dia_Chi(v_objItem_Dia_chi);
                    v_objItem_Dia_Chi_Benh_Vien.Benh_Vien_ID = p_objBenh_Vien.Auto_ID;
                    v_objItem_Dia_Chi_Benh_Vien.Dia_Chi_ID = v_intDia_Chi_ID;
                    v_objItem_Dia_Chi_Benh_Vien.Last_Updated_By = "admin";
                    _db_Dia_Chi_Benh_Vien.Insert_AD_Dia_Chi_Benh_Vien(v_objItem_Dia_Chi_Benh_Vien);
                }
                else
                {
                    v_objItem_Dia_chi.Last_Updated_By = "admin";
                    _db_Dia_Chi.Update_AD_Dia_Chi(v_objItem_Dia_chi);
                }
                _Grid_Dia_Chi.CancelRowEdit();
                LoadData_Dia_Chi();
                Error = "";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
        async void LoadData_Dia_Chi()
        {
            IList<CAD_Dia_Chi> v_arrItem = new List<CAD_Dia_Chi>();
            p_arrDia_Chi_Benh_Vien = _db_Dia_Chi_Benh_Vien.F3_1_List_AD_Dia_Chi_Benh_Vien_By_Benh_Vien_ID(p_objBenh_Vien.Auto_ID);
            foreach (CAD_Dia_Chi_Benh_Vien item in p_arrDia_Chi_Benh_Vien)
            {
                CAD_Dia_Chi v_objITem = _db_Dia_Chi.Get_AD_Dia_Chi_By_ID(item.Dia_Chi_ID);
                v_arrItem.Add(v_objITem);
            }
            p_arrDia_Chi = v_arrItem;
            await InvokeAsync(StateHasChanged);
        }
        void OnCancelButtonClick_Dia_Chi()
        {
            _Grid_Dia_Chi.CancelRowEdit();
            p_objDia_Chi = null;
            Error = "";
        }
        #endregion

        #region CRUD Khoa khám
        async void OnRowDeleting_Khoa_Kham(CAD_Khoa_Kham_Benh_Vien p_objItem)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db_Khoa_Kham_Benh_Vien.Delete_AD_Khoa_Kham_Benh_Vien(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            LoadData_Khoa_Kham();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting_Khoa_Kham(CAD_Khoa_Kham_Benh_Vien p_objItem)
        {
            if (p_objItem == null)
            {
                p_objKhoa_Kham_Benh_Vien = new CAD_Khoa_Kham_Benh_Vien();
                IsNewRow = true;
            }
            else
            {
                p_objKhoa_Kham_Benh_Vien = p_objItem;
                IsNewRow = false;
            }

        }
        void HandleValiSubmit_Khoa_Kham()
        {
            try
            {
                CAD_Khoa_Kham_Benh_Vien v_objItem = p_objKhoa_Kham_Benh_Vien;
                if (IsNewRow == true)
                {
                    v_objItem.Last_Updated_By = "admin";
                    v_objItem.Benh_Vien_ID = p_objBenh_Vien.Auto_ID;
                    _db_Khoa_Kham_Benh_Vien.Insert_AD_Khoa_Kham_Benh_Vien(v_objItem);
                }
                else
                {
                    v_objItem.Last_Updated_By = "admin";
                    _db_Khoa_Kham_Benh_Vien.Update_AD_Khoa_Kham_Benh_Vien(v_objItem);
                }
                _Grid_Khoa_Kham_Benh_Vien.CancelRowEdit();
                LoadData_Khoa_Kham();
                Error = "";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
        async void LoadData_Khoa_Kham()
        {
            IList<CAD_Khoa_Kham_Benh_Vien> v_arrItem = new List<CAD_Khoa_Kham_Benh_Vien>();
            v_arrItem = _db_Khoa_Kham_Benh_Vien.F5_1_List_AD_Khoa_Kham_Benh_Vien_By_Benh_Vien_ID(p_objBenh_Vien.Auto_ID);
            p_arrKhoa_Kham_Benh_Vien = v_arrItem;
            await InvokeAsync(StateHasChanged);
        }
        void OnCancelButtonClick_Khoa_Kham()
        {
            _Grid_Khoa_Kham_Benh_Vien.CancelRowEdit();
            p_objKhoa_Kham_Benh_Vien = null;
            Error = "";
        }
        #endregion
    }
}
