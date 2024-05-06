using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Nhom11_Quanlybangiay.DanhSachCacNhaCungCap
{
    class dataNCC
    {
        SqlConnection con = new SqlConnection();
        public dataNCC()
        {
            string connnect = @"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay9;Integrated Security=True";
            con = new SqlConnection(connnect);
        }
        public DataTable getThongTinNCC()
        {
            // LẤY THÔNG TIN NCC

            con.Open();
            DataTable dt = new DataTable();
            string sql = "select * from nhacungcap";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void them(string tenncc, string sdt, string diachi, string nhap)
        {
            int kiemtrancc = 0;
            con.Open();
            string sql = "Select * from nhacungcap where tenncc=N'" + tenncc + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read() == true)
            {
                kiemtrancc = 1;
                MessageBox.Show("Nhà cung cung cấp này đã có");
            }
            con.Close();
            if (kiemtrancc == 0)
            {
                con.Open();
                string insert = " insert into nhacungcap values(N'" + tenncc + "','" + sdt + "',N'" + diachi + "','" + nhap + "')";
                SqlCommand cmd_insert = new SqlCommand(insert, con);
                cmd_insert.ExecuteNonQuery();
                con.Close();
            }
        }
        public void sua(int mancc, string tenncc, string sdt, string diachi, string nhap)
        {
            int kiemtrancc = 0;
            con.Open();
            string sql = "Select * from nhacungcap where tenncc=N'" + tenncc + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read() == true)
            {

                MessageBox.Show("Nhà cung cung cấp này đã có");
                kiemtrancc = 1;
            }
            con.Close();
            if (kiemtrancc == 0)
            {
                con.Open();
                string sqll = " update nhacungcap set tenncc=N'" + tenncc + "',sdt_ncc=N'" + sdt + "', diachincc= N'" + diachi + "',tinhtrang='" + nhap + "' where mancc='" + mancc + "'  ";
                SqlCommand cmdd = new SqlCommand(sqll, con);
                cmdd.ExecuteNonQuery();
                con.Close();
            }


        }
        public void sua2(int mancc, string tenncc, string sdt, string diachi, string nhap)
        {

            con.Open();
            string sqll = " update nhacungcap set tenncc=N'" + tenncc + "',sdt_ncc=N'" + sdt + "', diachincc= N'" + diachi + "',tinhtrang='" + nhap + "' where mancc='" + mancc + "'  ";
            SqlCommand cmdd = new SqlCommand(sqll, con);
            cmdd.ExecuteNonQuery();
            con.Close();

        }
        public void xoa(int ncc)
        {
            con.Open();// xóa nhà cung cấp
            string sql = "exec xoanhacungcap '" + ncc + "'  ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable timtheoma(int mancc)
        { // tìm nhà cung cấp
            con.Open();
            DataTable dt = new DataTable();
            string sql = "select * from nhacungcap where mancc=N'" + mancc + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable timtheotem(String tenncc)
        {
            con.Open();
            // TÌM NHÀ CUNG CẤP THEO TÊN
            DataTable dt = new DataTable();
            string sql = "select * from nhacungcap where tenncc like '%'+N'" + tenncc + "'+'%'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable layrahoadoncuancc(int mancc)
        {
            // LẤY RA DƠN CỦA NCC
            con.Open();
            DataTable dt = new DataTable();
            string sql = "select sohdn,nhacungcap.mancc,tenncc,ngaynhap from hoadonnhap inner join nhacungcap on nhacungcap.mancc=hoadonnhap.mancc where hoadonnhap.mancc=N'" + mancc + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable layrahoadoncuanccTheoNgay(int mancc,DateTime x, DateTime y)
        {
            // LẤY RA DƠN CỦA NCC
            con.Open();
            DataTable dt = new DataTable();
            string sql = "EXEC thongkehoadonnhapTheoNgayCuaNhaCc '"+mancc+"','"+x+"','"+y+"'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }

        public int kiemtrancc = 0;
        public void kiemtranhacungcap(string tenncc)
        {
            kiemtrancc = 0;
            con.Open();
            string sql = "Select * from nhacungcap where tenncc=N'" + tenncc + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read() == true)
            {
                kiemtrancc = 1;
               
            }
            con.Close();
            if (kiemtrancc == 0)
            {
                
                con.Close();
            }
        }

    }
}
