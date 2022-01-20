using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBConnection
    {
        public static SqlConnection conn;
        public static string Name_Conn = @"server=MINHTIENIT; database=QuanLiKhoThuocTay;uid=sa; pwd=123";


        public static DataTable LoadData(string CauLenh)
        {

            conn = new SqlConnection(Name_Conn);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand(CauLenh, conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);

            return dt;
        }
    }
}
