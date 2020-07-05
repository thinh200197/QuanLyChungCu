using QuanLyChungCu.DAO;
using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class frmLoaiCanHo : Form
    {
        bool isSave = false;
        public frmLoaiCanHo()
        {
            InitializeComponent();
        }

        #region Method
        void LoadDS()
        {
            var data = ApartmentCategogyDAO.Instance.GetAll();
            gv_Data.DataSource = data;
        }

        void Clear()
        {
            foreach (Control item in groupControl1.Controls)
            {
                if (item is TextBox)
                {
                    this.ResetText();
                }
            }
            //txt_MaLoaiCH.Text = string.Empty;
            //txt_TenLoaiCH.Text = string.Empty;
            //cb_ToaNha.SelectedIndex = -1;
        }

        void EnableControl(bool enable)
        {
            txt_MaLoaiCH.Enabled = enable;
            txt_TenLoaiCH.Enabled = enable;
            txt_DienTich.Enabled = enable;
            txt_SoNguoiToiDa.Enabled = enable;
            txt_SoPhongNgu.Enabled = enable;
        }
        List<string> valiInput()
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(txt_MaLoaiCH.Text.Trim()))
            {
                errors.Add("Nhập mã loại.");
            }
            if (string.IsNullOrEmpty(txt_TenLoaiCH.Text.Trim()))
            {
                errors.Add("Nhập tên loại.");
            }

            return errors;
        }
        #endregion

        #region Event
        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            isSave = true;
            EnableControl(true);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isSave = true;
            EnableControl(true);
            txt_MaLoaiCH.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                return;
            }

            var errors = valiInput();

            if (errors.Any())
            {
                MessageBox.Show(string.Join("/n", errors), "Thông báo");
                return;
            }

            var request = new ApartmentCategogyDTO()
            {
                Tenloai_CH = txt_TenLoaiCH.Text,
                Maloai_CH = txt_MaLoaiCH.Text,
                DienTich = txt_DienTich.Text.Trim() == "" ? 0 : int.Parse(txt_DienTich.Text),
                SoNguoiToiDa = txt_SoNguoiToiDa.Text.Trim() == "" ? 0 : int.Parse(txt_SoNguoiToiDa.Text),
                SoPhongNgu = txt_SoPhongNgu.Text.Trim() == "" ? 0 : int.Parse(txt_SoPhongNgu.Text),
            };

            try
            {
                var result = new Messeges();
                var hasFloor = ApartmentCategogyDAO.Instance.GetFoolById(txt_MaLoaiCH.Text.Trim());

                if (hasFloor.Maloai_CH != null)
                {
                    result = ApartmentCategogyDAO.Instance.Update(request);
                }
                else
                {
                    result = ApartmentCategogyDAO.Instance.Add(request);
                }

                if (result.MessegeType == MessegeType.Success)
                {
                    LoadDS();
                }
                MessageBox.Show(result.MessegeContent, "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
        private void frmLoaiCanHo_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void gv_Data_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as ApartmentCategogyDTO;
            if (row == null)
            {
                return;
            }
            isSave = false;
            EnableControl(false);

            txt_MaLoaiCH.Text = row.Maloai_CH;
            txt_TenLoaiCH.Text = row.Tenloai_CH;
            txt_DienTich.Text = row.DienTich.ToString();
            txt_SoNguoiToiDa.Text = row.SoNguoiToiDa.ToString();
            txt_SoPhongNgu.Text = row.SoPhongNgu.ToString();
        }
        #endregion  
    }
}
