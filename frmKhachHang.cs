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


namespace CSDLPT_QuanLyDienThoai
{
    public partial class frmKhachHang : Form
    {
        string err = "";
        bool them;
        DataTable kh = new DataTable();
        BLKhachHang db = new BLKhachHang();
        DataSet dsKH = new DataSet();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKH();
        }
        void HienThiDanhSachKH()
        {
            try
            {
                kh = db.LoadKhachHang();
                dgvKHACHHANG.DataSource = kh;
                dgvKHACHHANG.AutoResizeColumns();
                

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Khách Hàng!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool f = false;
                if (them)
                {
                    f = db.ThemKhachHang(ref err, this.txtMaKH.Text, this.txtTenKhachHang.Text, this.txtDiaChi.Text, int.Parse(this.txtSDT.Text));
                    if (f == true)
                    {
                        HienThiDanhSachKH();

                    }
                    else
                    {
                        MessageBox.Show(err);
                    }
                }
                else
                {
                    f = db.SuaKhachHang(ref err, this.txtMaKH.Text, this.txtTenKhachHang.Text, this.txtDiaChi.Text, int.Parse(this.txtSDT.Text));
                    if (f == true)
                    {
                        HienThiDanhSachKH();

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvKHACHHANG.CurrentCell.RowIndex;

                string MaKH =
                dgvKHACHHANG.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn chắc chắn xóa nhân viên này ?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                string err = "";
                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = db.XoaKhachHang(ref err, this.txtMaKH.Text);
                    if (f)
                    {
                        // Cập nhật lại DataGridView 

                        HienThiDanhSachKH();

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
        }

        private void dgvKHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvKHACHHANG.CurrentCell.RowIndex;

                this.txtMaKH.Text =
                dgvKHACHHANG.Rows[r].Cells[0].Value.ToString();
                this.txtTenKhachHang.Text =
                dgvKHACHHANG.Rows[r].Cells[1].Value.ToString();
                this.txtDiaChi.Text =
                dgvKHACHHANG.Rows[r].Cells[2].Value.ToString();
                this.txtSDT.Text =
                dgvKHACHHANG.Rows[r].Cells[3].Value.ToString();
 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dsKH = db.TimKiemKhachHang(txtTimKiem.Text);
                dgvKHACHHANG.DataSource = dsKH.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy !",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
