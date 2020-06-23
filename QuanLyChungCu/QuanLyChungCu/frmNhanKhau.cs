using QuanLyChungCu.DAO;
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
    public partial class frmNhanKhau : Form
    {
        public frmNhanKhau()
        {
            InitializeComponent();
        }

        private void frmNhanKhau_Load(object sender, EventArgs e)
        {
            var data = NhanKhauDAO.Instance.DanhSachNhanKhau();
            dgvNhanKhau.DataSource = data;
        }
    }
}
