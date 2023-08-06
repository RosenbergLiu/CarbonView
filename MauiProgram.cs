using Microsoft.Extensions.Logging;
using GreenITBlazor.Services;
using Radzen;
using CommunityToolkit.Maui;

namespace GreenITBlazor;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        }).UseMauiCommunityToolkit();
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddScoped<DialogService>();
        builder.Services.AddScoped<NotificationService>();
        builder.Services.AddScoped<TooltipService>();
        builder.Services.AddScoped<ContextMenuService>();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<BillsDBService>();
        builder.Services.AddSingleton<ActivitiesDBService>();
        builder.Services.AddSingleton<ApiService>();

        Preferences.Default.Set("loggedin", false);

        return builder.Build();
    }
}