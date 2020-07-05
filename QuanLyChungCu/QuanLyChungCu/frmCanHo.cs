using QuanLyChungCu.DAO;
using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class frmCanHo : Form
    {
        private bool isSave = false;
        public frmCanHo()
        {
            InitializeComponent();
        }

        #region Method
        private List<string> ValidateInput()
        {
            var error = new List<string>();

            if (cb_Tang.SelectedIndex < 0 )
            {
                error.Add("Nhập Tầng");
            }

            if (cb_LoaiCanHo.SelectedIndex < 0)
            {
                error.Add("Nhập Loại căn hộ");
            }

            if (string.IsNullOrEmpty(txt_TenCanHo.Text))
            {
                error.Add("Nhập Tên căn hộ");
            }
            
            return error;
        }
        private void ResetGroup()
        {
            cb_ToaNha.SelectedItem = -1;
            cb_Tang.SelectedItem = -1;
            cb_LoaiCanHo.SelectedIndex = -1;
            txt_TenCanHo.Text = string.Empty;
            txt_SoNguoiO.Text = string.Empty;
            txt_CmndChuHo.Text = string.Empty;
            cb_TenChuHo.SelectedItem = -1;
        }

        private void LoadGrid()
        {
            var data = ApartmentDAO.Instance.GetAll();
            gv_CanHo.DataSource = data;
            gridView1.Columns["MaBlock"].Visible = false;
            gridView1.Columns["MaLoaiCanHo"].Visible = false;
            gridView1.Columns["MaTangLau"].Visible = false;
            gridView1.Columns["ChuHo"].Visible = false;
        }
        private void EnableButton(bool enable)
        {
            cb_LoaiCanHo.Enabled = enable;
            cb_Tang.Enabled = enable;
            cb_ToaNha.Enabled = enable;
            txt_TenCanHo.Enabled = enable;
            cb_TenChuHo.Enabled = enable;
            txt_MaCanHo.Enabled = enable;
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            isSave = true;
            EnableButton(true);
        }
        #endregion

        #region Event

        private void btnThem_Click(object sender, EventArgs e)
        {
            isSave = true;
            ResetGroup();
        }

        private void frmCanHo_Load(object sender, EventArgs e)
        {
            var chuHo = ResidentDAO.Instance.GetAllResident();
            cb_TenChuHo.DataSource = chuHo;
            cb_TenChuHo.ValueMember = "MACUDAN";
            cb_TenChuHo.DisplayMember = "TENCUDAN";

            var loaiCanHo = ApartmentCategogyDAO.Instance.GetAllApartmentCategogy();
            cb_LoaiCanHo.DataSource = loaiCanHo;
            cb_LoaiCanHo.ValueMember = "MALOAI_CH";
            cb_LoaiCanHo.DisplayMember = "TENLOAI_CH";

            var toaNha = BlockDAO.Instance.GetAll();
            cb_ToaNha.DataSource = toaNha;
            cb_ToaNha.ValueMember = "MABLOCK";
            cb_ToaNha.DisplayMember = "TENBLOCK";

            LoadGrid();
        }

        private void cb_TenChuHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = cb_TenChuHo.SelectedItem as ResidentDTO;
            if (row != null)
            {
                txt_CmndChuHo.Text = row.Cmnd;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as ApartmentDTO;
            if (row == null)
            {
                return;
            }
            cb_ToaNha.SelectedValue = row.MaBlock;
            cb_Tang.SelectedValue = row.MaTangLau;
            cb_LoaiCanHo.SelectedValue = row.MaLoaiCanHo;
            txt_TenCanHo.Text = row.TenCanHo;
            txt_SoNguoiO.Text = row.SoNguoiO.ToString();
            cb_TenChuHo.SelectedValue = row.ChuHo;
            //txt_CmndChuHo.Text = row.CmndChuHo;
            txt_MaCanHo.Text = row.MaCanHo;
        }

        private void cb_ToaNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var block = cb_ToaNha.SelectedValue;

            if (string.IsNullOrEmpty(block.ToString()))
            {
                return;
            }

            var tang = FloorDAO.Instance.GetAllFloorByMaBlock(block.ToString());
            cb_Tang.DataSource = tang;
            cb_Tang.ValueMember = "MaTangLau";
            cb_Tang.DisplayMember = "TenTangLau";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                return;
            }

            var error = ValidateInput();

            if (error.Any())
            {
                MessageBox.Show(string.Join(",",error));
                return;
            }

            var id = txt_MaCanHo.Text;
            var ch = new ApartmentDTO();
            var result = new Messeges();
            ch.MaLoaiCanHo = cb_LoaiCanHo.SelectedValue.ToString();
            ch.MaTangLau = cb_Tang.SelectedValue.ToString();
            ch.TenCanHo = txt_TenCanHo.Text;
            ch.SoNguoiO = 0;
            ch.ChuHo = int.Parse(cb_TenChuHo.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(id))
            {
                var row = gridView1.GetFocusedRow() as ApartmentDTO;
                ch.MaCanHo = row.MaCanHo;
                result = ApartmentDAO.Instance.Update(ch);
            }
            else
            {
                
                result = ApartmentDAO.Instance.Add(ch);
            }

            MessageBox.Show(result.MessegeContent, "Thông báo");

            if (result.MessegeType == MessegeType.Success)
            {
                LoadGrid();
                isSave = false;
                EnableButton(false);
            }

            //EnableButton(false);
        }

        #endregion
       
    }
}
