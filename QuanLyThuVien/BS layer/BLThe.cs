using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLThe
    {
        DBMain db = null;
        public BLThe()
        {
            db = new DBMain();
        }
        public DataSet LayThe()
        {
            return db.ExecuteQueryDataSet("execute layThe", CommandType.Text);
        }
        public bool ThemThe(string MaThe, string MaDG, string NgayLapThe, string NgayHetHan, ref string err)
        {
            string sqlString = "execute themThe '" + MaThe + "','" + MaDG + "','" + NgayLapThe + "','" + NgayHetHan + "',NULL";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaThe(string MaThe, ref string err)
        {
            string sqlString = "execute xoaThe '" + MaThe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThe(string MaThe, string MaDG, string NgayLapThe, string NgayHetHan, ref string err)
        {
            string sqlString = "execute suaThe '" + MaThe + "','" + MaDG + "','" + NgayLapThe + "','" + NgayHetHan + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
