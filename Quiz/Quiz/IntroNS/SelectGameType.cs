using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Handles the selection of quiz types
namespace Quiz_Game
{
    public partial class SelectGameType : UserControl
    {
        public SelectGameType()
        {
            InitializeComponent();
        }

        public AvailableQuiz SelectedQuiz
        {
            get
            {
                return (AvailableQuiz)comboBox.SelectedItem;
            }
        }


        private void SelectGameType_Load(object sender, EventArgs e)
        {
            List<AvailableQuiz> availableQuiz = new List<AvailableQuiz>();
            availableQuiz.Add(new AvailableQuiz() { ID = 1, name = "English" });
            availableQuiz.Add(new AvailableQuiz() { ID = 2, name = "General Knowledge" });
            availableQuiz.Add(new AvailableQuiz() { ID = 3, name = "History" });
            availableQuiz.Add(new AvailableQuiz() { ID = 4, name = "Science" });
            availableQuiz.Add(new AvailableQuiz() { ID = 5, name = "Technology" });
            comboBox.DataSource = availableQuiz;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "Name";
        }
    }
}
