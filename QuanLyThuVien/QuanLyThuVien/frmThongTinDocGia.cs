using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.SqlClient;
using QuanLyThuVien.BS_layer;

namespace QuanLyThuVien
{
    public partial class frmThongTinDocGia : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtDocGia = null;
        BLTraSach dbTraSach = new BLTraSach();

        string MaThe = "";

        public frmThongTinDocGia()
        {
            InitializeComponent();
        }

        private void btnMaThe_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.MaThe = btnMaThe.Text;
            LoadDataDocGia(this.MaThe);
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
            }
            catch
            {
                XtraMessageBox.Show("Không tìm thấy độc giả!!!");
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnMaThe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMaThe_ButtonClick(null, null);
            }
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

        }
    }
}