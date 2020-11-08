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
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtDocGia = null;
        bool them = false;
        string err;
        BLDocGia dbDG = new BLDocGia();

        string MaDG = "";
        string TenDG = "";
        bool GioiTinh = true;
        string NgaySinh = "";
        string CMND = "";
        string DiaChi = "";
        string SDT = "";
        PictureBox pic1 = new PictureBox();

        public frmDocGia()
        {
            InitializeComponent();
            gvDocGia.ShownEditor += gvDocGia_ShownEditor;
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtDocGia = new DataTable();
                dtDocGia.Clear();
                DataSet ds = dbDG.LayDocGia();
                dtDocGia = ds.Tables[0];

                gcDocGia.DataSource = dtDocGia;

                them = false;

                MaDG = "";
                TenDG = "";
                GioiTinh = true;
                NgaySinh = "";
                CMND = "";
                DiaChi = "";
                SDT = "";
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
                XtraMessageBox.Show("Không lấy được nội dung trong table DocGia. Lỗi rồi!!!");
            }
        }

        void gvDocGia_ShownEditor(object sender, EventArgs e)
        {
            gvDocGia.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvDocGia.GetDataRow(gvDocGia.FocusedRowHandle);
            MaDG = row[0].ToString();
            TenDG = row[1].ToString();
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
            DiaChi = row[5].ToString();
            SDT = row[6].ToString();
            try
            {
                pic1.BackgroundImageLayout = ImageLayout.Zoom;
                pic1.Image = byteArrayToImage((byte[])row[7]);
            }
            catch
            {
                pic1.Image = null;
                pic1.BackgroundImage = null;
            }
        }

        private void gvDocGia_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvDocGia.SetRowCellValue(e.RowHandle, "MaDG", "DG" + gvDocGia.RowCount);
            gvDocGia.SetRowCellValue(e.RowHandle, "NgaySinh", DateTime.Now.Date);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvDocGia.AddNewRow();
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
                int r = gvDocGia.FocusedRowHandle;

                string strDocGia = gvDocGia.GetRowCellValue(r, "MaDG").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbDG.XoaDocGia(strDocGia, ref err);
                    gvDocGia.DeleteRow(gvDocGia.FocusedRowHandle);
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
            gcDocGia.MainView = lvDocGia;
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
            gcDocGia.MainView = gvDocGia;
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
                    BLDocGia blDG = new BLDocGia();
                    if (pic1.Image == null)
                    {
                        blDG.ThemDocGia(MaDG, TenDG, GioiTinh, NgaySinh, CMND, DiaChi, SDT, null, ref err);
                    }
                    else
                    {
                        blDG.ThemDocGia(MaDG, TenDG, GioiTinh, NgaySinh, CMND, DiaChi, SDT, imageToByteArray(pic1.Image), ref err);
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
                BLDocGia blDG = new BLDocGia();
                if (pic1.Image == null)
                {
                    blDG.CapNhatDocGia(MaDG, TenDG, GioiTinh, NgaySinh, CMND, DiaChi, SDT, null, ref err);
                }
                else
                {
                    blDG.CapNhatDocGia(MaDG, TenDG, GioiTinh, NgaySinh, CMND, DiaChi, SDT, imageToByteArray(pic1.Image), ref err);
                }

                LoadData();

                XtraMessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoadData();
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
    }
}