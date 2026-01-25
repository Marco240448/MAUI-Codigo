namespace LaApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Pages.LoginPage), typeof(Pages.LoginPage));
            Routing.RegisterRoute(nameof(Pages.HomePage), typeof(Pages.HomePage));
            Routing.RegisterRoute(nameof(Pages.ConversorPage), typeof(Pages.ConversorPage));
            Routing.RegisterRoute(nameof(Pages.CochePage), typeof(Pages.CochePage));
            Routing.RegisterRoute(nameof(Pages.ProfilePage), typeof(Pages.ProfilePage));
        }
    }
}
