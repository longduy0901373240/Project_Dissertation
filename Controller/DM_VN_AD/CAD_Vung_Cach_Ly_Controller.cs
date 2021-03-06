using DataLayer;
using Entity.DM_VN_AD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.DM_VN_AD
{
    public class CAD_Vung_Cach_Ly_Controller
    {
		public IList<CAD_Vung_Cach_Ly> List_AD_Vung_Cach_Ly()
		{
			IList<CAD_Vung_Cach_Ly> v_arrRes = new List<CAD_Vung_Cach_Ly>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_List_AD_Vung_Cach_Ly");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CAD_Vung_Cach_Ly v_objRes = CUtility.Map<CAD_Vung_Cach_Ly>(v_row);
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

		public CAD_Vung_Cach_Ly Get_AD_Vung_Cach_Ly_By_ID(int p_iID)
		{
			CAD_Vung_Cach_Ly v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_Get_AD_Vung_Cach_Ly_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = CUtility.Map<CAD_Vung_Cach_Ly>(v_dt.Rows[0]);
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

		public int Insert_AD_Vung_Cach_Ly(CAD_Vung_Cach_Ly p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Vung_Cach_Ly",
					p_objData.Ten_Vung, p_objData.Lat, p_objData.Lng, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public int Insert_AD_Vung_Cach_Ly(SqlConnection conn, SqlTransaction v_trans, CAD_Vung_Cach_Ly p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(conn, v_trans, CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Vung_Cach_Ly",
					p_objData.Ten_Vung, p_objData.Lat, p_objData.Lng, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public void Update_AD_Vung_Cach_Ly(CAD_Vung_Cach_Ly p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_upd_AD_Vung_Cach_Ly", p_objData.Auto_ID,
					p_objData.Ten_Vung, p_objData.Lat, p_objData.Lng, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_AD_Vung_Cach_Ly(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_del_AD_Vung_Cach_Ly", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

        #region Customize
		public IList<String> F11_1_List_Ten_Vung()
        {
			IList<string> v_arrRes = new List<string>();
			DataTable v_dt = new DataTable();
            try
            {
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "F11_1_sp_sel_List_Ten_Vung");
                foreach (DataRow v_row in v_dt.Rows)
                {
					string v_objRes = CUtility.Convert_To_String(v_row.ItemArray[0]);
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
