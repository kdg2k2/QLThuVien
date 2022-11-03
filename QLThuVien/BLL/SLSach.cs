using QLThuVien.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.BLL
{
    public class SLSach
    {
        SqlConnection con = DBConnect.GetDBConnection();
        public void SLTang(string book_id)
        {
            con.Open();
            string sql = "update books " +
                                "set quantity=quantity + 1 " +
                                " Where book_id='" + book_id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SLGiam(string book_id)
        {
            con.Open();
            string sql = "update books " +
                                "set quantity=quantity - 1 " +
                                " Where book_id='" + book_id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int CheckSL(string book_id)
        {
            con.Open();
            int sl = 0;
            string sql = "Select quantity From books Where book_id='" + book_id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string strSL = dr["quantity"].ToString().Trim();
                if (strSL == "")
                    sl = 0;
                else 
                    sl = Convert.ToInt32(strSL);
            }
            return sl;
        }
    }
}
