using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLNgonNguSach
    {
        DBMain db = null;
        public BLNgonNguSach()
        {
            db = new DBMain();
        }
        public DataSet LayNgonNguSach()
        {
            return db.ExecuteQueryDataSet("execute layNgonNguSach", CommandType.Text);
        }
        public bool ThemNgonNguSach(string MaNgonNgu, string TenNgonNgu, ref string err)
        {
            string sqlString = "execute themNgonNguSach '" + MaNgonNgu +
                "',N'" + TenNgonNgu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNgonNguSach(string MaNgonNgu, ref string err)
        {
            string sqlString = "execute xoaNgonNguSach '" + MaNgonNgu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNgonNguSach(string MaNgonNgu, string TenNgonNgu, ref string err)
        {
            string sqlString = "execute suaNgonNguSach '" + MaNgonNgu + "',N'" + TenNgonNgu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
