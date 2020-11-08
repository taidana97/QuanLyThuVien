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
    public partial class frmRPPhieuMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmRPPhieuMuon()
        {
            InitializeComponent();
            QuanLyThuVienDataSet.EnforceConstraints = false;

        }

        private void frmRPPhieuMuon_Load(object sender, EventArgs e)
        {
            this.layPhieuMuonTableAdapter.Fill(this.QuanLyThuVienDataSet.layPhieuMuon);
            QuanLyThuVienDataSet.EnforceConstraints = false;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QuanLyThuVienDataSet.EnforceConstraints = false;
            this.DanhSachPhieuMuonTableAdapter.Fill(this.QuanLyThuVienDataSet.DanhSachPhieuMuon);
            SetParameters(slueMaThe.Text, slueSoPhieu.Text);
            this.reportViewer1.RefreshReport();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.layMuonSachSoPhieuTableAdapter.Fill(this.QuanLyThuVienDataSet.layMuonSachSoPhieu, slueMaThe.Text);
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