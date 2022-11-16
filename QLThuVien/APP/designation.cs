using ClosedXML.Excel;
using ExcelDataReader;
using QLThuVien.BLL;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace QLThuVien.APP
{
    public partial class designation : Form
    {
        public designation()
        {
            InitializeComponent();
        }

        SqlConnection con = DBConnect.GetDBConnection();
        DBConnect db = new DBConnect();

        ID_Check dieuKien = new ID_Check();
        private void designation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.designation' table. You can move, or remove it, as needed.
            //this.designationTableAdapter.Fill(this.qLThuVienDataSet.designation);
            con.Open();
            db.HienThi(dataView, "designation");
        }

        private void designation_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbDesignation_id.Text) || String.IsNullOrEmpty(tbDesignation.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            
            if (dieuKien.KiemTraMa("designation", "designation_id", tbDesignation_id.Text) > 0)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO designation " +
                                "VALUES (@designation_id, @designation)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("designation_id", tbDesignation_id.Text);
                cmd.Parameters.AddWithValue("designation", tbDesignation.Text);
                cmd.ExecuteNonQuery();
                db.HienThi(dataView, "designation");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbDesignation_id.Text) || String.IsNullOrEmpty(tbDesignation.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            string sqlThem = "update designation " +
                                "set designation_id=@designation_id, designation=@designation " +
                                "where designation_id=@designation_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("designation_id", tbDesignation_id.Text);
            cmd.Parameters.AddWithValue("designation", tbDesignation.Text);
            cmd.ExecuteNonQuery();
            db.HienThi(dataView, "designation");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbDesignation_id.Text))
            {
                MessageBox.Show("Bạn phải nhập mã chức vụ vào");
                return;
            }

            string sqlThem = "delete from designation " +
                                "where designation_id=@designation_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("designation_id", tbDesignation_id.Text);
            cmd.Parameters.AddWithValue("designation", tbDesignation.Text);
            cmd.ExecuteNonQuery();
            db.HienThi(dataView, "designation");
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNoiDungTimKiem.Text))
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần tìm vào");
                return;
            }

            string sqlThem = "SELECT * " +
                                "FROM designation " +
                                "WHERE designation_id like N'%" + tbNoiDungTimKiem.Text + "%' or designation like N'%" + tbNoiDungTimKiem.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("designation_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("designation", tbNoiDungTimKiem.Text);
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
            worksheet.Name = "designation";
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
            this.tbDesignation_id.Clear();
            this.tbDesignation.Clear();
            db.HienThi(dataView, "designation");
        }
    }
}
