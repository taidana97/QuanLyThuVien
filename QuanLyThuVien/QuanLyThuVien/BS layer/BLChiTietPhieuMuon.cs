using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLChiTietPhieuMuon
    {
        DBMain db = null;
        public BLChiTietPhieuMuon()
        {
            db = new DBMain();
        }
        public DataSet LayChiTietPhieuMuon()
        {
            return db.ExecuteQueryDataSet("execute layChiTietPhieuMuon", CommandType.Text);
        }
        public bool ThemChiTietPhieuMuon(string STT, string MaThe, string MaSach, string SoPhieu, string NgayMuon, string NgayHenTra, string NgayTra, string TinhTrangSach, decimal TienPhat, ref string err)
        {
            string sqlString = "execute themChiTietPhieuMuon '" + STT + "','" + MaThe + "','" + MaSach + "','" + 
                SoPhieu + "','" + NgayMuon+ "','" + NgayHenTra + "',NULL,'" + TinhTrangSach + "','" + TienPhat + "',NULL,NULL" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaChiTietPhieuMuon(string STT, ref string err)
        {
            string sqlString = "execute xoaChiTietPhieuMuon '" + STT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatChiTietPhieuMuon(string STT, string MaThe, string MaSach, string SoPhieu, string NgayMuon, string NgayHenTra, string NgayTra, string TinhTrangSach, decimal TienPhat, ref string err)
        {
            string sqlString = "execute suaChiTietPhieuMuon '" + STT + "','" + MaThe + "','" + MaSach + "','" + SoPhieu + "','" + 
                NgayMuon + "','" + NgayHenTra + "','" + NgayTra + "',N'" + TinhTrangSach + "','" + TienPhat + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
