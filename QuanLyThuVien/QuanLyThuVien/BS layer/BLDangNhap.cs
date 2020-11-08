using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLDangNhap
    {
        DBMain db = null;

        public BLDangNhap()
        {
            db = new DBMain();
        }
        public DataSet LayQuanLy()
        {
            return db.ExecuteQueryDataSet("select * from DangNhap", CommandType.Text);
        }
        public int DangNhapQuanLy(string User, string Pass, ref string err)
        {
            string sqlString = "select count(*) from DangNhap where ID='" + User + "' and PASS='" + Pass + "'";
            return db.QueryLogin(sqlString, CommandType.Text, ref err);
        }
        public bool DangKyQuanLy(string User, string Pass, ref string err)
        {
            string sqlString = "Insert Into DangNhap Values('" + User + "','" + Pass + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public int XetTenQuanLy(string User, ref string err)
        {
            string sqlString = "select count(*) from DangNhap where ID='" + User + "'";
            return db.QueryLogin(sqlString, CommandType.Text, ref err);
        }
        public bool DoiMatKhauDangNhap(string User, string PassNew, ref string err)
        {
            string sqlString = "execute suaPass '" + User + "','" + PassNew + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public string layPassOld(string User, ref string err)
        {
            string sqlString = "select * from layPassOld('" + User + "')";
            return db.QueryDoiMatKhau(sqlString, CommandType.Text, ref err);
        }
        public string LayQuyenTruyCap(string User, string Pass, ref string err)
        {
            string sqlString = "select * from layQuyenTruyCap('" + User + "','" + Pass + "')";
            return db.QueryQuyen(sqlString, CommandType.Text, ref err);
        }
    }
}
