using QLThuVien.BLL;
using QLThuVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.APP
{
    public partial class admin_change_Password : Form
    {
        public admin_change_Password()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnect.GetDBConnection();
        ID_Check check = new ID_Check();
        private void HienThi()
        {
            string sqlSelect = "select * from tbl_user";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_accounts.DataSource = dt;
        }

        private void admin_change_Password_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.tbl_user' table. You can move, or remove it, as needed.
            //this.tbl_userTableAdapter.Fill(this.qLThuVienDataSet.tbl_user);
            con.Open();
            HienThi();
        }

        private void admin_change_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.tbTaiKhoan.Clear();
            this.tbMatKhau.Clear();
            this.tbEmail.Clear();
            HienThi();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTaiKhoan.Text) || String.IsNullOrEmpty(tbMatKhau.Text) || String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            
            if (check.KiemTraMa("tbl_user", "user_name", tbTaiKhoan.Text) > 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
                return;
            }
            
            if (check.KiemTraMa("tbl_user", "email", tbEmail.Text) > 0)
            {
                MessageBox.Show("Email đã tồn tại");
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO tbl_user " +
                                "VALUES (@user_name, @password, @email)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("user_name", tbTaiKhoan.Text);
                cmd.Parameters.AddWithValue("password", tbMatKhau.Text);
                cmd.Parameters.AddWithValue("email", tbEmail.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbTaiKhoan.Text) || String.IsNullOrEmpty(tbMatKhau.Text) || String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }
            else
            {
                string sqlThem = "update tbl_user " +
                                    "set password=@password, email=@email " +
                                    "where user_name=@user_name";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("user_name", tbTaiKhoan.Text);
                cmd.Parameters.AddWithValue("password", tbMatKhau.Text);
                cmd.Parameters.AddWithValue("email", tbEmail.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTaiKhoan.Text))
            {
                MessageBox.Show("Bạn phải tài khoản cần xoá vào");
                return;
            }

            string sqlThem = "delete from tbl_user " +
                                "where user_name=@user_name";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("user_name", tbTaiKhoan.Text);
            cmd.Parameters.AddWithValue("password", tbMatKhau.Text);
            cmd.Parameters.AddWithValue("email", tbEmail.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
    }
}
