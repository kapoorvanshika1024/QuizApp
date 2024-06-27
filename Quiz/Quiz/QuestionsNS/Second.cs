using Quiz.Controllers;
using Quiz.UserLoginNS;
using Quiz_Game;
using Quiz_Game.DB;
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

namespace Quiz.Second
{
    public partial class Second : Form
    {
        private QuestionController controller;
        private List<QuizAnswer> answers;
        private string selectedOption;
        private QuizQuestion q;
        private User user;
        private int score;

        public Second(string quizType, User user)
        {
            InitializeComponent();
            controller = new QuestionController(quizType);
            answers = new List<QuizAnswer>();
            selectedOption = null;
            q = null;
            this.user = user;
            score = 0;

            this.Text = quizType;

            A_radioButton.CheckedChanged += radioButton_CheckedChanged;
            B_radioButton.CheckedChanged += radioButton_CheckedChanged;
            C_radioButton.CheckedChanged += radioButton_CheckedChanged;
            D_radioButton.CheckedChanged += radioButton_CheckedChanged;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                selectedOption = radioButton.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (controller.isNextQue()) setQuestion();
            else timer_label.Text = controller.getCountdown().ToString("00");
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            setQuestion();
        }

        private void setQuestion()
        {
            if (q != null)
            {
                answers.Add(new QuizAnswer(q.ID, q.question, selectedOption, q.correctAnswer));
                if (selectedOption == q.correctAnswer) { score += 1; }
            }
            if (controller.getTotalQuestions() > controller.getQuestionNo())
            {
                controller.resetCountdown();
                q = controller.getQuestion();
                setQuestionData();
                resetComponentValues();
                timer_label.Text = controller.getCountdown().ToString("00");
            }
            else
            {
                timer1.Dispose();
                setDataInDB();
                LeaderboardNS.Leaderboard leaderboard = new LeaderboardNS.Leaderboard(user, answers);
                leaderboard.Show();
                this.Dispose();
            }
        }

        private void setDataInDB()
        {
            using (QuizDBEntitie context = new QuizDBEntitie())
            {
                var us = context.Users.FirstOrDefault(u => u.ID == user.ID);

                int totalQuestions = us.Total_Questions;
                int totalAnswers = us.Total_Answers;

                int newQuestions = controller.getTotalQuestions();
                int newAnswers = score;

                totalQuestions += newQuestions;
                totalAnswers += newAnswers;

                us.Total_Questions = totalQuestions;
                us.Total_Answers = totalAnswers;
                us.Winning_Percentage = ((totalAnswers * 100) / totalQuestions);

                context.SaveChanges();
            }
        }
        private void setQuestionData()
        {
            Q_label.Text = "Question " + (controller.getQuestionNo())
                            + " of " + (controller.getTotalQuestions());
            question_textBox.Text = q.question;
            A_radioButton.Text = q.optionA;
            B_radioButton.Text = q.optionB;
            C_radioButton.Text = q.optionC;
            D_radioButton.Text = q.optionD;
        }

        private void resetComponentValues()
        {
            selectedOption = null;
            A_radioButton.Checked = false;
            B_radioButton.Checked = false;
            C_radioButton.Checked = false;
            D_radioButton.Checked = false;
        }

        private void Second_FormClosing(object sender, FormClosingEventArgs e)
        {
            Intro intro = new Intro(user);
            intro.Show();
            this.Dispose();
        }
    }
}
