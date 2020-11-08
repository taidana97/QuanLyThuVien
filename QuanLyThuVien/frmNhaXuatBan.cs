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
    public partial class frmNhaXuatBan : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtNhaXuatBan = null;
        bool them = false;
        string err;
        BLNhaXuatBan dbNXB = new BLNhaXuatBan();

        string MaNXB = "";
        string TenNXB = "";
        string DiaChi = "";
        string SDT = "";
        string NgayThanhLap = "";

        public frmNhaXuatBan()
        {
            InitializeComponent();
            gvNhaXuatBan.ShownEditor += gvNhaXuatBan_ShownEditor;
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtNhaXuatBan = new DataTable();
                dtNhaXuatBan.Clear();
                DataSet ds = dbNXB.LayNhaXuatBan();
                dtNhaXuatBan = ds.Tables[0];

                gcNhaXuatBan.DataSource = dtNhaXuatBan;

                them = false;

                MaNXB = "";
                TenNXB = "";
                DiaChi = "";
                SDT = "";
                NgayThanhLap = "";

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table NhaXuatBan. Lỗi rồi!!!");
            }
        }

        void gvNhaXuatBan_ShownEditor(object sender, EventArgs e)
        {
            gvNhaXuatBan.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvNhaXuatBan.GetDataRow(gvNhaXuatBan.FocusedRowHandle);
            MaNXB = row[0].ToString();
            TenNXB = row[1].ToString();
            DiaChi = row[2].ToString();
            SDT = row[3].ToString();
            try
            {
                NgayThanhLap = (Convert.ToDateTime(row[4].ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                NgayThanhLap = row[4].ToString();
            }
        }

        private void gvNhaXuatBan_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvNhaXuatBan.SetRowCellValue(e.RowHandle, "MaNXB", "NXB" + gvNhaXuatBan.RowCount);
            gvNhaXuatBan.SetRowCellValue(e.RowHandle, "NgayThanhLap", DateTime.Now.Date);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvNhaXuatBan.AddNewRow();
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
                int r = gvNhaXuatBan.FocusedRowHandle;

                string strNhaXuatBan = gvNhaXuatBan.GetRowCellValue(r, "MaNXB").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbNXB.XoaNhaXuatBan(strNhaXuatBan, ref err);
                    gvNhaXuatBan.DeleteRow(gvNhaXuatBan.FocusedRowHandle);
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
            gcNhaXuatBan.MainView = lvNhaXuatBan;
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
            gcNhaXuatBan.MainView = gvNhaXuatBan;
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
                    BLNhaXuatBan blNXB = new BLNhaXuatBan();

                    blNXB.ThemNhaXuatBan(MaNXB, TenNXB, DiaChi, SDT, NgayThanhLap, ref err);

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
                    BLNhaXuatBan blNXB = new BLNhaXuatBan();

                    blNXB.CapNhatNhaXuatBan(MaNXB, TenNXB, DiaChi, SDT, NgayThanhLap, ref err);

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