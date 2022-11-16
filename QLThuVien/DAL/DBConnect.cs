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

        SqlConnection con = DBConnect.GetDBConnection();
        public void HienThi(DataGridView dataGridView, string table)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "select * from "+table;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
