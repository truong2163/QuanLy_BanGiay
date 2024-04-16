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
using System.Data;
using System.Text.RegularExpressions;

namespace FormLogin
{
    public partial class Form1 : Form
    {
        // Danh sách nhân viên và mật khẩu
        Dictionary<string, string> nhanVien = new Dictionary<string, string>()
        {
    { "nhanvien1", "matkhau1" },
    { "nhanvien2", "matkhau2" },
    { "nhanvien3", "matkhau3" },
        };

        int soLanSai = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTenDangNhap.Text, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Tên đăng nhập không được chứa ký tự đặc biệt.");
                return;
            }

            // Check if the password is at least 6 characters long
            if (txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải từ 6 ký tự trở lên.");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RIFIUM18;Initial Catalog=QuanLy;Integrated Security=True;");
            try
            {
                con.Open();
                string tenDangNhap = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;
                string sql = "SELECT * FROM NguoiDung WHERE TaiKhoan = @TenDangNhap AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read())
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công!");
                }
                else if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!");
                }
                // Kiểm tra tên đăng nhập và mật khẩu
                else if (nhanVien.ContainsKey(tenDangNhap) && nhanVien[tenDangNhap] == matKhau)
                {
                    soLanSai = 0;
                    MessageBox.Show("Bạn đã đăng nhập thành công!");
                }
                else
                {
                    soLanSai++;
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");

                    if (soLanSai >= 3)
                    {
                        MessageBox.Show("Bạn đã nhập sai quá 3 lần. Hệ thống sẽ tự động thoát!");
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtTenDangNhap.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
