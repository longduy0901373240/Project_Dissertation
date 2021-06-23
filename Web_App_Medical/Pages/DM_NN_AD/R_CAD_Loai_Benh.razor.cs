﻿using DataLayer;
using DevExpress.Blazor;
using Entity.DM_NN_AD;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace Web_App_Medical.Pages.DM_NN_AD
{
    public partial class R_CAD_Loai_Benh
    {
        DxDataGrid<CAD_Loai_Benh> _Grid_Loai_Benh;
        private IList<CAD_Loai_Benh> p_arrLoai_Benh;
        CAD_Loai_Benh p_objLoai_Benh;
        private bool IsNewRow { get; set; }
        public string Error { get; set; }
        private string p_strSessionValue = "";

        protected override async Task OnInitializedAsync()
        {
            p_strSessionValue = await iLocalStorage.GetItemAsync<string>("SessionValue");
        }
        protected override void OnInitialized()
        {
            p_arrLoai_Benh = _db_Loai_Benh.List_AD_Loai_Benh();
        }

        #region CRUD
        async void OnRowDeleting(CAD_Loai_Benh p_objItem)
        {

            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db_Loai_Benh.Delete_AD_Loai_Benh(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            OnInitialized();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting(CAD_Loai_Benh p_objItem)
        {
            if (p_objItem == null)
            {
                p_objLoai_Benh = new CAD_Loai_Benh();
                IsNewRow = true;
            }
            else
            {
                p_objLoai_Benh = p_objItem;
                IsNewRow = false;
            }

        }
        void HandleValiSubmit()
        {
            try
            {
                CAD_Loai_Benh v_objItem = p_objLoai_Benh;
                if (IsNewRow == true)
                {
                    v_objItem.Last_Updated_By = "admin";
                    _db_Loai_Benh.Insert_AD_Loai_Benh(v_objItem);
                }
                else
                {
                    v_objItem.Last_Updated_By = "admin";
                    _db_Loai_Benh.Update_AD_Loai_Benh(v_objItem);
                }
                _Grid_Loai_Benh.CancelRowEdit();
                LoadData();
                Error = "";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
        #endregion

        #region Excel
        string p_strPath;
        private async void OnInputFileChange(InputFileChangeEventArgs e)
        {
            try
            {
                CExcel_Controller v_objexcel = new CExcel_Controller();
                string v_strWebRootPath = env.WebRootPath;
                var url = await v_objexcel.SaveFile(e.File, v_strWebRootPath);
                p_strPath = null;
                p_strPath = url;
            }
            catch (Exception ex)
            {
                await IJS.InvokeVoidAsync("alert", $"Warning! {ex.Message}");
            }
        }
        private void Import_Excel()
        {
            CExcel_Controller v_objexcel = new CExcel_Controller();
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.g_strLuan_Van_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();
                //lọc từ vùng chọn đến hết
                DataTable v_dt_List_Range_Value_To_End = v_objexcel.List_Range_Value_To_End("A1", "B", p_strPath);
                string test = v_dt_List_Range_Value_To_End.Columns[0].ToString();
                foreach (DataRow v_row in v_dt_List_Range_Value_To_End.Rows)
                {
                    CAD_Loai_Benh v_objItem = new CAD_Loai_Benh();
                    v_objItem.Ten_Loai_Benh = CUtility.Convert_To_String(v_row[0]);
                    v_objItem.Ghi_Chu = CUtility.Convert_To_String(v_row[1]);
                    v_objItem.Last_Updated_By = "admin";
                    _db_Loai_Benh.Insert_AD_Loai_Benh(v_conn, v_trans, v_objItem);
                }
                v_trans.Commit();
                p_strPath = "";
                IJS.InvokeVoidAsync("Clear_InputFile");
                IJS.InvokeVoidAsync("alert", "Import thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                if (v_trans != null)
                    v_trans.Rollback();
                IJS.InvokeVoidAsync("alert", $"Warning! {ex.Message}");
            }
            finally
            {
                v_trans.Dispose();
                if (v_conn != null)
                    v_conn.Close();
            }

        }
        #endregion
        async void LoadData()
        {
            OnInitialized();
            await InvokeAsync(StateHasChanged);
        }
        void OnCancelButtonClick()
        {
            _Grid_Loai_Benh.CancelRowEdit();
            p_objLoai_Benh = null;
            Error = "";
        }
    }
}
