using DataLayer;
using Entity.DM_NN_AD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.DM_NN_AD
{
    public class CAD_Loai_Benh_Controller
    {
		public IList<CAD_Loai_Benh> List_AD_Loai_Benh()
		{
			IList<CAD_Loai_Benh> v_arrRes = new List<CAD_Loai_Benh>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_List_AD_Loai_Benh");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CAD_Loai_Benh v_objRes = CUtility.Map<CAD_Loai_Benh>(v_row);
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

		public CAD_Loai_Benh Get_AD_Loai_Benh_By_ID(int p_iID)
		{
			CAD_Loai_Benh v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_Get_AD_Loai_Benh_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = CUtility.Map<CAD_Loai_Benh>(v_dt.Rows[0]);
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

		public int Insert_AD_Loai_Benh(CAD_Loai_Benh p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Loai_Benh",
					p_objData.Ten_Loai_Benh, p_objData.Ghi_Chu, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public int Insert_AD_Loai_Benh(SqlConnection p_conn, SqlTransaction p_strans, CAD_Loai_Benh p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(p_conn, p_strans, CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Loai_Benh",
					p_objData.Ten_Loai_Benh, p_objData.Ghi_Chu, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public void Update_AD_Loai_Benh(CAD_Loai_Benh p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_upd_AD_Loai_Benh", p_objData.Auto_ID,
					p_objData.Ten_Loai_Benh, p_objData.Ghi_Chu, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_AD_Loai_Benh(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_del_AD_Loai_Benh", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
