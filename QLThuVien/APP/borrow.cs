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
    public partial class borrow : Form
    {
        public borrow()
        {
            InitializeComponent();
        }

        SqlConnection con = DBConnect.GetDBConnection();

        public void HienThi()
        {
            string sqlSelect = "select * from borrow";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataView.DataSource = dt;
        }

        int dem = 0;
        private void KiemTraMa(string TenBang, string TenField, string DieuKien)
        {
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
                dem++;
            }
        }

        private void issue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.qLThuVienDataSet.borrow);
            con.Open();
            HienThi();
        }

        private void issue_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbIssue_id.Text) || String.IsNullOrEmpty(tbBook_id.Text) ||  String.IsNullOrEmpty(tbStudent_id.Text) || String.IsNullOrEmpty(tbStaff_id.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }
            KiemTraMa("borrow", "issue_id", tbIssue_id.Text);
            if(dem > 0)
            {
                MessageBox.Show("Mã đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                dem = 0;
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
                HienThi();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbIssue_id.Text) || String.IsNullOrEmpty(tbBook_id.Text) ||  String.IsNullOrEmpty(tbStudent_id.Text) || String.IsNullOrEmpty(tbStaff_id.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

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
            HienThi();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbIssue_id.Text))
            {
                MessageBox.Show("Bạn phải nhập mã mượn vào");
                return;
            }

            string sqlThem = "delete from borrow " +
                                "where issue_id=@issue_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("issue_id", tbIssue_id.Text);
            cmd.Parameters.AddWithValue("book_id", tbBook_id.Text);
            cmd.Parameters.AddWithValue("date_issue", dateIssue.Value);
            cmd.Parameters.AddWithValue("date_expirary", dateExpirary.Value);
            cmd.Parameters.AddWithValue("student_id", tbStudent_id.Text);
            cmd.Parameters.AddWithValue("staff_id", tbStaff_id.Text);
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

            string sqlThem = "SELECT * " +
                                    "FROM borrow " +
                                    "WHERE issue_id=@issue_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("issue_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("book_id", tbBook_id.Text);
            cmd.Parameters.AddWithValue("date_issue", dateIssue.Value);
            cmd.Parameters.AddWithValue("date_expirary", dateExpirary.Value);
            cmd.Parameters.AddWithValue("student_id", tbStudent_id.Text);
            cmd.Parameters.AddWithValue("staff_id", tbStaff_id.Text);
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
                    MessageBox.Show("Imported successfully");
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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel File|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.qLThuVienDataSet.borrow.CopyToDataTable(), "borrow");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất tệp Excel thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.tbIssue_id.Clear();
            this.tbBook_id.Clear();
            this.tbStudent_id.Clear();
            this.tbStaff_id.Clear();
            this.tbNoiDungTimKiem.Clear();
            HienThi();
        }
    }
}
