using Quiz.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Controls the flow of quiz questions
namespace Quiz_Game.DB
{
    internal class QuestionController
    {
        // List of shuffled quiz questions
        List<QuizQuestion> question;
        int countdown;
        int index;

        // Constructor initializes the quiz
        public QuestionController(string quizType)
        {
            question = shuffleQuestions(QuestionDBController.LoadData(quizType));
            index = 0;
            countdown = 1;
        }
        // Checks if there is a next question
        public bool isNextQue()
        {
            if (countdown == 0) return true;
            return false;
        }

        // Decrements countdown and returns the value
        public int getCountdown()
        {
            return countdown -= 1;
        }


        // Resets countdown to 11
        public void resetCountdown()
        {
            countdown = 11;
        }

        // Gets the next quiz question
        public QuizQuestion getQuestion()
        {
            return question.ElementAt(index++);
        }
        // Returns the current question number
        public int getQuestionNo()
        {
            return index;
        }
        // Returns the total number of questions
        public int getTotalQuestions()
        {
            return question.Count();
        }
        // Shuffles the list of questions randomly
        private static List<QuizQuestion> shuffleQuestions(List<QuizQuestion> questions)
        {
            Random random = new Random();
            return questions.OrderBy(q => random.Next()).ToList();
        }
    }
}
