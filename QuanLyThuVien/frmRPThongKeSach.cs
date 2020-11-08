using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien
{
    public partial class frmRPThongKeSach : DevExpress.XtraEditors.XtraForm
    {
        public frmRPThongKeSach()
        {
            InitializeComponent();
        }

        private void frmRPThongKeSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyThuVienDataSet.laySachThongKe' table. You can move, or remove it, as needed.
            this.laySachThongKeTableAdapter.Fill(this.QuanLyThuVienDataSet.laySachThongKe);

            this.reportViewer1.RefreshReport();
        }
    }
}