using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;

namespace QuanLyThuVien
{
    public partial class frmRPPhieuTra : DevExpress.XtraEditors.XtraForm
    {
        public frmRPPhieuTra()
        {
            InitializeComponent();
        }

        private void frmRPPhieuTra_Load(object sender, EventArgs e)
        {
            this.layPhieuTraTableAdapter.Fill(this.QuanLyThuVienDataSet.layPhieuTra);
            this.reportViewer1.RefreshReport();
        }

        private void slueMaThe_EditValueChanged(object sender, EventArgs e)
        {
            this.layPhieuTraSoPhieuTableAdapter.Fill(this.QuanLyThuVienDataSet.layPhieuTraSoPhieu, slueMaThe.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            SetParameters(slueMaThe.Text, slueSoPhieu.Text);
            this.reportViewer1.RefreshReport();
        }

        private void SetParameters(string maThe, string soPhieu)
        {
            ReportParameter[] rp = new ReportParameter[2];

            rp[0] = new ReportParameter("MaThe");
            rp[1] = new ReportParameter("SoPhieu");
            
            rp[0].Values.Add("*" + maThe + "*");
            rp[1].Values.Add("*" + soPhieu + "*");

            reportViewer1.LocalReport.SetParameters(rp);
        }
    }
}