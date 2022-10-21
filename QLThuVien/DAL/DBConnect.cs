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
        public static SqlConnection CreateConnect(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection con = new SqlConnection(connString);
            return con;
        }

        public static SqlConnection GetDBConnection()
        {
            string datasource = "DG";
            string database = "QLThuVien";
            string username = "sa";
            string password = "a12345678";
            return CreateConnect(datasource, database, username, password);
        }

        //SqlConnection con = new SqlConnection();
        //public void GetDBConnection()
        //{
        //    try
        //    {
        //        if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
        //        {
        //            con.ConnectionString = @"Data Source=DG;Initial Catalog=QLThuVien;Persist Security Info=True;User ID=sa;Password=a12345678";
        //            con.Open();
        //        }
        //    }
        //    catch
        //    {
        //        // Hiện ra hộp thoại thông báo
        //        MessageBox.Show("Kết nối không thành công ");
        //    }
        //}
    }
}
