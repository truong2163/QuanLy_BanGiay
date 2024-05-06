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
namespace Nhom11_Quanlybangiay.ThemSanPham
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        dataSanPham data = new dataSanPham();
        private void button1_Click(object sender, EventArgs e)
        {
            txtGiaBan.Enabled = true;
            dgvsanpham.DataSource = data.Xemtatsanpham();
            clear();
        }

        private void txtTimTenSP_Click(object sender, EventArgs e)
        {
            txtTimmaSP.Enabled = false; // BÔI ĐEN CỘT TÌM THEO MÃ
        }

        private void txtTimmaSP_Click(object sender, EventArgs e)
        {
            txtTimTenSP.Enabled = false;// BÔI ĐEN CỘT TÌM THEO TÊN
        }
        private void clear()
        {
            // BTN CLEAR
            txtMaSP.Enabled = false;
            txtTimmaSP.Enabled = true;
            txtTimTenSP.Enabled = true;
            txtMaSP.Clear();
            txtTenSP.Clear();
            cbbsize.SelectedIndex = -1;
            txtSlcon.Clear();
            txtTimTenSP.Clear();
            txtTimmaSP.Clear();
            txtGiaBan.Clear();
    
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            //BTN TÌM
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            //TẠO KẾT NỐI
            DataTable dt = new DataTable();
            string masp = txtTimmaSP.Text;
            string tensp = txtTimTenSP.Text;
            string sql = "Select * from Sanpham where masp='" + masp + "'   ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvsanpham.DataSource = dt;
            con.Close();
        }
        private void getheader()
        {
            //LẤY RA HEADER
            dgvsanpham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvsanpham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvsanpham.Columns[1].Width = 160;
            dgvsanpham.Columns[2].HeaderText = "Giá bán";
            dgvsanpham.Columns[3].HeaderText = "Tình trạng nhập";

        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            //SẢN PHẨM LOAD
            dgvsanpham.DataSource = data.Xemtatsanpham();
            cbbTinhTrang.SelectedIndex = 0;
            getheader();
            //THỐNG KÊ SỐ LƯỢNG SẢN PHẨM
            lblTK.Text = "Số lượng sản phẩm: " + dgvsanpham.Rows.Count;
        }
        private void getheadersize()
        {
            dgvSoLuong.Columns[0].HeaderText = "Tên sản phẩm";
            dgvSoLuong.Columns[0].Width = 160;
            dgvSoLuong.Columns[1].HeaderText = "Size"; ;
            dgvSoLuong.Columns[2].HeaderText = "Số lượng còn";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            // ĐÓNG FORM
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtMaSP.Text = dgvsanpham.Rows[d].Cells[0].Value.ToString() ;
                txtTenSP.Text = dgvsanpham.Rows[d].Cells[1].Value.ToString();
                txtGiaBan.Text = dgvsanpham.Rows[d].Cells[2].Value.ToString();
                cbbTinhTrang.Text = dgvsanpham.Rows[d].Cells[3].Value.ToString();
                txtMaSP.Enabled = false;
                cbbsize.SelectedIndex = -1;
                txtSlcon.Clear();
                dgvSoLuong.DataSource = data.LayRaSizeVaSoLuong(Convert.ToInt32(dgvsanpham.Rows[d].Cells[0].Value.ToString()));
                getheadersize();
                sua = 1;
            }
            catch (Exception)
            {
                //TRƯỜNG HỢP D=-1

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //BTN THÊM MỘT SẢN PHẨM
            if (string.IsNullOrWhiteSpace(txtTenSP.Text)  || string.IsNullOrWhiteSpace(txtGiaBan.Text)||string.IsNullOrWhiteSpace(cbbTinhTrang.Text))
            {
                MessageBox.Show("Dữ liệu bạn nhập chưa hợp lệ");
            }

            else
            {
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;

                try
                {
                    int giaban = Convert.ToInt32(txtGiaBan.Text);
                    data.themMotSanPham(txtTenSP.Text, Convert.ToInt32(txtGiaBan.Text),cbbTinhTrang.Text);
                    dgvsanpham.DataSource = data.Xemtatsanpham();
                    lblTK.Text = "Số lượng sản phẩm: " + dgvsanpham.Rows.Count;
                    clear();
                }
                catch (Exception)
                {

                    MessageBox.Show("Dữ liệu bạn nhập có thể không hợp lệ");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //BTN SỬA

            if (string.IsNullOrWhiteSpace(txtTenSP.Text)  || string.IsNullOrWhiteSpace(txtGiaBan.Text)||string.IsNullOrWhiteSpace(txtMaSP.Text)||string.IsNullOrWhiteSpace(cbbTinhTrang.Text))
            {
                MessageBox.Show("Dữ liệu nhập không được để trắng");
            }
            else
            {
               if(sua==1)
                {

                    int masp = Convert.ToInt32(txtMaSP.Text);

                    string tensp = txtTenSP.Text;

                    string tinhtrang = cbbTinhTrang.Text;

                    int giaban = Convert.ToInt32(txtGiaBan.Text);

                    data.suathongtin(masp, tensp, giaban, tinhtrang);
                    dgvsanpham.DataSource = data.Xemtatsanpham();
                    clear();
                }  
               else
                {
                    int masp = Convert.ToInt32(txtMaSP.Text);

                    string tensp = txtTenSP.Text;

                    string tinhtrang = cbbTinhTrang.Text;

                    int giaban = Convert.ToInt32(txtGiaBan.Text);

                    data.suathongtin1(masp, tensp, giaban, tinhtrang);
                    dgvsanpham.DataSource = data.Xemtatsanpham();
                    clear();

                }
               
               
            }    

               
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //XÓA SẢN PHẨM
            DialogResult kq = MessageBox.Show("Mọi thông tin về sản phẩm này không thể khôi phục bạn có chắc chắn không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq.Equals(DialogResult.Yes))
            {

                string masp = txtMaSP.Text;
                data.xoamotsanpham(masp);
                dgvsanpham.DataSource = data.Xemtatsanpham();
                clear();

            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtSLcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dgvSoLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            try
            {
                cbbsize.Text = dgvSoLuong.Rows[d].Cells[1].Value.ToString();
                txtSlcon.Text = dgvSoLuong.Rows[d].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void txtSlcon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dgvSoLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text)||string.IsNullOrWhiteSpace(cbbsize.Text) || string.IsNullOrWhiteSpace(txtSlcon.Text) || string.IsNullOrWhiteSpace(cbbsize.Text)) 
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ !!!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                data.themsize(Convert.ToInt32(txtMaSP.Text), cbbsize.Text, Convert.ToInt32(txtSlcon.Text));
                dgvSoLuong.DataSource = data.LayRaSizeVaSoLuong(Convert.ToInt32(txtMaSP.Text));
                getheadersize();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtSlcon.Text)||string.IsNullOrWhiteSpace(cbbsize.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống!!!");
            }    
            else

            {
                data.suasoluong(Convert.ToInt32(txtMaSP.Text), cbbsize.Text, Convert.ToInt32(txtSlcon.Text));
                dgvSoLuong.DataSource = data.LayRaSizeVaSoLuong(Convert.ToInt32(txtMaSP.Text));
                getheadersize();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open(); 
            //TẠO KẾT NỐI
            DataTable dt = new DataTable();
            string masp = txtTimmaSP.Text;
            string tensp = txtTimTenSP.Text;
            string sql = "Select * from Sanpham where  tensp like '%'+N'" + tensp + "'+'%'   ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvsanpham.DataSource = dt;
            con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int sua ;
        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            sua = 0;
        }

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
