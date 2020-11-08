using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLTraCuuSach
    {

        DBMain db = null;

        public BLTraCuuSach()
        {
            db = new DBMain();
        }
        public DataSet LayThongTinSach()
        {
            return db.ExecuteQueryDataSet("execute layThongTinSach", CommandType.Text);
        }

        public DataSet LayLocSach_TheLoai(string MaTL)
        {
            return db.ExecuteQueryDataSet("execute layLocSach_TheLoai '" + MaTL + "'", CommandType.Text);
        }

        public DataSet LayLocSach_NgonNgu(string MaNgonNgu)
        {
            return db.ExecuteQueryDataSet("execute layLocSach_NgonNgu '" + MaNgonNgu + "'", CommandType.Text);
        }
    }
}
