using Microsoft.Office.Interop.Excel;
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
    public partial class report_muontra : Form
    {
        public report_muontra()
        {
            InitializeComponent();
        }

        private void report_muontra_Load(object sender, EventArgs e)
        {
            con.Open();
            SinhVienChuaTraSach();
            SinhVienMuonQuaHan();
            BangMuonNhieuNhat();
        }
        SqlConnection con = DBConnect.GetDBConnection();
        public void SinhVienChuaTraSach()
        {
            string sqlSelect = "SELECT m.issue_id, s.book_id, s.book_name, m.date_issue, m.date_expirary, sv.student_id, sv.studentname, sv.phone FROM borrow m INNER JOIN books s ON m.book_id = s.book_id INNER JOIN student sv ON m.student_id = sv.student_id WHERE m.issue_id not in(select issue_id from giveback)";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            MD5_algorithm md5 = new MD5_algorithm();
            foreach (DataRow row in dt.Rows)
            {
                row["studentname"] = md5.GiaiMaSring(row["studentname"].ToString(), "NguyenKhaDang");
                row["phone"] = md5.GiaiMaSring(row["phone"].ToString(), "NguyenKhaDang");
            }
            dataView_ChuaTraSach.DataSource = dt;
        }

        public void SinhVienMuonQuaHan()
        {
            string sqlSelect = "SELECT dbo.borrow.issue_id, dbo.borrow.book_id, dbo.books.book_name, dbo.student.* FROM dbo.books INNER JOIN dbo.borrow ON dbo.books.book_id = dbo.borrow.book_id INNER JOIN dbo.student ON dbo.borrow.student_id = dbo.student.student_id WHERE GETDATE() > borrow.date_expirary AND borrow.issue_id NOT IN (SELECT giveback.issue_id FROM giveback)";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            MD5_algorithm md5 = new MD5_algorithm();
            foreach (DataRow row in dt.Rows)
            {
                row["studentname"] = md5.GiaiMaSring(row["studentname"].ToString(), "NguyenKhaDang");
                row["phone"] = md5.GiaiMaSring(row["phone"].ToString(), "NguyenKhaDang");
            }
            dataGridView_QuaHan.DataSource = dt;
        }

        public void BangMuonNhieuNhat()
        {
            string sqlSelect = "select TOP 3 T.book_id, max(T.mycount) as max   FROM(SELECT book_id, count(student_id) as mycount   FROM borrow GROUP BY book_id) AS T  group by t.book_id, mycount order by mycount desc";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataView_MuonNhieuNhat.DataSource = dt;
        }

        private void report_muontra_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
