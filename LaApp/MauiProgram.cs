using CommunityToolkit.Maui;
using LaApp.Pages;
using LaApp.ViewModels;
using LaApp.PopUps;
using Microsoft.Extensions.Logging;
using LaApp.Views;

namespace LaApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<ConversorViewModel>();
            builder.Services.AddTransient<ConversorPage>();
            builder.Services.AddTransient<CocheViewModel>();
            builder.Services.AddTransient<CochePage>();
            builder.Services.AddTransient<ProfileViewModel>();
            builder.Services.AddTransient<ProfilePage>();

            builder.Services.AddTransientPopup<CochePopUp, CochePopUpViewModel>();

            builder.Services.AddTransient<EntryView>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
