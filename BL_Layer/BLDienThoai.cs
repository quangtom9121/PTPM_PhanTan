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
    public class BLDienThoai
    {
        DBMainXuLy db = null;
        public BLDienThoai()
        {
            db = new DBMainXuLy();
        }
        public DataTable LoadDienThoai()
        {
            return db.ExecuteQueryDataSet("exec HienThiDienThoai", CommandType.Text).Tables[0];
        }
        public bool ThemDienThoai(ref string err, string MaDT,byte[] HinhAnh, string TenDT, int DonGia, string ManHinh,
            string HeDieuHanh, string Camera, string Ram, string BoNho, string DungLuongPin)
        {
            return db.MyExecuteNonQuery("ThemDienThoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDT", MaDT),
                new SqlParameter("@HinhAnh",HinhAnh),
                new SqlParameter("@TenDT", TenDT),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@ManHinh", ManHinh),
                new SqlParameter("@HeDieuHanh",HeDieuHanh),
                new SqlParameter("@Camera", Camera),
                new SqlParameter("@Ram", Ram),
                new SqlParameter("@BoNho",BoNho),
                new SqlParameter("@DungLuongPin",DungLuongPin)  
                );
        }
        public bool SuaDienThoai(ref string err, string MaDT, byte[] HinhAnh, string TenDT, int DonGia, string ManHinh,
          string HeDieuHanh, string Camera, string Ram, string BoNho, string DungLuongPin)
        {
            return db.MyExecuteNonQuery("SuaDienThoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDT", MaDT),
                new SqlParameter("@HinhAnh", HinhAnh),
                new SqlParameter("@TenDT", TenDT),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@ManHinh", ManHinh),
                new SqlParameter("@HeDieuHanh", HeDieuHanh),
                new SqlParameter("@Camera", Camera),
                new SqlParameter("@Ram", Ram),
                new SqlParameter("@BoNho", BoNho),
                new SqlParameter("@DungLuongPin", DungLuongPin)
                );
        }
        public bool XoaDienThoai(ref string err, string MaDT)
        {
            return db.MyExecuteNonQuery("XoaDienThoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDT", MaDT));
        }
        public DataSet TimKiemDienThoai(string TenDT)
        {
            return db.ExecuteQueryDataSet("exec TimKiemDienThoai N'" + TenDT + "'", CommandType.Text, null);
        }
    }
}
