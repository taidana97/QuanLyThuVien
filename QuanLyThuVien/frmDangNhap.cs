using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyThuVien.BS_layer;

namespace QuanLyThuVien
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        string err;
        public static string strTenDangNhap = "";
        public static string strQuyen = "";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BLDangNhap blDN = new BLDangNhap();
            int value = blDN.DangNhapQuanLy(this.txtID.Text.Trim(), this.txtPASS.Text.Trim(), ref err);
            string Quyen = blDN.LayQuyenTruyCap(this.txtID.Text.Trim(), this.txtPASS.Text.Trim(), ref err);
            if (value == 1)
            {
                frmMain.bIsLogin = true;
                strTenDangNhap = txtID.Text.Trim();
                strQuyen = Quyen;
                Close();
            }
            else
            {
                XtraMessageBox.Show("Không đúng tên người dùng / mật khẩu !!!",
                    "Thông báo");
                this.txtID.Focus();
            }
        }

        private void btnReHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(null, null);
            }
        }

        private void txtPASS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(null, null);
            }
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "Username")
            {
                txtID.ResetText();
            }
            if (txtPASS.Text.Trim() == "")
            {
                txtPASS.Properties.UseSystemPasswordChar = false;
                txtPASS.Text = "Password";
            }
        }

        private void txtPASS_Click(object sender, EventArgs e)
        {
            if (txtPASS.Text == "Password")
            {
                txtPASS.ResetText();
            }
            txtPASS.Properties.UseSystemPasswordChar = true;
            if (txtID.Text.Trim() == "")
            {

                txtID.Text = "Username";
            }
        }
    }
}