using Microsoft.Maui.Controls;

namespace OMRApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            if (int.TryParse(TotalQuestionsEntry.Text, out int totalQuestions) && totalQuestions > 0)
            {
                await Navigation.PushAsync(new OMRPage(totalQuestions));
            }
            else
            {
                await DisplayAlert("Error", "Please enter a valid number of questions.", "OK");
            }
        }
    }
}
