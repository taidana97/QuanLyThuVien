using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLSach
    {
        DBMain db = null;
        public BLSach()
        {
            db = new DBMain();
        }
        public DataSet LaySach()
        {
            return db.ExecuteQueryDataSet("execute laySach", CommandType.Text);
        }
        public bool ThemSach(string MaSach, string TenSach, string MaNgonNgu, string MaNXB, string MaTG, string MaTL, string MaVT, string SoTrang, string SoLuong, string NamNXB, decimal GiaSach, string NgayNhapVe, object hinhAnh, ref string err)
        {
            string sqlString = "execute themSach '" + MaSach + "',N'" + TenSach + "','" + MaNgonNgu + "','" + MaNXB + "','" + MaTG +
                "','" + MaTL + "','" + MaVT + "','" + SoTrang + "','" + SoLuong + "','" + NamNXB + "','" + GiaSach + "','" + NgayNhapVe + "',@hinh";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("execute themSach '" + MaSach + "',N'" + TenSach + "','" + MaNgonNgu + "','" + MaNXB + "','" + MaTG +
                "','" + MaTL + "','" + MaVT + "','" + SoTrang + "','" + SoLuong + "','" + NamNXB + "','" + GiaSach + "','" + NgayNhapVe + "',NULL", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
        public bool XoaSach(string MaSach, ref string err)
        {
            string sqlString = "execute xoaSach '" + MaSach + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSach(string MaSach, string TenSach, string MaNgonNgu, string MaNXB, string MaTG, string MaTL, string MaVT, string SoTrang, string SoLuong, string NamNXB, decimal GiaSach, string NgayNhapVe, object hinhAnh, ref string err)
        {
            string sqlString = "execute suaSach '" + MaSach + "',N'" + TenSach + "','" + MaNgonNgu + "','" + MaNXB + "','" + MaTG +
                "','" + MaTL + "','" + MaVT + "','" + SoTrang + "','" + SoLuong + "','" + NamNXB + "','" + GiaSach + "','" + NgayNhapVe + "',@hinh";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("execute suaSach '" + MaSach + "', N'" + TenSach + "','" + MaNgonNgu + "','" + MaNXB + "','" + MaTG +
                "','" + MaTL + "','" + MaVT + "','" + SoTrang + "','" + SoLuong + "','" + NamNXB + "','" + GiaSach + "','" + NgayNhapVe + "',NULL", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
    }
}
