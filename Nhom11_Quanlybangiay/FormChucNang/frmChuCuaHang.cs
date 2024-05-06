using Nhom11_Quanlybangiay.Người_quản_lí;
using System;
using System.Windows.Forms;

using Nhom11_Quanlybangiay.ThemSanPham;
using Nhom11_Quanlybangiay.Khachhang;
using Nhom11_Quanlybangiay.DanhSachCacNhaCungCap;
using Nhom11_Quanlybangiay.NhapHang;
using Nhom11_Quanlybangiay.SanPham;
using Nhom11_Quanlybangiay.FrmLogin;
namespace Nhom11_Quanlybangiay.FormChucNang
{
    public partial class frmChuCuaHang : Form
    {
        public frmChuCuaHang(string tk,string mk)
        {
            InitializeComponent();
            this.tk = tk;// TẠO TK , MK TRUYỀN THAM TRỊ SANG FORM ĐỔI MẬT KHẨU
            this.mk = mk;
        }
        dataformChucNang data = new dataformChucNang();
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string tk;
        string mk;
        private void frmChuCuaHang_Load(object sender, EventArgs e)
        {
            lblChao.Text = "Chào mừng " + data.layraten(tk);
            DateTime now = DateTime.Now;

            string gioPhutGiay = now.ToString("HH:mm:ss");
            string ngayThangNam = now.ToString("dd/MM/yyyy");

            // Định dạng thông tin ngày và giờ
            string formattedText = $"Thời gian: {gioPhutGiay}\nNgày: {ngayThangNam}";

            // Gán giá trị vào thuộc tính Text của Label
            labelDatatime.Text = formattedText;
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnĐãNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCacHoaDonDaNhap f = new frmCacHoaDonDaNhap();
            f.Show();
        }

        private void hóaĐơnĐãBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thốngKêHóaĐơnTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thốngKêSảnPhẩmBánChạyNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thốngKêHóaĐơnBánTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thốngKêHóaĐơnXuấtTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // THỐNG KÊ
            
        }

        private void thốngKêTiềnNhậpXuấtDoanhThuTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LOẠI HÀNG
           
        }

        private void xemLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm đổi mật khẩu
            
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void soSánhGiáSảnPhẩmNhậpGiữaCácNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void xemSảnPhẩmBánChậmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tổngSốLượngSảnPhẩmĐangTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (btnxem1.Visible == true)
            {
                // CÁC NÚT VỚI CÁC SỰ KIỆN
               
                btnxem6.Visible = false;
                btnxem5.Visible = false;
                btnxem4.Visible = false;
             
                btnxem2.Visible = false;
                btnxem1.Visible = false;
            }
            else
            {
                btnxem6.Visible = true;
                btnxem5.Visible = true;
                btnxem4.Visible = true;
                
                btnxem2.Visible = true;
                btnxem1.Visible = true;
            }    
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(btnTK7.Visible==true)
            {
                
             
               
                btnTK7.Visible = false;
                btnTK6.Visible = false;                     
                
                
               
            }    
            else
            {
               
               
                btnTK7.Visible = true;
                btnTK6.Visible = true;
                
                
                
                
                
            }    
        }

        private void btnxem1_Click(object sender, EventArgs e)
        {// THÔNG TIN TÀI KHOẢN
            this.panelDisplay.Controls.Clear();
            frmNguoiquanli f = new frmNguoiquanli();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill; 
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnxem2_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmCacHoaDonDaNhap f = new frmCacHoaDonDaNhap();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();

            
            
        }

       

        private void btnxem4_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmKhachHangVoiNQL f = new frmKhachHangVoiNQL();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnxem5_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmNhaCungCap f = new frmNhaCungCap();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnxem6_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmSanPham f = new frmSanPham();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void pnl_hienthi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            if(btnCN1.Visible==true)
            {
                btnCN2.Visible = false;
                btnCN1.Visible = false;
            }    
            else
            {
                btnCN2.Visible = true;
                btnCN1.Visible = true;
            }    
        }

      
      

       

       
        private void btnTK6_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmThongKeTienNhapGiuaCacNhaCungCap f = new frmThongKeTienNhapGiuaCacNhaCungCap();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnTK7_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmTongSoLuongTonKho f = new frmTongSoLuongTonKho();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnCN2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            formdoimatkhau f = new formdoimatkhau(tk, mk); // ĐỔI MẬT KHẨU
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Nhom11_Quanlybangiay.FrmLogin.FrmLogin f = new Nhom11_Quanlybangiay.FrmLogin.FrmLogin();
            f.ShowDialog();
            this.Close();

        }

        private void pnl_hienthi_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCN2_Click_1(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmNhapHang f = new frmNhapHang();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            f.manql = tk; // NHẬP HÀNG
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnCN1_Click(object sender, EventArgs e)
        {
            //Bán hàng
            this.panelDisplay.Controls.Clear();
            frmkhachhang f = new frmkhachhang();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;

            f.manql = tk; // TRUYỀN DỮ LIỆU GIỮA CÁC FORM
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnChucNang_Click_1(object sender, EventArgs e)
        {
            if (btnCN1.Visible == true)
            {
                btnCN2.Visible = false;
                btnCN1.Visible = false;
            }
            else
            {
                btnCN2.Visible = true;
                btnCN1.Visible = true;
            }
        }

        private void frmChuCuaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //Nhom11_Quanlybangiay.FrmLogin.FrmLogin f = new Nhom11_Quanlybangiay.FrmLogin.FrmLogin();
            //f.ShowDialog();
            //this.Close();
        }

        private void btnTK8_Click(object sender, EventArgs e)
        {// THỐNG KÊ NGƯỜI BÁN ĐƯỢC NHIEUF NHẤT
            
        }

        private void lblChao_Click(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            if (button5.Visible == true)
            {
                button5.Visible = false;
                button4.Visible = false;
            }
            else
            {
                button5.Visible = true;
                button4.Visible = true;
            }
        }

        private void labelDatatime_Click(object sender, EventArgs e)
        {
           
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
