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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace QLThuVien.APP
{
    public partial class @return : Form
    {
        public @return()
        {
            InitializeComponent();
        }

        SqlConnection con = DBConnect.GetDBConnection();

        public void HienThi()
        {
            string sqlSelect = "select * from giveback";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
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
        private void return_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.giveback' table. You can move, or remove it, as needed.
            //this.givebackTableAdapter.Fill(this.qLThuVienDataSet.giveback);
            con.Open();
            HienThi();
        }

        private void return_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbReturn_id.Text) || String.IsNullOrEmpty(tbIssue_id.Text) || String.IsNullOrEmpty(tbStaff.Text) || String.IsNullOrEmpty(tbBook_id.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            KiemTraMa("giveback", "return_id", tbReturn_id.Text);
            if (dieuKien > 0)
            {
                MessageBox.Show("Mã trả đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                return;
            }

            KiemTraMa("borrow", "issue_id", tbIssue_id.Text);
            if (dieuKien == 0)
            {
                MessageBox.Show("Mã mượn tồn tại");
                return;
            }

            KiemTraMa("books", "book_id", tbBook_id.Text);
            if (dieuKien == 0)
            {
                MessageBox.Show("Mã sách không tồn tại");
                return;
            }

            else
            {
                string sqlThem = "INSERT INTO giveback " +
                                "VALUES (@return_id, @issue_id, @date_return, @staff_id, @book_id)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("return_id", tbReturn_id.Text);
                cmd.Parameters.AddWithValue("issue_id", tbIssue_id.Text);
                cmd.Parameters.AddWithValue("date_return", dateReturn.Value);
                cmd.Parameters.AddWithValue("staff_id", tbStaff.Text);
                cmd.Parameters.AddWithValue("book_id", tbBook_id.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbReturn_id.Text) || String.IsNullOrEmpty(tbIssue_id.Text) || String.IsNullOrEmpty(tbStaff.Text) || String.IsNullOrEmpty(tbBook_id.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            KiemTraMa("borrow", "issue_id", tbIssue_id.Text);
            if (dieuKien == 0)
            {
                MessageBox.Show("Mã mượn không tồn tại");
                return;
            }

            KiemTraMa("books", "book_id", tbBook_id.Text);
            if (dieuKien == 0)
            {
                MessageBox.Show("Mã sách không tồn tại");
                return;
            }

            else
            {
                string sqlThem = "update giveback " +
                                    "set return_id=@return_id, issue_id=@issue_id, date_return=@date_return, staff_id=@staff_id, book_id=@book_id " +
                                    "where return_id=@return_id";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("return_id", tbReturn_id.Text);
                cmd.Parameters.AddWithValue("issue_id", tbIssue_id.Text);
                cmd.Parameters.AddWithValue("date_return", dateReturn.Value);
                cmd.Parameters.AddWithValue("staff_id", tbStaff.Text);
                cmd.Parameters.AddWithValue("book_id", tbBook_id.Text);
                cmd.ExecuteNonQuery();
                HienThi();
                dieuKien = 0;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbReturn_id.Text))
            {
                MessageBox.Show("Bạn phải nhập mã trả vào");
                return;
            }

            string sqlThem = "delete from giveback " +
                                "where return_id=@return_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("return_id", tbReturn_id.Text);
            cmd.Parameters.AddWithValue("issue_id", tbIssue_id.Text);
            cmd.Parameters.AddWithValue("date_return", dateReturn.Value);
            cmd.Parameters.AddWithValue("staff_id", tbStaff.Text);
            cmd.Parameters.AddWithValue("book_id", tbBook_id.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNoiDungTimKiem.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            string sqlThem = "SELECT * " +
                                    "FROM giveback " +
                                    "WHERE return_id like N'%" + tbNoiDungTimKiem.Text + "%' or issue_id like N'%" + tbNoiDungTimKiem.Text + "%' or staff_id like N'%" + tbNoiDungTimKiem.Text + "%' or book_id like N'%" + tbNoiDungTimKiem.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("return_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("issue_id", tbNoiDungTimKiem.Text);
            //cmd.Parameters.AddWithValue("date_return", dateReturn.Value);
            cmd.Parameters.AddWithValue("staff_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("book_id", tbNoiDungTimKiem.Text);
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

                            this.cbbSheet.Text = "giveback";//Mặc định
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
                List<DTO_giveback> list = new List<DTO_giveback>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DTO_giveback obj = new DTO_giveback();
                    obj.return_id = dt.Rows[i]["return_id"].ToString();
                    obj.issue_id = dt.Rows[i]["issue_id"].ToString();
                    obj.date_return = dt.Rows[i]["date_return"].ToString();
                    obj.staff_id = dt.Rows[i]["staff_id"].ToString();
                    obj.book_id = dt.Rows[i]["book_id"].ToString();
                    list.Add(obj);
                }
                givebackBindingSource.DataSource = list;
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
                DapperPlusManager.Entity<DTO_giveback>().Table("giveback");
                List<DTO_giveback> temp = givebackBindingSource.DataSource as List<DTO_giveback>;
                if (temp != null)
                {
                    using (IDbConnection db = new SqlConnection(connecionString))
                    {
                        db.BulkInsert(temp);
                    }
                    MessageBox.Show("Imported thành công");
                    HienThi();
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
            worksheet.Name = "giveback";
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
            this.tbReturn_id.Clear();
            this.tbIssue_id.Clear();
            this.tbStaff.Clear();
            this.tbFileName.Clear();
            this.tbBook_id.Clear();
            HienThi();
        }
    }
}
