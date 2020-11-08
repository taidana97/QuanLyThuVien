using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLTacGia
    {
        DBMain db = null;
        public BLTacGia()
        {
            db = new DBMain();
        }
        public DataSet LayTacGia()
        {
            return db.ExecuteQueryDataSet("execute layTacGia", CommandType.Text);
        }
        public bool ThemTacGia(string MaTG, string TenTG, string DiaChi, string SDT, string Email, ref string err)
        {
            string sqlString = "execute themTacGia '" + MaTG + "',N'" + TenTG + "',N'" + DiaChi + "','" + SDT + "','" + Email + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaTacGia(string MaTG, ref string err)
        {
            string sqlString = "execute xoaTacGia '" + MaTG + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTacGia(string MaTG, string TenTG, string DiaChi, string SDT, string Email, ref string err)
        {
            string sqlString = "execute suaTacGia '" + MaTG + "',N'" + TenTG + "',N'" + DiaChi + "','" + SDT + "','" + Email + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
