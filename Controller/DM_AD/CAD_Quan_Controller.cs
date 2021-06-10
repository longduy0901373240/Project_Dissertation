﻿using DataLayer;
using Entity.DM_AD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.DM_AD
{
    public class CAD_Quan_Controller
    {
		public IList<CAD_Quan> List_AD_Quan()
		{
			IList<CAD_Quan> v_arrRes = new List<CAD_Quan>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_List_AD_Quan");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CAD_Quan v_objRes = CUtility.Map<CAD_Quan>(v_row);
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

		public CAD_Quan Get_AD_Quan_By_ID(int p_iID)
		{
			CAD_Quan v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_Get_AD_Quan_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = CUtility.Map<CAD_Quan>(v_dt.Rows[0]);
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

		public int Insert_AD_Quan(CAD_Quan p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Quan",
					p_objData.Ten_Quan, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public int Insert_AD_Quan(SqlConnection conn, SqlTransaction v_trans, CAD_Quan p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(conn, v_trans, CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Quan",
					p_objData.Ten_Quan, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public void Update_AD_Quan(CAD_Quan p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_upd_AD_Quan", p_objData.Auto_ID,
					p_objData.Ten_Quan, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_AD_Quan(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_del_AD_Quan", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
