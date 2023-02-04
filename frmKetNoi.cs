using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CSDLPT_QuanLyDienThoai.BL_Layer;
using CSDLPT_QuanLyDienThoai.DB_Layer;

namespace CSDLPT_QuanLyDienThoai
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        BLKetNoi db = new BLKetNoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dt = db.LoadChiNhanh();
            cmbChiNhanh.DataSource = dt;
            cmbChiNhanh.DisplayMember = "TenCN";
            cmbChiNhanh.ValueMember = "TenServer";
            cmbChiNhanh.SelectedIndex = 1;
            cmbChiNhanh.SelectedIndex = 0;
            DBMain.bds_dspm.DataSource = dt;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue != null)
            {
                DBMain.servername = cmbChiNhanh.SelectedValue.ToString();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "", MessageBoxButtons.OK);
                return;
            }

            DBMain.mlogin = txtDangNhap.Text.Trim();
            DBMain.password = txtMatKhau.Text;
            if (DBMain.KetNoi() == 0)
                return;
            // 0 - trả về chi nhánh hiện tại
            SqlDataReader myReader;
            DBMain.mChinhanh = cmbChiNhanh.SelectedIndex;
            //DBMain.bds_dspm = ds;

            DBMain.mloginDN = DBMain.mlogin;
            DBMain.passwordDN = DBMain.password;
            string strLenh = "exec KiemTraDangNhap '" + DBMain.mlogin + "'";
            myReader = DBMain.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();


            DBMain.username = myReader.GetString(0);    // Lay user name
            if (Convert.IsDBNull(DBMain.username))
            {
                MessageBox.Show("User không đủ quyền truy cập ! Xin vui lòng xem lại cơ sở dữ liệu.", "", MessageBoxButtons.OK);
                return;
            }
            
            DBMain.mGroup = myReader.GetString(2);
           
            MessageBox.Show("Đăng nhập thành công !!!", "", MessageBoxButtons.OK);
            if (txtDangNhap.Text == "QuanLy01" || txtDangNhap.Text == "QuanLy02")
            {

                frmNhanVien frm = new frmNhanVien();
                frm.ShowDialog();
            }
            else
            {
                frmTrangChu frm = new frmTrangChu();
                frm.ShowDialog();
            }
        }
    }
}
