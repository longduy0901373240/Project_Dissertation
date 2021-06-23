using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.DM_NN_AD
{
    public class CAD_Nguoi_Nhiem_Benh
    {
		private int m_intAuto_ID;
		private string m_strTen_Nguoi_Nhiem;
		private DateTime m_dtmNgay_Sinh;
		private string m_strSDT;
		private string m_strEmail;
		private int m_intID_Loai_Benh;
		private int m_intID_Phan_Loai_Nhiem;
		private bool m_blnXac_Nhan;
		private string m_strGhi_Chu;
		private int m_intdeleted;
		private DateTime m_dtmCreated;
		private string m_strCreated_By;
		private DateTime m_dtmLast_Updated;
		private string m_strLast_Updated_By;

		public CAD_Nguoi_Nhiem_Benh()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_intAuto_ID = CConst.INT_VALUE_NULL;
			m_strTen_Nguoi_Nhiem = CConst.STR_VALUE_NULL;
			m_dtmNgay_Sinh = CConst.DTM_VALUE_NULL;
			m_strSDT = CConst.STR_VALUE_NULL;
			m_strEmail = CConst.STR_VALUE_NULL;
			m_intID_Loai_Benh = CConst.INT_VALUE_NULL;
			m_intID_Phan_Loai_Nhiem = CConst.INT_VALUE_NULL;
			m_blnXac_Nhan = CConst.BL_VALUE_NULL;
			m_strGhi_Chu = CConst.STR_VALUE_NULL;
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

		public string Ten_Nguoi_Nhiem
		{
			get
			{
				return m_strTen_Nguoi_Nhiem;
			}
			set
			{
				m_strTen_Nguoi_Nhiem = value.Trim();
			}
		}

		public DateTime Ngay_Sinh
		{
			get
			{
				return m_dtmNgay_Sinh;
			}
			set
			{
				m_dtmNgay_Sinh = value;
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

		public int ID_Loai_Benh
		{
			get
			{
				return m_intID_Loai_Benh;
			}
			set
			{
				m_intID_Loai_Benh = value;
			}
		}

		public int ID_Phan_Loai_Nhiem
		{
			get
			{
				return m_intID_Phan_Loai_Nhiem;
			}
			set
			{
				m_intID_Phan_Loai_Nhiem = value;
			}
		}

		public bool Xac_Nhan
		{
			get
			{
				return m_blnXac_Nhan;
			}
			set
			{
				m_blnXac_Nhan = value;
			}
		}

		public string Ghi_Chu
		{
			get
			{
				return m_strGhi_Chu;
			}
			set
			{
				m_strGhi_Chu = value.Trim();
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
