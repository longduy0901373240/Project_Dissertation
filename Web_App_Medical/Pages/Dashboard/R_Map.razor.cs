using Entity.DM_AD;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Medical.Pages.Dashboard
{
    public partial class R_Map
    {
        #region
        private IList<CAD_Dia_Chi> p_arrDia_Chi;
        private IList<CAD_Dia_Chi_Benh_Vien> p_arrDia_Chi_Benh_Vien;
        private CAD_Dia_Chi p_objItem = new CAD_Dia_Chi();
        #endregion

        #region CheckBox
        private bool p_blCheck_Box_Benh_Vien { get; set; } = false;
        #endregion
        public string p_strAddress_User { get; set; }
        protected override async void OnInitialized()
        {
            p_arrDia_Chi = _db_Dia_Chi.List_AD_Dia_Chi();
            p_arrDia_Chi_Benh_Vien = _db_Dia_Chi_Benh_Vien.List_AD_Dia_Chi_Benh_Vien();
            #region
            
            #endregion
            p_objItem = p_arrDia_Chi.FirstOrDefault();
            

        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await IJS.InvokeVoidAsync("initMap",null);
                await IJS.InvokeVoidAsync("initAutocompleteAddress_User");
                #region
                IList<CAD_Dia_Chi> v_arrDia_Chi_Benh_Vien = new List<CAD_Dia_Chi>();
                CAD_Dia_Chi v_objDia_Chi_Benh_Vien;
                foreach (var item in p_arrDia_Chi_Benh_Vien)
                {
                    v_objDia_Chi_Benh_Vien = _db_Dia_Chi.Get_AD_Dia_Chi_By_ID(item.Dia_Chi_ID);
                    v_arrDia_Chi_Benh_Vien.Add(v_objDia_Chi_Benh_Vien);
                }
                await IJS.InvokeVoidAsync("List_Marker_Address_Benh_Vien", v_arrDia_Chi_Benh_Vien);
                #endregion
                StateHasChanged();
            }
        }
        async void Submit(MouseEventArgs args)
        {
            await IJS.InvokeVoidAsync("Marker_Address_User", p_strAddress_User);
        }
        private async void EvenCheckBox_Benh_Vien(bool p_value)
        {
            p_blCheck_Box_Benh_Vien = p_value;
            
            if (p_value == true)
            {
                await IJS.InvokeVoidAsync("Show_Markers_Benh_Vien");
                //await IJS.InvokeVoidAsync("List_Marker_Address_Benh_Vien", v_arrDia_Chi_Benh_Vien);
            }
            else
            {
                await IJS.InvokeVoidAsync("Hide_Markers_Benh_Vien");
                //await IJS.InvokeVoidAsync("List_Marker_Address_Benh_Vien", v_arrDia_Chi_Benh_Vien);
            }
        }
    }
}
