using ClosedXML.Excel;
using ExcelDataReader;
using QLThuVien.DAL;
using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace QLThuVien.APP
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnect.GetDBConnection();

        public void HienThi()
        {
            string sqlSelect = "select * from student";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            //Giải Mã
            MD5_algorithm md5 = new MD5_algorithm();
            foreach (DataRow row in dt.Rows)
            {
                //row["student_id"] = md5.GiaiMaSring(row["student_id"].ToString(), "NguyenKhaDang");
                row["studentname"] = md5.GiaiMaSring(row["studentname"].ToString(), "NguyenKhaDang");
                row["phone"] = md5.GiaiMaSring(row["phone"].ToString(), "NguyenKhaDang");
            }
            dataView.DataSource = dt;
        }
        int dieuKien = 0;
        private void KiemTraMa(string TenBang, string TenField, string DieuKien)
        {
            dieuKien = 0;
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
        }
        private void students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.qLThuVienDataSet.student);
            con.Open();
            HienThi();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSV.Text) || String.IsNullOrEmpty(tbTenSV.Text) || String.IsNullOrEmpty(tbSDT.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            KiemTraMa("student", "student_id", tbTenSV.Text);
            if (dieuKien > 0)
            {
                MessageBox.Show("Mã sinh viên tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO student " +
                                "VALUES (@student_id, @studentname, @phone)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                //cmd.Parameters.AddWithValue("student_id", tbMaSV.Text);
                //cmd.Parameters.AddWithValue("studentname", tbTenSV.Text);
                //cmd.Parameters.AddWithValue("phone", tbSDT.Text);
                

                //Mã Hoá
                MD5_algorithm md5 = new MD5_algorithm();
                //cmd.Parameters.AddWithValue("student_id", md5.MaHoaString(tbMaSV.Text,"NguyenKhaDang"));
                cmd.Parameters.AddWithValue("student_id", tbMaSV.Text);
                cmd.Parameters.AddWithValue("studentname", md5.MaHoaString(tbTenSV.Text, "NguyenKhaDang"));
                cmd.Parameters.AddWithValue("phone", md5.MaHoaString(tbSDT.Text, "NguyenKhaDang"));
                cmd.ExecuteNonQuery();
                HienThi();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSV.Text) || String.IsNullOrEmpty(tbTenSV.Text) || String.IsNullOrEmpty(tbSDT.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            string sqlSua = "update student " +
                                "set student_id=@student_id, studentname=@studentname, phone=@phone " +
                                "where student_id=@student_id";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            //cmd.Parameters.AddWithValue("student_id", tbMaSV.Text);
            //cmd.Parameters.AddWithValue("studentname", tbTenSV.Text);
            //cmd.Parameters.AddWithValue("phone", tbSDT.Text);

            //Mã Hoá
            MD5_algorithm md5 = new MD5_algorithm();
            cmd.Parameters.AddWithValue("student_id", md5.MaHoaString(tbMaSV.Text, "NguyenKhaDang"));
            cmd.Parameters.AddWithValue("studentname", md5.MaHoaString(tbTenSV.Text, "NguyenKhaDang"));
            cmd.Parameters.AddWithValue("phone", md5.MaHoaString(tbSDT.Text, "NguyenKhaDang"));
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSV.Text))
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên vào để xoá");
                return;
            }

            string sqlXoa = "delete from student " +
                                "where student_id=@student_id";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("student_id", tbMaSV.Text);
            cmd.Parameters.AddWithValue("studentname", tbTenSV.Text);
            cmd.Parameters.AddWithValue("phone", tbSDT.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNoiDungTimKiem.Text))
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần tìm vào");
                return;
            }
            string sqlTimKiem = "SELECT * " +
                                    "FROM student " +
                                    "WHERE student_id like N'%" + tbNoiDungTimKiem.Text + "%' or studentname like N'%" + tbNoiDungTimKiem.Text + "%' or phone like N'%" + tbNoiDungTimKiem.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("student_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("studentname", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("phone", tbNoiDungTimKiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataView.DataSource = dt;

        }

        private void btExport_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "student";
            // storing header part in Excel  
            for (int i = 1; i < dataView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataView.Rows.Count; i++)
            {
                for (int j = 0; j < dataView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataView.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.tbMaSV.Clear();
            this.tbTenSV.Clear();
            this.tbSDT.Clear();
            HienThi();
        }

        private void students_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
