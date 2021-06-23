using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.Admin
{
    public class CThanh_Vien
    {
		private int m_intAuto_ID;
		private string m_strMa_Dang_Nhap;
		private string m_strTen;
		private string m_strHo_Lot;
		private string m_strSDT;
		private string m_strEmail;
		private string m_strPassword;
		private int m_intdeleted;
		private DateTime m_dtmCreated;
		private string m_strCreated_By;
		private DateTime m_dtmLast_Updated;
		private string m_strLast_Updated_By;

		public CThanh_Vien()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_intAuto_ID = CConst.INT_VALUE_NULL;
			m_strMa_Dang_Nhap = CConst.STR_VALUE_NULL;
			m_strTen = CConst.STR_VALUE_NULL;
			m_strHo_Lot = CConst.STR_VALUE_NULL;
			m_strSDT = CConst.STR_VALUE_NULL;
			m_strEmail = CConst.STR_VALUE_NULL;
			m_strPassword = CConst.STR_VALUE_NULL;
			m_intdeleted = CConst.INT_VALUE_NULL;
			m_dtmCreated = CConst.DTM_VALUE_NULL;
			m_strCreated_By = CConst.STR_VALUE_NULL;
			m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
			m_strLast_Updated_By = CConst.STR_VALUE_NULL;
		}

		public int Auto_ID
		{
			get
			{
				return m_intAuto_ID;
			}
			set
			{
				m_intAuto_ID = value;
			}
		}

		public string Ma_Dang_Nhap
		{
			get
			{
				return m_strMa_Dang_Nhap;
			}
			set
			{
				m_strMa_Dang_Nhap = value.Trim();
			}
		}

		public string Ten
		{
			get
			{
				return m_strTen;
			}
			set
			{
				m_strTen = value.Trim();
			}
		}

		public string Ho_Lot
		{
			get
			{
				return m_strHo_Lot;
			}
			set
			{
				m_strHo_Lot = value.Trim();
			}
		}

		public string SDT
		{
			get
			{
				return m_strSDT;
			}
			set
			{
				m_strSDT = value.Trim();
			}
		}

		public string Email
		{
			get
			{
				return m_strEmail;
			}
			set
			{
				m_strEmail = value.Trim();
			}
		}

		public string Password
		{
			get
			{
				return m_strPassword;
			}
			set
			{
				m_strPassword = value.Trim();
			}
		}

		public int deleted
		{
			get
			{
				return m_intdeleted;
			}
			set
			{
				m_intdeleted = value;
			}
		}

		public DateTime Created
		{
			get
			{
				return m_dtmCreated;
			}
			set
			{
				m_dtmCreated = value;
			}
		}

		public string Created_By
		{
			get
			{
				return m_strCreated_By;
			}
			set
			{
				m_strCreated_By = value.Trim();
			}
		}

		public DateTime Last_Updated
		{
			get
			{
				return m_dtmLast_Updated;
			}
			set
			{
				m_dtmLast_Updated = value;
			}
		}

		public string Last_Updated_By
		{
			get
			{
				return m_strLast_Updated_By;
			}
			set
			{
				m_strLast_Updated_By = value.Trim();
			}
		}
	}
}
