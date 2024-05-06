using Nhom11_Quanlybangiay.ThemSanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.SanPham
{
    public partial class frmThongKeTienNhapGiuaCacNhaCungCap : Form
    {
        
        public frmThongKeTienNhapGiuaCacNhaCungCap()
        {
            InitializeComponent();
        }
        dataSanPham data = new dataSanPham();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeTienNhapGiuaCacNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvDanhSachSP.DataSource = data.Xemtatsanpham();
            getheader();
            
        }
        private void getheader()
        {
            dgvDanhSachSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgvDanhSachSP.Columns[0].Width = 100;
            dgvDanhSachSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgvDanhSachSP.Columns[1].Width = 250;
            dgvDanhSachSP.Columns[2].HeaderText = "Giá bán";
            dgvDanhSachSP.Columns[3].HeaderText = "Nhập";
            
        }
        
        private void dgvDanhSachSP_DoubleClick(object sender, EventArgs e)
        {
            

          

        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtMaSP.Text = dgvDanhSachSP.Rows[d].Cells[0].Value.ToString();
                txtTenSP.Text = dgvDanhSachSP.Rows[d].Cells[1].Value.ToString();
                txtGiaBan.Text = dgvDanhSachSP.Rows[d].Cells[2].Value.ToString();
                if(!txtMaSP.Text.Equals(""))
                {
                    dgvThongKe.DataSource = data.layrathongtinnhap(Convert.ToInt32(txtMaSP.Text));
                    dgvThongKe.Columns[0].HeaderText = "Mã nhà cung cấp";
                    dgvThongKe.Columns[0].Width = 100;
                    dgvThongKe.Columns[1].HeaderText = "Tên nhà cung cấp";
                    dgvThongKe.Columns[1].Width = 150;
                    dgvThongKe.Columns[2].HeaderText = "Tiền nhập TB / Sản phẩm";
                    dgvThongKe.Columns[2].Width = 250;
                }    
            }
            catch (Exception)
            {

               
            }
        }

        private void dgvThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDanhSachSP_Click(object sender, EventArgs e)
        {
          
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
