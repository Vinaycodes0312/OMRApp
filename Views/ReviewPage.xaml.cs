using Microsoft.Maui.Controls;
using OMRApp.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace OMRApp.Views
{
    public partial class ReviewPage : ContentPage
    {
        private ObservableCollection<QuestionModel> _reviewQuestions;

        public ReviewPage()
        {
            InitializeComponent();
            string json = Preferences.Get("OMRResponses", "[]");
            var savedQuestions = JsonSerializer.Deserialize<ObservableCollection<QuestionModel>>(json) ?? new ObservableCollection<QuestionModel>();

            foreach (var question in savedQuestions)
            {
                question.SelectedAnswer = ReviewPage.GetSelectedAnswer(question);
            }
                
            _reviewQuestions = savedQuestions;
            ReviewCollectionView.ItemsSource = _reviewQuestions;
        }

        private static string GetSelectedAnswer(QuestionModel question)
        {
            if (question.IsASelected) return "A";
            if (question.IsBSelected) return "B";
            if (question.IsCSelected) return "C";
            if (question.IsDSelected) return "D";
            return "Not Answered";
        }
    }
}
