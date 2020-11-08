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
    public partial class frmTraSach : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtTraSach = null;
        DataTable dtDocGia = null;
        BLTraSach dbTraSach = new BLTraSach();

        string err = "";
        string MaThe = "";
        string STT = "";
        string TinhTrangSach = "";
        bool kiemTra = false;
        DateTime ngayTra = new DateTime();

        public frmTraSach()
        {
            InitializeComponent();
            gvTraSach.ShownEditor += gvTraSach_ShownEditor;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            ngayTra = DateTime.Now.Date;
            LoadDataSach(btnMaThe.Text);
            btnMaThe.Enabled = false;
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
                DataSet dsDocGia = dbTraSach.LayThongTinDocGia(MaThe);
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

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        void LoadDataSach(string MaThe)
        {
            try
            {
                dtTraSach = new DataTable();
                dtTraSach.Clear();
                DataSet dsTraSach = dbTraSach.LayTraSach(MaThe);
                dtTraSach = dsTraSach.Tables[0];

                gcTraSach.DataSource = dtTraSach;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Thẻ không hợp lệ !!!");
            }
        }

        private void btnTraSach_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ngayTra = DateTime.Now.Date;
            try
            {
                BLTraSach blTraSach = new BLTraSach();

                blTraSach.suaTraSach(STT, ngayTra.ToString("MM/dd/yyyy"), TinhTrangSach, frmDangNhap.strTenDangNhap, ref err);

                LoadDataSach(btnMaThe.Text);
                XtraMessageBox.Show(err);

            }
            catch
            {

                XtraMessageBox.Show("Không trả được. Lỗi rồi!");
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

        void gvTraSach_ShownEditor(object sender, EventArgs e)
        {
            gvTraSach.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }


        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow rowgv = gvTraSach.GetDataRow(gvTraSach.FocusedRowHandle);

            STT = rowgv[0].ToString();
            TinhTrangSach = rowgv[7].ToString();

            if (TinhTrangSach == "Bình thường")
            {
                TinhTrangSach = "B";
            }
            else
            {
                if (TinhTrangSach == "Hư")
                {
                    TinhTrangSach = "H";
                }
                else
                {
                    TinhTrangSach = "M";
                }
            }
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            btnKiemTra.Enabled = false;
            btnLockThe.Enabled = false;
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

            gcTraSach.DataSource = null;

            btnMaThe.Enabled = true;
            btnLockThe.Enabled = false;
            btnKiemTra.Enabled = false;
        }
    }
}