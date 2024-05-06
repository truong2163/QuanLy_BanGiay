using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Nhom11_Quanlybangiay.NhapHang
{
    class datanhaphang
    {
        public SqlConnection con = new SqlConnection();
        public datanhaphang()
        {
            string connnect = @"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True";
            con = new SqlConnection(connnect);

            //KẾT NỐI DỮ LIỆU
        }
        public DataTable Xemtatsanpham()
        {
            //XEM TẤT CẢ SẢN PHẨM
            con.Open();
            DataTable dt = new DataTable();
            string n = "N";
            string sql = "Select * from sanpham where tinhtrang='"+n+"'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable xemtatcanhacc()
        {
            //XEM TẤT CẢ CÁC NHÀ CUNG CẤP
            con.Open();
            string n = "N";
            DataTable dt = new DataTable();
            string sql = "Select * from nhacungcap where tinhtrang='"+n+"'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable xemnguoiquanli()
        {
            //XEM NGƯỜI QUẢN LÍ
            con.Open();
            DataTable dt = new DataTable();
            string sql = "Select * from nguoiquanli";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        // THÊM MỘT HĐN
        public void themhoadonnhap(string mancc,string manql,DateTime ngaynhap)
        {
            con.Open();
            string sql = "insert into hoadonnhap values('"+mancc+"','"+manql+"','"+ngaynhap+"')   ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //THÊM SẢN PHẨM VÀO HĐN
        public void themsanphamvaohoadon(int masp, int sohdn,string size,int soluongnhap,int dongia,int thanhtien)
        {
            con.Open();
            String sql = "Insert into chitiethoadonnhap values('"+masp+"','"+sohdn+"','"+size+"' , '"+soluongnhap+"','"+dongia+"','"+thanhtien+"')  ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //XEM THÔNG TIN SP
        public DataTable xemthongtinsanphamdanhap(int mahdn)
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "exec xemsanphamdanhap '"+mahdn+"' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        //XÓA SẢN PHẨM
        public void xoasanpham(int masp,string size)
        {
            con.Open();
            string sql = "Delete  from ChiTietHoaDonNhapBanNhap where masp='" + masp + "' and size='"+size+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //XÓA HDN
        public void xoahoadonnhap(int hdn)
        {
            con.Open();
            string sql = "exec xoahoadonnhap '"+hdn+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable xemtongtien(int hdn)
        {
            //XEM TỔNG TIỀN
            con.Open();
            DataTable dt = new DataTable();
            string sql = "exec tongtiennhap '" + hdn + "' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable xemchitietmothoadonhap(int hdn)
        {
            //XEM TỔNG TIỀN BÁN
            con.Open();
            DataTable dt = new DataTable();
            string sql = "exec xemchitietmothoadonnhap '" + hdn + "' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable xemHDN()
        {//XEM HDN 
            con.Open();
            DataTable dt = new DataTable();
            string sql = "Select sohdn,mancc,ngaynhap from hoadonnhap ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable xemnhunghoadondanhaptheomaNQL(string manql)
        {
            // LẤY RA HÓA ĐƠN ĐÃ NHẬP THEO MÃ NQL
            con.Open();
            DataTable dt = new DataTable();
            string sql = "Select sohdn,mancc,ngaynhap from hoadonnhap where manql = '"+manql+"' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable xemhoadonvuamoinhap()
        {// LẤY RA HÓA ĐƠN VỪA MỚI NHẬP
            con.Open();
            DataTable dt = new DataTable();
            string sql = "EXEC layRaSoHDNhapvuaNhap ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }

        public void themsanphamvaohoadonBanNhap(int masp, string tensp,string size, int soluongnhap, int dongia, int thanhtien)
        {
            con.Open();
            String sql = "Insert into ChiTietHoaDonNhapBanNhap values('" + masp + "',N'" + tensp + "','"+size+"','" + dongia + "','" + soluongnhap + "','" + thanhtien + "')  ";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                if(ex.Number==2627)
                {
                    MessageBox.Show("Mặt hàng này đã tồn tại !!!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }    
                
            }
            con.Close();
        }
        public DataTable xemsanphamtrongTable()
        {
            // XEM SẢN PHẨM CÓ TRONG BẢNG

            con.Open();
            DataTable dt = new DataTable();
            string sql = "Select * from ChiTietHoaDonNhapBanNhap ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void xoadl()
        {
            con.Open();
            String sql = "Delete from ChiTietHoaDonNhapBanNhap ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void CapNhatSoLuongHangHangXoa(int masp, string size, int soluongban)
        {
            con.Open();
            string sql = "exec CapNhatSoLuongHangXoa '" + masp + "','" + size + "','" + soluongban + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void insertSanPhamMoi(int masp, string size, int soluongban)
        {
             con.Open();
            string sql = " Insert into slcon values('"+masp+"','"+size+"','"+soluongban+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
