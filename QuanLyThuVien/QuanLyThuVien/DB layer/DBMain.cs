using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DB_layer
{
    class DBMain
    {
        string ConnStr = "Data Source=DESKTOP-DOEGLSO\\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);

            DataSet ds = new DataSet();

            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;

            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public int QueryLogin(string strSQL, CommandType ct, ref string err)
        {
            int f;
            // Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Thực hiện lệnh
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            // Kêt quả của việc thực hiện truy vấn câu hỏi
            f = (int)comm.ExecuteScalar();
            try
            {
                // Kêt quả của việc thực hiện truy vấn câu hỏi 
                f = (int)comm.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                // Thông báo lỗi
                err = ex.Message;
            }
            finally
            {
                // Kết thúc kết nối
                conn.Close();
            }
            return f;
        }
        public string QueryQuyen(string strSQL, CommandType ct, ref string err)
        {
            string f;
            // Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Thực hiện lệnh
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            // Kêt quả của việc thực hiện truy vấn câu hỏi
            f = (string)comm.ExecuteScalar();
            try
            {
                // Kêt quả của việc thực hiện truy vấn câu hỏi 
                f = (string)comm.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                // Thông báo lỗi
                err = ex.Message;
            }
            finally
            {
                // Kết thúc kết nối
                conn.Close();
            }
            return f;
        }
        public bool QueryHinh(string strSQL, object hinhAnh, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;

            comm.Parameters.AddWithValue("@hinh", hinhAnh);

            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public string QueryDoiMatKhau(string strSQL, CommandType ct, ref string err)
        {
            string f;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            f = (string)comm.ExecuteScalar();
            try
            {
                f = (string)comm.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
