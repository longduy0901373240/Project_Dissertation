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
    public class CAD_Phan_Loai_Nhiem_Controller
    {
		public IList<CAD_Phan_Loai_Nhiem> List_AD_Phan_Loai_Nhiem()
		{
			IList<CAD_Phan_Loai_Nhiem> v_arrRes = new List<CAD_Phan_Loai_Nhiem>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_List_AD_Phan_Loai_Nhiem");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CAD_Phan_Loai_Nhiem v_objRes = CUtility.Map<CAD_Phan_Loai_Nhiem>(v_row);
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

		public CAD_Phan_Loai_Nhiem Get_AD_Phan_Loai_Nhiem_By_ID(int p_iID)
		{
			CAD_Phan_Loai_Nhiem v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_Get_AD_Phan_Loai_Nhiem_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = CUtility.Map<CAD_Phan_Loai_Nhiem>(v_dt.Rows[0]);
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

		public int Insert_AD_Phan_Loai_Nhiem(CAD_Phan_Loai_Nhiem p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Phan_Loai_Nhiem",
					p_objData.Ten_Loai_Nhiem, p_objData.Ghi_Chu, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}
		public int Insert_AD_Phan_Loai_Nhiem(SqlConnection v_conn, SqlTransaction v_trans, CAD_Phan_Loai_Nhiem p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(v_conn, v_trans, CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Phan_Loai_Nhiem",
					p_objData.Ten_Loai_Nhiem, p_objData.Ghi_Chu, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}
		public void Update_AD_Phan_Loai_Nhiem(CAD_Phan_Loai_Nhiem p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_upd_AD_Phan_Loai_Nhiem", p_objData.Auto_ID,
					p_objData.Ten_Loai_Nhiem, p_objData.Ghi_Chu, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_AD_Phan_Loai_Nhiem(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_del_AD_Phan_Loai_Nhiem", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
