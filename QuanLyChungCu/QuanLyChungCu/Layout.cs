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
        private Guna2Panel currentGunnaPanel;
        public Layout()
        {
            InitializeComponent();
        }

        #region Event
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ShowSubMenu(plDanhMucSubMenu);
        }

        private void btnDKyNhanKhau_Click(object sender, EventArgs e)
        {
            CloseAllSubMenu();
            ActivateButton(sender);
            AddForm(new frmNhanKhau());
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            CloseAllSubMenu();
        }

        private void btnToaNha_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmDanhMuc());
        }
        #endregion

        #region Method
        private void AddForm(Form frmCurrent)
        {
            plNoiDung.Controls.Clear();
            frmCurrent.TopLevel = false;
            plNoiDung.Controls.Add(frmCurrent);
            frmCurrent.FormBorderStyle = FormBorderStyle.None;
            frmCurrent.Dock = DockStyle.Fill;
            frmCurrent.Show();
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {

                if (sender is Guna2Button && currentGunnaButton != (Guna2Button)sender)
                {
       
                    DisableButton();
                    currentGunnaButton = (Guna2Button)sender;
                    lbTenMenu.Text = currentGunnaButton.Text.ToUpper();
                    lbLink.Text = "";
                    currentGunnaButton.Checked = true;
                    currentGunnaButton.ForeColor = SystemColors.ButtonHighlight;
                    currentGunnaButton.Font = new Font("RobotoMono-Regular", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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
                if (previousBtn.GetType() == typeof(Guna2Panel))
                {
                    var panel = (Guna2Panel)previousBtn;
                    foreach (Control item in panel.Controls)
                    {
                        if (item.GetType() == typeof(Guna2Button))
                        {
                            var btnChild = (Guna2Button)item;
                            btnChild.Checked = false;
                        }
                    }                    
                }
            }
        }

        private void CloseAllSubMenu()
        {
            plDanhMucSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (plDanhMucSubMenu.Visible == true)
            {
                plDanhMucSubMenu.Visible = false;
            }            
        }

        private void ShowSubMenu(Guna2Panel subMenu)
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


    }
}
