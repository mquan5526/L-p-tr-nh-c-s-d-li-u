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
namespace PresentationLayer
{
    public partial class Login : Form
    {
        private LoginBL loginBL;
        public Login()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }
        private void Clear()
        {
            txtUsername.Clear();
            txtPass.Clear();
        }
        //Call Clear funcation
        private void label5_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Exit to this application
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //Show password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUsername.Text.Trim();
            pass = txtPass.Text;

            Account account = new Account(user, pass);

            LoginBL login = new LoginBL();

            if (login.Login(account))
            {
                MainMenu mm = new MainMenu();
                mm.Show();
                this.Hide();
            }
            else
            {
                string msg = "Username/Password are incorrect!";
                DialogResult result = MessageBox.Show(msg, "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {
                    txtUsername.Clear();
                    txtPass.Clear();
                    txtUsername.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistrationForm rg = new RegistrationForm();
            rg.Show();
            this.Hide();
        }
    }
}
