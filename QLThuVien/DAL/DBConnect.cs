using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.DAL
{
    public class DBConnect
    {
        public static SqlConnection GetDBConnection()
        {
            string connString = @"Data Source=DG;Initial Catalog=QLThuVien;Persist Security Info=True;User ID=sa;Password=a12345678";
            SqlConnection con = new SqlConnection(connString);
            return con;
        }
    }
}
