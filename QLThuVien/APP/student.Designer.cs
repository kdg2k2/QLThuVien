namespace QLThuVien.APP
{
    partial class student
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
            this.btDelete = new System.Windows.Forms.Button();
            this.tbNoiDungTimKiem = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTenSV = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet = new QLThuVien.QLThuVienDataSet();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new QLThuVien.QLThuVienDataSetTableAdapters.studentTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(129, 211);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 149;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 216);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 13);
            this.label20.TabIndex = 148;
            this.label20.Text = "Xuất dữ liệu ra file Excel";
            // 
            // btRefresh
            // 
            this.btRefresh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btRefresh.Location = new System.Drawing.Point(254, 91);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(92, 67);
            this.btRefresh.TabIndex = 147;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "Thêm dữ liệu bằng file Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 145;
            this.label1.Text = "Nội dung tìm:";
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(210, 171);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(75, 23);
            this.btImport.TabIndex = 144;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btTimFile
            // 
            this.btTimFile.Location = new System.Drawing.Point(291, 157);
            this.btTimFile.Name = "btTimFile";
            this.btTimFile.Size = new System.Drawing.Size(37, 23);
            this.btTimFile.TabIndex = 143;
            this.btTimFile.Text = "...";
            this.btTimFile.UseVisualStyleBackColor = true;
            this.btTimFile.Click += new System.EventHandler(this.btTimFile_Click);
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(65, 173);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(121, 21);
            this.cbbSheet.TabIndex = 142;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.sbbSheet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "Sheet";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(65, 147);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(220, 20);
            this.tbFileName.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 139;
            this.label4.Text = "File Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 138;
            this.label6.Text = "Tìm Kiếm ( theo mã )";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(211, 88);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(115, 20);
            this.btTimKiem.TabIndex = 136;
            this.btTimKiem.Text = "Search";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(224, 19);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(103, 37);
            this.btDelete.TabIndex = 135;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbNoiDungTimKiem
            // 
            this.tbNoiDungTimKiem.Location = new System.Drawing.Point(80, 88);
            this.tbNoiDungTimKiem.Name = "tbNoiDungTimKiem";
            this.tbNoiDungTimKiem.Size = new System.Drawing.Size(124, 20);
            this.tbNoiDungTimKiem.TabIndex = 137;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(115, 19);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(103, 37);
            this.btUpdate.TabIndex = 134;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 132;
            this.label7.Text = "Số ĐT";
            // 
            // tbTenSV
            // 
            this.tbTenSV.Location = new System.Drawing.Point(84, 54);
            this.tbTenSV.Name = "tbTenSV";
            this.tbTenSV.Size = new System.Drawing.Size(124, 20);
            this.tbTenSV.TabIndex = 129;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(6, 19);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(103, 37);
            this.btInsert.TabIndex = 127;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(84, 10);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(124, 20);
            this.tbMaSV.TabIndex = 126;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 125;
            this.label10.Text = "Mã Sinh Viên";
            // 
            // dataView
            // 
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataView.DataSource = this.studentBindingSource;
            this.dataView.Location = new System.Drawing.Point(369, 26);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(347, 412);
            this.dataView.TabIndex = 124;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "student_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "student_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "studentname";
            this.dataGridViewTextBoxColumn5.HeaderText = "studentname";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(84, 92);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(124, 20);
            this.tbSDT.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 128;
            this.label9.Text = "Tên Sinh Viên";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaSV);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbTenSV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 119);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btInsert);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btExport);
            this.groupBox2.Controls.Add(this.tbNoiDungTimKiem);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btImport);
            this.groupBox2.Controls.Add(this.tbFileName);
            this.groupBox2.Controls.Add(this.btTimFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbSheet);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 240);
            this.groupBox2.TabIndex = 151;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 29);
            this.label5.TabIndex = 125;
            this.label5.Text = "Quản Lý Sinh Viên Mượn Sách";
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataView);
            this.Name = "student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "students";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.students_FormClosing);
            this.Load += new System.EventHandler(this.students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbNoiDungTimKiem;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTenSV;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private QLThuVienDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}