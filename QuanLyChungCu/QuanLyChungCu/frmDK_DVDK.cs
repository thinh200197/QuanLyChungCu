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
    public partial class frmDK_DVDK : Form
    {
        public int id;
        public string maDichVu;
        public string maCanHo;
        public string trangThai;
        public frmDK_DVDK()
        {
            InitializeComponent();
        }

        #region Method
        private List<string> ValidateInput()
        {
            var erros = new List<string>();

            if (cb_CanHo.SelectedIndex < 0)
            {
                erros.Add("Nhập căn hộ");
            }
            if (cb_DichVu.SelectedIndex < 0)
            {
                erros.Add("Nhập dịch vụ");
            }
            if (cb_TT.SelectedIndex < 0)
            {
                erros.Add("Nhập trạng thái");
            }
            return erros;
        }

        public void SetUpdateValue()
        {
            cb_CanHo.SelectedIndex = -1;
            cb_TT.SelectedIndex = -1;
            cb_DichVu.SelectedIndex = -1;

            if (id > 0)
            {
                numID.Value = id;
            }

            if (!string.IsNullOrEmpty(maDichVu))
            {
                cb_DichVu.SelectedValue = maDichVu;
            }

            if (!string.IsNullOrEmpty(maCanHo))
            {
                cb_CanHo.SelectedValue = maCanHo;
            }

            if (!string.IsNullOrEmpty(trangThai))
            {
                cb_TT.SelectedValue = Common.ServiceStatus.GetNameByValue(trangThai);
            }
        }
        #endregion

        #region Event
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var errors = ValidateInput();
            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Thông báo");
                return;
            }

            var maCanHo = cb_CanHo.SelectedValue.ToString();
            var maDichVu = cb_DichVu.SelectedValue.ToString();
            var trangThai = cb_TT.SelectedValue.ToString();

            var dv = new DKDV_DinhKyDTO()
            {
                ID = id,
                MaCanHo = maCanHo,
                MaDichVu = maDichVu,
                TrangThai = trangThai,
                NGUOITAO = 0,
                NGAYTAO = DateTime.Now,
                NGUOICAPNHAT = 0,
                NGAYCAPNHAT = DateTime.Now
            };

            var result = new Messeges();
            if (id > 0)
            {
                result = ServiceDAO.Instance.Update_DVDK(dv);
            }
            else
            {
                result = ServiceDAO.Instance.Add_DVDK(dv);
            }

            if (result.MessegeType == MessegeType.Error)
            {
                MessageBox.Show(result.MessegeContent, "Thông báo");
            }
            else
            {
                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmDK_DVDK_Load(object sender, EventArgs e)
        {
            var canHo = ApartmentDAO.Instance.GetAll();
            var dichVu = ServiceDAO.Instance.GetAll_DVDK();
            var lstTT = new Dictionary<string, string>();
            lstTT.Add(nameof(Common.ServiceStatus.Cancel), Common.ServiceStatus.Cancel);
            lstTT.Add(nameof(Common.ServiceStatus.Active), Common.ServiceStatus.Active);
            lstTT.Add(nameof(Common.ServiceStatus.Inactive), Common.ServiceStatus.Inactive);

            cb_TT.DataSource = lstTT.ToList();
            cb_TT.ValueMember = "Key";
            cb_TT.DisplayMember = "Value";

            cb_CanHo.DataSource = canHo;
            cb_CanHo.DisplayMember = "TenCanHo";
            cb_CanHo.ValueMember = "MaCanHo";

            cb_DichVu.DataSource = dichVu;
            cb_DichVu.DisplayMember = "TENDICHVU";
            cb_DichVu.ValueMember = "MADICHVU";

            SetUpdateValue();
        }
        #endregion

    }
}
