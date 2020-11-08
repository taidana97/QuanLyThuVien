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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        string err;

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            BLDangNhap blPassOld = new BLDangNhap();

            string strLayPassOld = blPassOld.layPassOld(frmDangNhap.strTenDangNhap, ref err);
            if (frmMain.bIsLogin == true)
            {
                if (txtPassOld.Text.Trim() == strLayPassOld.Trim())
                {
                    if (txtPassNew.Text == txtRePassNew.Text)
                    {
                        BLDangNhap blQL = new BLDangNhap();
                        blQL.DoiMatKhauDangNhap(frmDangNhap.strTenDangNhap, txtPassNew.Text, ref err);

                        lbThongBao.Text = "Bạn đã đổi mật khẩu thành công!";
                        txtPassOld.ResetText();
                        txtPassNew.ResetText();
                        txtRePassNew.ResetText();
                    }
                    else
                    {
                        lbThongBao.Text = "Mật khẩu mới và gõ lại mật khẩu mới không\ntrùng khớp";
                    }

                }
                else
                {
                    lbThongBao.Text = "Mật khẩu cũ sai";
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassOld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau_Click(null, null);
            }
        }
    }
}