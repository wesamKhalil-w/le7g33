using System;
using DentalClinic.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Forms
{
    public partial class LoginForm : Form
    {
        private Athservice athService;
        public LoginForm()
        {
            InitializeComponent();
            athService = new Athservice();
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var user = athService.Authenticate(username, password);
            if (user != null)
            {
                this.Hide();
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
            }
            else
            {

                MessageBox.Show("Invalid username or password.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Set default credentials for testing
            txtUsername.Text = "hamza";
            txtPassword.Text = "hamza123";
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

