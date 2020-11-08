using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLDocGia
    {
        DBMain db = null;
        public BLDocGia()
        {
            db = new DBMain();
        }
        public DataSet LayDocGia()
        {
            return db.ExecuteQueryDataSet("execute layDocGia", CommandType.Text);
        }
        public bool ThemDocGia(string MaDG, string TenDG, bool GioiTinh, string NgaySinh, string CNMD, string DiaChi, string SDT, object hinhAnh, ref string err)
        {
            string sqlString = "execute themDocGia '" + MaDG + "',N'" + TenDG + "','" + GioiTinh + "','" + NgaySinh + 
                "','" + CNMD + "',N'" + DiaChi + "','" + SDT + "',@hinh";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("execute themDocGia '" + MaDG + "',N'" + TenDG + "','" + GioiTinh + 
                    "','" + NgaySinh + "','" + CNMD + "',N'" + DiaChi + "','" + SDT + "',NULL", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
        public bool XoaDocGia(string MaDG, ref string err)
        {
            string sqlString = "execute xoaDocGia '" + MaDG + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatDocGia(string MaDG, string TenDG, bool GioiTinh, string NgaySinh, string CNMD, string DiaChi, string SDT, object hinhAnh, ref string err)
        {
            string sqlString = "execute suaDocGia '" + MaDG + "',N'" + TenDG + "','" + GioiTinh + "','" + NgaySinh +
                "','" + CNMD + "',N'" + DiaChi + "','" + SDT + "',@hinh";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("execute suaDocGia '" + MaDG + "', N'" + TenDG + "', '" + GioiTinh + 
                    "','" + NgaySinh + "','" + CNMD + "',N'" + DiaChi + "','" + SDT + "',NULL", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
    }
}
