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
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtDangNhap = null;
        bool them = false;
        string err;
        BLQLDangNhap dbID = new BLQLDangNhap();

        DataTable dtNhanVien = null;
        BLNhanVien dbNV = new BLNhanVien();

        string ID = "";
        string PASS = "";
        string Quyen = "";

        public frmTaiKhoan()
        {
            InitializeComponent();
            gvDangNhap.ShownEditor += gvDangNhap_ShownEditor;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtDangNhap = new DataTable();
                dtDangNhap.Clear();
                DataSet dsDN = dbID.LayQLDangNhap();
                dtDangNhap = dsDN.Tables[0];

                gcDangNhap.DataSource = dtDangNhap;

                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                DataSet dsNV = dbNV.LayNhanVien();
                dtNhanVien = dsNV.Tables[0];

                glueID.DataSource = dtNhanVien;
                glueID.DisplayMember = "MaNV";
                glueID.ValueMember = "MaNV";

                them = false;

                ID = "";
                PASS = "";
                Quyen = "";

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table DangNhap. Lỗi rồi!!!");
            }
        }

        void gvDangNhap_ShownEditor(object sender, EventArgs e)
        {
            gvDangNhap.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvDangNhap.GetDataRow(gvDangNhap.FocusedRowHandle);
            ID = row[0].ToString();
            PASS = row[1].ToString();
            Quyen = row[2].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvDangNhap.AddNewRow();
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
                int r = gvDangNhap.FocusedRowHandle;

                string strDangNhap = gvDangNhap.GetRowCellValue(r, "ID").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbID.XoaQLDangNhap(strDangNhap, ref err);
                    gvDangNhap.DeleteRow(gvDangNhap.FocusedRowHandle);
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
            gcDangNhap.MainView = lvDangNhap;
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
            gcDangNhap.MainView = gvDangNhap;
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
                    BLQLDangNhap blID = new BLQLDangNhap();

                    blID.ThemQLDangNhap(ID, PASS, Quyen, ref err);

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
                try
                {
                    BLQLDangNhap blID = new BLQLDangNhap();

                    blID.CapNhatQLDangNhap(ID, PASS, Quyen, ref err);

                    LoadData();

                    XtraMessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoadData();
        }
    }
}