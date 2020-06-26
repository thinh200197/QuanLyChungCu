namespace QuanLyChungCu
{
    partial class frmNhanKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhanKhau = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbCuDan = new System.Windows.Forms.GroupBox();
            this.chk_ChuHo = new System.Windows.Forms.CheckBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cb_CuDan_GioiTinh = new System.Windows.Forms.ComboBox();
            this.cb_CuDan_Ten = new System.Windows.Forms.ComboBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_CuDan_CMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cb_ChuHo_Ten = new System.Windows.Forms.ComboBox();
            this.txt_ChuHo_CMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_CanHo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbCuDan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvNhanKhau);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 262);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Nhân khẩu";
            // 
            // dgvNhanKhau
            // 
            this.dgvNhanKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanKhau.Location = new System.Drawing.Point(3, 25);
            this.dgvNhanKhau.MainView = this.gridView1;
            this.dgvNhanKhau.Name = "dgvNhanKhau";
            this.dgvNhanKhau.Size = new System.Drawing.Size(945, 234);
            this.dgvNhanKhau.TabIndex = 0;
            this.dgvNhanKhau.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.Blue;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.Lime;
            this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgvNhanKhau;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gbCuDan
            // 
            this.gbCuDan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCuDan.Controls.Add(this.cb_CanHo);
            this.gbCuDan.Controls.Add(this.label12);
            this.gbCuDan.Controls.Add(this.cb_ChuHo_Ten);
            this.gbCuDan.Controls.Add(this.txt_ChuHo_CMND);
            this.gbCuDan.Controls.Add(this.label2);
            this.gbCuDan.Controls.Add(this.label7);
            this.gbCuDan.Controls.Add(this.chk_ChuHo);
            this.gbCuDan.Controls.Add(this.dtp_NgaySinh);
            this.gbCuDan.Controls.Add(this.cb_CuDan_GioiTinh);
            this.gbCuDan.Controls.Add(this.cb_CuDan_Ten);
            this.gbCuDan.Controls.Add(this.txt_SDT);
            this.gbCuDan.Controls.Add(this.txt_CuDan_CMND);
            this.gbCuDan.Controls.Add(this.label5);
            this.gbCuDan.Controls.Add(this.label6);
            this.gbCuDan.Controls.Add(this.label3);
            this.gbCuDan.Controls.Add(this.label4);
            this.gbCuDan.Controls.Add(this.label1);
            this.gbCuDan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbCuDan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCuDan.Location = new System.Drawing.Point(12, 12);
            this.gbCuDan.Name = "gbCuDan";
            this.gbCuDan.Size = new System.Drawing.Size(577, 200);
            this.gbCuDan.TabIndex = 16;
            this.gbCuDan.TabStop = false;
            this.gbCuDan.Text = "Thông tin cư dân đăng ký";
            // 
            // chk_ChuHo
            // 
            this.chk_ChuHo.AutoSize = true;
            this.chk_ChuHo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ChuHo.Location = new System.Drawing.Point(291, 120);
            this.chk_ChuHo.Name = "chk_ChuHo";
            this.chk_ChuHo.Size = new System.Drawing.Size(68, 21);
            this.chk_ChuHo.TabIndex = 9;
            this.chk_ChuHo.Text = "Chủ hộ";
            this.chk_ChuHo.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(90, 86);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(154, 25);
            this.dtp_NgaySinh.TabIndex = 8;
            this.dtp_NgaySinh.UseWaitCursor = true;
            this.dtp_NgaySinh.Value = new System.DateTime(2020, 6, 24, 9, 51, 0, 0);
            // 
            // cb_CuDan_GioiTinh
            // 
            this.cb_CuDan_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CuDan_GioiTinh.FormattingEnabled = true;
            this.cb_CuDan_GioiTinh.Items.AddRange(new object[] {
            "NỮ",
            "NAM"});
            this.cb_CuDan_GioiTinh.Location = new System.Drawing.Point(347, 31);
            this.cb_CuDan_GioiTinh.Name = "cb_CuDan_GioiTinh";
            this.cb_CuDan_GioiTinh.Size = new System.Drawing.Size(58, 25);
            this.cb_CuDan_GioiTinh.TabIndex = 7;
            this.cb_CuDan_GioiTinh.Text = "NAM";
            // 
            // cb_CuDan_Ten
            // 
            this.cb_CuDan_Ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CuDan_Ten.FormattingEnabled = true;
            this.cb_CuDan_Ten.Location = new System.Drawing.Point(90, 59);
            this.cb_CuDan_Ten.Name = "cb_CuDan_Ten";
            this.cb_CuDan_Ten.Size = new System.Drawing.Size(154, 25);
            this.cb_CuDan_Ten.TabIndex = 7;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.Color.White;
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(90, 116);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(154, 25);
            this.txt_SDT.TabIndex = 5;
            // 
            // txt_CuDan_CMND
            // 
            this.txt_CuDan_CMND.BackColor = System.Drawing.Color.White;
            this.txt_CuDan_CMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CuDan_CMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuDan_CMND.Location = new System.Drawing.Point(90, 30);
            this.txt_CuDan_CMND.Name = "txt_CuDan_CMND";
            this.txt_CuDan_CMND.Size = new System.Drawing.Size(154, 25);
            this.txt_CuDan_CMND.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(288, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và Tên";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(12, 228);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cb_ChuHo_Ten
            // 
            this.cb_ChuHo_Ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ChuHo_Ten.FormattingEnabled = true;
            this.cb_ChuHo_Ten.Location = new System.Drawing.Point(403, 86);
            this.cb_ChuHo_Ten.Name = "cb_ChuHo_Ten";
            this.cb_ChuHo_Ten.Size = new System.Drawing.Size(154, 25);
            this.cb_ChuHo_Ten.TabIndex = 13;
            // 
            // txt_ChuHo_CMND
            // 
            this.txt_ChuHo_CMND.BackColor = System.Drawing.Color.White;
            this.txt_ChuHo_CMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ChuHo_CMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChuHo_CMND.Location = new System.Drawing.Point(403, 58);
            this.txt_ChuHo_CMND.Name = "txt_ChuHo_CMND";
            this.txt_ChuHo_CMND.Size = new System.Drawing.Size(154, 25);
            this.txt_ChuHo_CMND.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(288, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "CMND Chủ Hộ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(288, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Họ và Tên Chủ hộ";
            // 
            // cb_CanHo
            // 
            this.cb_CanHo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CanHo.FormattingEnabled = true;
            this.cb_CanHo.Location = new System.Drawing.Point(494, 31);
            this.cb_CanHo.Name = "cb_CanHo";
            this.cb_CanHo.Size = new System.Drawing.Size(63, 25);
            this.cb_CanHo.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(432, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Căn Hộ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(102, 228);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(192, 228);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Lưu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmNhanKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 528);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbCuDan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanKhau";
            this.Text = "frmNhanKhau";
            this.Load += new System.EventHandler(this.frmNhanKhau_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbCuDan.ResumeLayout(false);
            this.gbCuDan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvNhanKhau;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbCuDan;
        private System.Windows.Forms.CheckBox chk_ChuHo;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.ComboBox cb_CuDan_GioiTinh;
        private System.Windows.Forms.ComboBox cb_CuDan_Ten;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_CuDan_CMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cb_CanHo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_ChuHo_Ten;
        private System.Windows.Forms.TextBox txt_ChuHo_CMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}