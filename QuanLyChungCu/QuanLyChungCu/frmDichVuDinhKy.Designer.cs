namespace QuanLyChungCu
{
    partial class frmDichVuDinhKy
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gv_Data = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.cb_TT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_DichVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_CanHo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gv_Data);
            this.groupControl1.Location = new System.Drawing.Point(14, 168);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(957, 404);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách đăng ký";
            // 
            // gv_Data
            // 
            this.gv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Data.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gv_Data.Location = new System.Drawing.Point(2, 20);
            this.gv_Data.MainView = this.gridView1;
            this.gv_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gv_Data.Name = "gv_Data";
            this.gv_Data.Size = new System.Drawing.Size(953, 382);
            this.gv_Data.TabIndex = 0;
            this.gv_Data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gv_Data;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btn_CapNhat);
            this.groupControl2.Controls.Add(this.btn_InHD);
            this.groupControl2.Controls.Add(this.btn_DangKy);
            this.groupControl2.Controls.Add(this.cb_TT);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.cb_DichVu);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.cb_CanHo);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(14, 16);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(957, 144);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin đăng ký";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Location = new System.Drawing.Point(824, 103);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(117, 35);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "CẬP NHẬT";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // btn_InHD
            // 
            this.btn_InHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.Location = new System.Drawing.Point(695, 103);
            this.btn_InHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(117, 35);
            this.btn_InHD.TabIndex = 2;
            this.btn_InHD.Text = "IN HÓA ĐƠN";
            this.btn_InHD.UseVisualStyleBackColor = true;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DangKy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.Location = new System.Drawing.Point(566, 103);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(117, 35);
            this.btn_DangKy.TabIndex = 2;
            this.btn_DangKy.Text = "ĐĂNG KÝ";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // cb_TT
            // 
            this.cb_TT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TT.FormattingEnabled = true;
            this.cb_TT.Items.AddRange(new object[] {
            "Chưa kích hoạt",
            "Kích hoạt",
            "Hủy đăng ký"});
            this.cb_TT.Location = new System.Drawing.Point(429, 61);
            this.cb_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_TT.Name = "cb_TT";
            this.cb_TT.Size = new System.Drawing.Size(140, 25);
            this.cb_TT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRẠNG THÁI";
            // 
            // cb_DichVu
            // 
            this.cb_DichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DichVu.FormattingEnabled = true;
            this.cb_DichVu.Items.AddRange(new object[] {
            "Chưa kích hoạt",
            "Kích hoạt",
            "Hủy đăng ký"});
            this.cb_DichVu.Location = new System.Drawing.Point(183, 61);
            this.cb_DichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_DichVu.Name = "cb_DichVu";
            this.cb_DichVu.Size = new System.Drawing.Size(217, 25);
            this.cb_DichVu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "DỊCH VỤ";
            // 
            // cb_CanHo
            // 
            this.cb_CanHo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CanHo.FormattingEnabled = true;
            this.cb_CanHo.Location = new System.Drawing.Point(14, 61);
            this.cb_CanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_CanHo.Name = "cb_CanHo";
            this.cb_CanHo.Size = new System.Drawing.Size(140, 25);
            this.cb_CanHo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CĂN HỘ";
            // 
            // frmDichVuDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 588);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDichVuDinhKy";
            this.Text = "frmDichVuDinhKy";
            this.Load += new System.EventHandler(this.frmDichVuDinhKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gv_Data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ComboBox cb_CanHo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.ComboBox cb_TT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_DichVu;
        private System.Windows.Forms.Label label2;
    }
}