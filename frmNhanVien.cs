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
using CSDLPT_QuanLyDienThoai.DB_Layer;
using System.Data.SqlClient;


namespace CSDLPT_QuanLyDienThoai
{
    public partial class frmNhanVien : Form
    {
       
        string err = "";
        bool them;
        DataTable dt = new DataTable();
        BLNhanVien db = new BLNhanVien();
        DataSet dsNV = new DataSet();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
           
            cmbChiNhanh.DataSource = DBMain.bds_dspm;
            cmbChiNhanh.DisplayMember = "TenCN";
            cmbChiNhanh.ValueMember = "TenServer";
            cmbChiNhanh.SelectedIndex = DBMain.mChinhanh;

        }
      
        void LoadDanhSachNhanVien()
        {
            try
            {
                this.loadNhanVienTableAdapter.Connection.ConnectionString = DBMain.connstr;
            
                this.loadNhanVienTableAdapter.Fill(this.xuLy.LoadNhanVien);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

        }

        private void dgvNHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvNHANVIEN.CurrentCell.RowIndex;
                
                this.txtMaNV.Text =
                dgvNHANVIEN.Rows[r].Cells[0].Value.ToString();
                this.txtMatKhau.Text =
                dgvNHANVIEN.Rows[r].Cells[1].Value.ToString();
                this.cmbQuyen.Text =
                dgvNHANVIEN.Rows[r].Cells[2].Value.ToString();
                this.txtHoNV.Text =
                dgvNHANVIEN.Rows[r].Cells[3].Value.ToString();
                this.txtTenNV.Text =
                dgvNHANVIEN.Rows[r].Cells[4].Value.ToString();
                this.txtSDT.Text =
                dgvNHANVIEN.Rows[r].Cells[5].Value.ToString();
                this.txtDiaChi.Text =
                dgvNHANVIEN.Rows[r].Cells[6].Value.ToString();
                this.dateTimePicker1.Text =
                dgvNHANVIEN.Rows[r].Cells[7].Value.ToString();
                this.cmbGioitinh.Text =
                dgvNHANVIEN.Rows[r].Cells[8].Value.ToString();
                this.txtChiNhanh.Text =
                dgvNHANVIEN.Rows[r].Cells[9].Value.ToString();
                this.txtLoaiNV.Text =
                dgvNHANVIEN.Rows[r].Cells[10].Value.ToString();
                this.txtLuong.Text =
                dgvNHANVIEN.Rows[r].Cells[11].Value.ToString();
                this.txtGhiChu.Text =
                dgvNHANVIEN.Rows[r].Cells[12].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvNHANVIEN.CurrentCell.RowIndex;
                
                string MaNV =
                dgvNHANVIEN.Rows[r].Cells[0].Value.ToString();
               
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn chắc chắn xóa nhân viên này ?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                string err = "";
                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = db.XoaNhanVien(ref err, this.txtMaNV.Text);
                    if (f)
                    {
                        // Cập nhật lại DataGridView 

                        this.loadNhanVienTableAdapter.Connection.ConnectionString = DBMain.connstr;

                        this.loadNhanVienTableAdapter.Fill(this.xuLy.LoadNhanVien);

                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!\n\r" + "Lỗi:" + err);
                    }
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            //Đóng kết nối
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dsNV = db.TimKiemNhanVien(txtTimKiem.Text);
                dgvTimKiemNhanVien.DataSource = dsNV.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy !",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool f = false;
                if (them)
                {
                    f = db.ThemNhanVien(ref err, this.txtMaNV.Text, this.txtMatKhau.Text, this.cmbQuyen.Text, this.txtHoNV.Text, this.txtTenNV.Text, int.Parse(this.txtSDT.Text), this.txtDiaChi.Text, DateTime.Parse(this.dateTimePicker1.Text), this.cmbGioitinh.Text, this.txtChiNhanh.Text, this.txtLoaiNV.Text, int.Parse(this.txtLuong.Text), this.txtGhiChu.Text);
                    if (f == true)
                    {
                        MessageBox.Show(err);
                        this.loadNhanVienTableAdapter.Connection.ConnectionString = DBMain.connstr;

                        this.loadNhanVienTableAdapter.Fill(this.xuLy.LoadNhanVien);

                    }
                    else
                    {
                        MessageBox.Show(err);
                    }
                }
               else
                {
                    f = db.SuaNhanVien(ref err, this.txtMaNV.Text, this.txtMatKhau.Text, this.cmbQuyen.Text, this.txtHoNV.Text, this.txtTenNV.Text, int.Parse(this.txtSDT.Text), this.txtDiaChi.Text, DateTime.Parse(this.dateTimePicker1.Text), this.cmbGioitinh.Text, this.txtChiNhanh.Text, this.txtLoaiNV.Text, int.Parse(this.txtLuong.Text), this.txtGhiChu.Text);
                    if (f == true)
                    {
                        MessageBox.Show("Sửa Nhân Viên Thành Công");
                        this.loadNhanVienTableAdapter.Connection.ConnectionString = DBMain.connstr;

                        this.loadNhanVienTableAdapter.Fill(this.xuLy.LoadNhanVien);

                    }
                    else
                    {
                        MessageBox.Show(err);
                    }
                }
               
            }
            catch
            {

            }
           
        }

        
    }
}
