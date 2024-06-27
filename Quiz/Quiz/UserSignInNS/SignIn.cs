using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz.Controllers;
using Quiz.UserSignInNS;

// Handles the main sign-in form
namespace Quiz.UserLoginNS
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void signup_label_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Dispose();
        }

        private void forgot_label_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Dispose();
        }

        private void signin_button_Click(object sender, EventArgs e)
        {
            string username = email_textBox.Text;
            string password = pass_textBox.Text;
            if (username != "" && password != "")
            {
                if (ValidateData())
                {
                    User user = SignInDBController.getUser(username, password);
                    if (user != null)
                    {
                        Intro intro = new Intro(user);
                        intro.Show();
                        this.Dispose();
                    }
                }
            }
            else MessageBox.Show("Enter complete details first...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateData()
        {
            string errorMessage = string.Empty;

            string email = Controllers.Validate.isEmail(email_textBox.Text);
            string phone = Controllers.Validate.isPhone(email_textBox.Text);
            if (!email.Equals("") && !phone.Equals(""))
            {
                errorMessage = $"{email}{phone}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
