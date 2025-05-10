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
using TransferObject;
using BusinessLayer;
using DataLayer;
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class Teachers : Form
    {
        private TeacherBL teacherBL;
        public Teachers()
        {
            InitializeComponent();
            teacherBL = new TeacherBL(); ;
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Hide();
        }
        private void TeacherLoad()
        {
            try
            {
                dataGridView1.DataSource = teacherBL.GetTeachers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Teachers_Load(object sender, EventArgs e)
        {
            TeacherLoad();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox2.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Fill all the Detail");
            }
            else
            {
                int id, age;
                string name, subject, gender, address;
                id = int.Parse(textBox3.Text);
                name = textBox1.Text;
                age = int.Parse(textBox2.Text);
                subject = textBox5.Text;
                gender = comboBox2.SelectedItem.ToString();
                address = textBox4.Text;

                Teacher teacher = new Teacher(id, name, age, subject, gender, address);

                try
                {
                    int numOfRows = teacherBL.Add(teacher);
                    MessageBox.Show("So giang vien da them: " + numOfRows.ToString(), "Teacher");
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gender = comboBox2.SelectedItem.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TeacherLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDeleteTeacher fdt = new FormDeleteTeacher();
            DialogResult result = fdt.ShowDialog();
            if (result == DialogResult.OK)
            {
                TeacherLoad();
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
                string name, subject, gender, address;
                id = int.Parse(textBox3.Text);
                name = textBox1.Text;
                age = int.Parse(textBox2.Text);
                address = textBox4.Text;
                gender = comboBox2.SelectedItem.ToString();
                subject = textBox5.Text;

                Teacher teacher = new Teacher(id, name, age, subject, gender, address);

                try
                {
                    int numOfRows = teacherBL.Update(teacher);
                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Cap nhat thanh cong!", "Teacher");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Khong ton tai giang vien de cap nhat!", "Teacher");
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
