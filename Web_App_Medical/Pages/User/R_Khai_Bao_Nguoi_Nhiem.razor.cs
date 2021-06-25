using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.DM_NN_AD;
using Entity.DM_AD;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;
using System.Threading;

namespace Web_App_Medical.Pages.User
{
    public partial class R_Khai_Bao_Nguoi_Nhiem
    {
        DxDataGrid<CAD_Dia_Chi> _Grid_Dia_Chi_Nguoi_Nhiem;
        private IList<CAD_Loai_Benh> p_arr_Loai_Benh;

        private IList<CAD_Phan_Loai_Nhiem> p_arrPhan_Loai_Nhiem;

        private IList<CAD_Dia_Chi> p_arrVi_tri_Nguoi_Nhiem = new List<CAD_Dia_Chi>();

        private CAD_Nguoi_Nhiem_Benh p_objNguoi_Nhiem_Benh = new CAD_Nguoi_Nhiem_Benh();

        private CAD_Dia_Chi p_objThong_Tin_Dia_Chi;
        public bool IsNewRow { get; set; }
        public string Error { get; set; }

        public string p_strAddress_User { get; set; }
        public string p_strDia_Chi_Chi_Tiet { get; set; }
        public string p_strLat { get; set; }
        public string p_strLng { get; set; }

        int p_Auto_ID = 0;

        protected override void OnInitialized()
        {
            p_arr_Loai_Benh = _db_Loai_Benh.List_AD_Loai_Benh();
            p_arrPhan_Loai_Nhiem = _db_Phan_Loai_Nhiem.List_AD_Phan_Loai_Nhiem();
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await IJS.InvokeVoidAsync("initMap", null);
                await IJS.InvokeVoidAsync("initAutocompleteAddress_User");
                StateHasChanged();
            }
        }
        async void Submit(MouseEventArgs args)
        {
            await IJS.InvokeVoidAsync("Marker_Address_User", p_strAddress_User);
            Thread.Sleep(1000);
            p_strDia_Chi_Chi_Tiet = await IJS.InvokeAsync<string>("Get_Dia_Chi_Chi_Tiet");
            p_strLat = await IJS.InvokeAsync<string>("Get_Lat");
            p_strLng = await IJS.InvokeAsync<string>("Get_Lng");
        }
        void OnRowStarting(CAD_Dia_Chi p_objItem)
        {
            if (p_objItem == null)
            {
                p_objThong_Tin_Dia_Chi = new CAD_Dia_Chi();
                p_objThong_Tin_Dia_Chi.Dia_Chi = p_strDia_Chi_Chi_Tiet;
                p_objThong_Tin_Dia_Chi.Lat = p_strLat;
                p_objThong_Tin_Dia_Chi.Lng = p_strLng;
                p_objThong_Tin_Dia_Chi.Last_Updated_By = "Admin";
                IsNewRow = true;
            }
            else
            {
                p_objThong_Tin_Dia_Chi = p_objItem;
                IsNewRow = false;
            }
        }
        void HandleValiSubmit()
        {
            try
            {
                CAD_Dia_Chi v_objItem = p_objThong_Tin_Dia_Chi;
                if (IsNewRow == true)
                {
                    v_objItem.Auto_ID = p_Auto_ID;
                    p_arrVi_tri_Nguoi_Nhiem.Add(v_objItem);
                    p_Auto_ID++;
                }
                else
                {
                    var item = p_arrVi_tri_Nguoi_Nhiem.FirstOrDefault(p => p.Auto_ID == v_objItem.Auto_ID);
                    if (item != null)
                        item = v_objItem;
                }
                _Grid_Dia_Chi_Nguoi_Nhiem.CancelRowEdit();
                _Grid_Dia_Chi_Nguoi_Nhiem.Refresh();
                Error = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
        async void OnRowDeleting(CAD_Dia_Chi p_objItem)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                p_arrVi_tri_Nguoi_Nhiem.Remove(p_objItem);
            }
            await _Grid_Dia_Chi_Nguoi_Nhiem.Refresh();
        }
        void OnCancelButtonClick()
        {
            _Grid_Dia_Chi_Nguoi_Nhiem.CancelRowEdit();
            p_objThong_Tin_Dia_Chi = null;
            Error = "";
        }
        async void Add_Data()
        {
            CAD_Nguoi_Nhiem_Benh v_objNguoi_Nhiem_Benh = p_objNguoi_Nhiem_Benh;
            int v_intAuto_ID_Nguoi_Nhiem = _db_Nguoi_Nhiem_Benh.Insert_AD_Nguoi_Nhiem_Benh(v_objNguoi_Nhiem_Benh);
            foreach (var item in p_arrVi_tri_Nguoi_Nhiem)
            {
                CAD_Dia_Chi_Nguoi_Nhiem_Benh v_objDia_Chi_Nguoi_Nhiem_Benh = new CAD_Dia_Chi_Nguoi_Nhiem_Benh();
                int v_intAuto_ID_Vi_Tri = _db_Dia_chi.Insert_AD_Dia_Chi(item);
                v_objDia_Chi_Nguoi_Nhiem_Benh.Dia_Chi_ID = v_intAuto_ID_Vi_Tri;
                v_objDia_Chi_Nguoi_Nhiem_Benh.Nguoi_Nhiem_ID = v_intAuto_ID_Nguoi_Nhiem;
                v_objDia_Chi_Nguoi_Nhiem_Benh.Last_Updated_By = "user";
                _db_Dia_Chi_Nguoi_Nhiem_Benh.Insert_AD_Dia_Chi_Nguoi_Nhiem_Benh(v_objDia_Chi_Nguoi_Nhiem_Benh);

            }
            await IJS.InvokeVoidAsync("alert", "Khai báo thành công");
            nav.NavigateTo("/user/map");
        }
    }
}
