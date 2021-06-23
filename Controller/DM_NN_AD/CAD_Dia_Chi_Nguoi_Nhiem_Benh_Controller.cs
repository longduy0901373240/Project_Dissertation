using DataLayer;
using Entity.DM_NN_AD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.DM_NN_AD
{
    public class CAD_Dia_Chi_Nguoi_Nhiem_Benh_Controller
    {
        public IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> List_AD_Dia_Chi_Nguoi_Nhiem_Benh()
        {
            IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> v_arrRes = new List<CAD_Dia_Chi_Nguoi_Nhiem_Benh>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_List_AD_Dia_Chi_Nguoi_Nhiem_Benh");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CAD_Dia_Chi_Nguoi_Nhiem_Benh v_objRes = CUtility.Map<CAD_Dia_Chi_Nguoi_Nhiem_Benh>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public CAD_Dia_Chi_Nguoi_Nhiem_Benh Get_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_ID(int p_iID)
        {
            CAD_Dia_Chi_Nguoi_Nhiem_Benh v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_Get_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map<CAD_Dia_Chi_Nguoi_Nhiem_Benh>(v_dt.Rows[0]);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }

        public int Insert_AD_Dia_Chi_Nguoi_Nhiem_Benh(CAD_Dia_Chi_Nguoi_Nhiem_Benh p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Dia_Chi_Nguoi_Nhiem_Benh",
                    p_objData.Nguoi_Nhiem_ID, p_objData.Dia_Chi_ID, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_AD_Dia_Chi_Nguoi_Nhiem_Benh(CAD_Dia_Chi_Nguoi_Nhiem_Benh p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_upd_AD_Dia_Chi_Nguoi_Nhiem_Benh", p_objData.Auto_ID,
                    p_objData.Nguoi_Nhiem_ID, p_objData.Dia_Chi_ID, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_AD_Dia_Chi_Nguoi_Nhiem_Benh(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_del_AD_Dia_Chi_Nguoi_Nhiem_Benh", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Customize
        public IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> F10_1_List_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_Nguoi_Nhiem_ID(int p_intNguoi_Nhiem_ID)
        {
            IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> v_arrRes = new List<CAD_Dia_Chi_Nguoi_Nhiem_Benh>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "F10_1_sp_sel_List_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_Nguoi_Nhiem_Benh",
                    p_intNguoi_Nhiem_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CAD_Dia_Chi_Nguoi_Nhiem_Benh v_objRes = CUtility.Map<CAD_Dia_Chi_Nguoi_Nhiem_Benh>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }
        public IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> F10_2_List_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_Dia_Chi_ID(int p_intDia_Chi_ID)
        {
            IList<CAD_Dia_Chi_Nguoi_Nhiem_Benh> v_arrRes = new List<CAD_Dia_Chi_Nguoi_Nhiem_Benh>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "F10_2_sp_sel_List_AD_Dia_Chi_Nguoi_Nhiem_Benh_By_Dia_Chi_ID",
                    p_intDia_Chi_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CAD_Dia_Chi_Nguoi_Nhiem_Benh v_objRes = CUtility.Map<CAD_Dia_Chi_Nguoi_Nhiem_Benh>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }
        #endregion
    }
}
