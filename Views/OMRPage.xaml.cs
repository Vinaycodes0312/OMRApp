using Microsoft.Maui.Controls;
using OMRApp.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace OMRApp.Views
{
    public partial class OMRPage : ContentPage
    {
        private readonly ObservableCollection<QuestionModel> _questions;

        public OMRPage(int totalQuestions)
        {
            InitializeComponent();
            _questions = new ObservableCollection<QuestionModel>();
            for (int i = 1; i <= totalQuestions; i++)
            {
                _questions.Add(new QuestionModel { QuestionNumber = i });
            }
            OMRCollectionView.ItemsSource = _questions;
        }


        private async void OnReviewClicked(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(_questions);
            Preferences.Set("OMRResponses", json); // Save responses locally
            await Navigation.PushAsync(new ReviewPage());
        }
    }
}
