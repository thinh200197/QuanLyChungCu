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

            //Thông tin căn hộ
            var data = ApartmentDAO.Instance.GetAllApartment();
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

            txt_ChuHo_CMND.Text = string.Empty;
            txt_ChuHo_Ten.Text = string.Empty;

            cb_CanHo.SelectedItem = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            var cuDan = new ResidentDTO()
            {
                TenCuDan = txt_CuDan_Ten.Text,
                Cmnd = txt_CuDan_CMND.Text,
                Sdt = txt_SDT.Text,
                GioiTinh = cb_CuDan_GioiTinh.SelectedIndex,
                NgaySinh = dtp_NgaySinh.Value,
            };

            var canHo = cb_CanHo.SelectedValue.ToString();

            // Lưu thông tin
            try
            {
                int id = string.IsNullOrEmpty(txt_ID.Text) ? 0 : int.Parse(txt_ID.Text);
                var resulf = NhanKhauDAO.Instance.ThemNhanKhau(id, cuDan, canHo);
                if (resulf.MessegeType == MessegeType.Success)
                {
                    LoadNhanKhau();
                    MessageBox.Show("Cập nhật thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại : " + ex.Message, "Thông báo");
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

            if (row == null)
            {
                return;
            }
            txt_ID.Text = row.ID.ToString();

            txt_CuDan_CMND.Text = row.Cmnd_CuDan;
            txt_CuDan_Ten.Text = row.TenCuDan;
            cb_CuDan_GioiTinh.SelectedIndex = row.GioiTinh == "Nam" ? 1 : 0;
            txt_SDT.Text = row.Sdt;
            dtp_NgaySinh.Text = row.NgaySinh.ToString();

            cb_CanHo.Text = row.TenCanHo;

            txt_ChuHo_Ten.Text = row.ChuHo;
            txt_ChuHo_CMND.Text = row.Cmnd_ChuHo;
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
                txt_ChuHo_CMND.Text = chuHo.Cmnd;
                txt_ChuHo_Ten.Text = chuHo.TenCuDan;
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
    }
}
