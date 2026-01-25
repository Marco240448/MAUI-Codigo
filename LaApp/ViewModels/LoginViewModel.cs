using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaApp.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _user = "Marco";
        [ObservableProperty]
        private string _password = "1234";

        [RelayCommand]
        private async Task LoginBtn()
        {
            if (User == "Marco" && Password == "1234")
            {
                _user = string.Empty;
                _password = string.Empty;
                await Shell.Current.GoToAsync("//HomePage");
            }
            else
            {
                _user = string.Empty;
                _password = string.Empty;
                await Shell.Current.DisplayAlertAsync("Error", "Usuario o contraseña incorrectos", "Aceptar");
            }
        }
    }
}
