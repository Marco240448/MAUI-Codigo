using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LaApp.Models;
using LaApp.PopUps;
using System.Collections.ObjectModel;

namespace LaApp.ViewModels
{
    public partial class CocheViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Coches> _coches = new();
        [ObservableProperty]
        private Coches? _coche = null;
        [ObservableProperty]
        private string _marca;
        [ObservableProperty]
        private string _modelo;
        [ObservableProperty]
        private string _urlImage; 

        readonly IPopupService popupService;

        public CocheViewModel(IPopupService popupService)
        {
            this.popupService = popupService;
        }

        [RelayCommand]
        private async Task HomeBtn()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        [RelayCommand]
        public async Task DisplayPopup()
        {
            var popup = new CochePopUp(new(popupService));
            IPopupResult<Coches> popupResult = await popupService.ShowPopupAsync<CochePopUpViewModel, Coches>(Shell.Current, PopupOptions.Empty, CancellationToken.None);

            if (!popupResult.WasDismissedByTappingOutsideOfPopup)
            {
                if (popupResult.Result is not null)
                {
                    if (!string.IsNullOrEmpty(popupResult.Result.Marca)
                     && !string.IsNullOrEmpty(popupResult.Result.Modelo))
                    {
                        Coche = popupResult.Result;
                        Coches.Add(Coche);

                        _marca = Coche.Marca;
                        _modelo = Coche.Modelo;
                    }
                }
            }
        }
    }
}


