﻿namespace QLThuVien
{
    partial class serviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceForm));
            this.label8 = new System.Windows.Forms.Label();
            this.picBorrow = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBooks = new System.Windows.Forms.PictureBox();
            this.picGiveback = new System.Windows.Forms.PictureBox();
            this.picType = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PicStudent = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mượn";
            // 
            // picBorrow
            // 
            this.picBorrow.Image = ((System.Drawing.Image)(resources.GetObject("picBorrow.Image")));
            this.picBorrow.Location = new System.Drawing.Point(79, 59);
            this.picBorrow.Name = "picBorrow";
            this.picBorrow.Size = new System.Drawing.Size(65, 62);
            this.picBorrow.TabIndex = 6;
            this.picBorrow.TabStop = false;
            this.picBorrow.Click += new System.EventHandler(this.picBorrow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loại Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sách";
            // 
            // picBooks
            // 
            this.picBooks.Image = ((System.Drawing.Image)(resources.GetObject("picBooks.Image")));
            this.picBooks.Location = new System.Drawing.Point(10, 154);
            this.picBooks.Name = "picBooks";
            this.picBooks.Size = new System.Drawing.Size(65, 62);
            this.picBooks.TabIndex = 8;
            this.picBooks.TabStop = false;
            this.picBooks.Click += new System.EventHandler(this.picBooks_Click);
            // 
            // picGiveback
            // 
            this.picGiveback.Image = ((System.Drawing.Image)(resources.GetObject("picGiveback.Image")));
            this.picGiveback.Location = new System.Drawing.Point(200, 59);
            this.picGiveback.Name = "picGiveback";
            this.picGiveback.Size = new System.Drawing.Size(65, 62);
            this.picGiveback.TabIndex = 9;
            this.picGiveback.TabStop = false;
            this.picGiveback.Click += new System.EventHandler(this.picGiveback_Click);
            // 
            // picType
            // 
            this.picType.Image = ((System.Drawing.Image)(resources.GetObject("picType.Image")));
            this.picType.Location = new System.Drawing.Point(140, 154);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(65, 62);
            this.picType.TabIndex = 10;
            this.picType.TabStop = false;
            this.picType.Click += new System.EventHandler(this.picType_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sinh Viên";
            // 
            // PicStudent
            // 
            this.PicStudent.Image = ((System.Drawing.Image)(resources.GetObject("PicStudent.Image")));
            this.PicStudent.Location = new System.Drawing.Point(267, 154);
            this.PicStudent.Name = "PicStudent";
            this.PicStudent.Size = new System.Drawing.Size(65, 62);
            this.PicStudent.TabIndex = 14;
            this.PicStudent.TabStop = false;
            this.PicStudent.Click += new System.EventHandler(this.PicStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mượn Trả Sách";
            // 
            // serviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicStudent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBooks);
            this.Controls.Add(this.picGiveback);
            this.Controls.Add(this.picType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picBorrow);
            this.Name = "serviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serviceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.serviceForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picBorrow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBooks;
        private System.Windows.Forms.PictureBox picGiveback;
        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PicStudent;
        private System.Windows.Forms.Label label1;
    }
}