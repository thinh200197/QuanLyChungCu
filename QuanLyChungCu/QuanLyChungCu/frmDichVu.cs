using Microsoft.VisualBasic;
using QuanLyChungCu.DAO;
using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class frmDichVu : Form
    {
        bool isSave = false;
        public frmDichVu()
        {
            InitializeComponent();
        }
        #region Method
        private void LoadData()
        {
            var data = ServiceDAO.Instance.GetAll();
            gv_Data.DataSource = data;
            gridView1.Columns["MaLoaiDichVu"].Visible = false;
        }

        private void ResetGroup()
        {
            txt_ID.Text = string.Empty;
            txt_TenDichVu.Text = string.Empty;
            txt_DonViTinh.Text = string.Empty;
            cb_TenLoaiDichVu.SelectedIndex = -1;
        }

        private void EnableControl(bool enable)
        {
            txt_ID.Enabled = enable;
            txt_TenDichVu.Enabled = enable;
            txt_DonViTinh.Enabled = enable;
            cb_TenLoaiDichVu.Enabled = enable;
        }

        private List<string> ValiInput()
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                errors.Add("Nhập ID.");
            }
            if (string.IsNullOrEmpty(txt_TenDichVu.Text))
            {
                errors.Add("Nhập Tên Dịch Vụ.");
            }

            if (cb_TenLoaiDichVu.SelectedIndex < 0 )
            {
                errors.Add("Chọn Tên Loại Dịch Vụ.");
            }

            if (string.IsNullOrEmpty(txt_DonViTinh.Text))
            {
                errors.Add("Nhập Đơn vị tính.");
            }

            return errors;
        }
        #endregion

        #region Event
        private void btnNew_Click(object sender, EventArgs e)
        {
            isSave = true;
            EnableControl(true);
            txt_ID.Enabled = false;
            ResetGroup();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isSave = true;
            EnableControl(true);
            txt_ID.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                return;
            }

            var erros = ValiInput();
            if (erros.Any())
            {
                MessageBox.Show(string.Join("\n", erros), "Thông Báo");
                return;
            }

            var request = new ServiceDTO()
            {
                MaDichVu = int.Parse(txt_ID.Text),
                TenDichVu = txt_TenDichVu.Text,
                MaLoaiDichVu = int.Parse(cb_TenLoaiDichVu.SelectedValue.ToString()),
                DonViTinh = txt_DonViTinh.Text,
            };

            try
            {
                var result = new Messeges();
                var hasResult = ServiceDAO.Instance.GetServiceById(request.MaDichVu);
                if (hasResult.MaDichVu > 0)
                {
                    result = ServiceDAO.Instance.Update(request);
                }
                else
                {
                    result = ServiceDAO.Instance.Add(request);
                }

                if (result.MessegeType == MessegeType.Success)
                {
                    LoadData();
                }
                MessageBox.Show(result.MessegeContent, "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void gv_Data_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as ServiceDTO;
            if (row == null)
            {
                return;
            }

            txt_ID.Text = row.MaDichVu.ToString();
            txt_TenDichVu.Text = row.TenDichVu;
            txt_DonViTinh.Text = row.DonViTinh;
            cb_TenLoaiDichVu.SelectedValue = row.MaLoaiDichVu;
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            cb_TenLoaiDichVu.DataSource = ServiceCategogyDAO.Instance.GetAll();
            cb_TenLoaiDichVu.DisplayMember = "TENLOAIDICHVU";
            cb_TenLoaiDichVu.ValueMember = "ID";

            LoadData();
        }
        #endregion


    }
}
