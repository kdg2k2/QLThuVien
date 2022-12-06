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
    public partial class borrow : Form
    {
        public borrow()
        {
            InitializeComponent();
        }

        SqlConnection con = DBConnect.GetDBConnection();
        SLSach sl = new SLSach();
        DBConnect db = new DBConnect();
        ID_Check dieuKien = new ID_Check();

        private void issue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.borrow' table. You can move, or remove it, as needed.
            //this.borrowTableAdapter.Fill(this.qLThuVienDataSet.borrow);
            con.Open();
            db.HienThi(dataView, "borrow");

            SqlCommand cmd = new SqlCommand("select * from books", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            tbBook_id.DataSource = ds.Tables[0];
            tbBook_id.DisplayMember = "book_id";
        }

        private void issue_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbIssue_id.Text) || String.IsNullOrEmpty(tbBook_id.Text) || String.IsNullOrEmpty(tbStudent_id.Text) || String.IsNullOrEmpty(tbStaff_id.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            if (dieuKien.KiemTraMa("student", "student_id", tbStudent_id.Text) == 0)
            {
                MessageBox.Show("Mã sinh viên ko tồn tại");
                student s = new student();
                s.ShowDialog();
            }

            if (dieuKien.KiemTraMa("borrow", "issue_id", tbIssue_id.Text) > 0)
            {
                MessageBox.Show("Mã mượn đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                return;
            }


            if (dieuKien.KiemTraMa("books", "book_id", tbBook_id.Text) == 0)
            {
                MessageBox.Show("Mã sách không tồn tại");
                return;
            }

            if (dieuKien.KiemTraMa("staff", "staff_id", tbStaff_id.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên ko tồn tại");
                return;
            }

            if (sl.CheckSL(tbBook_id.Text) <= 1)
            {
                MessageBox.Show("Sách này ko còn đủ số lượng để cho mượn");
                MessageBox.Show("Vui lòng mượn sách khác!");
                return;
            }
            DateTime ngaymuon = dateIssue.Value;
            DateTime hantra = dateExpirary.Value;
            if (hantra <= ngaymuon)
            {
                MessageBox.Show("Hạn hạn trả ko hợp lệ !");
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO borrow " +
                                "VALUES (@issue_id, @book_id, @date_issue, @date_expirary, @student_id, @staff_id)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("issue_id", tbIssue_id.Text);
                cmd.Parameters.AddWithValue("book_id", tbBook_id.Text);
                cmd.Parameters.AddWithValue("date_issue", dateIssue.Value);
                cmd.Parameters.AddWithValue("date_expirary", dateExpirary.Value);
                cmd.Parameters.AddWithValue("student_id", tbStudent_id.Text);
                cmd.Parameters.AddWithValue("staff_id", tbStaff_id.Text);
                cmd.ExecuteNonQuery();

                sl.SLGiam(tbBook_id.Text);
                db.HienThi(dataView, "borrow");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbIssue_id.Text) || String.IsNullOrEmpty(tbBook_id.Text) || String.IsNullOrEmpty(tbStudent_id.Text) || String.IsNullOrEmpty(tbStaff_id.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }


            if (dieuKien.KiemTraMa("books", "book_id", tbBook_id.Text) == 0)
            {
                MessageBox.Show("Mã sách không tồn tại");
                return;
            }


            if (dieuKien.KiemTraMa("student", "student_id", tbStudent_id.Text) == 0)
            {
                MessageBox.Show("Mã sinh viên tồn tại");
                return;
            }


            if (dieuKien.KiemTraMa("staff", "staff_id", tbStaff_id.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên tồn tại");
                return;
            }

            else
            {
                string sqlThem = "update borrow " +
                                    "set issue_id=@issue_id, book_id=@book_id, date_issue=@date_issue, date_expirary=@date_expirary, student_id=@student_id, staff_id=@staff_id " +
                                    "where issue_id=@issue_id";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("issue_id", tbIssue_id.Text);
                cmd.Parameters.AddWithValue("book_id", tbBook_id.Text);
                cmd.Parameters.AddWithValue("date_issue", dateIssue.Value);
                cmd.Parameters.AddWithValue("date_expirary", dateExpirary.Value);
                cmd.Parameters.AddWithValue("student_id", tbStudent_id.Text);
                cmd.Parameters.AddWithValue("staff_id", tbStaff_id.Text);
                cmd.ExecuteNonQuery();
                db.HienThi(dataView, "borrow");
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNoiDungTimKiem.Text))
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần tìm vào");
                return;
            }

            string sqlThem = "SELECT * " +
                                    "FROM borrow " +
                                    "WHERE issue_id like N'%" + tbNoiDungTimKiem.Text + "%' or book_id like N'%" + tbNoiDungTimKiem.Text + "%' or student_id like N'%" + tbNoiDungTimKiem.Text + "%' or staff_id like N'%" + tbNoiDungTimKiem.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("issue_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("book_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("date_issue", dateIssue.Value);
            cmd.Parameters.AddWithValue("date_expirary", dateExpirary.Value);
            cmd.Parameters.AddWithValue("student_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("staff_id", tbNoiDungTimKiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataView.DataSource = dt;
        }

        DataTableCollection tables;
        private void btTimFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel File|*.xls;*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbFileName.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tables = result.Tables;
                            cbbSheet.Items.Clear();

                            foreach (DataTable table in tables)
                                cbbSheet.Items.Add(table.TableName);//add sheet

                            this.cbbSheet.Text = "borrow";//Mặc định
                        }
                    }
                }
            }
        }

        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tables[cbbSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<DTO_borrow> list = new List<DTO_borrow>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DTO_borrow obj = new DTO_borrow();
                    obj.issue_id = dt.Rows[i]["issue_id"].ToString();
                    obj.book_id = dt.Rows[i]["book_id"].ToString();
                    obj.date_issue = dt.Rows[i]["date_issue"].ToString();
                    obj.date_expirary = dt.Rows[i]["date_expirary"].ToString();
                    obj.student_id = dt.Rows[i]["student_id"].ToString();
                    obj.staff_id = dt.Rows[i]["staff_id"].ToString();
                    list.Add(obj);
                }
                borrowBindingSource.DataSource = list;
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbFileName.Text))
            {
                MessageBox.Show("Bạn phải chọn tệp dữ liệu để nhập vào");
                return;
            }

            try
            {
                string connecionString = "Server=DG;Database=QLThuVien;User Id=sa;Password=a12345678;";
                DapperPlusManager.Entity<DTO_borrow>().Table("borrow");
                List<DTO_borrow> temp = borrowBindingSource.DataSource as List<DTO_borrow>;
                if (temp != null)
                {
                    using (IDbConnection db = new SqlConnection(connecionString))
                    {
                        db.BulkInsert(temp);
                    }
                    MessageBox.Show("Import thành công");
                    db.HienThi(dataView, "borrow");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            worksheet.Name = "borrow";
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
            this.tbIssue_id.Clear();
            this.tbBook_id.Refresh();
            this.tbStudent_id.Clear();
            this.tbStaff_id.Clear();
            this.tbNoiDungTimKiem.Clear();
            db.HienThi(dataView, "borrow");
        }
    }
}
