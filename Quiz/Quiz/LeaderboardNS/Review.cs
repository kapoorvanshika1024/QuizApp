using Quiz_Game;
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

namespace Quiz.LeaderboardNS
{
    public partial class Review : Form
    {
        private List<QuizAnswer> quizAnswers;
        private int score;
        public Review(List<QuizAnswer> quizAnswers)
        {
            InitializeComponent();
            this.quizAnswers = quizAnswers;
            score = 0;
            review_dataGridView.DataSource = quizAnswers;
            review_dataGridView.Columns["ID"].Visible = false;
            review_dataGridView.RowPrePaint += review_dataGridView_RowPrePaint;
            review_dataGridView.Refresh();
            updateScore();
        }

        private void updateScore()
        {
            foreach (QuizAnswer answer in quizAnswers)
                if (answer.yourAnswer == answer.correctAnswer) score += 1;
            
            score_label.Text = ("score = " + score + " / " + quizAnswers.Count);
            winning_label.Text = ("Winning(%) = " + ((double)(score*100) / quizAnswers.Count) + "%") ;
        }

        private void review_dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var currentRow = review_dataGridView.Rows[e.RowIndex].DataBoundItem as QuizAnswer;

            bool matched = string.Equals(currentRow?.yourAnswer, currentRow?.correctAnswer);

            review_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = matched ? Color.DarkGreen : Color.DarkRed;
            review_dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
        }
    }
}
