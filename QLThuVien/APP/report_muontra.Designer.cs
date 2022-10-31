namespace QLThuVien.APP
{
    partial class report_muontra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.borrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet = new QLThuVien.QLThuVienDataSet();
            this.givebackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.borrowTableAdapter = new QLThuVien.QLThuVienDataSetTableAdapters.borrowTableAdapter();
            this.givebackTableAdapter = new QLThuVien.QLThuVienDataSetTableAdapters.givebackTableAdapter();
            this.dataView_ChuaTraSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_BangMuon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_BangTra = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.givebackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_ChuaTraSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BangMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BangTra)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowBindingSource
            // 
            this.borrowBindingSource.DataMember = "borrow";
            this.borrowBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // givebackBindingSource
            // 
            this.givebackBindingSource.DataMember = "giveback";
            this.givebackBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet_borrow";
            reportDataSource5.Value = this.borrowBindingSource;
            reportDataSource6.Name = "DataSet_giveback";
            reportDataSource6.Value = this.givebackBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLThuVien.APP.Report_Muon_Tra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(385, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(240, 103);
            this.reportViewer1.TabIndex = 0;
            // 
            // borrowTableAdapter
            // 
            this.borrowTableAdapter.ClearBeforeFill = true;
            // 
            // givebackTableAdapter
            // 
            this.givebackTableAdapter.ClearBeforeFill = true;
            // 
            // dataView_ChuaTraSach
            // 
            this.dataView_ChuaTraSach.AllowUserToAddRows = false;
            this.dataView_ChuaTraSach.AllowUserToDeleteRows = false;
            this.dataView_ChuaTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_ChuaTraSach.Location = new System.Drawing.Point(3, 373);
            this.dataView_ChuaTraSach.Name = "dataView_ChuaTraSach";
            this.dataView_ChuaTraSach.ReadOnly = true;
            this.dataView_ChuaTraSach.Size = new System.Drawing.Size(632, 171);
            this.dataView_ChuaTraSach.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 176;
            this.label1.Text = "Sinh Viên Chưa Trả Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 177;
            this.label2.Text = "Báo Cáo Mượn Trả";
            // 
            // dataGridView_BangMuon
            // 
            this.dataGridView_BangMuon.AllowUserToAddRows = false;
            this.dataGridView_BangMuon.AllowUserToDeleteRows = false;
            this.dataGridView_BangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BangMuon.Location = new System.Drawing.Point(3, 133);
            this.dataGridView_BangMuon.Name = "dataGridView_BangMuon";
            this.dataGridView_BangMuon.ReadOnly = true;
            this.dataGridView_BangMuon.Size = new System.Drawing.Size(313, 202);
            this.dataGridView_BangMuon.TabIndex = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 176;
            this.label3.Text = "Bảng Mượn";
            // 
            // dataGridView_BangTra
            // 
            this.dataGridView_BangTra.AllowUserToAddRows = false;
            this.dataGridView_BangTra.AllowUserToDeleteRows = false;
            this.dataGridView_BangTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BangTra.Location = new System.Drawing.Point(322, 133);
            this.dataGridView_BangTra.Name = "dataGridView_BangTra";
            this.dataGridView_BangTra.ReadOnly = true;
            this.dataGridView_BangTra.Size = new System.Drawing.Size(313, 202);
            this.dataGridView_BangTra.TabIndex = 178;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 179;
            this.label4.Text = "Bảng Mượn";
            // 
            // report_muontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 543);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_BangTra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_BangMuon);
            this.Controls.Add(this.dataView_ChuaTraSach);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_muontra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "report_muontra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.report_muontra_FormClosing);
            this.Load += new System.EventHandler(this.report_muontra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.givebackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_ChuaTraSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BangMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BangTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource borrowBindingSource;
        private QLThuVienDataSetTableAdapters.borrowTableAdapter borrowTableAdapter;
        private System.Windows.Forms.BindingSource givebackBindingSource;
        private QLThuVienDataSetTableAdapters.givebackTableAdapter givebackTableAdapter;
        private System.Windows.Forms.DataGridView dataView_ChuaTraSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_BangMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_BangTra;
        private System.Windows.Forms.Label label4;
    }
}