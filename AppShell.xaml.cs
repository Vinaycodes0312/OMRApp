using Microsoft.Maui.Controls;
using OMRApp.Views;

namespace OMRApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(OMRPage), typeof(OMRPage));
            Routing.RegisterRoute(nameof(ReviewPage), typeof(ReviewPage));
        }
    }
}
