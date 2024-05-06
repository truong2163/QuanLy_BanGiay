using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Nhom11_Quanlybangiay.Khachhang
{
    class dataKhachHang
    {
        public SqlConnection con = new SqlConnection();
        public dataKhachHang()
        {
            string connnect = @"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True";
            con = new SqlConnection(connnect);
        }
        public DataTable xemKH()
        {// LẤY TẤT CẢ THÔNG TIN KHÁCH HÀNG
            con.Open();
            DataTable dt = new DataTable();
            String sql = "select * from khachhang";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void themkh(string sdt,string tenkh,string diachi_kh)
        {// THÊM MỘT KH
            try
            {
                con.Open();
                string sql = "insert into khachhang values('" + sdt + "',N'" + tenkh + "',N'" + diachi_kh + "' )";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã trùng khách hàng này!!!",ex.Message);
                con.Close();
                
            }
        }
        public void suakh(string sdt, string tenkh, string diachi_kh)
        {
            // UPDATE KHÁCH HÀNG
            con.Open();
            string sql = "update khachhang set tenkh=N'"+tenkh+"', diachi_kh=N'"+diachi_kh+"' where sdt_kh='"+sdt+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoakh(String makh)
        {
            // XÓA KHÁCH HÀNG
            con.Open();
            string sql = "exec xoakhachang '" + makh+"'  ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable xemkhVip()
        {
            // XEM MỘT KHÁCH HÀNG VIP
            con.Open();
            DataTable dt = new DataTable();
            String sql = "EXEC  khachhangvip"; // PROCEDUERE TRONG SQL
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public bool xemKHTonTaiHayChua(string sdt)
        {
            con.Open();
            string sql = "Select * from KhachHang where  SDT_KH='"+sdt+"'  ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt.Read();
           
        }
        public bool kiemtrahaithongtin(string sdt,string ten,string diachi)
        {
            con.Open();
            string sql = "Select * from KhachHang where  SDT_KH='" + sdt + "' and tenkh=N'"+ten+"' and diachi_kh=N'"+diachi+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt.Read();

        }
    }
}
