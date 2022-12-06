namespace QLThuVien.APP
{
    partial class books
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
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbMaSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet = new QLThuVien.QLThuVienDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenTacGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.booksTableAdapter = new QLThuVien.QLThuVienDataSetTableAdapters.booksTableAdapter();
            this.tbMaLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(290, 155);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 173;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(166, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 13);
            this.label20.TabIndex = 172;
            this.label20.Text = "Xuất dữ liệu ra file Excel";
            // 
            // btRefresh
            // 
            this.btRefresh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btRefresh.Location = new System.Drawing.Point(644, 257);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(163, 159);
            this.btRefresh.TabIndex = 171;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 170;
            this.label2.Text = "Thêm dữ liệu bằng file Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 169;
            this.label1.Text = "Nội dung tìm:";
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(371, 115);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(75, 23);
            this.btImport.TabIndex = 168;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btTimFile
            // 
            this.btTimFile.Location = new System.Drawing.Point(452, 91);
            this.btTimFile.Name = "btTimFile";
            this.btTimFile.Size = new System.Drawing.Size(37, 23);
            this.btTimFile.TabIndex = 167;
            this.btTimFile.Text = "...";
            this.btTimFile.UseVisualStyleBackColor = true;
            this.btTimFile.Click += new System.EventHandler(this.btTimFile_Click);
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(226, 117);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(121, 21);
            this.cbbSheet.TabIndex = 166;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 165;
            this.label3.Text = "Sheet";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(226, 91);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(220, 20);
            this.tbFileName.TabIndex = 164;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 163;
            this.label4.Text = "File Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 162;
            this.label6.Text = "Tìm Kiếm";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(372, 37);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(115, 20);
            this.btTimKiem.TabIndex = 160;
            this.btTimKiem.Text = "Search";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(27, 128);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(103, 37);
            this.btDelete.TabIndex = 159;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbNoiDungTimKiem
            // 
            this.tbNoiDungTimKiem.Location = new System.Drawing.Point(241, 37);
            this.tbNoiDungTimKiem.Name = "tbNoiDungTimKiem";
            this.tbNoiDungTimKiem.Size = new System.Drawing.Size(124, 20);
            this.tbNoiDungTimKiem.TabIndex = 161;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(27, 79);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(103, 37);
            this.btUpdate.TabIndex = 158;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 156;
            this.label7.Text = "Mã Loại";
            // 
            // tbTenSach
            // 
            this.tbTenSach.Location = new System.Drawing.Point(97, 62);
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(124, 20);
            this.tbTenSach.TabIndex = 1;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(27, 27);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(103, 37);
            this.btInsert.TabIndex = 153;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbMaSach
            // 
            this.tbMaSach.Location = new System.Drawing.Point(97, 36);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.Size = new System.Drawing.Size(124, 20);
            this.tbMaSach.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 151;
            this.label10.Text = "Mã Sách";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.quantity,
            this.dataGridViewTextBoxColumn9});
            this.dataView.DataSource = this.booksBindingSource;
            this.dataView.Location = new System.Drawing.Point(12, 257);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(626, 159);
            this.dataView.TabIndex = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "book_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "book_id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "book_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "book_name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "type_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "type_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "author_name";
            this.dataGridViewTextBoxColumn9.HeaderText = "author_name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 154;
            this.label9.Text = "Tên Sách";
            // 
            // tbquantity
            // 
            this.tbquantity.Location = new System.Drawing.Point(97, 114);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(124, 20);
            this.tbquantity.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 156;
            this.label5.Text = "Số lượng";
            // 
            // tbTenTacGia
            // 
            this.tbTenTacGia.Location = new System.Drawing.Point(97, 140);
            this.tbTenTacGia.Name = "tbTenTacGia";
            this.tbTenTacGia.Size = new System.Drawing.Size(124, 20);
            this.tbTenTacGia.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 156;
            this.label8.Text = "Tên Tác Giả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 239);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btExport);
            this.groupBox3.Controls.Add(this.btInsert);
            this.groupBox3.Controls.Add(this.btUpdate);
            this.groupBox3.Controls.Add(this.btDelete);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.tbFileName);
            this.groupBox3.Controls.Add(this.cbbSheet);
            this.groupBox3.Controls.Add(this.btTimKiem);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btTimFile);
            this.groupBox3.Controls.Add(this.tbNoiDungTimKiem);
            this.groupBox3.Controls.Add(this.btImport);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(279, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 188);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMaLoai);
            this.groupBox2.Controls.Add(this.tbquantity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbTenSach);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbMaSach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbTenTacGia);
            this.groupBox2.Location = new System.Drawing.Point(15, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(300, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 31);
            this.label11.TabIndex = 151;
            this.label11.Text = "Quản Lý Sách";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tbMaLoai
            // 
            this.tbMaLoai.FormattingEnabled = true;
            this.tbMaLoai.Location = new System.Drawing.Point(97, 88);
            this.tbMaLoai.Name = "tbMaLoai";
            this.tbMaLoai.Size = new System.Drawing.Size(124, 21);
            this.tbMaLoai.TabIndex = 174;
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btRefresh);
            this.Name = "books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.books_FormClosing);
            this.Load += new System.EventHandler(this.books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbMaSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTenTacGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private QLThuVienDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox tbMaLoai;
    }
}