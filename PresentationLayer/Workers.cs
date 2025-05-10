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
using TransferObject;
using System.Xml.Linq;
using DataLayer;

namespace PresentationLayer
{
    public partial class Workers : Form
    {
        private WorkerBL workerBL;
        public Workers()
        {
            InitializeComponent();
            workerBL = new WorkerBL();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Hide();
        }
        private void WorkerLoad()
        {
            try
            {
                dataGridView1.DataSource = workerBL.GetWorkers();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.ResetText();
        }
        private void Workers_Load(object sender, EventArgs e)
        {
            WorkerLoad();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Fill all the Detail");
            }
            else
            {
                int id, age;
                string name, position, gender, address;
                id = int.Parse(textBox3.Text);
                name = textBox1.Text;
                age = int.Parse(textBox2.Text);
                position = textBox5.Text;
                gender = comboBox2.SelectedItem.ToString();
                address = textBox4.Text;

                Worker worker = new Worker(id, name, age, position, gender, address);

                try
                {
                    int numOfRows = workerBL.Add(worker);
                    MessageBox.Show("So nhan vien da them: " + numOfRows.ToString(), "Worker");
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
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WorkerLoad();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormDeleteWorker fdw = new FormDeleteWorker();
            DialogResult result = fdw.ShowDialog();
            if (result == DialogResult.OK)
            {
                WorkerLoad();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Fill all the Detail");
            }
            else
            {
                int id, age;
                string name, position, gender, address;
                id = int.Parse(textBox3.Text);
                name = textBox1.Text;
                age = int.Parse(textBox2.Text);
                address = textBox4.Text;
                gender = comboBox2.SelectedItem.ToString();
                position = textBox5.Text;

                Worker worker = new Worker(id, name, age, position, gender, address);

                try
                {
                    int numOfRows = workerBL.Update(worker);
                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Cap nhat thanh cong!", "Worker");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Khong ton tai nhan vien de cap nhat!", "Worker");
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
    }
}
