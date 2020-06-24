using QuanLyChungCu.DAO;
using System;
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
            LoadNhanKhau();
        }

        private void LoadNhanKhau()
        {
            var data = NhanKhauDAO.Instance.DanhSachNhanKhau();
            dgvNhanKhau.DataSource = data;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var frm = new frmDangKyNhanKhau();
            frm.ShowDialog();
            LoadNhanKhau();
        }
    }
}
