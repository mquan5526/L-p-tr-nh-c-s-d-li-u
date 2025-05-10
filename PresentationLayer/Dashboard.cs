using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LTCSDLold\DataLayer\StudentDb.mdf;Integrated Security=True");
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CountStudent()
        {
            Conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from StTable",Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StNum.Text= dt.Rows[0][0].ToString();
            Conn.Close();
        }
        private void CountTeacher()
        {
            Conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from TeacherTable", Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NmT.Text = dt.Rows[0][0].ToString();
            Conn.Close();
        }
        private void CountWorker()
        {
            Conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from WorkerTable", Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NWk.Text = dt.Rows[0][0].ToString();
            Conn.Close();
        }
        private void SumFee()
        {
            Conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(Amount) from FeesTable", Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            fee.Text = dt.Rows[0][0].ToString();
            Conn.Close();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudent();
            CountTeacher();
            CountWorker();
            SumFee();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Hide();
        }
    }
}
