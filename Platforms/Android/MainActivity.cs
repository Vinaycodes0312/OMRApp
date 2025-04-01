using Android.App;
using Android.OS;
using Android.Views;
using Microsoft.Maui;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges =
    Android.Content.PM.ConfigChanges.ScreenSize |
    Android.Content.PM.ConfigChanges.Orientation |
    Android.Content.PM.ConfigChanges.UiMode |
    Android.Content.PM.ConfigChanges.ScreenLayout |
    Android.Content.PM.ConfigChanges.SmallestScreenSize)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#ff5733")); // Custom color
    }
}
