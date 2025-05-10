namespace PresentationLayer
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button4 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(32, 151);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(364, 151);
            label3.Name = "label3";
            label3.Size = new Size(70, 29);
            label3.TabIndex = 2;
            label3.Text = "MSSV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 281);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(649, 151);
            label5.Name = "label5";
            label5.Size = new Size(106, 29);
            label5.TabIndex = 4;
            label5.Text = "Thời gian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(364, 273);
            label6.Name = "label6";
            label6.Size = new Size(112, 29);
            label6.TabIndex = 5;
            label6.Text = "Trạng thái";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(37, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 36);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(369, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 36);
            textBox2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(654, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(395, 36);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Present", "Absent" });
            comboBox1.Location = new Point(521, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 37);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Present";
            // 
            // button4
            // 
            button4.BackColor = Color.SkyBlue;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(564, 374);
            button4.Name = "button4";
            button4.Size = new Size(108, 85);
            button4.TabIndex = 19;
            button4.Text = "Quay về";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(376, 374);
            button1.Name = "button1";
            button1.Size = new Size(100, 85);
            button1.TabIndex = 16;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(254, 530);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(547, 260);
            dataGridView1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(420, 483);
            label7.Name = "label7";
            label7.Size = new Size(229, 29);
            label7.TabIndex = 21;
            label7.Text = "Danh sách điểm danh";
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
            panel4.Size = new Size(1053, 60);
            panel4.TabIndex = 22;
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
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(955, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(443, 12);
            label8.Name = "label8";
            label8.Size = new Size(149, 36);
            label8.TabIndex = 7;
            label8.Text = "Điểm danh";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Refresh_icon;
            pictureBox2.Location = new Point(950, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 814);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance";
            Load += AttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private PictureBox pictureBox2;
    }
}