using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Represents a quiz question
namespace Quiz_Game
{
    public class QuizQuestion
    {
        public QuizQuestion() { }
        public QuizQuestion(int id, string question, string optionA, string optionB,
            string optionC, string optionD, string correctAnswer)
        {
            ID = id;
            this.question = question;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            this.correctAnswer = correctAnswer;
        }
        public int ID { get; set; }
        public string question { get; set; }
        public string optionA { get; set; }
        public string optionB { get; set; }
        public string optionC { get; set; }
        public string optionD { get; set; }
        public string correctAnswer { get; set; }
        public string type { get; set; }

    }
}
