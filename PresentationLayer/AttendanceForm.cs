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
using System.Xml.Linq;
using TransferObject;
using DataLayer;

namespace PresentationLayer
{
    public partial class AttendanceForm : Form
    {
        private AttendanceBL attendanceBL;
        public AttendanceForm()
        {
            InitializeComponent();
            attendanceBL = new AttendanceBL();
        }
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            comboBox1.ResetText();
        }
        private void LoadAttendance()
        {
            try
            {
                dataGridView1.DataSource = attendanceBL.GetAttendances();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Fill all data");
            }
            else
            {
                int id;
                string name, status;
                DateTime date;
                id = int.Parse(textBox2.Text);
                name = textBox1.Text;
                status = comboBox1.SelectedItem.ToString();
                date = dateTimePicker1.Value;

                Attendance attendance = new Attendance(id, name, date, status);

                try
                {
                    int numOfRows = attendanceBL.Add(attendance);
                    MessageBox.Show("Diem danh thanh cong!", "Attendance");
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Hide();
        }
    }
}
