using DataLayer;
using Entity.DM_AD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.DM_AD
{
    public class CAD_Dia_Chi_Benh_Vien_Controller
    {
		public IList<CAD_Dia_Chi_Benh_Vien> List_AD_Dia_Chi_Benh_Vien()
		{
			IList<CAD_Dia_Chi_Benh_Vien> v_arrRes = new List<CAD_Dia_Chi_Benh_Vien>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_List_AD_Dia_Chi_Benh_Vien");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CAD_Dia_Chi_Benh_Vien v_objRes = CUtility.Map<CAD_Dia_Chi_Benh_Vien>(v_row);
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

		public CAD_Dia_Chi_Benh_Vien Get_AD_Dia_Chi_Benh_Vien_By_ID(int p_iID)
		{
			CAD_Dia_Chi_Benh_Vien v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "sp_sel_Get_AD_Dia_Chi_Benh_Vien_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = CUtility.Map<CAD_Dia_Chi_Benh_Vien>(v_dt.Rows[0]);
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

		public int Insert_AD_Dia_Chi_Benh_Vien(CAD_Dia_Chi_Benh_Vien p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strLuan_Van_Data_Conn_String, "sp_ins_AD_Dia_Chi_Benh_Vien",
					p_objData.Benh_Vien_ID, p_objData.Dia_Chi_ID, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public void Update_AD_Dia_Chi_Benh_Vien(CAD_Dia_Chi_Benh_Vien p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_upd_AD_Dia_Chi_Benh_Vien", p_objData.Auto_ID,
					p_objData.Benh_Vien_ID, p_objData.Dia_Chi_ID, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_AD_Dia_Chi_Benh_Vien(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "sp_del_AD_Dia_Chi_Benh_Vien", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		#region Custom
		public IList<CAD_Dia_Chi_Benh_Vien> F3_1_List_AD_Dia_Chi_Benh_Vien_By_Benh_Vien_ID(int p_intBenh_Vien_ID)
		{
			IList<CAD_Dia_Chi_Benh_Vien> v_arrRes = new List<CAD_Dia_Chi_Benh_Vien>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Data_Conn_String, v_dt, "F3_1_sp_sel_List_AD_Dia_Chi_Benh_Vien_By_Benh_Vien_ID",
					p_intBenh_Vien_ID);

				foreach (DataRow v_row in v_dt.Rows)
				{
					CAD_Dia_Chi_Benh_Vien v_objRes = CUtility.Map<CAD_Dia_Chi_Benh_Vien>(v_row);
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

		public void F3_2_Delete_AD_Dia_Chi_Benh_Vien_By_Dia_Chi_ID(int p_iDia_Chi_ID, string p_strLast_Updated_By)
        {
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Data_Conn_String, "F3_2_sp_del_AD_Dia_Chi_Benh_Vien_By_Dia_Chi_ID", p_iDia_Chi_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
		#endregion
	}
}
