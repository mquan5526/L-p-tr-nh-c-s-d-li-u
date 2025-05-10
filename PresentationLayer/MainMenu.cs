using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AttendanceForm att = new AttendanceForm();
            att.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Fees fees = new Fees();
            fees.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Teachers tt = new Teachers();
            tt.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            StudentsForm login = new StudentsForm();
            login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AttendanceForm login = new AttendanceForm();
            login.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Fees login = new Fees();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Teachers login = new Teachers();
            login.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Dashboard login = new Dashboard();
            login.Show();
            this.Hide();
        }

        private void pSinhvien_Click(object sender, EventArgs e)
        {
            ShowForm(new StudentsForm());
        }
        private void ShowForm(Form form)
        {
            form.Show();
        }
    }
}
