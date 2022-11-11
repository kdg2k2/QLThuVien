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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }
        private void PicStudent_Click(object sender, EventArgs e)
        {
            student sinhvien = new student();
            sinhvien.ShowDialog();
        }

        private void picBooks_Click(object sender, EventArgs e)
        {
            books bk = new books();
            bk.ShowDialog();
        }

        private void picGiveback_Click(object sender, EventArgs e)
        {
            @return re = new @return();
            re.ShowDialog();
        }

        private void picBorrow_Click(object sender, EventArgs e)
        {
            borrow br = new borrow();
            br.ShowDialog();
        }

        private void picType_Click(object sender, EventArgs e)
        {
            type tp = new type();
            tp.ShowDialog();
        }

        private void picStaff_Click(object sender, EventArgs e)
        {
            staff sf = new staff();
            sf.ShowDialog();
        }

        private void picDesignation_Click(object sender, EventArgs e)
        {
            designation de = new designation();
            de.ShowDialog();
        }

        private void picBaoCao_Click(object sender, EventArgs e)
        {
            report_muontra re = new report_muontra();
            re.ShowDialog();
        }

        private void adminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }

        private void lbdoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_change_Password a = new admin_change_Password();
            a.ShowDialog();
        }
    }
}
