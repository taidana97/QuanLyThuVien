using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;


namespace QuanLyThuVien.BS_layer
{
    class BLViTriSach
    {
        DBMain db = null;
        public BLViTriSach()
        {
            db = new DBMain();
        }
        public DataSet LayViTriSach()
        {
            return db.ExecuteQueryDataSet("execute layViTriSach", CommandType.Text);
        }
        public bool ThemViTriSach(string MaVT, string Kho, string Ke, string Ngan, ref string err)
        {
            string sqlString = "execute themViTriSach '" + MaVT +
                "',N'" + Kho + "',N'" + Ke + "','" + Ngan + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaViTriSach(string MaVT, ref string err)
        {
            string sqlString = "execute xoaViTriSach '" + MaVT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatViTriSach(string MaVT, string Kho, string Ke, string Ngan, ref string err)
        {
            string sqlString = "execute suaViTriSach '" + MaVT + "',N'" + Kho + "',N'" + Ke + "','" + Ngan +  "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
