using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz.Second;

// Manages the introductory form
namespace Quiz
{
    public partial class Intro : Form
    {
        private User user = null;
        public Intro(User user)
        {
            this.user = user;
            InitializeComponent();
            welcome_label.Text = $"Welcome, {user.Name}";
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Second.Second second = new Second.Second(gameType_box.SelectedQuiz.name,user);
            second.Show();
            this.Dispose();
        }

        private void Intro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
