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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txt_TaiKhoan.Text;
            var password = txt_MatKhau.Text;
            var login = AccountDAO.Instance.Login(username, password);
            if (login)
            {
                this.Hide();
                var frm = new Layout();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
