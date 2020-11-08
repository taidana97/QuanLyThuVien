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
    public partial class frmRPTheDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmRPTheDocGia()
        {
            InitializeComponent();
        }

        private void frmRPTheDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.layTheDocGia' table. You can move, or remove it, as needed.
            this.layInTheDocGiaTableAdapter.Fill(this.quanLyThuVienDataSet.layInTheDocGia);
            this.reportViewer1.RefreshReport();
        }

        private void slueMaThe_EditValueChanged(object sender, EventArgs e)
        {
            this.layTheDocGiaTableAdapter.Fill(this.quanLyThuVienDataSet.layTheDocGia, slueMaThe.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}