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
using System.Data.Sql;
namespace Nhom11_Quanlybangiay.NhapHang
{
    public partial class frmNhapHang : Form
    {
        public string manql { get; set; } // SET UP MÃ NQL
        public frmNhapHang()
        {
            InitializeComponent();
            manql = 1 + "";
        }
        datanhaphang data = new datanhaphang();


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = Convert.ToInt32(txtSLNhap.Text) * Convert.ToInt32(txtDGnhap.Text) + ""; //TÍNH THÀNH TIỀN
            }
            catch (Exception)
            {

                txtThanhTien.Text = "NULL";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void reload()
        {
            dgvdanhsachhang.DataSource = data.xemthongtinsanphamdanhap(Convert.ToInt32(txtsohd.Text));//XEM DGV DANH SÁCH HÀNG
            getheader();
        }
        void getheader()
        {
            //GET HEADER
            dgvdanhsachhang.Columns[0].HeaderText = "Mã sản phẩm";
            dgvdanhsachhang.Columns[1].HeaderText = "Tên sản phẩm";
            dgvdanhsachhang.Columns[2].HeaderText = "Size";
            dgvdanhsachhang.Columns[3].HeaderText = "Đơn giá nhập";
            dgvdanhsachhang.Columns[4].HeaderText = "Số lượng nhập";
            dgvdanhsachhang.Columns[5].HeaderText = "Thành tiền";

            dgvdanhsachhang.Columns[0].Width = 100;
            dgvdanhsachhang.Columns[1].Width = 200;
        
            dgvdanhsachhang.Columns[3].Width = 100;
            dgvdanhsachhang.Columns[4].Width = 100;

        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        { // LẤY RA TÊN SP

            data.xoadl();

            cbboxTenSP.DataSource = data.Xemtatsanpham();
            cbboxTenSP.DisplayMember = "TenSP";
            cbboxTenSP.ValueMember = "MaSP";


            cbboxncc.DataSource = data.xemtatcanhacc();
            cbboxncc.DisplayMember = "Tenncc";// COMBOBOX LẤY RA NCC
            cbboxncc.ValueMember = "Mancc";//NHƯNG GIÁ TRỊ TRUYỀN VÀO LÀ MÃ NCC

            cbbsize.SelectedIndex = 0;


            cbnguoilap.DataSource = data.xemnguoiquanli();
            cbnguoilap.DisplayMember = "TenNQL";//COMBO BOX LÀ TÊN NQL
            cbnguoilap.ValueMember = "MaNQL";// COMBO BOX LÀ MÃ
            cbnguoilap.SelectedValue = manql;


            // TẠO KẾT NỐI
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True");
            DataTable dt = new DataTable();
            // LẤY RA THÔNG TIN MÃ NCC ĐỂ HIỂN THỊ
            string sql = "Select sdt_ncc,diachincc from nhacungcap where mancc='" + cbboxncc.SelectedValue + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            //CHÈN DỮ LIỆU
            txtsdt.Text = dt.Rows[0][0].ToString();
            txtdiachi.Text = dt.Rows[0][1].ToString();
            con.Close();
        }

        private void cbboxncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // TỰ ĐỘNG THAY ĐỔI THÔNG TIN NHÀ CUNG CẤP
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True");
                DataTable dt = new DataTable();
                string sql = "Select sdt_ncc,diachincc from nhacungcap where mancc='" + cbboxncc.SelectedValue + "'";
                SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                adap.Fill(dt);
                txtsdt.Text = dt.Rows[0][0].ToString();
                txtdiachi.Text = dt.Rows[0][1].ToString();
                con.Close();

            }
            catch (Exception)
            {


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSLNhap.Text)||string.IsNullOrWhiteSpace(txtDGnhap.Text))
            {
                MessageBox.Show("Không được để trắng dữ liệu!!!");
            }    
            else if (Convert.ToInt32(txtSLNhap.Text) == 0|| Convert.ToInt32(txtDGnhap.Text)==0)
            {
                MessageBox.Show("Vui lòng chọn số lượng khác 0 !!!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDGnhap.Text.Equals("") || txtSLNhap.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng xem lại dữ liệu !!!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                data.themsanphamvaohoadonBanNhap(Convert.ToInt32(cbboxTenSP.SelectedValue.ToString()), cbboxTenSP.Text, cbbsize.Text,  Convert.ToInt32(txtSLNhap.Text), Convert.ToInt32(txtDGnhap.Text), Convert.ToInt32(txtThanhTien.Text));
                dgvdanhsachhang.DataSource = data.xemsanphamtrongTable();
                getheader();
                int tongtien = 0;
                for (int i = 0; i < dgvdanhsachhang.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToInt32(dgvdanhsachhang.Rows[i].Cells[5].Value.ToString());
                }
                lblTongtien.Text = tongtien + "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BTN ĐÓNG
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data.xoasanpham(Convert.ToInt32(cbboxTenSP.SelectedValue.ToString()), cbbsize.Text);
            dgvdanhsachhang.DataSource = data.xemsanphamtrongTable();
            int tongtien = 0;
            for (int i = 0; i < dgvdanhsachhang.Rows.Count; i++)
            {
                tongtien = tongtien + Convert.ToInt32(dgvdanhsachhang.Rows[i].Cells[5].Value.ToString());
            }
            lblTongtien.Text = tongtien + "";
        }

        private void dgvdanhsachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                cbboxTenSP.Text = dgvdanhsachhang.Rows[d].Cells[1].Value.ToString();
                cbbsize.Text = dgvdanhsachhang.Rows[d].Cells[2].Value.ToString();
                txtDGnhap.Text = dgvdanhsachhang.Rows[d].Cells[3].Value.ToString();
                txtSLNhap.Text = dgvdanhsachhang.Rows[d].Cells[4].Value.ToString();
                txtThanhTien.Text = dgvdanhsachhang.Rows[d].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                // CLICK HỤT RA NGOÀI

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtDGnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dgvdanhsachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbsize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsohd_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }














}
