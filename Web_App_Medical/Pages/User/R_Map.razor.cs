using Entity.DM_AD;
using Entity.DM_NN_AD;
using Entity.DM_VN_AD;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Medical.Pages.User
{
    public partial class R_Map
    {
        #region
        private IList<CAD_Dia_Chi> p_arrDia_Chi;
        private IList<CAD_Dia_Chi_Benh_Vien> p_arrDia_Chi_Benh_Vien;
        private IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> p_arrDia_chi_Nguoi_Nhiem_Benh = new List<CAD_Dia_Chi_Nguoi_Nhiem_Benh>();
        private IList<CAD_Nguoi_Nhiem_Benh> p_arrNguoi_Nhiem_Benh;
        private IList<int> p_arrAuto_ID_Nguoi_Nhiem_Benh = new List<int>();
        private IList<CAD_Diem_Cach_Ly> p_arrDiem_Cach_Ly;
        #endregion

        #region CheckBox
        private bool p_blCheck_Box_All { get; set; } = false;
        private bool p_blCheck_Box_Nguoi_Nhiem { get; set; } = false;
        private bool p_blCheck_Box_Benh_Vien { get; set; } = false;
        private bool p_blCheck_Box_Diem_Cach_Ly { get; set; } = false;
        #endregion
        public string p_strAddress_User { get; set; }
        protected override void OnInitialized()
        {
            ;
            p_arrDia_Chi = _db_Dia_Chi.List_AD_Dia_Chi();
            p_arrDia_Chi_Benh_Vien = _db_Dia_Chi_Benh_Vien.List_AD_Dia_Chi_Benh_Vien();
            p_arrDiem_Cach_Ly = _db_Diem_Cach_Ly.List_AD_Diem_Cach_Ly();
            IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> v_arrDi_Chi_Nguoi_Nhiem_Benh_Temp = _db_Dia_Chi_Nguoi_Nhiem_Benh.List_AD_Dia_Chi_Nguoi_Nhiem_Benh();
            p_arrNguoi_Nhiem_Benh = _db_Nguoi_Nhiem_Benh.List_AD_Nguoi_Nhiem_Benh();
            foreach (var item in p_arrNguoi_Nhiem_Benh)
            {
                if (item.Xac_Nhan==true)
                {
                    p_arrAuto_ID_Nguoi_Nhiem_Benh.Add(item.Auto_ID);
                }
            }
            foreach (var item in v_arrDi_Chi_Nguoi_Nhiem_Benh_Temp)
            {
                foreach (var item_Auto_ID_Nguoi_Nhiem in p_arrAuto_ID_Nguoi_Nhiem_Benh)
                {
                    if (item.Nguoi_Nhiem_ID == item_Auto_ID_Nguoi_Nhiem)
                    {
                        p_arrDia_chi_Nguoi_Nhiem_Benh.Add(item);
                    }
                }
            }
            
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await IJS.InvokeVoidAsync("initMap", null);
                await IJS.InvokeVoidAsync("initAutocompleteAddress_User");
                #region
                IList<CAD_Dia_Chi> v_arrDia_Chi_Benh_Vien = new List<CAD_Dia_Chi>();
                CAD_Dia_Chi v_objDia_Chi_Benh_Vien;
                foreach (var item in p_arrDia_Chi_Benh_Vien)
                {
                    v_objDia_Chi_Benh_Vien = _db_Dia_Chi.Get_AD_Dia_Chi_By_ID(item.Dia_Chi_ID);
                    v_arrDia_Chi_Benh_Vien.Add(v_objDia_Chi_Benh_Vien);
                }
                IList<CAD_Dia_Chi> v_arrDia_Chi_Nguoi_Nhiem = new List<CAD_Dia_Chi>();
                CAD_Dia_Chi v_objDia_Chi_Nguoi_Nhiem;
                foreach (var item in p_arrDia_chi_Nguoi_Nhiem_Benh)
                {
                    v_objDia_Chi_Nguoi_Nhiem = _db_Dia_Chi.Get_AD_Dia_Chi_By_ID(item.Dia_Chi_ID);
                    v_arrDia_Chi_Nguoi_Nhiem.Add(v_objDia_Chi_Nguoi_Nhiem);
                }
                await IJS.InvokeVoidAsync("List_Marker_Address_All",v_arrDia_Chi_Benh_Vien,v_arrDia_Chi_Nguoi_Nhiem);
                await IJS.InvokeVoidAsync("List_Marker_Address_Diem_Cach_Ly",p_arrDiem_Cach_Ly);
                #endregion
                StateHasChanged();
            }
        }
        async void Submit(MouseEventArgs args)
        {
            await IJS.InvokeVoidAsync("Marker_Address_User", p_strAddress_User);
        }
        private async void EvenCheckBox_All(bool p_value)
        {
            p_blCheck_Box_All = p_value;
            if (p_value == true)
            {
                p_blCheck_Box_Benh_Vien = false;
                p_blCheck_Box_Nguoi_Nhiem = false;
                await IJS.InvokeVoidAsync("Hide_Markers_All");
                await IJS.InvokeVoidAsync("Show_Markers_All");
            }
            else
                await IJS.InvokeVoidAsync("Hide_Markers_All");
        }
        private async void EvenCheckBox_Benh_Vien(bool p_value)
        {
            p_blCheck_Box_Benh_Vien = p_value;
            if(p_value==true)
            {
                p_blCheck_Box_All = false;
                p_blCheck_Box_Nguoi_Nhiem = false;
                await IJS.InvokeVoidAsync("Hide_Markers_All");
                await IJS.InvokeVoidAsync("Show_Markers_Benh_Vien");
            }
            else
                await IJS.InvokeVoidAsync("Hide_Markers_All");
        }
        private async void EvenCheckBox_Nguoi_Nhiem(bool p_value)
        {
            p_blCheck_Box_Nguoi_Nhiem = p_value;
            if (p_value == true)
            {
                p_blCheck_Box_All = false;
                p_blCheck_Box_Benh_Vien = false;
                await IJS.InvokeVoidAsync("Hide_Markers_All");
                await IJS.InvokeVoidAsync("Show_Markers_Nguoi_Nhiem");
            }
            else
                await IJS.InvokeVoidAsync("Hide_Markers_All");
        }
        private async void EvenCheckBox_Diem_Cach_Ly(bool p_value)
        {
            p_blCheck_Box_Diem_Cach_Ly = p_value;
            if (p_value == true)
            {
                await IJS.InvokeVoidAsync("Show_Markers_Diem_Cach_Ly");
            }
            else
                await IJS.InvokeVoidAsync("Hide_Markers_Diem_Cach_Ly");
        }
    }
}
