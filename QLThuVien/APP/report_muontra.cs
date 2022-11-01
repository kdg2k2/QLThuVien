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
            BangMuon();
            BangTra();
            BangMuonNhieuNhat();
        }
        SqlConnection con = DBConnect.GetDBConnection();
        public void SinhVienChuaTraSach()
        {
            string sqlSelect = "SELECT  dbo.borrow.issue_id, dbo.student.*, dbo.borrow.book_id, dbo.borrow.date_issue, dbo.borrow.date_expirary FROM    dbo.borrow INNER JOIN   dbo.giveback ON dbo.borrow.issue_id != dbo.giveback.issue_id INNER JOIN  dbo.student ON dbo.borrow.student_id = dbo.student.student_id   EXCEPT  SELECT  dbo.borrow.issue_id, dbo.student.*, dbo.borrow.book_id, dbo.borrow.date_issue, dbo.borrow.date_expirary FROM    dbo.borrow INNER JOIN   dbo.giveback ON dbo.borrow.issue_id = dbo.giveback.issue_id INNER JOIN  dbo.student ON dbo.borrow.student_id = dbo.student.student_id";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
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

        public void BangMuon()
        {
            string sqlSelect = "select * from borrow";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView_BangMuon.DataSource = dt;
        }

        public void BangTra()
        {
            string sqlSelect = "select * from giveback";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView_BangTra.DataSource = dt;
        }

        public void BangMuonNhieuNhat()
        {
            string sqlSelect = "select TOP 1 T.book_id, max(T.mycount) as max   FROM(SELECT book_id, count(student_id) as mycount   FROM borrow GROUP BY book_id) AS T  group by t.book_id, mycount order by mycount desc";
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
