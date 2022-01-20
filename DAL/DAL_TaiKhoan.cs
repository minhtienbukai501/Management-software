using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class DAL_TaiKhoan : DBConnection
    {
        public DataTable LoadData()
        {
            string str = @"select * from Account";
            return DBConnection.LoadData(str);
        }
    }
}
