using System.Collections.Generic;
using OMRApp.Models;

namespace OMRApp.Services
{
    public class DataService
    {
        private static readonly List<QuestionModel> _questions = new();

        public static void Initialize(int count)
        {
            _questions.Clear();
            for (int i = 1; i <= count; i++)
            {
                _questions.Add(new QuestionModel { Number = i, SelectedAnswer = "" });
            }
        }

        public static List<QuestionModel> GetQuestions() => _questions;

        public static void SaveAnswer(int questionNumber, string answer)
        {
            var question = _questions.Find(q => q.Number == questionNumber);
            if (question != null)
            {
                question.SelectedAnswer = answer;
            }
        }
    }
}
