using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDLPT_QuanLyDienThoai.DB_Layer
{
    public class DBMain
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand sqlcmd;
        public static String connstr;

        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QL_DT";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "12345678";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0; // xác định chi nhánh
        public static String tenChiNhanh = "";
        public static String maCN = "";
        public static BindingSource bds_dspm = new BindingSource();

        public static int checkDangNhap = 0;
        public static int KetNoi()
        {
            if (DBMain.conn != null && DBMain.conn.State == ConnectionState.Open)
                DBMain.conn.Close();
            try
            {
                DBMain.connstr = "Data Source=" + DBMain.servername + ";Initial Catalog=" +
                      DBMain.database + ";User ID=" +
                      DBMain.mlogin + ";password=" + DBMain.password;
                DBMain.conn.ConnectionString = DBMain.connstr;
                DBMain.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, DBMain.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (DBMain.conn.State == ConnectionState.Closed) DBMain.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                DBMain.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            DataTable dt = new DataTable();
            if (DBMain.conn.State == ConnectionState.Closed) DBMain.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
    }
}
