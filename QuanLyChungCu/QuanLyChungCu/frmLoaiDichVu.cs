using QuanLyChungCu.DAO;
using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class frmLoaiDichVu : Form
    {
        bool isSave = false;
        public frmLoaiDichVu()
        {
            InitializeComponent();
        }
        #region Method
        void LoadData()
        {
            var data = ServiceCategogyDAO.Instance.GetAll();
            gv_Data.DataSource = data;
        }
        #endregion

        #region Event
        private void frmLoaiDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isSave = true;
            txt_TenLoaiDichVu.Enabled = true;
            txt_ID.Enabled = false;
        }

        private void gv_Data_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as ServiceCategogyDTO;
            if (row == null)
            {
                return;
            }

            txt_TenLoaiDichVu.Enabled = false;
            txt_ID.Enabled = false;

            txt_TenLoaiDichVu.Text = row.Name;
            txt_ID.Text = row.ID.ToString();

            isSave = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isSave = true;
            txt_TenLoaiDichVu.Enabled = true;
            txt_ID.Enabled = false;

            txt_TenLoaiDichVu.ResetText();
            txt_ID.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (!isSave)
            {
                return;
            }

            List<string> errors = new List<string>();
            //if (string.IsNullOrEmpty(txt_ID.Text))
            //{
            //    errors.Add("Nhập Mã loại.");
            //}
            if (string.IsNullOrEmpty(txt_TenLoaiDichVu.Text))
            {
                errors.Add("Nhập Tên Loại.");
            }
            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n",errors), "Thông Báo");
                return;
            }

            var request = new ServiceCategogyDTO()
            {
                ID = txt_ID.Text == "" ? 0 : int.Parse(txt_ID.Text),
                Name = txt_TenLoaiDichVu.Text
            };

            try
            {
                var result = new Messeges();
                var hasResult = ServiceCategogyDAO.Instance.GetFoolById(txt_ID.Text.Trim());
                if (hasResult.ID > 0)
                {
                    result = ServiceCategogyDAO.Instance.Update(request);
                }
                else
                {
                    result = ServiceCategogyDAO.Instance.Add(request);
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
        #endregion

    }
}
