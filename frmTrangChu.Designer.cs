namespace CSDLPT_QuanLyDienThoai
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDienThoai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgvHOADON = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dgvCHITIETHOADON = new System.Windows.Forms.DataGridView();
            this.hoaDon1 = new CSDLPT_QuanLyDienThoai.DB_Layer.HoaDon();
            this.loadHoaDonTableAdapter1 = new CSDLPT_QuanLyDienThoai.DB_Layer.HoaDonTableAdapters.LoadHoaDonTableAdapter();
            this.bindingSourceHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietHoaDon1 = new CSDLPT_QuanLyDienThoai.DB_Layer.ChiTietHoaDon();
            this.loadChiTietHoaDonTableAdapter1 = new CSDLPT_QuanLyDienThoai.DB_Layer.ChiTietHoaDonTableAdapters.LoadChiTietHoaDonTableAdapter();
            this.bindingSourceChiTietHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.maCTHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đơnGiáDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETHOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDienThoai
            // 
            this.btnDienThoai.Location = new System.Drawing.Point(917, 10);
            this.btnDienThoai.Name = "btnDienThoai";
            this.btnDienThoai.Size = new System.Drawing.Size(75, 23);
            this.btnDienThoai.TabIndex = 0;
            this.btnDienThoai.Text = "Dien Thoai";
            this.btnDienThoai.UseVisualStyleBackColor = true;
            this.btnDienThoai.Click += new System.EventHandler(this.btnDienThoai_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã HD";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(95, 44);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(121, 20);
            this.txtMaHD.TabIndex = 3;
            // 
            // dgvHOADON
            // 
            this.dgvHOADON.AutoGenerateColumns = false;
            this.dgvHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvHOADON.DataSource = this.bindingSourceHoaDon;
            this.dgvHOADON.Location = new System.Drawing.Point(12, 242);
            this.dgvHOADON.Name = "dgvHOADON";
            this.dgvHOADON.Size = new System.Drawing.Size(445, 145);
            this.dgvHOADON.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã NV";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(95, 124);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(121, 20);
            this.txtMaKho.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã KHO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã KH";
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(95, 159);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(121, 21);
            this.cmbMaKH.TabIndex = 11;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(777, 12);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(121, 21);
            this.cmbChiNhanh.TabIndex = 12;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(95, 79);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(121, 20);
            this.txtMaNV.TabIndex = 13;
            // 
            // dgvCHITIETHOADON
            // 
            this.dgvCHITIETHOADON.AutoGenerateColumns = false;
            this.dgvCHITIETHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCHITIETHOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCTHDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.maDTDataGridViewTextBoxColumn,
            this.đơnGiáDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvCHITIETHOADON.DataSource = this.bindingSourceChiTietHoaDon;
            this.dgvCHITIETHOADON.Location = new System.Drawing.Point(484, 242);
            this.dgvCHITIETHOADON.Name = "dgvCHITIETHOADON";
            this.dgvCHITIETHOADON.Size = new System.Drawing.Size(484, 145);
            this.dgvCHITIETHOADON.TabIndex = 14;
            // 
            // hoaDon1
            // 
            this.hoaDon1.DataSetName = "HoaDon";
            this.hoaDon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadHoaDonTableAdapter1
            // 
            this.loadHoaDonTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSourceHoaDon
            // 
            this.bindingSourceHoaDon.DataMember = "LoadHoaDon";
            this.bindingSourceHoaDon.DataSource = this.hoaDon1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaNV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaKho";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaKho";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaKH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // chiTietHoaDon1
            // 
            this.chiTietHoaDon1.DataSetName = "ChiTietHoaDon";
            this.chiTietHoaDon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadChiTietHoaDonTableAdapter1
            // 
            this.loadChiTietHoaDonTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSourceChiTietHoaDon
            // 
            this.bindingSourceChiTietHoaDon.DataMember = "LoadChiTietHoaDon";
            this.bindingSourceChiTietHoaDon.DataSource = this.chiTietHoaDon1;
            // 
            // maCTHDDataGridViewTextBoxColumn
            // 
            this.maCTHDDataGridViewTextBoxColumn.DataPropertyName = "MaCTHD";
            this.maCTHDDataGridViewTextBoxColumn.HeaderText = "MaCTHD";
            this.maCTHDDataGridViewTextBoxColumn.Name = "maCTHDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAHD";
            this.dataGridViewTextBoxColumn5.HeaderText = "MAHD";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // maDTDataGridViewTextBoxColumn
            // 
            this.maDTDataGridViewTextBoxColumn.DataPropertyName = "MaDT";
            this.maDTDataGridViewTextBoxColumn.HeaderText = "MaDT";
            this.maDTDataGridViewTextBoxColumn.Name = "maDTDataGridViewTextBoxColumn";
            // 
            // đơnGiáDataGridViewTextBoxColumn
            // 
            this.đơnGiáDataGridViewTextBoxColumn.DataPropertyName = "Đơn Giá";
            this.đơnGiáDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.đơnGiáDataGridViewTextBoxColumn.Name = "đơnGiáDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(561, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(561, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã KH";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(561, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã KHO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã NV";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(561, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã HD";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 389);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvCHITIETHOADON);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.cmbMaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHOADON);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDienThoai);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETHOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDienThoai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvHOADON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private DB_Layer.HoaDon hoaDon;
        private DB_Layer.HoaDonTableAdapters.LoadHoaDonTableAdapter loadHoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridView dgvCHITIETHOADON;
        private DB_Layer.HoaDon hoaDon1;
        private DB_Layer.HoaDonTableAdapters.LoadHoaDonTableAdapter loadHoaDonTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSourceHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DB_Layer.ChiTietHoaDon chiTietHoaDon1;
        private DB_Layer.ChiTietHoaDonTableAdapters.LoadChiTietHoaDonTableAdapter loadChiTietHoaDonTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSourceChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCTHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đơnGiáDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}