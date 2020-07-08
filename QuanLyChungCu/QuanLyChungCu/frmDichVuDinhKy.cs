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
        }

        private List<string> valiInput()
        {
            var erros = new List<string>();
            if (cb_CanHo.SelectedIndex < 0)
            {
                erros.Add("Chọn Căn hộ");
            }
            if (cb_DichVu.SelectedIndex < 0)
            {
                erros.Add("Chọn Dịch vụ");
            }
            return erros;
        }
        #endregion

        #region Event

        #endregion

        private void frmDichVuDinhKy_Load(object sender, EventArgs e)
        {
            LoadData();

            var canHo = ApartmentDAO.Instance.GetAll();
            var dichVu = ServiceDAO.Instance.GetAll();

            cb_CanHo.DataSource = canHo;
            cb_CanHo.DisplayMember = "TenCanHo";
            cb_CanHo.ValueMember = "MaCanHo";

            cb_DichVu.DataSource = dichVu;
            cb_DichVu.DisplayMember = "TenDichVu";
            cb_DichVu.ValueMember = "MaDichVu";
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            var erros = valiInput();
            if (erros.Any())
            {
                MessageBox.Show(string.Join("\n",erros), "Thông báo");
                return;
            }

            var dv = new DKDV_DinhKyDTO() {
                MaCanHo = int.Parse(cb_CanHo.SelectedValue.ToString()),
                MaDichVu = int.Parse(cb_DichVu.SelectedValue.ToString()),
                TrangThai = cb_TT.SelectedText,
                CREATE_BY = 0
            };

            try
            {
                var result = ServiceDAO.Instance.Add_DVDK(dv);

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
    }
}
