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
    public partial class frmToaNha : Form
    {
        bool isSave = false;
        public frmToaNha()
        {
            InitializeComponent();
        }

        #region Method
        private void LoadGrid()
        {
            var data = BlockDAO.Instance.GetAll();
            gv_ToaNha.DataSource = data;
        }

        private void ResetGroup()
        {
            txt_MaToaNha.Text = string.Empty;
            txt_TenToaNha.Text = string.Empty;
        }

        private void EnableControl(bool enable)
        {
            txt_MaToaNha.Enabled = enable;
            txt_TenToaNha.Enabled = enable;
        }
        #endregion

        #region Event
        private void gv_ToaNha_Click(object sender, EventArgs e)
        {
            var block = gridView1.GetFocusedRow() as BlockDTO;
            EnableControl(false);
            if (block == null) return;
            txt_MaToaNha.Text = block.MaBlock;
            txt_TenToaNha.Text = block.TenBlock;
        }

        #endregion

        private void frmToaNha_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isSave = true;
            //EnableControl(true);
            txt_TenToaNha.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isSave = true;
            EnableControl(true);
            ResetGroup();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isSave)
                {
                    return;
                }

                if (string.IsNullOrEmpty(txt_TenToaNha.Text.Trim()))
                {
                    MessageBox.Show("Nhập Tên Tòa Nhà", "Thông báo");
                    return;
                }
                var maToaNha = txt_MaToaNha.Text;
                var tenToaNha = txt_TenToaNha.Text;

                var tn = new BlockDTO()
                {
                    MaBlock = maToaNha,
                    TenBlock = tenToaNha
                };

                Messeges result;

                var isUpdate = BlockDAO.Instance.GetBlockById(maToaNha);

                if (isUpdate.MaBlock != null)
                {
                    result = BlockDAO.Instance.Update(tn);
                }
                else
                {
                    result = BlockDAO.Instance.Add(tn);
                }

                if (result.MessegeType == MessegeType.Success)
                {
                    LoadGrid();
                }

                MessageBox.Show(result.MessegeContent, "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
