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
        DBConnect db = new DBConnect();

        private void admin_change_Password_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.tbl_user' table. You can move, or remove it, as needed.
            //this.tbl_userTableAdapter.Fill(this.qLThuVienDataSet.tbl_user);
            con.Open();
            db.HienThi(dataGridView_accounts, "tbl_user");
        }

        private void admin_change_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.tbTaiKhoan.Clear();
            this.tbMatKhau.Clear();
            this.tbSDT.Clear();
            db.HienThi(dataGridView_accounts, "tbl_user");
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTaiKhoan.Text) || String.IsNullOrEmpty(tbMatKhau.Text) || String.IsNullOrEmpty(tbSDT.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            
            if (check.KiemTraMa("tbl_user", "user_name", tbTaiKhoan.Text) > 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
                return;
            }
            
            if (check.KiemTraMa("tbl_user", "SDT", tbSDT.Text) > 0)
            {
                MessageBox.Show("SDT đã tồn tại");
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO tbl_user " +
                                "VALUES (@user_name, @password, @SDT)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("user_name", tbTaiKhoan.Text);
                cmd.Parameters.AddWithValue("password", tbMatKhau.Text);
                cmd.Parameters.AddWithValue("SDT", tbSDT.Text);
                cmd.ExecuteNonQuery();
                db.HienThi(dataGridView_accounts, "tbl_user");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbTaiKhoan.Text) || String.IsNullOrEmpty(tbMatKhau.Text) || String.IsNullOrEmpty(tbSDT.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }
            else
            {
                string sqlThem = "update tbl_user " +
                                    "set password=@password, SDT=@SDT " +
                                    "where user_name=@user_name";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("user_name", tbTaiKhoan.Text);
                cmd.Parameters.AddWithValue("password", tbMatKhau.Text);
                cmd.Parameters.AddWithValue("SDT", tbSDT.Text);
                cmd.ExecuteNonQuery();
                db.HienThi(dataGridView_accounts, "tbl_user");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTaiKhoan.Text))
            {
                MessageBox.Show("Bạn phải nhập tài khoản cần xoá vào");
                return;
            }

            string sqlThem = "delete from tbl_user " +
                                "where user_name=@user_name";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("user_name", tbTaiKhoan.Text);
            cmd.Parameters.AddWithValue("password", tbMatKhau.Text);
            cmd.Parameters.AddWithValue("SDT", tbSDT.Text);
            cmd.ExecuteNonQuery();
            db.HienThi(dataGridView_accounts, "tbl_user");
        }
    }
}
