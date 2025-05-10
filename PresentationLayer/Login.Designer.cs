namespace PresentationLayer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label3 = new Label();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label8 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(282, 192);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 7;
            label3.Text = "UserName";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(428, 192);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(177, 36);
            txtUsername.TabIndex = 9;
            txtUsername.Text = "tht";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(428, 277);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(177, 36);
            txtPass.TabIndex = 11;
            txtPass.Text = "227";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(291, 275);
            label4.Name = "label4";
            label4.Size = new Size(111, 29);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 60);
            panel2.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(631, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(156, 6);
            label6.Name = "label6";
            label6.Size = new Size(414, 36);
            label6.TabIndex = 7;
            label6.Text = "Hệ thống quản lý trường đại học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(156, 471);
            label2.Name = "label2";
            label2.Size = new Size(317, 29);
            label2.TabIndex = 15;
            label2.Text = "Bạn chưa được cấp tài khoản?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(549, 331);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(335, 102);
            label8.Name = "label8";
            label8.Size = new Size(147, 36);
            label8.TabIndex = 18;
            label8.Text = "Đăng nhập";
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(428, 363);
            button2.Name = "button2";
            button2.Size = new Size(156, 65);
            button2.TabIndex = 19;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 163);
            button1.Location = new Point(479, 461);
            button1.Name = "button1";
            button1.Size = new Size(178, 47);
            button1.TabIndex = 20;
            button1.Text = "Đăng ký ngay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 606);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private Button button1;
    }
}