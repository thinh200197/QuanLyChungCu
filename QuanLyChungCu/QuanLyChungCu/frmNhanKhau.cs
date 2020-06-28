using QuanLyChungCu.DAO;
using QuanLyChungCu.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class frmNhanKhau : Form
    {
        public frmNhanKhau()
        {
            InitializeComponent();
        }

        private void frmNhanKhau_Load(object sender, EventArgs e)
        {
            // Thông tin chủ hộ
            cb_ChuHo_Ten.DataSource = ResidentDAO.Instance.GetAllResident();
            cb_ChuHo_Ten.DisplayMember = "TENCUDAN";
            cb_ChuHo_Ten.ValueMember = "MACUDAN";
            cb_ChuHo_Ten.SelectedIndex = -1;

            //Thông tin căn hộ
            cb_CanHo.DataSource = ApartmentDAO.Instance.GetAllApartment();
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

            txt_ChuHo_CMND.Text = string.Empty;
            cb_ChuHo_Ten.SelectedItem = -1;

            cb_CanHo.SelectedItem = -1;

            chk_ChuHo.Checked = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var isChuHo = chk_ChuHo.Checked;

            var cuDan = new ResidentDTO()
            {
                TenCuDan = txt_CuDan_Ten.Text,
                Cmnd = txt_CuDan_CMND.Text,
                Sdt = txt_SDT.Text,
                GioiTinh = cb_CuDan_GioiTinh.SelectedIndex,
                NgaySinh = dtp_NgaySinh.Value,
            };

            var canHo = cb_CanHo.SelectedValue.ToString();

            var chuHo = cb_CanHo.SelectedItem as ResidentDTO;

            if (isChuHo)
            {
                chuHo = cuDan;
            }

            // Lưu thông tin
            try
            {
                var them = NhanKhauDAO.Instance.ThemNhanKhau(cuDan, canHo, chuHo);
                if (them)
                {
                    LoadNhanKhau();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại : " + ex.Message);
            }
        }

        private void chk_ChuHo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ChuHo.Checked)
            {
                txt_ChuHo_CMND.Enabled = false;
                cb_ChuHo_Ten.Enabled = false;
            }
            else
            {
                txt_ChuHo_CMND.Enabled = true;
                cb_ChuHo_Ten.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var isAccept = MessageBox.Show("Bạn có muốn xóa nhân khẩu này ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes;
            if (isAccept)
            {
                var row = gridView1.GetFocusedRow() as NhanKhauDTO;
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

            txt_CuDan_CMND.Text = row.Cmnd_CuDan;
            txt_CuDan_Ten.Text = row.TenCuDan;
            cb_CuDan_GioiTinh.SelectedIndex = row.GioiTinh == "Nam" ? 1 : 0;
            txt_SDT.Text = row.Sdt;
            dtp_NgaySinh.Text = row.NgaySinh.ToString();

            cb_CanHo.Text = row.TenCanHo;

            cb_ChuHo_Ten.Text = row.ChuHo;
            txt_ChuHo_CMND.Text = row.Cmnd_ChuHo;
        }


        private void txt_ChuHo_CMND_Leave(object sender, EventArgs e)
        {
            var data = cb_ChuHo_Ten.Items;
            foreach (var item in data)
            {
                var cuDan = item as ResidentDTO;
                if (cuDan.Cmnd == txt_ChuHo_CMND.Text)
                {
                    cb_ChuHo_Ten.SelectedValue = cuDan.MaCuDan;
                    return;
                }
            }
        }
    }
}
