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

            SqlCommand cmd = new SqlCommand("select * from type", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            tbMaLoai.DataSource = ds.Tables[0];
            tbMaLoai.DisplayMember = "type_id";
            tbMaLoai.Text = "";
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
                                                "VALUES (@book_id, @book_name, @type_id, @quantity, @author_name)";//lệnh truy vấn
                SqlCommand cmd = new SqlCommand(sqlThem, con);//khởi tạo một đối tượng SqlCommand với hai tham số là câu lệnh sqlThem và đối tượng kết nối cơ sở dữ liệu
                cmd.Parameters.AddWithValue("book_id", tbMaSach.Text);
                cmd.Parameters.AddWithValue("book_name", tbTenSach.Text);
                cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
                cmd.Parameters.AddWithValue("quantity", tbquantity.Text);
                cmd.Parameters.AddWithValue("author_name", tbTenTacGia.Text); //thêm các giá trị tương ứng vào các tham số @book_id, @book_name, @type_id, @quantity, và @author_name được truyền vào trong câu lệnh sqlThem. Các giá trị được lấy từ Text của các textbox tương ứng tbMaSach, tbTenSach, tbMaLoai, tbquantity, và tbTenTacGia.
                cmd.ExecuteNonQuery();//thực thi truy vấn
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

        DataTableCollection tables; //biến tables chứa dữ liệu
        private void btTimFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel File|*.xls;*.xlsx" }) //Mở hộp thoại mở tập tin và chỉ cho phép người dùng chọn tập tin có định dạng Excel (.xls hoặc .xlsx).
            {
                if (ofd.ShowDialog() == DialogResult.OK) //Nếu người dùng chọn một tập tin và nhấn nút "Open" trong hộp thoại mở tập tin, thực hiện các lệnh bên trong điều kiện.
                {
                    tbFileName.Text = ofd.FileName;//Lấy tên tập tin được chọn và hiển thị trên một đối tượng TextBox có tên tbFileName.
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))//Mở tập tin được chọn và lưu đối tượng Stream của tập tin đó vào biến stream.
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))//Tạo một đối tượng IExcelDataReader từ biến stream để đọc dữ liệu từ tập tin Excel.
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()//Đọc dữ liệu từ tập tin Excel và lưu vào một đối tượng DataSet. DataSet là một tập hợp các đối tượng DataTable và có thể chứa nhiều bảng khác nhau.
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tables = result.Tables;//Lấy tập hợp các bảng trong DataSet result và lưu vào biến tables.
                            cbbSheet.Items.Clear();//Xóa tất cả các mục trong đối tượng ComboBox

                            foreach (DataTable table in tables)//Vòng lặp duyệt qua từng bảng trong tập hợp các bảng tables.
                                cbbSheet.Items.Add(table.TableName);//Thêm tên của bảng table vào đối tượng ComboBox cbbSheet.

                            this.cbbSheet.Text = "books";//Thiết lập giá trị mặc định cho ComboBox cbbSheet là "books".
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
                for (int i = 0; i < dt.Rows.Count; i++)//lặp đến khi i lớn hơn số hàng trong bảng dữ liệu
                {
                    DTO_books obj = new DTO_books();//tạo một đối tượng DTO_books (obj) và gán giá trị cho các thuộc tính của đối tượng từ các cột trong hàng hiện tại của bảng dữ liệu.
                    obj.book_id = dt.Rows[i]["book_id"].ToString();//gán cho thuộc tính book_id của đối tượng obj = giá trị của cột book_id trong hàng [i] sẽ được lấy ra bằng cách sử dụng dt.Rows[0]["book_id"]. ToString() sẽ chuyển giá trị cột này sang kiểu string 
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
                DapperPlusManager.Entity<DTO_books>().Table("books");//định nghĩa một đối tượng Entity của Dapper Plus, trong đó DTO_books là kiểu dữ liệu của đối tượng và "books" là tên bảng trong cơ sở dữ liệu mà đối tượng sẽ được lưu trữ.
                List<DTO_books> temp = booksBindingSource.DataSource as List<DTO_books>;//ép kiểu nguồn dữ liệu (data source) của đối tượng binding source có tên booksBindingSource thành một danh sách các đối tượng DTO_books và gán kết quả cho temp
                if (temp != null)
                {
                    using (IDbConnection db = new SqlConnection(connecionString))
                    {
                        db.BulkInsert(temp);//hàm BulkInsert() được sử dụng để chèn nhiều bản ghi cùng lúc vào bảng books trong cơ sở dữ liệu. Tham số temp của hàm này là danh sách các đối tượng DTO_books cần chèn.
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
              
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();// khởi tạo Excel Application
            
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);// tạo  WorkBook từ đối tượng Excel application và thêm nó vào tập tin Excel mới. 
            
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;// tạo Excelsheet mới trong workbook  
             
            app.Visible = true;// hiển thị excel cùng chương trình 
            
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];//lấy sheet có tên "Sheet1" trong tệp Excel và gán cho đối tượng worksheet.
            worksheet = workbook.ActiveSheet;//lấy sheet đang được chọn (active sheet) trong tệp Excel và gán cho đối tượng worksheet.

            worksheet.Name = "books";//đổi tên sheet hiện tại thành "books"
            
            for (int i = 1; i < dataView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataView.Columns[i - 1].HeaderText;
            }//duyệt qua từng cột trong lưới dữ liệu (data grid view) và gán tên của các cột đó vào các ô bảng (cell) trên sheet Excel. tên của cột được lấy từ thuộc tính HeaderText của đối tượng Column trong lưới dữ liệu. Biến i sẽ được tăng lên 1 mỗi lần lặp, và vòng lặp sẽ kết thúc khi i >= số lượng cột trong lưới dữ liệu.

            for (int i = 0; i < dataView.Rows.Count; i++)
            {
                for (int j = 0; j < dataView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataView.Rows[i].Cells[j].Value.ToString();
                }
            }//duyệt qua từng hàng và từng cột trong lưới dữ liệu (data grid view) và gán giá trị của từng ô dữ liệu vào các ô bảng (cell) trên sheet Excel. Trong mỗi vòng lặp, giá trị của từng ô dữ liệu được lấy từ thuộc tính Value của đối tượng Cell trong lưới dữ liệu. Sau đó, giá trị này được ép kiểu sang dạng chuỗi (ToString()) và được gán vào ô bảng tương ứng trên sheet Excel.
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.tbMaSach.Clear();
            this.tbTenTacGia.Clear();
            this.tbTenSach.Clear();
            this.tbFileName.Clear();
            this.tbquantity.Clear();
            this.tbMaLoai.Refresh();
            this.tbNoiDungTimKiem.Clear();
            tbMaLoai.Text = "";
            db.HienThi(dataView, "books");;
        }

        private void books_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
