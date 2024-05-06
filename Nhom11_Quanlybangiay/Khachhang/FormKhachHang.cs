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

namespace Nhom11_Quanlybangiay.Khachhang
{
    public partial class frmkhachhang : Form
    {
        public string manql { get; set; } // TRUYỀN DỮ TỪ FORM ĐĂNG NHẬP SANG FORM NÀY
        public frmkhachhang()
        {
            InitializeComponent();
        }
        dataKhachHang data = new dataKhachHang();
        

        private void txtTimtheoten_Click(object sender, EventArgs e)
        {
            txtTimtheosdt.Enabled = false; // CLICK VÀO BUTTON TÌM SẼ BỊ BÔI ĐEN
        }

        private void txtTimtheosdt_Click(object sender, EventArgs e)
        {
            txtTimtheoten.Enabled = false;// CLICK VÀO BUTTON TÌM SẼ BỊ BÔI ĐEN
        }
        private void clear()
        {
            txtsdt.Enabled = true;
            txtTimtheosdt.Enabled = true;
            txtTimtheoten.Enabled = true;
            txtsdt.Clear();
            txttenkh.Clear();
            txtTimtheoten.Clear();
            txtTimtheosdt.Clear();
            txtdiachi.Clear();
        }
        private void frmkhachhang_Load(object sender, EventArgs e)
        {
         
            dgvKH.DataSource = data.xemKH(); // XEM  KHÁCH HÀNG
            clear();
            GetHeader();
            dgvKH.Columns[0].Width = 150;
            dgvKH.Columns[1].Width = 250;
            dgvKH.Columns[2].Width = 250;
            lblSLKH.Text = "Số lượng khách hàng: " + dgvKH.Rows.Count;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {// RELOAD
            dgvKH.DataSource = data.xemKH();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //BTN TÌM THEO TÊN 
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtTimtheosdt.Text;
            string tennql = txtTimtheoten.Text;

            string sql = "Select * from khachhang where SDT_KH='" + manql + "' or TENKH like '%'+N'" + tennql + "'+'%'   ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvKH.DataSource = dt;
            con.Close();
            clear();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtsdt.Text = dgvKH.Rows[d].Cells[0].Value.ToString();
                txttenkh.Text = dgvKH.Rows[d].Cells[1].Value.ToString();
                txtdiachi.Text = dgvKH.Rows[d].Cells[2].Value.ToString();
                txtsdt.Enabled = false;
                
            }
            catch (Exception)
            {
                // TRƯỜNG HỢP D=-1;
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtsdt.Text)||string.IsNullOrWhiteSpace(txttenkh.Text)||string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!");
                //TRƯỜNG HỢP KHÔNG CÓ DỮ LIỆU Ở Ô TEXTBOX
            } 
            else if(txtsdt.Text.Length != 10)
            {
                MessageBox.Show("Điện thoại phải có 10 số!!!");
            }    
            else
            {
                data.themkh(txtsdt.Text, txttenkh.Text, txtdiachi.Text);
                dgvKH.DataSource = data.xemKH();
                
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // SỬA MỘT KHÁCH HÀNG
            if (string.IsNullOrWhiteSpace(txtsdt.Text) || string.IsNullOrWhiteSpace(txttenkh.Text) || string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!");
                //TRƯỜNG HỢP KHÔNG CÓ DỮ LIỆU Ở Ô TEXTBOX
            }
            else if (txtsdt.Text.Length != 10)
            {
                MessageBox.Show("Điện thoại phải có 10 số!!!");
            }
            {
                data.suakh(txtsdt.Text, txttenkh.Text, txtdiachi.Text);
                dgvKH.DataSource = data.xemKH();
                clear();
            }    
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetHeader()
        {
            // LẤY RA HEADER
            dgvKH.Columns[0].HeaderText = "Số điện thoại";
            
            dgvKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvKH.Columns[2].HeaderText = "Địa chỉ khách hàng";
            dgvKH.Columns[3].HeaderText = "Số tiền đã cọc";

        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTimtheoten_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string tennql = txtTimtheoten.Text;
            string sql = "Select * from khachhang where  TENKH like '%'+N'" + tennql + "'+'%'   ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvKH.DataSource = dt;
            con.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {// tìm theo số điện thoại

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtTimtheosdt.Text;
            string sql = "Select * from khachhang where SDT_KH='" + manql + "'  ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvKH.DataSource = dt;
            con.Close();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtsdt.Text = dgvKH.Rows[d].Cells[0].Value.ToString();
                txttenkh.Text = dgvKH.Rows[d].Cells[1].Value.ToString();
                txtdiachi.Text = dgvKH.Rows[d].Cells[2].Value.ToString();
                txtsdt.Enabled = false;

            }
            catch (Exception)
            {
                // TRƯỜNG HỢP D=-1;

            }
        }

        private void txtTimtheosdt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtTimtheosdt.Text;
            
            string sql = "Select * from khachhang where SDT_KH like '" + manql + "'+'%'  ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvKH.DataSource = dt;
            con.Close();
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtsdt.Text;

            string sql = "Select * from khachhang where SDT_KH like '" + manql + "'+'%'  ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvKH.DataSource = dt;
            con.Close();
        }

        private void txttenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txttenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
