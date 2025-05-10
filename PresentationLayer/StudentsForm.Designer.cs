namespace PresentationLayer
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            txtName = new TextBox();
            txtAge = new TextBox();
            txtenNO = new TextBox();
            cbClass = new ComboBox();
            cbGender = new ComboBox();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            dgvStudent = new DataGridView();
            label6 = new Label();
            txtID = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(441, 160);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 30);
            txtName.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(719, 160);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(131, 30);
            txtAge.TabIndex = 7;
            // 
            // txtenNO
            // 
            txtenNO.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtenNO.Location = new Point(441, 303);
            txtenNO.Name = "txtenNO";
            txtenNO.Size = new Size(189, 30);
            txtenNO.TabIndex = 8;
            // 
            // cbClass
            // 
            cbClass.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbClass.FormattingEnabled = true;
            cbClass.Items.AddRange(new object[] { "IT01", "IT02", "CS01", "CS02", "IM01", "IM02" });
            cbClass.Location = new Point(204, 303);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(121, 31);
            cbClass.TabIndex = 9;
            cbClass.SelectedIndexChanged += cbClass_SelectedIndexChanged;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(719, 302);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(143, 31);
            cbGender.TabIndex = 10;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(988, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1055, 60);
            panel4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(441, 6);
            label8.Name = "label8";
            label8.Size = new Size(127, 36);
            label8.TabIndex = 7;
            label8.Text = "Sinh viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(713, 263);
            label5.Name = "label5";
            label5.Size = new Size(100, 29);
            label5.TabIndex = 27;
            label5.Text = "Giới tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(206, 268);
            label1.Name = "label1";
            label1.Size = new Size(51, 29);
            label1.TabIndex = 25;
            label1.Text = "Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(436, 261);
            label3.Name = "label3";
            label3.Size = new Size(70, 29);
            label3.TabIndex = 26;
            label3.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(436, 121);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 24;
            label2.Text = "Họ và tên ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(714, 125);
            label4.Name = "label4";
            label4.Size = new Size(56, 29);
            label4.TabIndex = 28;
            label4.Text = "Tuổi";
            // 
            // button4
            // 
            button4.BackColor = Color.SkyBlue;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(667, 378);
            button4.Name = "button4";
            button4.Size = new Size(108, 85);
            button4.TabIndex = 32;
            button4.Text = "Quay về";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(537, 378);
            button3.Name = "button3";
            button3.Size = new Size(109, 85);
            button3.TabIndex = 31;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(407, 378);
            button2.Name = "button2";
            button2.Size = new Size(112, 85);
            button2.TabIndex = 30;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(284, 378);
            button1.Name = "button1";
            button1.Size = new Size(100, 85);
            button1.TabIndex = 29;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(422, 549);
            label7.Name = "label7";
            label7.Size = new Size(210, 29);
            label7.TabIndex = 34;
            label7.Text = "Danh sách sinh viên";
            // 
            // dgvStudent
            // 
            dgvStudent.BackgroundColor = SystemColors.ActiveCaption;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(129, 597);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 24;
            dgvStudent.Size = new Size(802, 260);
            dgvStudent.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(212, 125);
            label6.Name = "label6";
            label6.Size = new Size(34, 29);
            label6.TabIndex = 35;
            label6.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(204, 160);
            txtID.Name = "txtID";
            txtID.Size = new Size(189, 30);
            txtID.TabIndex = 36;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Refresh_icon;
            pictureBox2.Location = new Point(960, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 892);
            Controls.Add(pictureBox2);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(dgvStudent);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbGender);
            Controls.Add(cbClass);
            Controls.Add(txtenNO);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += StudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtenNO;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvStudent;
        private Label label6;
        private TextBox txtID;
        private PictureBox pictureBox2;
    }
}

