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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtNhanVien = null;
        bool them = false;
        string err;
        BLNhanVien dbNV = new BLNhanVien();

        string MaNV = "";
        string TenNV = "";
        bool GioiTinh = true;
        string NgaySinh = "";
        string CMND = "";
        string DiaChi = "";
        string SDT = "";
        string NgayNhapLam = "";
        PictureBox pic1 = new PictureBox();

        public frmNhanVien()
        {
            InitializeComponent();
            gvNhanVien.ShownEditor += gvNhanVien_ShownEditor;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {            
            try
            {
                dtNhanVien= new DataTable();
                dtNhanVien.Clear();
                DataSet ds = dbNV.LayNhanVien();
                dtNhanVien= ds.Tables[0];

                gcNhanVien.DataSource = dtNhanVien;

                them = false;

                MaNV = "";
                TenNV = "";
                GioiTinh = true;
                NgaySinh = "";
                CMND = "";
                DiaChi = "";
                SDT = "";
                NgayNhapLam = "";
                this.pic1.Image = null;
                this.pic1.BackgroundImage = null;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvNhanVien.AddNewRow();
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
                int r = gvNhanVien.FocusedRowHandle;

                string strNhanVien = gvNhanVien.GetRowCellValue(r, "MaNV").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbNV.XoaNhanVien(strNhanVien, ref err);
                    gvNhanVien.DeleteRow(gvNhanVien.FocusedRowHandle);
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
            gcNhanVien.MainView = lvNhanVien;
            this.gclLuu.OptionsColumn.AllowEdit = false;
            this.gclHuy.OptionsColumn.AllowEdit = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnRefresh.Enabled = false;
            this.btnInfor.Enabled = false;

            this.btnTable.Enabled = true;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void gvNhanVien_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvNhanVien.SetRowCellValue(e.RowHandle, "MaNV", "NV" + gvNhanVien.RowCount);
            gvNhanVien.SetRowCellValue(e.RowHandle, "NgaySinh", DateTime.Now.Date);
            gvNhanVien.SetRowCellValue(e.RowHandle, "NgayNhapLam", DateTime.Now.Date);
        }

        void gvNhanVien_ShownEditor(object sender, EventArgs e)
        {
            gvNhanVien.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvNhanVien.GetDataRow(gvNhanVien.FocusedRowHandle);
            MaNV = row[0].ToString();
            TenNV = row[1].ToString();
            try
            {
                NgaySinh = Convert.ToDateTime(row[3].ToString()).ToString("MM/dd/yyyy");
            }
            catch
            {
                NgaySinh = row[3].ToString();
            }
            if (row[2].ToString() == "Nam")
            {
                GioiTinh = true;
            }
            else
            {
                GioiTinh = false;
            }
            CMND = row[4].ToString();
            DiaChi= row[5].ToString();
            SDT = row[6].ToString();
            try
            {
                NgayNhapLam = (Convert.ToDateTime(row[7].ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                NgayNhapLam = row[7].ToString();
            }
            try
            {
                pic1.BackgroundImageLayout = ImageLayout.Zoom;
                pic1.Image = byteArrayToImage((byte[])row[8]);
            }
            catch
            {
                pic1.Image = null;
                pic1.BackgroundImage = null;
            }
        }

        private void btnLuu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (them)
            {
                try
                {
                    BLNhanVien blNV = new BLNhanVien();
                    if (pic1.Image == null)
                    {
                        blNV.ThemNhanVien(MaNV, TenNV, GioiTinh, NgaySinh, CMND, DiaChi, SDT, NgayNhapLam, null, ref err);
                    }
                    else
                    {
                        blNV.ThemNhanVien(MaNV, TenNV, GioiTinh, NgaySinh, CMND, DiaChi, SDT, NgayNhapLam, imageToByteArray(pic1.Image), ref err);
                    }

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
                BLNhanVien blNV = new BLNhanVien();
                if (pic1.Image == null)
                {
                    blNV.CapNhatNhanVien(MaNV, TenNV, GioiTinh, NgaySinh, CMND, DiaChi, SDT, NgayNhapLam, null, ref err);
                }
                else
                {
                    blNV.CapNhatNhanVien(MaNV, TenNV, GioiTinh, NgaySinh, CMND, DiaChi, SDT, NgayNhapLam, imageToByteArray(pic1.Image), ref err);
                }

                LoadData();

                XtraMessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {         
            LoadData();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            gcNhanVien.MainView = gvNhanVien;
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
    }
}