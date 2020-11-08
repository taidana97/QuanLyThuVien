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
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtMuonSach = null;
        DataTable dtDocGia = null;
        BLMuonSach dbMuonSach = new BLMuonSach();

        string err = "";
        string MaThe = "";
        string MaSach = "";
        bool kiemTra = false;
        DateTime ngayHienTai = new DateTime();
        DateTime ngayHenTra = new DateTime();

        public frmMuonSach()
        {
            InitializeComponent();
            gvMuonSach.ShownEditor += gvMuonSach_ShownEditor;
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            btnKiemTra.Enabled = false;
            btnLockThe.Enabled = false;
        }

        private void btnMaThe_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.MaThe = btnMaThe.Text;
            LoadDataDocGia(this.MaThe);
            if (kiemTra == true)
            {
                btnKiemTra.Enabled = true;
                btnLockThe.Enabled = true;
            }
        }
        void LoadDataDocGia(string MaThe)
        {
            try
            {
                dtDocGia = new DataTable();
                dtDocGia.Clear();
                DataSet dsDocGia = dbMuonSach.LayThongTinDocGia(MaThe);
                dtDocGia = dsDocGia.Tables[0];

                txtTenDG.Text = dtDocGia.Rows[0][1].ToString();
                if (dtDocGia.Rows[0][2].ToString() == "True")
                {
                    rdoGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    rdoGioiTinh.SelectedIndex = 1;
                }               
                dateNgaySinh.Text = dtDocGia.Rows[0][3].ToString();
                txtCMND.Text = dtDocGia.Rows[0][4].ToString();
                txtDiaChi.Text = dtDocGia.Rows[0][5].ToString();
                txtSDT.Text = dtDocGia.Rows[0][6].ToString();
                try
                {
                    picHinh.BackgroundImageLayout = ImageLayout.Zoom;
                    picHinh.Image = byteArrayToImage((byte[])dtDocGia.Rows[0][7]);
                }
                catch
                {
                    picHinh.Image = null;
                    picHinh.BackgroundImage = null;
                }
                dateNgayLapThe.Text = dtDocGia.Rows[0][8].ToString();
                dateNgayHetHan.Text = dtDocGia.Rows[0][9].ToString();
                kiemTra = true;
            }
            catch 
            {
                XtraMessageBox.Show("Không tìm thấy độc giả!!!");

                kiemTra = false;
            }
        }

        void LoadDataSach(string MaThe, string NgayHienTai)
        {
            try
            {
                dtMuonSach = new DataTable();
                dtMuonSach.Clear();
                DataSet dsSach = dbMuonSach.LayMuonSach(MaThe, NgayHienTai);
                dtMuonSach = dsSach.Tables[0];

                gcMuonSach.DataSource = dtMuonSach;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Thẻ không hợp lệ hoặc đã hết hạn sữ dụng!!!");
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            ngayHienTai = DateTime.Now.Date;
            LoadDataSach(btnMaThe.Text, ngayHienTai.ToString("MM/dd/yyyy"));
            btnMaThe.Enabled = false;
        }

        private void btnLockThe_Click(object sender, EventArgs e)
        {
            btnMaThe.ResetText();
            txtTenDG.ResetText();
            dateNgaySinh.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            dateNgayLapThe.ResetText();
            dateNgayHetHan.ResetText();
            picHinh.Image = null;
            picHinh.BackgroundImage = null;

            gcMuonSach.DataSource = null;

            btnMaThe.Enabled = true;
            btnLockThe.Enabled = false;
            btnKiemTra.Enabled = false;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (gcMuonSach.MainView == gvMuonSach)
            {
                gcMuonSach.MainView = lvMuonSach;
            }
            else
            {
                gcMuonSach.MainView = gvMuonSach;
            }
        }

        private void btnMuon_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ngayHenTra = DateTime.Now.Date.AddMonths(2);
            try
            {
                BLMuonSach blMuonSach = new BLMuonSach();

                blMuonSach.ThemMuonSach(btnMaThe.Text.Trim(), MaSach, ngayHienTai.ToString("ddMMyyyy") + btnMaThe.Text, ngayHienTai.ToString("MM/dd/yyyy"), ngayHenTra.ToString("MM/dd/yyyy"), frmDangNhap.strTenDangNhap,ref err);


                XtraMessageBox.Show(err);

                LoadDataSach(btnMaThe.Text, ngayHienTai.ToString("MM/dd/yyyy"));
            }
            catch
            {

                XtraMessageBox.Show("Không mượn được. Lỗi rồi!");
            }
        }

        private void btnMaThe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMaThe_ButtonClick(null, null);
                btnKiemTra_Click(null, null);
            }
        }

        void gvMuonSach_ShownEditor(object sender, EventArgs e)
        {
            gvMuonSach.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }


        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow rowgv = gvMuonSach.GetDataRow(gvMuonSach.FocusedRowHandle);

            MaSach = rowgv[0].ToString(); 
        }
    }
}