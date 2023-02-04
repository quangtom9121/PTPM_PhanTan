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
    public class BLNhanVien
    {
        DBMainXuLy db = null;
        public BLNhanVien()
        {
            db = new DBMainXuLy();
        }
        public DataTable Load()
        {
            return db.ExecuteQueryDataSet("exec LoadNhanVien", CommandType.Text).Tables[0];
        }
        public bool ThemNhanVien(ref string err, string MaNV, string MatKhau, string Quyen,string HoNV,string TenNV,int SDT,string DiaChi,DateTime NgaySinh,string GioiTinh,string MaCN,string LoaiNV,int Luong,string GhiChu)                     
        {
            return db.MyExecuteNonQuery("ThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@Quyen", Quyen),
                new SqlParameter("@HoNV", HoNV),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@MaCN", MaCN),
                new SqlParameter("@LoaiNV", LoaiNV),
                new SqlParameter("@Luong", Luong),
                new SqlParameter("@GhiChu", GhiChu)
                );
        }
        public bool SuaNhanVien(ref string err, string MaNV, string MatKhau, string Quyen, string HoNV, string TenNV, int SDT, string DiaChi, DateTime NgaySinh, string GioiTinh, string MaCN, string LoaiNV, int Luong, string GhiChu)
        {
            return db.MyExecuteNonQuery("SuaNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@Quyen", Quyen),
                new SqlParameter("@HoNV", HoNV),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@MaCN", MaCN),
                new SqlParameter("@LoaiNV", LoaiNV),
                new SqlParameter("@Luong", Luong),
                new SqlParameter("@GhiChu", GhiChu)
                );
        }
        public bool XoaNhanVien(ref string err,string MaNV)
        {
            return db.MyExecuteNonQuery("XoaNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV));
        }
        public DataSet TimKiemNhanVien(string TenNV)
        {
            return db.ExecuteQueryDataSet("exec TimKiemNhanVien N'" + TenNV + "'", CommandType.Text, null);
        }
    }
}
