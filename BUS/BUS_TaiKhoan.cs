using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;


namespace BUS
{
  
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan daTk = new DAL_TaiKhoan();
        public DataTable LoadTaiKhoan()
        {
            return daTk.LoadData();
        }
    }
}
