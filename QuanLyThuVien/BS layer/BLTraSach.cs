using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLTraSach
    {
        DBMain db = null;
        public BLTraSach()
        {
            db = new DBMain();
        }
        public DataSet LayThongTinDocGia(string MaThe)
        {
            return db.ExecuteQueryDataSet("select * from layThongTinDocGia('" + MaThe + "')", CommandType.Text);
        }

        public DataSet LayTraSach(string MaThe)
        {
            return db.ExecuteQueryDataSet("layTraSach '" + MaThe + "'", CommandType.Text);
        }

        public bool suaTraSach(string STT, string NgayTra, string TinhTrangSach, string NguoiThucHienMuon, ref string err)
        {
            string sqlString = "execute suaTraSach '" + STT + "','" + NgayTra + "','" + TinhTrangSach + "','" + NguoiThucHienMuon + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
