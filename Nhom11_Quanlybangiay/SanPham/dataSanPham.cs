using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Nhom11_Quanlybangiay.ThemSanPham
{
    class dataSanPham
    {
        SqlConnection con = new SqlConnection();
        public dataSanPham()
        {
            //TẠO KẾT NỐI
            string connnect = @"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True";
            con = new SqlConnection(connnect);
        }
        public DataTable Xemtatsanpham()
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "Select * from sanpham";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
       
        public void themMotSanPham(string tensp,int giaban,string tinhtrang)
        {
            int kiemtrahangtontai = 0;
            con.Open();
            string sql = "Select * from sanpham where tensp=N'" + tensp + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read() == true)
            {
                kiemtrahangtontai = 1;
                MessageBox.Show("Mặt hàng này đã có");
            }
            con.Close();
            if (kiemtrahangtontai == 0)
            {
                con.Open();
                string insert = " insert into sanpham values(N'" + tensp + "','" + giaban + "',N'"+tinhtrang+"')";
                SqlCommand cmd_insert = new SqlCommand(insert, con);
                cmd_insert.ExecuteNonQuery();
                con.Close();
            }

        }
        public void suaMotSanPham(String masp, string tensp,  int giaban,string size,int soluong)
        {
            int kiemtrahangtontai = 0;
            con.Open();
            string sql = "Select * from sanpham where tensp='" + tensp + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            if(dt.Read()==true)
            {
                kiemtrahangtontai = 1;
                MessageBox.Show("Mặt hàng này đã có");
            }    
            con.Close();
            if(kiemtrahangtontai==0)
            {
                MessageBox.Show("Thõa mản");
            }    
        }
        public void xoamotsanpham(string masp)
        {
            //XÓA MỘT SẢN PHẨM
            con.Open();
            string sql = "EXEC xoasanpham  '"+masp+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // LẤY RA SIZE SẢN PHẨM
        public DataTable LayRaSizeVaSoLuong (int masp)
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "Select TenSP,size,slcon from sanpham inner join slcon on slcon.masp= sanpham.masp" +
                " where slcon.masp='"+masp+"'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void themsize(int masp,string size,int slcon)
        {
            con.Open();
            string sql = "insert into slcon values('"+masp+"','"+size+"','"+slcon+"')    ";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                if(ex.Number==2627)
                {
                    MessageBox.Show("Đã có size này không thể thêm!!!");
                }    
            }
            con.Close();
        }
        public void suathongtin(int masp,string tensp, int giaban,string tinhtrang)
        {
            con.Open();
            string sql = "update sanpham set" +
                " tensp =N'"+tensp+"'," +
                "giaban ='"+giaban+"'," +
                "tinhtrang=N'"+tinhtrang+"' " +
                "where masp='"+masp+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void suathongtin1(int masp, string tensp, int giaban, string tinhtrang) // Nho may co hang roi
        {
            int kiemtrahangtontai = 0;
            con.Open();
            string sql = "Select * from sanpham where tensp=N'" + tensp + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read() == true)
            {
                kiemtrahangtontai = 1;
                MessageBox.Show("Mặt hàng này đã có");
            }
            con.Close();
            if (kiemtrahangtontai == 0)
            {
                con.Open();
                string sqll = "update sanpham set" +
                " tensp =N'" + tensp + "'," +
                "giaban ='" + giaban + "'," +
                "tinhtrang=N'" + tinhtrang + "' " +
                "where masp='" + masp + "' ";
                SqlCommand cmd_insert = new SqlCommand(sqll, con);
                cmd_insert.ExecuteNonQuery();
                con.Close();
            }

            
        }
        public void suasoluong(int masp, string size, int slcon)
        {
            con.Open();
            string sql = " update slcon set" +
                " slcon='"+slcon+"'" +
                "where masp='"+masp+"'" +
                "and size ='"+size+"'   ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable layrathongtinnhap (int masp)
        {
            con.Open();
            string sql = " exec sosanhgiagiua2nhacungcap '" + masp + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();
            return dt;
            
        }
        public string layratennhacc(int mancc)
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "Select tenncc from nhacungcap where mancc ='" + mancc + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
           
        }
        public DataTable soluongtonkho()
        {
            con.Open();
            string sql = " exec tongsltrongkho ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
