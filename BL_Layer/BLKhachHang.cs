using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLPT_QuanLyDienThoai.DB_Layer;
using System.Data.SqlClient;
using System.Data;

namespace CSDLPT_QuanLyDienThoai.BL_Layer
{
    public class BLKhachHang
    {
        DBMainXuLy db = null;
        public BLKhachHang()
        {
            db = new DBMainXuLy();
        }
        public DataTable LoadKhachHang()
        {
            return db.ExecuteQueryDataSet("exec LoadKhachHang", CommandType.Text).Tables[0];
        }
        public bool ThemKhachHang(ref string err, string MaKH,  string TenKH ,string DiaChi ,int SDT )
        {
            return db.MyExecuteNonQuery("ThemKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TenKH", TenKH),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SDT", SDT)
             
                );
        }
        public bool SuaKhachHang(ref string err, string MaKH, string TenKH, string DiaChi, int SDT)
        {
            return db.MyExecuteNonQuery("SuaKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TenKH", TenKH),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SDT", SDT)
                );
        }

        public bool XoaKhachHang(ref string err, string MaKH)
        {
            return db.MyExecuteNonQuery("XoaKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKH", MaKH));
        }
        public DataSet TimKiemKhachHang(string TenKH)
        {
            return db.ExecuteQueryDataSet("exec TimKiemKhachHang N'" + TenKH + "'", CommandType.Text, null);
        }
    }
}
