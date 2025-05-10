namespace PresentationLayer
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            panel2 = new Panel();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            txtPass = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            txtUsername = new TextBox();
            label9 = new Label();
            txtCpass = new TextBox();
            button2 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 60);
            panel2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(275, 9);
            label6.Name = "label6";
            label6.Size = new Size(414, 36);
            label6.TabIndex = 18;
            label6.Text = "Hệ thống quản lý trường đại học";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(893, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(479, 405);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(196, 36);
            txtPass.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(264, 405);
            label4.Name = "label4";
            label4.Size = new Size(109, 29);
            label4.TabIndex = 21;
            label4.Text = "Mật khẩu";
            // 
            // txtName
            // 
            txtName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(479, 217);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 36);
            txtName.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(264, 217);
            label3.Name = "label3";
            label3.Size = new Size(107, 29);
            label3.TabIndex = 19;
            label3.Text = "Họ và tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(359, 112);
            label1.Name = "label1";
            label1.Size = new Size(234, 36);
            label1.TabIndex = 18;
            label1.Text = "Đăng ký tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(429, 635);
            label2.Name = "label2";
            label2.Size = new Size(260, 29);
            label2.TabIndex = 26;
            label2.Text = "Bạn đã có sẵn tài khoản?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(264, 311);
            label8.Name = "label8";
            label8.Size = new Size(120, 29);
            label8.TabIndex = 28;
            label8.Text = "UserName";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(479, 311);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 36);
            txtUsername.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(264, 498);
            label9.Name = "label9";
            label9.Size = new Size(204, 29);
            label9.TabIndex = 30;
            label9.Text = "Xác nhận mật khẩu";
            // 
            // txtCpass
            // 
            txtCpass.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCpass.Location = new Point(479, 494);
            txtCpass.Name = "txtCpass";
            txtCpass.PasswordChar = '*';
            txtCpass.Size = new Size(196, 36);
            txtCpass.TabIndex = 31;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(519, 557);
            button2.Name = "button2";
            button2.Size = new Size(121, 65);
            button2.TabIndex = 32;
            button2.Text = "Đăng ký";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 163);
            button1.Location = new Point(709, 620);
            button1.Name = "button1";
            button1.Size = new Size(142, 56);
            button1.TabIndex = 33;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 843);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(txtCpass);
            Controls.Add(label9);
            Controls.Add(txtUsername);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private Button button1;
    }
}