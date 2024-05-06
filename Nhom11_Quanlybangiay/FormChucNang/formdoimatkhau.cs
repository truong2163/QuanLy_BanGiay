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
namespace Nhom11_Quanlybangiay.FormChucNang
{
    public partial class formdoimatkhau : Form
    {
        string tk, mk;
        public formdoimatkhau(string tk, string mk)
        {
            InitializeComponent();
            this.mk = mk;
            this.tk = tk;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtmakhaumoi2.Text)||string.IsNullOrWhiteSpace(txtmatkhaumoi.Text)||string.IsNullOrWhiteSpace(txtMkCu.Text))
            {
                MessageBox.Show("Không được để trống");
            }
            else

            {
                if (txtmatkhaumoi.Text == txtmakhaumoi2.Text && mk==txtMkCu.Text )

                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True");
                        con.Open();
                        string sql = "update  Nguoiquanli set mat_khau='" + txtmatkhaumoi.Text + "' where manql='" + tk + "' and mat_khau='" + mk + "' "; // ĐỔI MẬT KHẨU
                        SqlCommand cmd = new SqlCommand(sql, con); // TRUYỀN VÀO THAM CHIẾU VÀ THAM TRỊ
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đổi thành công");
                        con.Close();
                        this.Close();
                    }
                    catch (Exception EX)
                    {

                        MessageBox.Show("Đổi mật khẩu thất bại", EX.Message); // NẾU MẬT KHẨU SAI
                        txtMkCu.Clear();
                        txtmakhaumoi2.Clear();
                        txtmatkhaumoi.Clear();
                    }
                }

                else
                {
                    MessageBox.Show("Đổi thất bại!!!"); // TƯỜNG HỢP 2 MẬT KHẨU TRÊN DƯỚI KHÔNG GIỐNG NHAU 

                    txtmakhaumoi2.Clear();
                    txtmatkhaumoi.Clear();
                }
            }

        }

        private void formdoimatkhau_Load(object sender, EventArgs e)
        {

        }
    }
}
