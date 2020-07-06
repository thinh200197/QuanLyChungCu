using QuanLyChungCu.DAO;
using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class frmNhanKhau : Form
    {
        bool isSave = false;
        public frmNhanKhau()
        {
            InitializeComponent();
        }
        private void EnableControl(bool enable)
        {
            txt_CuDan_CMND.Enabled = enable;
            txt_CuDan_Ten.Enabled = enable;
            txt_SDT.Enabled = enable;
            cb_CanHo.Enabled = enable;
            cb_CuDan_GioiTinh.Enabled = enable;
            dtp_NgaySinh.Enabled = enable;
        }
        private List<string> ValiInput()
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(txt_CuDan_CMND.Text))
            {
                errors.Add("Nhập CMND.");
            }
            if (string.IsNullOrEmpty(txt_CuDan_Ten.Text))
            {
                errors.Add("Nhập Họ và Tên.");
            }
            if (string.IsNullOrEmpty(dtp_NgaySinh.Value.ToString()))
            {
                errors.Add("Chọn Ngày sinh.");
            }
            if (string.IsNullOrEmpty(txt_SDT.Text))
            {
                errors.Add("Nhập Số điện thoại.");
            }
            if (cb_CanHo.SelectedIndex < 0)
            {
                errors.Add("Chọn Căn Hộ.");
            }
            if (cb_CuDan_GioiTinh.SelectedIndex < 0)
            {
                errors.Add("Chọn Giới Tính.");
            }
            if (txt_CuDan_CMND.Text != null && (DateTime.Now.Year - dtp_NgaySinh.Value.Year) < 15)
            {
                errors.Add("Ngày sinh không hợp lệ.");
            }
            return errors;
        }
        private void frmNhanKhau_Load(object sender, EventArgs e)
        {
            //Thông tin căn hộ
            var data = ApartmentDAO.Instance.GetAll();
            cb_CanHo.DataSource = data;
            cb_CanHo.DisplayMember = "TENCANHO";
            cb_CanHo.ValueMember = "MACANHO";
            cb_CanHo.SelectedIndex = -1;

            //Thông tin nhân khẩu
            LoadNhanKhau();
            txt_CuDan_CMND.Focus();
        }

        private void LoadNhanKhau()
        {
            var data = NhanKhauDAO.Instance.DanhSachNhanKhau();
            dgvNhanKhau.DataSource = data;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_CuDan_CMND.Text = string.Empty;
            txt_CuDan_Ten.Text = string.Empty;
            cb_CuDan_GioiTinh.SelectedIndex = -1;
            txt_SDT.Text = string.Empty;
            dtp_NgaySinh.Value = DateTime.Now;

            cb_CanHo.SelectedIndex = -1;
            EnableControl(true);
            isSave = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                return;
            }

            // checkInput
            var errors = ValiInput();
            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n",errors),"Thông báo");
                return;
            }

            var newNh = new NhanKhauDTO() {
                ID = 0,
                TenCuDan = txt_CuDan_Ten.Text,
                Cmnd_CuDan = txt_CuDan_CMND.Text,
                Sdt = txt_SDT.Text,
                GioiTinh = cb_CuDan_GioiTinh.SelectedIndex,
                NgaySinh = dtp_NgaySinh.Value.ToString(),
                MaCanHo = cb_CanHo.SelectedValue.ToString()

            };
            var oldNh = gridView1.GetFocusedRow() as NhanKhauDTO;

            // Lưu thông tin
            try
            {
                var result = NhanKhauDAO.Instance.LuuNhanKhau(newNh, oldNh);
                if (result.MessegeType == MessegeType.Success)
                {
                    LoadNhanKhau();
                    MessageBox.Show("Cập nhật thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show(result.MessegeContent, "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại : " + ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as NhanKhauDTO;
            if (row == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin trước khi thực hiện", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var isAccept = MessageBox.Show("Xác nhận cư dân hết ở.", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes;
            if (isAccept)
            {
                try
                {
                    CuDan_CanHoDAO.Instance.XoaNhanKhau(row.ID);
                    LoadNhanKhau();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra : " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void txt_CuDan_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvNhanKhau_Click_1(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as NhanKhauDTO;

            if (row == null)
            {
                return;
            }
            txt_ID.Text = row.ID.ToString();

            txt_CuDan_CMND.Text = row.Cmnd_CuDan;
            txt_CuDan_Ten.Text = row.TenCuDan;
            cb_CuDan_GioiTinh.SelectedIndex = row.GioiTinh;
            txt_SDT.Text = row.Sdt;
            dtp_NgaySinh.Text = row.NgaySinh.ToString();

            cb_CanHo.Text = row.TenCanHo;
            EnableControl(false);
            isSave = false;
        }

        private void cb_CanHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// load thông tin chủ hộ
            try
            {
                if (cb_CanHo.SelectedIndex < 0)
                {
                    return;
                }
                var chuHo = ResidentDAO.Instance.LayChuHoTheoMaCanHo(cb_CanHo.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra : " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txt_CuDan_Ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            isSave = true;
        }
    }
}
