namespace QuanLyThuVien
{
    partial class frmNgonNguSach
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.lvNgonNguSach = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.btnLuu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewField_gclLuu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.btnHuy = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewField_gclHuy = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gcNgonNguSach = new DevExpress.XtraGrid.GridControl();
            this.gvNgonNguSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclLuu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclHuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.btnTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnInfor = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lvNgonNguSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gclLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gclHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNgonNguSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNgonNguSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNgonNguSach
            // 
            this.lvNgonNguSach.CardMinSize = new System.Drawing.Size(283, 86);
            this.lvNgonNguSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4});
            this.lvNgonNguSach.GridControl = this.gcNgonNguSach;
            this.lvNgonNguSach.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gclLuu,
            this.layoutViewField_gclHuy});
            this.lvNgonNguSach.Name = "lvNgonNguSach";
            this.lvNgonNguSach.OptionsBehavior.Editable = false;
            this.lvNgonNguSach.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Mã ngôn ngữ";
            this.layoutViewColumn1.FieldName = "MaNgonNgu";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_gridColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.Width = 101;
            // 
            // layoutViewField_gridColumn1
            // 
            this.layoutViewField_gridColumn1.EditorPreferredWidth = 183;
            this.layoutViewField_gridColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gridColumn1.Name = "layoutViewField_gridColumn1";
            this.layoutViewField_gridColumn1.Size = new System.Drawing.Size(263, 24);
            this.layoutViewField_gridColumn1.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "Tên ngôn ngữ";
            this.layoutViewColumn2.FieldName = "TenNgonNgu";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_gridColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            this.layoutViewColumn2.Width = 101;
            // 
            // layoutViewField_gridColumn2
            // 
            this.layoutViewField_gridColumn2.EditorPreferredWidth = 183;
            this.layoutViewField_gridColumn2.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_gridColumn2.Name = "layoutViewField_gridColumn2";
            this.layoutViewField_gridColumn2.Size = new System.Drawing.Size(263, 24);
            this.layoutViewField_gridColumn2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Lưu";
            this.layoutViewColumn3.ColumnEdit = this.btnLuu;
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_gclLuu;
            this.layoutViewColumn3.MinWidth = 11;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            this.layoutViewColumn3.Width = 11;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoHeight = false;
            this.btnLuu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::QuanLyThuVien.Properties.Resources.save_icon_silhouette, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnLuu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnLuu_ButtonClick);
            // 
            // layoutViewField_gclLuu
            // 
            this.layoutViewField_gclLuu.EditorPreferredWidth = 20;
            this.layoutViewField_gclLuu.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gclLuu.Name = "layoutViewField_gclLuu";
            this.layoutViewField_gclLuu.Size = new System.Drawing.Size(203, 100);
            this.layoutViewField_gclLuu.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Hủy";
            this.layoutViewColumn4.ColumnEdit = this.btnHuy;
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_gclHuy;
            this.layoutViewColumn4.MinWidth = 11;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            this.layoutViewColumn4.Width = 11;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoHeight = false;
            this.btnHuy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::QuanLyThuVien.Properties.Resources.if_068_Cancel_183197, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnHuy.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnHuy_ButtonClick);
            // 
            // layoutViewField_gclHuy
            // 
            this.layoutViewField_gclHuy.EditorPreferredWidth = 20;
            this.layoutViewField_gclHuy.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gclHuy.Name = "layoutViewField_gclHuy";
            this.layoutViewField_gclHuy.Size = new System.Drawing.Size(203, 100);
            this.layoutViewField_gclHuy.TextSize = new System.Drawing.Size(71, 13);
            // 
            // gcNgonNguSach
            // 
            this.gcNgonNguSach.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.lvNgonNguSach;
            gridLevelNode1.RelationName = "Level1";
            this.gcNgonNguSach.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcNgonNguSach.Location = new System.Drawing.Point(0, 0);
            this.gcNgonNguSach.MainView = this.gvNgonNguSach;
            this.gcNgonNguSach.Name = "gcNgonNguSach";
            this.gcNgonNguSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnLuu,
            this.btnHuy});
            this.gcNgonNguSach.Size = new System.Drawing.Size(423, 356);
            this.gcNgonNguSach.TabIndex = 1;
            this.gcNgonNguSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNgonNguSach,
            this.lvNgonNguSach});
            // 
            // gvNgonNguSach
            // 
            this.gvNgonNguSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gclLuu,
            this.gclHuy});
            this.gvNgonNguSach.GridControl = this.gcNgonNguSach;
            this.gvNgonNguSach.Name = "gvNgonNguSach";
            this.gvNgonNguSach.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvNgonNguSach_InitNewRow);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã ngôn ngữ";
            this.gridColumn1.FieldName = "MaNgonNgu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 101;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên ngôn ngữ";
            this.gridColumn2.FieldName = "TenNgonNgu";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 101;
            // 
            // gclLuu
            // 
            this.gclLuu.Caption = "Lưu";
            this.gclLuu.ColumnEdit = this.btnLuu;
            this.gclLuu.MinWidth = 11;
            this.gclLuu.Name = "gclLuu";
            this.gclLuu.Visible = true;
            this.gclLuu.VisibleIndex = 2;
            this.gclLuu.Width = 11;
            // 
            // gclHuy
            // 
            this.gclHuy.Caption = "Hủy";
            this.gclHuy.ColumnEdit = this.btnHuy;
            this.gclHuy.MinWidth = 11;
            this.gclHuy.Name = "gclHuy";
            this.gclHuy.Visible = true;
            this.gclHuy.VisibleIndex = 3;
            this.gclHuy.Width = 11;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gridColumn1,
            this.layoutViewField_gridColumn2});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("c5f4a6da-fcbd-49b6-b9bb-498707116200");
            this.dockPanel1.Location = new System.Drawing.Point(423, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(255, 200);
            this.dockPanel1.Size = new System.Drawing.Size(255, 356);
            this.dockPanel1.Text = "Thanh công cụ";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.btnTroVe);
            this.dockPanel1_Container.Controls.Add(this.btnTable);
            this.dockPanel1_Container.Controls.Add(this.btnInfor);
            this.dockPanel1_Container.Controls.Add(this.btnRefresh);
            this.dockPanel1_Container.Controls.Add(this.btnXoa);
            this.dockPanel1_Container.Controls.Add(this.btnThem);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(247, 329);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTroVe.Appearance.Options.UseFont = true;
            this.btnTroVe.Appearance.Options.UseTextOptions = true;
            this.btnTroVe.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnTroVe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTroVe.Image = global::QuanLyThuVien.Properties.Resources.icon_sign_out;
            this.btnTroVe.Location = new System.Drawing.Point(0, 178);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(247, 35);
            this.btnTroVe.TabIndex = 14;
            this.btnTroVe.Text = "Thoát";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnTable
            // 
            this.btnTable.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTable.Appearance.Options.UseFont = true;
            this.btnTable.Appearance.Options.UseTextOptions = true;
            this.btnTable.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTable.Image = global::QuanLyThuVien.Properties.Resources.table_grid;
            this.btnTable.Location = new System.Drawing.Point(0, 140);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(247, 38);
            this.btnTable.TabIndex = 13;
            this.btnTable.Text = "Thông tin bảng";
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnInfor
            // 
            this.btnInfor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInfor.Appearance.Options.UseFont = true;
            this.btnInfor.Appearance.Options.UseTextOptions = true;
            this.btnInfor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfor.Image = global::QuanLyThuVien.Properties.Resources.icon_infor;
            this.btnInfor.Location = new System.Drawing.Point(0, 105);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Size = new System.Drawing.Size(247, 35);
            this.btnInfor.TabIndex = 9;
            this.btnInfor.Text = "Thông tin chi tiết";
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseTextOptions = true;
            this.btnRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.Image = global::QuanLyThuVien.Properties.Resources.icon_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(0, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(247, 35);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Tải lại dữ liệu";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseTextOptions = true;
            this.btnXoa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoa.Image = global::QuanLyThuVien.Properties.Resources.icon_delete;
            this.btnXoa.Location = new System.Drawing.Point(0, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(247, 35);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseTextOptions = true;
            this.btnThem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThem.Image = global::QuanLyThuVien.Properties.Resources.icon_add;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(247, 35);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNgonNguSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 356);
            this.Controls.Add(this.gcNgonNguSach);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmNgonNguSach";
            this.Text = "Quản lý ngôn ngữ sách";
            this.Load += new System.EventHandler(this.frmNgonNguSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvNgonNguSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gclLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gclHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNgonNguSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNgonNguSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl gcNgonNguSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNgonNguSach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gclLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn gclHuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnTable;
        private DevExpress.XtraEditors.SimpleButton btnInfor;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Views.Layout.LayoutView lvNgonNguSach;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gclLuu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gclHuy;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}