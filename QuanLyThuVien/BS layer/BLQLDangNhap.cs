using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLQLDangNhap
    {
        DBMain db = null;
        public BLQLDangNhap()
        {
            db = new DBMain();
        }
        public DataSet LayQLDangNhap()
        {
            return db.ExecuteQueryDataSet("execute layDangNhap", CommandType.Text);
        }
        public bool ThemQLDangNhap(string ID, string PASS, string Quyen, ref string err)
        {
            string sqlString = "execute themDangNhap '" + ID + "',N'" + PASS + "',N'" + Quyen + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaQLDangNhap(string ID, ref string err)
        {
            string sqlString = "execute xoaDangNhap '" + ID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatQLDangNhap(string ID, string PASS, string Quyen, ref string err)
        {
            string sqlString = "execute suaDangNhap '" + ID + "',N'" + PASS + "',N'" + Quyen + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
