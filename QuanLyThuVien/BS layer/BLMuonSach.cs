using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLMuonSach
    {
        DBMain db = null;
        public BLMuonSach()
        {
            db = new DBMain();
        }
        public DataSet LayThongTinDocGia(string MaThe)
        {
            return db.ExecuteQueryDataSet("select * from layThongTinDocGia('" + MaThe + "')", CommandType.Text);
        }

        public DataSet LayMuonSach(string MaThe, string NgayHienTai)
        {
            return db.ExecuteQueryDataSet("layMuonSach '" + MaThe + "','" + NgayHienTai + "'", CommandType.Text);
        }
        public bool ThemMuonSach(string MaThe, string MaSach, string SoPhieu, string NgayMuon, string NgayHenTra, string NguoiThucHienMuon, ref string err)
        {
            string sqlString = "execute themMuonSach '" + MaThe + "','" + MaSach + "','" +
                SoPhieu + "','" + NgayMuon + "','" + NgayHenTra + "','" + NguoiThucHienMuon + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
