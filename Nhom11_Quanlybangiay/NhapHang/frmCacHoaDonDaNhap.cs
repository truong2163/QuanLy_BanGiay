using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.NhapHang
{
    public partial class frmCacHoaDonDaNhap : Form
    {
        public frmCacHoaDonDaNhap()
        {
            InitializeComponent();
        }
        datanhaphang data = new datanhaphang();
        private void dgvhoadonnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void getheader()
        {
            // LẤY RA HEADER
            dgvhoadonnhap.Columns[00].HeaderText = "Số HĐN";
            dgvhoadonnhap.Columns[01].HeaderText = "Mã NCC";
            dgvhoadonnhap.Columns[02].HeaderText = "Ngày nhập";
            dgvhoadonnhap.Columns[02].Width = 250;

        }
        private void frmCacHoaDonDaNhap_Load(object sender, EventArgs e)
        {
            //XEM NHỮNG HÓA ĐƠN ĐÃ NHẬP
            dgvhoadonnhap.DataSource = data.xemHDN();
            getheader();
            lbltongsohoadondanhap.Text = "Tổng số hóa đơn đã nhập: " + dgvhoadonnhap.Rows.Count;

        }

        private void dgvhoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtSoHDN.Text = dgvhoadonnhap.Rows[d].Cells[0].Value.ToString();
                txtMancc.Text = dgvhoadonnhap.Rows[d].Cells[1].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(dgvhoadonnhap.Rows[d].Cells[2].Value.ToString());
            }
            catch (Exception)
            {
                //TRƯỜNG HỢP D=-1
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//THOÁT
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa mọi thông tin sẽ không khôi phục được!!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if(kq.Equals(DialogResult.Yes))
            //{
            //    data.xoahoadonnhap(Convert.ToInt32(txtSoHDN.Text));
            //    dgvhoadonnhap.DataSource = data.xemHDN();
            //}    
        }

        private void dgvhoadonnhap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtSoHDN.Text = dgvhoadonnhap.Rows[d].Cells[0].Value.ToString();
                txtMancc.Text = dgvhoadonnhap.Rows[d].Cells[1].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(dgvhoadonnhap.Rows[d].Cells[2].Value.ToString());
            }
            catch (Exception)
            {
                //TRƯỜNG HỢP D=-1

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvhoadonnhap_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
