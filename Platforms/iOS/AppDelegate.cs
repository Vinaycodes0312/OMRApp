using Foundation;
using UIKit;

namespace OMRApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();


    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(255, 87, 51); // Change to your color
        UINavigationBar.Appearance.TintColor = UIColor.White; // Set text color
        UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes { TextColor = UIColor.White });

        return base.FinishedLaunching(app, options);
    }
}