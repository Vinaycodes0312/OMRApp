using Microsoft.Maui.Controls;
using OMRApp.Views;

namespace OMRApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new HomePage());
        }
    }
}
