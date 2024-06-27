using Quiz.Controllers;
using Quiz.UserLoginNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

// Manages the sign-up functionality
namespace Quiz.UserSignInNS
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signin_label_Click(object sender, EventArgs e)
        {
            showSignIn();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                User user = new User
                {
                    Name = name_textBox.Text,
                    Email = email_textBox.Text,
                    Phone = phone_textBox.Text,
                    Password = pass_textBox.Text,
                };

                SignInDBController.setUser(user);
                showSignIn();
            }
        }

        private bool ValidateData()
        {
            string errorMessage = string.Empty;
            errorMessage = $"{errorMessage}{Controllers.Validate.isName(name_textBox.Text)}";
            errorMessage = $"{errorMessage}{Controllers.Validate.isEmail(email_textBox.Text)}";
            errorMessage = $"{errorMessage}{Controllers.Validate.isPhone(phone_textBox.Text)}";
            errorMessage = $"{errorMessage}{Controllers.Validate.isPassword(pass_textBox.Text)}";
            Debug.WriteLine("errorMessage: " + errorMessage);
            if (errorMessage != string.Empty)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void showSignIn()
        {
            // Return to the SignIn form
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Dispose();
        }
        
        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            showSignIn();
        }

    }
}
