using Quiz_Game;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Handles loading quiz questions from the database
namespace Quiz.Controllers
{
    internal class QuestionDBController
    {
        // Loads quiz questions based on quiz type
        public static List<QuizQuestion> LoadData(string quizType)
        {

            using (QuizDBEntitie DB = new QuizDBEntitie())
            {
                // LINQ query to select quiz questions from the database
                var query = from q in DB.Questions
                             where q.Type == quizType.Trim()
                             select new QuizQuestion
                             {
                                 ID = q.ID,
                                 question = q.Question1,
                                 optionA = q.OptionA,
                                 optionB = q.OptionB,
                                 optionC = q.OptionC,
                                 optionD = q.OptionD,
                                 correctAnswer = q.CorrectAnswer,
                                 type = q.Type,
                             };

                return query.ToList();
            }
        }
    }
}
