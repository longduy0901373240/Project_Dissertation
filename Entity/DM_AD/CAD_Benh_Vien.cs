using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using Utility;

namespace Entity.DM_AD
{
	public class CAD_Benh_Vien
	{
		private int m_intAuto_ID;
		private string m_strTen_Benh_Vien;
		private int m_intChuyen_Khoa;
		private string m_strSDT;
		private string m_strEmail;
		private int m_intdeleted;
		private DateTime m_dtmCreated;
		private string m_strCreated_By;
		private DateTime m_dtmLast_Updated;
		private string m_strLast_Updated_By;

		public CAD_Benh_Vien()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_intAuto_ID = CConst.INT_VALUE_NULL;
			m_strTen_Benh_Vien = CConst.STR_VALUE_NULL;
			m_intChuyen_Khoa = CConst.INT_VALUE_NULL;
			m_strSDT = CConst.STR_VALUE_NULL;
			m_strEmail = CConst.STR_VALUE_NULL;
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

		public string Ten_Benh_Vien
		{
			get
			{
				return m_strTen_Benh_Vien;
			}
			set
			{
				m_strTen_Benh_Vien = value.Trim();
			}
		}

		public int Chuyen_Khoa
		{
			get
			{
				return m_intChuyen_Khoa;
			}
			set
			{
				m_intChuyen_Khoa = value;
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
