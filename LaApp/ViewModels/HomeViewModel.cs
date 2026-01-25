using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task ConversorBtn()
        {
            await Shell.Current.GoToAsync("//ConversorPage");
        }

        [RelayCommand]
        private async Task CocheBtn()
        {
            await Shell.Current.GoToAsync("//CochePage");
        }
    }
}
