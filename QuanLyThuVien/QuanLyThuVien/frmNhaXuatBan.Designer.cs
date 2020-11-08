namespace QuanLyThuVien
{
    partial class frmNhaXuatBan
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lvNhaXuatBan = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gcNhaXuatBan = new DevExpress.XtraGrid.GridControl();
            this.gvNhaXuatBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclLuu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLuu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gclHuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHuy = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockTools = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.btnTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnInfor = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lvNhaXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhaXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockTools.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNhaXuatBan
            // 
            this.lvNhaXuatBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn5,
            this.layoutViewColumn4});
            this.lvNhaXuatBan.GridControl = this.gcNhaXuatBan;
            this.lvNhaXuatBan.Name = "lvNhaXuatBan";
            this.lvNhaXuatBan.OptionsBehavior.Editable = false;
            this.lvNhaXuatBan.TemplateCard = this.layoutViewCard2;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Mã NXB";
            this.layoutViewColumn1.FieldName = "MaNXB";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_gridColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewField_gridColumn1
            // 
            this.layoutViewField_gridColumn1.EditorPreferredWidth = 113;
            this.layoutViewField_gridColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gridColumn1.Name = "layoutViewField_gridColumn1";
            this.layoutViewField_gridColumn1.Size = new System.Drawing.Size(218, 24);
            this.layoutViewField_gridColumn1.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "Tên NXB";
            this.layoutViewColumn2.FieldName = "TenNXB";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_gridColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // layoutViewField_gridColumn2
            // 
            this.layoutViewField_gridColumn2.EditorPreferredWidth = 113;
            this.layoutViewField_gridColumn2.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_gridColumn2.Name = "layoutViewField_gridColumn2";
            this.layoutViewField_gridColumn2.Size = new System.Drawing.Size(218, 24);
            this.layoutViewField_gridColumn2.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Địa Chỉ";
            this.layoutViewColumn3.FieldName = "DiaChi";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_gridColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewField_gridColumn3
            // 
            this.layoutViewField_gridColumn3.EditorPreferredWidth = 113;
            this.layoutViewField_gridColumn3.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_gridColumn3.Name = "layoutViewField_gridColumn3";
            this.layoutViewField_gridColumn3.Size = new System.Drawing.Size(218, 24);
            this.layoutViewField_gridColumn3.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "SĐT";
            this.layoutViewColumn5.FieldName = "SDT";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_layoutViewColumn5;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            // 
            // layoutViewField_layoutViewColumn5
            // 
            this.layoutViewField_layoutViewColumn5.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn5.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_layoutViewColumn5.Name = "layoutViewField_layoutViewColumn5";
            this.layoutViewField_layoutViewColumn5.Size = new System.Drawing.Size(218, 20);
            this.layoutViewField_layoutViewColumn5.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Ngày Thành Lập";
            this.layoutViewColumn4.FieldName = "NgayThanhLap";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_gridColumn4;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            // 
            // layoutViewField_gridColumn4
            // 
            this.layoutViewField_gridColumn4.EditorPreferredWidth = 113;
            this.layoutViewField_gridColumn4.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_gridColumn4.Name = "layoutViewField_gridColumn4";
            this.layoutViewField_gridColumn4.Size = new System.Drawing.Size(218, 24);
            this.layoutViewField_gridColumn4.TextSize = new System.Drawing.Size(82, 13);
            // 
            // gcNhaXuatBan
            // 
            this.gcNhaXuatBan.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.lvNhaXuatBan;
            gridLevelNode1.RelationName = "Level1";
            this.gcNhaXuatBan.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcNhaXuatBan.Location = new System.Drawing.Point(0, 0);
            this.gcNhaXuatBan.MainView = this.gvNhaXuatBan;
            this.gcNhaXuatBan.Name = "gcNhaXuatBan";
            this.gcNhaXuatBan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnLuu,
            this.btnHuy});
            this.gcNhaXuatBan.Size = new System.Drawing.Size(535, 379);
            this.gcNhaXuatBan.TabIndex = 6;
            this.gcNhaXuatBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhaXuatBan,
            this.lvNhaXuatBan});
            // 
            // gvNhaXuatBan
            // 
            this.gvNhaXuatBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn4,
            this.gclLuu,
            this.gclHuy});
            this.gvNhaXuatBan.GridControl = this.gcNhaXuatBan;
            this.gvNhaXuatBan.Name = "gvNhaXuatBan";
            this.gvNhaXuatBan.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvNhaXuatBan_InitNewRow);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã NXB";
            this.gridColumn1.FieldName = "MaNXB";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 84;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên NXB";
            this.gridColumn2.FieldName = "TenNXB";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 84;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa Chỉ";
            this.gridColumn3.FieldName = "DiaChi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 84;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "SĐT";
            this.gridColumn5.FieldName = "SDT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 84;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày Thành Lập";
            this.gridColumn4.FieldName = "NgayThanhLap";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 84;
            // 
            // gclLuu
            // 
            this.gclLuu.Caption = "Lưu";
            this.gclLuu.ColumnEdit = this.btnLuu;
            this.gclLuu.MinWidth = 11;
            this.gclLuu.Name = "gclLuu";
            this.gclLuu.Visible = true;
            this.gclLuu.VisibleIndex = 5;
            this.gclLuu.Width = 11;
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
            // gclHuy
            // 
            this.gclHuy.Caption = "Hủy";
            this.gclHuy.ColumnEdit = this.btnHuy;
            this.gclHuy.MinWidth = 11;
            this.gclHuy.Name = "gclHuy";
            this.gclHuy.Visible = true;
            this.gclHuy.VisibleIndex = 6;
            this.gclHuy.Width = 11;
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
            // layoutViewCard2
            // 
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gridColumn1,
            this.layoutViewField_gridColumn2,
            this.layoutViewField_gridColumn3,
            this.layoutViewField_gridColumn4,
            this.layoutViewField_layoutViewColumn5});
            this.layoutViewCard2.Name = "layoutViewCard2";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockTools});
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
            // dockTools
            // 
            this.dockTools.Controls.Add(this.dockPanel1_Container);
            this.dockTools.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockTools.ID = new System.Guid("f1145b3e-aef7-4a08-a870-aa665fe4e59c");
            this.dockTools.Location = new System.Drawing.Point(535, 0);
            this.dockTools.Name = "dockTools";
            this.dockTools.OriginalSize = new System.Drawing.Size(291, 200);
            this.dockTools.Size = new System.Drawing.Size(291, 379);
            this.dockTools.Text = "Thanh Công Cụ";
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
            this.dockPanel1_Container.Size = new System.Drawing.Size(283, 352);
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
            this.btnTroVe.Size = new System.Drawing.Size(283, 35);
            this.btnTroVe.TabIndex = 8;
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
            this.btnTable.Size = new System.Drawing.Size(283, 38);
            this.btnTable.TabIndex = 7;
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
            this.btnInfor.Size = new System.Drawing.Size(283, 35);
            this.btnInfor.TabIndex = 6;
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
            this.btnRefresh.Size = new System.Drawing.Size(283, 35);
            this.btnRefresh.TabIndex = 6;
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
            this.btnXoa.Size = new System.Drawing.Size(283, 35);
            this.btnXoa.TabIndex = 6;
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
            this.btnThem.Size = new System.Drawing.Size(283, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 379);
            this.Controls.Add(this.gcNhaXuatBan);
            this.Controls.Add(this.dockTools);
            this.Name = "frmNhaXuatBan";
            this.Text = "Quản lý nhà xuất bản";
            this.Load += new System.EventHandler(this.frmNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvNhaXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhaXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockTools.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockTools;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnInfor;
        private DevExpress.XtraEditors.SimpleButton btnTable;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraGrid.GridControl gcNhaXuatBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhaXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutView lvNhaXuatBan;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gclLuu;
        private DevExpress.XtraGrid.Columns.GridColumn gclHuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnHuy;
    }
}