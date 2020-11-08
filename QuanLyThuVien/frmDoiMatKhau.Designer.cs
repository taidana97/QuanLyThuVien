namespace QuanLyThuVien
{
    partial class frmDoiMatKhau
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
            this.txtPassOld = new DevExpress.XtraEditors.TextEdit();
            this.txtRePassNew = new DevExpress.XtraEditors.TextEdit();
            this.txtPassNew = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.lbThongBao = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(12, 60);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassOld.Properties.Appearance.Options.UseFont = true;
            this.txtPassOld.Properties.UseSystemPasswordChar = true;
            this.txtPassOld.Size = new System.Drawing.Size(252, 30);
            this.txtPassOld.TabIndex = 0;
            this.txtPassOld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassOld_KeyDown);
            // 
            // txtRePassNew
            // 
            this.txtRePassNew.Location = new System.Drawing.Point(12, 170);
            this.txtRePassNew.Name = "txtRePassNew";
            this.txtRePassNew.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRePassNew.Properties.Appearance.Options.UseFont = true;
            this.txtRePassNew.Properties.UseSystemPasswordChar = true;
            this.txtRePassNew.Size = new System.Drawing.Size(252, 30);
            this.txtRePassNew.TabIndex = 2;
            this.txtRePassNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassOld_KeyDown);
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(12, 115);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassNew.Properties.Appearance.Options.UseFont = true;
            this.txtPassNew.Properties.UseSystemPasswordChar = true;
            this.txtPassNew.Size = new System.Drawing.Size(252, 30);
            this.txtPassNew.TabIndex = 1;
            this.txtPassNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassOld_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(12, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mật khẩu củ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(12, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(12, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Gõ lại mật khẩu mới";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(184, 224);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(80, 33);
            this.btnTroVe.TabIndex = 4;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(12, 224);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(166, 33);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.AllowDrop = true;
            this.lbThongBao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.Location = new System.Drawing.Point(12, 11);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(0, 13);
            this.lbThongBao.TabIndex = 6;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 281);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.txtRePassNew);
            this.Controls.Add(this.txtPassOld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPassOld;
        private DevExpress.XtraEditors.TextEdit txtRePassNew;
        private DevExpress.XtraEditors.TextEdit txtPassNew;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.LabelControl lbThongBao;
    }
}