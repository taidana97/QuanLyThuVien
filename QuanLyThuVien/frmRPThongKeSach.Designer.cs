namespace QuanLyThuVien
{
    partial class frmRPThongKeSach
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.laySachThongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.laySachThongKeTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.laySachThongKeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.laySachThongKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // laySachThongKeBindingSource
            // 
            this.laySachThongKeBindingSource.DataMember = "laySachThongKe";
            this.laySachThongKeBindingSource.DataSource = this.QuanLyThuVienDataSet;
            // 
            // QuanLyThuVienDataSet
            // 
            this.QuanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1031, 498);
            this.splitContainerControl1.SplitterPosition = 360;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 498);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.laySachThongKeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.rpThongKeSach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(665, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // laySachThongKeTableAdapter
            // 
            this.laySachThongKeTableAdapter.ClearBeforeFill = true;
            // 
            // frmRPThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 498);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmRPThongKeSach";
            this.Text = "r";
            this.Load += new System.EventHandler(this.frmRPThongKeSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laySachThongKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource laySachThongKeBindingSource;
        private QuanLyThuVienDataSet QuanLyThuVienDataSet;
        private QuanLyThuVienDataSetTableAdapters.laySachThongKeTableAdapter laySachThongKeTableAdapter;
    }
}