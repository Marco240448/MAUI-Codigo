using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LaApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaApp.ViewModels
{
    public partial class CochePopUpViewModel : ObservableObject
    {
        private int _id;

        [ObservableProperty]
        private Coches _coche = new();

        readonly IPopupService popupService;

        public CochePopUpViewModel(IPopupService popupService)
        {
            this.popupService = popupService;
        }

        [RelayCommand]
        public async Task Cancel()
        {
            await popupService.ClosePopupAsync(Shell.Current);
        }

        [RelayCommand]
        public async Task Save()
        {
            await popupService.ClosePopupAsync(Shell.Current, _coche);
        }
    }
}

