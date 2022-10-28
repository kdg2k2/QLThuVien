using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        SqlConnection con = DBConnect.GetDBConnection();

        public void HienThi()
        {
            string sqlSelect = "select * from staff";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            MD5_algorithm md5 = new MD5_algorithm();
            //foreach (DataRow row in dt.Rows)
            //{
            //    row["name"] = md5.GiaiMaSring(row["name"].ToString(), "NguyenKhaDang");
            //    row["gender"] = md5.GiaiMaSring(row["gender"].ToString(), "NguyenKhaDang");
            //    row["designation_id"] = md5.GiaiMaSring(row["designation_id"].ToString(), "NguyenKhaDang");
            //    row["address"] = md5.GiaiMaSring(row["address"].ToString(), "NguyenKhaDang");
            //    row["phone"] = md5.GiaiMaSring(row["phone"].ToString(), "NguyenKhaDang");

            //}
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
        private void staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.qLThuVienDataSet.staff);
            con.Open();
            HienThi();
        }

        private void staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbStaff_id.Text) || String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbGender.Text) || String.IsNullOrEmpty(tbDesignation_id.Text) || String.IsNullOrEmpty(tbAddress.Text) || String.IsNullOrEmpty(tbPhone.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            KiemTraMa("staff", "staff_id", tbStaff_id.Text);
            if (dieuKien > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                MessageBox.Show("Hãy nhập mã khác");
                dieuKien = 0;
                return;
            }
            KiemTraMa("designation", "designation_id", tbDesignation_id.Text);
            if (dieuKien == 0)
            {
                MessageBox.Show("Mã chức vụ tồn tại");
                return;
            }
            else
            {
                MD5_algorithm md5 = new MD5_algorithm();

                string sqlThem = "INSERT INTO staff " +
                                "VALUES (@staff_id, @name, @gender, @designation_id, @address, @phone)";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("staff_id", tbStaff_id.Text);
                cmd.Parameters.AddWithValue("name", tbName.Text);
                cmd.Parameters.AddWithValue("gender", tbGender.Text);
                cmd.Parameters.AddWithValue("designation_id", tbDesignation_id.Text);
                cmd.Parameters.AddWithValue("address", tbAddress.Text);
                cmd.Parameters.AddWithValue("phone", tbPhone.Text);

                //Mã Hoá
                //cmd.Parameters.AddWithValue("staff_id", tbStaff_id.Text);
                //cmd.Parameters.AddWithValue("name", md5.MaHoaString((tbName.Text), "NguyenKhaDang"));
                //cmd.Parameters.AddWithValue("gender", md5.MaHoaString((tbGender.Text), "NguyenKhaDang"));
                //cmd.Parameters.AddWithValue("designation_id", md5.MaHoaString((tbDesignation_id.Text), "NguyenKhaDang"));
                //cmd.Parameters.AddWithValue("address", md5.MaHoaString((tbAddress.Text), "NguyenKhaDang"));
                //cmd.Parameters.AddWithValue("phone", md5.MaHoaString((tbPhone.Text), "NguyenKhaDang"));
                cmd.ExecuteNonQuery();
                HienThi();
                dieuKien = 0;
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbStaff_id.Text) || String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbGender.Text) || String.IsNullOrEmpty(tbDesignation_id.Text) || String.IsNullOrEmpty(tbAddress.Text) || String.IsNullOrEmpty(tbPhone.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào");
                return;
            }

            KiemTraMa("designation", "designation_id", tbDesignation_id.Text);
            if (dieuKien == 0)
            {
                MessageBox.Show("Mã chức vụ tồn tại");
                return;
            }

            else
            {
                string sqlThem = "update staff " +
                                    "set staff_id=@staff_id, name=@name, gender=@gender, designation_id=@designation_id, address=@address, phone=@phone " +
                                    "where staff_id=@staff_id";
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.Parameters.AddWithValue("staff_id", tbStaff_id.Text);
                cmd.Parameters.AddWithValue("name", tbName.Text);
                cmd.Parameters.AddWithValue("gender", tbGender.Text);
                cmd.Parameters.AddWithValue("designation_id", tbDesignation_id.Text);
                cmd.Parameters.AddWithValue("address", tbAddress.Text);
                cmd.Parameters.AddWithValue("phone", tbPhone.Text);
                cmd.ExecuteNonQuery();
                HienThi();
                dieuKien = 0;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbStaff_id.Text))
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên vào");
                return;
            }

            string sqlThem = "delete from staff " +
                                "where staff_id=@staff_id";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("staff_id", tbStaff_id.Text);
            cmd.Parameters.AddWithValue("name", tbName.Text);
            cmd.Parameters.AddWithValue("gender", tbGender.Text);
            cmd.Parameters.AddWithValue("designation_id", tbDesignation_id.Text);
            cmd.Parameters.AddWithValue("address", tbAddress.Text);
            cmd.Parameters.AddWithValue("phone", tbPhone.Text);
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

            //string sqlThem = "SELECT * " +
            //                        "FROM staff " +
            //                        "WHERE staff_id=@staff_id";
            string sqlThem = "SELECT * " +
                                    "FROM staff " +
                                    "WHERE staff_id like N'%" + tbNoiDungTimKiem.Text + "%' or name like N'%" + tbNoiDungTimKiem.Text + "%' or gender like N'%" + tbNoiDungTimKiem.Text + "%' or designation_id like N'%" + tbNoiDungTimKiem.Text + "%' or address like N'%" + tbNoiDungTimKiem.Text + "%' or phone like N'%" + tbNoiDungTimKiem.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("staff_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("name", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("gender", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("designation_id", tbNoiDungTimKiem.Text);
            cmd.Parameters.AddWithValue("address", tbNoiDungTimKiem.Text);
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

                            this.cbbSheet.Text = "staff";//Mặc định
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
                List<DTO_staff> list = new List<DTO_staff>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DTO_staff obj = new DTO_staff();
                    obj.staff_id = dt.Rows[i]["staff_id"].ToString();
                    obj.name = dt.Rows[i]["name"].ToString();
                    obj.gender = dt.Rows[i]["gender"].ToString();
                    obj.designation_id = dt.Rows[i]["designation_id"].ToString();
                    obj.address = dt.Rows[i]["address"].ToString();
                    obj.phone = dt.Rows[i]["phone"].ToString();
                    list.Add(obj);
                }
                staffBindingSource.DataSource = list;
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
                DapperPlusManager.Entity<DTO_staff>().Table("staff");
                List<DTO_staff> temp = staffBindingSource.DataSource as List<DTO_staff>;
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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel File|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.qLThuVienDataSet.staff.CopyToDataTable(), "staff");
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
            this.tbStaff_id.Clear();
            this.tbName.Clear();
            this.tbGender.Clear();
            this.tbFileName.Clear();
            this.tbDesignation_id.Clear();
            this.tbAddress.Clear();
            this.tbPhone.Clear();
            HienThi();
        }
    }
}
