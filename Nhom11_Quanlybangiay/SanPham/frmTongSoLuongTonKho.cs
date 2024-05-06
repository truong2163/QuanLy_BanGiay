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
    public partial class frmTongSoLuongTonKho : Form
    {
        public frmTongSoLuongTonKho()
        {
            InitializeComponent();
        }
        dataSanPham data = new dataSanPham();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTongSoLuongTonKho_Load(object sender, EventArgs e)
        {
            dgvsanpham.DataSource = data.soluongtonkho();
            dgvsanpham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvsanpham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvsanpham.Columns[2].HeaderText = "Số lượng còn";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
