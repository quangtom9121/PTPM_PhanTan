using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLPT_QuanLyDienThoai.BL_Layer;
using System.Data.SqlClient;
using CSDLPT_QuanLyDienThoai.DB_Layer;

namespace CSDLPT_QuanLyDienThoai
{
    public partial class frmTrangChu : Form
    {
        string err = "";
        bool them;

        DataTable kh = new DataTable();
        BLKhachHang db = new BLKhachHang();
        DataSet dsKH = new DataSet();
        public frmTrangChu()
        {
            InitializeComponent();
        }

        void HienThiDanhSachHoaDon()
        {
            try
            {
                this.loadHoaDonTableAdapter1.Connection.ConnectionString = DBMain.connstr;

                this.loadHoaDonTableAdapter1.Fill(this.hoaDon1.LoadHoaDon);

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Hóa Đơn!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         void HienThiDanhSachChiTietHoaDon()
        {
            try
            {
                this.loadChiTietHoaDonTableAdapter1.Connection.ConnectionString = DBMain.connstr;

                this.loadChiTietHoaDonTableAdapter1.Fill(this.chiTietHoaDon1.LoadChiTietHoaDon);

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Chi Tiết Hóa Đơn!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void HienThiDanhSachKH()
        {
            try
            {
                kh = db.LoadKhachHang();
                cmbMaKH.DataSource = kh;
                cmbMaKH.ValueMember = "MaKH";
                cmbMaKH.DisplayMember = "TenKH";


            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Khách Hàng!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDienThoai_Click(object sender, EventArgs e)
        {
            frmDienThoai frm = new frmDienThoai();
            frm.ShowDialog();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chiTietHoaDon.LoadChiTietHoaDon' table. You can move, or remove it, as needed.
            
            HienThiDanhSachHoaDon();
            HienThiDanhSachKH();
            HienThiDanhSachChiTietHoaDon();
            cmbChiNhanh.DataSource = DBMain.bds_dspm;
            cmbChiNhanh.DisplayMember = "TenCN";
            cmbChiNhanh.ValueMember = "TenServer";
            cmbChiNhanh.SelectedIndex = DBMain.mChinhanh;
        }
    }
}
