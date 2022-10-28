using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.APP
{
    public partial class report_muontra : Form
    {
        public report_muontra()
        {
            InitializeComponent();
        }

        private void report_muontra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.giveback' table. You can move, or remove it, as needed.
            this.givebackTableAdapter.Fill(this.qLThuVienDataSet.giveback);
            // TODO: This line of code loads data into the 'qLThuVienDataSet.borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.qLThuVienDataSet.borrow);
            this.reportViewer1.RefreshReport();
        }
    }
}
