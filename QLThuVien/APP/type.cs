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
    public partial class type : Form
    {
        public type()
        {
            InitializeComponent();
        }

        SqlConnection con = DBConnect.GetDBConnection();

        public void HienThi()
        {
            string sqlSelect = "select * from type";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataView.DataSource = dt;
        }

        ID_Check dieuKien = new ID_Check();

        private void type_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.type' table. You can move, or remove it, as needed.
            //this.typeTableAdapter.Fill(this.qLThuVienDataSet.type);
            con.Open();
            HienThi();
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaLoai.Text) || String.IsNullOrEmpty(tbTenLoai.Text) )
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            
            if (dieuKien.KiemTraMa("type", "type_id", tbMaLoai.Text) > 0)
            {
                MessageBox.Show("Mã đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO type " +
                                "VALUES (@type_id, @type_name)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
                cmd.Parameters.AddWithValue("type_name", tbTenLoai.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaLoai.Text) || String.IsNullOrEmpty(tbTenLoai.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            string sqlThem = "update type " +
                                "set type_id=@type_id, type_name=@type_name " +
                                "where type_id=@type_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
            cmd.Parameters.AddWithValue("type_name", tbTenLoai.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaLoai.Text))
            {
                MessageBox.Show("Bạn phải nhập mã loại sách vào");
                return;
            }

            string sqlThem = "delete from type " +
                                "where type_id=@type_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("type_id", tbMaLoai.Text);
            cmd.Parameters.AddWithValue("type_name", tbTenLoai.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNoiDungTimKiem.Text))
            {
                MessageBox.Show("Bạn phải nhập nội dung tìm vào");
                return;
            }

            string sqlThem = "SELECT * " +
                                    "FROM type " +
                                    "WHERE type_id like N'%" + tbNoiDungTimKiem.Text + "%' or type_name like N'%" + tbNoiDungTimKiem.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("type_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("type_name", tbNoiDungTimKiem.Text);
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

                            this.cbbSheet.Text = "type";//Mặc định
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
                List<DTO_type> list = new List<DTO_type>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DTO_type obj = new DTO_type();
                    obj.type_id = dt.Rows[i]["type_id"].ToString();
                    obj.type_name = dt.Rows[i]["type_name"].ToString();
                    list.Add(obj);
                }
                typeBindingSource.DataSource = list;
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
                DapperPlusManager.Entity<DTO_type>().Table("type");
                List<DTO_type> temp = typeBindingSource.DataSource as List<DTO_type>;
                if (temp != null)
                {
                    using (IDbConnection db = new SqlConnection(connecionString))
                    {
                        db.BulkInsert(temp);
                    }
                    MessageBox.Show("Import thành công");
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
            // khởi tạo Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // tạo WorkBook mới trong Excel Application 
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // tạo Excelsheet mới  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // mở bảng excel đằng sau chương trình
            app.Visible = true;
            // lấy tham chiếu của trang tính đầu tiên. Theo mặc định, tên của nó là Sheet1  
            worksheet = workbook.Sheets["Sheet1"];
            // lưu trữ tham chiếu của nó vào sheet 
            worksheet = workbook.ActiveSheet;
            // thay đổi tên của sheet  
            worksheet.Name = "type";
            // lấy tên cột
            for (int i = 1; i < dataView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataView.Columns[i - 1].HeaderText;
            }
            // lưu trữ từng giá trị hàng và cột vào sheet 
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
            this.tbMaLoai.Clear();
            this.tbTenLoai.Clear();
            this.tbFileName.Clear();
            HienThi();
        }

        private void type_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
