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
    public partial class frmDichVuDinhKy : Form
    {
        public frmDichVuDinhKy()
        {
            InitializeComponent();
        }
        #region Method
        private void LoadData()
        {
            var data = ServiceDAO.Instance.GetAll_DinhKy();
            gv_Data.DataSource = data;
            gridView1.Columns["MaDichVu"].Visible = false;
            gridView1.Columns["MaCanHo"].Visible = false;
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["NGUOITAO"].Visible = false;
            gridView1.Columns["NGAYCAPNHAT"].Visible = false;
            gridView1.Columns["NGUOICAPNHAT"].Visible = false;
        }
        #endregion

        #region Event
        private void frmDichVuDinhKy_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var frm = new frmDK_DVDK();
            var a = frm.ShowDialog();
            if (a == DialogResult.OK)
            {
                MessageBox.Show("Đăng ký thành công.");
                LoadData();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as DKDV_DinhKyDTO;
            if (row == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần cập nhật.");
                return;
            }
            var frm = new frmDK_DVDK();
            frm.id = row.ID;
            frm.maCanHo = row.MaCanHo;
            frm.maDichVu = row.MaDichVu;
            frm.trangThai = row.TrangThai;
            var a = frm.ShowDialog();
            if (a == DialogResult.OK)
            {
                MessageBox.Show("Cập nhật thành công.");
                LoadData();
            }
        }
        #endregion
    }
}
