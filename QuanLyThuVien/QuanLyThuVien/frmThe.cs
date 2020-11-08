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
    public partial class frmThe : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtThe = null;
        DataTable dtDocGia = null;
        bool them = false;
        string err;
        BLThe dbThe = new BLThe();
        BLDocGia dbDocGia = new BLDocGia();

        string MaThe = "";
        string MaDG = "";
        string NgayLapThe = "";
        string NgayHetHan = "";

        public frmThe()
        {
            InitializeComponent();
            gvThe.ShownEditor += gvThe_ShownEditor;
        }

        private void frmThe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtThe = new DataTable();
                dtThe.Clear();
                DataSet dsThe = dbThe.LayThe();
                dtThe = dsThe.Tables[0];

                gcThe.DataSource = dtThe;

                dtDocGia = new DataTable();
                dtDocGia.Clear();
                DataSet dsDocGia = dbDocGia.LayDocGia();
                dtDocGia = dsDocGia.Tables[0];

                glueMaDG.DataSource = dtDocGia;
                glueMaDG.DisplayMember = "MaDG";
                glueMaDG.ValueMember = "MaDG";

                them = false;

                MaThe = "";
                MaDG = "";
                NgayLapThe = "";
                NgayHetHan = "";

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnInfor.Enabled = true;
                this.btnTable.Enabled = true;
                this.btnTroVe.Enabled = true;

                this.btnTable.Enabled = false;
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table The. Lỗi rồi!!!");
            }
        }

        void gvThe_ShownEditor(object sender, EventArgs e)
        {
            gvThe.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {
            System.Data.DataRow row = gvThe.GetDataRow(gvThe.FocusedRowHandle);
            MaThe = row[0].ToString();
            MaDG = row[1].ToString();
            try
            {
                NgayLapThe = (Convert.ToDateTime(row[2].ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                NgayLapThe = row[2].ToString();
            }
            try
            {
                NgayHetHan = (Convert.ToDateTime(row[3].ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                NgayHetHan = row[3].ToString();
            }
        }

        private void gvThe_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvThe.SetRowCellValue(e.RowHandle, "MaThe", "The" + gvThe.RowCount);
            gvThe.SetRowCellValue(e.RowHandle, "NgayLapThe", DateTime.Now.Date);
            gvThe.SetRowCellValue(e.RowHandle, "NgayHetHan", DateTime.Now.Date.AddMonths(3));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvThe.AddNewRow();
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
                int r = gvThe.FocusedRowHandle;

                string strThe = gvThe.GetRowCellValue(r, "MaThe").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbThe.XoaThe(strThe, ref err);
                    gvThe.DeleteRow(gvThe.FocusedRowHandle);
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
            gcThe.MainView = lvThe;
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
            gcThe.MainView = gvThe;
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
                    BLThe blThe = new BLThe();

                    blThe.ThemThe(MaThe, MaDG, NgayLapThe, NgayHetHan, ref err);

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
                    BLThe blThe = new BLThe();

                    blThe.CapNhatThe(MaThe, MaDG, NgayLapThe, NgayHetHan, ref err);

                    LoadData();

                    XtraMessageBox.Show("Đã sửa xong!");
                }
                catch
                {
                    XtraMessageBox.Show("Không sữa được. Lỗi rồi!");
                }
            }
        }

        private void btnHuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoadData();
        }
    }
}