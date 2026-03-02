using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LaApp.Pages;

namespace LaApp.ViewModels
{
    public partial class ProfileViewModel : ObservableObject
    {
        private LoginPage loginPage;

        [ObservableProperty]
        private string _user;

        public ProfileViewModel(LoginPage loginPage, LoginViewModel loginViewModel)
        {
            this.loginPage = loginPage;
            _user = loginViewModel.User;
        }

        [RelayCommand]
        private async Task LogOutBtn()
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
