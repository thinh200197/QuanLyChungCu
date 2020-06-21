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
        public Layout()
        {
            InitializeComponent();
        }

        #region Event
        private void button5_Click(object sender, EventArgs e)
        {
            AddForm(new frmDanhMuc());
        }

        private void ActivateButton(object sender, EventArgs e)
        {
            Checked(sender);
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

        private void Checked(object btnSender)
        {
            if (btnSender != null)
            {

                if (currentGunnaButton != (Guna2Button)btnSender)
                {
                    DisableButton();
                    currentGunnaButton = (Guna2Button)btnSender;
                    lbTenMenu.Text = currentGunnaButton.Text.ToUpper();
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
                //hideSubMenu();
            }
        }

        #endregion

    }
}
