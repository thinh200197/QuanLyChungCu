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
    public partial class frmTang : Form
    {
        public frmTang()
        {
            InitializeComponent();
        }
        #region Method
        void LoadDS()
        {
            var data = FloorDAO.Instance.GetAll();
            gv_Tang.DataSource = data;
            gridView1.Columns["MaBlock"].Visible = false;
        }

        void Clear()
        {
            txt_MaTang.Text = string.Empty;
            txt_TenTang.Text = string.Empty;
            cb_ToaNha.SelectedIndex = -1;
        }

        void EnableControl(bool enable)
        {
            txt_MaTang.Enabled = enable;
            txt_TenTang.Enabled = enable;
            cb_ToaNha.Enabled = enable;
        }
        List<string> valiInput()
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(txt_MaTang.Text.Trim()))
            {
                errors.Add("Nhập mã tầng.");
            }
            if (string.IsNullOrEmpty(txt_TenTang.Text.Trim()))
            {
                errors.Add("Nhập tên tầng.");
            }
            if (cb_ToaNha.SelectedIndex < 0)
            {
                errors.Add("Nhập tòa nhà.");
            }

            return errors;
        }
        #endregion

        #region Event
        private void frmTang_Load(object sender, EventArgs e)
        {
            cb_ToaNha.DataSource = BlockDAO.Instance.GetAll();
            cb_ToaNha.DisplayMember = "TENBLOCK";
            cb_ToaNha.ValueMember = "MABLOCK";

            LoadDS();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            EnableControl(true);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txt_TenTang.Enabled = true;
            cb_ToaNha.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var errors = valiInput();

            if (errors.Any())
            {
                MessageBox.Show(string.Join("/n", errors), "Thông báo");
                return;
            }

            var floor = new FloorDTO()
            {
                MaBlock = cb_ToaNha.SelectedValue.ToString(),
                TenTangLau = txt_TenTang.Text,
                MaTangLau = txt_MaTang.Text,
            };

            try
            {
                var result = new Messeges();
                var hasFloor = FloorDAO.Instance.GetFoolById(txt_MaTang.Text.Trim());

                if (hasFloor.MaBlock != null)
                {
                    result = FloorDAO.Instance.Update(floor);
                }
                else
                {
                    result = FloorDAO.Instance.Add(floor);
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

        private void gv_Tang_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as FloorDTO;
            if (row == null)
            {
                return;
            }
            EnableControl(false);

            txt_MaTang.Text = row.MaTangLau;
            txt_TenTang.Text = row.TenTangLau;
            cb_ToaNha.SelectedValue = row.MaBlock;
        }
        #endregion


    }
}
