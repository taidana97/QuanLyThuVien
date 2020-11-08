using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyThuVien.DB_layer;

namespace QuanLyThuVien.BS_layer
{
    class BLPinBooks
    {
        DBMain db = null;

        public BLPinBooks()
        {
            db = new DBMain();
        }
        public DataSet LayViTriSach(string MaSach)
        {
            return db.ExecuteQueryDataSet("execute layPinBooks '"+ MaSach + "'", CommandType.Text);
        }


    }
}
