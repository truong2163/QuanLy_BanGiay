using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.FrmLogin1
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTenTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            string sql = "Select * from Nguoiquanli where MaNQL='" + txtMaTk.Text + "' and tennql=N'" + txtTenTK.Text + "' and sdt_nql=N'"+txtSoDT.Text+"' and Diachi_nql=N'"+txtDiaChi.Text+"'  ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            if(dt.Read()==true)
            {
                con.Close();
                con.Open();
                string sql_laylaimatkhau = "Select mat_khau from nguoiquanli where manql='"+txtMaTk.Text+"'";
                DataTable dt_laylaimatkhau = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(sql_laylaimatkhau, con);
                adap.Fill(dt_laylaimatkhau);
                MessageBox.Show("Lấy lại mật khẩu thành công !!! Mật khẩu của bạn là "+dt_laylaimatkhau.Rows[0][0].ToString());
                con.Close();
                txtMaTk.Clear();
                txtDiaChi.Clear();
                txtSoDT.Clear();
                txtTenTK.Clear();
            }
            
            else
            {
                MessageBox.Show("Lấy lại mật khẩu thất bại, vui lòng xem lại thông tin");
                con.Close();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
