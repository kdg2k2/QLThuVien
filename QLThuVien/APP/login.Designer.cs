namespace QLThuVien.APP
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.tbuser_name = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbForgot_pass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // tbuser_name
            // 
            this.tbuser_name.Location = new System.Drawing.Point(214, 35);
            this.tbuser_name.Name = "tbuser_name";
            this.tbuser_name.Size = new System.Drawing.Size(200, 20);
            this.tbuser_name.TabIndex = 0;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(339, 118);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            this.btDangNhap.Enter += new System.EventHandler(this.btDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(214, 81);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = 'x';
            this.tbpassword.Size = new System.Drawing.Size(200, 20);
            this.tbpassword.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 134);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbForgot_pass
            // 
            this.lbForgot_pass.AutoSize = true;
            this.lbForgot_pass.Location = new System.Drawing.Point(214, 108);
            this.lbForgot_pass.Name = "lbForgot_pass";
            this.lbForgot_pass.Size = new System.Drawing.Size(80, 13);
            this.lbForgot_pass.TabIndex = 4;
            this.lbForgot_pass.TabStop = true;
            this.lbForgot_pass.Text = "Quên mật khẩu";
            this.lbForgot_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbForgot_pass_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 153);
            this.Controls.Add(this.lbForgot_pass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbuser_name);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Enter += new System.EventHandler(this.btDangNhap_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbuser_name;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbForgot_pass;
    }
}