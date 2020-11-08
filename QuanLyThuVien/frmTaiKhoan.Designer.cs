namespace QuanLyThuVien
{
    partial class frmTaiKhoan
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.lvDangNhap = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.cmbQuyen = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.layoutViewField_gridColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.btnLuu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewField_gridColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.btnHuy = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewField_gridColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gcDangNhap = new DevExpress.XtraGrid.GridControl();
            this.gvDangNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glueID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.lvDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDangNhap
            // 
            this.lvDangNhap.CardMinSize = new System.Drawing.Size(242, 110);
            this.lvDangNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5});
            this.lvDangNhap.GridControl = this.gcDangNhap;
            this.lvDangNhap.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gridColumn4,
            this.layoutViewField_gridColumn5});
            this.lvDangNhap.Name = "lvDangNhap";
            this.lvDangNhap.OptionsBehavior.Editable = false;
            this.lvDangNhap.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "ID";
            this.layoutViewColumn1.FieldName = "ID";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_gridColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.Width = 112;
            // 
            // layoutViewField_gridColumn1
            // 
            this.layoutViewField_gridColumn1.EditorPreferredWidth = 177;
            this.layoutViewField_gridColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gridColumn1.Name = "layoutViewField_gridColumn1";
            this.layoutViewField_gridColumn1.Size = new System.Drawing.Size(222, 24);
            this.layoutViewField_gridColumn1.TextSize = new System.Drawing.Size(36, 13);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "PASS";
            this.layoutViewColumn2.FieldName = "PASS";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_gridColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            this.layoutViewColumn2.Width = 112;
            // 
            // layoutViewField_gridColumn2
            // 
            this.layoutViewField_gridColumn2.EditorPreferredWidth = 177;
            this.layoutViewField_gridColumn2.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_gridColumn2.Name = "layoutViewField_gridColumn2";
            this.layoutViewField_gridColumn2.Size = new System.Drawing.Size(222, 24);
            this.layoutViewField_gridColumn2.TextSize = new System.Drawing.Size(36, 13);
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Quyền";
            this.layoutViewColumn3.ColumnEdit = this.cmbQuyen;
            this.layoutViewColumn3.FieldName = "QUYEN";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_gridColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            this.layoutViewColumn3.Width = 112;
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.AutoHeight = false;
            this.cmbQuyen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbQuyen.Items.AddRange(new object[] {
            "nv",
            "ad"});
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // layoutViewField_gridColumn3
            // 
            this.layoutViewField_gridColumn3.EditorPreferredWidth = 177;
            this.layoutViewField_gridColumn3.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_gridColumn3.Name = "layoutViewField_gridColumn3";
            this.layoutViewField_gridColumn3.Size = new System.Drawing.Size(222, 24);
            this.layoutViewField_gridColumn3.TextSize = new System.Drawing.Size(36, 13);
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Lưu";
            this.layoutViewColumn4.ColumnEdit = this.btnLuu;
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_gridColumn4;
            this.layoutViewColumn4.MinWidth = 11;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            this.layoutViewColumn4.Width = 11;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoHeight = false;
            this.btnLuu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::QuanLyThuVien.Properties.Resources.save_icon_silhouette, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnLuu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnLuu_ButtonClick);
            // 
            // layoutViewField_gridColumn4
            // 
            this.layoutViewField_gridColumn4.EditorPreferredWidth = 20;
            this.layoutViewField_gridColumn4.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gridColumn4.Name = "layoutViewField_gridColumn4";
            this.layoutViewField_gridColumn4.Size = new System.Drawing.Size(203, 124);
            this.layoutViewField_gridColumn4.TextSize = new System.Drawing.Size(36, 13);
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "Hủy";
            this.layoutViewColumn5.ColumnEdit = this.btnHuy;
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_gridColumn5;
            this.layoutViewColumn5.MinWidth = 11;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            this.layoutViewColumn5.Width = 11;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoHeight = false;
            this.btnHuy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::QuanLyThuVien.Properties.Resources.if_068_Cancel_183197, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnHuy.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnHuy_ButtonClick);
            // 
            // layoutViewField_gridColumn5
            // 
            this.layoutViewField_gridColumn5.EditorPreferredWidth = 20;
            this.layoutViewField_gridColumn5.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gridColumn5.Name = "layoutViewField_gridColumn5";
            this.layoutViewField_gridColumn5.Size = new System.Drawing.Size(203, 124);
            this.layoutViewField_gridColumn5.TextSize = new System.Drawing.Size(36, 13);
            // 
            // gcDangNhap
            // 
            this.gcDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.LevelTemplate = this.lvDangNhap;
            gridLevelNode2.RelationName = "Level1";
            this.gcDangNhap.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcDangNhap.Location = new System.Drawing.Point(0, 0);
            this.gcDangNhap.MainView = this.gvDangNhap;
            this.gcDangNhap.Name = "gcDangNhap";
            this.gcDangNhap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnLuu,
            this.btnHuy,
            this.cmbQuyen,
            this.glueID});
            this.gcDangNhap.Size = new System.Drawing.Size(582, 406);
            this.gcDangNhap.TabIndex = 1;
            this.gcDangNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDangNhap,
            this.lvDangNhap});
            // 
            // gvDangNhap
            // 
            this.gvDangNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gclLuu,
            this.gclHuy});
            this.gvDangNhap.GridControl = this.gcDangNhap;
            this.gvDangNhap.Name = "gvDangNhap";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.ColumnEdit = this.glueID;
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // glueID
            // 
            this.glueID.AutoHeight = false;
            this.glueID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueID.Name = "glueID";
            this.glueID.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PASS";
            this.gridColumn2.FieldName = "PASS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Quyền";
            this.gridColumn3.ColumnEdit = this.cmbQuyen;
            this.gridColumn3.FieldName = "QUYEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 112;
            // 
            // gclLuu
            // 
            this.gclLuu.Caption = "Lưu";
            this.gclLuu.ColumnEdit = this.btnLuu;
            this.gclLuu.MinWidth = 11;
            this.gclLuu.Name = "gclLuu";
            this.gclLuu.Visible = true;
            this.gclLuu.VisibleIndex = 3;
            this.gclLuu.Width = 11;
            // 
            // gclHuy
            // 
            this.gclHuy.Caption = "Hủy";
            this.gclHuy.ColumnEdit = this.btnHuy;
            this.gclHuy.MinWidth = 11;
            this.gclHuy.Name = "gclHuy";
            this.gclHuy.Visible = true;
            this.gclHuy.VisibleIndex = 4;
            this.gclHuy.Width = 11;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gridColumn1,
            this.layoutViewField_gridColumn2,
            this.layoutViewField_gridColumn3});
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
            this.dockPanel1.ID = new System.Guid("fe38b939-fd6d-4878-a106-66da8cc99a83");
            this.dockPanel1.Location = new System.Drawing.Point(582, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(247, 200);
            this.dockPanel1.Size = new System.Drawing.Size(247, 406);
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
            this.dockPanel1_Container.Size = new System.Drawing.Size(239, 379);
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
            this.btnTroVe.Size = new System.Drawing.Size(239, 35);
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
            this.btnTable.Size = new System.Drawing.Size(239, 38);
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
            this.btnInfor.Size = new System.Drawing.Size(239, 35);
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
            this.btnRefresh.Size = new System.Drawing.Size(239, 35);
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
            this.btnXoa.Size = new System.Drawing.Size(239, 35);
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
            this.btnThem.Size = new System.Drawing.Size(239, 35);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 406);
            this.Controls.Add(this.gcDangNhap);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmTaiKhoan";
            this.Text = "Quản lý tài khoản - cấp quyền truy cập";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gcDangNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDangNhap;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnTable;
        private DevExpress.XtraEditors.SimpleButton btnInfor;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Views.Layout.LayoutView lvDangNhap;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbQuyen;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnLuu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnHuy;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gclLuu;
        private DevExpress.XtraGrid.Columns.GridColumn gclHuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glueID;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    }
}