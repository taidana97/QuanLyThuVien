using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;

namespace QuanLyThuVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public static bool bIsLogin = false;
        string Quyen = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNhanVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            this.btnChiTietPhieuMuon.Enabled = false;
            this.btnNhanVien.Enabled =false;
            this.btnNhaXuatBan.Enabled = false;
            this.btnDocGia.Enabled = false;
            this.btnSach.Enabled = false;
            this.btnThe.Enabled = false;
            this.btnTheLoai.Enabled = false;
            this.btnDoiMatKhau.Enabled = false;
            this.btnViTriSach.Enabled = false;
            this.btnNgonNguSach.Enabled = false;
            this.btnTaiKhoan.Enabled = false;
            this.btnTacGia.Enabled = false;

            this.btnInTheDocGia.Enabled = false;
            this.btnPhieuMuon.Enabled = false;
            this.btnPhieuTra.Enabled = false;

            this.btnMuonSach.Enabled = false;
            this.btnTraSach.Enabled = false;
        }

        private void btnNhaXuatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNhaXuatBan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhaXuatBan f = new frmNhaXuatBan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTheLoai));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTheLoai f = new frmTheLoai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmSach));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSach f = new frmSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDocGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDocGia f = new frmDocGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmThe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThe f = new frmThe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChiTietPhieuMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmChiTietPhieuMuon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmChiTietPhieuMuon f = new frmChiTietPhieuMuon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap login = new frmDangNhap();
            login.ShowDialog();
            if (frmMain.bIsLogin == true)
            {
                btnDangXuat.Enabled = true;
                btnDoiMatKhau.Enabled = true;
                barHeaderTenDangNhap.Caption = "Tên đăng nhập: " + frmDangNhap.strTenDangNhap;
                btnLogin.Enabled = false;
                Quyen = frmDangNhap.strQuyen;
                if (Quyen.Trim() == "ad")
                {
                    this.btnChiTietPhieuMuon.Enabled = true;
                    this.btnNhanVien.Enabled = true;
                    this.btnNhaXuatBan.Enabled = true;
                    this.btnDocGia.Enabled = true;
                    this.btnSach.Enabled = true;
                    this.btnThe.Enabled = true;
                    this.btnTheLoai.Enabled = true;
                    this.btnViTriSach.Enabled = true;
                    this.btnNgonNguSach.Enabled = true;
                    this.btnTaiKhoan.Enabled = true;
                    this.btnTacGia.Enabled = true;

                    this.btnInTheDocGia.Enabled = true;
                    this.btnPhieuMuon.Enabled = true;
                    this.btnPhieuTra.Enabled = true;

                    this.btnMuonSach.Enabled = true;
                    this.btnTraSach.Enabled = true;
                }
                else
                {                   
                    this.btnDocGia.Enabled = true;
                    this.btnSach.Enabled = true;
                    this.btnThe.Enabled = true;
                    this.btnTheLoai.Enabled = true;
                    this.btnViTriSach.Enabled = true;
                    this.btnNgonNguSach.Enabled = true;
                    this.btnTacGia.Enabled = true;
                    this.btnNhaXuatBan.Enabled = true;

                    this.btnInTheDocGia.Enabled = true;
                    this.btnPhieuMuon.Enabled = true;
                    this.btnPhieuTra.Enabled = true;

                    this.btnMuonSach.Enabled = true;
                    this.btnTraSach.Enabled = true;
                }
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DialogResult traloi;
            //traloi = XtraMessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (traloi == DialogResult.OK)
            //{
            btnLogin.Enabled = true;
            btnDoiMatKhau.Enabled = false;

            this.btnChiTietPhieuMuon.Enabled = false;
            this.btnNhanVien.Enabled = false;
            this.btnNhaXuatBan.Enabled = false;
            this.btnDocGia.Enabled = false;
            this.btnSach.Enabled = false;
            this.btnThe.Enabled = false;
            this.btnTheLoai.Enabled = false;
            this.btnDoiMatKhau.Enabled = false;
            this.btnViTriSach.Enabled = false;
            this.btnNgonNguSach.Enabled = false;
            this.btnTaiKhoan.Enabled = false;
            this.btnTacGia.Enabled = false;

            this.btnInTheDocGia.Enabled = false;
            this.btnPhieuMuon.Enabled = false;
            this.btnPhieuTra.Enabled = false;

            this.btnMuonSach.Enabled = false;
            this.btnTraSach.Enabled = false;

            this.btnDoiMatKhau.Enabled = false;
            barHeaderTenDangNhap.Caption = "";
        }

        private void btnTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTacGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTacGia f = new frmTacGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNgonNguSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNgonNguSach));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNgonNguSach f = new frmNgonNguSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViTriSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmViTriSach));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmViTriSach f = new frmViTriSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTaiKhoan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau login = new frmDoiMatKhau();
            login.ShowDialog();
        }

        private void btnMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmMuonSach));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMuonSach f = new frmMuonSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTraSach));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTraSach f = new frmTraSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmRPPhieuMuon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmRPPhieuMuon f = new frmRPPhieuMuon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmRPPhieuTra));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmRPPhieuTra f = new frmRPPhieuTra();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmRPTheDocGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmRPTheDocGia f = new frmRPTheDocGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTraCuuSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTraCuuSach));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTraCuuSach f = new frmTraCuuSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath))
        }

        private void btnViewDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinDocGia login = new frmThongTinDocGia();
            login.ShowDialog();
        }
    }
}
