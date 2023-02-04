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
    public class BLChiTietHoaDon
    {
        DBMainXuLy db = null;
        public BLChiTietHoaDon()
        {
            db = new DBMainXuLy();
        }
        public DataTable LoadHoaDon()
        {
            return db.ExecuteQueryDataSet("exec LoadChiTietHoaDon", CommandType.Text).Tables[0];
        }
    }
}
