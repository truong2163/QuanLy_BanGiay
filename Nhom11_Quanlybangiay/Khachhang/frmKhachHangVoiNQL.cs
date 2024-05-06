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
    public partial class frmKhachHangVoiNQL : Form
    {
        public frmKhachHangVoiNQL()
        {
            InitializeComponent();
        }
        dataKhachHang data = new dataKhachHang();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //BTN TÌM

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

        private void txtTimtheoten_Click(object sender, EventArgs e)
        {
            txtTimtheosdt.Enabled = false; // KHI CLICK VÀO TÌM CÁI KIA CÁI NÀY SẼ BỊ ĐEN
        }

        private void txtTimtheosdt_Click(object sender, EventArgs e)
        {
            txtTimtheoten.Enabled = false;// KHI CLICK VÀO TÌM CÁI KIA CÁI NÀY SẼ BỊ ĐEN
        }
        private void getheader()
        {
            // LẤY RA HEADER
            dgvKH.Columns[0].HeaderText = "Số điện thoại";
            dgvKH.Columns[0].Width = 150;
            dgvKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvKH.Columns[1].Width = 200;
            dgvKH.Columns[2].HeaderText = "Địa chỉ ";
            dgvKH.Columns[2].Width = 200;
            dgvKH.Columns[3].HeaderText = "Số tiền đã cọc";
            dgvKH.Columns[3].Width = 150;
        }
        private void frmKhachHangVoiNQL_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = data.xemKH(); // XEM THÔNG TIN MỘT KHÁCH HÀNG
            clear();
            getheader();
            lblTK.Text = "Tổng số khách hàng: " + dgvKH.Rows.Count;
        }
        private void clear()
        { //CLEAR
            txtsdt.Enabled = true;
            txtTimtheosdt.Enabled = true;
            txtTimtheoten.Enabled = true;
            txtsdt.Clear();
            txttenkh.Clear();
            txtTimtheoten.Clear();
            txtTimtheosdt.Clear();
            txtdiachi.Clear();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //BTN XEM KH
            dgvKH.DataSource = data.xemKH();
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BTN SỬA KH
            if(string.IsNullOrWhiteSpace(txtsdt.Text)||string.IsNullOrWhiteSpace(txttenkh.Text)||string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Dữ liệu không được để trắng!!!");
            }    
            else
            {
                data.suakh(txtsdt.Text, txttenkh.Text, txtdiachi.Text);
                dgvKH.DataSource = data.xemKH();
                clear();
            }    
            
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
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
                //TRƯỜNG HỢP D=-1
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa, dữ liệu không thể khôi phục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(kq.Equals(DialogResult.Yes))
            {//XÓA DỮ LIỆU
                data.xoakh(txtsdt.Text);
                dgvKH.DataSource = data.xemKH();
                clear();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string manql = txtTimtheosdt.Text;
            string tennql = txtTimtheoten.Text;
            string sql = "Select * from khachhang where SDT_KH='" + manql + "'   ";

            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvKH.DataSource = dt;
            con.Close();
            clear();
        }

        
    }
}
