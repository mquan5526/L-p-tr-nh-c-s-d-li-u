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

namespace PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        private RegistrationBL registrationBL;
        public RegistrationForm()
        {
            InitializeComponent();
            registrationBL = new RegistrationBL();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, user, password, cpassword;
            name = txtName.Text;
            user = txtUsername.Text;
            password = txtPass.Text;
            cpassword = txtCpass.Text;

            Registration registration = new Registration(name, user, password, cpassword);

            try
            {
                int numOfRows = registrationBL.Add(registration);
                MessageBox.Show("Đăng ký thành công!", "Đăng ký");
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
}
