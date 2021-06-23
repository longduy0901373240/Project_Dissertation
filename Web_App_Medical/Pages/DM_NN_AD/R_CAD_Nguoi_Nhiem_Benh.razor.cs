using DevExpress.Blazor;
using Entity.DM_AD;
using Entity.DM_NN_AD;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Medical.Pages.DM_NN_AD
{
    public partial class R_CAD_Nguoi_Nhiem_Benh
    {
        DxDataGrid<CAD_Nguoi_Nhiem_Benh> _Grid_Nguoi_Nhiem_Benh;
        private IList<CAD_Nguoi_Nhiem_Benh> p_arrNguoi_Nhiem_Benh;
        CAD_Nguoi_Nhiem_Benh p_objNguoi_Nhiem_Benh;
        int p_intAuto_ID_Nguoi_Nhiem_Benh;


        private IList<CAD_Phan_Loai_Nhiem> p_arrPhan_Loai_Nhiem;

        private IList<CAD_Loai_Benh> p_arrLoai_Benh;

        private IList<CAD_Quan> p_arrQuan;

        DxDataGrid<CAD_Dia_Chi> _Grid_Dia_Chi_Nguoi_Nhiem_Benh;
        CAD_Dia_Chi p_objDia_Chi_Nguoi_Nhiem_Benh;
        IList<CAD_Dia_Chi> p_arrDia_Chi_Nguoi_Nhiem_By_Nguoi_Nhiem_ID = new List<CAD_Dia_Chi>();
        private bool IsNewRow_Dia_Chi_Nguoi_Nhiem { get; set; }
        public string Error_Dia_Chi_Nguoi_Nhiem { get; set; }
        private bool IsNewRow { get; set; }
        public string Error { get; set; }
        private string p_strSessionValue = "";

        protected override async Task OnInitializedAsync()
        {
            p_strSessionValue = await iLocalStorage.GetItemAsync<string>("SessionValue");
        }
        protected override void OnInitialized()
        {
            p_arrNguoi_Nhiem_Benh = _db_Nguoi_Nhiem_Benh.List_AD_Nguoi_Nhiem_Benh();
            p_arrLoai_Benh = _db_Loai_Benh.List_AD_Loai_Benh();
            p_arrPhan_Loai_Nhiem = _db_Phan_Loai_Nhiem.List_AD_Phan_Loai_Nhiem();
            p_arrQuan = _db_Quan.List_AD_Quan();
        }

        #region Địa chỉ người nhiểm bệnh
        async void OnRowDeleting_Dia_Chi_Nguoi_Nhiem_Benh(CAD_Dia_Chi p_objItem)
        {
            IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> v_arrDia_Chi_Nguoi_Nhiem_Benh = new List<CAD_Dia_Chi_Nguoi_Nhiem_Benh>();
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                v_arrDia_Chi_Nguoi_Nhiem_Benh = _db_Dia_Chi_Nguoi_Nhiem_Benh.F10_2_List_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_Dia_Chi_ID(p_objItem.Auto_ID);
                foreach (var item in v_arrDia_Chi_Nguoi_Nhiem_Benh)
                {
                    _db_Dia_Chi_Nguoi_Nhiem_Benh.Delete_AD_Dia_Chi_Nguoi_Nhiem_Benh(item.Auto_ID,"admin");
                }
                _db_Dia_Chi.Delete_AD_Dia_Chi(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            LoadData_Dia_Chi_Nguoi_Nhiem();
        }
        private IList<CAD_Dia_Chi> Get_List_Dia_Chi_Nguoi_Nhiem_Benh(int p_intID_Nguoi_Nhiem)
        {
            IList<CAD_Dia_Chi> v_arrRes = new List<CAD_Dia_Chi>();
            IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> v_arrDia_Chi_Nguoi_Nhiem_Benh_By_Nguoi_Nhiem_ID = _db_Dia_Chi_Nguoi_Nhiem_Benh.F10_1_List_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_Nguoi_Nhiem_ID(p_intID_Nguoi_Nhiem);
            CAD_Dia_Chi v_objDia_Chi_By_Nguoi_Nhiem_Benh = new CAD_Dia_Chi();
            foreach (var item in v_arrDia_Chi_Nguoi_Nhiem_Benh_By_Nguoi_Nhiem_ID)
            {
                v_objDia_Chi_By_Nguoi_Nhiem_Benh = _db_Dia_Chi.Get_AD_Dia_Chi_By_ID(item.Dia_Chi_ID);
                v_arrRes.Add(v_objDia_Chi_By_Nguoi_Nhiem_Benh);
            }
            return v_arrRes;
        }
        void HandleValiSubmit_Dia_Chi_Nguoi_Nhiem()
        {
            try
            {
                CAD_Dia_Chi_Nguoi_Nhiem_Benh v_objDia_Chi_Nguoi_Nhiem_Benh = new CAD_Dia_Chi_Nguoi_Nhiem_Benh();
                CAD_Dia_Chi v_objItem = p_objDia_Chi_Nguoi_Nhiem_Benh;
                if (IsNewRow_Dia_Chi_Nguoi_Nhiem == true)
                {
                    v_objItem.Last_Updated_By = "admin";
                    v_objDia_Chi_Nguoi_Nhiem_Benh.Dia_Chi_ID = _db_Dia_Chi.Insert_AD_Dia_Chi(v_objItem);
                    v_objDia_Chi_Nguoi_Nhiem_Benh.Nguoi_Nhiem_ID = p_intAuto_ID_Nguoi_Nhiem_Benh;
                    v_objDia_Chi_Nguoi_Nhiem_Benh.Last_Updated_By = "admin";
                    _db_Dia_Chi_Nguoi_Nhiem_Benh.Insert_AD_Dia_Chi_Nguoi_Nhiem_Benh(v_objDia_Chi_Nguoi_Nhiem_Benh);
                }
                else
                {
                    v_objItem.Last_Updated_By = "admin";
                    _db_Dia_Chi.Update_AD_Dia_Chi(v_objItem);
                }
                _Grid_Dia_Chi_Nguoi_Nhiem_Benh.CancelRowEdit();
                LoadData_Dia_Chi_Nguoi_Nhiem();
                Error_Dia_Chi_Nguoi_Nhiem = "";
            }
            catch (Exception ex)
            {

                Error_Dia_Chi_Nguoi_Nhiem=ex.Message;
            }
        }
        void OnRowStarting_Dia_Chi_Nguoi_Nhiem(CAD_Dia_Chi p_objItem)
        {
            if (p_objItem==null)
            {
                p_objDia_Chi_Nguoi_Nhiem_Benh = new CAD_Dia_Chi();
                IsNewRow_Dia_Chi_Nguoi_Nhiem = true;
            }
            else
            {
                p_objDia_Chi_Nguoi_Nhiem_Benh = p_objItem;
                IsNewRow_Dia_Chi_Nguoi_Nhiem = false;
            }
        }
        async void LoadData_Dia_Chi_Nguoi_Nhiem()
        {
            p_arrDia_Chi_Nguoi_Nhiem_By_Nguoi_Nhiem_ID = Get_List_Dia_Chi_Nguoi_Nhiem_Benh(p_intAuto_ID_Nguoi_Nhiem_Benh);
            _Grid_Dia_Chi_Nguoi_Nhiem_Benh.Data=p_arrDia_Chi_Nguoi_Nhiem_By_Nguoi_Nhiem_ID;
            await InvokeAsync(StateHasChanged);
        }
        void OnCancelButtonClick_Dia_Chi_Nguoi_Nhiem()
        {
            _Grid_Dia_Chi_Nguoi_Nhiem_Benh.CancelRowEdit();
            p_objDia_Chi_Nguoi_Nhiem_Benh = null;
            Error_Dia_Chi_Nguoi_Nhiem = "";
        }
        #endregion

        #region Người Nhiễm Bệnh
        async void OnRowDeleting_Nguoi_Nhiem_Benh(CAD_Nguoi_Nhiem_Benh p_objItem)
        {
            IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> v_arrDia_Chi_Nguoi_Nhiem_Benh = new List<CAD_Dia_Chi_Nguoi_Nhiem_Benh>();
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                v_arrDia_Chi_Nguoi_Nhiem_Benh = _db_Dia_Chi_Nguoi_Nhiem_Benh.F10_1_List_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_Nguoi_Nhiem_ID(p_objItem.Auto_ID);
                foreach (var item in v_arrDia_Chi_Nguoi_Nhiem_Benh)
                {
                    _db_Dia_Chi.Delete_AD_Dia_Chi(item.Dia_Chi_ID,"admin");
                    _db_Dia_Chi_Nguoi_Nhiem_Benh.Delete_AD_Dia_Chi_Nguoi_Nhiem_Benh(item.Auto_ID, "admin");
                }
                _db_Nguoi_Nhiem_Benh.Delete_AD_Nguoi_Nhiem_Benh(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            OnInitialized();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting_Nguoi_Nhiem_Benh(CAD_Nguoi_Nhiem_Benh p_objItem)
        {
            if (p_objItem == null)
            {
                p_objNguoi_Nhiem_Benh = new CAD_Nguoi_Nhiem_Benh();
                IsNewRow = true;
            }
            else
            {
                p_objNguoi_Nhiem_Benh = p_objItem;
                IsNewRow = false;
            }

        }
        void HandleValiSubmit_Nguoi_Nhiem_Benh()
        {
            try
            {
                CAD_Nguoi_Nhiem_Benh v_objItem = p_objNguoi_Nhiem_Benh;
                if (IsNewRow == true)
                {
                    v_objItem.Last_Updated_By = "admin";
                    _db_Nguoi_Nhiem_Benh.Insert_AD_Nguoi_Nhiem_Benh(v_objItem);
                }
                else
                {
                    v_objItem.Last_Updated_By = "admin";
                    _db_Nguoi_Nhiem_Benh.Update_AD_Nguoi_Nhiem_Benh(v_objItem);
                }
                _Grid_Nguoi_Nhiem_Benh.CancelRowEdit();
                LoadData_Nguoi_Nhiem_Benh();
                Error = "";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
        async void LoadData_Nguoi_Nhiem_Benh()
        {
            OnInitialized();
            await InvokeAsync(StateHasChanged);
        }
        void OnCancelButtonClick_Nguoi_Nhiem_Benh()
        {
            _Grid_Nguoi_Nhiem_Benh.CancelRowEdit();
            p_objNguoi_Nhiem_Benh = null;
            Error = "";
        }
        #endregion
    }
}
