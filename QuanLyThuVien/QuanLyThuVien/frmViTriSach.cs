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
    public partial class frmViTriSach : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtViTriSach = null;
        bool them = false;
        string err;
        BLViTriSach dbVT = new BLViTriSach();

        string MaVT = "";
        string Day = "";
        string Ke = "";
        string Ngan = "";

        public frmViTriSach()
        {
            InitializeComponent();
            gvViTriSach.ShownEditor += gvViTriSach_ShownEditor;
        }

        private void frmViTriSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtViTriSach = new DataTable();
                dtViTriSach.Clear();
                DataSet ds = dbVT.LayViTriSach();
                dtViTriSach = ds.Tables[0];

                gcViTriSach.DataSource = dtViTriSach;

                them = false;

                MaVT = "";
                Day = "";
                Ke = "";
                Ngan = "";

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table ViTriSach. Lỗi rồi!!!");
            }
        }

        void gvViTriSach_ShownEditor(object sender, EventArgs e)
        {
            gvViTriSach.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvViTriSach.GetDataRow(gvViTriSach.FocusedRowHandle);
            MaVT = row[0].ToString();
            Day = row[1].ToString();
            Ke = row[2].ToString();
            Ngan = row[3].ToString();
        }

        private void gvViTriSach_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvViTriSach.SetRowCellValue(e.RowHandle, "MaVT", "VT" + gvViTriSach.RowCount);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvViTriSach.AddNewRow();
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
                int r = gvViTriSach.FocusedRowHandle;

                string strViTriSach = gvViTriSach.GetRowCellValue(r, "MaVT").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbVT.XoaViTriSach(strViTriSach, ref err);
                    gvViTriSach.DeleteRow(gvViTriSach.FocusedRowHandle);
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
            gcViTriSach.MainView = lvViTriSach;
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
            gcViTriSach.MainView = gvViTriSach;
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
                    BLViTriSach blVT = new BLViTriSach();

                    blVT.ThemViTriSach(MaVT, Day, Ke, Ngan, ref err);

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
                    BLViTriSach blVT = new BLViTriSach();

                    blVT.CapNhatViTriSach(MaVT, Day, Ke, Ngan, ref err);

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