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
    public partial class frmChiTietPhieuMuon : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtChiTietPhieuMuon = null;
        DataTable dtThe = null;
        DataTable dtSach = null;
        bool them = false;
        string err;
        BLChiTietPhieuMuon dbChiTietPhieuMuon = new BLChiTietPhieuMuon();
        BLThe dbThe = new BLThe();
        BLSach dbSach = new BLSach();

        string STT = "";
        string MaThe = "";
        string MaSach = "";
        string SoPhieu = "";
        string NgayMuon = "";
        string NgayHenTra = "";
        string NgayTra = "";
        string TinhTrangSach = "";
        decimal TienPhat = 0;

        public frmChiTietPhieuMuon()
        {
            InitializeComponent();
            gvChiTietPhieuMuon.ShownEditor += gvChiTietPhieuMuon_ShownEditor;
        }

        private void frmChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtChiTietPhieuMuon = new DataTable();
                dtChiTietPhieuMuon.Clear();
                DataSet dsChiTietPhieuMuon = dbChiTietPhieuMuon.LayChiTietPhieuMuon();
                dtChiTietPhieuMuon = dsChiTietPhieuMuon.Tables[0];

                gcChiTietPhieuMuon.DataSource = dtChiTietPhieuMuon;

                dtThe = new DataTable();
                dtThe.Clear();
                DataSet dsThe = dbThe.LayThe();
                dtThe = dsThe.Tables[0];

                glueMaThe.DataSource = dtThe;
                glueMaThe.DisplayMember = "MaThe";
                glueMaThe.ValueMember = "MaThe";

                dtSach = new DataTable();
                dtSach.Clear();
                DataSet dsSach = dbSach.LaySach();
                dtSach = dsSach.Tables[0];

                glueMaSach.DataSource = dtSach;
                glueMaSach.DisplayMember = "MaSach";
                glueMaSach.ValueMember = "MaSach";

                them = false;

                STT = "";
                MaThe = "";
                MaSach = "";
                SoPhieu = "";
                NgayMuon = "";
                NgayHenTra = "";
                NgayTra = "";
                TinhTrangSach = "";
                TienPhat = 0;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table ChiTietPhieuMuon. Lỗi rồi!!!");
            }
        }

        void gvChiTietPhieuMuon_ShownEditor(object sender, EventArgs e)
        {
            gvChiTietPhieuMuon.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvChiTietPhieuMuon.GetDataRow(gvChiTietPhieuMuon.FocusedRowHandle);
            STT = row[0].ToString();
            MaThe = row[1].ToString();
            MaSach = row[2].ToString();
            SoPhieu = row[3].ToString();
            try
            {
                NgayMuon = (Convert.ToDateTime(row[4].ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                NgayMuon = row[4].ToString();
            }
            try
            {
                NgayHenTra = (Convert.ToDateTime(row[5].ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                NgayHenTra = row[5].ToString();
            }
            try
            {
                NgayTra = (Convert.ToDateTime(row[6].ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                NgayTra = row[6].ToString();
            }
            TinhTrangSach = row[7].ToString();
            try
            {
                TienPhat = decimal.Parse(row[8].ToString());
            }
            catch
            {
                TienPhat = 0;
            }
        }

        private void gvChiTietPhieuMuon_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvChiTietPhieuMuon.SetRowCellValue(e.RowHandle, "STT", gvChiTietPhieuMuon.RowCount);
            gvChiTietPhieuMuon.SetRowCellValue(e.RowHandle, "NgayMuon", DateTime.Now.Date);
            gvChiTietPhieuMuon.SetRowCellValue(e.RowHandle, "NgayHenTra", DateTime.Now.Date.AddMonths(2));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvChiTietPhieuMuon.AddNewRow();
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
                int r = gvChiTietPhieuMuon.FocusedRowHandle;

                string strChiTietPhieuMuon = gvChiTietPhieuMuon.GetRowCellValue(r, "STT").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbChiTietPhieuMuon.XoaChiTietPhieuMuon(strChiTietPhieuMuon, ref err);
                    gvChiTietPhieuMuon.DeleteRow(gvChiTietPhieuMuon.FocusedRowHandle);
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
            gcChiTietPhieuMuon.MainView = lvChiTietPhieuMuon;
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
            gcChiTietPhieuMuon.MainView = gvChiTietPhieuMuon;
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
                    BLChiTietPhieuMuon blChiTietPhieuMuon = new BLChiTietPhieuMuon();

                    blChiTietPhieuMuon.ThemChiTietPhieuMuon(STT, MaThe, MaSach, SoPhieu, NgayMuon, NgayHenTra, NgayTra, TinhTrangSach, TienPhat, ref err);

                    LoadData();

                    XtraMessageBox.Show(err);

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
                    BLChiTietPhieuMuon blChiTietPhieuMuon = new BLChiTietPhieuMuon();

                    blChiTietPhieuMuon.CapNhatChiTietPhieuMuon(STT, MaThe, MaSach, SoPhieu, NgayMuon, NgayHenTra, NgayTra, TinhTrangSach, TienPhat, ref err);

                    LoadData();

                    XtraMessageBox.Show("Đã sửa xong!");
                }
                catch
                {
                    XtraMessageBox.Show("Không sữa được. Lỗi rồi!");
                }
            }
        }

        private void btnHuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoadData();
        }        
    }
}