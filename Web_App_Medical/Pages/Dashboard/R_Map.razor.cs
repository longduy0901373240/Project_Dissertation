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
        private IList<CAD_Dia_Chi> p_arrDia_Chi;
        private CAD_Dia_Chi p_objItem = new CAD_Dia_Chi();
        public string p_strAddress_User { get; set; }
        protected override void OnInitialized()
        {
            p_arrDia_Chi = _db_Dia_Chi.List_AD_Dia_Chi();
            p_objItem = p_arrDia_Chi.FirstOrDefault();
            
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await IJS.InvokeVoidAsync("initMap",null);
                await IJS.InvokeVoidAsync("initAutocompleteAddress_User");
                StateHasChanged();
            }
        }
        async void Submit(MouseEventArgs args)
        {
            await IJS.InvokeVoidAsync("Marker_Address_User", p_strAddress_User);
        }
    }
}
