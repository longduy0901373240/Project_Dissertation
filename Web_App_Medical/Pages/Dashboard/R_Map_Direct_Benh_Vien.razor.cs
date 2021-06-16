using Entity.DM_AD;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Medical.Pages.Dashboard
{
    public partial class R_Map_Direct_Benh_Vien
    {
        private string p_strAddress_User { get; set; }
        private CAD_Dia_Chi p_objAddress_Hospital { get; set; }
        int ActiveTabIndex { get; set; } = 1;

        #region Quận
        IList<CAD_Quan> p_arrQuan;
        private CAD_Quan p_objQuan = null;
        private bool p_EnabledCB_Quan { get; set; } = false;
        #endregion

        #region Khoa khám
        IList<CAD_Khoa_Kham> p_arrKhoa_Kham;
        private CAD_Khoa_Kham p_objKhoa_Kham = null;
        private bool p_EnabledCB_Khoa_Kham { get; set; } = false;

        private IList<CAD_Khoa_Kham_Benh_Vien> p_arrKhoa_Kham_Benh_Vien;
        #endregion

        #region Bệnh Viện
        IList<CAD_Benh_Vien> p_arrBenh_Vien;
        IList<CAD_Benh_Vien> p_arrBenh_Vien_Temp = null;
        private CAD_Benh_Vien p_objBenh_Vien = null;
        private CAD_Khoa_Kham p_objChuyen_Khoa_Benh_Vien;
        private bool p_EnabledCB_Benh_Vien { get; set; } = true;
        #endregion

        #region Địa chỉ
        IList<CAD_Dia_Chi> p_arrDia_Chi;
        #endregion

        protected override void OnInitialized()
        {
            p_arrQuan = _db_Quan.List_AD_Quan();
            p_arrKhoa_Kham = _db_Khoa_Kham.List_AD_Khoa_Kham();
            p_arrBenh_Vien = _db_Benh_Vien.List_AD_Benh_Vien();
            p_arrDia_Chi = _db_Dia_Chi.List_AD_Dia_Chi();

            Selected_Quan_Changed(p_objQuan);
            Selected_Khoa_Kham_Changed(p_objKhoa_Kham);
            Selected_Benh_Vien_Changed(p_objBenh_Vien);
        }
        protected override async void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                await IJS.InvokeVoidAsync("initMap", null);
                await IJS.InvokeVoidAsync("initAutocompleteAddress_User");
            }
        }
        #region Quận
        private void Selected_Quan_Changed(CAD_Quan p_objItem)
        {
            if (p_objItem != null)
            {
                p_objBenh_Vien = null;
                if (p_arrBenh_Vien_Temp == null)
                {
                    p_EnabledCB_Quan = true;
                    p_EnabledCB_Benh_Vien = false;
                    p_objQuan = p_objItem;
                    IList<CAD_Dia_Chi> v_arrDia_Chi_By_Quan_ID = _db_Dia_Chi.F2_1_List_AD_Dia_Chi_By_Quan_ID(p_objItem.Auto_ID);
                    List<int> v_arrAuto_ID_Benh_Vien = new List<int>();
                    foreach (var item_Dia_Chi in v_arrDia_Chi_By_Quan_ID)
                    {
                        int v_iAuto_ID_Benh_Vien = _db_Dia_Chi_Benh_Vien.F3_3_Get_Benh_Vien_ID_By_Dia_Chi_ID(item_Dia_Chi.Auto_ID);
                        if (v_arrAuto_ID_Benh_Vien.Any(item => item == v_iAuto_ID_Benh_Vien) != true)
                        {
                            v_arrAuto_ID_Benh_Vien.Add(v_iAuto_ID_Benh_Vien);
                        }
                    }
                    IList<CAD_Benh_Vien> v_arrBenh_Vien = new List<CAD_Benh_Vien>();
                    foreach (var item in v_arrAuto_ID_Benh_Vien)
                    {
                        CAD_Benh_Vien v_objItem = _db_Benh_Vien.Get_AD_Benh_Vien_By_ID(item);
                        v_arrBenh_Vien.Add(v_objItem);
                    }
                    p_arrBenh_Vien_Temp = v_arrBenh_Vien;
                    p_arrBenh_Vien = v_arrBenh_Vien;
                }
                else
                {
                    p_arrBenh_Vien = p_arrBenh_Vien_Temp;
                    p_EnabledCB_Quan = true;
                    p_objQuan = p_objItem;
                    IList<CAD_Dia_Chi> v_arrDia_Chi_By_Quan_ID = _db_Dia_Chi.F2_1_List_AD_Dia_Chi_By_Quan_ID(p_objItem.Auto_ID);
                    List<int> v_arrAuto_ID_Benh_Vien = new List<int>();
                    foreach (var item in v_arrDia_Chi_By_Quan_ID)
                    {
                        int v_iAuto_ID_Benh_Vien = _db_Dia_Chi_Benh_Vien.F3_3_Get_Benh_Vien_ID_By_Dia_Chi_ID(item.Auto_ID);
                        if (v_arrAuto_ID_Benh_Vien.Any(item => item == v_iAuto_ID_Benh_Vien) != true)
                        {
                            v_arrAuto_ID_Benh_Vien.Add(v_iAuto_ID_Benh_Vien);
                        }
                    }
                    IList<CAD_Benh_Vien> v_arrBenh_Vien = new List<CAD_Benh_Vien>();
                    foreach (var v_iBenh_Vien_ID in v_arrAuto_ID_Benh_Vien)
                    {
                        foreach (var item in p_arrBenh_Vien)
                        {
                            if (item.Auto_ID == v_iBenh_Vien_ID)
                            {
                                v_arrBenh_Vien.Add(item);
                            }
                        }
                    }
                    p_arrBenh_Vien = v_arrBenh_Vien;
                }

            }
        }
        #endregion

        #region Khoa khám
        private void Selected_Khoa_Kham_Changed(CAD_Khoa_Kham p_objItem)
        {
            if (p_objItem != null)
            {
                p_objBenh_Vien = null;
                if (p_arrBenh_Vien_Temp != null)
                {
                    p_arrBenh_Vien = p_arrBenh_Vien_Temp;
                    p_arrBenh_Vien_Temp = null;
                    p_EnabledCB_Khoa_Kham = true;
                    p_objKhoa_Kham = p_objItem;
                    IList<CAD_Khoa_Kham_Benh_Vien> v_arrKhoa_Kham_Benh_Vien_By_Khoa_Kham_ID = _db_Khoa_Kham_Benh_vien.F5_2_List_AD_Khoa_Kham_Benh_Vien_By_Khoa_Kham_ID(p_objItem.Auto_ID);
                    IList<CAD_Benh_Vien> v_arrBenh_Vien = new List<CAD_Benh_Vien>();
                    foreach (var item_Khoa_Kham_Benh_Vien in v_arrKhoa_Kham_Benh_Vien_By_Khoa_Kham_ID)
                    {
                        foreach (var item_Benh_Vien in p_arrBenh_Vien)
                        {
                            if (item_Benh_Vien.Auto_ID == item_Khoa_Kham_Benh_Vien.Benh_Vien_ID)
                            {
                                v_arrBenh_Vien.Add(item_Benh_Vien);
                            }
                        }
                    }
                    p_arrBenh_Vien = v_arrBenh_Vien;
                }
                else
                {
                    p_EnabledCB_Benh_Vien = false;
                    p_EnabledCB_Khoa_Kham = true;
                    p_objKhoa_Kham = p_objItem;
                    IList<CAD_Khoa_Kham_Benh_Vien> v_arrKhoa_Kham_Benh_Vien_By_Khoa_Kham_ID = _db_Khoa_Kham_Benh_vien.F5_2_List_AD_Khoa_Kham_Benh_Vien_By_Khoa_Kham_ID(p_objItem.Auto_ID);
                    IList<CAD_Benh_Vien> v_arrBenh_Vien = new List<CAD_Benh_Vien>();
                    foreach (var item_Khoa_Kham_Benh_Vien in v_arrKhoa_Kham_Benh_Vien_By_Khoa_Kham_ID)
                    {
                        foreach (var item_Benh_Vien in p_arrBenh_Vien)
                        {
                            if (item_Benh_Vien.Auto_ID == item_Khoa_Kham_Benh_Vien.Benh_Vien_ID)
                            {
                                v_arrBenh_Vien.Add(item_Benh_Vien);
                            }
                        }
                    }
                    p_arrBenh_Vien_Temp = v_arrBenh_Vien;
                    p_arrBenh_Vien = v_arrBenh_Vien;
                }
            }
        }
        #endregion

        #region Bệnh viện
        private void Selected_Benh_Vien_Changed(CAD_Benh_Vien p_objItem)
        {
            if (p_objItem != null)
            {
                p_objBenh_Vien = p_objItem;
                p_objChuyen_Khoa_Benh_Vien = _db_Khoa_Kham.Get_AD_Khoa_Kham_By_ID(p_objItem.Chuyen_Khoa);
                p_arrKhoa_Kham_Benh_Vien = _db_Khoa_Kham_Benh_vien.F5_1_List_AD_Khoa_Kham_Benh_Vien_By_Benh_Vien_ID(p_objItem.Auto_ID);
                IList<CAD_Dia_Chi_Benh_Vien> v_arrDia_Chi_Benh_Vien = _db_Dia_Chi_Benh_Vien.F3_1_List_AD_Dia_Chi_Benh_Vien_By_Benh_Vien_ID(p_objItem.Auto_ID);
                CAD_Dia_Chi v_objDia_Chi = _db_Dia_Chi.Get_AD_Dia_Chi_By_ID(v_arrDia_Chi_Benh_Vien[0].Dia_Chi_ID);
                p_objAddress_Hospital = v_objDia_Chi;
            }
        }
        #endregion

        #region event button
        private void Event_Click_Clear_Benh_Vien()
        {
            p_EnabledCB_Quan = false;
            p_EnabledCB_Khoa_Kham = false;
            p_EnabledCB_Benh_Vien = true;

            p_objQuan = null;
            p_objKhoa_Kham = null;
            p_objBenh_Vien = null;
            p_arrBenh_Vien = _db_Benh_Vien.List_AD_Benh_Vien();
            p_arrBenh_Vien_Temp = null;
        }

        async void Confirm_address_user(MouseEventArgs args)
        {
            await IJS.InvokeVoidAsync("Marker_Address_User", p_strAddress_User);
        }

        async void Submit(MouseEventArgs args)
        {
            await IJS.InvokeVoidAsync("point_Start_End",p_strAddress_User,p_objAddress_Hospital);
        }
        #endregion
    }
}
