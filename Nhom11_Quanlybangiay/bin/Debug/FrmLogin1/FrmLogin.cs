using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Nhom11_Quanlybangiay.FormChucNang;
using Nhom11_Quanlybangiay.FrmLogin1;

namespace Nhom11_Quanlybangiay.FrmLogin
{
    public partial class FrmLogin : Form
    {
        public string MaNQL { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;  // KIỂM TRA TÀI KHOẢN MẬT KHẨU
            string loaitk;

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            string Layratinhtrangtaikhoan = "exec layratinhtrangNQL '" + tk + "'";
            DataTable datatb = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(Layratinhtrangtaikhoan, con);  // LẤY RA TÌNH TRẠNG CỦA TÀI KHOẢN
            adap.Fill(datatb);
             // TÌNH TRẠNG CỦA TÀI KHOẢN LÀ ĐANG HOẠT ĐỘNG HAY ĐANG KHÔNG HOẠT ĐỘNG
            con.Close();



            con.Open();
            string sql = "Select * from Nguoiquanli where MaNQL='" + tk + "' and mat_khau='" + mk + "'   ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            //NẾU ĐỌC ĐƯỢC DỮ LIỆU THÌ CÓ NGHĨA LÀ TỒN TẠI

            MaNQL = tk;

            if (dt.Read() == true)
            {
                loaitk = datatb.Rows[0][0].ToString();
                if (loaitk.Equals("NV"))
                {
                    this.Hide();
                    frmNV f = new frmNV(tk, mk);
                    MessageBox.Show("Đăng nhập thành công với tư cách nhân viên!!!");
                    // TRUYỀN TK MK SANG FORM KHÁC ĐỂ BÁN HÀNG XUẤT HÀNG
                    f.ShowDialog();
                   
                    this.Close();
                    
                }
                else if(loaitk.Equals("ADMIN"))
                {
                    this.Hide();
                    frmChuCuaHang f = new frmChuCuaHang(tk, mk);
                    MessageBox.Show("Đăng nhập thành công với tư cách chủ cửa hàng!!!");
                    // TRUYỀN TK MK SANG FORM KHÁC ĐỂ BÁN HÀNG XUẤT HÀNG
                    f.ShowDialog();
                    
                    this.Close();
                }
                else  if (loaitk.Equals("VHH"))
                {
                    MessageBox.Show("Tài khoản này bị vô hiệu hóa!!!");
                }    

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }



            con.Close();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           // SET BACK COLOR
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau f = new frmQuenMatKhau();
            f.Show();
        }
    }
}
