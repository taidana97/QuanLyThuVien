using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLNhanVien
    {
        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("execute layNhanVien", CommandType.Text);
        }
        public bool ThemNhanVien(string MaNV, string TenNV, bool GioiTinh,string NgaySinh, string CNMD, string DiaChi, string SDT, string NgayNhapLam, object hinhAnh, ref string err)
        {
            string sqlString = "execute themNhanVien '" + MaNV + "',N'" + TenNV + "','" + GioiTinh + "','" + 
                NgaySinh + "','" + CNMD + "',N'" + DiaChi + "','" + SDT + "','" + NgayNhapLam + "',@hinh)";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("execute themNhanVien'" + MaNV + 
                    "',N'" + TenNV + "','" + GioiTinh + "','" + NgaySinh + "','" + CNMD + "',N'" + DiaChi + "','" + SDT + "','" + NgayNhapLam + "',NULL", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(string MaNV, ref string err)
        {
            string sqlString = "execute xoaNhanVien '" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien(string MaNV, string TenNV, bool GioiTinh, string NgaySinh, string CNMD, string DiaChi, string SDT, string NgayNhapLam, object hinhAnh, ref string err)
        {
            string sqlString = "execute suaNhanVien '" + MaNV + "',N'" + TenNV + "','" + GioiTinh + "','" +
                NgaySinh + "',N'" + CNMD + "','" + DiaChi + "','" + SDT + "','" + NgayNhapLam + "',@hinh)";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("execute suaNhanVien'" + MaNV + "',N'" + TenNV + "','" + GioiTinh + 
                    "','" + NgaySinh + "','" + CNMD + "',N'" + DiaChi + "','" + SDT + "','" + NgayNhapLam + "',NULL", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
    }
}
