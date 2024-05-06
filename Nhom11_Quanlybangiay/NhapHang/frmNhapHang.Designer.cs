
namespace Nhom11_Quanlybangiay.NhapHang
{
    partial class frmNhapHang
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
            this.SOhd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbboxncc = new System.Windows.Forms.ComboBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbnguoilap = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbsize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.txtDGnhap = new System.Windows.Forms.TextBox();
            this.cbboxTenSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvdanhsachhang = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachhang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SOhd
            // 
            this.SOhd.AutoSize = true;
            this.SOhd.Location = new System.Drawing.Point(6, 35);
            this.SOhd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SOhd.Name = "SOhd";
            this.SOhd.Size = new System.Drawing.Size(120, 19);
            this.SOhd.TabIndex = 0;
            this.SOhd.Text = "Số hóa đơn nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT_NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ NCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Người lập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbboxncc);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtsohd);
            this.groupBox1.Controls.Add(this.SOhd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(305, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbboxncc
            // 
            this.cbboxncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxncc.FormattingEnabled = true;
            this.cbboxncc.Location = new System.Drawing.Point(135, 68);
            this.cbboxncc.Margin = new System.Windows.Forms.Padding(4);
            this.cbboxncc.Name = "cbboxncc";
            this.cbboxncc.Size = new System.Drawing.Size(140, 27);
            this.cbboxncc.TabIndex = 1;
            this.cbboxncc.SelectedIndexChanged += new System.EventHandler(this.cbboxncc_SelectedIndexChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(135, 142);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(140, 27);
            this.txtsdt.TabIndex = 3;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Enabled = false;
            this.txtdiachi.Location = new System.Drawing.Point(135, 106);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(140, 27);
            this.txtdiachi.TabIndex = 2;
            // 
            // txtsohd
            // 
            this.txtsohd.Enabled = false;
            this.txtsohd.Location = new System.Drawing.Point(135, 35);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(4);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(140, 27);
            this.txtsohd.TabIndex = 0;
            this.txtsohd.TextChanged += new System.EventHandler(this.txtsohd_TextChanged);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(93, 80);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(135, 27);
            this.dtpNgayNhap.TabIndex = 1;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // cbnguoilap
            // 
            this.cbnguoilap.Enabled = false;
            this.cbnguoilap.FormattingEnabled = true;
            this.cbnguoilap.Location = new System.Drawing.Point(93, 45);
            this.cbnguoilap.Margin = new System.Windows.Forms.Padding(4);
            this.cbnguoilap.Name = "cbnguoilap";
            this.cbnguoilap.Size = new System.Drawing.Size(135, 27);
            this.cbnguoilap.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbsize);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtSLNhap);
            this.groupBox2.Controls.Add(this.txtDGnhap);
            this.groupBox2.Controls.Add(this.cbboxTenSP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(771, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(248, 229);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin về sản phẩm nhập";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbbsize
            // 
            this.cbbsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbsize.FormattingEnabled = true;
            this.cbbsize.Items.AddRange(new object[] {
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44"});
            this.cbbsize.Location = new System.Drawing.Point(105, 76);
            this.cbbsize.Name = "cbbsize";
            this.cbbsize.Size = new System.Drawing.Size(131, 27);
            this.cbbsize.TabIndex = 1;
            this.cbbsize.SelectedIndexChanged += new System.EventHandler(this.cbbsize_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Size";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(105, 193);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.MaxLength = 15;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(131, 27);
            this.txtThanhTien.TabIndex = 4;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(105, 115);
            this.txtSLNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLNhap.MaxLength = 15;
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(131, 27);
            this.txtSLNhap.TabIndex = 3;
            this.txtSLNhap.Text = "0";
            this.txtSLNhap.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtSLNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLNhap_KeyPress);
            // 
            // txtDGnhap
            // 
            this.txtDGnhap.Location = new System.Drawing.Point(105, 154);
            this.txtDGnhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDGnhap.MaxLength = 15;
            this.txtDGnhap.Name = "txtDGnhap";
            this.txtDGnhap.Size = new System.Drawing.Size(131, 27);
            this.txtDGnhap.TabIndex = 2;
            this.txtDGnhap.Text = "0";
            this.txtDGnhap.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtDGnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDGnhap_KeyPress);
            // 
            // cbboxTenSP
            // 
            this.cbboxTenSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxTenSP.FormattingEnabled = true;
            this.cbboxTenSP.Location = new System.Drawing.Point(105, 37);
            this.cbboxTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbboxTenSP.Name = "cbboxTenSP";
            this.cbboxTenSP.Size = new System.Drawing.Size(131, 27);
            this.cbboxTenSP.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "SL Nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "ĐG Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên SP";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Nhom11_Quanlybangiay.Properties.Resources.remove_format;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(50, 318);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa sản phẩm ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(418, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 38);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hóa đơn nhập hàng";
            // 
            // dgvdanhsachhang
            // 
            this.dgvdanhsachhang.AllowUserToAddRows = false;
            this.dgvdanhsachhang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdanhsachhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdanhsachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachhang.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdanhsachhang.Location = new System.Drawing.Point(50, 388);
            this.dgvdanhsachhang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdanhsachhang.Name = "dgvdanhsachhang";
            this.dgvdanhsachhang.ReadOnly = true;
            this.dgvdanhsachhang.RowHeadersWidth = 51;
            this.dgvdanhsachhang.RowTemplate.Height = 24;
            this.dgvdanhsachhang.Size = new System.Drawing.Size(789, 193);
            this.dgvdanhsachhang.TabIndex = 6;
            this.dgvdanhsachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsachhang_CellClick);
            this.dgvdanhsachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsachhang_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(888, 531);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tổng tiền";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtien.ForeColor = System.Drawing.Color.Red;
            this.lblTongtien.Location = new System.Drawing.Point(1000, 531);
            this.lblTongtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(23, 26);
            this.lblTongtien.TabIndex = 13;
            this.lblTongtien.Text = "0";
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Nhom11_Quanlybangiay.Properties.Resources.Exit_ForMat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(280, 318);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "Hủy hóa đơn này";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Nhom11_Quanlybangiay.Properties.Resources.ADD_FORMAT;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(50, 258);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thêm sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ngày lập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNgayNhap);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cbnguoilap);
            this.groupBox3.Location = new System.Drawing.Point(441, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 128);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin về người lập";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdanhsachhang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Nhập hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachhang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SOhd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbnguoilap;
        private System.Windows.Forms.ComboBox cbboxncc;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDGnhap;
        private System.Windows.Forms.ComboBox cbboxTenSP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdanhsachhang;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.ComboBox cbbsize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}