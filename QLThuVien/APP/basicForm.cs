using QLThuVien.APP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class basicForm : Form
    {
        public basicForm()
        {
            InitializeComponent();
        }

        private void basicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }

        private void picBorrow_Click(object sender, EventArgs e)
        {
            borrow b = new borrow();
            b.ShowDialog();
        }

        private void picGiveback_Click(object sender, EventArgs e)
        {
            @return b = new @return();
            b.ShowDialog();
        }

        private void PicStudent_Click(object sender, EventArgs e)
        {
            student b = new student();
            b.ShowDialog();
        }

        private void picBooks_Click(object sender, EventArgs e)
        {
            books b = new books();
            b.ShowDialog();
        }

        private void picType_Click(object sender, EventArgs e)
        {
            type b = new type();
            b.ShowDialog();
        }

        private void picBaoCao_Click(object sender, EventArgs e)
        {
            report_muontra b = new report_muontra();
            b.ShowDialog();
        }
    }
}
