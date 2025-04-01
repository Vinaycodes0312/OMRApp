using System.Collections.ObjectModel;
using OMRApp.Models;  // 🔥 Fix: Added missing namespace
using OMRApp.ViewModels;

namespace OMRApp.ViewModels;

public class ReviewViewModel
{
    public ObservableCollection<QuestionModel> Questions { get; set; }

    public ReviewViewModel()
    {
        Questions = new ObservableCollection<QuestionModel>
        {
            new QuestionModel { Number = 1, QuestionText = "What is 2 + 2?", SelectedAnswer = "B", CorrectAnswer = "B" },
            new QuestionModel { Number = 2, QuestionText = "What is the capital of India?", SelectedAnswer = "A", CorrectAnswer = "A" },
            new QuestionModel { Number = 3, QuestionText = "What is the square root of 16?", SelectedAnswer = "C", CorrectAnswer = "C" }
        };
    }
}
