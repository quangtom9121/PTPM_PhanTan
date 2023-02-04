using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CSDLPT_QuanLyDienThoai.DB_Layer
{
    class DBMainLoadChiNhanh
    {
        public static string server, user, password;
        string strConnectionString = @"Data Source=DESKTOP-15AS6GK;Initial Catalog=QL_DT;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMainLoadChiNhanh()
        {
            conn = new SqlConnection(strConnectionString);
            comm = conn.CreateCommand();
        }
        public void Connect(ref string state)
        {
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
    }
}
