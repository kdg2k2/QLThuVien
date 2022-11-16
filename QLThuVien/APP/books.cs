using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using QLThuVien.BLL;
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
        DBConnect db = new DBConnect();

        ID_Check dieuKien = new ID_Check();
        private void books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.books' table. You can move, or remove it, as needed.
            //this.booksTableAdapter.Fill(this.qLThuVienDataSet.books);
            con.Open();
            db.HienThi(dataView, "books");
        }
        
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSach.Text) || String.IsNullOrEmpty(tbTenSach.Text) || String.IsNullOrEmpty(tbMaLoai.Text) || String.IsNullOrEmpty(tbquantity.Text) || String.IsNullOrEmpty(tbTenTacGia.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            
            if (dieuKien.KiemTraMa("books", "book_id", tbMaSach.Text) > 0)
            {
                MessageBox.Show("Mã đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                return;
            }

            
            if (dieuKien.KiemTraMa("type", "type_id", tbMaLoai.Text) == 0)
            {
                MessageBox.Show("Mã loại sách không tồn tại !");
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO books " +
                                                "VALUES (@book_id, @book_name, @type_id, @quantity, @author_name)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("book_id", tbMaSach.Text);
                cmd.Parameters.AddWithValue("book_name", tbTenSach.Text);
                cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
                cmd.Parameters.AddWithValue("quantity", tbquantity.Text);
                cmd.Parameters.AddWithValue("author_name", tbTenTacGia.Text);
                cmd.ExecuteNonQuery();
                db.HienThi(dataView, "books");;
            }
            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSach.Text) || String.IsNullOrEmpty(tbTenSach.Text) || String.IsNullOrEmpty(tbMaLoai.Text) || String.IsNullOrEmpty(tbquantity.Text) || String.IsNullOrEmpty(tbTenTacGia.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            
            if (dieuKien.KiemTraMa("type", "type_id", tbMaLoai.Text) == 0)
            {
                MessageBox.Show("Mã loại sách không tồn tại !");
                return;
            }

            else
            {
                string sqlThem = "update books " +
                                "set book_id=@book_id, book_name=@book_name, type_id=@type_id, quantity=@quantity, author_name=@author_name " +
                                "where book_id=@book_id";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("book_id", tbMaSach.Text);
                cmd.Parameters.AddWithValue("book_name", tbTenSach.Text);
                cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
                cmd.Parameters.AddWithValue("quantity", tbquantity.Text);
                cmd.Parameters.AddWithValue("author_name", tbTenTacGia.Text);
                cmd.ExecuteNonQuery();
                db.HienThi(dataView, "books");;
            }
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
            cmd.Parameters.AddWithValue("quantity", tbquantity.Text);
            cmd.Parameters.AddWithValue("author_name", tbTenTacGia.Text);
            cmd.ExecuteNonQuery();
            db.HienThi(dataView, "books");;
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
                                    "WHERE book_id like N'%" + tbNoiDungTimKiem.Text + "%' or book_name like N'%" + tbNoiDungTimKiem.Text + "%' or type_id like N'%" + tbNoiDungTimKiem.Text + "%' or quantity like N'%" + tbNoiDungTimKiem.Text + "%' or author_name like N'%" + tbNoiDungTimKiem.Text + "%'";

            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("book_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("book_name", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("type_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("quantity", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("author_name", tbNoiDungTimKiem.Text);
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
                    obj.quantity = dt.Rows[i]["quantity"].ToString();
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
                MessageBox.Show("Bạn phải chọn tệp excel để nhập vào");
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
                    MessageBox.Show("Import thành công");
                    db.HienThi(dataView, "books");;
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
            worksheet.Name = "books";
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
            this.tbMaSach.Clear();
            this.tbTenTacGia.Clear();
            this.tbTenSach.Clear();
            this.tbFileName.Clear();
            this.tbquantity.Clear();
            this.tbMaLoai.Clear();
            this.tbNoiDungTimKiem.Clear();
            db.HienThi(dataView, "books");;
        }

        private void books_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
