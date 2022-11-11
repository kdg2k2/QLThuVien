using QLThuVien.BLL;
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

namespace QLThuVien.APP
{
    public partial class forgot__password : Form
    {
        public forgot__password()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnect.GetDBConnection();
        ID_Check check = new ID_Check();
        private void tbChangePass_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUser_name.Text) || String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(tbRePassword.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }
            if(check.KiemTraMa("tbl_user", "user_name", tbUser_name.Text) == 0)
            {
                MessageBox.Show("Tên tài khoản không tồn tại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(check.KiemTraMa("tbl_user", "email", tbEmail.Text) == 0)
            {
                MessageBox.Show("Email này chưa từng được đăng kí trên hệ thống", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                string sqlThem = "update tbl_user " +
                                    "set password=@password " +
                                    "where user_name=@user_name";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("user_name", tbUser_name.Text);
                cmd.Parameters.AddWithValue("password", tbPassword.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đổi mật khẩu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void forgot__password_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void forgot__password_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
