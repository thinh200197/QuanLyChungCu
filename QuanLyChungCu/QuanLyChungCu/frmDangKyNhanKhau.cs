using ApartmentManager.DAO;
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
    public partial class frmDangKyNhanKhau : Form
    {
        public frmDangKyNhanKhau()
        {
            InitializeComponent();
        }

        #region Method

        private void LoadComboboxCuDan()
        {
            var dataCuDan = ResidentDAO.Instance.GetAllResident();
            var dataChuHo = ResidentDAO.Instance.GetAllResident();
            cb_CuDan.DataSource = dataCuDan;
            cb_CuDan.DisplayMember = "TENCUDAN";
            cb_CuDan.ValueMember = "MACUDAN";
            cb_CuDan.SelectedIndex = -1;

            cb_ChuHo.DataSource = dataChuHo;
            cb_ChuHo.DisplayMember = "TENCUDAN";
            cb_ChuHo.ValueMember = "MACUDAN";
            cb_ChuHo.SelectedIndex = -1;

            cb_CuDan_GioiTinh.SelectedItem = 0;


        }
        #endregion

        #region Event

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemCuDan_Click(object sender, EventArgs e)
        {
            var frm = new frmCuDan();
            frm.ShowDialog();
            LoadComboboxCuDan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // thực hiện lưu thông tin
            this.Hide();           
        }

        private void frmDangKyNhanKhau_Load(object sender, EventArgs e)
        {
            LoadComboboxCuDan();
        }
        #endregion

        private void cb_CuDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cb_CuDan.SelectedItem;
            cb_CuDan_GioiTinh.SelectedItem = 0;

        }
    }
}
