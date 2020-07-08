namespace QuanLyChungCu
{
    partial class frmCanHo
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gb_CanHo = new DevExpress.XtraEditors.GroupControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gv_CanHo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cb_TenChuHo = new System.Windows.Forms.ComboBox();
            this.cb_LoaiCanHo = new System.Windows.Forms.ComboBox();
            this.cb_Tang = new System.Windows.Forms.ComboBox();
            this.cb_ToaNha = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaCanHo = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoNguoiO = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenCanHo = new DevExpress.XtraEditors.TextEdit();
            this.txt_CmndChuHo = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gb_CanHo)).BeginInit();
            this.gb_CanHo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CanHo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCanHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoNguoiO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenCanHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CmndChuHo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_CanHo
            // 
            this.gb_CanHo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_CanHo.Controls.Add(this.gridSplitContainer1);
            this.gb_CanHo.Location = new System.Drawing.Point(12, 186);
            this.gb_CanHo.Name = "gb_CanHo";
            this.gb_CanHo.Size = new System.Drawing.Size(776, 388);
            this.gb_CanHo.TabIndex = 5;
            this.gb_CanHo.Text = "Danh Sách Căn Hộ";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gv_CanHo;
            this.gridSplitContainer1.Location = new System.Drawing.Point(2, 20);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gv_CanHo);
            this.gridSplitContainer1.Size = new System.Drawing.Size(772, 366);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // gv_CanHo
            // 
            this.gv_CanHo.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gv_CanHo.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gv_CanHo.Location = new System.Drawing.Point(0, 0);
            this.gv_CanHo.MainView = this.gridView1;
            this.gv_CanHo.Name = "gv_CanHo";
            this.gv_CanHo.Size = new System.Drawing.Size(772, 366);
            this.gv_CanHo.TabIndex = 1;
            this.gv_CanHo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gv_CanHo.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gv_CanHo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Cancel;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.btnSave);
            this.groupControl3.Controls.Add(this.btnEdit);
            this.groupControl3.Controls.Add(this.btnNew);
            this.groupControl3.Controls.Add(this.cb_TenChuHo);
            this.groupControl3.Controls.Add(this.cb_LoaiCanHo);
            this.groupControl3.Controls.Add(this.cb_Tang);
            this.groupControl3.Controls.Add(this.cb_ToaNha);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Controls.Add(this.txt_MaCanHo);
            this.groupControl3.Controls.Add(this.txt_SoNguoiO);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Controls.Add(this.txt_TenCanHo);
            this.groupControl3.Controls.Add(this.txt_CmndChuHo);
            this.groupControl3.Controls.Add(this.label8);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Location = new System.Drawing.Point(12, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(776, 168);
            this.groupControl3.TabIndex = 23;
            this.groupControl3.Text = "Thông Tin Căn Hộ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(689, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(599, 127);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(509, 127);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 31);
            this.btnNew.TabIndex = 37;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cb_TenChuHo
            // 
            this.cb_TenChuHo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_TenChuHo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_TenChuHo.Enabled = false;
            this.cb_TenChuHo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenChuHo.FormattingEnabled = true;
            this.cb_TenChuHo.Location = new System.Drawing.Point(367, 29);
            this.cb_TenChuHo.Name = "cb_TenChuHo";
            this.cb_TenChuHo.Size = new System.Drawing.Size(198, 25);
            this.cb_TenChuHo.TabIndex = 33;
            this.cb_TenChuHo.SelectedIndexChanged += new System.EventHandler(this.cb_TenChuHo_SelectedIndexChanged);
            // 
            // cb_LoaiCanHo
            // 
            this.cb_LoaiCanHo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_LoaiCanHo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_LoaiCanHo.Enabled = false;
            this.cb_LoaiCanHo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiCanHo.FormattingEnabled = true;
            this.cb_LoaiCanHo.Location = new System.Drawing.Point(95, 100);
            this.cb_LoaiCanHo.Name = "cb_LoaiCanHo";
            this.cb_LoaiCanHo.Size = new System.Drawing.Size(143, 25);
            this.cb_LoaiCanHo.TabIndex = 34;
            // 
            // cb_Tang
            // 
            this.cb_Tang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Tang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Tang.Enabled = false;
            this.cb_Tang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Tang.FormattingEnabled = true;
            this.cb_Tang.Location = new System.Drawing.Point(95, 64);
            this.cb_Tang.Name = "cb_Tang";
            this.cb_Tang.Size = new System.Drawing.Size(108, 25);
            this.cb_Tang.TabIndex = 35;
            // 
            // cb_ToaNha
            // 
            this.cb_ToaNha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ToaNha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ToaNha.Enabled = false;
            this.cb_ToaNha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ToaNha.FormattingEnabled = true;
            this.cb_ToaNha.Location = new System.Drawing.Point(95, 29);
            this.cb_ToaNha.Name = "cb_ToaNha";
            this.cb_ToaNha.Size = new System.Drawing.Size(108, 25);
            this.cb_ToaNha.TabIndex = 36;
            this.cb_ToaNha.SelectedIndexChanged += new System.EventHandler(this.cb_ToaNha_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Loại Căn Hộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tầng";
            // 
            // txt_MaCanHo
            // 
            this.txt_MaCanHo.Enabled = false;
            this.txt_MaCanHo.Location = new System.Drawing.Point(367, 134);
            this.txt_MaCanHo.Name = "txt_MaCanHo";
            this.txt_MaCanHo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCanHo.Properties.Appearance.Options.UseFont = true;
            this.txt_MaCanHo.Size = new System.Drawing.Size(75, 24);
            this.txt_MaCanHo.TabIndex = 30;
            // 
            // txt_SoNguoiO
            // 
            this.txt_SoNguoiO.Enabled = false;
            this.txt_SoNguoiO.Location = new System.Drawing.Point(367, 99);
            this.txt_SoNguoiO.Name = "txt_SoNguoiO";
            this.txt_SoNguoiO.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoNguoiO.Properties.Appearance.Options.UseFont = true;
            this.txt_SoNguoiO.Size = new System.Drawing.Size(59, 24);
            this.txt_SoNguoiO.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mã Căn Hộ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Số người ở";
            // 
            // txt_TenCanHo
            // 
            this.txt_TenCanHo.Location = new System.Drawing.Point(95, 135);
            this.txt_TenCanHo.Name = "txt_TenCanHo";
            this.txt_TenCanHo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenCanHo.Properties.Appearance.Options.UseFont = true;
            this.txt_TenCanHo.Size = new System.Drawing.Size(148, 24);
            this.txt_TenCanHo.TabIndex = 31;
            // 
            // txt_CmndChuHo
            // 
            this.txt_CmndChuHo.Enabled = false;
            this.txt_CmndChuHo.Location = new System.Drawing.Point(367, 64);
            this.txt_CmndChuHo.Name = "txt_CmndChuHo";
            this.txt_CmndChuHo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CmndChuHo.Properties.Appearance.Options.UseFont = true;
            this.txt_CmndChuHo.Size = new System.Drawing.Size(148, 24);
            this.txt_CmndChuHo.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tên Căn Hộ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tên Chủ Hộ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tòa Nhà";
            // 
            // frmCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.gb_CanHo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCanHo";
            this.Text = "frmCanHo";
            this.Load += new System.EventHandler(this.frmCanHo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb_CanHo)).EndInit();
            this.gb_CanHo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CanHo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCanHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoNguoiO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenCanHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CmndChuHo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl gb_CanHo;
        private DevExpress.XtraGrid.GridControl gv_CanHo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cb_TenChuHo;
        private System.Windows.Forms.ComboBox cb_LoaiCanHo;
        private System.Windows.Forms.ComboBox cb_Tang;
        private System.Windows.Forms.ComboBox cb_ToaNha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_SoNguoiO;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_TenCanHo;
        private DevExpress.XtraEditors.TextEdit txt_CmndChuHo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.TextEdit txt_MaCanHo;
        private System.Windows.Forms.Label label4;
    }
}