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
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtSach = null;
        BLSach dbSach = new BLSach();

        DataTable dtNgonNguSach = null;
        BLNgonNguSach dbNgonNgu = new BLNgonNguSach();

        DataTable dtTacGia = null;
        BLTacGia dbTG = new BLTacGia();

        DataTable dtTheLoai = null;
        BLTheLoai dbTheLoai = new BLTheLoai();

        DataTable dtNhaXuatBan = null;
        BLNhaXuatBan dbNhaXuatBan = new BLNhaXuatBan();

        DataTable dtViTriSach = null;
        BLViTriSach dbVT = new BLViTriSach();
        

        bool them = false;
        string err;
        
        
       

        string MaSach = "";
        string TenSach = "";
        string MaNgonNgu = "";
        string MaNXB = "";
        string MaTG = "";
        string MaTL = "";
        string MaVT = "";
        string SoTrang = "";
        string SoLuong = "";        
        string NamNXB = "";
        string NgayNhapVe = "";
        decimal GiaSach = 0;
        PictureBox pic1 = new PictureBox();

        public frmSach()
        {
            InitializeComponent();
            gvSach.ShownEditor += gvSach_ShownEditor;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtSach = new DataTable();
                dtSach.Clear();
                DataSet dsSach = dbSach.LaySach();
                dtSach = dsSach.Tables[0];

                gcSach.DataSource = dtSach;

                dtNgonNguSach = new DataTable();
                dtNgonNguSach.Clear();
                DataSet dsNgonNguSach = dbNgonNgu.LayNgonNguSach();
                dtNgonNguSach = dsNgonNguSach.Tables[0];

                glueMaNgonNgu.DataSource = dtNgonNguSach;
                glueMaNgonNgu.DisplayMember = "MaNgonNgu";
                glueMaNgonNgu.ValueMember = "MaNgonNgu";

                dtTacGia = new DataTable();
                dtTacGia.Clear();
                DataSet dsTacGia = dbTG.LayTacGia();
                dtTacGia = dsTacGia.Tables[0];

                glueMaTG.DataSource = dtTacGia;
                glueMaTG.DisplayMember = "MaTG";
                glueMaTG.ValueMember = "MaTG";

                dtTheLoai = new DataTable();
                dtTheLoai.Clear();
                DataSet dsTheLoai = dbTheLoai.LayTheLoai();
                dtTheLoai = dsTheLoai.Tables[0];

                glueMaTL.DataSource = dtTheLoai;
                glueMaTL.DisplayMember = "MaTL";
                glueMaTL.ValueMember = "MaTL";

                dtNhaXuatBan = new DataTable();
                dtNhaXuatBan.Clear();
                DataSet dsNhaXuatBan = dbNhaXuatBan.LayNhaXuatBan();
                dtNhaXuatBan = dsNhaXuatBan.Tables[0];

                glueMaNXB.DataSource = dtNhaXuatBan;
                glueMaNXB.DisplayMember = "MaNXB";
                glueMaNXB.ValueMember = "MaNXB";

                dtViTriSach = new DataTable();
                dtViTriSach.Clear();
                DataSet dsViTriSach = dbVT.LayViTriSach();
                dtViTriSach = dsViTriSach.Tables[0];

                glueMaVT.DataSource = dtViTriSach;
                glueMaVT.DisplayMember = "MaVT";
                glueMaVT.ValueMember = "MaVT";



                them = false;

                MaSach = "";
                TenSach = "";
                MaTL = "";
                SoLuong = "";
                MaNXB = "";
                NamNXB = "";
                GiaSach = 0;
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
                XtraMessageBox.Show("Không lấy được nội dung trong table Sach. Lỗi rồi!!!");
            }
        }

        void gvSach_ShownEditor(object sender, EventArgs e)
        {
            gvSach.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvSach.GetDataRow(gvSach.FocusedRowHandle);
            MaSach = row[0].ToString();
            TenSach = row[1].ToString();
            MaNgonNgu = row[2].ToString();
            MaNXB = row[3].ToString();
            MaTG = row[4].ToString();
            MaTL = row[5].ToString();
            MaVT = row[6].ToString();
            SoTrang = row[7].ToString();
            SoLuong = row[8].ToString();
            try
            {
                NamNXB = Convert.ToDateTime(row[9].ToString()).ToString("MM/dd/yyyy");
            }
            catch
            {
                NamNXB = row[9].ToString();
            }
            try
            {
                GiaSach = decimal.Parse(row[10].ToString());
            }
            catch
            {
                GiaSach = 0;
            }
            try
            {
                NgayNhapVe = Convert.ToDateTime(row[12].ToString()).ToString("MM/dd/yyyy");
            }
            catch
            {
                NgayNhapVe = row[12].ToString();
            }
            try
            {
                pic1.BackgroundImageLayout = ImageLayout.Zoom;
                pic1.Image = byteArrayToImage((byte[])row[11]);
            }
            catch
            {
                pic1.Image = null;
                pic1.BackgroundImage = null;
            }
        }

        private void gvSach_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvSach.SetRowCellValue(e.RowHandle, "MaSach", "MSS" + gvSach.RowCount);
            gvSach.SetRowCellValue(e.RowHandle, "NamNXB", DateTime.Now.Date);
            gvSach.SetRowCellValue(e.RowHandle, "NgayNhapVe", DateTime.Now.Date);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvSach.AddNewRow();
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
                int r = gvSach.FocusedRowHandle;

                string strSach = gvSach.GetRowCellValue(r, "MaSach").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbSach.XoaSach(strSach, ref err);
                    gvSach.DeleteRow(gvSach.FocusedRowHandle);
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
            gcSach.MainView = lvSach;
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
            gcSach.MainView = gvSach;
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
                    BLSach blSach = new BLSach();
                    if (pic1.Image == null)
                    {
                        blSach.ThemSach(MaSach, TenSach, MaNgonNgu, MaNXB, MaTG, MaTL, MaVT, SoTrang, SoLuong, NamNXB, GiaSach, NgayNhapVe, null, ref err);
                    }
                    else
                    {
                        blSach.ThemSach(MaSach, TenSach, MaNgonNgu, MaNXB, MaTG, MaTL, MaVT, SoTrang, SoLuong, NamNXB, GiaSach, NgayNhapVe, imageToByteArray(pic1.Image), ref err);
                    }

                    LoadData();
                    XtraMessageBox.Show("Đã thêm xong!");
                    XtraMessageBox.Show(err);
                }
                catch
                {
                    XtraMessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLSach blSach = new BLSach();
                if (pic1.Image == null)
                {
                    blSach.CapNhatSach(MaSach, TenSach, MaNgonNgu, MaNXB, MaTG, MaTL, MaVT, SoTrang, SoLuong, NamNXB, GiaSach, NgayNhapVe, null, ref err);
                }
                else
                {
                    blSach.CapNhatSach(MaSach, TenSach, MaNgonNgu, MaNXB, MaTG, MaTL, MaVT, SoTrang, SoLuong, NamNXB, GiaSach, NgayNhapVe,imageToByteArray(pic1.Image), ref err);
                }
                XtraMessageBox.Show(err);
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