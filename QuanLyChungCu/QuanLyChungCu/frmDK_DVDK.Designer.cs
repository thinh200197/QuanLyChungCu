namespace QuanLyChungCu
{
    partial class frmDK_DVDK
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
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.cb_TT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_DichVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_CanHo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.SuspendLayout();
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(54, 132);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(49, 20);
            this.numID.TabIndex = 15;
            this.numID.Visible = false;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(65, 159);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(239, 41);
            this.btn_CapNhat.TabIndex = 12;
            this.btn_CapNhat.Text = "LƯU THÔNG TIN";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // cb_TT
            // 
            this.cb_TT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_TT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TT.FormattingEnabled = true;
            this.cb_TT.Location = new System.Drawing.Point(130, 98);
            this.cb_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_TT.Name = "cb_TT";
            this.cb_TT.Size = new System.Drawing.Size(185, 25);
            this.cb_TT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "TRẠNG THÁI";
            // 
            // cb_DichVu
            // 
            this.cb_DichVu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_DichVu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_DichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DichVu.FormattingEnabled = true;
            this.cb_DichVu.Location = new System.Drawing.Point(130, 61);
            this.cb_DichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_DichVu.Name = "cb_DichVu";
            this.cb_DichVu.Size = new System.Drawing.Size(185, 25);
            this.cb_DichVu.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DỊCH VỤ";
            // 
            // cb_CanHo
            // 
            this.cb_CanHo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_CanHo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_CanHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CanHo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CanHo.FormattingEnabled = true;
            this.cb_CanHo.Location = new System.Drawing.Point(130, 24);
            this.cb_CanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_CanHo.Name = "cb_CanHo";
            this.cb_CanHo.Size = new System.Drawing.Size(185, 25);
            this.cb_CanHo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "CĂN HỘ";
            // 
            // frmDK_DVDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 216);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.cb_TT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_DichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_CanHo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmDK_DVDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDK_DVDK";
            this.Load += new System.EventHandler(this.frmDK_DVDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.ComboBox cb_TT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_DichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_CanHo;
        private System.Windows.Forms.Label label1;
    }
}