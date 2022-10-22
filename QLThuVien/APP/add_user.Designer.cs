namespace QLThuVien.APP
{
    partial class add_user
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
            this.tbuser_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDangKi = new System.Windows.Forms.Button();
            this.tbstudent_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbretypePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbuser_name
            // 
            this.tbuser_name.Location = new System.Drawing.Point(112, 22);
            this.tbuser_name.Name = "tbuser_name";
            this.tbuser_name.Size = new System.Drawing.Size(154, 20);
            this.tbuser_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản";
            // 
            // btDangKi
            // 
            this.btDangKi.Location = new System.Drawing.Point(191, 126);
            this.btDangKi.Name = "btDangKi";
            this.btDangKi.Size = new System.Drawing.Size(75, 23);
            this.btDangKi.TabIndex = 4;
            this.btDangKi.Text = "Đăng Kí";
            this.btDangKi.UseVisualStyleBackColor = true;
            this.btDangKi.Click += new System.EventHandler(this.btDangKi_Click);
            // 
            // tbstudent_id
            // 
            this.tbstudent_id.Location = new System.Drawing.Point(112, 48);
            this.tbstudent_id.Name = "tbstudent_id";
            this.tbstudent_id.Size = new System.Drawing.Size(154, 20);
            this.tbstudent_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(112, 74);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = 'x';
            this.tbpassword.Size = new System.Drawing.Size(154, 20);
            this.tbpassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu";
            // 
            // tbretypePassword
            // 
            this.tbretypePassword.Location = new System.Drawing.Point(112, 100);
            this.tbretypePassword.Name = "tbretypePassword";
            this.tbretypePassword.PasswordChar = 'x';
            this.tbretypePassword.Size = new System.Drawing.Size(154, 20);
            this.tbretypePassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 154);
            this.Controls.Add(this.btDangKi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbretypePassword);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbstudent_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbuser_name);
            this.Name = "add_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbuser_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDangKi;
        private System.Windows.Forms.TextBox tbstudent_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbretypePassword;
        private System.Windows.Forms.Label label4;
    }
}