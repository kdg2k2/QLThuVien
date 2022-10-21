namespace QLThuVien.APP
{
    partial class staff
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
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbStaff_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet = new QLThuVien.QLThuVienDataSet();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbDesignation_id = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.staffTableAdapter = new QLThuVien.QLThuVienDataSetTableAdapters.staffTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(254, 141);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 201;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(130, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 13);
            this.label20.TabIndex = 200;
            this.label20.Text = "Xuất dữ liệu ra file Excel";
            // 
            // btRefresh
            // 
            this.btRefresh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btRefresh.Location = new System.Drawing.Point(653, 244);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 43);
            this.btRefresh.TabIndex = 199;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 198;
            this.label2.Text = "Thêm dữ liệu bằng file Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 197;
            this.label1.Text = "Nội dung tìm:";
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(334, 112);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(75, 23);
            this.btImport.TabIndex = 196;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btTimFile
            // 
            this.btTimFile.Location = new System.Drawing.Point(416, 97);
            this.btTimFile.Name = "btTimFile";
            this.btTimFile.Size = new System.Drawing.Size(37, 23);
            this.btTimFile.TabIndex = 195;
            this.btTimFile.Text = "...";
            this.btTimFile.UseVisualStyleBackColor = true;
            this.btTimFile.Click += new System.EventHandler(this.btTimFile_Click);
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(189, 114);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(121, 21);
            this.cbbSheet.TabIndex = 194;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 193;
            this.label3.Text = "Sheet";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(189, 88);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(220, 20);
            this.tbFileName.TabIndex = 192;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 191;
            this.label4.Text = "File Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 190;
            this.label6.Text = "Tìm Kiếm ( theo mã )";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(336, 28);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(115, 20);
            this.btTimKiem.TabIndex = 188;
            this.btTimKiem.Text = "Search";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(8, 114);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(103, 37);
            this.btDelete.TabIndex = 187;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbNoiDungTimKiem
            // 
            this.tbNoiDungTimKiem.Location = new System.Drawing.Point(205, 28);
            this.tbNoiDungTimKiem.Name = "tbNoiDungTimKiem";
            this.tbNoiDungTimKiem.Size = new System.Drawing.Size(124, 20);
            this.tbNoiDungTimKiem.TabIndex = 189;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(8, 65);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(103, 37);
            this.btUpdate.TabIndex = 186;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 180;
            this.label8.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 182;
            this.label5.Text = "Mã Chức Vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 181;
            this.label7.Text = "Giới Tính";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(87, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(124, 20);
            this.tbName.TabIndex = 179;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(8, 13);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(103, 37);
            this.btInsert.TabIndex = 177;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbStaff_id
            // 
            this.tbStaff_id.Location = new System.Drawing.Point(87, 13);
            this.tbStaff_id.Name = "tbStaff_id";
            this.tbStaff_id.Size = new System.Drawing.Size(124, 20);
            this.tbStaff_id.TabIndex = 176;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(192, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 31);
            this.label10.TabIndex = 175;
            this.label10.Text = "Quản Lý Nhân Viên Thư Viện";
            // 
            // dataView
            // 
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataView.DataSource = this.staffBindingSource;
            this.dataView.Location = new System.Drawing.Point(12, 244);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(728, 213);
            this.dataView.TabIndex = 174;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "staff_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "staff_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn3.HeaderText = "gender";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "designation_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "designation_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn5.HeaderText = "address";
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
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(87, 117);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(124, 20);
            this.tbAddress.TabIndex = 184;
            // 
            // tbDesignation_id
            // 
            this.tbDesignation_id.Location = new System.Drawing.Point(87, 91);
            this.tbDesignation_id.Name = "tbDesignation_id";
            this.tbDesignation_id.Size = new System.Drawing.Size(124, 20);
            this.tbDesignation_id.TabIndex = 183;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(87, 65);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(124, 20);
            this.tbGender.TabIndex = 185;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 178;
            this.label9.Text = "Tên Nhân Viên";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(87, 143);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(124, 20);
            this.tbPhone.TabIndex = 184;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 180;
            this.label11.Text = "SDT";
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbGender);
            this.groupBox1.Controls.Add(this.tbDesignation_id);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbStaff_id);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(11, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 170);
            this.groupBox1.TabIndex = 202;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExport);
            this.groupBox2.Controls.Add(this.btInsert);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.tbNoiDungTimKiem);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btImport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btTimFile);
            this.groupBox2.Controls.Add(this.tbFileName);
            this.groupBox2.Controls.Add(this.cbbSheet);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(246, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 170);
            this.groupBox2.TabIndex = 203;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 226);
            this.groupBox3.TabIndex = 204;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.dataView);
            this.Name = "staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.staff_FormClosing);
            this.Load += new System.EventHandler(this.staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbStaff_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbDesignation_id;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label11;
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private QLThuVienDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}