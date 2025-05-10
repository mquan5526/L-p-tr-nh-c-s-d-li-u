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
using DataLayer;
using TransferObject;
using BusinessLayer;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class StudentsForm : Form
    {
        private StudentBL studentBL;
        public StudentsForm()
        {
            InitializeComponent();
            studentBL = new StudentBL();
        }

        private void LoadStudent()
        {
            try
            {
                dgvStudent.DataSource = studentBL.GetStudents();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtName.Text == "" || cbClass.Text == "" || txtAge.Text == "" || cbGender.Text == "" || txtenNO.Text == "")
            {
                MessageBox.Show("Fill all the Detail");
            }
            else
            {
                int id;
                string name, age, @class, enNO, gender;
                id = int.Parse(txtID.Text);
                name = txtName.Text;
                age = txtAge.Text;
                @class = cbClass.SelectedItem.ToString();
                enNO = txtenNO.Text;
                gender = cbGender.SelectedItem.ToString();

                Student student = new Student(id, name, age, @class, enNO, gender);

                try
                {
                    int numOfRows = studentBL.Add(student);
                    MessageBox.Show("So sinh vien da them: " + numOfRows.ToString(), "Student");
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
        //Clear text
        private void Clear()
        {
            txtName.Clear();
            txtAge.Clear();
            cbClass.ResetText();
            txtenNO.Clear();
            cbGender.ResetText();
            txtID.Clear();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string @class = cbClass.SelectedItem.ToString();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gender = cbGender.SelectedItem.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtName.Text == "" || cbClass.Text == "" || txtAge.Text == "" || cbGender.Text == "" || txtenNO.Text == "")
            {
                MessageBox.Show("Fill all the Detail");
            }
            else
            {
                int id;
                string name, age, nclass, enno, gender;
                id = int.Parse(txtID.Text);
                name = txtName.Text;
                age = txtAge.Text;
                nclass = cbClass.SelectedItem.ToString();
                enno = txtenNO.Text;
                gender = cbGender.SelectedItem.ToString();

                Student student = new Student(id, name, age, nclass, enno, gender);

                try
                {
                    int numOfRows = studentBL.Update(student);
                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Cap nhat thanh cong!", "Student");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Khong ton tai sinh vien de cap nhat!", "Student");
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
        private void button3_Click(object sender, EventArgs e)
        {
            FormDeleteStudent fds = new FormDeleteStudent();
            DialogResult result = fds.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadStudent();
            }
        }
    }
}
