using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace Nhom11_Quanlybangiay.FormChucNang
{
    class dataformChucNang
    {

        SqlConnection con = new SqlConnection();
        public dataformChucNang()
        {
            // TẠO LIÊN KẾT 
            string connnect = @"Data Source=LAPTOP-RIFIUM18;Initial Catalog=qlgiay;Integrated Security=True";
            con = new SqlConnection(connnect);
        }
        public string layraten(string manql)
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "Select tennql from nguoiquanli where manql='" + manql + "'"; // LẤY RA TÊN NHÀ QUẢN LÍ ĐỂ CHÀO
            SqlDataAdapter adap = new SqlDataAdapter(sql,con);
            adap.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
        
    }
}
