using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Medical.Pages.Admin
{
    public partial class Sign_In
    {
        private string p_strSession = "";
        private string p_strUserName;
        private string p_strPassword;
        private async void Event_Submit()
        {
            if (p_strPassword == "abcd@1234"&&p_strUserName=="admin")
            {
                p_strSession = "Admin";
                await iLocalStorage.SetItemAsync("SessionValue", p_strSession);
                nav.NavigateTo("/danh_muc_ad/benh_vien");
            }
        }    
        
    }
}
