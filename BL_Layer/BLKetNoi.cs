using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLPT_QuanLyDienThoai.DB_Layer;
using System.Data;

namespace CSDLPT_QuanLyDienThoai.BL_Layer
{
    class BLKetNoi
    {
        DBMainLoadChiNhanh db = null;
        public BLKetNoi()
        {
            db = new DBMainLoadChiNhanh();
        }
        public DataTable LoadChiNhanh()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM DanhSachChiNhanh", CommandType.Text).Tables[0];
        }
    }
}
