using QLThuVien.APP;
using QLThuVien.QLThuVienDataSetTableAdapters;
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
    public partial class serviceForm : Form
    {
        //Form cho người dùng cho chức vụ xử lý các công việc quản lý mượn, trả sách.v.v.
        public serviceForm()
        {
            InitializeComponent();
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

        private void PicStudent_Click(object sender, EventArgs e)
        {
            student b = new student();
            b.ShowDialog();
        }

        private void serviceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }
    }
}
