﻿namespace QuanLyThuVien
{
    partial class frmTacGia
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
            this.lvTacGia = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.btnLuu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewField_gclLuu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn7 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.btnHuy = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewField_gclHuy = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gcTacGia = new DevExpress.XtraGrid.GridControl();
            this.gvTacGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.lvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gclLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gclHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTacGia
            // 
            this.lvTacGia.CardMinSize = new System.Drawing.Size(281, 158);
            this.lvTacGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6,
            this.layoutViewColumn7});
            this.lvTacGia.GridControl = this.gcTacGia;
            this.lvTacGia.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gclLuu,
            this.layoutViewField_gclHuy});
            this.lvTacGia.Name = "lvTacGia";
            this.lvTacGia.OptionsBehavior.Editable = false;
            this.lvTacGia.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Mã tác giả";
            this.layoutViewColumn1.FieldName = "MaTG";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_gridColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.Width = 91;
            // 
            // layoutViewField_gridColumn1
            // 
            this.layoutViewField_gridColumn1.EditorPreferredWidth = 195;
            this.layoutViewField_gridColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gridColumn1.Name = "layoutViewField_gridColumn1";
            this.layoutViewField_gridColumn1.Size = new System.Drawing.Size(261, 24);
            this.layoutViewField_gridColumn1.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "Tên tác giả";
            this.layoutViewColumn2.FieldName = "TenTG";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_gridColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            this.layoutViewColumn2.Width = 91;
            // 
            // layoutViewField_gridColumn2
            // 
            this.layoutViewField_gridColumn2.EditorPreferredWidth = 195;
            this.layoutViewField_gridColumn2.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_gridColumn2.Name = "layoutViewField_gridColumn2";
            this.layoutViewField_gridColumn2.Size = new System.Drawing.Size(261, 24);
            this.layoutViewField_gridColumn2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Địa chỉ";
            this.layoutViewColumn3.FieldName = "DiaChi";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_gridColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            this.layoutViewColumn3.Width = 91;
            // 
            // layoutViewField_gridColumn3
            // 
            this.layoutViewField_gridColumn3.EditorPreferredWidth = 195;
            this.layoutViewField_gridColumn3.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_gridColumn3.Name = "layoutViewField_gridColumn3";
            this.layoutViewField_gridColumn3.Size = new System.Drawing.Size(261, 24);
            this.layoutViewField_gridColumn3.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "SĐT";
            this.layoutViewColumn4.FieldName = "SDT";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_gridColumn4;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            this.layoutViewColumn4.Width = 91;
            // 
            // layoutViewField_gridColumn4
            // 
            this.layoutViewField_gridColumn4.EditorPreferredWidth = 195;
            this.layoutViewField_gridColumn4.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_gridColumn4.Name = "layoutViewField_gridColumn4";
            this.layoutViewField_gridColumn4.Size = new System.Drawing.Size(261, 24);
            this.layoutViewField_gridColumn4.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "Email";
            this.layoutViewColumn5.FieldName = "Email";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_gridColumn5;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            this.layoutViewColumn5.Width = 91;
            // 
            // layoutViewField_gridColumn5
            // 
            this.layoutViewField_gridColumn5.EditorPreferredWidth = 195;
            this.layoutViewField_gridColumn5.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_gridColumn5.Name = "layoutViewField_gridColumn5";
            this.layoutViewField_gridColumn5.Size = new System.Drawing.Size(261, 24);
            this.layoutViewField_gridColumn5.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutViewColumn6
            // 
            this.layoutViewColumn6.Caption = "Lưu";
            this.layoutViewColumn6.ColumnEdit = this.btnLuu;
            this.layoutViewColumn6.LayoutViewField = this.layoutViewField_gclLuu;
            this.layoutViewColumn6.MinWidth = 11;
            this.layoutViewColumn6.Name = "layoutViewColumn6";
            this.layoutViewColumn6.Width = 11;
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
            this.layoutViewField_gclLuu.Size = new System.Drawing.Size(261, 120);
            this.layoutViewField_gclLuu.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutViewColumn7
            // 
            this.layoutViewColumn7.Caption = "Hủy";
            this.layoutViewColumn7.ColumnEdit = this.btnHuy;
            this.layoutViewColumn7.LayoutViewField = this.layoutViewField_gclHuy;
            this.layoutViewColumn7.MinWidth = 11;
            this.layoutViewColumn7.Name = "layoutViewColumn7";
            this.layoutViewColumn7.Width = 11;
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
            this.layoutViewField_gclHuy.Size = new System.Drawing.Size(261, 120);
            this.layoutViewField_gclHuy.TextSize = new System.Drawing.Size(57, 13);
            // 
            // gcTacGia
            // 
            this.gcTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.lvTacGia;
            gridLevelNode1.RelationName = "Level1";
            this.gcTacGia.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcTacGia.Location = new System.Drawing.Point(0, 0);
            this.gcTacGia.MainView = this.gvTacGia;
            this.gcTacGia.Name = "gcTacGia";
            this.gcTacGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnLuu,
            this.btnHuy});
            this.gcTacGia.Size = new System.Drawing.Size(656, 331);
            this.gcTacGia.TabIndex = 1;
            this.gcTacGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTacGia,
            this.lvTacGia});
            // 
            // gvTacGia
            // 
            this.gvTacGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gclLuu,
            this.gclHuy});
            this.gvTacGia.GridControl = this.gcTacGia;
            this.gvTacGia.Name = "gvTacGia";
            this.gvTacGia.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvTacGia_InitNewRow);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã tác giả";
            this.gridColumn1.FieldName = "MaTG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 91;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên tác giả";
            this.gridColumn2.FieldName = "TenTG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 91;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "DiaChi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 91;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "SĐT";
            this.gridColumn4.FieldName = "SDT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 91;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Email";
            this.gridColumn5.FieldName = "Email";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 91;
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
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gridColumn1,
            this.layoutViewField_gridColumn2,
            this.layoutViewField_gridColumn3,
            this.layoutViewField_gridColumn4,
            this.layoutViewField_gridColumn5});
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
            this.dockPanel1.ID = new System.Guid("637a69ff-678c-46ad-9b8b-cde94838c3ca");
            this.dockPanel1.Location = new System.Drawing.Point(656, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(236, 200);
            this.dockPanel1.Size = new System.Drawing.Size(236, 331);
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
            this.dockPanel1_Container.Size = new System.Drawing.Size(228, 304);
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
            this.btnTroVe.Size = new System.Drawing.Size(228, 35);
            this.btnTroVe.TabIndex = 20;
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
            this.btnTable.Size = new System.Drawing.Size(228, 38);
            this.btnTable.TabIndex = 19;
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
            this.btnInfor.Size = new System.Drawing.Size(228, 35);
            this.btnInfor.TabIndex = 15;
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
            this.btnRefresh.Size = new System.Drawing.Size(228, 35);
            this.btnRefresh.TabIndex = 16;
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
            this.btnXoa.Size = new System.Drawing.Size(228, 35);
            this.btnXoa.TabIndex = 17;
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
            this.btnThem.Size = new System.Drawing.Size(228, 35);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 331);
            this.Controls.Add(this.gcTacGia);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmTacGia";
            this.Text = "Quản lý tác giả";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gclLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gclHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTacGia)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnTable;
        private DevExpress.XtraEditors.SimpleButton btnInfor;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gcTacGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gclLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn gclHuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnHuy;
        private DevExpress.XtraGrid.Views.Layout.LayoutView lvTacGia;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn5;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gclLuu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn7;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gclHuy;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}