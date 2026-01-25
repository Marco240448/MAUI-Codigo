using LaApp.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace LaApp
{
    public partial class App : Application
    {
        LoginPage _loginPage;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _loginPage = serviceProvider.GetService<LoginPage>();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}