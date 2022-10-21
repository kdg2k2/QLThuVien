using QLThuVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLThuVien.APP
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnect.GetDBConnection();

        
        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_user WHERE user_name ='" + username + "' and password='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["user_id"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public static string ID_USER = "";

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbuser_name.Text) || String.IsNullOrEmpty(tbpassword.Text))
            {
                MessageBox.Show("Nhập tài khoản và mật khẩu vào","Message" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ID_USER = getID(tbuser_name.Text, tbpassword.Text);

            if (ID_USER != "")
            {
                if(tbuser_name.Text == "admin")
                {
                    adminForm a = new adminForm();
                    a.Show();
                }
                else
                {
                    //normalUserForm normalUserForm = new normalUserForm();
                    //normalUserForm.Show();
                }
                tbuser_name.Text = "";
                tbpassword.Text = "";
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
            }
        }
    }
}
