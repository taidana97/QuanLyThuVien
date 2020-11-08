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
            this.layInTheDocGiaTableAdapter.Fill(this.quanLyThuVienDataSet.layInTheDocGia);
        }

        private void slueMaThe_EditValueChanged(object sender, EventArgs e)
        {
            this.layTheDocGiaTableAdapter.Fill(this.quanLyThuVienDataSet.layTheDocGia, slueMaThe.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}