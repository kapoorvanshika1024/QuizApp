using Quiz.UserLoginNS;
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
using System.Windows.Forms.DataVisualization.Charting;

// Manages the leaderboard display
namespace Quiz.LeaderboardNS
{
    public partial class Leaderboard : Form
    {
        private User user = null;
        private List<QuizAnswer> quizAnswers;
        public Leaderboard(User user, List<QuizAnswer> quizAnswers)
        {
            InitializeComponent();
            this.user = user;
            this.quizAnswers = quizAnswers;
            using (QuizDBEntitie context = new QuizDBEntitie())
            {
                List<User> users = context.Users.ToList();
                List<User> sortedUser = users.OrderByDescending(u => u.Winning_Percentage).ToList();
                setGridData(sortedUser);
                setChartData(sortedUser);
            }
        }

        private void setChartData(List<User> sortedUser)
        {
            foreach (User user in sortedUser)
            {
                Series series = new Series(user.Name);
                series.ChartType = SeriesChartType.Column;
                series.Points.AddXY("Global Users", user.Winning_Percentage);
                result_chart.Series.Add(series);
            }
        }

        private void setGridData(List<User> sortedUser)
        {
            result_dataGridView.DataSource = sortedUser;
            result_dataGridView.Columns["ID"].Visible = false;
            result_dataGridView.Columns["Email"].Visible = false;
            result_dataGridView.Columns["Phone"].Visible = false;
            result_dataGridView.Columns["Password"].Visible = false;
            result_dataGridView.Columns["Total_Questions"].Visible = false;
            result_dataGridView.Columns["Total_Answers"].Visible = false;
            result_dataGridView.RowPrePaint += result_dataGridView_RowPrePaint;
            result_dataGridView.Refresh();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro(user);
            intro.Show();
            this.Dispose();
        }

        private void Leaderboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            home_btn.PerformClick();
        }

        private void result_dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            string nameValue = result_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (nameValue == this.user.Name)
            {
                result_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green; 
                result_dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void review_btn_Click(object sender, EventArgs e)
        {
            Review review = new Review(quizAnswers);   
            review.Show();
        }
    }
}
