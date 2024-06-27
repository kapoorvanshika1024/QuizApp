using Microsoft.VisualBasic;
using Quiz.Controllers;
using Quiz.UserLoginNS;
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

// Manages the forgot password functionality
namespace Quiz.UserSignInNS
{
    public partial class ForgotPassword : Form
    {
        private User user;
        public ForgotPassword()
        {
            InitializeComponent();
            user = null;
            pass_textBox.Visible = false;
            pass_label.Visible = false;
        }

        private void signin_label_Click(object sender, EventArgs e)
        {
            showSignIn();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            if (user != null && ValidateData())
            {
                string pass = pass_textBox.Text;
                ForgotPassController.updatePassword(user, pass);
                MessageBox.Show("Password Updated Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showSignIn();
                return;
            }

            if (user == null && ValidateData())
            {
                string email = email_textBox.Text;
                string phone = phone_textBox.Text;
                user = ForgotPassController.getUser(email, phone);
                if (user != null)
                    updateComponents();
                else
                    MessageBox.Show("User not found!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateComponents()
        {
            name_textBox.Text = user.Name;
            pass_textBox.Visible = true;
            pass_label.Visible = true;
            name_textBox.Enabled = false;
            email_textBox.Enabled = false;
            phone_textBox.Enabled = false;
            reset_button.Text = "Reset Password";
        }
        private void showSignIn()
        {
            // Return to the SignIn form
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Dispose();
        }

        private bool ValidateData()
        {
            string errorMessage = string.Empty;
            if (user == null)
            {
                errorMessage = $"{errorMessage}{Controllers.Validate.isName(name_textBox.Text)}";
                errorMessage = $"{errorMessage}{Controllers.Validate.isEmail(email_textBox.Text)}";
                errorMessage = $"{errorMessage}{Controllers.Validate.isPhone(phone_textBox.Text)}";
            }
            else
                errorMessage = $"{errorMessage}{Controllers.Validate.isPassword(pass_textBox.Text)}";

            if (errorMessage != string.Empty)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            showSignIn();
        }
    }
}
