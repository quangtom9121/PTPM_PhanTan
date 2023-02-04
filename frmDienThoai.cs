using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CSDLPT_QuanLyDienThoai.BL_Layer;
using System.Data.SqlClient;


namespace CSDLPT_QuanLyDienThoai
{
    public partial class frmDienThoai : Form
    {
        string err = "";
        bool them;
        DataTable dt = new DataTable();
        BLDienThoai db = new BLDienThoai();
        DataSet dsDT = new DataSet();
        public frmDienThoai()
        {
            InitializeComponent();
        }
        string imgLocation;

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
           
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);

            bool f = false;
            if (them)
            {
                
                f = db.ThemDienThoai(ref err, this.txtMaDT.Text,images, this.txtTenDT.Text, int.Parse(this.txtDonGia.Text), this.txtManHinh.Text, this.txtHeDieuHanh.Text,this.txtCamera.Text,this.txtRam.Text,this.txtBoNho.Text,this.txtDungLuongPin.Text);
                MessageBox.Show("Thêm Thành Công");
                HienThiDanhSachDT();
            }
            else
            {

                f = db.SuaDienThoai(ref err, this.txtMaDT.Text, images, this.txtTenDT.Text, int.Parse(this.txtDonGia.Text), this.txtManHinh.Text, this.txtHeDieuHanh.Text, this.txtCamera.Text, this.txtRam.Text, this.txtBoNho.Text, this.txtDungLuongPin.Text);
                MessageBox.Show("Sửa Thành Công");
                HienThiDanhSachDT();
            }
        }

        private void frmDienThoai_Load(object sender, EventArgs e)
        {
            HienThiDanhSachDT();
           
        }
      

        void HienThiDanhSachDT()
        {
            try
            {
                dt = db.LoadDienThoai();
                dgvDIENTHOAI.RowTemplate.Height = 200;
                dgvDIENTHOAI.AllowUserToAddRows = false;
               

                dgvDIENTHOAI.DataSource = dt;
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgvDIENTHOAI.Columns[1];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
 
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Điện Thoại!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDIENTHOAI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvDIENTHOAI.CurrentCell.RowIndex;

                this.txtMaDT.Text =
                dgvDIENTHOAI.Rows[r].Cells[0].Value.ToString();
                Byte[] img=(Byte[])dgvDIENTHOAI.Rows[r].Cells[1].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                this.txtTenDT.Text =
                dgvDIENTHOAI.Rows[r].Cells[2].Value.ToString();
                this.txtDonGia.Text =
                dgvDIENTHOAI.Rows[r].Cells[3].Value.ToString();
                this.txtManHinh.Text =
                dgvDIENTHOAI.Rows[r].Cells[4].Value.ToString();
                this.txtHeDieuHanh.Text =
                dgvDIENTHOAI.Rows[r].Cells[5].Value.ToString();
                this.txtCamera.Text =
                dgvDIENTHOAI.Rows[r].Cells[6].Value.ToString();
                this.txtRam.Text =
                dgvDIENTHOAI.Rows[r].Cells[7].Value.ToString();
                this.txtBoNho.Text =
                dgvDIENTHOAI.Rows[r].Cells[8].Value.ToString();
                this.txtDungLuongPin.Text =
                dgvDIENTHOAI.Rows[r].Cells[9].Value.ToString();
                
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
                int r = dgvDIENTHOAI.CurrentCell.RowIndex;

                string MaDT =
                dgvDIENTHOAI.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn chắc chắn xóa điện thoại này ?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                string err = "";
                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = db.XoaDienThoai(ref err, this.txtMaDT.Text);
                    if (f)
                    {
                       

                        HienThiDanhSachDT();
                        
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
                dsDT = db.TimKiemDienThoai(txtTimKiem.Text);
                dgvDIENTHOAI.DataSource = dsDT.Tables[0];
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
    }
}
