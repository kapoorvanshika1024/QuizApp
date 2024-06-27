using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Represents a user's answer to a quiz question

namespace Quiz_Game
{
    public class QuizAnswer
    {
        public QuizAnswer(int id, string question, string yourAnswer, string correctAnswer)
        {
            this.ID = id;
            this.question = question;
            this.yourAnswer = yourAnswer;
            this.correctAnswer = correctAnswer;
        }
        public int ID { get; set; }
        public string question { get; set; }
        public string yourAnswer { get; set; }
        public string correctAnswer { get; set; }
    }
}
