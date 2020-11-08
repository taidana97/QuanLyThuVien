using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLTheLoai
    {
        DBMain db = null;
        public BLTheLoai()
        {
            db = new DBMain();
        }
        public DataSet LayTheLoai()
        {
            return db.ExecuteQueryDataSet("execute layTheLoai", CommandType.Text);
        }
        public bool ThemTheLoai(string MaTL, string TenTL, ref string err)
        {
            string sqlString = "execute themTheLoai '" + MaTL +  "',N'" + TenTL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaTheLoai(string MaTL, ref string err)
        {
            string sqlString = "execute xoaTheLoai '" + MaTL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTheLoai(string MaTL, string TenTL, ref string err)
        {
            string sqlString = "execute suaTheLoai '" + MaTL + "',N'" + TenTL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
