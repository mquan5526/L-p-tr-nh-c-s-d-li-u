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
using BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TransferObject;

namespace PresentationLayer
{
    public partial class Fees : Form
    {
        private FeeBL feeBL;
        public Fees()
        {
            InitializeComponent();
            feeBL = new FeeBL();
        }
        //SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LTCSDLold\DataLayer\StudentDb.mdf;Integrated Security=True");
        //private void DisplayFees()
        //{
        //    Conn.Open();
        //    String cmd = "Select* from FeesTable";
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd, Conn);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
        //    var ds = new DataSet();
        //    adapter.Fill(ds);
        //    dataGridView1.DataSource = ds.Tables[0];
        //    Conn.Close();
        //}

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            textBox3.Clear();
        }
        private void LoadFee()
        {
            try
            {
                dataGridView1.DataSource = feeBL.GetFees();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Fill all data");
            }
            else
            {
                int id, amount;
                string name, enno;
                DateTime date;
                id = int.Parse(textBox4.Text);
                name = textBox1.Text;
                amount = int.Parse(textBox3.Text);
                date = dateTimePicker1.Value;
                enno = textBox2.Text;

                Fee fee = new Fee(id, name, enno, date, amount);

                try
                {
                    int numOfRows = feeBL.Add(fee);
                    MessageBox.Show("Cap nhat hoc phi thanh cong!", "Fee");
                    if (numOfRows > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Clear();
                }
            }
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            LoadFee();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadFee();
        }
    }
}
