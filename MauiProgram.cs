using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;

namespace OMRApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.ConfigureMauiHandlers(handlers =>
        {
#if ANDROID
            ToolbarHandler.Mapper.AppendToMapping("CustomNavigationBar", (handler, view) =>
            {
                if (handler.PlatformView is AndroidX.AppCompat.Widget.Toolbar toolbar) // Fully qualified name
                {
                    toolbar.SetBackgroundColor(Android.Graphics.Color.ParseColor("#ff5733")); // Fully qualified name
                }
            });
#endif
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif


        return builder.Build();
    }
}
