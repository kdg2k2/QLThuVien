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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnect.GetDBConnection();

        public void HienThi()
        {
            string sqlSelect = "select * from student";
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
        private void students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.qLThuVienDataSet.student);
            con.Open();
            HienThi();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSV.Text) || String.IsNullOrEmpty(tbTenSV.Text) || String.IsNullOrEmpty(tbSDT.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            KiemTraMa("student", "student_id", tbTenSV.Text);
            if (dieuKien > 0)
            {
                MessageBox.Show("Mã sinh viên tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                return;
            }
            else
            {
                string sqlThem = "INSERT INTO student " +
                                "VALUES (@student_id, @studentname, @phone)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("student_id", tbMaSV.Text);
                cmd.Parameters.AddWithValue("studentname", tbTenSV.Text);
                cmd.Parameters.AddWithValue("phone", tbSDT.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSV.Text) || String.IsNullOrEmpty(tbTenSV.Text) || String.IsNullOrEmpty(tbSDT.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            string sqlSua = "update student " +
                                "set student_id=@student_id, studentname=@studentname, phone=@phone " +
                                "where student_id=@student_id";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("student_id", tbMaSV.Text);
            cmd.Parameters.AddWithValue("studentname", tbTenSV.Text);
            cmd.Parameters.AddWithValue("phone", tbSDT.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaSV.Text))
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên vào để xoá");
                return;
            }

            string sqlXoa = "delete from student " +
                                "where student_id=@student_id";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("student_id", tbMaSV.Text);
            cmd.Parameters.AddWithValue("studentname", tbTenSV.Text);
            cmd.Parameters.AddWithValue("phone", tbSDT.Text);
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
                                    "FROM student " +
                                    "WHERE student_id like N'%" + tbNoiDungTimKiem.Text + "%' or studentname like N'%" + tbNoiDungTimKiem.Text + "%' or phone like N'%" + tbNoiDungTimKiem.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("student_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("studentname", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("phone", tbNoiDungTimKiem.Text);
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

                            this.cbbSheet.Text = "student";//Mặc định
                        }
                    }
                }
            }
        }

        private void sbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tables[cbbSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<DTO_student> list = new List<DTO_student>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DTO_student obj = new DTO_student();
                    obj.student_id = dt.Rows[i]["student_id"].ToString();
                    obj.studentname = dt.Rows[i]["studentname"].ToString();
                    obj.phone = dt.Rows[i]["phone"].ToString();
                    list.Add(obj);
                }
                studentBindingSource.DataSource = list;
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
                DapperPlusManager.Entity<DTO_student>().Table("student");
                List<DTO_student> Students = studentBindingSource.DataSource as List<DTO_student>;
                if (Students != null)
                {
                    using (IDbConnection db = new SqlConnection(connecionString))
                    {
                        db.BulkInsert(Students);
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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel File|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.qLThuVienDataSet.student.CopyToDataTable(), "student");
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
            this.tbMaSV.Clear();
            this.tbTenSV.Clear();
            this.tbSDT.Clear();
            this.tbFileName.Clear();
            HienThi();
        }

        private void students_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
