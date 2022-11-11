using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DAL;

namespace QLThuVien.BLL
{
    public class ID_Check
    {
        SqlConnection con = DBConnect.GetDBConnection();
        public int KiemTraMa(string TenBang, string TenField, string DieuKien)
        {
            int dieuKien = 0;
            DataSet ds = new DataSet();
            string strSQL = " Select * From " + TenBang;
            if (TenField != "" && DieuKien != "")
            {
                strSQL += " Where " + TenField + "='" + DieuKien + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
            da.Fill(ds, TenBang);
            DataTable table = ds.Tables[0];

            foreach (DataRow row in table.Rows)
            {
                dieuKien++;
            }
            return dieuKien;
        }
    }
}
