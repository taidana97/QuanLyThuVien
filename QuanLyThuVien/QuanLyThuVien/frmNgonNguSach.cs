using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
using System.IO;
using System.Data.SqlClient;
using QuanLyThuVien.BS_layer;


namespace QuanLyThuVien
{
    public partial class frmNgonNguSach : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtNgonNguSach = null;
        bool them = false;
        string err;
        BLNgonNguSach dbNgonNgu = new BLNgonNguSach();

        string MaNgonNgu = "";
        string TenNgonNgu = "";

        public frmNgonNguSach()
        {
            InitializeComponent();
            gvNgonNguSach.ShownEditor += gvNgonNguSach_ShownEditor;
        }

        private void frmNgonNguSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtNgonNguSach = new DataTable();
                dtNgonNguSach.Clear();
                DataSet ds = dbNgonNgu.LayNgonNguSach();
                dtNgonNguSach = ds.Tables[0];

                gcNgonNguSach.DataSource = dtNgonNguSach;

                them = false;

                MaNgonNgu = "";
                TenNgonNgu = "";

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table NgonNguSach. Lỗi rồi!!!");
            }
        }

        void gvNgonNguSach_ShownEditor(object sender, EventArgs e)
        {
            gvNgonNguSach.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvNgonNguSach.GetDataRow(gvNgonNguSach.FocusedRowHandle);
            MaNgonNgu = row[0].ToString();
            TenNgonNgu = row[1].ToString();
        }

        private void gvNgonNguSach_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvNgonNguSach.SetRowCellValue(e.RowHandle, "MaNgonNgu", "NN" + gvNgonNguSach.RowCount);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvNgonNguSach.AddNewRow();
            them = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnInfor.Enabled = false;
            this.btnTable.Enabled = false;
            this.btnTroVe.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvNgonNguSach.FocusedRowHandle;

                string strNgonNguSach = gvNgonNguSach.GetRowCellValue(r, "MaNgonNgu").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbNgonNgu.XoaNgonNguSach(strNgonNguSach, ref err);
                    gvNgonNguSach.DeleteRow(gvNgonNguSach.FocusedRowHandle);
                    XtraMessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    XtraMessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                XtraMessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            gcNgonNguSach.MainView = lvNgonNguSach;
            this.gclLuu.OptionsColumn.AllowEdit = false;
            this.gclHuy.OptionsColumn.AllowEdit = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnRefresh.Enabled = false;
            this.btnInfor.Enabled = false;

            this.btnTable.Enabled = true;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            gcNgonNguSach.MainView = gvNgonNguSach;
            this.gclLuu.OptionsColumn.AllowEdit = true;
            this.gclHuy.OptionsColumn.AllowEdit = true;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnRefresh.Enabled = true;
            this.btnInfor.Enabled = true;

            this.btnTable.Enabled = false;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = XtraMessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnLuu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (them)
            {
                try
                {
                    BLNgonNguSach blNgonNgu = new BLNgonNguSach();

                    blNgonNgu.ThemNgonNguSach(MaNgonNgu, TenNgonNgu, ref err);

                    LoadData();

                    XtraMessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    XtraMessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                try
                {
                    BLNgonNguSach blNgonNgu = new BLNgonNguSach();

                    blNgonNgu.CapNhatNgonNguSach(MaNgonNgu, TenNgonNgu, ref err);

                    LoadData();

                    XtraMessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoadData();
        }
    }
}