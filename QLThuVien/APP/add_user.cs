using QLThuVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.APP
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnect.GetDBConnection();
        public static int dem = 0;
        private void KiemTraMa(string TenBang, string TenField, string DieuKien)
        {
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
                dem++;
            }
        }

        private void btDangKi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbuser_name.Text) || String.IsNullOrEmpty(tbpassword.Text) || String.IsNullOrEmpty(tbretypePassword.Text) || String.IsNullOrEmpty(tbstudent_id.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy thông tin vào");
                return;
            }
            if(tbpassword.Text != tbretypePassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại chưa đúng!");
                tbpassword.Text = "";
                tbretypePassword.Text = "";
                return;
            }
            con.Open();
            KiemTraMa("tbl_user", "user_name", tbuser_name.Text);
            if (dem > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                MessageBox.Show("Hãy nhập tài khoản khác");
                dem = 0;
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO tbl_user " +
                                                "VALUES (@user_name, @password, @student_id)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("user_name", tbuser_name.Text);
                cmd.Parameters.AddWithValue("password", tbpassword.Text);
                cmd.Parameters.AddWithValue("student_id", tbstudent_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Đăng kí thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
