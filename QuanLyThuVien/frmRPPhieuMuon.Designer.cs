namespace QuanLyThuVien
{
    partial class frmRPPhieuMuon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DanhSachPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.slueMaThe = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.layPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slueSoPhieu = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.layMuonSachSoPhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DanhSachPhieuMuonTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.DanhSachPhieuMuonTableAdapter();
            this.layPhieuMuonTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.layPhieuMuonTableAdapter();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layMuonSachSoPhieuTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.layMuonSachSoPhieuTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slueMaThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPhieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueSoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layMuonSachSoPhieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachPhieuMuonBindingSource
            // 
            this.DanhSachPhieuMuonBindingSource.DataMember = "DanhSachPhieuMuon";
            this.DanhSachPhieuMuonBindingSource.DataSource = this.QuanLyThuVienDataSet;
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
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(951, 471);
            this.splitContainerControl1.SplitterPosition = 444;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(443, 471);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh mục tìm kiếm";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.slueMaThe);
            this.layoutControl1.Controls.Add(this.slueSoPhieu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 25);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(439, 444);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(307, 72);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(116, 20);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Thống kê";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // slueMaThe
            // 
            this.slueMaThe.Location = new System.Drawing.Point(77, 16);
            this.slueMaThe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slueMaThe.Name = "slueMaThe";
            this.slueMaThe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueMaThe.Properties.DataSource = this.layPhieuMuonBindingSource;
            this.slueMaThe.Properties.DisplayMember = "MaThe";
            this.slueMaThe.Properties.ValueMember = "MaThe";
            this.slueMaThe.Size = new System.Drawing.Size(346, 22);
            this.slueMaThe.StyleController = this.layoutControl1;
            this.slueMaThe.TabIndex = 1;
            this.slueMaThe.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // layPhieuMuonBindingSource
            // 
            this.layPhieuMuonBindingSource.DataMember = "layPhieuMuon";
            this.layPhieuMuonBindingSource.DataSource = this.QuanLyThuVienDataSet;
            // 
            // slueSoPhieu
            // 
            this.slueSoPhieu.Location = new System.Drawing.Point(77, 44);
            this.slueSoPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slueSoPhieu.Name = "slueSoPhieu";
            this.slueSoPhieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueSoPhieu.Properties.DataSource = this.layMuonSachSoPhieuBindingSource;
            this.slueSoPhieu.Properties.DisplayMember = "SoPhieu";
            this.slueSoPhieu.Properties.ValueMember = "SoPhieu";
            this.slueSoPhieu.Size = new System.Drawing.Size(346, 22);
            this.slueSoPhieu.StyleController = this.layoutControl1;
            this.slueSoPhieu.TabIndex = 7;
            // 
            // layMuonSachSoPhieuBindingSource
            // 
            this.layMuonSachSoPhieuBindingSource.DataMember = "layMuonSachSoPhieu";
            this.layMuonSachSoPhieuBindingSource.DataSource = this.QuanLyThuVienDataSet;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(439, 444);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.slueSoPhieu;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(413, 28);
            this.layoutControlItem2.Text = "Số phiếu:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(58, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(291, 56);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(122, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(122, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 82);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(413, 282);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 364);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(413, 54);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(291, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.slueMaThe;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(413, 28);
            this.layoutControlItem1.Text = "Mã thẻ:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(58, 17);
            // 
            // DanhSachPhieuMuonTableAdapter
            // 
            this.DanhSachPhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // layPhieuMuonTableAdapter
            // 
            this.layPhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsFind.FindFilterColumns = "MaThe";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // layMuonSachSoPhieuTableAdapter
            // 
            this.layMuonSachSoPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DanhSachPhieuMuonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.rpDanhSachPhieuMuon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(501, 471);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRPPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 471);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRPPhieuMuon";
            this.Text = "Phiếu mượn";
            this.Load += new System.EventHandler(this.frmRPPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slueMaThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPhieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueSoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layMuonSachSoPhieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.BindingSource DanhSachPhieuMuonBindingSource;
        private QuanLyThuVienDataSet QuanLyThuVienDataSet;
        private QuanLyThuVienDataSetTableAdapters.DanhSachPhieuMuonTableAdapter DanhSachPhieuMuonTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource layPhieuMuonBindingSource;
        private QuanLyThuVienDataSetTableAdapters.layPhieuMuonTableAdapter layPhieuMuonTableAdapter;
        private DevExpress.XtraEditors.SearchLookUpEdit slueSoPhieu;
        private DevExpress.XtraEditors.SearchLookUpEdit slueMaThe;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private System.Windows.Forms.BindingSource layMuonSachSoPhieuBindingSource;
        private QuanLyThuVienDataSetTableAdapters.layMuonSachSoPhieuTableAdapter layMuonSachSoPhieuTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}