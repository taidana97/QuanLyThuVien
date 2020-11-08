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
    public partial class frmTheLoai : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtTheLoai = null;
        bool them = false;
        string err;
        BLTheLoai dbTL = new BLTheLoai();

        string MaTL = "";
        string TenTL = "";

        public frmTheLoai()
        {
            InitializeComponent();
            gvTheLoai.ShownEditor += gvTheLoai_ShownEditor;
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtTheLoai = new DataTable();
                dtTheLoai.Clear();
                DataSet ds = dbTL.LayTheLoai();
                dtTheLoai = ds.Tables[0];

                gcTheLoai.DataSource = dtTheLoai;

                them = false;

                MaTL = "";
                TenTL = "";

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table TheLoai. Lỗi rồi!!!");
            }
        }
        void gvTheLoai_ShownEditor(object sender, EventArgs e)
        {
            gvTheLoai.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvTheLoai.GetDataRow(gvTheLoai.FocusedRowHandle);
            MaTL = row[0].ToString();
            TenTL = row[1].ToString();
        }

        private void gvTheLoai_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvTheLoai.SetRowCellValue(e.RowHandle, "MaTL", "TL" + gvTheLoai.RowCount);
            gvTheLoai.SetRowCellValue(e.RowHandle, "NgayThanhLap", DateTime.Now.Date);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvTheLoai.AddNewRow();
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
                int r = gvTheLoai.FocusedRowHandle;

                string strTheLoai = gvTheLoai.GetRowCellValue(r, "MaTL").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbTL.XoaTheLoai(strTheLoai, ref err);
                    gvTheLoai.DeleteRow(gvTheLoai.FocusedRowHandle);
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
            gcTheLoai.MainView = lvTheLoai;
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
            gcTheLoai.MainView = gvTheLoai;
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
            System.Data.DataRow row = gvTheLoai.GetDataRow(gvTheLoai.FocusedRowHandle);
            if (them)
            {
                try
                {
                    BLTheLoai blTL = new BLTheLoai();

                    blTL.ThemTheLoai(MaTL, TenTL, ref err);

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
                    BLTheLoai blTL = new BLTheLoai();

                    blTL.CapNhatTheLoai(MaTL, TenTL, ref err);

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