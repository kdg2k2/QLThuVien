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
    public partial class designation : Form
    {
        public designation()
        {
            InitializeComponent();
        }

        SqlConnection con = DBConnect.GetDBConnection();

        public void HienThi()
        {
            string sqlSelect = "select * from designation";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataView.DataSource = dt;
        }
        int dieuKien = 0;
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
                dieuKien++;
            }
        }
        private void designation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.designation' table. You can move, or remove it, as needed.
            this.designationTableAdapter.Fill(this.qLThuVienDataSet.designation);
            con.Open();
            HienThi();
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

            KiemTraMa("designation", "designation_id", tbDesignation_id.Text);
            if (dieuKien > 0)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                dieuKien = 0;
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
                dieuKien = 0;
                HienThi();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbDesignation_id.Text) || String.IsNullOrEmpty(tbDesignation.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            KiemTraMa("designation", "designation_id", tbDesignation_id.Text);
            if (dieuKien > 0)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                dieuKien = 0;
                return;
            }

            else
            {
                string sqlThem = "update designation " +
                                "set designation_id=@designation_id, designation=@designation " +
                                "where designation_id=@designation_id";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("designation_id", tbDesignation_id.Text);
                cmd.Parameters.AddWithValue("designation", tbDesignation.Text);
                cmd.ExecuteNonQuery();
                HienThi();
                dieuKien = 0;
            }
            
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
                                "FROM designation " +
                                "WHERE designation_id=@designation_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("designation_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("designation", tbDesignation.Text);
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

                            this.cbbSheet.Text = "designation";//Mặc định
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
                List<DTO_designation> list = new List<DTO_designation>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DTO_designation obj = new DTO_designation();
                    obj.designation_id = dt.Rows[i]["designation_id"].ToString();
                    obj.designation = dt.Rows[i]["designation"].ToString();
                    list.Add(obj);
                }
                designationBindingSource.DataSource = list;
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
                DapperPlusManager.Entity<DTO_designation>().Table("designation");
                List<DTO_designation> temp = designationBindingSource.DataSource as List<DTO_designation>;
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
                            workbook.Worksheets.Add(this.qLThuVienDataSet.designation.CopyToDataTable(), "designation");
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
            this.tbDesignation_id.Clear();
            this.tbDesignation.Clear();
            this.tbFileName.Clear();
            HienThi();
        }
    }
}
