using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CSDLPT_QuanLyDienThoai.DB_Layer
{
    class DBMainXuLy
    {
        public static string server, user, password;
        string strConnectionString = @"Data Source=DESKTOP-15AS6GK;Initial Catalog=QL_DT;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        public DBMainXuLy()
        {
            conn = new SqlConnection(strConnectionString);
            comm = conn.CreateCommand();
        }
        public void Connect(ref string state)
        {//kiểm tra kết nối, nếu kết nối thành công thì trạng thái là "Open"
            // ngược lại là "Closed"
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try { conn.Open(); }
            catch { }
            state = conn.State.ToString();
        }
        public DataSet ExecuteQueryDataSet(string strSQl, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQl;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;

            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
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
        public static string ExcuteScalarrrrrrrrr(string stringSQL)
        {
            string giaTri = "";
            try
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-U513UAP\SQLENTERPRISE;Initial Catalog=QuanLyQuanAn_DoAnCuoiKi;Integrated Security=True");
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(stringSQL, sqlconn);
                giaTri = cmd.ExecuteScalar().ToString();
            }
            catch { }
            return giaTri;
        }
        public static string ExcuteScalar(string strSQL, CommandType ct)
        {
            string Tong = "";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U513UAP\SQLENTERPRISE;Initial Catalog=QuanLyQuanAn_DoAnCuoiKi;Integrated Security=True");
            if (conn.State == ConnectionState.Open)
                conn.Close();
            //conn = strConnectionString();
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm = conn.CreateCommand();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                Tong = comm.ExecuteScalar().ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!!!!!!");
            }
            finally
            {
                conn.Close();
            }
            return Tong;
        }
    }
}
