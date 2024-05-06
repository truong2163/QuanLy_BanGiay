using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Nhom11_Quanlybangiay.Người_quản_lí
{
    class dataMaNQL
    {
        SqlConnection con = new SqlConnection();
        public dataMaNQL()
        {
            //TẠO KẾT NỐI
            string connnect = @"Data Source=LAPTOP-U2CB5CV7\GIAONGU;Initial Catalog=qlgiay;Integrated Security=True";
            con = new SqlConnection(connnect);
        }
        public DataTable hienthi()
        { // HIỂN THỊ DỮ LIỆU
            con.Open();
            DataTable dt = new DataTable();
            String sql = "select * from nguoiquanli";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void them(String manql,string tennql,string sdt,string diachi,string matkhau,string tinhtrang)
        {
            //THÊM DỮ LIỆU
            try
            {
                con.Open();
                string sql = "insert into nguoiquanli values(N'" + manql + "',N'" + tennql + "',N'" + sdt + "',N'" + diachi + "',N'" + matkhau + "',N'" + tinhtrang + "'   )";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Trùng mã !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }
        public void sua(String manql, string tennql, string sdt, string diachi, string matkhau,string tinhtrang)
        {
                // SỬA
            con.Open();
            string sql = "update  nguoiquanli set tennql=N'"+tennql+ "',sdt_nql=N'" + sdt+ "',diachi_nql=N'" + diachi+ "',mat_khau=N'" + matkhau+ "',tinhtrang=N'"+tinhtrang+"' where manql=N'" + manql+"'          ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoa(string manql)
        {// XÓA
            con.Open();
            string sql = "exec xoanguoiquanli '" + manql + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
