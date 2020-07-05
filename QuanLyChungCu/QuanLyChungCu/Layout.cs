using Guna.UI2.WinForms;
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
    public partial class Layout : Form
    {
        private Guna2Button currentGunnaButton;
        private Panel currentGunnaPanel;
        public Layout()
        {
            InitializeComponent();
        }

        #region Method
        private void AddForm(Form frmCurrent)
        {
            pl_NoiDung.Controls.Clear();
            frmCurrent.TopLevel = false;
            pl_NoiDung.Controls.Add(frmCurrent);
            frmCurrent.FormBorderStyle = FormBorderStyle.None;
            frmCurrent.Dock = DockStyle.Fill;
            frmCurrent.Show();
        }

        private void ActivateButton(object sender, Panel SubMenu = null)
        {
            if (sender != null)
            {
                if (sender is Guna2Button && currentGunnaButton != (Guna2Button)sender)
                {
                    DisableButton();
                    currentGunnaButton = (Guna2Button)sender;
                    lb_TenMenu.Text = currentGunnaButton.Text.ToUpper();
                    currentGunnaButton.Checked = true;
                    currentGunnaButton.ForeColor = SystemColors.ButtonHighlight;
                    currentGunnaButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in plMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    var btnPrevious = (Guna2Button)previousBtn;
                    btnPrevious.Checked = false;
                }               
            }

            if (currentGunnaPanel != null && currentGunnaPanel.Controls.Count > 0)
            {
                foreach (Control item in currentGunnaPanel.Controls)
                {
                    if (item.GetType() == typeof(Guna2Button))
                    {
                        var btnChild = (Guna2Button)item;
                        btnChild.Checked = false;
                    }
                }
            }
        }

        private void CloseAllSubMenu()
        {
            plDanhMucSubMenu.Visible = false;
            plDichVuSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (plDanhMucSubMenu.Visible == true)
            {
                plDanhMucSubMenu.Visible = false;
            }
            if (plDichVuSubMenu.Visible == true)
            {
                plDichVuSubMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                currentGunnaPanel = subMenu;
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #endregion

        #region Event

        private void Layout_Load(object sender, EventArgs e)
        {
            CloseAllSubMenu();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Bạn có muốn Đăng xuất!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }            
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, plDanhMucSubMenu);
            ShowSubMenu(plDanhMucSubMenu);
        }

        private void btnDKyNhanKhau_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
            AddForm(new frmNhanKhau());
        }       

        private void btnToaNha_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmToaNha());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, plDichVuSubMenu);
            ShowSubMenu(plDichVuSubMenu);
        }       

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmTang());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmLoaiCanHo());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmCanHo());

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmLoaiDichVu());
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            pl_NoiDung.Controls.Clear();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmDichVu());
        }
        #endregion

    }
}
