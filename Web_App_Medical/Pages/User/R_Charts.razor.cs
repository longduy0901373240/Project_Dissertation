using Entity.DM_AD;
using Entity.DM_NN_AD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Medical.Pages.User
{
    public class Thong_Ke
    {
        public string Quan { get; set; }
        public int So_Ca_Nhiem { get; set; }
    }
    public partial class R_Charts
    {
        IList<Thong_Ke> p_arrThong_Khe = new List<Thong_Ke>();
        IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> p_arrDia_Chi_Nguoi_Nhiem;
        IList<CAD_Quan> p_arrQuan;
        IList<CAD_Dia_Chi> p_arrDia_Chi_By_ID_Nguoi_Nhiem = new List<CAD_Dia_Chi>();
        protected override void OnInitialized()
        {
            p_arrDia_Chi_Nguoi_Nhiem = _db_Dia_Chi_Nguoi_Nhiem_Benh.List_AD_Dia_Chi_Nguoi_Nhiem_Benh();
            p_arrQuan = _db_Quan.List_AD_Quan();
            foreach (var item in p_arrDia_Chi_Nguoi_Nhiem)
            {
                CAD_Dia_Chi v_objDia_Chi_By_ID_Nguoi_Nhiem = _db_Dia_Chi.Get_AD_Dia_Chi_By_ID(item.Dia_Chi_ID);
                p_arrDia_Chi_By_ID_Nguoi_Nhiem.Add(v_objDia_Chi_By_ID_Nguoi_Nhiem);
            }
            foreach (var item_Quan in p_arrQuan)
            {
                int count = 0;
                foreach (var item in p_arrDia_Chi_By_ID_Nguoi_Nhiem)
                {
                    if (item_Quan.Auto_ID == item.Quan_ID)
                    {
                        count++;
                    }
                }
                Thong_Ke v_objThong_Ke = new Thong_Ke();
                v_objThong_Ke.Quan = item_Quan.Ten_Quan;
                v_objThong_Ke.So_Ca_Nhiem = count;
                p_arrThong_Khe.Add(v_objThong_Ke);
            }
            
        }
    }
}
