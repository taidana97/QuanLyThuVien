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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtTacGia = null;
        bool them = false;
        string err;
        BLTacGia dbTG = new BLTacGia();

        string MaTG = "";
        string TenTG = "";
        string DiaChi = "";
        string SDT = "";
        string Email = "";

        public frmTacGia()
        {
            InitializeComponent();
            gvTacGia.ShownEditor += gvTacGia_ShownEditor;
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtTacGia = new DataTable();
                dtTacGia.Clear();
                DataSet ds = dbTG.LayTacGia();
                dtTacGia = ds.Tables[0];

                gcTacGia.DataSource = dtTacGia;

                them = false;

                MaTG = "";
                TenTG = "";
                DiaChi = "";
                SDT = "";
                Email = "";

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table TacGia. Lỗi rồi!!!");
            }
        }

        void gvTacGia_ShownEditor(object sender, EventArgs e)
        {
            gvTacGia.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvTacGia.GetDataRow(gvTacGia.FocusedRowHandle);
            MaTG = row[0].ToString();
            TenTG = row[1].ToString();
            DiaChi = row[2].ToString();
            SDT = row[3].ToString();
            Email = row[4].ToString();
        }

        private void gvTacGia_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvTacGia.SetRowCellValue(e.RowHandle, "MaTG", "TG" + gvTacGia.RowCount);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvTacGia.AddNewRow();
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
                int r = gvTacGia.FocusedRowHandle;

                string strTacGia = gvTacGia.GetRowCellValue(r, "MaTG").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbTG.XoaTacGia(strTacGia, ref err);
                    gvTacGia.DeleteRow(gvTacGia.FocusedRowHandle);
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
            gcTacGia.MainView = lvTacGia;
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
            gcTacGia.MainView = gvTacGia;
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
                    BLTacGia blTG = new BLTacGia();

                    blTG.ThemTacGia(MaTG, TenTG, DiaChi, SDT, Email, ref err);

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
                    BLTacGia blTG = new BLTacGia();

                    blTG.CapNhatTacGia(MaTG, TenTG, DiaChi, SDT, Email, ref err);

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