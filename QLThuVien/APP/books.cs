using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using QLThuVien.DAL;
using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }

        SqlConnection con = DBConnect.GetDBConnection();

        public void HienThi()
        {
            string sqlSelect = "select * from books";
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

        private void books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.qLThuVienDataSet.books);
            con.Open();
            HienThi();
        }
        
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSach.Text) || String.IsNullOrEmpty(tbTenSach.Text) || String.IsNullOrEmpty(tbMaLoai.Text) || String.IsNullOrEmpty(tbISBN.Text) || String.IsNullOrEmpty(tbTenTacGia.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            KiemTraMa("books", "book_id", tbMaSach.Text);
            if (dem > 0)
            {
                MessageBox.Show("Mã đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                dem = 0;
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO books " +
                                                "VALUES (@book_id, @book_name, @type_id, @isbn, @author_name)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("book_id", tbMaSach.Text);
                cmd.Parameters.AddWithValue("book_name", tbTenSach.Text);
                cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
                cmd.Parameters.AddWithValue("isbn", tbISBN.Text);
                cmd.Parameters.AddWithValue("author_name", tbTenTacGia.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSach.Text) || String.IsNullOrEmpty(tbTenSach.Text) || String.IsNullOrEmpty(tbMaLoai.Text) || String.IsNullOrEmpty(tbISBN.Text) || String.IsNullOrEmpty(tbTenTacGia.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            string sqlThem = "update books " +
                                "set book_id=@book_id, book_name=@book_name, type_id=@type_id, isbn=@isbn, author_name=@author_name " +
                                "where book_id=@book_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("book_id", tbMaSach.Text);
            cmd.Parameters.AddWithValue("book_name", tbTenSach.Text);
            cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
            cmd.Parameters.AddWithValue("isbn", tbISBN.Text);
            cmd.Parameters.AddWithValue("author_name", tbTenTacGia.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSach.Text))
            {
                MessageBox.Show("Bạn phải nhập mã sách vào");
                return;
            }

            string sqlThem = "delete from books " +
                                "where book_id=@book_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("book_id", tbMaSach.Text);
            cmd.Parameters.AddWithValue("book_name", tbTenSach.Text);
            cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
            cmd.Parameters.AddWithValue("isbn", tbISBN.Text);
            cmd.Parameters.AddWithValue("author_name", tbTenTacGia.Text);
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
                                    "FROM books " +
                                    "WHERE book_id=@book_id";

            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("book_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("book_name", tbTenSach.Text);
            cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
            cmd.Parameters.AddWithValue("isbn", tbISBN.Text);
            cmd.Parameters.AddWithValue("author_name", tbTenTacGia.Text);
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

                            this.cbbSheet.Text = "books";//Mặc định
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
                List<DTO_books> list = new List<DTO_books>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DTO_books obj = new DTO_books();
                    obj.book_id = dt.Rows[i]["book_id"].ToString();
                    obj.book_name = dt.Rows[i]["book_name"].ToString();
                    obj.type_id = dt.Rows[i]["type_id"].ToString();
                    obj.isbn = dt.Rows[i]["isbn"].ToString();
                    obj.author_name = dt.Rows[i]["author_name"].ToString();
                    list.Add(obj);
                }
                booksBindingSource.DataSource = list;
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
                DapperPlusManager.Entity<DTO_books>().Table("books");
                List<DTO_books> temp = booksBindingSource.DataSource as List<DTO_books>;
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
                            workbook.Worksheets.Add(this.qLThuVienDataSet.books.CopyToDataTable(), "books");
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
            this.tbMaSach.Clear();
            this.tbTenTacGia.Clear();
            this.tbTenSach.Clear();
            this.tbFileName.Clear();
            this.tbISBN.Clear();
            this.tbMaLoai.Clear();
            HienThi();
        }

        private void books_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void tbNoiDungTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMaLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tbTenTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
