namespace QLThuVien.APP
{
    partial class @return
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
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.btExport = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btImport = new System.Windows.Forms.Button();
            this.btTimFile = new System.Windows.Forms.Button();
            this.cbbSheet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbNoiDungTimKiem = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbReturn_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateexpiraryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givebackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet = new QLThuVien.QLThuVienDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.tbStaff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_expirary = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.givebackTableAdapter = new QLThuVien.QLThuVienDataSetTableAdapters.givebackTableAdapter();
            this.tbIssue_id = new System.Windows.Forms.ComboBox();
            this.tbBook_id = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.givebackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateReturn
            // 
            this.dateReturn.CustomFormat = "dd/MM/yyyy";
            this.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReturn.Location = new System.Drawing.Point(87, 69);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(190, 20);
            this.dateReturn.TabIndex = 2;
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(138, 148);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 262;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 13);
            this.label20.TabIndex = 261;
            this.label20.Text = "Xuất dữ liệu ra file Excel";
            // 
            // btRefresh
            // 
            this.btRefresh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btRefresh.Location = new System.Drawing.Point(343, 19);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(112, 147);
            this.btRefresh.TabIndex = 260;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 259;
            this.label2.Text = "Thêm dữ liệu bằng file Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 258;
            this.label1.Text = "Nội dung tìm:";
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(202, 114);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(75, 23);
            this.btImport.TabIndex = 257;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btTimFile
            // 
            this.btTimFile.Location = new System.Drawing.Point(297, 86);
            this.btTimFile.Name = "btTimFile";
            this.btTimFile.Size = new System.Drawing.Size(37, 23);
            this.btTimFile.TabIndex = 256;
            this.btTimFile.Text = "...";
            this.btTimFile.UseVisualStyleBackColor = true;
            this.btTimFile.Click += new System.EventHandler(this.btTimFile_Click);
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(74, 114);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(121, 21);
            this.cbbSheet.TabIndex = 255;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 254;
            this.label3.Text = "Sheet";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(74, 88);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(220, 20);
            this.tbFileName.TabIndex = 253;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 252;
            this.label4.Text = "File Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 251;
            this.label6.Text = "Tìm Kiếm";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(220, 23);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(115, 20);
            this.btTimKiem.TabIndex = 249;
            this.btTimKiem.Text = "Search";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbNoiDungTimKiem
            // 
            this.tbNoiDungTimKiem.Location = new System.Drawing.Point(89, 23);
            this.tbNoiDungTimKiem.Name = "tbNoiDungTimKiem";
            this.tbNoiDungTimKiem.Size = new System.Drawing.Size(124, 20);
            this.tbNoiDungTimKiem.TabIndex = 250;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(312, 103);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(103, 37);
            this.btUpdate.TabIndex = 247;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 243;
            this.label5.Text = "Ngày Trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 242;
            this.label7.Text = "Mã Sách";
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(312, 31);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(103, 37);
            this.btInsert.TabIndex = 236;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbReturn_id
            // 
            this.tbReturn_id.Location = new System.Drawing.Point(87, 14);
            this.tbReturn_id.Name = "tbReturn_id";
            this.tbReturn_id.Size = new System.Drawing.Size(190, 20);
            this.tbReturn_id.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 234;
            this.label10.Text = "Mã Trả";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dateexpiraryDataGridViewTextBoxColumn});
            this.dataView.DataSource = this.givebackBindingSource;
            this.dataView.Location = new System.Drawing.Point(483, 12);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(643, 425);
            this.dataView.TabIndex = 233;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "return_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "return_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "issue_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "issue_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date_return";
            this.dataGridViewTextBoxColumn3.HeaderText = "date_return";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "staff_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "staff_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "book_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "book_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dateexpiraryDataGridViewTextBoxColumn
            // 
            this.dateexpiraryDataGridViewTextBoxColumn.DataPropertyName = "date_expirary";
            this.dateexpiraryDataGridViewTextBoxColumn.HeaderText = "date_expirary";
            this.dateexpiraryDataGridViewTextBoxColumn.Name = "dateexpiraryDataGridViewTextBoxColumn";
            this.dateexpiraryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // givebackBindingSource
            // 
            this.givebackBindingSource.DataMember = "giveback";
            this.givebackBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 237;
            this.label9.Text = "Mã Mượn";
            // 
            // tbStaff
            // 
            this.tbStaff.Location = new System.Drawing.Point(87, 95);
            this.tbStaff.Name = "tbStaff";
            this.tbStaff.Size = new System.Drawing.Size(190, 20);
            this.tbStaff.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 242;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBook_id);
            this.groupBox1.Controls.Add(this.tbIssue_id);
            this.groupBox1.Controls.Add(this.date_expirary);
            this.groupBox1.Controls.Add(this.btInsert);
            this.groupBox1.Controls.Add(this.dateReturn);
            this.groupBox1.Controls.Add(this.btUpdate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbStaff);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbReturn_id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 174);
            this.groupBox1.TabIndex = 264;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // date_expirary
            // 
            this.date_expirary.CustomFormat = "dd/MM/yyyy";
            this.date_expirary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_expirary.Location = new System.Drawing.Point(87, 147);
            this.date_expirary.Name = "date_expirary";
            this.date_expirary.Size = new System.Drawing.Size(190, 20);
            this.date_expirary.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 242;
            this.label12.Text = "Hạn Trả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbSheet);
            this.groupBox2.Controls.Add(this.btRefresh);
            this.groupBox2.Controls.Add(this.btExport);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.tbNoiDungTimKiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btImport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btTimFile);
            this.groupBox2.Controls.Add(this.tbFileName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 176);
            this.groupBox2.TabIndex = 265;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 425);
            this.groupBox3.TabIndex = 266;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(161, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 31);
            this.label11.TabIndex = 234;
            this.label11.Text = "Trả Sách";
            // 
            // givebackTableAdapter
            // 
            this.givebackTableAdapter.ClearBeforeFill = true;
            // 
            // tbIssue_id
            // 
            this.tbIssue_id.FormattingEnabled = true;
            this.tbIssue_id.Location = new System.Drawing.Point(87, 43);
            this.tbIssue_id.Name = "tbIssue_id";
            this.tbIssue_id.Size = new System.Drawing.Size(190, 21);
            this.tbIssue_id.TabIndex = 248;
            // 
            // tbBook_id
            // 
            this.tbBook_id.FormattingEnabled = true;
            this.tbBook_id.Location = new System.Drawing.Point(87, 120);
            this.tbBook_id.Name = "tbBook_id";
            this.tbBook_id.Size = new System.Drawing.Size(190, 21);
            this.tbBook_id.TabIndex = 249;
            // 
            // @return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 447);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataView);
            this.Name = "@return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.return_FormClosing);
            this.Load += new System.EventHandler(this.return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.givebackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btTimFile;
        private System.Windows.Forms.ComboBox cbbSheet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbNoiDungTimKiem;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbReturn_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbStaff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereturnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource givebackBindingSource;
        private QLThuVienDataSetTableAdapters.givebackTableAdapter givebackTableAdapter;
        private System.Windows.Forms.DateTimePicker date_expirary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateexpiraryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox tbBook_id;
        private System.Windows.Forms.ComboBox tbIssue_id;
    }
}