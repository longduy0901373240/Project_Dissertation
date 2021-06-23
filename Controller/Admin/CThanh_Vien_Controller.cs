using DataLayer;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.Admin
{
    public class CThanh_Vien_Controller
    {
		public IList<CThanh_Vien> List_Thanh_Vien()
		{
			IList<CThanh_Vien> v_arrRes = new List<CThanh_Vien>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Admin_Conn_String, v_dt, "sp_sel_List_Thanh_Vien");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CThanh_Vien v_objRes = CUtility.Map<CThanh_Vien>(v_row);
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

		public CThanh_Vien Get_Thanh_Vien_By_ID(int p_iID)
		{
			CThanh_Vien v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strLuan_Van_Admin_Conn_String, v_dt, "sp_sel_Get_Thanh_Vien_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = CUtility.Map<CThanh_Vien>(v_dt.Rows[0]);
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

		public int Insert_Thanh_Vien(CThanh_Vien p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strLuan_Van_Admin_Conn_String, "sp_ins_Thanh_Vien",
					p_objData.Ma_Dang_Nhap, p_objData.Ten, p_objData.Ho_Lot, p_objData.SDT, p_objData.Email, p_objData.Password, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public void Update_Thanh_Vien(CThanh_Vien p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Admin_Conn_String, "sp_upd_Thanh_Vien", p_objData.Auto_ID,
					p_objData.Ma_Dang_Nhap, p_objData.Ten, p_objData.Ho_Lot, p_objData.SDT, p_objData.Email, p_objData.Password, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_Thanh_Vien(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strLuan_Van_Admin_Conn_String, "sp_del_Thanh_Vien", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
