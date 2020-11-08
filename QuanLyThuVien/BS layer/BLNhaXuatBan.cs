using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLNhaXuatBan
    {
        DBMain db = null;
        public BLNhaXuatBan()
        {
            db = new DBMain();
        }
        public DataSet LayNhaXuatBan()
        {
            return db.ExecuteQueryDataSet("execute layNhaXuatBan", CommandType.Text);
        }
        public bool ThemNhaXuatBan(string MaNXB, string TenNXB, string DiaChi, string SDT, string NgayThanhLap, ref string err)
        {
            string sqlString = "execute themNhaXuatBan '" + MaNXB +
                "',N'" + TenNXB + "',N'" + DiaChi + "','" + SDT + "','" + NgayThanhLap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhaXuatBan(string MaNXB, ref string err)
        {
            string sqlString = "execute xoaNhaXuatBan '" + MaNXB + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhaXuatBan(string MaNXB, string TenNXB, string DiaChi, string SDT, string NgayThanhLap, ref string err)
        {
            string sqlString = "execute suaNhaXuatBan '" + MaNXB + "',N'" + TenNXB + "',N'" + DiaChi + "','" + SDT + "','" + NgayThanhLap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
