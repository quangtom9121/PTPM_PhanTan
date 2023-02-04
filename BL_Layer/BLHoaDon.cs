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
    public class BLHoaDon
    {
        DBMainXuLy db = null;
        public BLHoaDon()
        {
            db = new DBMainXuLy();
        }
        public DataTable LoadHoaDon()
        {
            return db.ExecuteQueryDataSet("exec LoadHoaDon", CommandType.Text).Tables[0];
        }
    }
}
