using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using Nhom11_Quanlybangiay.NhapHang;
namespace Nhom11_Quanlybangiay.Người_quản_lí
{
    public partial class frmNguoiquanli : Form
    {
        dataMaNQL data = new dataMaNQL();
        public frmNguoiquanli()
        {
            InitializeComponent();
        }
        void getheader()
        { //TẠO HEADER
            dgvDanhSach.Columns[0].HeaderText = "Mã tài khoản";
            dgvDanhSach.Columns[0].Width = 100;
            dgvDanhSach.Columns[1].HeaderText = "Tên tài khoản";
            dgvDanhSach.Columns[1].Width = 250;
            dgvDanhSach.Columns[2].HeaderText = "Số điện thoại";
            dgvDanhSach.Columns[2].Width = 120;
            dgvDanhSach.Columns[3].HeaderText = "Địa chỉ ";
            dgvDanhSach.Columns[3].Width = 150;
            dgvDanhSach.Columns[4].HeaderText = "Mật khẩu ";
            dgvDanhSach.Columns[5].HeaderText = "Loại tài khoản ";
        }
        private void frmNguoiquanli_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = data.hienthi();
           
            //HIỂN THỊ THÔNG TIN
            getheader();
        }

        private void txtmaNQL_Click(object sender, EventArgs e)
        {
            txtTenNQL.Enabled = false; // KHI ẤN VÀO ĐÂY NÚT TÌM KIA SẼ BỊ BÔI ĐEN
        }

        private void txtTenNQL_Click(object sender, EventArgs e)
        {
            txtmaNQL.Enabled = false;// KHI ẤN VÀO ĐÂY NÚT TÌM KIA SẼ BỊ BÔI ĐEN
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BTN FILLTER

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtmaNQL.Text;//GÁN GIÁ TRỊ ĐÊ THỰC HIỆN XEM CHI TIẾT MỘT HÓA ĐƠN
            string tennql = txtTenNQL.Text;//GÁN GIÁ TRỊ ĐÊ THỰC HIỆN XEM CHI TIẾT MỘT HÓA ĐƠN
            string sql = "Select * from Nguoiquanli where MaNQL like '%'+'" + manql + "'+'%' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvDanhSach.DataSource = dt;
            con.Close();
            
        }
        private void clear()
        {
            //BTN CLEAR
            txtmaNQL.Clear();
            txtTenNQL.Clear();
            txtMa.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtDiachi.Clear();
            txtMatKhau.Clear();

        }
        private void btnreload_Click(object sender, EventArgs e)
        {
            //BTN RELOAD
            dgvDanhSach.DataSource = data.hienthi();
            clear();
            txtmaNQL.Enabled = true;
            txtTenNQL.Enabled = true;
            txtMa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Text.Trim();
            txtMatKhau.Text.Trim();
            txtTen.Text.Trim();
            txtSDT.Text.Trim();
            txtDiachi.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtDiachi.Text) )
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!");
            }
            else if(txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Điện thoại phải có 10 số ");
            }    
            else
            {
                if (cbtinhtrang.Text.Equals("VHH") || cbtinhtrang.Text.Equals("ADMIN") || cbtinhtrang.Text.Equals("NV"))
                {
                    // KIỂM TRA TÍNH HỢP LỆ DỮ LIỆU
                    data.them(txtMa.Text, txtTen.Text, txtSDT.Text, txtDiachi.Text, txtMatKhau.Text, cbtinhtrang.Text);
                    dgvDanhSach.DataSource = data.hienthi();
                    clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng xem lại tình trạng!!!");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtMa.Text = dgvDanhSach.Rows[d].Cells[0].Value.ToString();
                txtTen.Text = dgvDanhSach.Rows[d].Cells[1].Value.ToString();
                txtSDT.Text = dgvDanhSach.Rows[d].Cells[2].Value.ToString();
                txtDiachi.Text = dgvDanhSach.Rows[d].Cells[3].Value.ToString();
                txtMatKhau.Text = dgvDanhSach.Rows[d].Cells[4].Value.ToString();
                cbtinhtrang.Text = dgvDanhSach.Rows[d].Cells[5].Value.ToString();
                txtMa.Enabled = false;
            }
            catch (Exception)
            {
                //TRƯỜNG HỢP D=-1

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtDiachi.Text))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!");
            }
            else if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Điện thoại phải có 10 số ");
            }

            else
            {
                if (cbtinhtrang.Text.Equals("VHH") || cbtinhtrang.Text.Equals("ADMIN") || cbtinhtrang.Text.Equals("NV"))
                {
                    data.sua(txtMa.Text, txtTen.Text, txtSDT.Text, txtDiachi.Text, txtMatKhau.Text, cbtinhtrang.Text);
                    dgvDanhSach.DataSource = data.hienthi();
                    clear();

                }
                else
                {
                    MessageBox.Show("Vui lòng xem lại tình trạng!!!"); // KIỂM TRA TÍNH HỢP LỆ DỮ LIỆU
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //BTN XÓA
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn xóa không tất cả dữ liệu về người này sẽ bị xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (kq.Equals(DialogResult.Yes))
            {
                data.xoa(txtMa.Text);
                dgvDanhSach.DataSource = data.hienthi();
                clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa chọn một bản ghi nào!!!");
            }
            else
            {
                // XEM HÓA ĐƠN ĐÃ NHẬP THEO NHÂN VIÊN
                frmNhungHangDaNhapTheoTuNhanVien f = new frmNhungHangDaNhapTheoTuNhanVien(txtMa.Text);
                f.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtmaNQL.Text;//GÁN GIÁ TRỊ ĐÊ THỰC HIỆN XEM CHI TIẾT MỘT HÓA ĐƠN
            string tennql = txtTenNQL.Text;//GÁN GIÁ TRỊ ĐÊ THỰC HIỆN XEM CHI TIẾT MỘT HÓA ĐƠN
            string sql = "Select * from Nguoiquanli where tennql LIKE '%'+N'" + tennql + "'+ '%'    ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvDanhSach.DataSource = dt;
            con.Close();
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenNQL_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtmaNQL.Text;//GÁN GIÁ TRỊ ĐÊ THỰC HIỆN XEM CHI TIẾT MỘT HÓA ĐƠN
            string tennql = txtTenNQL.Text;//GÁN GIÁ TRỊ ĐÊ THỰC HIỆN XEM CHI TIẾT MỘT HÓA ĐƠN
            string sql = "Select * from Nguoiquanli where tennql LIKE '%'+N'" + tennql + "'+ '%'    ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvDanhSach.DataSource = dt;
            con.Close();
        }

        private void txtmaNQL_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtmaNQL.Text;//GÁN GIÁ TRỊ ĐÊ THỰC HIỆN XEM CHI TIẾT MỘT HÓA ĐƠN
            string tennql = txtTenNQL.Text;//GÁN GIÁ TRỊ ĐÊ THỰC HIỆN XEM CHI TIẾT MỘT HÓA ĐƠN
            string sql = "Select * from Nguoiquanli where MaNQL like '%'+'" + manql + "'+'%' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvDanhSach.DataSource = dt;
            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
