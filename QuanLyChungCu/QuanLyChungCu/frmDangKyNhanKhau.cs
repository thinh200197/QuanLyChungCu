using ApartmentManager.DAO;
using ApartmentManager.DTO;
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

            //Thông tin cư dân
            cb_CuDan.DataSource = dataCuDan;
            cb_CuDan.DisplayMember = "TENCUDAN";
            cb_CuDan.ValueMember = "MACUDAN";
            cb_CuDan.SelectedItem = null;
            cb_CuDan.SelectedIndex = -1;


            // Thông tin chủ hộ
            cb_ChuHo.DataSource = dataChuHo;
            cb_ChuHo.DisplayMember = "TENCUDAN";
            cb_ChuHo.ValueMember = "MACUDAN";
            cb_ChuHo.SelectedIndex = -1;
            cb_ChuHo.SelectedItem = null;

            var block = BlockDAO.Instance.GetAllBlock();
            //Thông tin căn hộ
            cb_CanHo_ToaNha.DataSource = block;
            cb_CanHo_ToaNha.DisplayMember = "MABLOCK";
            cb_CanHo_ToaNha.ValueMember = "TENBLOCK";
            cb_CanHo_ToaNha.SelectedIndex = -1;
            cb_CanHo_ToaNha.SelectedItem = null;
        }
        #endregion

        #region Event

        #region Thông tin cư dân
        private void cb_CuDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cb_CuDan.SelectedItem as ResidentDTO;
            if (selected == null)
            {
                cb_CuDan_GioiTinh.SelectedIndex = -1;
                txt_CuDan_CMND.Text = string.Empty;
                txt_CuDan_SDT.Text = string.Empty;
                dtp_CuDan_NgaySinh.Value = DateTime.Now;
            }
            else
            {
                cb_CuDan_GioiTinh.SelectedIndex = selected.GioiTinh;
                txt_CuDan_CMND.Text = selected.Cmnd;
                txt_CuDan_SDT.Text = selected.Sdt;
                dtp_CuDan_NgaySinh.Value = selected.NgaySinh;
            }

        }

        private void chk_CuDan_ChuHo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_CuDan_ChuHo.Checked)
            {
                gbChuHo.Enabled = false;
            }
            else
            {
                gbChuHo.Enabled = true;
            }
        }

        private void txt_CuDan_CMND_Leave(object sender, EventArgs e)
        {

        }
        #endregion

        #region Thông tin chủ hộ

        private void cb_ChuHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cb_ChuHo.SelectedItem as ResidentDTO;
            if (selected == null)
            {
                cb_ChuHo_GioiTinh.SelectedIndex = -1;
                txt_ChuHo_CMND.Text = string.Empty;
                txt_ChuHo_SDT.Text = string.Empty;
                dtp_ChuHo_NgaySinh.Value = DateTime.Now;
            }
            else
            {
                cb_ChuHo_GioiTinh.SelectedIndex = selected.GioiTinh;
                txt_ChuHo_CMND.Text = selected.Cmnd;
                txt_ChuHo_SDT.Text = selected.Sdt;
                dtp_ChuHo_NgaySinh.Value = selected.NgaySinh;
            }
        }

        #endregion

        #region Thông tin căn hộ

        private void cb_CanHo_ToaNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cb_CanHo_ToaNha.SelectedItem as BlockDTO;
            if (selected == null)
            {
                return;
            }
            else
            {
                cb_CanHo_Tang.DataSource = FloorDAO.Instance.GetAllFloorByMaBlock(selected.MaBlock);
                cb_CanHo_Tang.DisplayMember = "TENTANGLAU";
                cb_CanHo_Tang.ValueMember = "MATANGLAU";
            }

        }

        private void cb_CanHo_Tang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selected = cb_CanHo_Tang.SelectedItem as FloorDTO;
            //if (selected == null)
            //{
            //    return;
            //}

            cb_CanHo_LoaiCanHo.DataSource = ApartmentCategogyDAO.Instance.GetAllApartmentCategogy();
            cb_CanHo_LoaiCanHo.DisplayMember = "TENLOAI_CH";
            cb_CanHo_LoaiCanHo.ValueMember = "MALOAI_CH";
            cb_CanHo_LoaiCanHo.SelectedIndex = -1;

        }

        private void cb_CanHo_LoaiCanHo_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selected = cb_CanHo_LoaiCanHo.SelectedItem as ApartmentCategogyDTO;
            if (selected == null)
            {
                return;
            }
            //cb_CanHo_CanHo.DataSource = ApartmentDAO.Instance.GetAllApartmentByLoaiCanHo(selected.Maloai_CH);
            cb_CanHo_CanHo.DataSource = ApartmentDAO.Instance.GetAllApartment();
            cb_CanHo_CanHo.DisplayMember = "TENCANHO";
            cb_CanHo_CanHo.ValueMember = "MACANHO";

            var loaiCanHo = cb_CanHo_LoaiCanHo.SelectedItem as ApartmentCategogyDTO;
            if (loaiCanHo != null)
            {
                txt_CanHo_NgToiDa.Text = loaiCanHo.SoNguoiToiDa.ToString();

            }
        }

        private void cb_CanHo_CanHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var canHo = cb_CanHo_CanHo.SelectedItem as ApartmentDTO;
            if (canHo != null)
            {
                txt_CanHo_NgDangO.Text = canHo.SoNguoiO.ToString();
            }
        }
        #endregion


        private void btnLuu_Click(object sender, EventArgs e)
        {
            var cuDan = new ResidentDTO()
            {
                TenCuDan = cb_CuDan.Text,
                NgaySinh = dtp_CuDan_NgaySinh.Value,
                Cmnd = txt_CuDan_CMND.Text,
                Sdt = txt_CuDan_SDT.Text,
                GioiTinh = cb_CuDan_GioiTinh.SelectedIndex
            };

            var cbChuHo = cb_ChuHo.SelectedItem as ResidentDTO;

            var canHo = new ApartmentDTO()
            {
                MaCanHo = cb_CanHo_CanHo.SelectedValue.ToString()
            };


            var them = NhanKhauDAO.Instance.ThemNhanKhau(cuDan, canHo, cbChuHo);
            if (them)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            this.Hide();

            // thực hiện lưu thông tin

        }

        private void frmDangKyNhanKhau_Load(object sender, EventArgs e)
        {
            LoadComboboxCuDan();
        }






        #endregion


    }
}
