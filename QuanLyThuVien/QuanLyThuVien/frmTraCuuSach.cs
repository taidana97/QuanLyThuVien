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
    public partial class frmTraCuuSach : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtThongTinSach = null;
        DataTable dtLocSach_TheLoai = null;
        DataTable dtLocSach_NgonNgu = null;
        DataTable dtPinBooks = null;
        BLPinBooks dbPinBooks = new BLPinBooks();
        BLTraCuuSach dbTraCuuSach = new BLTraCuuSach();

        string Day = "";
        string Ke = "";
        string Ngan = "";
        string MaSach = "";

        public frmTraCuuSach()
        {
            InitializeComponent();
            gvTraCuuSach.ShownEditor += gvTraCuuSach_ShownEditor;
        }

        private void frmTraCuuSach_Load(object sender, EventArgs e)
        {
            LoadDataThongTinSach();
        }

        private void btnViTri_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoadDataPinBooks(MaSach);
            string strPinBooks = "Vị trí của sách ở dãy " + Day + " kệ " + Ke + " ngăn " + Ngan + ".";
            XtraMessageBox.Show(strPinBooks);
        }

        void LoadDataPinBooks(string MaThe)
        {
            try
            {
                dtPinBooks = new DataTable();
                dtPinBooks.Clear();
                DataSet dsPinBooks = dbPinBooks.LayViTriSach(MaThe);
                dtPinBooks = dsPinBooks.Tables[0];

                Day = dtPinBooks.Rows[0][1].ToString();
                Ke = dtPinBooks.Rows[0][2].ToString();               
                Ngan = dtPinBooks.Rows[0][3].ToString();               
            }
            catch
            {
                XtraMessageBox.Show("Không tìm thấy vị trí sách lỗi rồi!!!");
            }
        }

        void LoadDataThongTinSach()
        {
            try
            {
                dtThongTinSach = new DataTable();
                dtThongTinSach.Clear();
                DataSet dsThongTinSach = dbTraCuuSach.LayThongTinSach();
                dtThongTinSach = dsThongTinSach.Tables[0];

                gcTraCuuSach.DataSource = dtThongTinSach;
                
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table ThongTinSach. Lỗi rồi!!!");
            }
        }

        void LoadDataLocSach_TL(string MaTL)
        {
            try
            {
                dtLocSach_TheLoai = new DataTable();
                dtLocSach_TheLoai.Clear();
                DataSet ds = dbTraCuuSach.LayLocSach_TheLoai(MaTL);
                dtLocSach_TheLoai = ds.Tables[0];

                gcTraCuuSach.DataSource = dtLocSach_TheLoai;
            }
            catch
            {
                XtraMessageBox.Show("Không lọc sách thành công lỗi rồi!!!");
            }
        }

        void LoadDataLocSach_NN(string MaNgonNgu)
        {
            try
            {
                dtLocSach_NgonNgu = new DataTable();
                dtLocSach_NgonNgu.Clear();
                DataSet ds = dbTraCuuSach.LayLocSach_NgonNgu(MaNgonNgu);
                dtLocSach_NgonNgu = ds.Tables[0];

                gcTraCuuSach.DataSource = dtLocSach_NgonNgu;
            }
            catch
            {
                XtraMessageBox.Show("Không lọc sách không thành công lỗi rồi!!!");
            }
        }

        void gvTraCuuSach_ShownEditor(object sender, EventArgs e)
        {
            gvTraCuuSach.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }



        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow rowgv = gvTraCuuSach.GetDataRow(gvTraCuuSach.FocusedRowHandle);

            MaSach = rowgv[0].ToString();            
        }

        private void navTL1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL1");
        }

        private void navTL2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL2");
        }

        private void navTL3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL3");
        }

        private void navTL4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL4");
        }

        private void navTL5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL5");
        }

        private void navTL6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL6");
        }

        private void navTL7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL7");
        }

        private void navTL8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL8");
        }

        private void navTL9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL9");
        }

        private void navTL10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL10");
        }

        private void navTL11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL11");
        }

        private void navTL12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL12");
        }

        private void navTL13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL13");
        }

        private void navTL14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_TL("TL14");
        }

        private void navNN1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN1");
        }

        private void navNN2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN2");
        }

        private void navNN3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN3");
        }

        private void navNN4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN4");
        }

        private void navNN5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN5");
        }

        private void navNN6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN6");
        }

        private void navNN7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN7");
        }

        private void navNN8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN8");
        }

        private void navNN9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN9");
        }

        private void navNN10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataLocSach_NN("NN10");
        }

        private void navMacDinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDataThongTinSach();
        }

        private void navgvTraCuuSach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gcTraCuuSach.MainView = gvTraCuuSach;
        }

        private void navlvTraCuuSach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gcTraCuuSach.MainView = lvTraCuuSach;
        }
    }
}