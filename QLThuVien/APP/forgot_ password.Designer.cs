namespace QLThuVien.APP
{
    partial class forgot__password
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser_name = new System.Windows.Forms.TextBox();
            this.tbChangePass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản";
            // 
            // tbUser_name
            // 
            this.tbUser_name.Location = new System.Drawing.Point(117, 25);
            this.tbUser_name.Name = "tbUser_name";
            this.tbUser_name.Size = new System.Drawing.Size(157, 20);
            this.tbUser_name.TabIndex = 0;
            // 
            // tbChangePass
            // 
            this.tbChangePass.Location = new System.Drawing.Point(188, 129);
            this.tbChangePass.Name = "tbChangePass";
            this.tbChangePass.Size = new System.Drawing.Size(86, 23);
            this.tbChangePass.TabIndex = 4;
            this.tbChangePass.Text = "Đổi mật khẩu";
            this.tbChangePass.UseVisualStyleBackColor = true;
            this.tbChangePass.Click += new System.EventHandler(this.tbChangePass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(117, 51);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(157, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(117, 77);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = 'x';
            this.tbPassword.Size = new System.Drawing.Size(157, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // tbRePassword
            // 
            this.tbRePassword.Location = new System.Drawing.Point(117, 103);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.PasswordChar = 'x';
            this.tbRePassword.Size = new System.Drawing.Size(157, 20);
            this.tbRePassword.TabIndex = 3;
            // 
            // forgot__password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 160);
            this.Controls.Add(this.tbChangePass);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUser_name);
            this.Controls.Add(this.label1);
            this.Name = "forgot__password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.forgot__password_FormClosing);
            this.Load += new System.EventHandler(this.forgot__password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser_name;
        private System.Windows.Forms.Button tbChangePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRePassword;
    }
}